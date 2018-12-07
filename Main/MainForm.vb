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
        getCount()

    End Sub
    Public Sub getCount()
        TextBox_Essay.Text = Me.EssayQuest_tblTableAdapter.CountTotal().ToString
        TextBox_QCM.Text = Me.QCMQuest_tblTableAdapter.CountTotal().ToString
        TextBox_TFQue.Text = Me.TrueFalse_tblTableAdapter.CountTotal().ToString
    End Sub
End Class