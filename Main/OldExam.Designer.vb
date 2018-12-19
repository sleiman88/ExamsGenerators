<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldExam
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
        Me.DataGridView_OldExams = New System.Windows.Forms.DataGridView()
        Me.OldExamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.Old_Exams_TableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.Old_Exams_TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameExamsTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameExamsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateExamsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdExamsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView_OldExams, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OldExamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView_OldExams
        '
        Me.DataGridView_OldExams.AllowUserToAddRows = False
        Me.DataGridView_OldExams.AllowUserToDeleteRows = False
        Me.DataGridView_OldExams.AutoGenerateColumns = False
        Me.DataGridView_OldExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_OldExams.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameExamsTypeDataGridViewTextBoxColumn, Me.NameExamsDataGridViewTextBoxColumn, Me.DateExamsDataGridViewTextBoxColumn, Me.IdExamsDataGridViewTextBoxColumn})
        Me.DataGridView_OldExams.DataSource = Me.OldExamsBindingSource
        Me.DataGridView_OldExams.Location = New System.Drawing.Point(3, 31)
        Me.DataGridView_OldExams.Name = "DataGridView_OldExams"
        Me.DataGridView_OldExams.ReadOnly = True
        Me.DataGridView_OldExams.Size = New System.Drawing.Size(355, 384)
        Me.DataGridView_OldExams.TabIndex = 0
        '
        'OldExamsBindingSource
        '
        Me.OldExamsBindingSource.DataMember = "Old Exams "
        Me.OldExamsBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'ExamsGenerator_DBDataSet
        '
        Me.ExamsGenerator_DBDataSet.DataSetName = "ExamsGenerator_DBDataSet"
        Me.ExamsGenerator_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Old_Exams_TableAdapter
        '
        Me.Old_Exams_TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Old Exams "
        '
        'NameExamsTypeDataGridViewTextBoxColumn
        '
        Me.NameExamsTypeDataGridViewTextBoxColumn.DataPropertyName = "Name_ExamsType"
        Me.NameExamsTypeDataGridViewTextBoxColumn.HeaderText = "Exam Type"
        Me.NameExamsTypeDataGridViewTextBoxColumn.Name = "NameExamsTypeDataGridViewTextBoxColumn"
        Me.NameExamsTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameExamsTypeDataGridViewTextBoxColumn.Visible = False
        '
        'NameExamsDataGridViewTextBoxColumn
        '
        Me.NameExamsDataGridViewTextBoxColumn.DataPropertyName = "Name_Exams"
        Me.NameExamsDataGridViewTextBoxColumn.HeaderText = "Exam Name "
        Me.NameExamsDataGridViewTextBoxColumn.Name = "NameExamsDataGridViewTextBoxColumn"
        Me.NameExamsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateExamsDataGridViewTextBoxColumn
        '
        Me.DateExamsDataGridViewTextBoxColumn.DataPropertyName = "Date_Exams"
        Me.DateExamsDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateExamsDataGridViewTextBoxColumn.Name = "DateExamsDataGridViewTextBoxColumn"
        Me.DateExamsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdExamsDataGridViewTextBoxColumn
        '
        Me.IdExamsDataGridViewTextBoxColumn.DataPropertyName = "Id_Exams"
        Me.IdExamsDataGridViewTextBoxColumn.HeaderText = "Id_Exams"
        Me.IdExamsDataGridViewTextBoxColumn.Name = "IdExamsDataGridViewTextBoxColumn"
        Me.IdExamsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OldExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 427)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView_OldExams)
        Me.Name = "OldExam"
        Me.Text = "OldExam"
        CType(Me.DataGridView_OldExams, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OldExamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView_OldExams As DataGridView
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents OldExamsBindingSource As BindingSource
    Friend WithEvents Old_Exams_TableAdapter As ExamsGenerator_DBDataSetTableAdapters.Old_Exams_TableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents NameExamsTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameExamsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateExamsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdExamsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
