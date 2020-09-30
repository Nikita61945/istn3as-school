<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CaptureMarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaptureMarks))
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCM = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.Subject = New System.Windows.Forms.Label()
        Me.GradeChoice = New System.Windows.Forms.ComboBox()
        Me.listSub = New System.Windows.Forms.ListBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLabel.Location = New System.Drawing.Point(36, 38)
        Me.GradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(46, 16)
        Me.GradeLabel.TabIndex = 0
        Me.GradeLabel.Text = "Grade"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(345, 41)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(655, 400)
        Me.DataGridView1.TabIndex = 3
        '
        'btnCM
        '
        Me.btnCM.Enabled = False
        Me.btnCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCM.Location = New System.Drawing.Point(925, 458)
        Me.btnCM.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCM.Name = "btnCM"
        Me.btnCM.Size = New System.Drawing.Size(75, 32)
        Me.btnCM.TabIndex = 4
        Me.btnCM.Text = "Capture Mark"
        Me.btnCM.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(925, 498)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 32)
        Me.HomeBtn.TabIndex = 5
        Me.HomeBtn.Text = "Close"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'Subject
        '
        Me.Subject.AutoSize = True
        Me.Subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject.Location = New System.Drawing.Point(20, 84)
        Me.Subject.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(53, 16)
        Me.Subject.TabIndex = 7
        Me.Subject.Text = "Subject"
        '
        'GradeChoice
        '
        Me.GradeChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeChoice.FormattingEnabled = True
        Me.GradeChoice.Location = New System.Drawing.Point(115, 37)
        Me.GradeChoice.Margin = New System.Windows.Forms.Padding(4)
        Me.GradeChoice.Name = "GradeChoice"
        Me.GradeChoice.Size = New System.Drawing.Size(160, 24)
        Me.GradeChoice.TabIndex = 6
        '
        'listSub
        '
        Me.listSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listSub.FormattingEnabled = True
        Me.listSub.ItemHeight = 16
        Me.listSub.Location = New System.Drawing.Point(107, 85)
        Me.listSub.Margin = New System.Windows.Forms.Padding(4)
        Me.listSub.Name = "listSub"
        Me.listSub.Size = New System.Drawing.Size(200, 292)
        Me.listSub.TabIndex = 8
        '
        'CaptureMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 553)
        Me.Controls.Add(Me.listSub)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.GradeChoice)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.btnCM)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GradeLabel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(225, 25)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CaptureMarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CaptureMarks"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GradeLabel As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCM As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Subject As Label
    Friend WithEvents GradeChoice As ComboBox
    Friend WithEvents listSub As ListBox
End Class
