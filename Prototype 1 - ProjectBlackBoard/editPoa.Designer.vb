<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditPOA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditPOA))
        Me.CalCmb = New System.Windows.Forms.ComboBox()
        Me.termsCmb = New System.Windows.Forms.ComboBox()
        Me.WeightingText = New System.Windows.Forms.TextBox()
        Me.PassMarkText = New System.Windows.Forms.TextBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.TotalText = New System.Windows.Forms.TextBox()
        Me.DateDuetxt = New System.Windows.Forms.DateTimePicker()
        Me.DateGive = New System.Windows.Forms.DateTimePicker()
        Me.TopicText = New System.Windows.Forms.TextBox()
        Me.YearText = New System.Windows.Forms.TextBox()
        Me.txtGrade = New System.Windows.Forms.TextBox()
        Me.PoaIDText = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.chkSBA = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CalCmb
        '
        Me.CalCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CalCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalCmb.FormattingEnabled = True
        Me.CalCmb.Items.AddRange(New Object() {"Paper specific", "Group 1", "Group 2", "Group 3", "Group 4"})
        Me.CalCmb.Location = New System.Drawing.Point(140, 472)
        Me.CalCmb.Margin = New System.Windows.Forms.Padding(4)
        Me.CalCmb.Name = "CalCmb"
        Me.CalCmb.Size = New System.Drawing.Size(265, 24)
        Me.CalCmb.TabIndex = 39
        '
        'termsCmb
        '
        Me.termsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.termsCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termsCmb.FormattingEnabled = True
        Me.termsCmb.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.termsCmb.Location = New System.Drawing.Point(142, 108)
        Me.termsCmb.Margin = New System.Windows.Forms.Padding(4)
        Me.termsCmb.Name = "termsCmb"
        Me.termsCmb.Size = New System.Drawing.Size(265, 24)
        Me.termsCmb.TabIndex = 22
        '
        'WeightingText
        '
        Me.WeightingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightingText.Location = New System.Drawing.Point(140, 433)
        Me.WeightingText.Margin = New System.Windows.Forms.Padding(4)
        Me.WeightingText.Name = "WeightingText"
        Me.WeightingText.Size = New System.Drawing.Size(267, 22)
        Me.WeightingText.TabIndex = 37
        '
        'PassMarkText
        '
        Me.PassMarkText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassMarkText.Location = New System.Drawing.Point(142, 393)
        Me.PassMarkText.Margin = New System.Windows.Forms.Padding(4)
        Me.PassMarkText.Name = "PassMarkText"
        Me.PassMarkText.Size = New System.Drawing.Size(265, 22)
        Me.PassMarkText.TabIndex = 36
        '
        'txtTask
        '
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.Location = New System.Drawing.Point(142, 352)
        Me.txtTask.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.ReadOnly = True
        Me.txtTask.Size = New System.Drawing.Size(265, 22)
        Me.txtTask.TabIndex = 34
        '
        'TotalText
        '
        Me.TotalText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalText.Location = New System.Drawing.Point(140, 312)
        Me.TotalText.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalText.Name = "TotalText"
        Me.TotalText.ReadOnly = True
        Me.TotalText.Size = New System.Drawing.Size(267, 22)
        Me.TotalText.TabIndex = 32
        '
        'DateDuetxt
        '
        Me.DateDuetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDuetxt.Location = New System.Drawing.Point(142, 233)
        Me.DateDuetxt.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDuetxt.Name = "DateDuetxt"
        Me.DateDuetxt.Size = New System.Drawing.Size(265, 22)
        Me.DateDuetxt.TabIndex = 28
        '
        'DateGive
        '
        Me.DateGive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateGive.Location = New System.Drawing.Point(142, 192)
        Me.DateGive.Margin = New System.Windows.Forms.Padding(4)
        Me.DateGive.Name = "DateGive"
        Me.DateGive.Size = New System.Drawing.Size(265, 22)
        Me.DateGive.TabIndex = 25
        '
        'TopicText
        '
        Me.TopicText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopicText.Location = New System.Drawing.Point(142, 272)
        Me.TopicText.Margin = New System.Windows.Forms.Padding(4)
        Me.TopicText.Name = "TopicText"
        Me.TopicText.ReadOnly = True
        Me.TopicText.Size = New System.Drawing.Size(265, 22)
        Me.TopicText.TabIndex = 30
        '
        'YearText
        '
        Me.YearText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearText.Location = New System.Drawing.Point(142, 152)
        Me.YearText.Margin = New System.Windows.Forms.Padding(4)
        Me.YearText.Name = "YearText"
        Me.YearText.ReadOnly = True
        Me.YearText.Size = New System.Drawing.Size(265, 22)
        Me.YearText.TabIndex = 23
        '
        'txtGrade
        '
        Me.txtGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade.Location = New System.Drawing.Point(142, 70)
        Me.txtGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrade.Name = "txtGrade"
        Me.txtGrade.ReadOnly = True
        Me.txtGrade.Size = New System.Drawing.Size(265, 22)
        Me.txtGrade.TabIndex = 20
        '
        'PoaIDText
        '
        Me.PoaIDText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoaIDText.Location = New System.Drawing.Point(142, 28)
        Me.PoaIDText.Margin = New System.Windows.Forms.Padding(4)
        Me.PoaIDText.Name = "PoaIDText"
        Me.PoaIDText.ReadOnly = True
        Me.PoaIDText.Size = New System.Drawing.Size(265, 22)
        Me.PoaIDText.TabIndex = 19
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActive.Location = New System.Drawing.Point(143, 521)
        Me.chkActive.Margin = New System.Windows.Forms.Padding(4)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(64, 20)
        Me.chkActive.TabIndex = 41
        Me.chkActive.Text = "Active"
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'chkSBA
        '
        Me.chkSBA.AutoSize = True
        Me.chkSBA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSBA.Location = New System.Drawing.Point(312, 519)
        Me.chkSBA.Margin = New System.Windows.Forms.Padding(4)
        Me.chkSBA.Name = "chkSBA"
        Me.chkSBA.Size = New System.Drawing.Size(64, 20)
        Me.chkSBA.TabIndex = 42
        Me.chkSBA.Text = "isSBA"
        Me.chkSBA.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(350, 559)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 32)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(253, 559)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 32)
        Me.btnSave.TabIndex = 43
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(46, 475)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Calculation"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(47, 435)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 16)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Weighting"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(46, 397)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 16)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "PassMark"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(46, 356)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Task No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(47, 316)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(46, 274)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Topic"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(46, 234)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Due Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 193)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Date Given"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 114)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Term No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "SubGrade"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(46, 28)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(56, 16)
        Me.label1.TabIndex = 17
        Me.label1.Text = "POA_ID"
        '
        'EditPOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 605)
        Me.Controls.Add(Me.CalCmb)
        Me.Controls.Add(Me.termsCmb)
        Me.Controls.Add(Me.WeightingText)
        Me.Controls.Add(Me.PassMarkText)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.TotalText)
        Me.Controls.Add(Me.DateDuetxt)
        Me.Controls.Add(Me.DateGive)
        Me.Controls.Add(Me.TopicText)
        Me.Controls.Add(Me.YearText)
        Me.Controls.Add(Me.txtGrade)
        Me.Controls.Add(Me.PoaIDText)
        Me.Controls.Add(Me.chkActive)
        Me.Controls.Add(Me.chkSBA)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditPOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit POA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CalCmb As ComboBox
    Friend WithEvents termsCmb As ComboBox
    Friend WithEvents WeightingText As TextBox
    Friend WithEvents PassMarkText As TextBox
    Friend WithEvents txtTask As TextBox
    Friend WithEvents TotalText As TextBox
    Friend WithEvents DateDuetxt As DateTimePicker
    Friend WithEvents DateGive As DateTimePicker
    Friend WithEvents TopicText As TextBox
    Friend WithEvents YearText As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents PoaIDText As TextBox
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents chkSBA As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents label1 As Label
End Class
