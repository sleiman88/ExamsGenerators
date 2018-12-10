Public Class GenerateAnExam
    Public ExamType As Decimal
    Public Sub New(Etype As Decimal)
        ExamType = Etype
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub GenerateAnExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox_Examtype.Text = Me.ExamsType_tblTableAdapter.getName(ExamType)
        getTotal()
    End Sub
    Private Sub getTotal()
        TextBox_TotalEs10.Text = Me.EssayQuest_tblTableAdapter.NbEssay10(ExamType)
        TextBox_TotalEs15.Text = Me.EssayQuest_tblTableAdapter.NBEssay15(ExamType)
        TextBox_TotalEs20.Text = Me.EssayQuest_tblTableAdapter.NbEssay20(ExamType)
        TextBox_TotalTF.Text = Me.TrueFalse_tblTableAdapter.CountTotal(ExamType)
        TextBox_TotalQCM.Text = Me.QCMQuest_tblTableAdapter.CountTotal(ExamType)

    End Sub
    Private Sub Button_Generate_Click(sender As Object, e As EventArgs) Handles Button_Generate.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox_ReqQCM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ReqQCM.KeyPress
        If Not Char.IsNumber(e.KeyChar) Then
            MsgBox("only Numbers allowed")
            e.Handled = True
            Label_QCM.Visible = True
        End If
        If TextBox_ReqQCM.Text = String.Empty Then
            Label_QCM.Visible = False
        End If
    End Sub

    Private Sub TextBox_ReqQCM_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ReqQCM.KeyUp
        If TextBox_ReqQCM.Text <> String.Empty Then
            TextBox_ReqQCM.Visible = False
        End If
    End Sub
End Class