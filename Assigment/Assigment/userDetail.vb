Public Class userDetail
    Private Access As New LMS

    Private Sub userDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Usearch_Click(sender As Object, e As EventArgs) Handles Usearch.Click
        uPanel.Visible = True
        uPanel.BringToFront()
        Access.ExecQuery("SELECT * from Users WHERE Username LIKE '%" & Udetail.Text & "%'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 0 Then
            MessageBox.Show("Username not exist!")
            Exit Sub
        End If

        nameLabel.Text = "Name : " & Access.DBDT.Rows(0).Item(4)
        rollNo.Text = "Roll No : " & Access.DBDT.Rows(0).Item(3)
        discipline.Text = "Discipline : " & Access.DBDT.Rows(0).Item(6)
        webmail.Text = "Webmail : " & Access.DBDT.Rows(0).Item(1)
        Dept.Text = "Department : " & Access.DBDT.Rows(0).Item(7)

    End Sub

End Class
