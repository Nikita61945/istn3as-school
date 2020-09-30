<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListOfLearnersTakingSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListOfLearnersTakingSubject))
        Me.NamesRTB = New System.Windows.Forms.RichTextBox()
        Me.SubjectsListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.LabelLNUmber = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NamesRTB
        '
        Me.NamesRTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamesRTB.Location = New System.Drawing.Point(308, 68)
        Me.NamesRTB.Name = "NamesRTB"
        Me.NamesRTB.Size = New System.Drawing.Size(249, 264)
        Me.NamesRTB.TabIndex = 7
        Me.NamesRTB.Text = ""
        '
        'SubjectsListBox
        '
        Me.SubjectsListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectsListBox.FormattingEnabled = True
        Me.SubjectsListBox.ItemHeight = 16
        Me.SubjectsListBox.Location = New System.Drawing.Point(30, 68)
        Me.SubjectsListBox.Name = "SubjectsListBox"
        Me.SubjectsListBox.Size = New System.Drawing.Size(258, 260)
        Me.SubjectsListBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Grade : "
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(86, 26)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(121, 23)
        Me.GradeComboBox.TabIndex = 4
        '
        'LabelLNUmber
        '
        Me.LabelLNUmber.AutoSize = True
        Me.LabelLNUmber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLNUmber.Location = New System.Drawing.Point(309, 344)
        Me.LabelLNUmber.Name = "LabelLNUmber"
        Me.LabelLNUmber.Size = New System.Drawing.Size(0, 16)
        Me.LabelLNUmber.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListOfLearnersTakingSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 389)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelLNUmber)
        Me.Controls.Add(Me.NamesRTB)
        Me.Controls.Add(Me.SubjectsListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradeComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListOfLearnersTakingSubject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Of Learners Taking Subject"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NamesRTB As RichTextBox
    Friend WithEvents SubjectsListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents LabelLNUmber As Label
    Public WithEvents Button1 As Button
End Class
