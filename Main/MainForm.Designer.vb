<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_TFQue = New System.Windows.Forms.TextBox()
        Me.TextBox_Essay = New System.Windows.Forms.TextBox()
        Me.TextBox_QCM = New System.Windows.Forms.TextBox()
        Me.Button_GenerateExam = New System.Windows.Forms.Button()
        Me.Button_Old = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTrueOrFalseQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEssayQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddQCMQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.EssayQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssayQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter()
        Me.TrueFalsetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrueFalse_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter()
        Me.QCMQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCMQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter()
        Me.ComboBox_ExamType = New System.Windows.Forms.ComboBox()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddExamTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "True or False Questions "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "QCM Questions "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Essay Questions "
        '
        'TextBox_TFQue
        '
        Me.TextBox_TFQue.Enabled = False
        Me.TextBox_TFQue.Location = New System.Drawing.Point(199, 55)
        Me.TextBox_TFQue.Name = "TextBox_TFQue"
        Me.TextBox_TFQue.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_TFQue.TabIndex = 3
        '
        'TextBox_Essay
        '
        Me.TextBox_Essay.Enabled = False
        Me.TextBox_Essay.Location = New System.Drawing.Point(199, 123)
        Me.TextBox_Essay.Name = "TextBox_Essay"
        Me.TextBox_Essay.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_Essay.TabIndex = 4
        '
        'TextBox_QCM
        '
        Me.TextBox_QCM.Enabled = False
        Me.TextBox_QCM.Location = New System.Drawing.Point(199, 91)
        Me.TextBox_QCM.Name = "TextBox_QCM"
        Me.TextBox_QCM.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_QCM.TabIndex = 5
        '
        'Button_GenerateExam
        '
        Me.Button_GenerateExam.Location = New System.Drawing.Point(265, 181)
        Me.Button_GenerateExam.Name = "Button_GenerateExam"
        Me.Button_GenerateExam.Size = New System.Drawing.Size(75, 23)
        Me.Button_GenerateExam.TabIndex = 6
        Me.Button_GenerateExam.Text = "Generate Exam"
        Me.Button_GenerateExam.UseVisualStyleBackColor = True
        '
        'Button_Old
        '
        Me.Button_Old.Location = New System.Drawing.Point(265, 210)
        Me.Button_Old.Name = "Button_Old"
        Me.Button_Old.Size = New System.Drawing.Size(75, 23)
        Me.Button_Old.TabIndex = 7
        Me.Button_Old.Text = "OLD Exams"
        Me.Button_Old.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(457, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddQuestionsToolStripMenuItem, Me.AddExamTypeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddQuestionsToolStripMenuItem
        '
        Me.AddQuestionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTrueOrFalseQuestionsToolStripMenuItem, Me.AddEssayQuestionsToolStripMenuItem, Me.AddQCMQuestionsToolStripMenuItem})
        Me.AddQuestionsToolStripMenuItem.Name = "AddQuestionsToolStripMenuItem"
        Me.AddQuestionsToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AddQuestionsToolStripMenuItem.Text = "Add Questions "
        '
        'AddTrueOrFalseQuestionsToolStripMenuItem
        '
        Me.AddTrueOrFalseQuestionsToolStripMenuItem.Name = "AddTrueOrFalseQuestionsToolStripMenuItem"
        Me.AddTrueOrFalseQuestionsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AddTrueOrFalseQuestionsToolStripMenuItem.Text = "Add True or False questions "
        '
        'AddEssayQuestionsToolStripMenuItem
        '
        Me.AddEssayQuestionsToolStripMenuItem.Name = "AddEssayQuestionsToolStripMenuItem"
        Me.AddEssayQuestionsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AddEssayQuestionsToolStripMenuItem.Text = "Add Essay Questions "
        '
        'AddQCMQuestionsToolStripMenuItem
        '
        Me.AddQCMQuestionsToolStripMenuItem.Name = "AddQCMQuestionsToolStripMenuItem"
        Me.AddQCMQuestionsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AddQCMQuestionsToolStripMenuItem.Text = "Add QCM Questions "
        '
        'ExamsGenerator_DBDataSet
        '
        Me.ExamsGenerator_DBDataSet.DataSetName = "ExamsGenerator_DBDataSet"
        Me.ExamsGenerator_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TrueFalsetblBindingSource
        '
        Me.TrueFalsetblBindingSource.DataMember = "TrueFalse_tbl"
        Me.TrueFalsetblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'TrueFalse_tblTableAdapter
        '
        Me.TrueFalse_tblTableAdapter.ClearBeforeFill = True
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
        'ComboBox_ExamType
        '
        Me.ComboBox_ExamType.DataSource = Me.ExamsTypetblBindingSource
        Me.ComboBox_ExamType.DisplayMember = "Name_ExamsType"
        Me.ComboBox_ExamType.FormattingEnabled = True
        Me.ComboBox_ExamType.Location = New System.Drawing.Point(130, 163)
        Me.ComboBox_ExamType.Name = "ComboBox_ExamType"
        Me.ComboBox_ExamType.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_ExamType.TabIndex = 9
        Me.ComboBox_ExamType.ValueMember = "Id_ExamsType"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Exam Type"
        '
        'AddExamTypeToolStripMenuItem
        '
        Me.AddExamTypeToolStripMenuItem.Name = "AddExamTypeToolStripMenuItem"
        Me.AddExamTypeToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AddExamTypeToolStripMenuItem.Text = "Add Exam type"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 245)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox_ExamType)
        Me.Controls.Add(Me.Button_Old)
        Me.Controls.Add(Me.Button_GenerateExam)
        Me.Controls.Add(Me.TextBox_QCM)
        Me.Controls.Add(Me.TextBox_Essay)
        Me.Controls.Add(Me.TextBox_TFQue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_TFQue As TextBox
    Friend WithEvents TextBox_Essay As TextBox
    Friend WithEvents TextBox_QCM As TextBox
    Friend WithEvents Button_GenerateExam As Button
    Friend WithEvents Button_Old As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTrueOrFalseQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEssayQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddQCMQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents EssayQuesttblBindingSource As BindingSource
    Friend WithEvents EssayQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter
    Friend WithEvents TrueFalsetblBindingSource As BindingSource
    Friend WithEvents TrueFalse_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter
    Friend WithEvents QCMQuesttblBindingSource As BindingSource
    Friend WithEvents QCMQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter
    Friend WithEvents ComboBox_ExamType As ComboBox
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents AddExamTypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
