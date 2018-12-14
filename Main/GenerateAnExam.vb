Public Class GenerateAnExam
    Public ExamType As Decimal
    Public Sub New(Etype As Decimal)
        ExamType = Etype
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub GenerateAnExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsQuestions_tbl' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.Exams_tbl' table. You can move, or remove it, as needed.


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
                    Try
                        insertNewExam()

                        insertQuestions(getExamID(), getrandomIdQcm(), getrandomIdTF(), getrandomIdEs10(), getrandomIdEs15(), getrandomIdEs20())
                        'show report 
                        MsgBox("Succefuly addded ")

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


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
    Private Sub insertNewExam()
        Me.Exams_tblTableAdapter.InsertQuery(TextBox_ExamName.Text, ExamType, Today())
    End Sub
    Private Sub insertQuestions(ExamId As Int32, QCm As Int32(), Tf As Int32(), Es10 As Int32(), Es15 As Int32(), Es20 As Int32())

        For i As Integer = 0 To Decimal.Parse(TextBox_ReqQCM.Text) - 1
            Me.ExamsQuestions_tblTableAdapter.InsertQuery(ExamId, QCm(i), "QCM")
        Next

        For i As Integer = 0 To Decimal.Parse(TextBox_ReqTF.Text) - 1
            Me.ExamsQuestions_tblTableAdapter.InsertQuery(ExamId, Tf(i), "TrueOrFalse")
        Next

        For i As Integer = 0 To Decimal.Parse(TextBox_ReqEssay10.Text) - 1
            Me.ExamsQuestions_tblTableAdapter.InsertQuery(ExamId, Es10(i), "Essay10")
        Next
        For i As Integer = 0 To Decimal.Parse(TextBox_Req15.Text) - 1
            Me.ExamsQuestions_tblTableAdapter.InsertQuery(ExamId, Es15(i), "Essay15")
        Next
        For i As Integer = 0 To Decimal.Parse(TextBox_Req20.Text) - 1
            Me.ExamsQuestions_tblTableAdapter.InsertQuery(ExamId, Es20(i), "Essay20")
        Next

    End Sub

    Private Function getrandomIdQcm() As Int32()
        Dim reqQCm As Int32
        reqQCm = Decimal.Parse(TextBox_ReqQCM.Text)

        Dim QCmTbl(20) As Int32

        Dim DtableQcm As DataTable

        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        Me.QCMQuest_tblTableAdapter.FillByRandom(Me.ExamsGenerator_DBDataSet.QCMQuest_tbl, reqQCm, ExamType)
        DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        If DtableQcm IsNot Nothing AndAlso DtableQcm.Rows.Count > 0 Then
            ' result = DtableQcm.Rows(0)("ID")
            For i As Integer = 0 To reqQCm - 1
                QCmTbl(i) = DtableQcm.Rows(i)("ID")
                '  MsgBox("row " + i.ToString + "=" + DtableQcm.Rows(i)("ID").ToString)
            Next
        End If
        'Dim temp As String
        'For i As Integer = 0 To reqQCm - 1
        '    temp += QCmTbl(i).ToString
        'Next
        'MsgBox(temp)
        Return QCmTbl
    End Function
    Private Function getrandomIdTF() As Int32()
        Dim reqTf As Int32

        reqTf = Decimal.Parse(TextBox_ReqTF.Text)


        Dim TFTbl(20) As Int32

        Dim DtableTF As DataTable

        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        Me.TrueFalse_tblTableAdapter.FillByRandom(Me.ExamsGenerator_DBDataSet.TrueFalse_tbl, reqTf, ExamType)

        DtableTF = ExamsGenerator_DBDataSet.Tables("TrueFalse_tbl")
        If DtableTF IsNot Nothing AndAlso DtableTF.Rows.Count > 0 Then
            ' result = DtableQcm.Rows(0)("ID")
            For i As Integer = 0 To reqTf - 1
                TFTbl(i) = DtableTF.Rows(i)("ID")
                '  MsgBox("row " + i.ToString + "=" + DtableQcm.Rows(i)("ID").ToString)
            Next
        End If
        'Dim temp As String
        'For i As Integer = 0 To reqTf - 1
        '    temp += TFTbl(i).ToString
        'Next
        'MsgBox(temp)
        Return TFTbl
    End Function
    Private Function getrandomIdEs10() As Int32()
        Dim reqEs10 As Int32

        reqEs10 = Decimal.Parse(TextBox_ReqEssay10.Text)


        Dim E10Tbl(10) As Int32

        Dim DtableEs10 As DataTable

        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        Me.EssayQuest_tblTableAdapter.FillByrandom10(Me.ExamsGenerator_DBDataSet.EssayQuest_tbl, reqEs10, ExamType)

        DtableEs10 = ExamsGenerator_DBDataSet.Tables("EssayQuest_tbl")
        If DtableEs10 IsNot Nothing AndAlso DtableEs10.Rows.Count > 0 Then
            ' result = DtableQcm.Rows(0)("ID")
            For i As Integer = 0 To reqEs10 - 1
                E10Tbl(i) = DtableEs10.Rows(i)("ID")
                '  MsgBox("row " + i.ToString + "=" + DtableQcm.Rows(i)("ID").ToString)
            Next
        End If
        'Dim temp As String
        'For i As Integer = 0 To reqEs10 - 1
        '    temp += E10Tbl(i).ToString
        'Next
        'MsgBox(temp)
        Return E10Tbl
    End Function
    Private Function getrandomIdEs15() As Int32()
        Dim reqEs15 As Int32

        reqEs15 = Decimal.Parse(TextBox_Req15.Text)


        Dim E15Tbl(7) As Int32

        Dim DtableEs15 As DataTable

        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        Me.EssayQuest_tblTableAdapter.FillByRandom15(Me.ExamsGenerator_DBDataSet.EssayQuest_tbl, reqEs15, ExamType)

        DtableEs15 = ExamsGenerator_DBDataSet.Tables("EssayQuest_tbl")
        If DtableEs15 IsNot Nothing AndAlso DtableEs15.Rows.Count > 0 Then
            ' result = DtableQcm.Rows(0)("ID")
            For i As Integer = 0 To reqEs15 - 1
                E15Tbl(i) = DtableEs15.Rows(i)("ID")
                '  MsgBox("row " + i.ToString + "=" + DtableQcm.Rows(i)("ID").ToString)
            Next
        End If
        'Dim temp As String
        'For i As Integer = 0 To reqEs15 - 1
        '    temp += E15Tbl(i).ToString
        'Next
        'MsgBox(temp)
        Return E15Tbl
    End Function
    Private Function getrandomIdEs20() As Int32()
        Dim reqEs20 As Int32

        reqEs20 = Decimal.Parse(TextBox_Req20.Text)


        Dim E20Tbl(5) As Int32

        Dim DtableEs20 As DataTable

        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        Me.EssayQuest_tblTableAdapter.FillByRandom15(Me.ExamsGenerator_DBDataSet.EssayQuest_tbl, reqEs20, ExamType)

        DtableEs20 = ExamsGenerator_DBDataSet.Tables("EssayQuest_tbl")
        If DtableEs20 IsNot Nothing AndAlso DtableEs20.Rows.Count > 0 Then
            ' result = DtableQcm.Rows(0)("ID")
            For i As Integer = 0 To reqEs20 - 1
                E20Tbl(i) = DtableEs20.Rows(i)("ID")
                '  MsgBox("row " + i.ToString + "=" + DtableQcm.Rows(i)("ID").ToString)
            Next
        End If
        'Dim temp As String
        'For i As Integer = 0 To reqEs20 - 1
        '    temp += E20Tbl(i).ToString
        'Next
        'MsgBox(temp)
        Return E20Tbl
    End Function
    Private Function getExamID()
        Return Me.Exams_tblTableAdapter.getExamId()
    End Function

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

        If TextBox_ExamName.Text = String.Empty Then
            Label_ExamName.Visible = True
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

    Private Sub TextBox_ReqTF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ReqTF.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            Label_TF.Visible = True
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox_ReqEssay10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ReqEssay10.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            Label_E10.Visible = True
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox_Req15_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Req15.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            Label_E15.Visible = True
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox_Req20_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Req20.KeyPress
        If Not Char.IsNumber(e.KeyChar) And e.KeyChar <> ChrW(Keys.Back) Then
            MsgBox("only Numbers allowed")
            Label_E20.Visible = True
            e.Handled = True

        End If
    End Sub

    Private Sub TextBox_ExamName_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox_ExamName.KeyUp
        If TextBox_ExamName.Text <> String.Empty Then
            Label_ExamName.Visible = False
        End If
    End Sub
End Class