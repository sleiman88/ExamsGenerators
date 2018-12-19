<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateAnExam
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
        Me.TextBox_Examtype = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_TotalEs10 = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalEs15 = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalEs20 = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalTF = New System.Windows.Forms.TextBox()
        Me.TextBox_TotalQCM = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label_E20 = New System.Windows.Forms.Label()
        Me.Label_E15 = New System.Windows.Forms.Label()
        Me.Label_E10 = New System.Windows.Forms.Label()
        Me.Label_TF = New System.Windows.Forms.Label()
        Me.Label_QCM = New System.Windows.Forms.Label()
        Me.TextBox_Req20 = New System.Windows.Forms.TextBox()
        Me.TextBox_Req15 = New System.Windows.Forms.TextBox()
        Me.TextBox_ReqEssay10 = New System.Windows.Forms.TextBox()
        Me.TextBox_ReqTF = New System.Windows.Forms.TextBox()
        Me.TextBox_ReqQCM = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button_Generate = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_TotalGrade = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label_ExamName = New System.Windows.Forms.Label()
        Me.TextBox_ExamName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label_TotalGrade = New System.Windows.Forms.Label()
        Me.ExamsGenerator_DBDataSet = New Main.ExamsGenerator_DBDataSet()
        Me.ExamsTypetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsType_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter()
        Me.EssayQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EssayQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter()
        Me.QCMQuesttblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QCMQuest_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter()
        Me.TrueFalsetblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrueFalse_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter()
        Me.ExamstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Exams_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.Exams_tblTableAdapter()
        Me.ExamsQuestionstblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExamsQuestions_tblTableAdapter = New Main.ExamsGenerator_DBDataSetTableAdapters.ExamsQuestions_tblTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamsQuestionstblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam Type"
        '
        'TextBox_Examtype
        '
        Me.TextBox_Examtype.Enabled = False
        Me.TextBox_Examtype.Location = New System.Drawing.Point(95, 12)
        Me.TextBox_Examtype.Name = "TextBox_Examtype"
        Me.TextBox_Examtype.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_Examtype.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total QCM Questions "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total TF Questions "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Essay 10"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total Essay 15"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total Essay 20"
        '
        'TextBox_TotalEs10
        '
        Me.TextBox_TotalEs10.Enabled = False
        Me.TextBox_TotalEs10.Location = New System.Drawing.Point(167, 11)
        Me.TextBox_TotalEs10.Name = "TextBox_TotalEs10"
        Me.TextBox_TotalEs10.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_TotalEs10.TabIndex = 7
        '
        'TextBox_TotalEs15
        '
        Me.TextBox_TotalEs15.Enabled = False
        Me.TextBox_TotalEs15.Location = New System.Drawing.Point(167, 40)
        Me.TextBox_TotalEs15.Name = "TextBox_TotalEs15"
        Me.TextBox_TotalEs15.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_TotalEs15.TabIndex = 8
        '
        'TextBox_TotalEs20
        '
        Me.TextBox_TotalEs20.Enabled = False
        Me.TextBox_TotalEs20.Location = New System.Drawing.Point(167, 65)
        Me.TextBox_TotalEs20.Name = "TextBox_TotalEs20"
        Me.TextBox_TotalEs20.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_TotalEs20.TabIndex = 9
        '
        'TextBox_TotalTF
        '
        Me.TextBox_TotalTF.Enabled = False
        Me.TextBox_TotalTF.Location = New System.Drawing.Point(342, 13)
        Me.TextBox_TotalTF.Name = "TextBox_TotalTF"
        Me.TextBox_TotalTF.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_TotalTF.TabIndex = 10
        '
        'TextBox_TotalQCM
        '
        Me.TextBox_TotalQCM.Enabled = False
        Me.TextBox_TotalQCM.Location = New System.Drawing.Point(342, 43)
        Me.TextBox_TotalQCM.Name = "TextBox_TotalQCM"
        Me.TextBox_TotalQCM.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_TotalQCM.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox_TotalQCM)
        Me.Panel1.Controls.Add(Me.TextBox_TotalTF)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox_TotalEs20)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox_TotalEs15)
        Me.Panel1.Controls.Add(Me.TextBox_TotalEs10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 97)
        Me.Panel1.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label_E20)
        Me.Panel2.Controls.Add(Me.Label_E15)
        Me.Panel2.Controls.Add(Me.Label_E10)
        Me.Panel2.Controls.Add(Me.Label_TF)
        Me.Panel2.Controls.Add(Me.Label_QCM)
        Me.Panel2.Controls.Add(Me.TextBox_Req20)
        Me.Panel2.Controls.Add(Me.TextBox_Req15)
        Me.Panel2.Controls.Add(Me.TextBox_ReqEssay10)
        Me.Panel2.Controls.Add(Me.TextBox_ReqTF)
        Me.Panel2.Controls.Add(Me.TextBox_ReqQCM)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(12, 173)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 161)
        Me.Panel2.TabIndex = 13
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(154, 69)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(41, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Max(3)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(154, 92)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Max(3)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(154, 114)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Max(3)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(154, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Max(10)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(154, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Max(5)"
        '
        'Label_E20
        '
        Me.Label_E20.AutoSize = True
        Me.Label_E20.ForeColor = System.Drawing.Color.Red
        Me.Label_E20.Location = New System.Drawing.Point(135, 114)
        Me.Label_E20.Name = "Label_E20"
        Me.Label_E20.Size = New System.Drawing.Size(13, 13)
        Me.Label_E20.TabIndex = 24
        Me.Label_E20.Text = "*"
        Me.Label_E20.Visible = False
        '
        'Label_E15
        '
        Me.Label_E15.AutoSize = True
        Me.Label_E15.ForeColor = System.Drawing.Color.Red
        Me.Label_E15.Location = New System.Drawing.Point(135, 88)
        Me.Label_E15.Name = "Label_E15"
        Me.Label_E15.Size = New System.Drawing.Size(13, 13)
        Me.Label_E15.TabIndex = 23
        Me.Label_E15.Text = "*"
        Me.Label_E15.Visible = False
        '
        'Label_E10
        '
        Me.Label_E10.AutoSize = True
        Me.Label_E10.ForeColor = System.Drawing.Color.Red
        Me.Label_E10.Location = New System.Drawing.Point(135, 69)
        Me.Label_E10.Name = "Label_E10"
        Me.Label_E10.Size = New System.Drawing.Size(13, 13)
        Me.Label_E10.TabIndex = 22
        Me.Label_E10.Text = "*"
        Me.Label_E10.Visible = False
        '
        'Label_TF
        '
        Me.Label_TF.AutoSize = True
        Me.Label_TF.ForeColor = System.Drawing.Color.Red
        Me.Label_TF.Location = New System.Drawing.Point(135, 44)
        Me.Label_TF.Name = "Label_TF"
        Me.Label_TF.Size = New System.Drawing.Size(13, 13)
        Me.Label_TF.TabIndex = 21
        Me.Label_TF.Text = "*"
        Me.Label_TF.Visible = False
        '
        'Label_QCM
        '
        Me.Label_QCM.AutoSize = True
        Me.Label_QCM.ForeColor = System.Drawing.Color.Red
        Me.Label_QCM.Location = New System.Drawing.Point(135, 17)
        Me.Label_QCM.Name = "Label_QCM"
        Me.Label_QCM.Size = New System.Drawing.Size(13, 13)
        Me.Label_QCM.TabIndex = 20
        Me.Label_QCM.Text = "*"
        Me.Label_QCM.Visible = False
        '
        'TextBox_Req20
        '
        Me.TextBox_Req20.Location = New System.Drawing.Point(92, 111)
        Me.TextBox_Req20.Name = "TextBox_Req20"
        Me.TextBox_Req20.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_Req20.TabIndex = 19
        '
        'TextBox_Req15
        '
        Me.TextBox_Req15.Location = New System.Drawing.Point(92, 85)
        Me.TextBox_Req15.Name = "TextBox_Req15"
        Me.TextBox_Req15.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_Req15.TabIndex = 18
        '
        'TextBox_ReqEssay10
        '
        Me.TextBox_ReqEssay10.Location = New System.Drawing.Point(92, 62)
        Me.TextBox_ReqEssay10.Name = "TextBox_ReqEssay10"
        Me.TextBox_ReqEssay10.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_ReqEssay10.TabIndex = 17
        '
        'TextBox_ReqTF
        '
        Me.TextBox_ReqTF.Location = New System.Drawing.Point(92, 37)
        Me.TextBox_ReqTF.Name = "TextBox_ReqTF"
        Me.TextBox_ReqTF.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_ReqTF.TabIndex = 16
        '
        'TextBox_ReqQCM
        '
        Me.TextBox_ReqQCM.Location = New System.Drawing.Point(92, 11)
        Me.TextBox_ReqQCM.Name = "TextBox_ReqQCM"
        Me.TextBox_ReqQCM.Size = New System.Drawing.Size(36, 20)
        Me.TextBox_ReqQCM.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Essay 20"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Essay 15"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Essay 10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "True or false"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "QCM"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(15, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Required Questions "
        '
        'Button_Generate
        '
        Me.Button_Generate.Location = New System.Drawing.Point(240, 60)
        Me.Button_Generate.Name = "Button_Generate"
        Me.Button_Generate.Size = New System.Drawing.Size(75, 23)
        Me.Button_Generate.TabIndex = 15
        Me.Button_Generate.Text = "Generate"
        Me.Button_Generate.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Total Grade"
        '
        'TextBox_TotalGrade
        '
        Me.TextBox_TotalGrade.Enabled = False
        Me.TextBox_TotalGrade.Location = New System.Drawing.Point(81, 15)
        Me.TextBox_TotalGrade.Name = "TextBox_TotalGrade"
        Me.TextBox_TotalGrade.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_TotalGrade.TabIndex = 17
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label_ExamName)
        Me.Panel3.Controls.Add(Me.TextBox_ExamName)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label_TotalGrade)
        Me.Panel3.Controls.Add(Me.TextBox_TotalGrade)
        Me.Panel3.Controls.Add(Me.Button_Generate)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Location = New System.Drawing.Point(291, 210)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(338, 93)
        Me.Panel3.TabIndex = 18
        '
        'Label_ExamName
        '
        Me.Label_ExamName.AutoSize = True
        Me.Label_ExamName.ForeColor = System.Drawing.Color.Red
        Me.Label_ExamName.Location = New System.Drawing.Point(187, 55)
        Me.Label_ExamName.Name = "Label_ExamName"
        Me.Label_ExamName.Size = New System.Drawing.Size(13, 13)
        Me.Label_ExamName.TabIndex = 24
        Me.Label_ExamName.Text = "*"
        Me.Label_ExamName.Visible = False
        '
        'TextBox_ExamName
        '
        Me.TextBox_ExamName.Location = New System.Drawing.Point(81, 48)
        Me.TextBox_ExamName.Name = "TextBox_ExamName"
        Me.TextBox_ExamName.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ExamName.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Exam Name "
        '
        'Label_TotalGrade
        '
        Me.Label_TotalGrade.AutoSize = True
        Me.Label_TotalGrade.ForeColor = System.Drawing.Color.Red
        Me.Label_TotalGrade.Location = New System.Drawing.Point(187, 18)
        Me.Label_TotalGrade.Name = "Label_TotalGrade"
        Me.Label_TotalGrade.Size = New System.Drawing.Size(13, 13)
        Me.Label_TotalGrade.TabIndex = 21
        Me.Label_TotalGrade.Text = "*"
        Me.Label_TotalGrade.Visible = False
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
        'EssayQuesttblBindingSource
        '
        Me.EssayQuesttblBindingSource.DataMember = "EssayQuest_tbl"
        Me.EssayQuesttblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'EssayQuest_tblTableAdapter
        '
        Me.EssayQuest_tblTableAdapter.ClearBeforeFill = True
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
        'TrueFalsetblBindingSource
        '
        Me.TrueFalsetblBindingSource.DataMember = "TrueFalse_tbl"
        Me.TrueFalsetblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'TrueFalse_tblTableAdapter
        '
        Me.TrueFalse_tblTableAdapter.ClearBeforeFill = True
        '
        'ExamstblBindingSource
        '
        Me.ExamstblBindingSource.DataMember = "Exams_tbl"
        Me.ExamstblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'Exams_tblTableAdapter
        '
        Me.Exams_tblTableAdapter.ClearBeforeFill = True
        '
        'ExamsQuestionstblBindingSource
        '
        Me.ExamsQuestionstblBindingSource.DataMember = "ExamsQuestions_tbl"
        Me.ExamsQuestionstblBindingSource.DataSource = Me.ExamsGenerator_DBDataSet
        '
        'ExamsQuestions_tblTableAdapter
        '
        Me.ExamsQuestions_tblTableAdapter.ClearBeforeFill = True
        '
        'GenerateAnExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 343)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox_Examtype)
        Me.Name = "GenerateAnExam"
        Me.Text = "GenerateAnExam"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ExamsGenerator_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsTypetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EssayQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QCMQuesttblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueFalsetblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamsQuestionstblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ExamsGenerator_DBDataSet As ExamsGenerator_DBDataSet
    Friend WithEvents ExamsTypetblBindingSource As BindingSource
    Friend WithEvents ExamsType_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsType_tblTableAdapter
    Friend WithEvents TextBox_Examtype As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_TotalEs10 As TextBox
    Friend WithEvents TextBox_TotalEs15 As TextBox
    Friend WithEvents TextBox_TotalEs20 As TextBox
    Friend WithEvents TextBox_TotalTF As TextBox
    Friend WithEvents TextBox_TotalQCM As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox_Req20 As TextBox
    Friend WithEvents TextBox_Req15 As TextBox
    Friend WithEvents TextBox_ReqEssay10 As TextBox
    Friend WithEvents TextBox_ReqTF As TextBox
    Friend WithEvents TextBox_ReqQCM As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button_Generate As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_TotalGrade As TextBox
    Friend WithEvents Label_E20 As Label
    Friend WithEvents Label_E15 As Label
    Friend WithEvents Label_E10 As Label
    Friend WithEvents Label_TF As Label
    Friend WithEvents Label_QCM As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents EssayQuesttblBindingSource As BindingSource
    Friend WithEvents EssayQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.EssayQuest_tblTableAdapter
    Friend WithEvents QCMQuesttblBindingSource As BindingSource
    Friend WithEvents QCMQuest_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.QCMQuest_tblTableAdapter
    Friend WithEvents TrueFalsetblBindingSource As BindingSource
    Friend WithEvents TrueFalse_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.TrueFalse_tblTableAdapter
    Friend WithEvents Label_TotalGrade As Label
    Friend WithEvents Label_ExamName As Label
    Friend WithEvents TextBox_ExamName As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ExamstblBindingSource As BindingSource
    Friend WithEvents Exams_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.Exams_tblTableAdapter
    Friend WithEvents ExamsQuestionstblBindingSource As BindingSource
    Friend WithEvents ExamsQuestions_tblTableAdapter As ExamsGenerator_DBDataSetTableAdapters.ExamsQuestions_tblTableAdapter
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
End Class
