<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatePOA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreatePOA))
        Me.PoaIDLabel = New System.Windows.Forms.Label()
        Me.GradeIDLabel = New System.Windows.Forms.Label()
        Me.PoaIDTextBox = New System.Windows.Forms.TextBox()
        Me.SubGradeIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YearLabel = New System.Windows.Forms.Label()
        Me.YearTextBox = New System.Windows.Forms.TextBox()
        Me.DateGivenLabel = New System.Windows.Forms.Label()
        Me.DueDateLabel = New System.Windows.Forms.Label()
        Me.TopicLabel = New System.Windows.Forms.Label()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.PassMarkLabel = New System.Windows.Forms.Label()
        Me.PassMarkTextBox = New System.Windows.Forms.TextBox()
        Me.WeightingLabel = New System.Windows.Forms.Label()
        Me.WeightingTextBox = New System.Windows.Forms.TextBox()
        Me.CalcLabel = New System.Windows.Forms.Label()
        Me.ActiveLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.POACancelButton = New System.Windows.Forms.Button()
        Me.Subjects = New System.Windows.Forms.ComboBox()
        Me.Grades = New System.Windows.Forms.ComboBox()
        Me.DateGiven = New System.Windows.Forms.DateTimePicker()
        Me.DateDue = New System.Windows.Forms.DateTimePicker()
        Me.CalculationType = New System.Windows.Forms.ComboBox()
        Me.Active = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.isSBA = New System.Windows.Forms.CheckBox()
        Me.termCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTaskNo = New System.Windows.Forms.TextBox()
        Me.TopicTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PoaIDLabel
        '
        Me.PoaIDLabel.AutoSize = True
        Me.PoaIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoaIDLabel.Location = New System.Drawing.Point(25, 38)
        Me.PoaIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PoaIDLabel.Name = "PoaIDLabel"
        Me.PoaIDLabel.Size = New System.Drawing.Size(52, 16)
        Me.PoaIDLabel.TabIndex = 0
        Me.PoaIDLabel.Text = "POA ID"
        '
        'GradeIDLabel
        '
        Me.GradeIDLabel.AutoSize = True
        Me.GradeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeIDLabel.Location = New System.Drawing.Point(27, 73)
        Me.GradeIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GradeIDLabel.Name = "GradeIDLabel"
        Me.GradeIDLabel.Size = New System.Drawing.Size(46, 16)
        Me.GradeIDLabel.TabIndex = 1
        Me.GradeIDLabel.Text = "Grade"
        '
        'PoaIDTextBox
        '
        Me.PoaIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PoaIDTextBox.Location = New System.Drawing.Point(148, 30)
        Me.PoaIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PoaIDTextBox.Name = "PoaIDTextBox"
        Me.PoaIDTextBox.ReadOnly = True
        Me.PoaIDTextBox.Size = New System.Drawing.Size(268, 22)
        Me.PoaIDTextBox.TabIndex = 1
        '
        'SubGradeIDLabel
        '
        Me.SubGradeIDLabel.AutoSize = True
        Me.SubGradeIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubGradeIDLabel.Location = New System.Drawing.Point(27, 119)
        Me.SubGradeIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SubGradeIDLabel.Name = "SubGradeIDLabel"
        Me.SubGradeIDLabel.Size = New System.Drawing.Size(53, 16)
        Me.SubGradeIDLabel.TabIndex = 4
        Me.SubGradeIDLabel.Text = "Subject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 159)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Term No."
        '
        'YearLabel
        '
        Me.YearLabel.AutoSize = True
        Me.YearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLabel.Location = New System.Drawing.Point(27, 196)
        Me.YearLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.YearLabel.Name = "YearLabel"
        Me.YearLabel.Size = New System.Drawing.Size(37, 16)
        Me.YearLabel.TabIndex = 8
        Me.YearLabel.Text = "Year"
        '
        'YearTextBox
        '
        Me.YearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearTextBox.Location = New System.Drawing.Point(148, 187)
        Me.YearTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.ReadOnly = True
        Me.YearTextBox.Size = New System.Drawing.Size(268, 22)
        Me.YearTextBox.TabIndex = 5
        '
        'DateGivenLabel
        '
        Me.DateGivenLabel.AutoSize = True
        Me.DateGivenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateGivenLabel.Location = New System.Drawing.Point(27, 231)
        Me.DateGivenLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateGivenLabel.Name = "DateGivenLabel"
        Me.DateGivenLabel.Size = New System.Drawing.Size(75, 16)
        Me.DateGivenLabel.TabIndex = 10
        Me.DateGivenLabel.Text = "Date Given"
        '
        'DueDateLabel
        '
        Me.DueDateLabel.AutoSize = True
        Me.DueDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDateLabel.Location = New System.Drawing.Point(27, 268)
        Me.DueDateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DueDateLabel.Name = "DueDateLabel"
        Me.DueDateLabel.Size = New System.Drawing.Size(65, 16)
        Me.DueDateLabel.TabIndex = 12
        Me.DueDateLabel.Text = "Due Date"
        '
        'TopicLabel
        '
        Me.TopicLabel.AutoSize = True
        Me.TopicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopicLabel.Location = New System.Drawing.Point(27, 303)
        Me.TopicLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TopicLabel.Name = "TopicLabel"
        Me.TopicLabel.Size = New System.Drawing.Size(43, 16)
        Me.TopicLabel.TabIndex = 14
        Me.TopicLabel.Text = "Topic"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(145, 336)
        Me.TotalTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(268, 22)
        Me.TotalTextBox.TabIndex = 9
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLabel.Location = New System.Drawing.Point(24, 340)
        Me.TotalLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(39, 16)
        Me.TotalLabel.TabIndex = 19
        Me.TotalLabel.Text = "Total"
        '
        'PassMarkLabel
        '
        Me.PassMarkLabel.AutoSize = True
        Me.PassMarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassMarkLabel.Location = New System.Drawing.Point(27, 414)
        Me.PassMarkLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PassMarkLabel.Name = "PassMarkLabel"
        Me.PassMarkLabel.Size = New System.Drawing.Size(72, 16)
        Me.PassMarkLabel.TabIndex = 20
        Me.PassMarkLabel.Text = "Pass Mark"
        '
        'PassMarkTextBox
        '
        Me.PassMarkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassMarkTextBox.Location = New System.Drawing.Point(145, 410)
        Me.PassMarkTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PassMarkTextBox.Name = "PassMarkTextBox"
        Me.PassMarkTextBox.Size = New System.Drawing.Size(268, 22)
        Me.PassMarkTextBox.TabIndex = 11
        '
        'WeightingLabel
        '
        Me.WeightingLabel.AutoSize = True
        Me.WeightingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightingLabel.Location = New System.Drawing.Point(29, 455)
        Me.WeightingLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.WeightingLabel.Name = "WeightingLabel"
        Me.WeightingLabel.Size = New System.Drawing.Size(68, 16)
        Me.WeightingLabel.TabIndex = 22
        Me.WeightingLabel.Text = "Weighting"
        '
        'WeightingTextBox
        '
        Me.WeightingTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeightingTextBox.Location = New System.Drawing.Point(145, 449)
        Me.WeightingTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.WeightingTextBox.Name = "WeightingTextBox"
        Me.WeightingTextBox.Size = New System.Drawing.Size(268, 22)
        Me.WeightingTextBox.TabIndex = 12
        '
        'CalcLabel
        '
        Me.CalcLabel.AutoSize = True
        Me.CalcLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalcLabel.Location = New System.Drawing.Point(27, 496)
        Me.CalcLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CalcLabel.Name = "CalcLabel"
        Me.CalcLabel.Size = New System.Drawing.Size(74, 16)
        Me.CalcLabel.TabIndex = 24
        Me.CalcLabel.Text = "Calculation"
        '
        'ActiveLabel
        '
        Me.ActiveLabel.AutoSize = True
        Me.ActiveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActiveLabel.Location = New System.Drawing.Point(144, 532)
        Me.ActiveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ActiveLabel.Name = "ActiveLabel"
        Me.ActiveLabel.Size = New System.Drawing.Size(45, 16)
        Me.ActiveLabel.TabIndex = 27
        Me.ActiveLabel.Text = "Active"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(341, 565)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 16
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'POACancelButton
        '
        Me.POACancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POACancelButton.Location = New System.Drawing.Point(341, 602)
        Me.POACancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.POACancelButton.Name = "POACancelButton"
        Me.POACancelButton.Size = New System.Drawing.Size(75, 32)
        Me.POACancelButton.TabIndex = 17
        Me.POACancelButton.Text = "Cancel"
        Me.POACancelButton.UseVisualStyleBackColor = True
        '
        'Subjects
        '
        Me.Subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Subjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subjects.FormattingEnabled = True
        Me.Subjects.Location = New System.Drawing.Point(148, 108)
        Me.Subjects.Margin = New System.Windows.Forms.Padding(4)
        Me.Subjects.Name = "Subjects"
        Me.Subjects.Size = New System.Drawing.Size(268, 24)
        Me.Subjects.TabIndex = 3
        '
        'Grades
        '
        Me.Grades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grades.FormattingEnabled = True
        Me.Grades.Location = New System.Drawing.Point(148, 63)
        Me.Grades.Margin = New System.Windows.Forms.Padding(4)
        Me.Grades.Name = "Grades"
        Me.Grades.Size = New System.Drawing.Size(268, 24)
        Me.Grades.TabIndex = 2
        '
        'DateGiven
        '
        Me.DateGiven.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateGiven.Location = New System.Drawing.Point(148, 225)
        Me.DateGiven.Margin = New System.Windows.Forms.Padding(4)
        Me.DateGiven.Name = "DateGiven"
        Me.DateGiven.Size = New System.Drawing.Size(265, 22)
        Me.DateGiven.TabIndex = 6
        '
        'DateDue
        '
        Me.DateDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDue.Location = New System.Drawing.Point(148, 261)
        Me.DateDue.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDue.Name = "DateDue"
        Me.DateDue.Size = New System.Drawing.Size(265, 22)
        Me.DateDue.TabIndex = 7
        '
        'CalculationType
        '
        Me.CalculationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CalculationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculationType.FormattingEnabled = True
        Me.CalculationType.Items.AddRange(New Object() {"Paper specific", "Group 1", "Group 2", "Group 3", "Group 4"})
        Me.CalculationType.Location = New System.Drawing.Point(145, 486)
        Me.CalculationType.Margin = New System.Windows.Forms.Padding(4)
        Me.CalculationType.Name = "CalculationType"
        Me.CalculationType.Size = New System.Drawing.Size(268, 24)
        Me.CalculationType.TabIndex = 13
        '
        'Active
        '
        Me.Active.AutoSize = True
        Me.Active.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Active.Location = New System.Drawing.Point(201, 532)
        Me.Active.Margin = New System.Windows.Forms.Padding(4)
        Me.Active.Name = "Active"
        Me.Active.Size = New System.Drawing.Size(15, 14)
        Me.Active.TabIndex = 14
        Me.Active.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(305, 532)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "isSBA"
        '
        'isSBA
        '
        Me.isSBA.AutoSize = True
        Me.isSBA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isSBA.Location = New System.Drawing.Point(360, 532)
        Me.isSBA.Margin = New System.Windows.Forms.Padding(4)
        Me.isSBA.Name = "isSBA"
        Me.isSBA.Size = New System.Drawing.Size(15, 14)
        Me.isSBA.TabIndex = 15
        Me.isSBA.UseVisualStyleBackColor = True
        '
        'termCombo
        '
        Me.termCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.termCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.termCombo.FormattingEnabled = True
        Me.termCombo.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.termCombo.Location = New System.Drawing.Point(148, 149)
        Me.termCombo.Margin = New System.Windows.Forms.Padding(4)
        Me.termCombo.Name = "termCombo"
        Me.termCombo.Size = New System.Drawing.Size(268, 24)
        Me.termCombo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 380)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Task No."
        '
        'txtTaskNo
        '
        Me.txtTaskNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTaskNo.Location = New System.Drawing.Point(145, 377)
        Me.txtTaskNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTaskNo.Name = "txtTaskNo"
        Me.txtTaskNo.Size = New System.Drawing.Size(268, 22)
        Me.txtTaskNo.TabIndex = 10
        '
        'TopicTextBox
        '
        Me.TopicTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TopicTextBox.Location = New System.Drawing.Point(148, 297)
        Me.TopicTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TopicTextBox.Name = "TopicTextBox"
        Me.TopicTextBox.Size = New System.Drawing.Size(265, 22)
        Me.TopicTextBox.TabIndex = 8
        '
        'CreatePOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(491, 647)
        Me.Controls.Add(Me.TopicTextBox)
        Me.Controls.Add(Me.txtTaskNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.termCombo)
        Me.Controls.Add(Me.isSBA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Active)
        Me.Controls.Add(Me.CalculationType)
        Me.Controls.Add(Me.DateDue)
        Me.Controls.Add(Me.DateGiven)
        Me.Controls.Add(Me.Grades)
        Me.Controls.Add(Me.Subjects)
        Me.Controls.Add(Me.POACancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ActiveLabel)
        Me.Controls.Add(Me.CalcLabel)
        Me.Controls.Add(Me.WeightingTextBox)
        Me.Controls.Add(Me.WeightingLabel)
        Me.Controls.Add(Me.PassMarkTextBox)
        Me.Controls.Add(Me.PassMarkLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.TopicLabel)
        Me.Controls.Add(Me.DueDateLabel)
        Me.Controls.Add(Me.DateGivenLabel)
        Me.Controls.Add(Me.YearTextBox)
        Me.Controls.Add(Me.YearLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubGradeIDLabel)
        Me.Controls.Add(Me.PoaIDTextBox)
        Me.Controls.Add(Me.GradeIDLabel)
        Me.Controls.Add(Me.PoaIDLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreatePOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreatePOA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PoaIDLabel As Label
    Friend WithEvents GradeIDLabel As Label
    Friend WithEvents PoaIDTextBox As TextBox
    Friend WithEvents SubGradeIDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents YearLabel As Label
    Friend WithEvents YearTextBox As TextBox
    Friend WithEvents DateGivenLabel As Label
    Friend WithEvents DueDateLabel As Label
    Friend WithEvents TopicLabel As Label
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents TotalLabel As Label
    Friend WithEvents PassMarkLabel As Label
    Friend WithEvents PassMarkTextBox As TextBox
    Friend WithEvents WeightingLabel As Label
    Friend WithEvents WeightingTextBox As TextBox
    Friend WithEvents CalcLabel As Label
    Friend WithEvents ActiveLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents POACancelButton As Button
    Friend WithEvents Subjects As ComboBox
    Friend WithEvents Grades As ComboBox
    Friend WithEvents DateGiven As DateTimePicker
    Friend WithEvents DateDue As DateTimePicker
    Friend WithEvents CalculationType As ComboBox
    Friend WithEvents Active As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents isSBA As CheckBox
    Friend WithEvents termCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTaskNo As TextBox
    Friend WithEvents TopicTextBox As TextBox
End Class
