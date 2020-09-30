<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tblAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MSDataset = New reportmodule.MSDataset()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataSet1 = New reportmodule.DataSet1()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New reportmodule.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.tblLearnerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblLearnerTableAdapter = New reportmodule.MSDatasetTableAdapters.tblLearnerTableAdapter()
        Me.tblAccountTableAdapter = New reportmodule.MSDatasetTableAdapters.tblAccountTableAdapter()
        CType(Me.tblAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSDataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tblLearnerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblAccountBindingSource
        '
        Me.tblAccountBindingSource.DataMember = "tblAccount"
        Me.tblAccountBindingSource.DataSource = Me.MSDataset
        '
        'MSDataset
        '
        Me.MSDataset.DataSetName = "MSDataset"
        Me.MSDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MSHeader"
        ReportDataSource1.Value = Me.tblLearnerBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "reportmodule.MSTop.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(717, 458)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'tblLearnerBindingSource
        '
        Me.tblLearnerBindingSource.DataMember = "tblLearner"
        Me.tblLearnerBindingSource.DataSource = Me.MSDataset
        '
        'tblLearnerTableAdapter
        '
        Me.tblLearnerTableAdapter.ClearBeforeFill = True
        '
        'tblAccountTableAdapter
        '
        Me.tblAccountTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 458)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.tblAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSDataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tblLearnerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents DataTable1TableAdapter As DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents tblLearnerBindingSource As BindingSource
    Friend WithEvents MSDataset As MSDataset
    Friend WithEvents tblLearnerTableAdapter As MSDatasetTableAdapters.tblLearnerTableAdapter
    Friend WithEvents tblAccountBindingSource As BindingSource
    Friend WithEvents tblAccountTableAdapter As MSDatasetTableAdapters.tblAccountTableAdapter
End Class
