Public Class addBook

    Private Access As New LMS
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If bookTitle.Text = "" Or author.Text = "" Or ISBN.Text = "" Or genre.Text = "" Or publisher.Text = "" Then
            MessageBox.Show("Please enter all fields!", "Error")
            Console.Write("Error: Field left empty")
            Exit Sub
        End If

        Access.ExecQuery("Select * from Book where ISBN = '" & ISBN.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 1 Then
            Dim temp As Integer = Access.DBDT.Rows(0).Item(4) + 1
            Dim increment As String = "Update Book set Copies_Available =" & temp & " where ISBN ='" & ISBN.Text & "'"
            Access.ExecQuery(increment)
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        Else
            addnewBook()
        End If


    End Sub
    Private Sub addnewBook()

        Dim tmp As String = "0"
        Dim tmp2 As Integer = 1
        Dim insert As String = "Insert into Book (Title, ISBN, Authors, Copies_Available, Issued_to, Genre, Publisher) values ('" & bookTitle.Text & "','" & ISBN.Text & "','" & author.Text & "'," & tmp2 & ",'" & tmp & "','" & genre.Text & "','" & publisher.Text & "')"
        Access.ExecQuery(insert)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Access.ExecQuery("Select * from Book where ISBN = '" & ISBN.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 1 Then
            MessageBox.Show("Book " & bookTitle.Text & " successfully added")
            Console.WriteLine("Book " & bookTitle.Text & " successfully added")
        Else
            Console.WriteLine("Book " & bookTitle.Text & " Book not added")
        End If

    End Sub


    Private Sub bookTitle_TextChanged(sender As Object, e As EventArgs) Handles bookTitle.Click
        bookTitle.Text = ""
    End Sub

    Private Sub author_TextChanged(sender As Object, e As EventArgs) Handles author.Click
        author.Text = ""
    End Sub

    Private Sub ISBN_TextChanged(sender As Object, e As EventArgs) Handles ISBN.Click
        ISBN.Text = ""
    End Sub

    Private Sub genre_TextChanged(sender As Object, e As EventArgs) Handles genre.Click
        genre.Text = ""
    End Sub

    Private Sub publisher_TextChanged(sender As Object, e As EventArgs) Handles publisher.Click
        publisher.Text = ""
    End Sub
End Class
