<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighestArchievers
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
        Me.rbSubject = New System.Windows.Forms.RadioButton()
        Me.rbGrade = New System.Windows.Forms.RadioButton()
        Me.CBSubject = New System.Windows.Forms.ComboBox()
        Me.CBGrade = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'rbSubject
        '
        Me.rbSubject.AutoSize = True
        Me.rbSubject.Location = New System.Drawing.Point(39, 49)
        Me.rbSubject.Name = "rbSubject"
        Me.rbSubject.Size = New System.Drawing.Size(61, 17)
        Me.rbSubject.TabIndex = 0
        Me.rbSubject.TabStop = True
        Me.rbSubject.Text = "Subject"
        Me.rbSubject.UseVisualStyleBackColor = True
        '
        'rbGrade
        '
        Me.rbGrade.AutoSize = True
        Me.rbGrade.Location = New System.Drawing.Point(37, 87)
        Me.rbGrade.Name = "rbGrade"
        Me.rbGrade.Size = New System.Drawing.Size(54, 17)
        Me.rbGrade.TabIndex = 1
        Me.rbGrade.TabStop = True
        Me.rbGrade.Text = "Grade"
        Me.rbGrade.UseVisualStyleBackColor = True
        '
        'CBSubject
        '
        Me.CBSubject.DropDownHeight = 50
        Me.CBSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBSubject.FormattingEnabled = True
        Me.CBSubject.IntegralHeight = False
        Me.CBSubject.Location = New System.Drawing.Point(118, 48)
        Me.CBSubject.MaxDropDownItems = 5
        Me.CBSubject.Name = "CBSubject"
        Me.CBSubject.Size = New System.Drawing.Size(121, 21)
        Me.CBSubject.TabIndex = 2
        '
        'CBGrade
        '
        Me.CBGrade.DropDownHeight = 50
        Me.CBGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGrade.FormattingEnabled = True
        Me.CBGrade.IntegralHeight = False
        Me.CBGrade.Location = New System.Drawing.Point(121, 86)
        Me.CBGrade.MaxDropDownItems = 5
        Me.CBGrade.Name = "CBGrade"
        Me.CBGrade.Size = New System.Drawing.Size(121, 21)
        Me.CBGrade.TabIndex = 3
        '
        'HighestArchievers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 261)
        Me.Controls.Add(Me.CBGrade)
        Me.Controls.Add(Me.CBSubject)
        Me.Controls.Add(Me.rbGrade)
        Me.Controls.Add(Me.rbSubject)
        Me.Name = "HighestArchievers"
        Me.Text = "HighestArchievers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbSubject As RadioButton
    Friend WithEvents rbGrade As RadioButton
    Friend WithEvents CBSubject As ComboBox
    Friend WithEvents CBGrade As ComboBox
End Class
