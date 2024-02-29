Imports MaternityClinicApp.My
Imports System.Threading
Imports MySql.Data.MySqlClient ' Import the MySQL data provider

Public Class LoginForm

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=finalproject")

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles label1.Click, label2.Click

    End Sub

    Private Sub btn_signup_Click_1(sender As Object, e As EventArgs) Handles registerBtn.Click
        RegisterForm.Show()
        Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles logInBtn.Click
        Dim username As String = usernameTxt.Text
        Dim password As String = passwordTxt.Text

        ' Perform authentication
        If AuthenticateUser(username, password) Then
            ' If authentication succeeds, show the main form and hide the login form
            MainForm.Show()
            Me.Hide()
        Else
            ' If authentication fails, show an error message
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        ' Use MySQL data provider classes for connection and command
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password"

        Using connection As New MySqlConnection(conn.ConnectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                If count > 0 Then
                    Return True ' Authentication succeeded
                Else
                    Return False ' Authentication failed
                End If
            End Using
        End Using
    End Function

    Private Sub passwordTxt_TextChanged(sender As Object, e As EventArgs) Handles passwordTxt.TextChanged

    End Sub
End Class
