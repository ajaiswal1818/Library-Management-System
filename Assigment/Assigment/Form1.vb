Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SidePanel.Height = Button1.Height
        SidePanel.Top = Button1.Top

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles eBookBtn.Click
        SidePanel.Height = eBookBtn.Height
        SidePanel.Top = eBookBtn.Top
        EBooks1.Visible = True
        Search1.Visible = False
        Log1.Visible = False


    End Sub

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SidePanel.Height = SearchBtn.Height
        SidePanel.Top = SearchBtn.Top
        EBooks1.Visible = False
        Search1.Visible = True
        Log1.Visible = False
    End Sub


    Private Sub MyAccount_Click(sender As Object, e As EventArgs) Handles MyAccount.Click
        SidePanel.Height = MyAccount.Height()
        SidePanel.Top = MyAccount.Top()
        EBooks1.Visible = False
        Search1.Visible = False
        Log1.Visible = True

    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Panel4.Visible = False
        Panel1.Visible = True
        MyprofileSidePanel.Visible = False



    End Sub


    Private Sub Log1_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub MyprofileSidePanel_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Log1_Load_1(sender As Object, e As EventArgs) Handles Log1.Load

    End Sub
End Class
