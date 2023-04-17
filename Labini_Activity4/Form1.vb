Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from users where username = '" _
                & .username.Text & "' and password = '" _
                & .password.Text & "'"

            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            Dim userType As String = ""

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                myreader.Read()
                userType = myreader.GetString("role")
                .username.Text = ""
                .password.Text = ""
                .Hide()
            Else
                MessageBox.Show("Invalid username or password")
            End If
            Call Disconnect_to_DB()

            If userType = "admin" Then
                admin.Show()
            ElseIf userType = "cashier" Then
                Fooderia.Show()
            End If
        End With
    End Sub

    Private Sub signup_Click(sender As Object, e As EventArgs) Handles signup.Click
        Hide()
        signupForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
