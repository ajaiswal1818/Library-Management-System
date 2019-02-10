'Public Class remove_detail


'    Private Sub remove_detail_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

'    End Sub

'    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

'    End Sub
'End Class
Public Class remove_detail
    Dim cnt As Integer = 0

    Private Access As New LMS

    Private Sub Refr()
        lblSrch2.Hide()
        removeBtn.Hide()
        AddHandler removeBtn.Click, AddressOf Me.Button_Click

        Srchcbx.AllowDrop() = True
        Srchcbx.Items.Add("Title")
        Srchcbx.Items.Add("ISBN")
        Srchcbx.Items.Add("Author")
        Srchcbx.Items.Add("Genre")
        Srchcbx.Items.Add("Publisher")

        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ''Fill Datagrid
        'dgvSrch.DataSource = Access.DBDT

        'Display first name found
        If Access.RecordCount > 0 Then Srchcbx.SelectedIndex = 0
    End Sub

    Private Sub Search_Visible(sender As Object, e As EventArgs) Handles MyBase.Load
        Clr()
        Refr()
    End Sub

    Private Sub Srchcbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Srchcbx.SelectedIndexChanged
        Dim srchPattern As String
        srchPattern = Srchcbx.SelectedItem
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Clr()
        lblSrch2.Show()

        If Srchcbx.SelectedItem = "Title" Then
            Access.ExecQuery("SELECT * from Book WHERE Title LIKE '%" & srchTxt.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If Srchcbx.SelectedItem = "ISBN" Then
            Access.ExecQuery("SELECT * from Book WHERE ISBN = '" & srchTxt.Text & "'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If Srchcbx.SelectedItem = "Genre" Then
            Access.ExecQuery("SELECT * from Book WHERE Genre LIKE '%" & srchTxt.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If Srchcbx.SelectedItem = "Author" Then
            Access.ExecQuery("SELECT * from Book WHERE Authors LIKE '%" & srchTxt.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If Srchcbx.SelectedItem = "Publisher" Then
            Access.ExecQuery("SELECT * from Book WHERE Publisher LIKE '%" & srchTxt.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If

        'MessageBox.Show(Access.DBDT.Rows.Count)
        If Access.DBDT.Rows.Count = 0 Then
            Dim Op1 As String = "Sorry: No results match your search"
            lblSrch2.Text = Op1
            removeBtn.Hide()
            Exit Sub
        End If

        removeBtn.Show()
        For Each R As DataRow In Access.DBDT.Rows
            cnt += 1
            Dim Op1 As String = ""
            Op1 &= "Book Name: " & R.Item(1) & Environment.NewLine
            Op1 &= "Authors: " & R.Item(3) & Environment.NewLine
            Op1 &= "Genre: " & R.Item(6) & Environment.NewLine
            Op1 &= "Publisher: " & R.Item(7) & Environment.NewLine
            Op1 &= "ISBN: " & R.Item(2) & Environment.NewLine
            Op1 &= "Copies Available: " & R.Item(4) & Environment.NewLine

            If cnt = 1 Then
                lblSrch2.Font = New Font("Century Gothic", 7)
                removeBtn.Font = New Font("Century Gothic", 7)
                removeBtn.DialogResult = R.Item(0)
                lblSrch2.Text = Op1
            Else
                DynamicLabel1(cnt, Op1, R)
            End If
        Next

    End Sub

    Private Sub DynamicLabel1(i As Integer, txt As String, R As DataRow)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblSrch" & CStr(i)
        Dim yt As Integer = lblSrch2.Location.Y + 120 * (i - 1)
        Dim lbl1 As New Label
        lbl1.Font = New Font("Century Gothic", 7)
        lbl1.Name = lblName
        lbl1.Text = txt
        lbl1.AutoSize = True
        'lbl1.Height = lblSrch2.Hseight
        'lbl1.Width = lblSrch2.Width
        lbl1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        lbl1.BackColor = Color.White
        lbl1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(lbl1)
        lbl1.Location = New Point(lblSrch2.Location.X, yt)

        Dim btnName As String
        btnName = "btnSrch" & CStr(i)
        Dim yb As Integer = removeBtn.Location.Y + 120 * (i - 1)
        Dim btn1 As New Button
        btn1.Font = New Font("Century Gothic", 7)
        btn1.Name = btnName
        btn1.Text = "Remove"
        btn1.Height = removeBtn.Height
        btn1.Width = removeBtn.Width
        'btn1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(btn1)
        btn1.Location = New Point(removeBtn.Location.X, yb)
        btn1.DialogResult = R.Item(0)
        AddHandler btn1.Click, AddressOf Me.Button_Click

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender
        'MessageBox.Show("you have clicked button " & selectedBtn.DialogResult)

        'If Log.CurUser = "" Then
        '    MessageBox.Show("You are currently not logged in! Please log in to issue books!", "Error")
        '    Console.WriteLine("Error in Issuing: Not logged in")
        '    Exit Sub
        'End If

        'If Log.CurBkLimit <= 0 Then
        '    MessageBox.Show("You cannot issue any more books!", "Error")
        '    Console.WriteLine("User book limit reached")
        '    Exit Sub
        'End If

        'MessageBox.Show(selectedBtn.DialogResult)

        Dim IDFind As Integer = CInt(selectedBtn.DialogResult)
        Access.ExecQuery("SELECT * FROM Book where [ID] = " & IDFind)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 0 Or Access.DBDT.Rows.Count > 1 Then
            MessageBox.Show("Book to be issued not found", "Error")
            Console.WriteLine("Book to be issued not found")
            Exit Sub
        End If
        If Access.DBDT.Rows(0).Item(4) <= 0 Then
            MessageBox.Show("All book copies issued", "Error")
            Console.WriteLine("All book copies issued")
            Exit Sub
        End If
        Dim BkName As String = Access.DBDT.Rows(0).Item(1)
        Dim BkID As Integer = Access.DBDT.Rows(0).Item(0)
        Dim BkCnt As Integer = Access.DBDT.Rows(0).Item(4) - 1
        Dim BkIss As String = Access.DBDT.Rows(0).Item(5)
        BkIss &= "-" & CStr(Log.CurID)


        Access.ExecQuery("Update Book set Copies_Available=" & BkCnt & ", Issued_to='" & BkIss & "' where [ID]=" & BkID)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        Log.CurBkLimit -= 1
        Log.CurBooks &= "-" & CStr(BkID)
        Try
            Access.ExecQuery("Update Users set Book_Limit=" & Log.CurBkLimit & ", Books_Issued='" & Log.CurBooks & "' where [ID]=" & Log.CurID)
        Catch ex As Exception
            MessageBox.Show("Error", "Error")
        End Try

        MessageBox.Show("Book " & BkName & " issued")
        Console.Write("Book " & BkName & " issued")
        'Clr()
    End Sub

    Private Sub Clr()
        lblSrch2.Text = ""
        For i As Integer = 2 To cnt
            Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("btnSrch" & CStr(i), True)(0))
        Next
        cnt = 0
    End Sub

End Class
