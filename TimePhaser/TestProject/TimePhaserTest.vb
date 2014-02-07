Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports TimePhaser



'''<summary>
'''This is a test class for TimePhaserTest and is intended
'''to contain all TimePhaserTest Unit Tests
'''</summary>
<TestClass()> _
Public Class TimePhaserTest


    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = Value
        End Set
    End Property

#Region "Additional test attributes"
    '
    'You can use the following additional attributes as you write your tests:
    '
    'Use ClassInitialize to run code before running the first test in the class
    '<ClassInitialize()>  _
    'Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    'End Sub
    '
    'Use ClassCleanup to run code after all tests in a class have run
    '<ClassCleanup()>  _
    'Public Shared Sub MyClassCleanup()
    'End Sub
    '
    'Use TestInitialize to run code before running each test
    '<TestInitialize()>  _
    'Public Sub MyTestInitialize()
    'End Sub
    '
    'Use TestCleanup to run code after each test has run
    '<TestCleanup()>  _
    'Public Sub MyTestCleanup()
    'End Sub
    '
#End Region


    '''<summary>
    '''A test for FindTimeIntervals
    '''</summary>
    <TestMethod()> _
    Public Sub FindTimeIntervalsTest()
        Dim startTime As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim endTime As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Array = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Array
        actual = TimePhaser.FindTimeIntervals(startTime, endTime, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for FindLastInterval
    '''</summary>
    <TestMethod()> _
    Public Sub FindLastIntervalTest()
        Dim time As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim actual As Nullable(Of DateTime)
        actual = TimePhaser.FindLastInterval(time, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for FindNextInterval
    '''</summary>
    <TestMethod()> _
    Public Sub FindNextIntervalTest()
        Dim time As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim actual As Nullable(Of DateTime)
        actual = TimePhaser.FindNextInterval(time, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for FindWholeIntervals
    '''</summary>
    <TestMethod()> _
    Public Sub FindWholeIntervalsTest()
        Dim nextInterval As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim lastInterval As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim intervals As Array = Nothing ' TODO: Initialize to an appropriate value
        Dim i As Integer = 0 ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Array = Nothing ' TODO: Initialize to an appropriate value
        Dim actual As Array
        actual = TimePhaser.FindWholeIntervals(nextInterval, lastInterval, intervals, i, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for PartOfIntervalRemaining
    '''</summary>
    <TestMethod()> _
    Public Sub PartOfIntervalRemainingTest()
        Dim remainingTime As TimeSpan = New TimeSpan() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = TimePhaser.PartOfIntervalRemaining(remainingTime, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for RemainingTimeInBeginningInterval
    '''</summary>
    <TestMethod()> _
    Public Sub RemainingTimeInBeginningIntervalTest()
        Dim startTime As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim nextInterval As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = TimePhaser.RemainingTimeInBeginningInterval(startTime, nextInterval, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub

    '''<summary>
    '''A test for RemainingTimeInLastInterval
    '''</summary>
    <TestMethod()> _
    Public Sub RemainingTimeInLastIntervalTest()
        Dim endTime As DateTime = New DateTime() ' TODO: Initialize to an appropriate value
        Dim lastInterval As Nullable(Of DateTime) = New Nullable(Of DateTime)() ' TODO: Initialize to an appropriate value
        Dim interval As String = String.Empty ' TODO: Initialize to an appropriate value
        Dim expected As Double = 0.0! ' TODO: Initialize to an appropriate value
        Dim actual As Double
        actual = TimePhaser.RemainingTimeInLastInterval(endTime, lastInterval, interval)
        Assert.AreEqual(expected, actual)
        Assert.Inconclusive("Verify the correctness of this test method.")
    End Sub
End Class
