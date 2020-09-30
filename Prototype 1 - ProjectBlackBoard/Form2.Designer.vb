<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetupRooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetupRooms))
        Me.DataEOYcompTableAdapter1 = New Prototype_1___ProjectBlackBoard.DataSet1TableAdapters.dataEOYcompTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.CapacityNUD = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonCan = New System.Windows.Forms.Button()
        CType(Me.CapacityNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataEOYcompTableAdapter1
        '
        Me.DataEOYcompTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Room Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Room Capacity"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(357, 120)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 32)
        Me.ButtonDelete.TabIndex = 3
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(328, 15)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 32)
        Me.ButtonSave.TabIndex = 5
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(357, 82)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 32)
        Me.ButtonEdit.TabIndex = 2
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'CapacityNUD
        '
        Me.CapacityNUD.Location = New System.Drawing.Point(155, 59)
        Me.CapacityNUD.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.CapacityNUD.Name = "CapacityNUD"
        Me.CapacityNUD.Size = New System.Drawing.Size(120, 20)
        Me.CapacityNUD.TabIndex = 2
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(155, 22)
        Me.TextBoxName.MaxLength = 15
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'dgvRooms
        '
        Me.dgvRooms.AllowUserToAddRows = False
        Me.dgvRooms.AllowUserToDeleteRows = False
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(36, 38)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.ReadOnly = True
        Me.dgvRooms.Size = New System.Drawing.Size(288, 182)
        Me.dgvRooms.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonCan)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxName)
        Me.Panel1.Controls.Add(Me.ButtonSave)
        Me.Panel1.Controls.Add(Me.CapacityNUD)
        Me.Panel1.Location = New System.Drawing.Point(29, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(428, 115)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Select a Room to edit or delete it"
        '
        'ButtonCan
        '
        Me.ButtonCan.Location = New System.Drawing.Point(328, 59)
        Me.ButtonCan.Name = "ButtonCan"
        Me.ButtonCan.Size = New System.Drawing.Size(75, 32)
        Me.ButtonCan.TabIndex = 11
        Me.ButtonCan.Text = "Cancel"
        Me.ButtonCan.UseVisualStyleBackColor = True
        '
        'SetupRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 424)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetupRooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setup Rooms/ Classrooms"
        CType(Me.CapacityNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataEOYcompTableAdapter1 As DataSet1TableAdapters.dataEOYcompTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents CapacityNUD As NumericUpDown
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonCan As Button
End Class
