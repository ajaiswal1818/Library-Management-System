Imports System.IO
Public Class CurProfile

    Private Access As New LMS

    Private Sub CurProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Access.ExecQuery("SELECT * from Users WHERE [ID] =" & Log.CurID)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        nameLabel.Text = "Name : " & Access.DBDT.Rows(0).Item(4)
        rollNo.Text = "Roll No : " & Access.DBDT.Rows(0).Item(3)
        discipline.Text = "Discipline : " & Access.DBDT.Rows(0).Item(6)
        webmail.Text = "Webmail : " & Access.DBDT.Rows(0).Item(1)
        Dept.Text = "Department : " & Access.DBDT.Rows(0).Item(7)


        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)

        fullPath = fullPath.Substring(0, fullPath.Length - 39) & "\Assigment\bin\Debug\Resource\"

        Dim Path As String = fullPath & Access.DBDT.Rows(0).Item(1) & ".jpg"

        If File.Exists(Path) Then
            PicProfile.ImageLocation = (Path)
            PicProfile.Load()
        End If
    End Sub

End Class
