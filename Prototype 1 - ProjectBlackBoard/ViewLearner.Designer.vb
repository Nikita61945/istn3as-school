<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewLearner
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewLearner))
        Me.dgvLearners = New System.Windows.Forms.DataGridView()
        Me.NameRB = New System.Windows.Forms.RadioButton()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GenderRB = New System.Windows.Forms.RadioButton()
        Me.GradeRB = New System.Windows.Forms.RadioButton()
        Me.SurnameRB = New System.Windows.Forms.RadioButton()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DisplayAllLearners = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.dgvLearners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvLearners
        '
        Me.dgvLearners.AllowUserToAddRows = False
        Me.dgvLearners.AllowUserToDeleteRows = False
        Me.dgvLearners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLearners.Location = New System.Drawing.Point(38, 124)
        Me.dgvLearners.Name = "dgvLearners"
        Me.dgvLearners.ReadOnly = True
        Me.dgvLearners.Size = New System.Drawing.Size(718, 284)
        Me.dgvLearners.TabIndex = 0
        '
        'NameRB
        '
        Me.NameRB.AutoSize = True
        Me.NameRB.Location = New System.Drawing.Point(14, 21)
        Me.NameRB.Name = "NameRB"
        Me.NameRB.Size = New System.Drawing.Size(63, 20)
        Me.NameRB.TabIndex = 1
        Me.NameRB.TabStop = True
        Me.NameRB.Text = "Name"
        Me.NameRB.UseVisualStyleBackColor = True
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.RadioButton2)
        Me.DisplayGroupBox.Controls.Add(Me.RadioButton1)
        Me.DisplayGroupBox.Controls.Add(Me.GenderRB)
        Me.DisplayGroupBox.Controls.Add(Me.GradeRB)
        Me.DisplayGroupBox.Controls.Add(Me.SurnameRB)
        Me.DisplayGroupBox.Controls.Add(Me.NameRB)
        Me.DisplayGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayGroupBox.Location = New System.Drawing.Point(25, 12)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(200, 101)
        Me.DisplayGroupBox.TabIndex = 2
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "Display By :"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(106, 74)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(73, 20)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "InActive"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 74)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 20)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GenderRB
        '
        Me.GenderRB.AutoSize = True
        Me.GenderRB.Location = New System.Drawing.Point(106, 47)
        Me.GenderRB.Name = "GenderRB"
        Me.GenderRB.Size = New System.Drawing.Size(71, 20)
        Me.GenderRB.TabIndex = 4
        Me.GenderRB.TabStop = True
        Me.GenderRB.Text = "Gender"
        Me.GenderRB.UseVisualStyleBackColor = True
        '
        'GradeRB
        '
        Me.GradeRB.AutoSize = True
        Me.GradeRB.Location = New System.Drawing.Point(106, 21)
        Me.GradeRB.Name = "GradeRB"
        Me.GradeRB.Size = New System.Drawing.Size(64, 20)
        Me.GradeRB.TabIndex = 3
        Me.GradeRB.TabStop = True
        Me.GradeRB.Text = "Grade"
        Me.GradeRB.UseVisualStyleBackColor = True
        '
        'SurnameRB
        '
        Me.SurnameRB.AutoSize = True
        Me.SurnameRB.Location = New System.Drawing.Point(14, 47)
        Me.SurnameRB.Name = "SurnameRB"
        Me.SurnameRB.Size = New System.Drawing.Size(80, 20)
        Me.SurnameRB.TabIndex = 2
        Me.SurnameRB.TabStop = True
        Me.SurnameRB.Text = "Surname"
        Me.SurnameRB.UseVisualStyleBackColor = True
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.Location = New System.Drawing.Point(338, 28)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.SurnameTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.SurnameTextBox, "Enter a Surname and Press Search to fnd  Learner ")
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(338, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.NameTextBox.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.NameTextBox, "Enter a Name and Press Search to find  Learner ")
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(577, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Edit "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(614, 26)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 39)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(681, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(338, 85)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(190, 21)
        Me.GradeComboBox.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.GradeComboBox, "Select a grade and Press Search to fInd Learner ")
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(263, 31)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(62, 16)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Surname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(263, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Name"
        '
        'DisplayAllLearners
        '
        Me.DisplayAllLearners.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayAllLearners.Location = New System.Drawing.Point(25, 419)
        Me.DisplayAllLearners.Name = "DisplayAllLearners"
        Me.DisplayAllLearners.Size = New System.Drawing.Size(101, 39)
        Me.DisplayAllLearners.TabIndex = 14
        Me.DisplayAllLearners.Text = "Display All Learners"
        Me.DisplayAllLearners.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(614, 74)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(101, 39)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Clear Fields"
        Me.ToolTip1.SetToolTip(Me.Button4, "Click on to clear Textboxes")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Enter a Surname and Press Search to fInd  Learner "
        '
        'ViewLearner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 466)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DisplayAllLearners)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.dgvLearners)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "ViewLearner.htm")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(801, 505)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(801, 505)
        Me.Name = "ViewLearner"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Learner"
        Me.TopMost = True
        CType(Me.dgvLearners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLearners As DataGridView
    Friend WithEvents NameRB As RadioButton
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents GenderRB As RadioButton
    Friend WithEvents GradeRB As RadioButton
    Friend WithEvents SurnameRB As RadioButton
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DisplayAllLearners As Button
    Friend WithEvents Button4 As Button
    Public WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
