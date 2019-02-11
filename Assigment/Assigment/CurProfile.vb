Imports System.IO
Public Class CurProfile

    Private Access As New LMS

    Public Sub CurProfile_Load()

        If Log.CurID = 0 Then
            Exit Sub
        End If

        Access.ExecQuery("SELECT * from Users WHERE [ID] =" & Log.CurID)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        nameLabel.Font = New Font("Century Gothic", 24)
        rollNo.Font = New Font("Century Gothic", 12)
        discipline.Font = New Font("Century Gothic", 12)
        webmail.Font = New Font("Century Gothic", 12)
        Dept.Font = New Font("Century Gothic", 12)
        nameLabel.Text = Access.DBDT.Rows(0).Item(4)
        rollNo.Text = "Roll No :   " & Access.DBDT.Rows(0).Item(3)
        discipline.Text = "Discipline :   " & Access.DBDT.Rows(0).Item(6)
        webmail.Text = "Webmail :   " & Access.DBDT.Rows(0).Item(1) & "@iitg.ac.in"
        Dept.Text = "Department :   " & Access.DBDT.Rows(0).Item(7)


        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 39) & "\Resource\"

        Dim Path As String = fullPath & Access.DBDT.Rows(0).Item(1) & ".jpg"
        If File.Exists(Path) Then
            PicProfile.ImageLocation = (Path)
            PicProfile.Load()
        Else
            Path = fullPath & "Default.jpg"
            PicProfile.ImageLocation = (Path)
            PicProfile.Load()
        End If
    End Sub

    Private Sub CurProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nameLabel_Click(sender As Object, e As EventArgs) Handles nameLabel.Click

    End Sub
End Class
