Public Class Search
    Private Access As New LMS
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbxSrch.AllowDrop() = True
        cbxSrch.Items.Add("Title")
        cbxSrch.Items.Add("ISBN")
        cbxSrch.Items.Add("Authors")
        cbxSrch.Items.Add("Genre")
        cbxSrch.Items.Add("Publisher")

        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Fill Datagrid
        dgvSrch.DataSource = Access.DBDT

        ' Fill Combobox
        'For Each R As DataRow In Access.DBDT.Rows
        '    cbxSrch.Items.Add(R("Title"))
        'Next



        

        'Display first name found
        If Access.RecordCount > 0 Then cbxSrch.SelectedIndex = 0
    End Sub

    Private Sub cbxSrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSrch.SelectedIndexChanged
        Dim srchPattern As String

        srchPattern = cbxSrch.SelectedItem


    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        If cbxSrch.SelectedItem = "Title" Then
            Access.ExecQuery("SELECT * from Book WHERE Title = '" & txtSrch.text & "'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            dgvSrch.DataSource = Access.DBDT
        End If
    End Sub

    Private Sub txtSrch_Click(sender As Object, e As EventArgs) Handles txtSrch.Click
        txtSrch.ResetText()

    End Sub
End Class
