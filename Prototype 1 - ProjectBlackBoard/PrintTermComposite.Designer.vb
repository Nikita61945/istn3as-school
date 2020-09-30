<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintTermComposite
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
        Me.TermLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.TermTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TermLabel
        '
        Me.TermLabel.AutoSize = True
        Me.TermLabel.Location = New System.Drawing.Point(29, 36)
        Me.TermLabel.Name = "TermLabel"
        Me.TermLabel.Size = New System.Drawing.Size(31, 13)
        Me.TermLabel.TabIndex = 0
        Me.TermLabel.Text = "Term"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(29, 68)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(36, 13)
        Me.GradeLabel.TabIndex = 2
        Me.GradeLabel.Text = "Grade"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Location = New System.Drawing.Point(29, 103)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(43, 13)
        Me.SubjectLabel.TabIndex = 3
        Me.SubjectLabel.Text = "Subject"
        '
        'TermTextBox
        '
        Me.TermTextBox.Location = New System.Drawing.Point(109, 29)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.Size = New System.Drawing.Size(157, 20)
        Me.TermTextBox.TabIndex = 4
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(109, 61)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(157, 20)
        Me.GradeTextBox.TabIndex = 5
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Location = New System.Drawing.Point(109, 96)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(157, 20)
        Me.SubjectTextBox.TabIndex = 6
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(191, 137)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 7
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(109, 137)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(191, 180)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 9
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'PrintTermComposite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 255)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.TermTextBox)
        Me.Controls.Add(Me.SubjectLabel)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.TermLabel)
        Me.Name = "PrintTermComposite"
        Me.Text = "PrintTermComposite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TermLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents SubjectLabel As Label
    Friend WithEvents TermTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents PrintButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents HomeButton As Button
End Class
