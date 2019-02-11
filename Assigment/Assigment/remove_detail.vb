Public Class remove_detail
    Public Shared cnt_rem As Integer = 0
    Public Shared cnt_del As Integer = 0
    Public Shared cnt_lbl As Integer = 0
    Public Shared check_btn As Integer = -1
    Private Access As New LMS

    Public Sub Refr()
        lblSrch1.Hide()
        btnSrch1.Hide()
        btnDel1.Hide()

        Srchcbx.AllowDrop() = True
        Srchcbx.Items.Add("Title")
        Srchcbx.Items.Add("ISBN")
        Srchcbx.Items.Add("Author")
        Srchcbx.Items.Add("Genre")
        Srchcbx.Items.Add("Publisher")

        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub


        If Access.RecordCount > 0 Then Srchcbx.SelectedIndex = 0
    End Sub

    Private Sub btnSearch_Click() Handles btnSearch.Click                                                              'CHANGE...................
        'MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)
        lblSrch1.Show()

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
            lblSrch1.Text = Op1
            btnSrch1.Hide()
            Exit Sub
        End If

        If check_btn = 0 Then
            If cnt_del <> 0 Then
                Clr_Del()
            End If
            Clr_Rem()
            Clr_lbl()
            draw_remove_btn()
        ElseIf check_btn = 1 Then
            Clr_Del()
            Clr_lbl()
            If cnt_rem <> 0 Then
                Clr_Rem()
            End If
            draw_detail_btn()
        End If



    End Sub

    Private Sub draw_remove_btn()

        btnSrch1.Show()
        For Each R As DataRow In Access.DBDT.Rows
            cnt_rem += 1
            cnt_lbl += 1
            Dim Op1 As String = ""
            Op1 &= "Book Name: " & R.Item(1) & Environment.NewLine
            Op1 &= "Authors: " & R.Item(3) & Environment.NewLine
            Op1 &= "Genre: " & R.Item(6) & Environment.NewLine
            Op1 &= "Publisher: " & R.Item(7) & Environment.NewLine
            Op1 &= "ISBN: " & R.Item(2) & Environment.NewLine
            Op1 &= "Copies Available: " & R.Item(4) & Environment.NewLine

            If cnt_rem = 1 Then
                lblSrch1.Font = New Font("Century Gothic", 7)
                btnSrch1.Font = New Font("Century Gothic", 7)
                'btnSrch1.DialogResult = R.Item(0)
                lblSrch1.Text = Op1
                lbltemp1.Text = R.Item(0)
                AddHandler btnSrch1.Click, AddressOf Me.Button_Click
            Else
                DynamicLabel1(cnt_rem, Op1, R)
            End If
        Next
    End Sub

    Private Sub draw_detail_btn()

        btnDel1.Show()
        For Each R As DataRow In Access.DBDT.Rows
            cnt_del += 1
            cnt_lbl += 1
            Dim Op1 As String = ""
            Op1 &= "Book Name: " & R.Item(1) & Environment.NewLine
            Op1 &= "Authors: " & R.Item(3) & Environment.NewLine
            Op1 &= "Genre: " & R.Item(6) & Environment.NewLine
            Op1 &= "Publisher: " & R.Item(7) & Environment.NewLine
            Op1 &= "ISBN: " & R.Item(2) & Environment.NewLine
            Op1 &= "Copies Available: " & R.Item(4) & Environment.NewLine

            If cnt_del = 1 Then
                lblSrch1.Font = New Font("Century Gothic", 7)
                btnDel1.Font = New Font("Century Gothic", 7)
                'btnDel1.DialogResult = R.Item(0)
                lblSrch1.Text = Op1
                lbltemp1.Text = R.Item(0)
                AddHandler btnDel1.Click, AddressOf Me.Button_Click2
            Else
                DynamicLabel2(cnt_del, Op1, R)
            End If
        Next
    End Sub


    Private Sub DynamicLabel1(i As Integer, txt As String, R As DataRow)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblSrch" & CStr(i)
        Dim yt As Integer = lblSrch1.Location.Y + 120 * (i - 1)
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
        lbl1.Location = New Point(lblSrch1.Location.X, yt)

        Dim btnName As String
        btnName = "btnSrch" & CStr(i)
        Dim yb As Integer = btnSrch1.Location.Y + 120 * (i - 1)
        Dim btn1 As New Button
        btn1.Font = New Font("Century Gothic", 7)
        btn1.Name = btnName
        btn1.Text = "Remove"
        btn1.Height = btnSrch1.Height
        btn1.Width = btnSrch1.Width
        'btn1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(btn1)
        btn1.Location = New Point(btnSrch1.Location.X, yb)
        'btn1.DialogResult = R.Item(0)
        AddHandler btn1.Click, AddressOf Me.Button_Click

        Dim tempName As String
        Dim temp1 As New Label
        tempName = "lbltemp" & CStr(i)
        temp1.Name = tempName
        temp1.Text = R.Item(0)
        'MessageBox.Show(temp1.Text)
        Me.Controls.Add(temp1)
        temp1.Hide()

    End Sub

    Private Sub DynamicLabel2(i As Integer, txt As String, R As DataRow)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblSrch" & CStr(i)
        Dim yt As Integer = lblSrch1.Location.Y + 120 * (i - 1)
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
        lbl1.Location = New Point(lblSrch1.Location.X, yt)

        Dim btnName As String
        btnName = "btnDel" & CStr(i)
        Dim yb As Integer = btnDel1.Location.Y + 120 * (i - 1)
        Dim btn1 As New Button
        btn1.Font = New Font("Century Gothic", 7)
        btn1.Name = btnName
        btn1.Text = "Details"
        btn1.Height = btnDel1.Height
        btn1.Width = btnDel1.Width
        'btn1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(btn1)
        btn1.Location = New Point(btnDel1.Location.X, yb)
        'btn1.DialogResult = R.Item(0)
        AddHandler btn1.Click, AddressOf Me.Button_Click2

        Dim tempName As String
        Dim temp1 As New Label
        tempName = "lbltemp" & CStr(i)
        temp1.Name = tempName
        temp1.Text = R.Item(0)
        'MessageBox.Show(temp1.Text)
        Me.Controls.Add(temp1)
        temp1.Hide()

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender


        ''Dim IDFind As Integer = CInt(selectedBtn.DialogResult)
        Dim tmp As Label = Me.Controls.Find("lbltemp" & selectedBtn.Name.Substring(7), True)(0)
        'MessageBox.Show(tmp.Text)
        Dim IDFind As Integer = CInt(tmp.Text)
        Access.ExecQuery("SELECT * FROM Book where [ID] = " & IDFind)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Dim BkName As String = Access.DBDT.Rows(0).Item(1)
        Dim BkIss As String = Access.DBDT.Rows(0).Item(5)
        If BkIss.Length = 1 Then
            Access.ExecQuery("DELETE * FROM Book where [ID] = " & IDFind)
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            MessageBox.Show(BkName & " deleted!")
        Else
            Access.ExecQuery("Update Book set Copies_Available = 0 where [ID] = " & IDFind)
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            MessageBox.Show(BkName & " available copies set to 0!")
        End If

        Clr_Rem()
        Clr_lbl()
        If cnt_del <> 0 Then
            Clr_Del()
        End If
        btnSearch_Click()

    End Sub


    Private Sub Button_Click2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender

        Dim tmp As Label = Me.Controls.Find("lbltemp" & selectedBtn.Name.Substring(6), True)(0)
        'MessageBox.Show(tmp.Text)
        Dim IDFind As Integer = CInt(tmp.Text)

        Access.ExecQuery("SELECT * FROM Book where [ID] = " & IDFind)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Dim BkIss As String = Access.DBDT.Rows(0).Item(5)


        Form1.Book_details.BringToFront()
        Form1.Book_details.Visible = True

        Dim R As DataRow = Access.DBDT.Rows(0)
        Dim Op1 As String = ""
        Op1 &= "Book Name: " & R.Item(1) & Environment.NewLine
        Op1 &= "Authors: " & R.Item(3) & Environment.NewLine
        Op1 &= "Genre: " & R.Item(6) & Environment.NewLine
        Op1 &= "Publisher: " & R.Item(7) & Environment.NewLine
        Op1 &= "ISBN: " & R.Item(2) & Environment.NewLine
        Op1 &= "Copies Available: " & R.Item(4) & Environment.NewLine

        Form1.Book_details.load_content(Op1, BkIss)

        Clr_Del()
        Clr_lbl()
        If cnt_del <> 0 Then
            Clr_Rem()
        End If
        btnSearch_Click()

    End Sub

    Public Sub Clr_Rem()
        'MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)
        RemoveHandler btnSrch1.Click, AddressOf Me.Button_Click
        lblSrch1.Text = ""
        lbltemp1.Text = ""
        For i As Integer = 2 To cnt_rem
            ''Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
            RemoveHandler Me.Controls.Find("btnSrch" & CStr(i), True)(0).Click, AddressOf Me.Button_Click
            Me.Controls.Remove(Me.Controls.Find("btnSrch" & CStr(i), True)(0))

        Next
        cnt_rem = 0
    End Sub

    Public Sub Clr_Del()
        'MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)
        lblSrch1.Text = ""
        lbltemp1.Text = ""
        RemoveHandler btnDel1.Click, AddressOf Me.Button_Click
        For i As Integer = 2 To cnt_del
            ''Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
            RemoveHandler Me.Controls.Find("btnDel" & CStr(i), True)(0).Click, AddressOf Me.Button_Click
            Me.Controls.Remove(Me.Controls.Find("btnDel" & CStr(i), True)(0))
        Next
        cnt_del = 0
    End Sub

    Public Sub Clr_lbl()
        MessageBox.Show("cnt_lbl: " & remove_detail.cnt_lbl & "\ncnt_rem: " & remove_detail.cnt_rem & "\ncnt_del: " & remove_detail.cnt_del)
        lblSrch1.Text = ""
        lbltemp1.Text = ""
        For i As Integer = 2 To cnt_lbl
            Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("lbltemp" & CStr(i), True)(0))

        Next
        cnt_lbl = 0
    End Sub


    'Private Sub details_Click(sender As Object, e As EventArgs) Handles btnDel1.Click
    '    Form1.Book_details.Visible = True
    '    Form1.Book_details.BringToFront()
    'End Sub

    
    Private Sub remove_detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
