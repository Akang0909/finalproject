Imports MySql.Data.MySqlClient


Public Class Contact

    Dim conn As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=finalproject")

    Dim i As Integer
    Dim dr As MySqlDataReader

    Private Sub buttonCreate_Click(sender As Object, e As EventArgs) Handles createContactBtn.Click
        Try


            ' Call the function to insert the appointment


            ' Combine the two SQL queries into one
            Dim combinedQuery As String = "INSERT INTO doctors (doctor_fullname, contact_info) VALUES('" & physicianNameTxt.Text & "','" & contactPhysicianTxt.Text & "');" &
                                      "INSERT INTO emergency_contacts (name_emergency, relationship, emergency_contact) VALUES('" & nameEmergencyTxt.Text & "','" & relationshipTxt.Text & "','" & emergencyContactTxt.Text & "')"

            ' Call the Create function with the combined query
            Create(combinedQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'DGV_load()

    End Sub

    Public Sub clear()
        'emergency id clear here'
        nameEmergencyTxt.Clear()
        relationshipTxt.Clear()
        emergencyContactTxt.Clear()
    End Sub


    Sub edit()
        Try
            conn.Open()

            Dim cmd As New MySqlCommand("UPDATE `emergency_contacts` SET `name_emergency`=@name_emergency,`relationship`=@relationship,`emergency_contact`=@emergency_contact WHERE `emergency_id`=@emergency_id", conn)
            cmd.Parameters.Clear()
            'cmd.Parameters.AddWithValue("emergency_id",) make emergency id label and txtbox'
            cmd.Parameters.AddWithValue("emergency_name", nameEmergencyTxt)
            cmd.Parameters.AddWithValue("relationship", relationshipTxt)
            cmd.Parameters.AddWithValue("emergency_contact", emergencyContactTxt)


            i = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("Update Sucessfully!", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to update!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        'DGV_load()

    End Sub

    Private Sub rescheduleBtn_Click(sender As Object, e As EventArgs) Handles contactUpdateBtn.Click
        edit()

    End Sub


    Private Sub contactDeleteBtn_Click(sender As Object, e As EventArgs) Handles contactDeleteBtn.Click
        Try

            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM `emergency_contacts` WHERE 'emergency_id' = @emergency_id", conn)

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("emergency_id", contactDeleteBtn.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Contact deleted sucessfully!", "Contact", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Contact failed to delete!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()

        End Try
        'DGV_load()

    End Sub


    'Private Sub ReadAppointbtn_Click(sender As Object, e As EventArgs) Handles contactClearBtn.Click

    '    DTGAppointment.Rows.Clear()
    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("SELECT * FROM `appointments`", conn)

    '        Dim adapter As New MySqlDataAdapter(cmd)
    '        Dim dataTable As New DataTable()
    '        adapter.Fill(dataTable)

    '        DTGAppointment.DataSource = dataTable

    '    Catch ex As Exception

    '    Finally
    '        conn.Close()
    '    End Try

    'End Sub
    'DGV_load()


    'Public Sub DGV_load()
    '    DTGAppointment.Rows.Clear()
    '    Try
    '        conn.Open()
    '        Dim query As String = "SELECT * FROM appointments " &
    '                          "INNER JOIN doctors ON appointments.doctor_id = doctors.doctor_id " &
    '                          "LEFT JOIN emergency_contacts ON appointments.emergency_id = emergency_contacts.emergency_id " &
    '                          "INNER JOIN users ON appointments.id = users.id"

    '        Dim cmd As MySqlCommand = New MySqlCommand(query, conn)
    '        dr = cmd.ExecuteReader()

    '        While dr.Read
    '            DTGAppointment.Rows.Add(dr.Item("appointment_date"), dr.Item("name"), dr.Item("doctor_fullname"), dr.Item("status"))
    '        End While

    '        dr.Close()
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    'multiple comment is ctrl + k + c



    Private Sub Appointments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles reasonAppointmentTxt.TextChanged

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub



    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Label19_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles createContactBtn.Click
        'CreateAppointment()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles nameEmergencyTxt.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub editAppointmentBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub fullnameTxt_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub physicianNameTxt_TextChanged(sender As Object, e As EventArgs) Handles physicianNameTxt.TextChanged

    End Sub


End Class
