<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignSubjectstoGrade
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AssignSubjectstoGrade))
        Me.EditButton = New System.Windows.Forms.Button()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SubjectsListBox = New System.Windows.Forms.ListBox()
        Me.SubGradeListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'EditButton
        '
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(520, 47)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 32)
        Me.EditButton.TabIndex = 5
        Me.EditButton.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.EditButton, "Select a Subject to edit its Details")
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(533, 364)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 32)
        Me.HomeBtn.TabIndex = 7
        Me.HomeBtn.Text = "Close"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Subjects Not Yet Allocated"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(127, 12)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GradeComboBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select Grade"
        '
        'SubjectsListBox
        '
        Me.SubjectsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectsListBox.FormattingEnabled = True
        Me.SubjectsListBox.ItemHeight = 15
        Me.SubjectsListBox.Location = New System.Drawing.Point(12, 87)
        Me.SubjectsListBox.Name = "SubjectsListBox"
        Me.SubjectsListBox.Size = New System.Drawing.Size(275, 259)
        Me.SubjectsListBox.TabIndex = 2
        '
        'SubGradeListBox
        '
        Me.SubGradeListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubGradeListBox.FormattingEnabled = True
        Me.SubGradeListBox.ItemHeight = 15
        Me.SubGradeListBox.Location = New System.Drawing.Point(324, 87)
        Me.SubGradeListBox.Name = "SubGradeListBox"
        Me.SubGradeListBox.Size = New System.Drawing.Size(284, 259)
        Me.SubGradeListBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(321, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Subject Already Allocated"
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(212, 49)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 32)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Choose a Subject to Add to Selected Grade"
        '
        'AssignSubjectstoGrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 418)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SubGradeListBox)
        Me.Controls.Add(Me.SubjectsListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.EditButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AssignSubjectstoGrade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assign Subjects to Grade"
        Me.ToolTip1.SetToolTip(Me, "Select a Grade First")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditButton As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SubjectsListBox As ListBox
    Friend WithEvents SubGradeListBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
