<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateExamTimeTable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateExamTimeTable))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ExamTT = New System.Windows.Forms.DataGridView()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionOne = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionTwo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ExamTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(100, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        Me.DateTimePicker1.Value = New Date(2019, 8, 8, 16, 2, 5, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(100, 69)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Start Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "End Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Exam Dates "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(318, 38)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Set Exam Date"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(211, 152)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Session One Times "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 104)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(199, 38)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Set Session One"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "HH:mm"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(100, 31)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.ShowUpDown = True
        Me.DateTimePicker3.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker3.TabIndex = 0
        Me.DateTimePicker3.Value = New Date(2019, 8, 15, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "End Time"
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.CustomFormat = "HH:mm"
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker4.Location = New System.Drawing.Point(100, 69)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.ShowUpDown = True
        Me.DateTimePicker4.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker4.TabIndex = 1
        Me.DateTimePicker4.Value = New Date(2019, 8, 15, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Start Time"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker6)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(577, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(211, 152)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Session Two Times"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 104)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 38)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Set Session Two"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "HH:mm"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(100, 35)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.ShowUpDown = True
        Me.DateTimePicker5.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker5.TabIndex = 0
        Me.DateTimePicker5.Value = New Date(2019, 8, 15, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "End Time"
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = "HH:mm"
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker6.Location = New System.Drawing.Point(100, 73)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.ShowUpDown = True
        Me.DateTimePicker6.Size = New System.Drawing.Size(92, 20)
        Me.DateTimePicker6.TabIndex = 1
        Me.DateTimePicker6.Value = New Date(2019, 8, 15, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Start Time"
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
        Me.ExamTT.Location = New System.Drawing.Point(246, 174)
        Me.ExamTT.Name = "ExamTT"
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ExamTT.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ExamTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ExamTT.Size = New System.Drawing.Size(542, 453)
        Me.ExamTT.TabIndex = 7
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Papers"
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.BackColor = System.Drawing.SystemColors.Control
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel.Location = New System.Drawing.Point(9, 188)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(222, 439)
        Me.panel.TabIndex = 8
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Location = New System.Drawing.Point(9, 638)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(118, 36)
        Me.CloseBtn.TabIndex = 10
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(670, 638)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 36)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CreateExamTimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 686)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.ExamTT)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateExamTimeTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create Exam Timetable"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ExamTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ExamTT As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents panel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents SessionOne As DataGridViewTextBoxColumn
    Friend WithEvents SessionTwo As DataGridViewTextBoxColumn
End Class
