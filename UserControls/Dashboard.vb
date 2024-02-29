
Imports System.Windows.Forms


Public Class Dashboard


    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub profileImg_Click(sender As Object, e As EventArgs) Handles profileImg.Click
        If profileDlg.ShowDialog() = DialogResult.OK Then
            profileImg.Image = Image.FromFile(profileDlg.FileName)
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub recentlyMedicalRecordsLst_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
