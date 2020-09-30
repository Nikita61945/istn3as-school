<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubjectDetails))
        Me.IsOfferedCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsOffLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SBATextBox = New System.Windows.Forms.TextBox()
        Me.PassmarkTextBox = New System.Windows.Forms.TextBox()
        Me.PassmarkLabel = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HoursReqNUD = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelGrade = New System.Windows.Forms.Label()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.HoursReqNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IsOfferedCheckBox
        '
        Me.IsOfferedCheckBox.AutoSize = True
        Me.IsOfferedCheckBox.Location = New System.Drawing.Point(224, 226)
        Me.IsOfferedCheckBox.Name = "IsOfferedCheckBox"
        Me.IsOfferedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsOfferedCheckBox.TabIndex = 4
        Me.IsOfferedCheckBox.UseVisualStyleBackColor = True
        '
        'IsOffLabel
        '
        Me.IsOffLabel.AutoSize = True
        Me.IsOffLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsOffLabel.Location = New System.Drawing.Point(48, 224)
        Me.IsOffLabel.Name = "IsOffLabel"
        Me.IsOffLabel.Size = New System.Drawing.Size(65, 16)
        Me.IsOffLabel.TabIndex = 23
        Me.IsOffLabel.Text = "Is Offered"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Enter SBA Weighting"
        '
        'SBATextBox
        '
        Me.SBATextBox.Location = New System.Drawing.Point(224, 132)
        Me.SBATextBox.Name = "SBATextBox"
        Me.SBATextBox.Size = New System.Drawing.Size(121, 21)
        Me.SBATextBox.TabIndex = 2
        '
        'PassmarkTextBox
        '
        Me.PassmarkTextBox.Location = New System.Drawing.Point(224, 92)
        Me.PassmarkTextBox.Name = "PassmarkTextBox"
        Me.PassmarkTextBox.Size = New System.Drawing.Size(121, 21)
        Me.PassmarkTextBox.TabIndex = 1
        '
        'PassmarkLabel
        '
        Me.PassmarkLabel.AutoSize = True
        Me.PassmarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassmarkLabel.Location = New System.Drawing.Point(48, 95)
        Me.PassmarkLabel.Name = "PassmarkLabel"
        Me.PassmarkLabel.Size = New System.Drawing.Size(103, 16)
        Me.PassmarkLabel.TabIndex = 21
        Me.PassmarkLabel.Text = "Enter Passmark"
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(270, 269)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Grade: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Subject : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 32)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Enter Number of Teaching " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hours Required"
        '
        'HoursReqNUD
        '
        Me.HoursReqNUD.Location = New System.Drawing.Point(224, 172)
        Me.HoursReqNUD.Name = "HoursReqNUD"
        Me.HoursReqNUD.Size = New System.Drawing.Size(120, 21)
        Me.HoursReqNUD.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(269, 307)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelGrade
        '
        Me.LabelGrade.AutoSize = True
        Me.LabelGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGrade.Location = New System.Drawing.Point(113, 53)
        Me.LabelGrade.Name = "LabelGrade"
        Me.LabelGrade.Size = New System.Drawing.Size(0, 18)
        Me.LabelGrade.TabIndex = 29
        '
        'LabelSubject
        '
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubject.Location = New System.Drawing.Point(113, 28)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(0, 18)
        Me.LabelSubject.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(349, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 18)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 18)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 337)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 18)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Required Fields"
        '
        'SubjectDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 377)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelSubject)
        Me.Controls.Add(Me.LabelGrade)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HoursReqNUD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IsOfferedCheckBox)
        Me.Controls.Add(Me.IsOffLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SBATextBox)
        Me.Controls.Add(Me.PassmarkTextBox)
        Me.Controls.Add(Me.PassmarkLabel)
        Me.Controls.Add(Me.SaveButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubjectDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subject Details"
        Me.TopMost = True
        CType(Me.HoursReqNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IsOfferedCheckBox As CheckBox
    Friend WithEvents IsOffLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SBATextBox As TextBox
    Friend WithEvents PassmarkTextBox As TextBox
    Friend WithEvents PassmarkLabel As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HoursReqNUD As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelGrade As Label
    Friend WithEvents LabelSubject As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
