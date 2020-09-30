<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenFeeStForm
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
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeBtn
        '
        Me.HomeBtn.Location = New System.Drawing.Point(24, 218)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 23)
        Me.HomeBtn.TabIndex = 0
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'GenFeeStForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.HomeBtn)
        Me.Name = "GenFeeStForm"
        Me.Text = "GenFeeStForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeBtn As Button
End Class
