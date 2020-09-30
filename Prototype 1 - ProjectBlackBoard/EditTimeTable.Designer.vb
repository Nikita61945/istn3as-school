<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTimeTable
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditTimeTable))
        Me.CreateTT = New System.Windows.Forms.DataGridView()
        Me.Day = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel = New System.Windows.Forms.Panel()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.CreateTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CreateTT
        '
        Me.CreateTT.AllowDrop = True
        Me.CreateTT.AllowUserToAddRows = False
        Me.CreateTT.AllowUserToDeleteRows = False
        Me.CreateTT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.CreateTT.BackgroundColor = System.Drawing.SystemColors.Window
        Me.CreateTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreateTT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Day, Me.P1, Me.P2, Me.P3, Me.P4, Me.P5, Me.P6, Me.P7, Me.P8, Me.P9})
        Me.CreateTT.Location = New System.Drawing.Point(18, 176)
        Me.CreateTT.Name = "CreateTT"
        Me.CreateTT.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreateTT.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CreateTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CreateTT.Size = New System.Drawing.Size(1300, 423)
        Me.CreateTT.TabIndex = 7
        '
        'Day
        '
        Me.Day.HeaderText = "Day"
        Me.Day.Name = "Day"
        Me.Day.ReadOnly = True
        Me.Day.ToolTipText = "Oh hi there"
        Me.Day.Width = 90
        '
        'P1
        '
        Me.P1.HeaderText = "8:15 - 8:45"
        Me.P1.Name = "P1"
        Me.P1.ReadOnly = True
        Me.P1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.P1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P1.Width = 130
        '
        'P2
        '
        Me.P2.HeaderText = "8:45 - 9:15"
        Me.P2.Name = "P2"
        Me.P2.ReadOnly = True
        Me.P2.Width = 130
        '
        'P3
        '
        Me.P3.HeaderText = "9:15 - 9:45"
        Me.P3.Name = "P3"
        Me.P3.ReadOnly = True
        Me.P3.Width = 130
        '
        'P4
        '
        Me.P4.HeaderText = "9:45 - 10:15"
        Me.P4.Name = "P4"
        Me.P4.ReadOnly = True
        Me.P4.Width = 130
        '
        'P5
        '
        Me.P5.HeaderText = "10:15 - 10:45"
        Me.P5.Name = "P5"
        Me.P5.ReadOnly = True
        Me.P5.Width = 130
        '
        'P6
        '
        Me.P6.HeaderText = "10:45 - 11:15"
        Me.P6.Name = "P6"
        Me.P6.ReadOnly = True
        Me.P6.Width = 130
        '
        'P7
        '
        Me.P7.HeaderText = "11:15 - 11:45"
        Me.P7.Name = "P7"
        Me.P7.ReadOnly = True
        Me.P7.Width = 130
        '
        'P8
        '
        Me.P8.HeaderText = "11:45 - 12:15"
        Me.P8.Name = "P8"
        Me.P8.ReadOnly = True
        Me.P8.Width = 130
        '
        'P9
        '
        Me.P9.HeaderText = "12:15 - 12:45"
        Me.P9.Name = "P9"
        Me.P9.ReadOnly = True
        Me.P9.Width = 130
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subjects"
        '
        'panel
        '
        Me.panel.AutoScroll = True
        Me.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel.Location = New System.Drawing.Point(349, 54)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(969, 82)
        Me.panel.TabIndex = 12
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Location = New System.Drawing.Point(18, 630)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(118, 36)
        Me.CloseBtn.TabIndex = 11
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Grade "
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(105, 82)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(187, 26)
        Me.GradeComboBox.TabIndex = 9
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(1201, 630)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(118, 36)
        Me.SaveBtn.TabIndex = 8
        Me.SaveBtn.Text = "Update Table"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1067, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 18)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tutor has not indicated available slots"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(771, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 18)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Tutor has indicated available slots"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.Location = New System.Drawing.Point(1031, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 24)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.Location = New System.Drawing.Point(735, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 24)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EditTimeTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1331, 678)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel)
        Me.Controls.Add(Me.CreateTT)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.SaveBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditTimeTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit TimeTable"
        CType(Me.CreateTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CreateTT As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents panel As Panel
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Day As DataGridViewTextBoxColumn
    Friend WithEvents P1 As DataGridViewTextBoxColumn
    Friend WithEvents P2 As DataGridViewTextBoxColumn
    Friend WithEvents P3 As DataGridViewTextBoxColumn
    Friend WithEvents P4 As DataGridViewTextBoxColumn
    Friend WithEvents P5 As DataGridViewTextBoxColumn
    Friend WithEvents P6 As DataGridViewTextBoxColumn
    Friend WithEvents P7 As DataGridViewTextBoxColumn
    Friend WithEvents P8 As DataGridViewTextBoxColumn
    Friend WithEvents P9 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
