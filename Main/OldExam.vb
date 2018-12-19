Public Class OldExam
    Private Sub DataGridView_OldExams_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_OldExams.CellDoubleClick
        If DataGridView_OldExams.Item(3, e.RowIndex).Value IsNot Nothing Then
            action(DataGridView_OldExams.Item(3, e.RowIndex).Value)
        End If
    End Sub

    Private Sub DataGridView_OldExams_RowHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView_OldExams.RowHeaderMouseDoubleClick
        If DataGridView_OldExams.Item(3, e.RowIndex).Value IsNot Nothing Then
            action(DataGridView_OldExams.Item(3, e.RowIndex).Value)

        End If
    End Sub

    Private Sub OldExam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.Old_Exams_' table. You can move, or remove it, as needed.
        Me.Old_Exams_TableAdapter.Fill(Me.ExamsGenerator_DBDataSet.Old_Exams_)

    End Sub
    Private Sub action(Id As Int32)
        Dim Myprint As PrintExam
        Myprint = New PrintExam(Id)
        Myprint.ShowDialog()
    End Sub
End Class