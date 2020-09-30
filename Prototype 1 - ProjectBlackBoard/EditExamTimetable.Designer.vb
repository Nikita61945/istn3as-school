<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditExamTimetable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.ExamTT = New System.Windows.Forms.DataGridView()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionTwo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ExamTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(677, 526)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 36)
        Me.Button4.TabIndex = 18
        Me.Button4.Text = "Update Timetable"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Location = New System.Drawing.Point(34, 526)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(137, 36)
        Me.CloseBtn.TabIndex = 17
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Papers"
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.BackColor = System.Drawing.SystemColors.Control
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel.Location = New System.Drawing.Point(35, 61)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(222, 439)
        Me.panel.TabIndex = 15
        '
        'ExamTT
        '
        Me.ExamTT.AllowDrop = True
        Me.ExamTT.AllowUserToAddRows = False
        Me.ExamTT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.ExamTT.BackgroundColor = System.Drawing.SystemColors.Window
        Me.ExamTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExamTT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Day, Me.SessionOne, Me.SessionTwo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ExamTT.DefaultCellStyle = DataGridViewCellStyle1
        Me.ExamTT.Location = New System.Drawing.Point(272, 47)
        Me.ExamTT.Name = "ExamTT"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExamTT.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ExamTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ExamTT.Size = New System.Drawing.Size(542, 453)
        Me.ExamTT.TabIndex = 14
        '
        'Day
        '
        Me.Day.HeaderText = "Day/Date"
        Me.Day.Name = "Day"
        Me.Day.Width = 130
        '
        'SessionOne
        '
        Me.SessionOne.HeaderText = "Session One"
        Me.SessionOne.Name = "SessionOne"
        Me.SessionOne.Width = 190
        '
        'SessionTwo
        '
        Me.SessionTwo.HeaderText = "Session Two"
        Me.SessionTwo.Name = "SessionTwo"
        Me.SessionTwo.Width = 190
        '
        'EditExamTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 608)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.ExamTT)
        Me.Name = "EditExamTimetable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditExamTimetable"
        CType(Me.ExamTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents panel As Panel
    Friend WithEvents ExamTT As DataGridView
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents SessionOne As DataGridViewTextBoxColumn
    Friend WithEvents SessionTwo As DataGridViewTextBoxColumn
End Class
