Public Class Search
    Private Access As New LMS
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Fill Datagrid
        dgvSrch.DataSource = Access.DBDT
    End Sub
End Class
