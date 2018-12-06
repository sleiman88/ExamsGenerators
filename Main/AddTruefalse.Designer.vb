<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTruefalse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_TFQues = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton_true = New System.Windows.Forms.RadioButton()
        Me.RadioButton_fasle = New System.Windows.Forms.RadioButton()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_ExamType = New System.Windows.Forms.ComboBox()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.TrueFalsetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrueFalse_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter()
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Question"
        '
        'TextBox_TFQues
        '
        Me.TextBox_TFQues.Location = New System.Drawing.Point(294, 12)
        Me.TextBox_TFQues.Multiline = True
        Me.TextBox_TFQues.Name = "TextBox_TFQues"
        Me.TextBox_TFQues.Size = New System.Drawing.Size(367, 51)
        Me.TextBox_TFQues.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Answer"
        '
        'RadioButton_true
        '
        Me.RadioButton_true.AutoSize = True
        Me.RadioButton_true.Checked = True
        Me.RadioButton_true.Location = New System.Drawing.Point(25, 11)
        Me.RadioButton_true.Name = "RadioButton_true"
        Me.RadioButton_true.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton_true.TabIndex = 3
        Me.RadioButton_true.TabStop = True
        Me.RadioButton_true.Text = "True"
        Me.RadioButton_true.UseVisualStyleBackColor = True
        '
        'RadioButton_fasle
        '
        Me.RadioButton_fasle.AutoSize = True
        Me.RadioButton_fasle.Location = New System.Drawing.Point(25, 37)
        Me.RadioButton_fasle.Name = "RadioButton_fasle"
        Me.RadioButton_fasle.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_fasle.TabIndex = 4
        Me.RadioButton_fasle.TabStop = True
        Me.RadioButton_fasle.Text = "False"
        Me.RadioButton_fasle.UseVisualStyleBackColor = True
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(586, 138)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 5
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_fasle)
        Me.GroupBox1.Controls.Add(Me.RadioButton_true)
        Me.GroupBox1.Location = New System.Drawing.Point(294, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 64)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'ComboBox_ExamType
        '
        Me.ComboBox_ExamType.DataSource = Me.ExamsTypetblBindingSource
        Me.ComboBox_ExamType.DisplayMember = "Name_ExamsType"
        Me.ComboBox_ExamType.FormattingEnabled = True
        Me.ComboBox_ExamType.Location = New System.Drawing.Point(93, 26)
        Me.ComboBox_ExamType.Name = "ComboBox_ExamType"
        Me.ComboBox_ExamType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ExamType.TabIndex = 7
        Me.ComboBox_ExamType.ValueMember = "Id_ExamsType"
        '
        'ExamsTypetblBindingSource
        '
        Me.ExamsTypetblBindingSource.DataMember = "ExamsType_tbl"
        Me.ExamsTypetblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'ExamsGenerator_DBDataSet
        '
        Me.ExamsGenerator_DBDataSet.DataSetName = "ExamsGenerator_DBDataSet"
        Me.ExamsGenerator_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrueFalsetblBindingSource
        '
        Me.TrueFalsetblBindingSource.DataMember = "TrueFalse_tbl"
        Me.TrueFalsetblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'TrueFalse_tblTableAdapter
        '
        Me.TrueFalse_tblTableAdapter.ClearBeforeFill = True
        '
        'ExamsType_tblTableAdapter
        '
        Me.ExamsType_tblTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Exam Type"
        '
        'AddTruefalse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 187)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_ExamType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_TFQues)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddTruefalse"
        Me.Text = "AddTruefalse"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_TFQues As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton_true As RadioButton
    Friend WithEvents RadioButton_fasle As RadioButton
    Friend WithEvents Button_Add As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox_ExamType As ComboBox
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents TrueFalsetblBindingSource As BindingSource
    Friend WithEvents TrueFalse_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
    Friend WithEvents Label3 As Label
End Class
