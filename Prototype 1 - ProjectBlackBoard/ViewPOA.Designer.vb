<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPOA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPOA))
        Me.btnHome = New System.Windows.Forms.Button()
        Me.dgvPOA = New System.Windows.Forms.DataGridView()
        Me.btnEditPOA = New System.Windows.Forms.Button()
        Me.Grade = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboGrade = New System.Windows.Forms.ComboBox()
        Me.ListSubjects = New System.Windows.Forms.ListBox()
        Me.Order = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.dgvPOA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(19, 468)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(100, 39)
        Me.btnHome.TabIndex = 5
        Me.btnHome.Text = "Close"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'dgvPOA
        '
        Me.dgvPOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPOA.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPOA.Location = New System.Drawing.Point(287, 36)
        Me.dgvPOA.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPOA.Name = "dgvPOA"
        Me.dgvPOA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPOA.Size = New System.Drawing.Size(732, 406)
        Me.dgvPOA.TabIndex = 1
        '
        'btnEditPOA
        '
        Me.btnEditPOA.Enabled = False
        Me.btnEditPOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPOA.Location = New System.Drawing.Point(901, 468)
        Me.btnEditPOA.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditPOA.Name = "btnEditPOA"
        Me.btnEditPOA.Size = New System.Drawing.Size(118, 39)
        Me.btnEditPOA.TabIndex = 6
        Me.btnEditPOA.Text = "Edit POA"
        Me.btnEditPOA.UseVisualStyleBackColor = True
        '
        'Grade
        '
        Me.Grade.AutoSize = True
        Me.Grade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade.Location = New System.Drawing.Point(14, 43)
        Me.Grade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(46, 16)
        Me.Grade.TabIndex = 3
        Me.Grade.Text = "Grade"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject"
        '
        'ComboGrade
        '
        Me.ComboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboGrade.FormattingEnabled = True
        Me.ComboGrade.Location = New System.Drawing.Point(82, 43)
        Me.ComboGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboGrade.Name = "ComboGrade"
        Me.ComboGrade.Size = New System.Drawing.Size(176, 24)
        Me.ComboGrade.TabIndex = 1
        '
        'ListSubjects
        '
        Me.ListSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListSubjects.FormattingEnabled = True
        Me.ListSubjects.ItemHeight = 16
        Me.ListSubjects.Location = New System.Drawing.Point(82, 96)
        Me.ListSubjects.Margin = New System.Windows.Forms.Padding(4)
        Me.ListSubjects.Name = "ListSubjects"
        Me.ListSubjects.Size = New System.Drawing.Size(176, 180)
        Me.ListSubjects.TabIndex = 2
        '
        'Order
        '
        Me.Order.Controls.Add(Me.RadioButton2)
        Me.Order.Controls.Add(Me.RadioButton1)
        Me.Order.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order.Location = New System.Drawing.Point(18, 313)
        Me.Order.Margin = New System.Windows.Forms.Padding(4)
        Me.Order.Name = "Order"
        Me.Order.Padding = New System.Windows.Forms.Padding(4)
        Me.Order.Size = New System.Drawing.Size(241, 123)
        Me.Order.TabIndex = 7
        Me.Order.TabStop = False
        Me.Order.Text = "Order By: "
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(43, 73)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 20)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Term"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(43, 43)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(108, 20)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Task Number"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ViewPOA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 527)
        Me.Controls.Add(Me.Order)
        Me.Controls.Add(Me.ListSubjects)
        Me.Controls.Add(Me.ComboGrade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Grade)
        Me.Controls.Add(Me.btnEditPOA)
        Me.Controls.Add(Me.dgvPOA)
        Me.Controls.Add(Me.btnHome)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(230, 20)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ViewPOA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ViewPOA"
        CType(Me.dgvPOA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order.ResumeLayout(False)
        Me.Order.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHome As Button
    Friend WithEvents dgvPOA As DataGridView
    Friend WithEvents btnEditPOA As Button
    Friend WithEvents Grade As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboGrade As ComboBox
    Friend WithEvents ListSubjects As ListBox
    Friend WithEvents Order As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
End Class
