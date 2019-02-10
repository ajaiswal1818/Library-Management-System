Public Class Log

    Public Shared CurID As Integer = 0
    Public Shared CurUser As String = ""
    Public Shared CurPass As String = ""
    Public Shared CurRoll As Integer = 0
    Public Shared CurName As String = ""
    Public Shared CurAccess As String = ""
    Public Shared CurProg As String = ""
    Public Shared CurDept As String = ""
    Public Shared CurBkLimit As Integer = 0
    Public Shared CurBooks As String = ""

    Private Access As New LMS

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
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

        Access.ExecQuery("SELECT * FROM Users WHERE Username = '" & txtUser.Text & "' AND Psswd = '" & txtPass.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If Access.DBDT.Rows.Count = 0 Then
            MessageBox.Show("Incorrect Username or Password", "Error")
            Exit Sub
        ElseIf txtUser.Text = "root" Then
            Form1.adminPanel.BringToFront()
            Form1.adminPanel.Visible = True
            'Form1.remove_detail.Visible = True
            'Form1.remove_detail.BringToFront()
            Form1.AddBookP.Visible = True
            Form1.AddBookP.BringToFront()
            Form1.Panel4.Visible = True
            Form1.Panel4.BringToFront()
            Form1.Panel1.Visible = False
        Else
            CurID = Access.DBDT.Rows(0).Item(0)
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
            Form1.Panel4.BringToFront()
            Form1.Search1.Visible = True
            Form1.Search1.BringToFront()
            Form1.SidePanel.Height = Form1.SearchBtn.Height
            Form1.SidePanel.Top = Form1.SearchBtn.Top
        End If

    End Sub

    Private Sub Sign_Click(sender As Object, e As EventArgs) Handles Sign_up.Click
        Form1.NewLogin.Visible = True
        Form1.NewLogin.BringToFront()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Forgot_Click(sender As Object, e As EventArgs) Handles Forgot.Click

    End Sub
End Class
