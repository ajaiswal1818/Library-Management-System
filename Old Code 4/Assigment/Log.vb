Public Class Log

    Public CurUser As String = ""
    Public CurPass As String = ""
    Public CurRoll As Integer = 0
    Public CurName As String = ""
    Public CurAccess As String = ""
    Public CurProg As String = ""
    Public CurDept As String = ""
    Public CurBkLimit As Integer = 0
    Public CurBooks As String = ""

    Private Access As New LMS

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Access.ExecQuery("SELECT * FROM Users")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ''Fill Datagrid
        dgvUser.DataSource = Access.DBDT

    End Sub

    Private Sub LogIn_Click(sender As Object, e As EventArgs) Handles LogIn.Click
        If txtPass.Text = "" Or txtUser.Text = "" Then
            MessageBox.Show("Please enter username and password", "Error")
            Exit Sub
        End If

        Access.ExecQuery("SELECT * FROM Users WHERE Username = '" & txtUser.Text & "' AND Password = '" & txtPass.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If Access.DBDT.Rows.Count = 0 Then
            MessageBox.Show("Incorrect Username or Password", "Error")
            Exit Sub
        End If

        CurUser = Access.DBDT.Rows(0).Item(1)
        CurPass = Access.DBDT.Rows(0).Item(2)
        CurRoll = Access.DBDT.Rows(0).Item(3)
        CurName = Access.DBDT.Rows(0).Item(4)
        CurAccess = Access.DBDT.Rows(0).Item(5)
        CurProg = Access.DBDT.Rows(0).Item(6)
        CurDept = Access.DBDT.Rows(0).Item(7)
        CurBkLimit = Access.DBDT.Rows(0).Item(8)
        CurBooks = Access.DBDT.Rows(0).Item(9)

        Form1.Panel4.Visible = True
        Form1.Panel1.Visible = False
        Form1.Log1.Visible = False
        Form1.MyprofileSidePanel.Visible = True
    End Sub

    Private Sub Sign_Click(sender As Object, e As EventArgs) Handles Sign_up.Click
        Form1.NewLogin.Visible = True
        Form1.Panel4.Visible = False
        Form1.Log1.Visible = False
        Form1.MyprofileSidePanel.Visible = False

    End Sub

End Class
