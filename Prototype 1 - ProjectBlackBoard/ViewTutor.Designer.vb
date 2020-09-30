<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTutor
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTutor))
        Me.dgvTutor = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TutorComboBox = New System.Windows.Forms.ComboBox()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.NameRadioButton = New System.Windows.Forms.RadioButton()
        Me.PaymentStyleRadioButton = New System.Windows.Forms.RadioButton()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SalarydescRadioButton = New System.Windows.Forms.RadioButton()
        Me.SalaryASCRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradesCombo = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTutor
        '
        Me.dgvTutor.AllowUserToAddRows = False
        Me.dgvTutor.AllowUserToDeleteRows = False
        Me.dgvTutor.AllowUserToResizeColumns = False
        Me.dgvTutor.AllowUserToResizeRows = False
        Me.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTutor.Location = New System.Drawing.Point(41, 79)
        Me.dgvTutor.MultiSelect = False
        Me.dgvTutor.Name = "dgvTutor"
        Me.dgvTutor.ReadOnly = True
        Me.dgvTutor.Size = New System.Drawing.Size(705, 311)
        Me.dgvTutor.TabIndex = 0
        Me.ToolTip2.SetToolTip(Me.dgvTutor, "Double Click to edit Tutor Info")
        Me.GradesCombo.SetToolTip(Me.dgvTutor, "Double click on a tutor to edit")
        Me.ToolTip1.SetToolTip(Me.dgvTutor, "Double Click to edit Tutor Info")
        Me.ToolTip3.SetToolTip(Me.dgvTutor, "Double Click to edit Tutor Info")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TutorComboBox)
        Me.Panel1.Location = New System.Drawing.Point(41, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(483, 51)
        Me.Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select a Tutor"
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.Location = New System.Drawing.Point(384, 9)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(75, 32)
        Me.DisplayAllButton.TabIndex = 2
        Me.DisplayAllButton.Text = "Display All"
        Me.DisplayAllButton.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(303, 9)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TutorComboBox
        '
        Me.TutorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TutorComboBox.FormattingEnabled = True
        Me.TutorComboBox.Location = New System.Drawing.Point(114, 16)
        Me.TutorComboBox.Name = "TutorComboBox"
        Me.TutorComboBox.Size = New System.Drawing.Size(155, 21)
        Me.TutorComboBox.TabIndex = 0
        Me.GradesCombo.SetToolTip(Me.TutorComboBox, "Select a Tutor to search for")
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(661, 417)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 36)
        Me.EditButton.TabIndex = 2
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'NameRadioButton
        '
        Me.NameRadioButton.AutoSize = True
        Me.NameRadioButton.Location = New System.Drawing.Point(25, 19)
        Me.NameRadioButton.Name = "NameRadioButton"
        Me.NameRadioButton.Size = New System.Drawing.Size(53, 17)
        Me.NameRadioButton.TabIndex = 1
        Me.NameRadioButton.TabStop = True
        Me.NameRadioButton.Text = "Name"
        Me.NameRadioButton.UseVisualStyleBackColor = True
        '
        'PaymentStyleRadioButton
        '
        Me.PaymentStyleRadioButton.AutoSize = True
        Me.PaymentStyleRadioButton.Location = New System.Drawing.Point(25, 39)
        Me.PaymentStyleRadioButton.Name = "PaymentStyleRadioButton"
        Me.PaymentStyleRadioButton.Size = New System.Drawing.Size(92, 17)
        Me.PaymentStyleRadioButton.TabIndex = 0
        Me.PaymentStyleRadioButton.TabStop = True
        Me.PaymentStyleRadioButton.Text = "Payment Style"
        Me.PaymentStyleRadioButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(661, 459)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 36)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SalarydescRadioButton)
        Me.GroupBox1.Controls.Add(Me.SalaryASCRadioButton)
        Me.GroupBox1.Controls.Add(Me.NameRadioButton)
        Me.GroupBox1.Controls.Add(Me.PaymentStyleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 407)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 107)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order By:"
        '
        'SalarydescRadioButton
        '
        Me.SalarydescRadioButton.AutoSize = True
        Me.SalarydescRadioButton.Location = New System.Drawing.Point(25, 80)
        Me.SalarydescRadioButton.Name = "SalarydescRadioButton"
        Me.SalarydescRadioButton.Size = New System.Drawing.Size(86, 17)
        Me.SalarydescRadioButton.TabIndex = 4
        Me.SalarydescRadioButton.TabStop = True
        Me.SalarydescRadioButton.Text = "Salary DESC"
        Me.SalarydescRadioButton.UseVisualStyleBackColor = True
        '
        'SalaryASCRadioButton
        '
        Me.SalaryASCRadioButton.AutoSize = True
        Me.SalaryASCRadioButton.Location = New System.Drawing.Point(25, 60)
        Me.SalaryASCRadioButton.Name = "SalaryASCRadioButton"
        Me.SalaryASCRadioButton.Size = New System.Drawing.Size(78, 17)
        Me.SalaryASCRadioButton.TabIndex = 3
        Me.SalaryASCRadioButton.TabStop = True
        Me.SalaryASCRadioButton.Text = "Salary ASC"
        Me.SalaryASCRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SubjectComboBox)
        Me.GroupBox2.Controls.Add(Me.GradeComboBox)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(195, 407)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 107)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter By"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(162, 57)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubjectComboBox.TabIndex = 3
        Me.GradesCombo.SetToolTip(Me.SubjectComboBox, "Select a subject to view who tutors it")
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(162, 30)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GradeComboBox.TabIndex = 2
        Me.GradesCombo.SetToolTip(Me.GradeComboBox, "Select a grade to view who tutors it")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subjects Teaching"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grades Teaching"
        '
        'GradesCombo
        '
        Me.GradesCombo.ShowAlways = True
        Me.GradesCombo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip2
        '
        Me.ToolTip2.ShowAlways = True
        Me.ToolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ToolTip3
        '
        Me.ToolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip3.ToolTipTitle = "Double Click to edit Tutor Info"
        '
        'ViewTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 526)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTutor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewTutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Tutor"
        Me.ToolTip1.SetToolTip(Me, "Select a subject to view who tutors it")
        Me.GradesCombo.SetToolTip(Me, "Select a grade to view who tutors it")
        Me.TopMost = True
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTutor As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents TutorComboBox As ComboBox
    Friend WithEvents EditButton As Button
    Friend WithEvents DisplayAllButton As Button
    Friend WithEvents NameRadioButton As RadioButton
    Friend WithEvents PaymentStyleRadioButton As RadioButton
    Friend WithEvents CloseButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SalarydescRadioButton As RadioButton
    Friend WithEvents SalaryASCRadioButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SubjectComboBox As ComboBox
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GradesCombo As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip3 As ToolTip
End Class
