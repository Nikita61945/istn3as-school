<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutstandingMarksForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutstandingMarksForm))
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.dgvOutstanding = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSG = New System.Windows.Forms.RadioButton()
        Me.radTask = New System.Windows.Forms.RadioButton()
        Me.radTerm = New System.Windows.Forms.RadioButton()
        CType(Me.dgvOutstanding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(763, 411)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(100, 39)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Close"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'dgvOutstanding
        '
        Me.dgvOutstanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOutstanding.Location = New System.Drawing.Point(223, 20)
        Me.dgvOutstanding.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvOutstanding.Name = "dgvOutstanding"
        Me.dgvOutstanding.ReadOnly = True
        Me.dgvOutstanding.Size = New System.Drawing.Size(640, 363)
        Me.dgvOutstanding.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radSG)
        Me.GroupBox1.Controls.Add(Me.radTask)
        Me.GroupBox1.Controls.Add(Me.radTerm)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(185, 172)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order By:"
        '
        'radSG
        '
        Me.radSG.AutoSize = True
        Me.radSG.Location = New System.Drawing.Point(32, 124)
        Me.radSG.Margin = New System.Windows.Forms.Padding(4)
        Me.radSG.Name = "radSG"
        Me.radSG.Size = New System.Drawing.Size(64, 20)
        Me.radSG.TabIndex = 2
        Me.radSG.TabStop = True
        Me.radSG.Text = "Grade"
        Me.radSG.UseVisualStyleBackColor = True
        '
        'radTask
        '
        Me.radTask.AutoSize = True
        Me.radTask.Location = New System.Drawing.Point(32, 82)
        Me.radTask.Margin = New System.Windows.Forms.Padding(4)
        Me.radTask.Name = "radTask"
        Me.radTask.Size = New System.Drawing.Size(108, 20)
        Me.radTask.TabIndex = 1
        Me.radTask.TabStop = True
        Me.radTask.Text = "Task Number"
        Me.radTask.UseVisualStyleBackColor = True
        '
        'radTerm
        '
        Me.radTerm.AutoSize = True
        Me.radTerm.Location = New System.Drawing.Point(32, 42)
        Me.radTerm.Margin = New System.Windows.Forms.Padding(4)
        Me.radTerm.Name = "radTerm"
        Me.radTerm.Size = New System.Drawing.Size(58, 20)
        Me.radTerm.TabIndex = 0
        Me.radTerm.TabStop = True
        Me.radTerm.Text = "Term"
        Me.radTerm.UseVisualStyleBackColor = True
        '
        'OutstandingMarksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 464)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvOutstanding)
        Me.Controls.Add(Me.HomeButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OutstandingMarksForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Outstanding Marks"
        CType(Me.dgvOutstanding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents dgvOutstanding As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSG As RadioButton
    Friend WithEvents radTask As RadioButton
    Friend WithEvents radTerm As RadioButton
End Class
