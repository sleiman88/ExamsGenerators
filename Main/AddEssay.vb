Public Class AddEssay
    Public myMain
    Private Sub AddEssay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.EssayQuest_tbl' table. You can move, or remove it, as needed.
        Me.EssayQuest_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.EssayQuest_tbl)
        'TODO: This line of code loads data into the 'ExamsGenerator_DBDataSet.ExamsType_tbl' table. You can move, or remove it, as needed.
        Me.ExamsType_tblTableAdapter.Fill(Me.ExamsGenerator_DBDataSet.ExamsType_tbl)

    End Sub
    Public Sub New(main As MainForm)

        ' This call is required by the designer.
        InitializeComponent()
        myMain = main
        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        work()
    End Sub

    Private Sub work()
        If TextBox_Essay.Text.Length = 0 Then
            MsgBox("Please add an Essay first !!")
            TextBox_Essay.Focus()
        Else

            If checkIfExist() = False Then
                Me.EssayQuest_tblTableAdapter.InsertQuery(TextBox_Essay.Text, getGrade().ToString, Decimal.Parse(ComboBox1.SelectedValue))
                MsgBox("Essay added Succefuly ")
                myMain.getCount()

                TextBox_Essay.Text = ""
                TextBox_Essay.Focus()


            Else
                MsgBox("This question already exist ")
            End If



        End If
    End Sub
    Private Function getGrade() As Decimal
        Dim result As Decimal

        If RadioButton_10.Checked = True Then
            result = 10
        End If
        If RadioButton_15.Checked = True Then
            result = 15
        End If
        If RadioButton_20.Checked = True Then
            result = 20
        End If

        Return result
    End Function

    Private Function checkIfExist() As Boolean
        If Me.EssayQuest_tblTableAdapter.checkIfExist(TextBox_Essay.Text) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class