Public Class AddTruefalse
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Work()
    End Sub

    Private Sub Work()

        If TextBox_TFQues.Text.Length = 0 Then
            MsgBox("Please enter question First !")
            TextBox_TFQues.Focus()

        Else

            If checkIfExist() = False Then
                Me.TrueFalse_tblTableAdapter.InsertQuery(TextBox_TFQues.Text, RadioButton_true.Checked, Decimal.Parse(ComboBox_ExamType.SelectedValue))

                MsgBox("added Succefully ")
                ' Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)
                TextBox_TFQues.Text = ""
                TextBox_TFQues.Focus()

            Else
                MsgBox("this question already exist !! ")
            End If

        End If
    End Sub

    Private Function checkIfExist() As Boolean
        If Me.TrueFalse_tblTableAdapter.checkIfExist(TextBox_TFQues.Text) = 0 Then

            Return False
        Else
            Return True

        End If

        Return False
    End Function

    Private Sub AddTruefalse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.TrueFalse_tbl' table. You can move, or remove it, as needed.
        '   Me.TrueFalse_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.TrueFalse_tbl)

    End Sub

    Private Sub RadioButton_true_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_true.CheckedChanged

    End Sub
End Class