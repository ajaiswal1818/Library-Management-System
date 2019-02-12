Public Class Rec_book

    Private Access As New LMS

    Private Sub Rec_isbn_TextChanged(sender As Object, e As EventArgs) Handles Rec_isbn.Click
        Rec_isbn.Text = ""
    End Sub

    Private Sub Rec_title_TextChanged(sender As Object, e As EventArgs) Handles Rec_title.Click
        Rec_title.Text = ""

    End Sub

    Private Sub Rec_author_TextChanged(sender As Object, e As EventArgs) Handles Rec_Auth.Click
        Rec_Auth.Text = ""

    End Sub


    Private Sub Rectbn_Click(sender As Object, e As EventArgs) Handles Rectbn.Click
        If Rec_Auth.Text = "Authors" Or Rec_title.Text = "Title" Or Rec_isbn.Text = "ISBN" Then
            MessageBox.Show("Please fill in all fields!")
            Console.Write("Error: Not all field filled!")
            Exit Sub
        End If
        If Log.CurUser <> "" Then
            Access.ExecQuery("SELECT * FROM Book WHERE ISBN = '" & Rec_isbn.Text & "'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            If Rec_isbn.Text = "" Or Rec_title.Text = "" Or Rec_Auth.Text = "" Then
                MessageBox.Show("Please enter all fields!", "Error")
                Console.Write("Error: Field left empty")
                Exit Sub
            ElseIf Access.DBDT.Rows.Count <> 0 Then
                MessageBox.Show("Book already exists in the library!")
                Console.Write("Error: Book already exists")
                Exit Sub
            End If

            Add_recommend()

        Else
            MessageBox.Show("Login to recommend!")
            Console.WriteLine("login first!")
            Exit Sub
        End If

    End Sub


    Private Sub Add_recommend()


        Dim insert As String = "Insert into Rec (ISBN, Title, Authors) values ('" & Rec_isbn.Text & "','" & Rec_title.Text & "','" & Rec_Auth.Text & "')"
        Access.ExecQuery(insert)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Access.ExecQuery("Select * from Rec where ISBN = '" & Rec_isbn.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 1 Then
            MessageBox.Show("Recommendation for " & Rec_title.Text & " added successfully")
            Console.WriteLine("Recommendation for " & Rec_title.Text & " added successfully")
            
        Else
            Console.WriteLine("Recommendation for " & Rec_title.Text & " failed")
        End If

    End Sub

    
    Private Sub Rec_title_TextChanged_1(sender As Object, e As EventArgs) Handles Rec_title.Click
        Rec_title.Text = ""
        Rec_title.ForeColor = Color.Black

    End Sub

    Private Sub Rec_Auth_TextChanged(sender As Object, e As EventArgs) Handles Rec_Auth.Click
        Rec_Auth.Text = ""
        Rec_Auth.ForeColor = Color.Black

    End Sub

    Private Sub Rec_isbn_TextChanged_1(sender As Object, e As EventArgs) Handles Rec_isbn.Click
        Rec_isbn.Text = ""
        Rec_isbn.ForeColor = Color.Black

    End Sub
End Class
