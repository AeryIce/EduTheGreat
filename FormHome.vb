Public Class FormHome
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
        FormLogin.Close()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click

    End Sub

    Private Sub ButtonHome_MouseHover(sender As Object, e As EventArgs) Handles ButtonHome.MouseHover
        Me.ButtonHome.BackColor = Color.White
    End Sub

    Private Sub ButtonHome_MouseLeave(sender As Object, e As EventArgs) Handles ButtonHome.MouseLeave
        Me.ButtonHome.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonExit_MouseHover(sender As Object, e As EventArgs) Handles ButtonExit.MouseHover
        Me.ButtonExit.BackColor = Color.White
    End Sub

    Private Sub ButtonExit_MouseLeave(sender As Object, e As EventArgs) Handles ButtonExit.MouseLeave
        Me.ButtonExit.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonAdmin_MouseHover(sender As Object, e As EventArgs) Handles ButtonAdmin.MouseHover
        Me.ButtonAdmin.BackColor = Color.White
    End Sub

    Private Sub ButtonAdmin_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAdmin.MouseLeave
        Me.ButtonAdmin.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonReport_MouseHover(sender As Object, e As EventArgs) Handles ButtonReport.MouseHover
        Me.ButtonReport.BackColor = Color.White
    End Sub

    Private Sub ButtonReport_MouseLeave(sender As Object, e As EventArgs) Handles ButtonReport.MouseLeave
        Me.ButtonReport.BackColor = Color.LightBlue
    End Sub

    Private Sub ButtonBook_MouseHover(sender As Object, e As EventArgs) Handles ButtonBook.MouseHover
        Me.ButtonBook.BackColor = Color.White
    End Sub

    Private Sub ButtonBook_MouseLeave(sender As Object, e As EventArgs) Handles ButtonBook.MouseLeave
        Me.ButtonBook.BackColor = Color.LightBlue
    End Sub


    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonBook_Click(sender As Object, e As EventArgs) Handles ButtonBook.Click
        FormBook.Show()
        Me.Close()

    End Sub
End Class