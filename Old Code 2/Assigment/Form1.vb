Public Class Form1
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Log1.BringToFront()
    End Sub

    Private Sub Panel11_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SidePanel.Height = Button1.Height
        SidePanel.Top = Button1.Top

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SidePanel.Height = Button2.Height
        SidePanel.Top = Button2.Top
        EBooks1.BringToFront()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Log1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub EBooks1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Searchbar_OnTextChange(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SidePanel.Height = Button3.Height
        SidePanel.Top = Button3.Top
        Search1.BringToFront()
    End Sub

    Private Sub Search1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Log2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Log1_Load_1(sender As Object, e As EventArgs)

    End Sub
End Class
