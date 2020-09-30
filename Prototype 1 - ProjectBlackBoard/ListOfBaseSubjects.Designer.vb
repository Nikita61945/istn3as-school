<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfBaseSubjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListOfBaseSubjects))
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.IsOfferedCheckBox = New System.Windows.Forms.CheckBox()
        Me.IsOffLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.SubjectListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubNameTextBox = New System.Windows.Forms.TextBox()
        Me.SubCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayOrderVal = New System.Windows.Forms.NumericUpDown()
        Me.DisplayOrder = New System.Windows.Forms.Label()
        CType(Me.DisplayOrderVal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeBtn
        '
        Me.HomeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeBtn.Location = New System.Drawing.Point(523, 265)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(75, 32)
        Me.HomeBtn.TabIndex = 7
        Me.HomeBtn.Text = "Close"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(523, 210)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 32)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'EditButton
        '
        Me.EditButton.Enabled = False
        Me.EditButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(424, 210)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 32)
        Me.EditButton.TabIndex = 1
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Enabled = False
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(334, 210)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 32)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'IsOfferedCheckBox
        '
        Me.IsOfferedCheckBox.AutoSize = True
        Me.IsOfferedCheckBox.Location = New System.Drawing.Point(447, 164)
        Me.IsOfferedCheckBox.Name = "IsOfferedCheckBox"
        Me.IsOfferedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.IsOfferedCheckBox.TabIndex = 5
        Me.IsOfferedCheckBox.UseVisualStyleBackColor = True
        '
        'IsOffLabel
        '
        Me.IsOffLabel.AutoSize = True
        Me.IsOffLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsOffLabel.Location = New System.Drawing.Point(306, 165)
        Me.IsOffLabel.Name = "IsOffLabel"
        Me.IsOffLabel.Size = New System.Drawing.Size(65, 16)
        Me.IsOffLabel.TabIndex = 12
        Me.IsOffLabel.Text = "Is Offered"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLabel.Location = New System.Drawing.Point(306, 101)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(117, 16)
        Me.GradeLabel.TabIndex = 11
        Me.GradeLabel.Text = "Subject Full Name"
        '
        'SubjectListBox
        '
        Me.SubjectListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectListBox.FormattingEnabled = True
        Me.SubjectListBox.ItemHeight = 15
        Me.SubjectListBox.Location = New System.Drawing.Point(36, 50)
        Me.SubjectListBox.Name = "SubjectListBox"
        Me.SubjectListBox.ScrollAlwaysVisible = True
        Me.SubjectListBox.Size = New System.Drawing.Size(249, 274)
        Me.SubjectListBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "List of Subjects :"
        '
        'SubNameTextBox
        '
        Me.SubNameTextBox.Location = New System.Drawing.Point(447, 99)
        Me.SubNameTextBox.Name = "SubNameTextBox"
        Me.SubNameTextBox.Size = New System.Drawing.Size(151, 20)
        Me.SubNameTextBox.TabIndex = 3
        '
        'SubCodeTextBox
        '
        Me.SubCodeTextBox.Location = New System.Drawing.Point(447, 69)
        Me.SubCodeTextBox.Name = "SubCodeTextBox"
        Me.SubCodeTextBox.Size = New System.Drawing.Size(151, 20)
        Me.SubCodeTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Subject Code"
        '
        'DisplayOrderVal
        '
        Me.DisplayOrderVal.Location = New System.Drawing.Point(447, 130)
        Me.DisplayOrderVal.Name = "DisplayOrderVal"
        Me.DisplayOrderVal.Size = New System.Drawing.Size(120, 20)
        Me.DisplayOrderVal.TabIndex = 4
        '
        'DisplayOrder
        '
        Me.DisplayOrder.AutoSize = True
        Me.DisplayOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayOrder.Location = New System.Drawing.Point(306, 131)
        Me.DisplayOrder.Name = "DisplayOrder"
        Me.DisplayOrder.Size = New System.Drawing.Size(91, 16)
        Me.DisplayOrder.TabIndex = 23
        Me.DisplayOrder.Text = "Display Order"
        '
        'ListOfBaseSubjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 364)
        Me.Controls.Add(Me.DisplayOrder)
        Me.Controls.Add(Me.DisplayOrderVal)
        Me.Controls.Add(Me.SubCodeTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HomeBtn)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.IsOfferedCheckBox)
        Me.Controls.Add(Me.IsOffLabel)
        Me.Controls.Add(Me.GradeLabel)
        Me.Controls.Add(Me.SubjectListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListOfBaseSubjects"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Base Subjects"
        CType(Me.DisplayOrderVal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeBtn As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents IsOfferedCheckBox As CheckBox
    Friend WithEvents IsOffLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents SubjectListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SubNameTextBox As TextBox
    Friend WithEvents SubCodeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayOrderVal As NumericUpDown
    Friend WithEvents DisplayOrder As Label
End Class
