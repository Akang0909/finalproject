

Imports MySql.Data.MySqlClient


Public Class RegisterForm


    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=finalproject")


    Public Sub Register()
        Try
            conn.Open()
            Dim query As String = "INSERT INTO `users` (`name`, `birth_date`, `email`, `contacts`, `address`, `username`, `password`) VALUES (@n, @bd, @e, @c, @a, @u, @p)"


            Dim cmd As New MySqlCommand(query, conn)


            cmd.Parameters.AddWithValue("@n", usernameTxt.Text)
            cmd.Parameters.AddWithValue("@bd", birthDatePck.Text)
            cmd.Parameters.AddWithValue("@e", emailTxt.Text)
            cmd.Parameters.AddWithValue("@c", phoneNumberTxt.Text)
            cmd.Parameters.AddWithValue("@a", addressTxt.Text)
            cmd.Parameters.AddWithValue("@u", usernameTxt.Text)
            cmd.Parameters.AddWithValue("@p", passwordTxt.Text)

            Dim i As Integer = cmd.ExecuteNonQuery()

            If i > 0 Then
                MessageBox.Show("Register Success!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Register Failed!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try


    End Sub




    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles user_firstname.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs)
        LoginForm.Show()
        Close()
    End Sub

    Private Sub txt_userid_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles user_phonenumber.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub


    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub Label2_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Register()



    End Sub

    Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

    End Sub
End Class