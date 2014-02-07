<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.startLabel = New System.Windows.Forms.Label()
        Me.endLabel = New System.Windows.Forms.Label()
        Me.startDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.endDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IntervalTextBox = New System.Windows.Forms.RichTextBox()
        Me.TimeIntervalButton = New System.Windows.Forms.Button()
        Me.intervalComboBox = New System.Windows.Forms.ComboBox()
        Me.intervalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startLabel
        '
        Me.startLabel.AutoSize = True
        Me.startLabel.Location = New System.Drawing.Point(12, 32)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(78, 13)
        Me.startLabel.TabIndex = 2
        Me.startLabel.Text = "Start DateTime"
        '
        'endLabel
        '
        Me.endLabel.AutoSize = True
        Me.endLabel.Location = New System.Drawing.Point(12, 63)
        Me.endLabel.Name = "endLabel"
        Me.endLabel.Size = New System.Drawing.Size(75, 13)
        Me.endLabel.TabIndex = 3
        Me.endLabel.Text = "End DateTime"
        '
        'startDateTimePicker
        '
        Me.startDateTimePicker.Location = New System.Drawing.Point(95, 28)
        Me.startDateTimePicker.Name = "startDateTimePicker"
        Me.startDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.startDateTimePicker.TabIndex = 4
        '
        'endDateTimePicker
        '
        Me.endDateTimePicker.Location = New System.Drawing.Point(95, 59)
        Me.endDateTimePicker.Name = "endDateTimePicker"
        Me.endDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.endDateTimePicker.TabIndex = 5
        '
        'IntervalTextBox
        '
        Me.IntervalTextBox.Location = New System.Drawing.Point(15, 124)
        Me.IntervalTextBox.Name = "IntervalTextBox"
        Me.IntervalTextBox.ReadOnly = True
        Me.IntervalTextBox.Size = New System.Drawing.Size(519, 142)
        Me.IntervalTextBox.TabIndex = 6
        Me.IntervalTextBox.Text = ""
        '
        'TimeIntervalButton
        '
        Me.TimeIntervalButton.Location = New System.Drawing.Point(15, 95)
        Me.TimeIntervalButton.Name = "TimeIntervalButton"
        Me.TimeIntervalButton.Size = New System.Drawing.Size(147, 23)
        Me.TimeIntervalButton.TabIndex = 7
        Me.TimeIntervalButton.Text = "Find Time Intervals"
        Me.TimeIntervalButton.UseVisualStyleBackColor = True
        '
        'intervalComboBox
        '
        Me.intervalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.intervalComboBox.FormattingEnabled = True
        Me.intervalComboBox.Items.AddRange(New Object() {"Days", "Hours", "Minutes"})
        Me.intervalComboBox.Location = New System.Drawing.Point(365, 26)
        Me.intervalComboBox.Name = "intervalComboBox"
        Me.intervalComboBox.Size = New System.Drawing.Size(121, 21)
        Me.intervalComboBox.TabIndex = 8
        '
        'intervalLabel
        '
        Me.intervalLabel.AutoSize = True
        Me.intervalLabel.Location = New System.Drawing.Point(317, 29)
        Me.intervalLabel.Name = "intervalLabel"
        Me.intervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.intervalLabel.TabIndex = 9
        Me.intervalLabel.Text = "Interval"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 278)
        Me.Controls.Add(Me.intervalLabel)
        Me.Controls.Add(Me.intervalComboBox)
        Me.Controls.Add(Me.TimeIntervalButton)
        Me.Controls.Add(Me.IntervalTextBox)
        Me.Controls.Add(Me.endDateTimePicker)
        Me.Controls.Add(Me.startDateTimePicker)
        Me.Controls.Add(Me.endLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Name = "TestForm"
        Me.Text = "TestForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startLabel As System.Windows.Forms.Label
    Friend WithEvents endLabel As System.Windows.Forms.Label
    Friend WithEvents startDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents endDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IntervalTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TimeIntervalButton As System.Windows.Forms.Button
    Friend WithEvents intervalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents intervalLabel As System.Windows.Forms.Label
End Class
