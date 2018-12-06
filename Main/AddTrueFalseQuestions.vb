Public Class AddTrueFalseQuestions
    Private Sub AddTrueFalseQuestions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        '  Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)

    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click

    End Sub
End Class