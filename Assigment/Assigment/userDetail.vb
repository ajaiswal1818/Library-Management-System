Imports System.IO
Public Class userDetail
    Dim count As Integer = 0

    Private Access As New LMS

    Private Sub Usearch_Click(sender As Object, e As EventArgs) Handles Usearch.Click
        Clear()   'will clear all the previously generated book labbels


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

        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)

        fullPath = fullPath.Substring(0, fullPath.Length - 39) & "\Assigment\bin\Debug\Resource\"

        Dim Path As String = fullPath & Udetail.Text & ".jpg"
     
        If File.Exists(Path) Then
            displayPic.ImageLocation = (Path)
            displayPic.Load()
        End If

        Refresh_Page()

    End Sub

    Private Sub Clear()
        lblissue.Text = ""
        For i As Integer = 2 To count
            Me.Controls.Remove(Me.Controls.Find("lblissue" & CStr(i), True)(0))
        Next
        count = 0
        lblissue.Hide()
    End Sub


    Private Sub Refresh_Page()
        Dim count As Integer = 0

        lblissue.Show()

        Access.ExecQuery("SELECT * from Users WHERE Username LIKE '%" & Udetail.Text & "%'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Dim checkString As String = ""
        For Each R As DataRow In Access.DBDT.Rows
            checkString &= R.Item(9)
        Next
        Dim array As String() = Split(checkString, "-")
        Dim bkno As Integer = 0
        For Each temp As String In array
            If IsNumeric(temp) = False Then
                Continue For
            End If

            Access.ExecQuery("SELECT * from Book WHERE [ID]=" & CInt(temp))
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            If Access.DBDT.Rows.Count <> 0 Then
                bkno = 1
            End If
            For Each R As DataRow In Access.DBDT.Rows
                count += 1
                Dim checktemp As String = ""
                'checktemp &= R.Item(0)
                checktemp &= "Book Name: " & R.Item(1) & Environment.NewLine
                checktemp &= "Authors: " & R.Item(3) & Environment.NewLine
                checktemp &= "Genre: " & R.Item(6) & Environment.NewLine
                checktemp &= "Publisher: " & R.Item(7) & Environment.NewLine
                checktemp &= "ISBN: " & R.Item(2) & Environment.NewLine
                checktemp &= "Copies Available: " & R.Item(4) & Environment.NewLine

                If count = 1 Then
                    lblissue.Font = New Font("Century Gothic", 7)
                    lblissue.Text = checktemp
                Else
                    DynamicBook(count, checktemp, R)
                End If
            Next
        Next

        'MessageBox.Show(bkno)

        If bkno = 0 Then
            lblissue.Hide()

        End If
    End Sub

    Private Sub DynamicBook(i As Integer, txt As String, R As DataRow)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblissue" & CStr(i)
        Dim yt As Integer = lblissue.Location.Y + 120 * (i - 1)
        Dim lbl1 As New Label
        lbl1.Font = New Font("Century Gothic", 7)
        lbl1.Name = lblName
        lbl1.Text = txt
        lbl1.AutoSize = True
        lbl1.Anchor = AnchorStyles.Top
        ' lbl1.Anchor = AnchorStyles.Left
        'lbl1.Height = lblissue1.Hseight
        'lbl1.Width = lblissue1.Width
        lbl1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        lbl1.BackColor = Color.White
        lbl1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(lbl1)
        lbl1.Location = New Point(lblissue.Location.X, yt)

    End Sub

    Private Sub userDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear()
    End Sub

End Class
