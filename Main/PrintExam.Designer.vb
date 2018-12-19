<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintExam
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Exams_tblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Exams_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.Exams_tblTableAdapter()
        Me.GetQCMQuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetQCMQuesTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.getQCMQuesTableAdapter()
        Me.GetTrueFQuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetTrueFQuesTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.getTrueFQuesTableAdapter()
        Me.GetEssayQuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetEssayQuesTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.getEssayQuesTableAdapter()
        CType(Me.Exams_tblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetQCMQuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetTrueFQuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetEssayQuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Exams_tblBindingSource
        '
        Me.Exams_tblBindingSource.DataMember = "Exams_tbl"
        Me.Exams_tblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'ExamsGenerator_DBDataSet
        '
        Me.ExamsGenerator_DBDataSet.DataSetName = "ExamsGenerator_DBDataSet"
        Me.ExamsGenerator_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.Exams_tblBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Main.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 757)
        Me.ReportViewer1.TabIndex = 0
        '
        'Exams_tblTableAdapter
        '
        Me.Exams_tblTableAdapter.ClearBeforeFill = True
        '
        'GetQCMQuesBindingSource
        '
        Me.GetQCMQuesBindingSource.DataMember = "getQCMQues"
        Me.GetQCMQuesBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'GetQCMQuesTableAdapter
        '
        Me.GetQCMQuesTableAdapter.ClearBeforeFill = True
        '
        'GetTrueFQuesBindingSource
        '
        Me.GetTrueFQuesBindingSource.DataMember = "getTrueFQues"
        Me.GetTrueFQuesBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'GetTrueFQuesTableAdapter
        '
        Me.GetTrueFQuesTableAdapter.ClearBeforeFill = True
        '
        'GetEssayQuesBindingSource
        '
        Me.GetEssayQuesBindingSource.DataMember = "getEssayQues"
        Me.GetEssayQuesBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'GetEssayQuesTableAdapter
        '
        Me.GetEssayQuesTableAdapter.ClearBeforeFill = True
        '
        'PrintExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 757)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "PrintExam"
        Me.Text = "PrintExam"
        CType(Me.Exams_tblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetQCMQuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetTrueFQuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetEssayQuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Exams_tblBindingSource As BindingSource
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents Exams_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.Exams_tblTableAdapter
    Friend WithEvents GetQCMQuesBindingSource As BindingSource
    Friend WithEvents GetQCMQuesTableAdapter As ExamsGenerator_DBDataSetTableAdapters.getQCMQuesTableAdapter
    Friend WithEvents GetTrueFQuesBindingSource As BindingSource
    Friend WithEvents GetTrueFQuesTableAdapter As ExamsGenerator_DBDataSetTableAdapters.getTrueFQuesTableAdapter
    Friend WithEvents GetEssayQuesBindingSource As BindingSource
    Friend WithEvents GetEssayQuesTableAdapter As ExamsGenerator_DBDataSetTableAdapters.getEssayQuesTableAdapter
End Class
