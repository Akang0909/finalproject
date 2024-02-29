

Public Class MainForm

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pagePnl.Controls.Add(New Dashboard())
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub panel_mr_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'panel_appoint.Hide()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        'pnl3.Show()


    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub panel_profile_Paint(sender As Object, e As PaintEventArgs)


    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New Dashboard())
    End Sub

    Private Sub medicalRecordsBtn_Click(sender As Object, e As EventArgs) Handles medicalRecordsBtn.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New Billing())
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        ' Prompt the user to sign out
        sign_out()
    End Sub

    Private Sub sign_out()
        Dim result As DialogResult = MessageBox.Show("Sign Out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Additional code for any tasks before exiting the program, if needed
            Me.Close() ' Close the current form
        ElseIf result = DialogResult.No Then
            ' Continue with the dashboard functionality
        End If
    End Sub

    Private Sub appointmentsBtn_Click(sender As Object, e As EventArgs) Handles appointmentsBtn.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New Contact())
    End Sub

    Private Sub aboutUsBtn_Click(sender As Object, e As EventArgs) Handles aboutUsBtn.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New AboutUs())
    End Sub

    Private Sub pagePnl_Paint(sender As Object, e As PaintEventArgs) Handles pagePnl.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New Consultation())
    End Sub

    Private Sub contactInfoBtn_Click(sender As Object, e As EventArgs) Handles contactInfoBtn.Click
        pagePnl.Controls.Clear()
        pagePnl.Controls.Add(New Contact())
    End Sub
End Class