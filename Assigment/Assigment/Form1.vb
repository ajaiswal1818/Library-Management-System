Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RecommendBtn.Click
        SidePanel.Height = RecommendBtn.Height
        SidePanel.Top = RecommendBtn.Top
        SidePanel.Visible = True
        Myprofile.Visible = False
        EBooks1.Visible = False
        Search1.Visible = False
        Log1.Visible = False
        NewLogin.Visible = False
        Rec_book1.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles eBookBtn.Click
        SidePanel.Height = eBookBtn.Height
        SidePanel.Top = eBookBtn.Top
        SidePanel.Visible = True
        EBooks1.Visible = True
        Search1.Visible = False
        Log1.Visible = False
        Myprofile.Visible = False

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SidePanel.Height = SearchBtn.Height
        SidePanel.Top = SearchBtn.Top
        EBooks1.Visible = False
        Search1.Visible = True
        Log1.Visible = False
        Myprofile.Visible = False
        SidePanel.Visible = True

    End Sub


    Private Sub MyAccount_Click(sender As Object, e As EventArgs) Handles MyAccount.Click
        SidePanel.Height = MyAccount.Height()
        SidePanel.Top = MyAccount.Top()
        EBooks1.Visible = False
        Search1.Visible = False
        Log1.Visible = True
        SidePanel.Visible = True
        If Log.CurID <> 0 Then
            Myprofile.Visible = True
        End If

    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Panel4.Visible = False
        Panel1.Visible = True
        Myprofile.Visible = False
        Search1.Visible = True
        Myprofile.Arrow.Visible = False
        BooksIssued.Visible = False
        adminPanel.Visible = False
        SidePanel.Height = SearchBtn.Height
        SidePanel.Top = SearchBtn.Top
        Log1.Visible = False
        ChngPass.Visible = False

    End Sub

    Private Sub Myprofile_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub recommended_Click(sender As Object, e As EventArgs) Handles recommended.Click
        Reco.Visible = True

        Reco.BringToFront()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddBook_Click(sender As Object, e As EventArgs) Handles AddBook.Click
        AddBookP.BringToFront()
        Search1.Visible = False
    End Sub

    Private Sub RemoveBook_Click(sender As Object, e As EventArgs) Handles RemoveBook.Click
        remove_detail.BringToFront()

    End Sub

    Private Sub remove_detail_Load(sender As Object, e As EventArgs)

    End Sub
End Class
