Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SidePanel.Height = Button1.Height
        SidePanel.Top = Button1.Top

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SidePanel.Height = Button2.Height
        SidePanel.Top = Button2.Top
        EBooks1.BringToFront()
    End Sub

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SidePanel.Height = Button3.Height
        SidePanel.Top = Button3.Top
        Search1.BringToFront()
    End Sub


    Private Sub MyAccount_Click(sender As Object, e As EventArgs) Handles MyAccount.Click
        Log1.BringToFront()

    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Panel4.Visible = False
        Panel1.Visible = True
        MyprofileSidePanel.Visible = False


    End Sub


End Class
