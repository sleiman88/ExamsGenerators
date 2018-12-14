Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.IO
Public Class PrintExam
    Public MyExamId As Integer
    Public Sub New(ExamId As Integer)
        MyExamId = ExamId
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PrintExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Rp1, Rp2, Rp3, Rp4, Rp5, Rp6, Rp7, Rp8, Rp9, Rp10, Rp11, Rp12, Rp13, Rp14, Rp15, Rp16, Rp17, Rp18, Rp19, Rp20 As New ReportParameter
        Rp1.Name = "RP1"
        Rp2.Name = "RP2"
        Rp3.Name = "RP3"
        Rp4.Name = "RP4"
        Rp5.Name = "RP5"
        Rp6.Name = "RP6"
        '  ReportParam.Values.Add(TextBoxquerry.Text)


        'Dim dsGrid As New DataSet()
        'Dim sqlAdapter As SqlDataAdapter
        'Dim cmd As New SqlCommand(NameStoreProcedure)
        'cmd.CommandType = CommandType.StoredProcedure
        'cmd.Connection = myConn.openConnection()
        'cmd.Parameters.AddWithValue("@IdScan", IdScan)
        'sqlAdapter = New SqlDataAdapter(cmd)

        'sqlAdapter.Fill(dsGrid)
        'DataGridView.ClearSelection()
        'Dim Dtable As DataTable
        'Dim result As Int32

        'Dtable = dsGrid.Tables(0)

        'If Dtable IsNot Nothing AndAlso Dtable.Rows.Count > 0 Then
        '    result = Dtable.Rows(0)("count")
        'Else
        '    result = 0
        'End If
        'MyTextBox.Text = result.ToString


        'DataGridView.DataSource = dsGrid.Tables(0)
        'DataGridView.Columns("count").Visible = False


        'myConn.closeConnection()

        'Catch ex As Exception
        'myConn.closeConnection()
        'MessageBox.Show(ex.Message)
        'End Try
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class