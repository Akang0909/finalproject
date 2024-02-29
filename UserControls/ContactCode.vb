Imports MySql.Data.MySqlClient
Module ContactCode
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=finalproject")
    End Function

    Public strcom As MySqlConnection = strconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub Create(ByVal sql As String)
        Try
            strcom.Open()
            With cmd
                .Connection = strcom
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("Create appointment failed", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Create appointment added", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcom.Close()
        End Try
    End Sub



    Public Sub Reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcom.Open()
            With cmd
                .Connection = strcom
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.atasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcom.Close()
        End Try


    End Sub

    Public Sub InsertAppointment(selectedDate As DateTime)
        Try
            Dim formattedDate As String = selectedDate.ToString("yyyy-MM-dd")
            Dim commandText As String = $"INSERT INTO appointments (appointment_date) VALUES ('{formattedDate}')"
            Create(commandText)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module
