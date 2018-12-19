Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.IO
Public Class PrintExam
    Public MyExamId As Integer
    Public Sub New(ExamId As Int64)
        '
        ' 
        MyExamId = ExamId

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PrintExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.getEssayQues' table. You can move, or remove it, as needed.



        getQCM()
        getTFalse()
        GetEssay()
    End Sub
    Private Sub getQCM()


        Dim Q1, Q1A, Q1B, Q1C, Q1D, Q2, Q2A, Q2B, Q2C, Q2D, Q3, Q3A, Q3B, Q3C, Q3D, Q4, Q4A, Q4B, Q4C, Q4D, Q5, Q5A, Q5B, Q5C, Q5D, ExamName, ExamType, Examdate As New ReportParameter
        ExamName.Name = "ExamName"
        ExamType.Name = "ExamType"
        Examdate.Name = "Examdate"


        Q1.Name = "Q1"
        Q1A.Name = "Q1A"
        Q1B.Name = "Q1B"
        Q1C.Name = "Q1C"
        Q1D.Name = "Q1D"
        Q2.Name = "Q2"
        Q2A.Name = "Q2A"
        Q2B.Name = "Q2B"
        Q2C.Name = "Q2C"
        Q2D.Name = "Q2D"
        Q3.Name = "Q3"
        Q3A.Name = "Q3A"
        Q3B.Name = "Q3B"
        Q3C.Name = "Q3C"
        Q3D.Name = "Q3D"
        Q4.Name = "Q4"
        Q4A.Name = "Q4A"
        Q4B.Name = "Q4B"
        Q4C.Name = "Q4C"
        Q4D.Name = "Q4D"
        Q5.Name = "Q5"
        Q5A.Name = "Q5A"
        Q5B.Name = "Q5B"
        Q5C.Name = "Q5C"
        Q5D.Name = "Q5D"





        Dim DtableQcm As DataTable
        Me.GetQCMQuesTableAdapter.FillByExamID(Me.ExamsGenerator_DBDataSet.getQCMQues, MyExamId)
        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False


        DtableQcm = ExamsGenerator_DBDataSet.Tables("getQCMQues")


        If DtableQcm IsNot Nothing AndAlso DtableQcm.Rows.Count > 0 Then
            ExamName.Values.Add(DtableQcm.Rows(0)("Name_Exams").ToString)
            ExamType.Values.Add(DtableQcm.Rows(0)("Name_ExamsType").ToString)
            Examdate.Values.Add(DtableQcm.Rows(0)("Date_Exams").ToString)
            Dim i As Int32
            i = 0
            If i <= DtableQcm.Rows.Count - 1 Then
                Q1.Values.Add(DtableQcm.Rows(i)("Quest_QCMQuest").ToString)
                Q1A.Values.Add(DtableQcm.Rows(i)("ChoiceA_QCMQuest").ToString)
                Q1B.Values.Add(DtableQcm.Rows(i)("ChoiceB_QCMQuest").ToString)
                Q1C.Values.Add(DtableQcm.Rows(i)("ChoiceC_QCMQuest").ToString)
                Q1D.Values.Add(DtableQcm.Rows(i)("ChoiceD_QCMQuest").ToString)
                i = i + 1
            End If

            If i <= DtableQcm.Rows.Count - 1 Then
                Q2.Values.Add(DtableQcm.Rows(i)("Quest_QCMQuest").ToString)
                Q2A.Values.Add(DtableQcm.Rows(i)("ChoiceA_QCMQuest").ToString)
                Q2B.Values.Add(DtableQcm.Rows(i)("ChoiceB_QCMQuest").ToString)
                Q2C.Values.Add(DtableQcm.Rows(i)("ChoiceC_QCMQuest").ToString)
                Q2D.Values.Add(DtableQcm.Rows(i)("ChoiceD_QCMQuest").ToString)
                i = i + 1
            End If

            If i <= DtableQcm.Rows.Count - 1 Then
                Q3.Values.Add(DtableQcm.Rows(i)("Quest_QCMQuest").ToString)
                Q3A.Values.Add(DtableQcm.Rows(i)("ChoiceA_QCMQuest").ToString)
                Q3B.Values.Add(DtableQcm.Rows(i)("ChoiceB_QCMQuest").ToString)
                Q3C.Values.Add(DtableQcm.Rows(i)("ChoiceC_QCMQuest").ToString)
                Q3D.Values.Add(DtableQcm.Rows(i)("ChoiceD_QCMQuest").ToString)
                i = i + 1
            End If
            If i <= DtableQcm.Rows.Count - 1 Then
                Q4.Values.Add(DtableQcm.Rows(i)("Quest_QCMQuest").ToString)
                Q4A.Values.Add(DtableQcm.Rows(i)("ChoiceA_QCMQuest").ToString)
                Q4B.Values.Add(DtableQcm.Rows(i)("ChoiceB_QCMQuest").ToString)
                Q4C.Values.Add(DtableQcm.Rows(i)("ChoiceC_QCMQuest").ToString)
                Q4D.Values.Add(DtableQcm.Rows(i)("ChoiceD_QCMQuest").ToString)
                i = i + 1
            End If
            If i <= DtableQcm.Rows.Count - 1 Then
                Q5.Values.Add(DtableQcm.Rows(i)("Quest_QCMQuest").ToString)
                Q5A.Values.Add(DtableQcm.Rows(i)("ChoiceA_QCMQuest").ToString)
                Q5B.Values.Add(DtableQcm.Rows(i)("ChoiceB_QCMQuest").ToString)
                Q5C.Values.Add(DtableQcm.Rows(i)("ChoiceC_QCMQuest").ToString)
                Q5D.Values.Add(DtableQcm.Rows(i)("ChoiceD_QCMQuest").ToString)
                i = i + 1
            End If

        End If


        ReportViewer1.LocalReport.SetParameters(Q1)
        ReportViewer1.LocalReport.SetParameters(Q1A)
        ReportViewer1.LocalReport.SetParameters(Q1B)
        ReportViewer1.LocalReport.SetParameters(Q1C)
        ReportViewer1.LocalReport.SetParameters(Q1D)
        ReportViewer1.LocalReport.SetParameters(Q2)
        ReportViewer1.LocalReport.SetParameters(Q2A)
        ReportViewer1.LocalReport.SetParameters(Q2B)
        ReportViewer1.LocalReport.SetParameters(Q2C)
        ReportViewer1.LocalReport.SetParameters(Q2D)
        ReportViewer1.LocalReport.SetParameters(Q3)
        ReportViewer1.LocalReport.SetParameters(Q3A)
        ReportViewer1.LocalReport.SetParameters(Q3B)
        ReportViewer1.LocalReport.SetParameters(Q3C)
        ReportViewer1.LocalReport.SetParameters(Q3D)
        ReportViewer1.LocalReport.SetParameters(Q4)
        ReportViewer1.LocalReport.SetParameters(Q4A)
        ReportViewer1.LocalReport.SetParameters(Q4B)
        ReportViewer1.LocalReport.SetParameters(Q4C)
        ReportViewer1.LocalReport.SetParameters(Q4D)
        ReportViewer1.LocalReport.SetParameters(Q5)
        ReportViewer1.LocalReport.SetParameters(Q5A)
        ReportViewer1.LocalReport.SetParameters(Q5B)
        ReportViewer1.LocalReport.SetParameters(Q5C)
        ReportViewer1.LocalReport.SetParameters(Q5D)
        ReportViewer1.LocalReport.SetParameters(ExamName)
        ReportViewer1.LocalReport.SetParameters(Examdate)
        ReportViewer1.LocalReport.SetParameters(ExamType)

        ReportViewer1.RefreshReport()
    End Sub
    Private Sub getTFalse()
        Dim TF1, TF2, TF3, TF4, TF5, TF6, TF7, TF8, TF9, TF10 As New ReportParameter
        TF1.Name = "TF1"
        TF2.Name = "TF2"
        TF3.Name = "TF3"
        TF4.Name = "TF4"
        TF5.Name = "TF5"
        TF6.Name = "TF6"
        TF7.Name = "TF7"
        TF8.Name = "TF8"
        TF9.Name = "TF9"
        TF10.Name = "TF10"



        Dim DtableTF As DataTable
        Me.GetTrueFQuesTableAdapter.FillByExamID(Me.ExamsGenerator_DBDataSet.getTrueFQues, MyExamId)
        ' DtableQcm = ExamsGenerator_DBDataSet.Tables("QCMQuest_tbl")
        ExamsGenerator_DBDataSet.EnforceConstraints = False


        DtableTF = ExamsGenerator_DBDataSet.Tables("getTrueFQues")
        If DtableTF IsNot Nothing AndAlso DtableTF.Rows.Count > 0 Then

            Dim i As Int32
            i = 0

            If i <= DtableTF.Rows.Count - 1 Then
                TF1.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF2.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF3.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If

            If i <= DtableTF.Rows.Count - 1 Then
                TF4.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF5.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF6.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF7.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF8.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If
            If i <= DtableTF.Rows.Count - 1 Then
                TF9.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If

            If i <= DtableTF.Rows.Count - 1 Then
                TF10.Values.Add(DtableTF.Rows(i)("Quest_TrueFalseQuest").ToString)
                i = i + 1
            End If

        End If
        ReportViewer1.LocalReport.SetParameters(TF1)
        ReportViewer1.LocalReport.SetParameters(TF2)
        ReportViewer1.LocalReport.SetParameters(TF3)
        ReportViewer1.LocalReport.SetParameters(TF4)
        ReportViewer1.LocalReport.SetParameters(TF5)
        ReportViewer1.LocalReport.SetParameters(TF6)
        ReportViewer1.LocalReport.SetParameters(TF7)
        ReportViewer1.LocalReport.SetParameters(TF8)
        ReportViewer1.LocalReport.SetParameters(TF9)
        ReportViewer1.LocalReport.SetParameters(TF10)


        ReportViewer1.RefreshReport()


    End Sub
    Private Sub GetEssay()
        Dim E1, E2, E3, E4, E5, E6, E7, E8, E9, P1, P2, P3, P4, P5, P6, P7, P8, P9 As New ReportParameter
        E1.Name = "E1"
        E2.Name = "E2"
        E3.Name = "E3"
        E4.Name = "E4"
        E5.Name = "E5"
        E6.Name = "E6"
        E7.Name = "E7"
        E8.Name = "E8"
        E9.Name = "E9"
        P1.Name = "P1"
        P2.Name = "P2"
        P3.Name = "P3"
        P4.Name = "P4"
        P5.Name = "P5"
        P6.Name = "P6"
        P7.Name = "P7"
        P8.Name = "P8"
        P9.Name = "P9"
        Dim DtableEssay As DataTable
        Me.GetEssayQuesTableAdapter.FillByExamId(Me.ExamsGenerator_DBDataSet.getEssayQues, MyExamId)
        ExamsGenerator_DBDataSet.EnforceConstraints = False
        DtableEssay = ExamsGenerator_DBDataSet.Tables("getEssayQues")

        If DtableEssay IsNot Nothing AndAlso DtableEssay.Rows.Count > 0 Then


            Dim i As Int32
            i = 0

            If i <= DtableEssay.Rows.Count - 1 Then
                E1.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P1.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If

            If i <= DtableEssay.Rows.Count - 1 Then
                E2.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P2.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If

            If i <= DtableEssay.Rows.Count - 1 Then
                E3.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P3.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If

            If i <= DtableEssay.Rows.Count - 1 Then
                E4.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P4.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If
            If i <= DtableEssay.Rows.Count - 1 Then
                E5.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P5.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If
            If i <= DtableEssay.Rows.Count - 1 Then
                E6.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P6.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If

            If i <= DtableEssay.Rows.Count - 1 Then
                E7.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P7.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If
            If i <= DtableEssay.Rows.Count - 1 Then
                E8.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P8.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If

            If i <= DtableEssay.Rows.Count - 1 Then
                E9.Values.Add(DtableEssay.Rows(i)("Quest_EssamQuest").ToString)
                P9.Values.Add(DtableEssay.Rows(i)("Point_EssayQuest").ToString)
                i = i + 1
            End If








        End If



        ReportViewer1.LocalReport.SetParameters(E1)
        ReportViewer1.LocalReport.SetParameters(E2)
        ReportViewer1.LocalReport.SetParameters(E3)
        ReportViewer1.LocalReport.SetParameters(E4)
        ReportViewer1.LocalReport.SetParameters(E5)
        ReportViewer1.LocalReport.SetParameters(E6)
        ReportViewer1.LocalReport.SetParameters(E7)
        ReportViewer1.LocalReport.SetParameters(E8)
        ReportViewer1.LocalReport.SetParameters(E9)

        ReportViewer1.LocalReport.SetParameters(P1)
        ReportViewer1.LocalReport.SetParameters(P2)
        ReportViewer1.LocalReport.SetParameters(P3)
        ReportViewer1.LocalReport.SetParameters(P4)
        ReportViewer1.LocalReport.SetParameters(P5)
        ReportViewer1.LocalReport.SetParameters(P6)
        ReportViewer1.LocalReport.SetParameters(P7)
        ReportViewer1.LocalReport.SetParameters(P8)
        ReportViewer1.LocalReport.SetParameters(P9)



        ReportViewer1.RefreshReport()
    End Sub
End Class