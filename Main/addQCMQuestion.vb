Public Class addQCMQuestion
    Dim myMain As MainForm
    Private Sub addQCMQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)

    End Sub
    Public Sub New(main As MainForm)

        ' This call is required by the designer.
        InitializeComponent()
        myMain = main
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        Work()
    End Sub

    Private Sub Work()
        If TextBox_QCMques.Text.Length = 0 Then
            MsgBox("Please add a question first !")
        Else
            If TextBox_A.Text.Length * TextBox_B.Text.Length * TextBox_C.Text.Length * TextBox_D.Text.Length = 0 Then
                MsgBox("Please add all Options !")
            Else
                If checkIFExist() = False Then
                    Me.QCMQuest_tblTableAdapter.InsertQuery(TextBox_QCMques.Text, TextBox_A.Text, TextBox_B.Text, TextBox_C.Text, TextBox_D.Text, getTrueAnswer(), ComboBox1.SelectedValue)
                    MsgBox("added succefely ")
                    myMain.getCount()
                    TextBox_A.Text = ""
                    TextBox_B.Text = ""
                    TextBox_C.Text = ""
                    TextBox_D.Text = ""
                    TextBox_QCMques.Text = ""
                    TextBox_QCMques.Focus()

                Else
                    MsgBox("This question already exist !")
                End If
            End If
        End If


    End Sub

    Private Function getTrueAnswer() As String
        Dim result As String
        result = ""
        If RadioButton_A.Checked = True Then
            Return TextBox_A.Text
        End If
        If RadioButton_B.Checked = True Then
            Return TextBox_B.Text
        End If
        If RadioButton_C.Checked = True Then
            Return TextBox_C.Text
        End If
        If RadioButton_D.Checked = True Then
            Return TextBox_D.Text
        End If


    End Function

    Private Function checkIFExist() As Boolean

        If Me.QCMQuest_tblTableAdapter.checkIfExist(TextBox_QCMques.Text) = 0 Then
            Return False
        Else
            Return True

        End If

    End Function


End Class