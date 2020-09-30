<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListTakingSubject
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListTakingSubject))
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.CurrentSubjectsListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GradeComboBox = New System.Windows.Forms.ComboBox()
        Me.NameComboBox = New System.Windows.Forms.ComboBox()
        Me.LearnerNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.Buttondrop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeBtn
        '
        Me.HomeBtn.Location = New System.Drawing.Point(23, 345)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(83, 32)
        Me.HomeBtn.TabIndex = 9
        Me.HomeBtn.Text = "Close"
        Me.HomeBtn.UseVisualStyleBackColor = True
        '
        'CurrentSubjectsListBox
        '
        Me.CurrentSubjectsListBox.FormattingEnabled = True
        Me.CurrentSubjectsListBox.Location = New System.Drawing.Point(23, 114)
        Me.CurrentSubjectsListBox.Name = "CurrentSubjectsListBox"
        Me.CurrentSubjectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.CurrentSubjectsListBox.Size = New System.Drawing.Size(254, 225)
        Me.CurrentSubjectsListBox.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Grade"
        '
        'GradeComboBox
        '
        Me.GradeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeComboBox.FormattingEnabled = True
        Me.GradeComboBox.Location = New System.Drawing.Point(103, 23)
        Me.GradeComboBox.Name = "GradeComboBox"
        Me.GradeComboBox.Size = New System.Drawing.Size(199, 21)
        Me.GradeComboBox.TabIndex = 19
        '
        'NameComboBox
        '
        Me.NameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NameComboBox.FormattingEnabled = True
        Me.NameComboBox.Location = New System.Drawing.Point(103, 55)
        Me.NameComboBox.Name = "NameComboBox"
        Me.NameComboBox.Size = New System.Drawing.Size(199, 21)
        Me.NameComboBox.TabIndex = 18
        '
        'LearnerNameLabel
        '
        Me.LearnerNameLabel.AutoSize = True
        Me.LearnerNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LearnerNameLabel.Location = New System.Drawing.Point(3, 58)
        Me.LearnerNameLabel.Name = "LearnerNameLabel"
        Me.LearnerNameLabel.Size = New System.Drawing.Size(94, 16)
        Me.LearnerNameLabel.TabIndex = 17
        Me.LearnerNameLabel.Text = "Learner Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Learner's Subjects"
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'Buttondrop
        '
        Me.Buttondrop.Location = New System.Drawing.Point(191, 345)
        Me.Buttondrop.Name = "Buttondrop"
        Me.Buttondrop.Size = New System.Drawing.Size(86, 32)
        Me.Buttondrop.TabIndex = 22
        Me.Buttondrop.Text = "Drop Subject"
        Me.Buttondrop.UseVisualStyleBackColor = True
        '
        'ListTakingSubject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 386)
        Me.Controls.Add(Me.Buttondrop)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GradeComboBox)
        Me.Controls.Add(Me.NameComboBox)
        Me.Controls.Add(Me.LearnerNameLabel)
        Me.Controls.Add(Me.CurrentSubjectsListBox)
        Me.Controls.Add(Me.HomeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.Topic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(328, 425)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(328, 425)
        Me.name = "ListTakingSubject"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subjects Taken"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HomeBtn As Button
    Friend WithEvents CurrentSubjectsListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GradeComboBox As ComboBox
    Friend WithEvents NameComboBox As ComboBox
    Friend WithEvents LearnerNameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents Buttondrop As Button
End Class
