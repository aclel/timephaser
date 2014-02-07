Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Class TestForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitializeTimePickers()

        intervalComboBox.SelectedIndex = 0

    End Sub

    Private Sub InitializeTimePickers()
        startDateTimePicker.Format = DateTimePickerFormat.Time
        endDateTimePicker.Format = DateTimePickerFormat.Time
    End Sub

    Private Sub TimeIntervalButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeIntervalButton.Click
        IntervalTextBox.Clear()
        Dim intervals As ArrayList = TimePhaser.FindTimeIntervals(startDateTimePicker.Value, endDateTimePicker.Value, ConvertComboBoxValue(intervalComboBox.SelectedItem))
        For Each value In intervals
            If value IsNot Nothing Then
                IntervalTextBox.AppendText(value & ", ")
            End If
        Next
    End Sub

    Private Function ConvertComboBoxValue(ByVal value As String) As String
        If value = "Days" Then
            Return "d"
        ElseIf value = "Hours" Then
            Return "h"
        ElseIf value = "Minutes" Then
            Return "m"
        End If
    End Function
End Class