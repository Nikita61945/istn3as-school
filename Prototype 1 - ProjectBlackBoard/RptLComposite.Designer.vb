<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RptLComposite
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RptLComposite))
        Me.DataLearnerCompBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Prototype_1___ProjectBlackBoard.DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataLearnerCompTableAdapter = New Prototype_1___ProjectBlackBoard.DataSet1TableAdapters.DataLearnerCompTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LearnerCB = New System.Windows.Forms.ComboBox()
        CType(Me.DataLearnerCompBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLearnerCompBindingSource
        '
        Me.DataLearnerCompBindingSource.DataMember = "DataLearnerComp"
        Me.DataLearnerCompBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.DocumentMapWidth = 64
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DataLearnerCompBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Prototype_1___ProjectBlackBoard.LearnerComposite.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-1, 107)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(608, 223)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Learner No"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(164, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Year"
        '
        'DataLearnerCompTableAdapter
        '
        Me.DataLearnerCompTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(344, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 51)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Print Learner Composite"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LearnerCB
        '
        Me.LearnerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LearnerCB.FormattingEnabled = True
        Me.LearnerCB.Location = New System.Drawing.Point(164, 28)
        Me.LearnerCB.Name = "LearnerCB"
        Me.LearnerCB.Size = New System.Drawing.Size(142, 21)
        Me.LearnerCB.TabIndex = 6
        '
        'RptLComposite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 329)
        Me.Controls.Add(Me.LearnerCB)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RptLComposite"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Learner Composite"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DataLearnerCompBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataLearnerCompBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataLearnerCompTableAdapter As DataSet1TableAdapters.DataLearnerCompTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents LearnerCB As ComboBox
End Class
