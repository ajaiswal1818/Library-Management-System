Public Class Search
    Private Access As New LMS
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Fill Datagrid
        dgvSrch.DataSource = Access.DBDT

        ' Fill Combobox
        'For Each R As DataRow In Access.DBDT.Rows
        '    cbxSrch.Items.Add(R("Title"))
        'Next
        cbxSrch.AllowDrop() = True
        cbxSrch.Items.Add("Title")
        cbxSrch.Items.Add("ISBN")
        cbxSrch.Items.Add("Authors")
        cbxSrch.Items.Add("Genre")
        cbxSrch.Items.Add("Publisher")


        

        'Display first name found
        If Access.RecordCount > 0 Then cbxSrch.SelectedIndex = 0
    End Sub

    Private Sub cbxSrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSrch.SelectedIndexChanged
        Dim srchPattern As String

        srchPattern = cbxSrch.SelectedItem


    End Sub
End Class
