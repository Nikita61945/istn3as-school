<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignSubjects))
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(114, 26)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(204, 21)
        Me.GradeComboBox.TabIndex = 0
        '
        'NameComboBox
        '
        Me.NameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NameComboBox.DropDownHeight = 100
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.IntegralHeight = False
        Me.NameComboBox.Location = New System.Drawing.Point(114, 53)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(204, 21)
        Me.NameComboBox.TabIndex = 1
        '
        'SubjectsListBox
        '
        Me.SubjectsListBox.FormattingEnabled = True
        Me.SubjectsListBox.Location = New System.Drawing.Point(23, 111)
        Me.SubjectsListBox.Name = "SubjectsListBox"
        Me.SubjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.SubjectsListBox.Size = New System.Drawing.Size(295, 212)
        Me.SubjectsListBox.Sorted = True
        Me.SubjectsListBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Grade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Name"
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(12, 387)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 32)
        Me.HomeBtn.TabIndex = 7
        Me.HomeBtn.Text = "Close"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(584, 387)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 8
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Available Subjects For The Grade"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(372, 111)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(297, 212)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(369, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "List of Learner Subjects"
        '
        'AssignSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 442)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubjectsListBox)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.GradeComboBox)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Find)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(365, 326)
        Me.Name = "AssignSubjects"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Assign Subjects To Learner"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents SubjectsListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents HomeBtn As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label4 As Label
End Class
