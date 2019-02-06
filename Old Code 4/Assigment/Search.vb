Public Class Search
    Dim cnt As Integer = 0

    Private Access As New LMS
    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSrch1.Hide()
        cbxSrch.AllowDrop() = True
        cbxSrch.Items.Add("Title")
        cbxSrch.Items.Add("ISBN")
        cbxSrch.Items.Add("Author")
        cbxSrch.Items.Add("Genre")
        cbxSrch.Items.Add("Publisher")

        'Run query
        Access.ExecQuery("SELECT * FROM Book")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        ''Fill Datagrid
        dgvSrch.DataSource = Access.DBDT

        'Display first name found
        If Access.RecordCount > 0 Then cbxSrch.SelectedIndex = 0
    End Sub

    Private Sub cbxSrch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSrch.SelectedIndexChanged
        Dim srchPattern As String

        srchPattern = cbxSrch.SelectedItem


    End Sub


    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Clr()
        lblSrch1.Show()


        If cbxSrch.SelectedItem = "Title" Then
            Access.ExecQuery("SELECT * from Book WHERE Title LIKE '%" & txtSrch.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If cbxSrch.SelectedItem = "ISBN" Then
            Access.ExecQuery("SELECT * from Book WHERE ISBN = '" & txtSrch.Text & "'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If cbxSrch.SelectedItem = "Genre" Then
            Access.ExecQuery("SELECT * from Book WHERE Genre LIKE '%" & txtSrch.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If cbxSrch.SelectedItem = "Author" Then
            Access.ExecQuery("SELECT * from Book WHERE Authors LIKE '%" & txtSrch.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If
        If cbxSrch.SelectedItem = "Publisher" Then
            Access.ExecQuery("SELECT * from Book WHERE Publisher LIKE '%" & txtSrch.Text & "%'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        End If

        'MessageBox.Show(Access.DBDT.Rows.Count)
        If Access.DBDT.Rows.Count = 0 Then
            Dim Op1 As String = "Sorry: No results match your search"
            lblSrch1.Text = Op1
            Exit Sub
        End If

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
                lblSrch1.Font = New Font("Century Gothic", 7)
                lblSrch1.Text = Op1
            Else
                DynamicLabel(cnt, Op1)
            End If
        Next

        dgvSrch.DataSource = Access.DBDT
    End Sub

    Private Sub DynamicLabel(i As Integer, txt As String)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lblSrch" & CStr(i)
        Dim yt As Integer = lblSrch1.Location.Y + 120 * (i - 1)
        Dim lbl1 As New Label
        lbl1.Font = New Font("Century Gothic", 7)
        lbl1.Name = lblName
        lbl1.Text = txt
        lbl1.AutoSize = True
        'lbl1.Height = lblSrch1.Hseight
        'lbl1.Width = lblSrch1.Width
        lbl1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        lbl1.BackColor = Color.White
        lbl1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(lbl1)
        lbl1.Location = New Point(lblSrch1.Location.X, yt)

    End Sub

    Private Sub Clr()
        lblSrch1.Text = ""
        For i As Integer = 2 To cnt
            Me.Controls.Remove(Me.Controls.Find("lblSrch" & CStr(i), True)(0))
        Next
        cnt = 0
    End Sub

End Class
