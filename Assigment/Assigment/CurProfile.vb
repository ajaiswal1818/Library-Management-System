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


        Address.Text = "Address : Indian Institue of Technology , Guwahati"
        pincode.Text = "Pincode : 781039"
        Dim temp As String = Access.DBDT.Rows(0).Item(3)
        year.Text = "Year of Admission : 20" & temp.Substring(0, 2)

        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 39) & "\Resource\"
        'MessageBox.Show(fullPath)
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

   
End Class
