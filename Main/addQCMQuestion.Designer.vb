<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addQCMQuestion
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_QCMques = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.TextBox_C = New System.Windows.Forms.TextBox()
        Me.TextBox_D = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton_A = New System.Windows.Forms.RadioButton()
        Me.RadioButton_B = New System.Windows.Forms.RadioButton()
        Me.RadioButton_D = New System.Windows.Forms.RadioButton()
        Me.RadioButton_C = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.QCMQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCMQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam Type"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ExamsTypetblBindingSource
        Me.ComboBox1.DisplayMember = "Name_ExamsType"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(95, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
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
        'ExamsType_tblTableAdapter
        '
        Me.ExamsType_tblTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Question "
        '
        'TextBox_QCMques
        '
        Me.TextBox_QCMques.Location = New System.Drawing.Point(95, 67)
        Me.TextBox_QCMques.Multiline = True
        Me.TextBox_QCMques.Name = "TextBox_QCMques"
        Me.TextBox_QCMques.Size = New System.Drawing.Size(393, 83)
        Me.TextBox_QCMques.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Option A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Option B"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Option C"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Option D"
        '
        'TextBox_A
        '
        Me.TextBox_A.Location = New System.Drawing.Point(95, 183)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_A.TabIndex = 8
        '
        'TextBox_B
        '
        Me.TextBox_B.Location = New System.Drawing.Point(95, 210)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_B.TabIndex = 9
        '
        'TextBox_C
        '
        Me.TextBox_C.Location = New System.Drawing.Point(95, 238)
        Me.TextBox_C.Name = "TextBox_C"
        Me.TextBox_C.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_C.TabIndex = 10
        '
        'TextBox_D
        '
        Me.TextBox_D.Location = New System.Drawing.Point(95, 264)
        Me.TextBox_D.Name = "TextBox_D"
        Me.TextBox_D.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_D.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton_A)
        Me.GroupBox1.Controls.Add(Me.RadioButton_B)
        Me.GroupBox1.Controls.Add(Me.RadioButton_D)
        Me.GroupBox1.Controls.Add(Me.RadioButton_C)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 177)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(44, 119)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'RadioButton_A
        '
        Me.RadioButton_A.AutoSize = True
        Me.RadioButton_A.Checked = True
        Me.RadioButton_A.Location = New System.Drawing.Point(6, 9)
        Me.RadioButton_A.Name = "RadioButton_A"
        Me.RadioButton_A.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton_A.TabIndex = 0
        Me.RadioButton_A.TabStop = True
        Me.RadioButton_A.Text = "A"
        Me.RadioButton_A.UseVisualStyleBackColor = True
        '
        'RadioButton_B
        '
        Me.RadioButton_B.AutoSize = True
        Me.RadioButton_B.Location = New System.Drawing.Point(6, 36)
        Me.RadioButton_B.Name = "RadioButton_B"
        Me.RadioButton_B.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton_B.TabIndex = 1
        Me.RadioButton_B.TabStop = True
        Me.RadioButton_B.Text = "B"
        Me.RadioButton_B.UseVisualStyleBackColor = True
        '
        'RadioButton_D
        '
        Me.RadioButton_D.AutoSize = True
        Me.RadioButton_D.Location = New System.Drawing.Point(7, 90)
        Me.RadioButton_D.Name = "RadioButton_D"
        Me.RadioButton_D.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton_D.TabIndex = 3
        Me.RadioButton_D.TabStop = True
        Me.RadioButton_D.Text = "D"
        Me.RadioButton_D.UseVisualStyleBackColor = True
        '
        'RadioButton_C
        '
        Me.RadioButton_C.AutoSize = True
        Me.RadioButton_C.Location = New System.Drawing.Point(7, 64)
        Me.RadioButton_C.Name = "RadioButton_C"
        Me.RadioButton_C.Size = New System.Drawing.Size(32, 17)
        Me.RadioButton_C.TabIndex = 2
        Me.RadioButton_C.TabStop = True
        Me.RadioButton_C.Text = "C"
        Me.RadioButton_C.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(205, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "True Answer"
        '
        'Button_Add
        '
        Me.Button_Add.Location = New System.Drawing.Point(413, 252)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(75, 23)
        Me.Button_Add.TabIndex = 14
        Me.Button_Add.Text = "ADD"
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'QCMQuesttblBindingSource
        '
        Me.QCMQuesttblBindingSource.DataMember = "QCMQuest_tbl"
        Me.QCMQuesttblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'QCMQuest_tblTableAdapter
        '
        Me.QCMQuest_tblTableAdapter.ClearBeforeFill = True
        '
        'addQCMQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 306)
        Me.Controls.Add(Me.Button_Add)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox_D)
        Me.Controls.Add(Me.TextBox_C)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox_QCMques)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addQCMQuestion"
        Me.Text = "addQCMQuestion"
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_QCMques As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents TextBox_C As TextBox
    Friend WithEvents TextBox_D As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton_D As RadioButton
    Friend WithEvents RadioButton_C As RadioButton
    Friend WithEvents RadioButton_B As RadioButton
    Friend WithEvents RadioButton_A As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Button_Add As Button
    Friend WithEvents QCMQuesttblBindingSource As BindingSource
    Friend WithEvents QCMQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter
End Class
