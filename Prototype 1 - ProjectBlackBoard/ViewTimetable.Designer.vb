<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTimetable
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        CType(Me.CreateTT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1077, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Grade "
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(1133, 29)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(187, 26)
        Me.GradeComboBox.TabIndex = 17
        '
        'CreateTT
        '
        Me.CreateTT.AllowDrop = True
        Me.CreateTT.AllowUserToAddRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateTT.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CreateTT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.CreateTT.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreateTT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CreateTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CreateTT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Day, Me.P1, Me.P2, Me.P3, Me.P4, Me.P5, Me.P6, Me.P7, Me.P8, Me.P9})
        Me.CreateTT.Location = New System.Drawing.Point(24, 84)
        Me.CreateTT.Name = "CreateTT"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreateTT.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreateTT.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.CreateTT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CreateTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CreateTT.Size = New System.Drawing.Size(1300, 423)
        Me.CreateTT.TabIndex = 16
        '
        'Day
        '
        Me.Day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Day.HeaderText = "Day"
        Me.Day.Name = "Day"
        Me.Day.ToolTipText = "Oh hi there"
        Me.Day.Width = 90
        '
        'P1
        '
        Me.P1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P1.DefaultCellStyle = DataGridViewCellStyle3
        Me.P1.HeaderText = "8:15 - 8:45"
        Me.P1.Name = "P1"
        Me.P1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.P1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P1.Width = 130
        '
        'P2
        '
        Me.P2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2.DefaultCellStyle = DataGridViewCellStyle4
        Me.P2.HeaderText = "8:45 - 9:15"
        Me.P2.Name = "P2"
        Me.P2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P2.Width = 130
        '
        'P3
        '
        Me.P3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P3.DefaultCellStyle = DataGridViewCellStyle5
        Me.P3.HeaderText = "9:15 - 9:45"
        Me.P3.Name = "P3"
        Me.P3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P3.Width = 130
        '
        'P4
        '
        Me.P4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4.DefaultCellStyle = DataGridViewCellStyle6
        Me.P4.HeaderText = "9:45 - 10:15"
        Me.P4.Name = "P4"
        Me.P4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P4.Width = 130
        '
        'P5
        '
        Me.P5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P5.DefaultCellStyle = DataGridViewCellStyle7
        Me.P5.HeaderText = "10:15 - 10:45"
        Me.P5.Name = "P5"
        Me.P5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P5.Width = 130
        '
        'P6
        '
        Me.P6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P6.DefaultCellStyle = DataGridViewCellStyle8
        Me.P6.HeaderText = "10:45 - 11:15"
        Me.P6.Name = "P6"
        Me.P6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P6.Width = 130
        '
        'P7
        '
        Me.P7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P7.DefaultCellStyle = DataGridViewCellStyle9
        Me.P7.HeaderText = "11:15 - 11:45"
        Me.P7.Name = "P7"
        Me.P7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P7.Width = 130
        '
        'P8
        '
        Me.P8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P8.DefaultCellStyle = DataGridViewCellStyle10
        Me.P8.HeaderText = "11:45 - 12:15"
        Me.P8.Name = "P8"
        Me.P8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P8.Width = 130
        '
        'P9
        '
        Me.P9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P9.DefaultCellStyle = DataGridViewCellStyle11
        Me.P9.HeaderText = "12:15 - 12:45"
        Me.P9.Name = "P9"
        Me.P9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.P9.Width = 130
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(602, 542)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 36)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Delete Timetable"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1209, 542)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Edit Timetable"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Location = New System.Drawing.Point(24, 542)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(118, 36)
        Me.CloseBtn.TabIndex = 19
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'ViewTimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 616)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.CreateTT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Name = "ViewTimetable"
        Me.Text = "ViewTimetable"
        CType(Me.CreateTT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents CreateTT As DataGridView
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents CloseBtn As Button
End Class
