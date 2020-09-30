<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintLearnerComposite
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
        Me.LearnerNameLabel = New System.Windows.Forms.Label()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.LearnerNameComboBox = New System.Windows.Forms.ComboBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LearnerNameLabel
        '
        Me.LearnerNameLabel.AutoSize = True
        Me.LearnerNameLabel.Location = New System.Drawing.Point(28, 29)
        Me.LearnerNameLabel.Name = "LearnerNameLabel"
        Me.LearnerNameLabel.Size = New System.Drawing.Size(74, 13)
        Me.LearnerNameLabel.TabIndex = 0
        Me.LearnerNameLabel.Text = "Learner Name"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Location = New System.Drawing.Point(28, 66)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(43, 13)
        Me.SubjectLabel.TabIndex = 1
        Me.SubjectLabel.Text = "Subject"
        '
        'LearnerNameComboBox
        '
        Me.LearnerNameComboBox.FormattingEnabled = True
        Me.LearnerNameComboBox.Location = New System.Drawing.Point(140, 26)
        Me.LearnerNameComboBox.Name = "LearnerNameComboBox"
        Me.LearnerNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.LearnerNameComboBox.TabIndex = 2
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(140, 63)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SubjectComboBox.TabIndex = 3
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(185, 116)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 4
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(104, 116)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(75, 23)
        Me.BackButton.TabIndex = 5
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Location = New System.Drawing.Point(185, 145)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(75, 23)
        Me.HomeButton.TabIndex = 6
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'PrintLearnerComposite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 177)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.LearnerNameComboBox)
        Me.Controls.Add(Me.SubjectLabel)
        Me.Controls.Add(Me.LearnerNameLabel)
        Me.Name = "PrintLearnerComposite"
        Me.Text = "PrintLearnerComposite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LearnerNameLabel As Label
    Friend WithEvents SubjectLabel As Label
    Friend WithEvents LearnerNameComboBox As ComboBox
    Friend WithEvents SubjectComboBox As ComboBox
    Friend WithEvents PrintButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents HomeButton As Button
End Class
