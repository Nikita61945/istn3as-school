<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecordPaymentReciepts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RecordPaymentReciepts))
        Me.dgvPay = New System.Windows.Forms.DataGridView()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CaptureButton = New System.Windows.Forms.Button()
        Me.BankRadioButton = New System.Windows.Forms.RadioButton()
        Me.RecieptRadioButton = New System.Windows.Forms.RadioButton()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.LearnerComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SubAccountComboBox = New System.Windows.Forms.ComboBox()
        Me.daySel = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.transnoteTextBox = New System.Windows.Forms.TextBox()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RefNoTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvPay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daySel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPay
        '
        Me.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPay.Location = New System.Drawing.Point(24, 69)
        Me.dgvPay.Name = "dgvPay"
        Me.dgvPay.Size = New System.Drawing.Size(795, 270)
        Me.dgvPay.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.dgvPay, "Select a row to edit it")
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(767, 393)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 32)
        Me.CancelButton.TabIndex = 13
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(767, 350)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(767, 431)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 32)
        Me.BackButton.TabIndex = 14
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'CaptureButton
        '
        Me.CaptureButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CaptureButton.Location = New System.Drawing.Point(583, 18)
        Me.CaptureButton.Name = "CaptureButton"
        Me.CaptureButton.Size = New System.Drawing.Size(94, 36)
        Me.CaptureButton.TabIndex = 4
        Me.CaptureButton.Text = "Capture"
        Me.CaptureButton.UseVisualStyleBackColor = True
        '
        'BankRadioButton
        '
        Me.BankRadioButton.AutoSize = True
        Me.BankRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BankRadioButton.Location = New System.Drawing.Point(106, 15)
        Me.BankRadioButton.Name = "BankRadioButton"
        Me.BankRadioButton.Size = New System.Drawing.Size(57, 20)
        Me.BankRadioButton.TabIndex = 1
        Me.BankRadioButton.TabStop = True
        Me.BankRadioButton.Text = "Bank"
        Me.BankRadioButton.UseVisualStyleBackColor = True
        '
        'RecieptRadioButton
        '
        Me.RecieptRadioButton.AutoSize = True
        Me.RecieptRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecieptRadioButton.Location = New System.Drawing.Point(16, 16)
        Me.RecieptRadioButton.Name = "RecieptRadioButton"
        Me.RecieptRadioButton.Size = New System.Drawing.Size(73, 20)
        Me.RecieptRadioButton.TabIndex = 2
        Me.RecieptRadioButton.TabStop = True
        Me.RecieptRadioButton.Text = "Reciept"
        Me.RecieptRadioButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(725, 17)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(94, 36)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(359, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Month"
        '
        'MonthTextBox
        '
        Me.MonthTextBox.Location = New System.Drawing.Point(421, 29)
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.Size = New System.Drawing.Size(30, 20)
        Me.MonthTextBox.TabIndex = 3
        '
        'LearnerComboBox
        '
        Me.LearnerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LearnerComboBox.FormattingEnabled = True
        Me.LearnerComboBox.ItemHeight = 13
        Me.LearnerComboBox.Location = New System.Drawing.Point(91, 404)
        Me.LearnerComboBox.Name = "LearnerComboBox"
        Me.LearnerComboBox.Size = New System.Drawing.Size(162, 21)
        Me.LearnerComboBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.LearnerComboBox, "If Name is not found the learner doesnot have an existing account")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Learner "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(260, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Sub Account"
        '
        'SubAccountComboBox
        '
        Me.SubAccountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SubAccountComboBox.FormattingEnabled = True
        Me.SubAccountComboBox.Items.AddRange(New Object() {"Tutoring and Support", "Curriculum ", "SACAI Registration Fees", "Textbooks", "Re-Registration Fees"})
        Me.SubAccountComboBox.Location = New System.Drawing.Point(377, 363)
        Me.SubAccountComboBox.Name = "SubAccountComboBox"
        Me.SubAccountComboBox.Size = New System.Drawing.Size(140, 21)
        Me.SubAccountComboBox.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.SubAccountComboBox, "Select Fee Account that has been paid")
        '
        'daySel
        '
        Me.daySel.Location = New System.Drawing.Point(91, 362)
        Me.daySel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.daySel.Name = "daySel"
        Me.daySel.Size = New System.Drawing.Size(120, 20)
        Me.daySel.TabIndex = 6
        Me.daySel.ThousandsSeparator = True
        Me.daySel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 361)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Transaction Note"
        '
        'transnoteTextBox
        '
        Me.transnoteTextBox.Location = New System.Drawing.Point(377, 402)
        Me.transnoteTextBox.Name = "transnoteTextBox"
        Me.transnoteTextBox.Size = New System.Drawing.Size(186, 20)
        Me.transnoteTextBox.TabIndex = 9
        Me.transnoteTextBox.Text = "Payment Recieved"
        Me.ToolTip1.SetToolTip(Me.transnoteTextBox, "This note will appear on the Fee Statement")
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Location = New System.Drawing.Point(632, 402)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(569, 405)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Amount"
        '
        'RefNoTextBox
        '
        Me.RefNoTextBox.Location = New System.Drawing.Point(632, 364)
        Me.RefNoTextBox.Name = "RefNoTextBox"
        Me.RefNoTextBox.Size = New System.Drawing.Size(36, 20)
        Me.RefNoTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.RefNoTextBox, "Field is not required")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(569, 361)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Ref No"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipTitle = "If Name is not found the learner doesnot have an existing account"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RecieptRadioButton)
        Me.GroupBox1.Controls.Add(Me.BankRadioButton)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(52, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(190, 43)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Source"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Select where the source the Payment can be traced to")
        '
        'RecordPaymentReciepts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RefNoTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.transnoteTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.daySel)
        Me.Controls.Add(Me.SubAccountComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LearnerComboBox)
        Me.Controls.Add(Me.MonthTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.CaptureButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.dgvPay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecordPaymentReciepts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Payment Reciepts"
        CType(Me.dgvPay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daySel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPay As DataGridView
    Friend WithEvents CancelButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents CaptureButton As Button
    Friend WithEvents BankRadioButton As RadioButton
    Friend WithEvents RecieptRadioButton As RadioButton
    Friend WithEvents EditButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthTextBox As TextBox
    Friend WithEvents LearnerComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SubAccountComboBox As ComboBox
    Friend WithEvents daySel As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents transnoteTextBox As TextBox
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RefNoTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GroupBox1 As GroupBox
End Class
