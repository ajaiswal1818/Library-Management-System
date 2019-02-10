Public Class reco

    Dim cnt As Integer = 0

    Private Access As New LMS

    Private Sub Search_Visible(sender As Object, e As EventArgs) Handles MyBase.Load
        show_rec()

    End Sub

    Private Sub show_rec()

        btn_del1.Hide()
        AddHandler btn_del1.Click, AddressOf Me.Button_Click
        Clr()
        lbl_rec1.Show()

        'Run query
        Access.ExecQuery("SELECT * FROM Rec")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        'Fill Datagrid
        rec_table.DataSource = Access.DBDT

        If Access.DBDT.Rows.Count = 0 Then
            Dim Op1 As String = "Sorry: No results match your search"
            lbl_rec1.Text = Op1
            Exit Sub
        End If

        btn_del1.Show()
        For Each R As DataRow In Access.DBDT.Rows
            cnt += 1
            Dim Op1 As String = ""
            Op1 &= "Book Name: " & R.Item(2) & Environment.NewLine
            Op1 &= "Author: " & R.Item(3) & Environment.NewLine
            Op1 &= "ISBN: " & R.Item(1) & Environment.NewLine

            If cnt = 1 Then
                lbl_rec1.Font = New Font("Century Gothic", 7)
                btn_del1.Font = New Font("Century Gothic", 7)
                btn_del1.DialogResult = R.Item(0)
                lbl_rec1.Text = Op1
            Else
                DynamicLabel(cnt, Op1, R)
            End If
        Next


    End Sub



    Private Sub DynamicLabel(i As Integer, txt As String, R As DataRow)
        'MessageBox.Show("Hello")
        Dim lblName As String
        lblName = "lbl_rec" & CStr(i)
        Dim yt As Integer = lbl_rec1.Location.Y + 120 * (i - 1)
        Dim lbl1 As New Label
        lbl1.Font = New Font("Century Gothic", 7)
        lbl1.Name = lblName
        lbl1.Text = txt
        lbl1.AutoSize = True
        lbl1.BorderStyle = Windows.Forms.BorderStyle.Fixed3D
        lbl1.BackColor = Color.White
        lbl1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(lbl1)
        lbl1.Location = New Point(lbl_rec1.Location.X, yt)

        Dim btnName As String
        btnName = "btn_del" & CStr(i)
        Dim yb As Integer = btn_del1.Location.Y + 120 * (i - 1)
        Dim btn1 As New Button
        btn1.Font = New Font("Century Gothic", 7)
        btn1.Name = btnName
        btn1.Text = "delete rec"
        btn1.Height = btn_del1.Height
        btn1.Width = btn_del1.Width
        'btn1.Margin = New Padding(10, 10, 10, 10)
        Me.Controls.Add(btn1)
        btn1.Location = New Point(btn_del1.Location.X, yb)
        btn1.DialogResult = R.Item(0)
        AddHandler btn1.Click, AddressOf Me.Button_Click

    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender

        Dim IDFind As Integer = CInt(selectedBtn.DialogResult)
        Access.ExecQuery("SELECT * FROM Rec where [ID] = " & IDFind)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 0 Or Access.DBDT.Rows.Count > 1 Then
            MessageBox.Show("Recommendation not found", "Error")
            Console.WriteLine("Recommendation not found")
            Exit Sub
        End If

        Access.ExecQuery("delete * from Rec where [ID]=" & IDFind)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        MessageBox.Show("Book recommendation deleted")
        Console.Write("Book recommendation deleted")
    End Sub

    Private Sub Clr()
        lbl_rec1.Text = ""
        For i As Integer = 2 To cnt
            Me.Controls.Remove(Me.Controls.Find("lbl_rec" & CStr(i), True)(0))
            Me.Controls.Remove(Me.Controls.Find("btn_del" & CStr(i), True)(0))
        Next
        cnt = 0
    End Sub

End Class
