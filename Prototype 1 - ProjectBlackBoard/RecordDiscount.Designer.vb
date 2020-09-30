<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordDiscount
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordDiscount))
        Me.LearnerAccLabel = New System.Windows.Forms.Label()
        Me.SubAccLabel = New System.Windows.Forms.Label()
        Me.DisAmtLabel = New System.Windows.Forms.Label()
        Me.LearnersComboBox = New System.Windows.Forms.ComboBox()
        Me.SubAccountComboBox = New System.Windows.Forms.ComboBox()
        Me.DisAmountTextBox = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthBreakDownBox = New System.Windows.Forms.RichTextBox()
        Me.EndMonthTextBox = New System.Windows.Forms.TextBox()
        Me.EndMonthLabel = New System.Windows.Forms.Label()
        Me.StartMonthTextBox = New System.Windows.Forms.TextBox()
        Me.StartMonthLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fullamount = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LearnerAccLabel
        '
        Me.LearnerAccLabel.AutoSize = True
        Me.LearnerAccLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LearnerAccLabel.Location = New System.Drawing.Point(16, 28)
        Me.LearnerAccLabel.Name = "LearnerAccLabel"
        Me.LearnerAccLabel.Size = New System.Drawing.Size(105, 16)
        Me.LearnerAccLabel.TabIndex = 0
        Me.LearnerAccLabel.Text = "Learner Account"
        '
        'SubAccLabel
        '
        Me.SubAccLabel.AutoSize = True
        Me.SubAccLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubAccLabel.Location = New System.Drawing.Point(16, 57)
        Me.SubAccLabel.Name = "SubAccLabel"
        Me.SubAccLabel.Size = New System.Drawing.Size(83, 16)
        Me.SubAccLabel.TabIndex = 1
        Me.SubAccLabel.Text = "Sub Account"
        '
        'DisAmtLabel
        '
        Me.DisAmtLabel.AutoSize = True
        Me.DisAmtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisAmtLabel.Location = New System.Drawing.Point(16, 114)
        Me.DisAmtLabel.Name = "DisAmtLabel"
        Me.DisAmtLabel.Size = New System.Drawing.Size(108, 16)
        Me.DisAmtLabel.TabIndex = 3
        Me.DisAmtLabel.Text = "Discount Amount"
        '
        'LearnersComboBox
        '
        Me.LearnersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LearnersComboBox.DropDownWidth = 140
        Me.LearnersComboBox.FormattingEnabled = True
        Me.LearnersComboBox.Location = New System.Drawing.Point(170, 30)
        Me.LearnersComboBox.Name = "LearnersComboBox"
        Me.LearnersComboBox.Size = New System.Drawing.Size(202, 21)
        Me.LearnersComboBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.LearnersComboBox, "Select a learner to add discount to")
        '
        'SubAccountComboBox
        '
        Me.SubAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubAccountComboBox.FormattingEnabled = True
        Me.SubAccountComboBox.Items.AddRange(New Object() {"Tutoring and Support", "Curriculum ", "SACAI Registration Fees", "Textbooks", "Re-Registration Fees"})
        Me.SubAccountComboBox.Location = New System.Drawing.Point(170, 57)
        Me.SubAccountComboBox.Name = "SubAccountComboBox"
        Me.SubAccountComboBox.Size = New System.Drawing.Size(202, 21)
        Me.SubAccountComboBox.TabIndex = 2
        '
        'DisAmountTextBox
        '
        Me.DisAmountTextBox.Location = New System.Drawing.Point(170, 113)
        Me.DisAmountTextBox.Name = "DisAmountTextBox"
        Me.DisAmountTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DisAmountTextBox.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.DisAmountTextBox, "Enter the total DIscount Amount")
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(216, 352)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(297, 352)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelButton.TabIndex = 8
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Discount Given"
        Me.ToolTip1.SetToolTip(Me.TextBox1, "This note will appear on the Fee Statement")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Trans Note"
        '
        'MonthBreakDownBox
        '
        Me.MonthBreakDownBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthBreakDownBox.Location = New System.Drawing.Point(151, 147)
        Me.MonthBreakDownBox.Name = "MonthBreakDownBox"
        Me.MonthBreakDownBox.ReadOnly = True
        Me.MonthBreakDownBox.Size = New System.Drawing.Size(221, 190)
        Me.MonthBreakDownBox.TabIndex = 21
        Me.MonthBreakDownBox.TabStop = False
        Me.MonthBreakDownBox.Text = ""
        '
        'EndMonthTextBox
        '
        Me.EndMonthTextBox.Location = New System.Drawing.Point(94, 208)
        Me.EndMonthTextBox.Name = "EndMonthTextBox"
        Me.EndMonthTextBox.Size = New System.Drawing.Size(40, 20)
        Me.EndMonthTextBox.TabIndex = 6
        Me.EndMonthTextBox.Text = "11"
        '
        'EndMonthLabel
        '
        Me.EndMonthLabel.AutoSize = True
        Me.EndMonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EndMonthLabel.Location = New System.Drawing.Point(16, 208)
        Me.EndMonthLabel.Name = "EndMonthLabel"
        Me.EndMonthLabel.Size = New System.Drawing.Size(71, 16)
        Me.EndMonthLabel.TabIndex = 20
        Me.EndMonthLabel.Text = "End Month"
        '
        'StartMonthTextBox
        '
        Me.StartMonthTextBox.Location = New System.Drawing.Point(94, 167)
        Me.StartMonthTextBox.Name = "StartMonthTextBox"
        Me.StartMonthTextBox.Size = New System.Drawing.Size(40, 20)
        Me.StartMonthTextBox.TabIndex = 5
        Me.StartMonthTextBox.Text = "2"
        '
        'StartMonthLabel
        '
        Me.StartMonthLabel.AutoSize = True
        Me.StartMonthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartMonthLabel.Location = New System.Drawing.Point(16, 167)
        Me.StartMonthLabel.Name = "StartMonthLabel"
        Me.StartMonthLabel.Size = New System.Drawing.Size(74, 16)
        Me.StartMonthLabel.TabIndex = 19
        Me.StartMonthLabel.Text = "Start Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(653, 303)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Total Amount Charged"
        '
        'fullamount
        '
        Me.fullamount.AutoSize = True
        Me.fullamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullamount.Location = New System.Drawing.Point(814, 303)
        Me.fullamount.Name = "fullamount"
        Me.fullamount.Size = New System.Drawing.Size(0, 16)
        Me.fullamount.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(463, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.Size = New System.Drawing.Size(421, 261)
        Me.DataGridView1.TabIndex = 25
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'RecordDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 408)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.fullamount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MonthBreakDownBox)
        Me.Controls.Add(Me.EndMonthTextBox)
        Me.Controls.Add(Me.EndMonthLabel)
        Me.Controls.Add(Me.StartMonthTextBox)
        Me.Controls.Add(Me.StartMonthLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.DisAmountTextBox)
        Me.Controls.Add(Me.SubAccountComboBox)
        Me.Controls.Add(Me.LearnersComboBox)
        Me.Controls.Add(Me.DisAmtLabel)
        Me.Controls.Add(Me.SubAccLabel)
        Me.Controls.Add(Me.LearnerAccLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecordDiscount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Discount"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LearnerAccLabel As Label
    Friend WithEvents SubAccLabel As Label
    Friend WithEvents DisAmtLabel As Label
    Friend WithEvents LearnersComboBox As ComboBox
    Friend WithEvents SubAccountComboBox As ComboBox
    Friend WithEvents DisAmountTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthBreakDownBox As RichTextBox
    Friend WithEvents EndMonthTextBox As TextBox
    Friend WithEvents EndMonthLabel As Label
    Friend WithEvents StartMonthTextBox As TextBox
    Friend WithEvents StartMonthLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents fullamount As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
End Class
