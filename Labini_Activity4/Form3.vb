Imports MySql.Data.MySqlClient

Public Class signupForm

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Call Connect_to_DB()
        Dim mycmd As New MySqlCommand
        mycmd.Connection = myconn

        Dim firstname As String = txtFirstname.Text
        Dim lastname As String = txtLastname.Text
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim phonenumber As String = txtContactnumber.Text
        Dim email As String = txtEmail.Text
        Dim role As String = "cashier"

        Dim sql As String = "INSERT INTO users (firstname, lastname, username, password, role, phonenumber, email) VALUES (@firstname, @lastname, @username, @password, @role, @phonenumber, @email)"
        mycmd = New MySqlCommand(sql, mycmd.Connection)

        mycmd.Parameters.AddWithValue("@firstname", firstname)
        mycmd.Parameters.AddWithValue("@lastname", lastname)
        mycmd.Parameters.AddWithValue("@username", username)
        mycmd.Parameters.AddWithValue("@password", password)
        mycmd.Parameters.AddWithValue("@role", role)
        mycmd.Parameters.AddWithValue("@phonenumber", phonenumber)
        mycmd.Parameters.AddWithValue("@email", email)
        mycmd.ExecuteNonQuery()
        MessageBox.Show("You have successfully created your account!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Disconnect_to_DB()

        Form1.Show()
        Hide()

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Hide()
    End Sub
End Class