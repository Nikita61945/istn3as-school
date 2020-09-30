<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewTutorSalaries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTutorSalaries))
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.monthlyRTB = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TutorRTB = New System.Windows.Forms.RichTextBox()
        Me.TutorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthComboBox
        '
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Items.AddRange(New Object() {"01 Jan", "02 Feb", "03 Mar", "04 Apr", "05 May", "06 Jun", "07 Jul", "08 Aug", "09 Sept", "10 Oct", "11 Nov", "12 Dec"})
        Me.MonthComboBox.Location = New System.Drawing.Point(210, 25)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(121, 21)
        Me.MonthComboBox.Sorted = True
        Me.MonthComboBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Month"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(526, 478)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TabPage1.Controls.Add(Me.monthlyRTB)
        Me.TabPage1.Controls.Add(Me.MonthComboBox)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(518, 452)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Month"
        '
        'monthlyRTB
        '
        Me.monthlyRTB.Location = New System.Drawing.Point(22, 68)
        Me.monthlyRTB.Name = "monthlyRTB"
        Me.monthlyRTB.Size = New System.Drawing.Size(473, 347)
        Me.monthlyRTB.TabIndex = 2
        Me.monthlyRTB.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Silver
        Me.TabPage2.Controls.Add(Me.TutorRTB)
        Me.TabPage2.Controls.Add(Me.TutorComboBox)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(518, 452)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Tutor"
        '
        'TutorRTB
        '
        Me.TutorRTB.Location = New System.Drawing.Point(23, 74)
        Me.TutorRTB.Name = "TutorRTB"
        Me.TutorRTB.Size = New System.Drawing.Size(473, 347)
        Me.TutorRTB.TabIndex = 5
        Me.TutorRTB.Text = ""
        '
        'TutorComboBox
        '
        Me.TutorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TutorComboBox.FormattingEnabled = True
        Me.TutorComboBox.Location = New System.Drawing.Point(211, 31)
        Me.TutorComboBox.Name = "TutorComboBox"
        Me.TutorComboBox.Size = New System.Drawing.Size(121, 21)
        Me.TutorComboBox.Sorted = True
        Me.TutorComboBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tutor"
        '
        'ViewTutorSalaries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 476)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewTutorSalaries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewTutorSalaries"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents monthlyRTB As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TutorRTB As RichTextBox
    Friend WithEvents TutorComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class
