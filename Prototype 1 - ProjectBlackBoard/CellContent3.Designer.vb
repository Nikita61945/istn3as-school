<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellContent3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CellContent3))
        Me.CloseName = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'CloseName
        '
        Me.CloseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseName.Location = New System.Drawing.Point(15, 147)
        Me.CloseName.Name = "CloseName"
        Me.CloseName.Size = New System.Drawing.Size(118, 36)
        Me.CloseName.TabIndex = 14
        Me.CloseName.Text = "Close"
        Me.CloseName.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(466, 147)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(118, 36)
        Me.SaveBtn.TabIndex = 13
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Cell Content"
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.BackColor = System.Drawing.SystemColors.Control
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel.Location = New System.Drawing.Point(15, 27)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(569, 94)
        Me.panel.TabIndex = 11
        '
        'CellContent3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 196)
        Me.Controls.Add(Me.CloseName)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CellContent3"
        Me.Text = "Edit Subjects"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseName As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents panel As Panel
End Class
