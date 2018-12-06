<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTrueFalseQuestions
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Question = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_True = New System.Windows.Forms.RadioButton()
        Me.RadioButton_False = New System.Windows.Forms.RadioButton()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam type"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ExamsTypetblBindingSource
        Me.ComboBox1.DisplayMember = "Name_ExamsType"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(77, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "Id_ExamsType"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Question"
        '
        'TextBox_Question
        '
        Me.TextBox_Question.Location = New System.Drawing.Point(77, 79)
        Me.TextBox_Question.Multiline = True
        Me.TextBox_Question.Name = "TextBox_Question"
        Me.TextBox_Question.Size = New System.Drawing.Size(285, 63)
        Me.TextBox_Question.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Anwer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_False)
        Me.GroupBox1.Controls.Add(Me.RadioButton_True)
        Me.GroupBox1.Location = New System.Drawing.Point(77, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 34)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_True
        '
        Me.RadioButton_True.AutoSize = True
        Me.RadioButton_True.Location = New System.Drawing.Point(7, 11)
        Me.RadioButton_True.Name = "RadioButton_True"
        Me.RadioButton_True.Size = New System.Drawing.Size(47, 17)
        Me.RadioButton_True.TabIndex = 0
        Me.RadioButton_True.TabStop = True
        Me.RadioButton_True.Text = "True"
        Me.RadioButton_True.UseVisualStyleBackColor = True
        '
        'RadioButton_False
        '
        Me.RadioButton_False.AutoSize = True
        Me.RadioButton_False.Location = New System.Drawing.Point(80, 12)
        Me.RadioButton_False.Name = "RadioButton_False"
        Me.RadioButton_False.Size = New System.Drawing.Size(50, 17)
        Me.RadioButton_False.TabIndex = 1
        Me.RadioButton_False.TabStop = True
        Me.RadioButton_False.Text = "False"
        Me.RadioButton_False.UseVisualStyleBackColor = True
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(287, 230)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 6
        Me.Button_Save.Text = "Add"
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
        'AddTrueFalseQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 262)
        Me.Controls.Add(Me.Button_Save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_Question)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "AddTrueFalseQuestions"
        Me.Text = "AddTrueFalseQuestions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Question As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_False As RadioButton
    Friend WithEvents RadioButton_True As RadioButton
    Friend WithEvents Button_Save As Button
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
End Class
