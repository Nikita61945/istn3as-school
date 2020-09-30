<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpeningBalance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LeanersComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.CaptureButton = New System.Windows.Forms.Button()
        Me.OpeningBalTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Learner Name"
        '
        'LeanersComboBox
        '
        Me.LeanersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LeanersComboBox.FormattingEnabled = True
        Me.LeanersComboBox.Location = New System.Drawing.Point(124, 27)
        Me.LeanersComboBox.Name = "LeanersComboBox"
        Me.LeanersComboBox.Size = New System.Drawing.Size(176, 21)
        Me.LeanersComboBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Opening Balance R"
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(274, 157)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 31)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'CaptureButton
        '
        Me.CaptureButton.Location = New System.Drawing.Point(193, 157)
        Me.CaptureButton.Name = "CaptureButton"
        Me.CaptureButton.Size = New System.Drawing.Size(75, 31)
        Me.CaptureButton.TabIndex = 2
        Me.CaptureButton.Text = "Capture"
        Me.CaptureButton.UseVisualStyleBackColor = True
        '
        'OpeningBalTextBox
        '
        Me.OpeningBalTextBox.Location = New System.Drawing.Point(124, 67)
        Me.OpeningBalTextBox.Name = "OpeningBalTextBox"
        Me.OpeningBalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OpeningBalTextBox.TabIndex = 1
        '
        'OpeningBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(377, 238)
        Me.Controls.Add(Me.OpeningBalTextBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.CaptureButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeanersComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OpeningBalance"
        Me.Text = "OpeningBalance"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LeanersComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CloseButton As Button
    Friend WithEvents CaptureButton As Button
    Friend WithEvents OpeningBalTextBox As MaskedTextBox
End Class
