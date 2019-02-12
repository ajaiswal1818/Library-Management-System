Public Class Myprofile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmyprofile.Click
        Arrow.Visible = True
        Arrow.Top = btnmyprofile.Top + 12
        Form1.CurProfile.BringToFront()
        Form1.CurProfile.Visible = True
    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Arrow.Visible = True
        Arrow.Top = btnItems.Top + 12
        Form1.BooksIssued.BringToFront()
        Form1.BooksIssued.Visible = True
        Form1.BooksIssued.Clr()
        Form1.BooksIssued.RefreshPage()
    End Sub

    Private Sub btnPasschange_Click(sender As Object, e As EventArgs) Handles btnPasschange.Click
        Arrow.Visible = True
        Arrow.Top = btnPasschange.Top + 12
        Form1.ChngPass.BringToFront()
        Form1.ChngPass.Visible = True
        Form1.ChngPass.oldpass.Text = ""
        Form1.ChngPass.newpass.Text = ""
        Form1.ChngPass.newpass2.Text = ""
    End Sub
End Class
