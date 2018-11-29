<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddExamstype
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ExamsType = New System.Windows.Forms.TextBox()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam Type"
        '
        'TextBox_ExamsType
        '
        Me.TextBox_ExamsType.Location = New System.Drawing.Point(95, 48)
        Me.TextBox_ExamsType.Name = "TextBox_ExamsType"
        Me.TextBox_ExamsType.Size = New System.Drawing.Size(159, 20)
        Me.TextBox_ExamsType.TabIndex = 1
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(298, 48)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 2
        Me.Button_Save.Text = "Save"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'ExamsGenerator_DBDataSet
        '
        Me.ExamsGenerator_DBDataSet.DataSetName = "ExamsGenerator_DBDataSet"
        Me.ExamsGenerator_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExamsTypetblBindingSource
        '
        Me.ExamsTypetblBindingSource.DataMember = "ExamsType_tbl"
        Me.ExamsTypetblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'ExamsType_tblTableAdapter
        '
        Me.ExamsType_tblTableAdapter.ClearBeforeFill = True
        '
        'AddExamstype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 121)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.TextBox_ExamsType)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "AddExamstype"
        Me.Text = "AddExamstype"
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ExamsType As TextBox
    Friend WithEvents Button_Save As Button
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
End Class
