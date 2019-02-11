Public Class ChngPass

    Private Access As New LMS


    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If oldpass.Text = "" Or newpass.Text = "" Or newpass2.Text = "" Then
            MessageBox.Show("Please enter all the fields", "Error")
            Exit Sub
        End If
        If oldpass.Text <> Log.CurPass Then
            MessageBox.Show("Old password incorrect!")
            Exit Sub
        End If
        If newpass.Text <> newpass2.Text Then
            MessageBox.Show("Password confirmation failed!")
        End If


        changepass()
    End Sub

    Private Sub changepass()
        If Log.CurUser = "" Then
            MessageBox.Show("You are not currently logged in!")
            Exit Sub
        End If
        'MessageBox.Show(newpass.Text)
        'Dim update As String =
        'Dim update As String = "Select * from Users where Username='" & Log.CurUser & "'"
        Dim pass As String = CStr(newpass.Text)
        Access.ExecQuery("Update Users set Psswd='" & pass & "' where [ID]=" & Log.CurID)

        'Access.ExecQuery("Update Users Set Psswd='" & newpass.Text & "' where [ID]= " & Log.CurID)
        'Access.ExecQuery("Select * From Users where [ID]=" & Log.CurID)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'If Access.DBDT.Rows.Count = 0 Then
        '    MessageBox.Show("Username not found")
        'End If
        MessageBox.Show("Password Changed Successfully")
        oldpass.Clear()
        newpass.Clear()
        newpass2.Clear()
    End Sub

    Private Sub ChngPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
