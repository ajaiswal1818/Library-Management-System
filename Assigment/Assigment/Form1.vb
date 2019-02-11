Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RecommendBtn.Click
        SidePanel.Height = RecommendBtn.Height
        SidePanel.Top = RecommendBtn.Top
        SidePanel.BringToFront()
        Rec_book1.BringToFront()
        SidePanel.Visible = True
        Rec_book1.Visible = True
        If Log.CurID <> 0 Then
            Myprofile.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles eBookBtn.Click
        SidePanel.Height = eBookBtn.Height
        SidePanel.Top = eBookBtn.Top
        SidePanel.BringToFront()
        EBooks1.BringToFront()
        SidePanel.Visible = True
        EBooks1.Visible = True
        If Log.CurID <> 0 Then
            Myprofile.Visible = False
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        SidePanel.Height = SearchBtn.Height
        SidePanel.Top = SearchBtn.Top
        Search1.BringToFront()
        SidePanel.BringToFront()
        Search1.Visible = True
        SidePanel.Visible = True
        If Log.CurID <> 0 Then
            Myprofile.Visible = False
        End If
        BooksIssued.RefreshPage()
    End Sub


    Private Sub MyAccount_Click(sender As Object, e As EventArgs) Handles MyAccount.Click
        Log1.txtUser.Clear()
        Log1.txtPass.Clear()
        SidePanel.Height = MyAccount.Height()
        SidePanel.Top = MyAccount.Top()
        Log1.BringToFront()
        Log1.Visible = True
        SidePanel.BringToFront()
        SidePanel.Visible = True
        If Log.CurID <> 0 Then
            Myprofile.BringToFront()
            Myprofile.Visible = True
            Myprofile.Arrow.Visible = True
            Myprofile.Arrow.Top = Myprofile.btnmyprofile.Top + 12
            CurProfile.BringToFront()
            CurProfile.Visible = True
        End If

    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Panel1.BringToFront()
        Search1.BringToFront()
        adminPanel.Visible = False
        Panel1.Visible = True
        Search1.Visible = True
        SidePanel.Height = SearchBtn.Height
        SidePanel.Top = SearchBtn.Top
        Myprofile.Visible = False
        Panel4.Visible = False

        Log.CurID = 0
        Log.CurUser = ""
        Log.CurPass = ""
        Log.CurRoll = 0
        Log.CurName = ""
        Log.CurAccess = ""
        Log.CurProg = ""
        Log.CurDept = ""
        Log.CurBkLimit = 0
        Log.CurBooks = ""
    End Sub

    Private Sub recommended_Click(sender As Object, e As EventArgs) Handles recommended.Click
        Reco.BringToFront()
        Reco.Visible = True
    End Sub

    Private Sub AddBook_Click(sender As Object, e As EventArgs) Handles AddBook.Click
        AddBookP.BringToFront()
        AddBookP.Visible = True
        Panel6.Visible = True
        Panel6.BringToFront()
        Panel6.Height = AddBook.Height
        Panel6.Top = AddBook.Top
    End Sub

    Private Sub RemoveBook_Click(sender As Object, e As EventArgs) Handles RemoveBook.Click
        remove_detail.BringToFront()
        remove_detail.Visible = True
        Panel6.Visible = True
        Panel6.BringToFront()
        Panel6.Height = RemoveBook.Height
        Panel6.Top = RemoveBook.Top
        Remove_detail1.Clr_Rem()
        Remove_detail1.Clr_lbl()
        If remove_detail.cnt_del <> 0 Then
            remove_detail.Clr_Del()
        End If
        remove_detail.Refr()
        remove_detail.check_btn = 0
        'MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)
    End Sub

    Private Sub BookDetail_Click(sender As Object, e As EventArgs) Handles BookDetail.Click
        remove_detail.BringToFront()
        remove_detail.Visible = True
        Panel6.Visible = True
        Panel6.BringToFront()
        Panel6.Height = BookDetail.Height
        Panel6.Top = BookDetail.Top
        remove_detail.Clr_Del()
        remove_detail.Clr_lbl()
        If remove_detail.cnt_rem <> 0 Then
            remove_detail.Clr_Rem()
        End If
        remove_detail.Refr()
        remove_detail.check_btn = 1
        'MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)

    End Sub

    Private Sub UserDetail_Click(sender As Object, e As EventArgs) Handles UserDetail.Click
        UserDetail1.BringToFront()
        UserDetail1.Visible = True
        Panel6.Visible = True
        Panel6.BringToFront()
        Panel6.Height = UserDetail.Height
        Panel6.Top = UserDetail.Top
        UserDetail1.Clear()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        DiscRoom.BringToFront()
        DiscRoom.Visible = True
        SidePanel.Visible = False
        Panel6.Visible = False
    End Sub

    Private Sub Myprofile_Load(sender As Object, e As EventArgs) Handles Myprofile.Load

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub
End Class
