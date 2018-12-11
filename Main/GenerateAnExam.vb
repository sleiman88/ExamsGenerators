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
        If checktest() = 0 Then

            If checkTestNBquestion() = 0 Then
                If checkGrade() = False Then
                    'generate
                Else
                    MsgBox("Please choose total question in order to have grade over 100 !")
                End If

            Else
                MsgBox("Please make sure the required number of question does not exceed the available number of questions !")
            End If

        Else
            MsgBox("Please check required Informaitons ")
        End If
    End Sub

    Private Function checkGrade() As Boolean
        Dim totalGrade As Decimal
        totalGrade = Decimal.Parse(TextBox_ReqQCM.Text) * 5 + Decimal.Parse(TextBox_ReqTF.Text) * 5 + Decimal.Parse(TextBox_ReqEssay10.Text) * 10 + Decimal.Parse(TextBox_Req15.Text) * 15 + Decimal.Parse(TextBox_Req20.Text) * 20
        TextBox_TotalGrade.Text = totalGrade.ToString + "/100"
        If totalGrade <> 100 Then

            Label_TotalGrade.Visible = True
            Return True
        End If
        Label_TotalGrade.Visible = False
        Return False
    End Function

    Private Sub TextBox_ReqQCM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ReqQCM.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            Label_QCM.Visible = True
            e.Handled = True

        End If

    End Sub

    Private Sub TextBox_ReqQCM_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ReqQCM.KeyUp
        If TextBox_ReqQCM.Text <> String.Empty Then
            Label_QCM.Visible = False
        End If
    End Sub
    Private Function checkTestNBquestion() As Decimal
        Dim result As Decimal
        result = 0
        If Decimal.Parse(TextBox_ReqQCM.Text) > Decimal.Parse(TextBox_TotalQCM.Text) Then
            Label_QCM.Visible = True
            result += 1
        End If
        If Decimal.Parse(TextBox_ReqTF.Text) > Decimal.Parse(TextBox_TotalTF.Text) Then
            Label_TF.Visible = True
            result += 1
        End If
        If Decimal.Parse(TextBox_ReqEssay10.Text) > Decimal.Parse(TextBox_TotalEs10.Text) Then
            Label_TF.Visible = True
            result += 1
        End If
        If Decimal.Parse(TextBox_Req15.Text) > Decimal.Parse(TextBox_TotalEs15.Text) Then
            Label_E15.Visible = True
            result += 1
        End If
        If Decimal.Parse(TextBox_Req20.Text) > Decimal.Parse(TextBox_TotalEs20.Text) Then
            Label_E20.Visible = True
            result += 1
        End If
        Return result
    End Function
    Private Function checktest() As Decimal
        Dim result As Decimal
        result = 0
        If TextBox_ReqQCM.Text = String.Empty Then
            Label_QCM.Visible = True
            result += 1
        End If

        If TextBox_ReqTF.Text = String.Empty Then
            Label_TF.Visible = True
            result += 1
        End If


        If TextBox_ReqEssay10.Text = String.Empty Then
            Label_E10.Visible = True
            result += 1
        End If


        If TextBox_Req15.Text = String.Empty Then
            Label_E15.Visible = True
            result += 1
        End If

        If TextBox_Req20.Text = String.Empty Then
            Label_E20.Visible = True
            result += 1
        End If

        Return result
    End Function

    Private Sub TextBox_ReqTF_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ReqTF.KeyUp
        If TextBox_ReqTF.Text <> String.Empty Then
            Label_TF.Visible = False
        End If
    End Sub

    Private Sub TextBox_ReqEssay10_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ReqEssay10.KeyUp
        If TextBox_TotalEs10.Text <> String.Empty Then
            Label_E10.Visible = False
        End If
    End Sub

    Private Sub TextBox_Req15_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_Req15.KeyUp
        If TextBox_Req15.Text <> String.Empty Then
            Label_E15.Visible = False
        End If
    End Sub

    Private Sub TextBox_Req20_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_Req20.KeyUp
        If TextBox_Req20.Text <> String.Empty Then
            Label_E20.Visible = False
        End If
    End Sub
End Class