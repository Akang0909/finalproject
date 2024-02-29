Imports MySql.Data.MySqlClient

Public Class Appointment

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=finalproject")
    Dim i As Integer
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub appReschedBtn_Click(sender As Object, e As EventArgs) Handles appReschedBtn.Click

    End Sub

    Public Sub ClearInputs()
        appIDTxt.Clear()
        appDTP1.Value = Now
        'appC.Text = ""
        'majorTxt.Clear()
        'gpaTxt.Clear()
    End Sub
    Sub edit()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE `appointments` SET `appointment_date`=@appointment_date,`status`=@status,`doctor_id`=@doctor_id WHERE `appointment_id`=@appointment_id", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("appointment_id", appIDTxt.Text)
            cmd.Parameters.AddWithValue("appointment_date", appDTP1)

            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Rescheduled Sucessfully!", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to reschedule!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        'DGV_load()

    End Sub
    Private Sub appCreateBtn_Click(sender As Object, e As EventArgs) Handles appCreateBtn.Click

    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub appDeleteBtn_Click(sender As Object, e As EventArgs) Handles appDeleteBtn.Click
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `appointments` WHERE 'appointment_id' = @appointment_id", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("appointment_id", appDeleteBtn.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record deleted sucessfully!", "Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Record failed to delete!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        'DGV_load()

    End Sub


    Private Sub appClearBtn_Click(sender As Object, e As EventArgs) Handles appClearBtn.Click

    End Sub

    Private Sub Appointment_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
