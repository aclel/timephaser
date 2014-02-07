Module TimePhaser

    Public Function FindTimeIntervals(ByVal startTime As Date, ByVal endTime As Date, ByVal interval As String) As Array
        ' Comments: Finds the time intervals which exist between a start time and end time, based upon a specified interval.
        ' Parameters:   interval - A String which represents the interval to split the time period over. "d" represents days, 
        '                          "h" represents hours and "m" represents minutes.
        '               startTime - The start of the time period.
        '               endTime - The end of the time period.
        ' Returns: An array which contains the intervals, or part thereof, which exist between the start time and end time.

        Dim intervals As Array = {}

        Dim nextInterval As Nullable(Of Date) = FindNextInterval(startTime, interval)
        Dim lastInterval As Nullable(Of Date) = FindLastInterval(endTime, interval)

        ' If any time remains befor the next interval, add it to the array
        Dim remainingTime = RemainingTimeInBeginningInterval(startTime, nextInterval, interval)
        Dim i As Integer = 0
        If remainingTime <> 0 Then
            intervals(i) = remainingTime
            i = 1
        End If

        ' Add all whole intervals up until the start of the last interval
        intervals = FindWholeIntervals(nextInterval, lastInterval, intervals, i, interval)

        ' Add time remaining before endTime
        remainingTime = RemainingTimeInLastInterval(endTime, lastInterval, interval)
        i = intervals.Length
        If remainingTime <> 0 Then
            intervals(i) = remainingTime
        End If

        Return intervals
    End Function

    Public Function FindNextInterval(ByVal time As Date, ByVal interval As String) As Nullable(Of Date)
        ' Comments: Finds the date object which represents the start of the next interval.
        ' Parameters: time - The start time.
        '             interval - The interval used to split the time period.

        ' The next interval
        Dim nextInterval As Nullable(Of Date) = Nothing

        ' Add whole interval to the time to get the next interval, then remove lower orders to find the start.
        ' Subtract the current time from the start of the next interval to find the remaining time in the interval.
        If interval Is "d" And time.Hour <> 0 Then
            nextInterval = New Date(time.Year, time.Month, time.Day + 1)
        ElseIf interval Is "h" And time.Minute <> 0 Then
            nextInterval = New Date(time.Year, time.Month, time.Day, time.Hour + 1, 0, 0)
        ElseIf interval Is "m" And time.Second <> 0 Then
            nextInterval = New Date(time.Year, time.Month, time.Day, time.Hour, time.Minute + 1, 0)
        End If

        Return nextInterval
    End Function

    Public Function FindLastInterval(ByVal time As Date, ByVal interval As String) As Nullable(Of Date)
        ' Comments: Finds the date object which represents the start of the last interval.
        ' Parameters: time - The end time.
        '             interval - The interval used to split the time period.

        ' The last interval
        Dim lastInterval As Nullable(Of Date) = Nothing

        If interval Is "d" And time.Hour <> 0 Then
            lastInterval = New Date(time.Year, time.Month, time.Day)
        ElseIf interval Is "h" And time.Minute <> 0 Then
            lastInterval = New Date(time.Year, time.Month, time.Day, time.Hour, 0, 0)
        ElseIf interval Is "m" And time.Second <> 0 Then
            lastInterval = New Date(time.Year, time.Month, time.Day, time.Hour, time.Minute, 0)
        End If

        Return lastInterval
    End Function

    Public Function RemainingTimeInBeginningInterval(ByVal startTime As Date, ByVal nextInterval As Nullable(Of Date), _
                                                     ByVal interval As String) As Double
        ' Comments: Finds the fraction of the current interval which remains until the next interval.
        ' Parameters: startTime - The start time.
        '             nextInterval - The Date which represents the beginning of the next interval.
        '             interval - The interval over which to find the fraction
        ' Returns: A fraction which represents the remaining time in the current interval.

        ' The remaining time in the interval
        Dim remainingTime As TimeSpan
        If nextInterval IsNot Nothing Then
            remainingTime = nextInterval - startTime
            Return PartOfIntervalRemaining(remainingTime, interval)
        Else
            Return 0
        End If
    End Function

    Public Function RemainingTimeInLastInterval(ByVal endTime As Date, ByVal lastInterval As Nullable(Of Date), _
                                                ByVal interval As String) As Double
        ' Comments: Finds the fraction of the interval remaining between the start of the last interval and the endTime
        ' Parameters : endTime - The end time.
        '              lastInterval - The Date which represents the beginning of the last interval.
        ' Returns: A fraction which represents the remaining time in the last interval.
        Dim remainingTime As TimeSpan
        If lastInterval IsNot Nothing Then
            remainingTime = endTime - lastInterval
            Return PartOfIntervalRemaining(remainingTime, interval)
        Else
            Return 0
        End If
    End Function

    Public Function PartOfIntervalRemaining(ByVal remainingTime As TimeSpan, ByVal interval As String) As Double
        ' Comments: Computes the fraction of the remaining time in an interval.
        ' Parameters: remainingTime - The amount of time remaining in the interval.
        ' Returns: The remainingTime divided by the number elements in the interval which is one order lower

        Const hoursInDay = 24
        Const minutesInHour = 60
        Const secondsInMinute = 60
        Dim fractionOfInterval As Double

        If interval Is "d" Then
            fractionOfInterval = remainingTime.Hours / hoursInDay
        ElseIf interval Is "h" Then
            fractionOfInterval = remainingTime.Minutes / minutesInHour
        ElseIf interval Is "m" Then
            fractionOfInterval = remainingTime.Seconds / secondsInMinute
        End If

        Return fractionOfInterval
    End Function

    Public Function FindWholeIntervals(ByVal nextInterval As Nullable(Of Date), ByVal lastInterval As Nullable(Of Date), _
                                      ByVal intervals As Array, ByVal i As Integer, ByVal interval As String) As Array
        ' Comments: Finds the number of whole intervals between the start of the first full interval and the beginning of the last interval.
        '           They are then added to the given array.
        ' Parameters: nextInterval - The start of the next whole interval.
        '             lastInterval - The start of the last interval.
        '             intervals - The array of time periods.
        '             interval - The interval used to splut the time period.
        ' Returns: An array containing the intervals over the time period.

        Dim startInterval As Integer
        Dim endInterval As Integer

        ' Finds the start and end of the whole intervals
        If interval Is "d" Then
            startInterval = nextInterval.Value.DayOfYear
            endInterval = nextInterval.Value.DayOfYear
        ElseIf interval Is "h" Then
            startInterval = nextInterval.Value.Hour
            endInterval = nextInterval.Value.Hour
        ElseIf interval Is "m" Then
            startInterval = nextInterval.Value.Minute
            endInterval = nextInterval.Value.Minute
        End If

        ' Add whole intervals to the array
        For start As Integer = startInterval To endInterval
            intervals(i) = 1
            i += 1
        Next

        Return intervals
    End Function
End Module
