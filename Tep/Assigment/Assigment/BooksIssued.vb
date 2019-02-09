Public Class BooksIssued

    Dim cnt As Integer = 0

    Private Access As New LMS


    Private Sub BooksIssued_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cnt As Integer = 0

        Clr()
        lblissue1.Show()

        Access.ExecQuery("SELECT * from User WHERE ID LIKE '%" & Log.CurId & "%'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        'Access.ExecQuery("SELECT * from User WHERE ISBN = '" & txtSrch.Text & "'")
        'If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        'Access.ExecQuery("SELECT * from User WHERE Genre LIKE '%" & txtSrch.Text & "%'")
        'If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        'Access.ExecQuery("SELECT * from User WHERE Authors LIKE '%" & txtSrch.Text & "%'")
        'If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Access.ExecQuery("SELECT * from User WHERE Publisher LIKE '%" & txtSrch.Text & "%'")
        '    If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ''MessageBox.Show(Access.DBDT.Rows.Count)
        'If Access.DBDT.Rows.Count = 0 Then
        '    Dim checkString As String = "Sorry: No results match your search"
        '    BooksIssued.checklbl.Text = checkString
        '    Exit Sub
        'End If
        Dim checkString As String = ""
        For Each R As DataRow In Access.DBDT.Rows
            'cnt += 1
            checkString &= R.Item(10)    '  checkString contain id of all the issued books
            'checkString &= "Authors: " & R.Item(3) & Environment.NewLine
            'checkString &= "Genre: " & R.Item(6) & Environment.NewLine
            'checkString &= "Publisher: " & R.Item(7) & Environment.NewLine
            'checkString &= "ISBN: " & R.Item(2) & Environment.NewLine
            'checkString &= "Copies Available: " & R.Item(4) & Environment.NewLine

            'If cnt = 1 Then
            '    lblissue1.Font = New Font("Century Gothic", 7)
            '    lblissue1.Text = checkString
            'Else
            '    DynamicLabel(cnt, checkString)
            'End If
        Next
        Dim array As String() = Split(checkString, " ")
        'Dim Query = New String() {Split(checkString, " ")}

        'Dim temp As String
        For Each temp As String In array
            Access.ExecQuery("SELECT * from Book WHERE ID LIKE '%" & temp & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

            For Each R As DataRow In Access.DBDT.Rows
                cnt += 1
                Dim checktemp As String = ""
                checktemp &= R.Item(10)
                checktemp &= "Authors: " & R.Item(3) & Environment.NewLine
                checktemp &= "Genre: " & R.Item(6) & Environment.NewLine
                checktemp &= "Publisher: " & R.Item(7) & Environment.NewLine
                checktemp &= "ISBN: " & R.Item(2) & Environment.NewLine
                checktemp &= "Copies Available: " & R.Item(4) & Environment.NewLine

                If cnt = 1 Then
                    lblissue1.Font = New Font("Century Gothic", 7)
                    lblissue1.Text = checktemp
                Else
                    DynamicLabel(cnt, checktemp)
                End If
            Next
        Next


    End Sub



    Private Sub DynamicLabel(i As Integer, txt As String)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblSrch" & CStr(i)
        Dim yt As Integer = lblissue1.Location.Y + 120 * (i - 1)
        Dim lbl1 As New Label
        lbl1.Font = New Font("Century Gothic", 7)
        lbl1.Name = lblName
        lbl1.Text = txt
        lbl1.AutoSize = True
        'lbl1.Height = lblissue1.Hseight
        'lbl1.Width = lblissue1.Width
        lbl1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        lbl1.BackColor = Color.White
        lbl1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(lbl1)
        lbl1.Location = New Point(lblissue1.Location.X, yt)

    End Sub

    Private Sub Clr()
        lblissue1.Text = ""
        For i As Integer = 2 To cnt
            Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
        Next
        cnt = 0
    End Sub


End Class
