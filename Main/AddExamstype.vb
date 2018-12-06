Public Class AddExamstype
    Private Sub AddExamstype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        'Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)

    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Work()

    End Sub

    Private Sub TextBox_ExamsType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_ExamsType.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Work()
        End If
    End Sub

    Private Sub Work()
        If TextBox_ExamsType.Text.Length = 0 Then
            MsgBox("Please enter Exam tyme first !")
            TextBox_ExamsType.Focus()

        Else


            If checkIfExist() = False Then
                Me.ExamsType_tblTableAdapter.InsertQuery(TextBox_ExamsType.Text)
                MsgBox("added Succefully ")
                TextBox_ExamsType.Text = ""
                TextBox_ExamsType.Focus()

            Else
                MsgBox("this exam type already exist ")
            End If

        End If
    End Sub

    Private Function checkIfExist() As Boolean
        If Me.ExamsType_tblTableAdapter.checkIfExist(TextBox_ExamsType.Text) = 0 Then
            Return False
        Else
            Return True

        End If

        Return False
    End Function
End Class