﻿Public Class Myprofile
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnmyprofile.Click
        Arrow.Visible = True
        Arrow.Top = btnmyprofile.Top + 12
        Form1.Log1.Visible = False
        Form1.CurProfile.Visible = True
        Form1.ChngPass.Visible = False
        Form1.BooksIssued.Visible = False

    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Arrow.Visible = True
        Arrow.Top = btnItems.Top + 12
        Form1.BooksIssued.Visible = True
        Form1.ChngPass.Visible = False
        Form1.Log1.Visible = False
        Form1.CurProfile.Visible = False

    End Sub

    Private Sub btnPasschange_Click(sender As Object, e As EventArgs) Handles btnPasschange.Click
        Arrow.Visible = True
        Arrow.Top = btnPasschange.Top + 12
        Form1.BooksIssued.Visible = False
        Form1.Log1.Visible = False
        Form1.CurProfile.Visible = False
        Form1.ChngPass.Visible = True
    End Sub
End Class
