<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TutorRegister
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
        Me.DateOfWork = New System.Windows.Forms.DateTimePicker()
        Me.endTime = New System.Windows.Forms.DateTimePicker()
        Me.dgvTutor = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBoxTutor = New System.Windows.Forms.ComboBox()
        Me.startTime = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.DisplayAllButton = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.TutorComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtonBack = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateOfWork
        '
        Me.DateOfWork.CustomFormat = "ddd dd/MM/yy"
        Me.DateOfWork.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfWork.Location = New System.Drawing.Point(111, 55)
        Me.DateOfWork.Name = "DateOfWork"
        Me.DateOfWork.Size = New System.Drawing.Size(121, 22)
        Me.DateOfWork.TabIndex = 0
        '
        'endTime
        '
        Me.endTime.CustomFormat = "HH:mm"
        Me.endTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.endTime.Location = New System.Drawing.Point(111, 118)
        Me.endTime.Name = "endTime"
        Me.endTime.ShowUpDown = True
        Me.endTime.Size = New System.Drawing.Size(76, 22)
        Me.endTime.TabIndex = 2
        '
        'dgvTutor
        '
        Me.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTutor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvTutor.Location = New System.Drawing.Point(30, 80)
        Me.dgvTutor.Name = "dgvTutor"
        Me.dgvTutor.Size = New System.Drawing.Size(604, 157)
        Me.dgvTutor.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.AddButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ComboBoxTutor)
        Me.GroupBox1.Controls.Add(Me.endTime)
        Me.GroupBox1.Controls.Add(Me.startTime)
        Me.GroupBox1.Controls.Add(Me.DateOfWork)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 144)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add to Register"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "End Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Start Time"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(358, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 32)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Save"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tutor"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(358, 79)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ComboBoxTutor
        '
        Me.ComboBoxTutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTutor.FormattingEnabled = True
        Me.ComboBoxTutor.Location = New System.Drawing.Point(111, 19)
        Me.ComboBoxTutor.Name = "ComboBoxTutor"
        Me.ComboBoxTutor.Size = New System.Drawing.Size(165, 24)
        Me.ComboBoxTutor.TabIndex = 3
        '
        'startTime
        '
        Me.startTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.startTime.CalendarForeColor = System.Drawing.Color.White
        Me.startTime.CalendarMonthBackground = System.Drawing.Color.White
        Me.startTime.CalendarTitleBackColor = System.Drawing.Color.White
        Me.startTime.CalendarTitleForeColor = System.Drawing.Color.White
        Me.startTime.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.startTime.CustomFormat = "HH:mm"
        Me.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startTime.Location = New System.Drawing.Point(111, 92)
        Me.startTime.Name = "startTime"
        Me.startTime.ShowUpDown = True
        Me.startTime.Size = New System.Drawing.Size(76, 22)
        Me.startTime.TabIndex = 1
        Me.startTime.Value = New Date(2019, 5, 1, 0, 0, 0, 0)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.EditButton)
        Me.Panel1.Controls.Add(Me.DisplayAllButton)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.TutorComboBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 51)
        Me.Panel1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(404, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(566, 15)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 32)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(485, 15)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 32)
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'DisplayAllButton
        '
        Me.DisplayAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayAllButton.Location = New System.Drawing.Point(318, 15)
        Me.DisplayAllButton.Name = "DisplayAllButton"
        Me.DisplayAllButton.Size = New System.Drawing.Size(75, 32)
        Me.DisplayAllButton.TabIndex = 2
        Me.DisplayAllButton.Text = "Display All"
        Me.DisplayAllButton.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(237, 15)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'TutorComboBox
        '
        Me.TutorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TutorComboBox.FormattingEnabled = True
        Me.TutorComboBox.Location = New System.Drawing.Point(73, 15)
        Me.TutorComboBox.Name = "TutorComboBox"
        Me.TutorComboBox.Size = New System.Drawing.Size(155, 21)
        Me.TutorComboBox.TabIndex = 0
        '
        'ButtonBack
        '
        Me.ButtonBack.Location = New System.Drawing.Point(578, 358)
        Me.ButtonBack.Name = "ButtonBack"
        Me.ButtonBack.Size = New System.Drawing.Size(75, 32)
        Me.ButtonBack.TabIndex = 11
        Me.ButtonBack.Text = "Back"
        Me.ButtonBack.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Tutor"
        '
        'TutorRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 424)
        Me.Controls.Add(Me.ButtonBack)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvTutor)
        Me.Name = "TutorRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TutorRegister"
        CType(Me.dgvTutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateOfWork As DateTimePicker
    Friend WithEvents endTime As DateTimePicker
    Friend WithEvents dgvTutor As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents ComboBoxTutor As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DisplayAllButton As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents TutorComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents startTime As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents Label6 As Label
End Class
