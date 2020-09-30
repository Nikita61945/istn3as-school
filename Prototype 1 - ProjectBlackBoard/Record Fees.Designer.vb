<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Record_Fees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Record_Fees))
        Me.AccountLabel = New System.Windows.Forms.Label()
        Me.AccountComboBox = New System.Windows.Forms.ComboBox()
        Me.NoteLabel = New System.Windows.Forms.Label()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountLabel = New System.Windows.Forms.Label()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.StartMonthLabel = New System.Windows.Forms.Label()
        Me.StartMonthTextBox = New System.Windows.Forms.TextBox()
        Me.EndMonthLabel = New System.Windows.Forms.Label()
        Me.EndMonthTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthBreakDownBox = New System.Windows.Forms.RichTextBox()
        Me.dgvLAccounts = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvLAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccountLabel
        '
        Me.AccountLabel.AutoSize = True
        Me.AccountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLabel.Location = New System.Drawing.Point(17, 61)
        Me.AccountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AccountLabel.Name = "AccountLabel"
        Me.AccountLabel.Size = New System.Drawing.Size(83, 16)
        Me.AccountLabel.TabIndex = 0
        Me.AccountLabel.Text = "Sub Account"
        '
        'AccountComboBox
        '
        Me.AccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AccountComboBox.FormattingEnabled = True
        Me.AccountComboBox.Items.AddRange(New Object() {"Tutoring and Support", "Curriculum ", "SACAI Registration Fees", "Textbooks", "Re-Registration Fees"})
        Me.AccountComboBox.Location = New System.Drawing.Point(203, 58)
        Me.AccountComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AccountComboBox.Name = "AccountComboBox"
        Me.AccountComboBox.Size = New System.Drawing.Size(188, 24)
        Me.AccountComboBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AccountComboBox, "Select type of Fee that is being charged")
        '
        'NoteLabel
        '
        Me.NoteLabel.AutoSize = True
        Me.NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoteLabel.Location = New System.Drawing.Point(17, 94)
        Me.NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NoteLabel.Name = "NoteLabel"
        Me.NoteLabel.Size = New System.Drawing.Size(37, 16)
        Me.NoteLabel.TabIndex = 2
        Me.NoteLabel.Text = "Note"
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Location = New System.Drawing.Point(203, 94)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(188, 22)
        Me.NoteTextBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.NoteTextBox, "This will appear as the mesage on the Fee Statement")
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountLabel.Location = New System.Drawing.Point(17, 137)
        Me.AmountLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(66, 16)
        Me.AmountLabel.TabIndex = 4
        Me.AmountLabel.Text = "Amount R"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(203, 134)
        Me.AmountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(161, 22)
        Me.AmountTextBox.TabIndex = 4
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(17, 25)
        Me.GradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(46, 16)
        Me.GradeLabel.TabIndex = 6
        Me.GradeLabel.Text = "Grade"
        '
        'StartMonthLabel
        '
        Me.StartMonthLabel.AutoSize = True
        Me.StartMonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartMonthLabel.Location = New System.Drawing.Point(21, 210)
        Me.StartMonthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StartMonthLabel.Name = "StartMonthLabel"
        Me.StartMonthLabel.Size = New System.Drawing.Size(74, 16)
        Me.StartMonthLabel.TabIndex = 10
        Me.StartMonthLabel.Text = "Start Month"
        '
        'StartMonthTextBox
        '
        Me.StartMonthTextBox.Location = New System.Drawing.Point(125, 210)
        Me.StartMonthTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StartMonthTextBox.Name = "StartMonthTextBox"
        Me.StartMonthTextBox.Size = New System.Drawing.Size(36, 22)
        Me.StartMonthTextBox.TabIndex = 5
        Me.StartMonthTextBox.Text = "2"
        '
        'EndMonthLabel
        '
        Me.EndMonthLabel.AutoSize = True
        Me.EndMonthLabel.Location = New System.Drawing.Point(21, 257)
        Me.EndMonthLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EndMonthLabel.Name = "EndMonthLabel"
        Me.EndMonthLabel.Size = New System.Drawing.Size(71, 16)
        Me.EndMonthLabel.TabIndex = 12
        Me.EndMonthLabel.Text = "End Month"
        '
        'EndMonthTextBox
        '
        Me.EndMonthTextBox.Location = New System.Drawing.Point(125, 257)
        Me.EndMonthTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EndMonthTextBox.Name = "EndMonthTextBox"
        Me.EndMonthTextBox.Size = New System.Drawing.Size(36, 22)
        Me.EndMonthTextBox.TabIndex = 6
        Me.EndMonthTextBox.Text = "11"
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(805, 407)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(707, 407)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(203, 19)
        Me.GradeComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(122, 24)
        Me.GradeComboBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.GradeComboBox, "Select Grade to view learners in grade")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(471, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select learner(s) to add Fees to"
        '
        'MonthBreakDownBox
        '
        Me.MonthBreakDownBox.Location = New System.Drawing.Point(192, 194)
        Me.MonthBreakDownBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MonthBreakDownBox.Name = "MonthBreakDownBox"
        Me.MonthBreakDownBox.ReadOnly = True
        Me.MonthBreakDownBox.Size = New System.Drawing.Size(226, 233)
        Me.MonthBreakDownBox.TabIndex = 16
        Me.MonthBreakDownBox.Text = ""
        '
        'dgvLAccounts
        '
        Me.dgvLAccounts.AllowUserToAddRows = False
        Me.dgvLAccounts.AllowUserToDeleteRows = False
        Me.dgvLAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLAccounts.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLAccounts.Location = New System.Drawing.Point(472, 94)
        Me.dgvLAccounts.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvLAccounts.Name = "dgvLAccounts"
        Me.dgvLAccounts.Size = New System.Drawing.Size(408, 279)
        Me.dgvLAccounts.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.dgvLAccounts, "Select learners after Specifying Account")
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Record_Fees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 468)
        Me.Controls.Add(Me.dgvLAccounts)
        Me.Controls.Add(Me.MonthBreakDownBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.EndMonthTextBox)
        Me.Controls.Add(Me.EndMonthLabel)
        Me.Controls.Add(Me.StartMonthTextBox)
        Me.Controls.Add(Me.StartMonthLabel)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.NoteLabel)
        Me.Controls.Add(Me.AccountComboBox)
        Me.Controls.Add(Me.AccountLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Record_Fees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Fees"
        CType(Me.dgvLAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AccountLabel As Label
    Friend WithEvents AccountComboBox As ComboBox
    Friend WithEvents NoteLabel As Label
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents AmountLabel As Label
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents StartMonthLabel As Label
    Friend WithEvents StartMonthTextBox As TextBox
    Friend WithEvents EndMonthLabel As Label
    Friend WithEvents EndMonthTextBox As TextBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthBreakDownBox As RichTextBox
    Friend WithEvents dgvLAccounts As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class
