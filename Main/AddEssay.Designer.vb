<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEssay
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
        Me.TextBox_Essay = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_20 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_15 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_10 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.EssayQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssayQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Essay Question"
        '
        'TextBox_Essay
        '
        Me.TextBox_Essay.Location = New System.Drawing.Point(112, 67)
        Me.TextBox_Essay.Multiline = True
        Me.TextBox_Essay.Name = "TextBox_Essay"
        Me.TextBox_Essay.Size = New System.Drawing.Size(576, 80)
        Me.TextBox_Essay.TabIndex = 1
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(613, 213)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 2
        Me.Button_Add.Text = "Add"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Grade"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_20)
        Me.GroupBox1.Controls.Add(Me.RadioButton_15)
        Me.GroupBox1.Controls.Add(Me.RadioButton_10)
        Me.GroupBox1.Location = New System.Drawing.Point(112, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 42)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_20
        '
        Me.RadioButton_20.AutoSize = True
        Me.RadioButton_20.Location = New System.Drawing.Point(93, 13)
        Me.RadioButton_20.Name = "RadioButton_20"
        Me.RadioButton_20.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton_20.TabIndex = 2
        Me.RadioButton_20.Text = "20"
        Me.RadioButton_20.UseVisualStyleBackColor = True
        '
        'RadioButton_15
        '
        Me.RadioButton_15.AutoSize = True
        Me.RadioButton_15.Location = New System.Drawing.Point(50, 13)
        Me.RadioButton_15.Name = "RadioButton_15"
        Me.RadioButton_15.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton_15.TabIndex = 1
        Me.RadioButton_15.Text = "15"
        Me.RadioButton_15.UseVisualStyleBackColor = True
        '
        'RadioButton_10
        '
        Me.RadioButton_10.AutoSize = True
        Me.RadioButton_10.Checked = True
        Me.RadioButton_10.Location = New System.Drawing.Point(7, 13)
        Me.RadioButton_10.Name = "RadioButton_10"
        Me.RadioButton_10.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton_10.TabIndex = 0
        Me.RadioButton_10.TabStop = True
        Me.RadioButton_10.Text = "10"
        Me.RadioButton_10.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ExamsTypetblBindingSource
        Me.ComboBox1.DisplayMember = "Name_ExamsType"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(78, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "Id_ExamsType"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Exam Type"
        '
        'ExamsType_tblTableAdapter
        '
        Me.ExamsType_tblTableAdapter.ClearBeforeFill = True
        '
        'EssayQuesttblBindingSource
        '
        Me.EssayQuesttblBindingSource.DataMember = "EssayQuest_tbl"
        Me.EssayQuesttblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'EssayQuest_tblTableAdapter
        '
        Me.EssayQuest_tblTableAdapter.ClearBeforeFill = True
        '
        'AddEssay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 243)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.TextBox_Essay)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddEssay"
        Me.Text = "AddEssay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Essay As TextBox
    Friend WithEvents Button_Add As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_20 As RadioButton
    Friend WithEvents RadioButton_15 As RadioButton
    Friend WithEvents RadioButton_10 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
    Friend WithEvents EssayQuesttblBindingSource As BindingSource
    Friend WithEvents EssayQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter
End Class
