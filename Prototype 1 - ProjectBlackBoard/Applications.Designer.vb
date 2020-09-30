<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Applications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Applications))
        Me.RBPend = New System.Windows.Forms.RadioButton()
        Me.RBAccptNoE = New System.Windows.Forms.RadioButton()
        Me.RBAccept = New System.Windows.Forms.RadioButton()
        Me.RBRejected = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RBPend
        '
        Me.RBPend.AutoSize = True
        Me.RBPend.Location = New System.Drawing.Point(340, 45)
        Me.RBPend.Name = "RBPend"
        Me.RBPend.Size = New System.Drawing.Size(64, 17)
        Me.RBPend.TabIndex = 14
        Me.RBPend.TabStop = True
        Me.RBPend.Text = "Pending"
        Me.RBPend.UseVisualStyleBackColor = True
        '
        'RBAccptNoE
        '
        Me.RBAccptNoE.AutoSize = True
        Me.RBAccptNoE.Location = New System.Drawing.Point(438, 45)
        Me.RBAccptNoE.Name = "RBAccptNoE"
        Me.RBAccptNoE.Size = New System.Drawing.Size(162, 17)
        Me.RBAccptNoE.TabIndex = 13
        Me.RBAccptNoE.TabStop = True
        Me.RBAccptNoE.Text = "Accepted and NOT Enrolled "
        Me.RBAccptNoE.UseVisualStyleBackColor = True
        '
        'RBAccept
        '
        Me.RBAccept.AutoSize = True
        Me.RBAccept.Location = New System.Drawing.Point(438, 22)
        Me.RBAccept.Name = "RBAccept"
        Me.RBAccept.Size = New System.Drawing.Size(71, 17)
        Me.RBAccept.TabIndex = 12
        Me.RBAccept.TabStop = True
        Me.RBAccept.Text = "Accepted"
        Me.RBAccept.UseVisualStyleBackColor = True
        '
        'RBRejected
        '
        Me.RBRejected.AutoSize = True
        Me.RBRejected.Location = New System.Drawing.Point(340, 22)
        Me.RBRejected.Name = "RBRejected"
        Me.RBRejected.Size = New System.Drawing.Size(68, 17)
        Me.RBRejected.TabIndex = 11
        Me.RBRejected.TabStop = True
        Me.RBRejected.Text = "Rejected"
        Me.RBRejected.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(738, 286)
        Me.DataGridView1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Grade ID"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(156, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Click on a Application to Open is Details"
        '
        'Applications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 434)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RBPend)
        Me.Controls.Add(Me.RBAccptNoE)
        Me.Controls.Add(Me.RBAccept)
        Me.Controls.Add(Me.RBRejected)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Applications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Applications"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBPend As RadioButton
    Friend WithEvents RBAccptNoE As RadioButton
    Friend WithEvents RBAccept As RadioButton
    Friend WithEvents RBRejected As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
