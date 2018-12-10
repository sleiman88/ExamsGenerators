Public Class MainForm
    Private Sub AddTrueOrFalseQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTrueOrFalseQuestionsToolStripMenuItem.Click
        Dim newTF As AddTruefalse
        newTF = New AddTruefalse(Me)

        newTF.ShowDialog()
    End Sub

    Private Sub AddEssayQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEssayQuestionsToolStripMenuItem.Click
        Dim newEssay As AddEssay
        newEssay = New AddEssay(Me)
        newEssay.ShowDialog()
    End Sub

    Private Sub AddQCMQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddQCMQuestionsToolStripMenuItem.Click
        Dim newQcm As addQCMQuestion
        newQcm = New addQCMQuestion(Me)
        newQcm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)
        getCount()

    End Sub
    Public Sub getCount()
        TextBox_Essay.Text = Me.EssayQuest_tblTableAdapter.CountTotal(ComboBox_ExamType.SelectedValue).ToString
        TextBox_QCM.Text = Me.QCMQuest_tblTableAdapter.CountTotal(ComboBox_ExamType.SelectedValue).ToString
        TextBox_TFQue.Text = Me.TrueFalse_tblTableAdapter.CountTotal(ComboBox_ExamType.SelectedValue).ToString
    End Sub

    Private Sub Button_GenerateExam_Click(sender As Object, e As EventArgs) Handles Button_GenerateExam.Click
        If checkQuesTotalGrade() = False Then
            MsgBox("Not enought question for this typpe of Exam .Please choose another Exam type or add questions first !!")

        Else
            ''go to generate exam
        End If
    End Sub
    Private Function checkQuesTotalGrade() As Boolean
        Dim Totalgrade As Decimal
        Totalgrade = 0

        Totalgrade = 10 * Me.EssayQuest_tblTableAdapter.NbEssay10(ComboBox_ExamType.SelectedValue) + 15 * Me.EssayQuest_tblTableAdapter.NBEssay15(ComboBox_ExamType.SelectedValue) + 20 * Me.EssayQuest_tblTableAdapter.NbEssay20(ComboBox_ExamType.SelectedValue)
        Totalgrade += 5 * Me.QCMQuest_tblTableAdapter.CountTotal(ComboBox_ExamType.SelectedValue)
        Totalgrade += 5 * Me.TrueFalse_tblTableAdapter.CountTotal(ComboBox_ExamType.SelectedValue)
        If Totalgrade >= 100 Then

            Return True
        Else

            Return False
        End If


    End Function


    Private Sub ComboBox_ExamType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ExamType.SelectedIndexChanged
        getCount()
    End Sub
End Class