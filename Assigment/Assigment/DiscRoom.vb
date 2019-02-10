Public Class DiscRoom

    Private Access As New LMS

    Private Sub DiscRoom_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

    End Sub

    Private Sub DiscRoom_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'btn0_0.Font = New Font("Century Gothic", 9)

        'My.Computer.FileSystem.WriteAllText("Resource\\RoomLastAccess.txt", "This is new text to be added.", False)
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText("Resource\\RoomLastAccess.txt")
        Dim thisDate As Date
        thisDate = Today
        If CStr(thisDate) <> CStr(fileReader) Then
            Access.ExecQuery("Update Room Set 0=0, 1=0, 2=0, 3=0, 4=0, 5=0, 6=0, 7=0")
        End If

        Access.ExecQuery("SELECT * from Room")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        Dim avail(4, 8) As Integer
        Dim ii As Integer = 0
        For Each R As DataRow In Access.DBDT.Rows
            For j As Integer = 0 To 7
                avail(ii, j) = R.Item(j + 1)
            Next
            ii += 1
        Next


        For i As Integer = 0 To 3
            For j As Integer = 0 To 7
                Dim nm As String = "0"
                If avail(i, j) = 0 Then
                    If i = 0 And j = 0 Then
                        'btn0_0.Enabled = True
                        Continue For
                    End If
                Else
                    Access.ExecQuery("Select [Title] From Users Where [ID] =" & avail(i, j))
                    If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
                    If Access.DBDT.Rows.Count = 1 Then
                        nm = Access.DBDT.Rows(0).Item(0)
                        If i = 0 And j = 0 Then
                            'btn0_0.Enabled = False
                            btn0_0.BackColor = Color.Blue
                            btn0_0.ForeColor = Color.White
                            btn0_0.Text = nm
                        Else

                        End If
                    End If

                End If
                DynamicButton(i, j, nm)
            Next
        Next

        My.Computer.FileSystem.WriteAllText("Resource\\RoomLastAccess.txt", thisDate, False)

    End Sub

    Private Sub DynamicButton(i As Integer, j As Integer, nm As String)
        Dim btnName As String
        btnName = "btn" & CStr(i) & "_" & CStr(j)
        Dim btn1 As New Button
        btn1.Font = btn0_0.Font
        If nm = "0" Then
            btn1.ForeColor = Color.Blue
            btn1.BackColor = Color.White
            btn1.Text = "Book Me!"
        Else
            btn1.ForeColor = Color.White
            btn1.BackColor = Color.Blue
            btn1.Text = nm
        End If
        btn1.FlatStyle = FlatStyle.Popup
        btn1.FlatAppearance.BorderSize = 0.5
        btn1.Name = btnName
        btn1.Height = btn0_0.Height
        btn1.Width = btn0_0.Width
        Me.Controls.Add(btn1)
        btn1.Location = New Point(btn0_0.Location.X + i * btn0_0.Width, btn0_0.Location.Y + j * btn0_0.Height)
        AddHandler btn1.Click, AddressOf Me.Button_Click

        'Dim lblName As String
        'lblName = "lbl" & CStr(i) & "_" & CStr(j)
        'Dim lbl1 As New Label
        'lbl1.Name = lblName
        'lbl1.Text = i & " " & j
        'lbl1.Hide()
        'Me.Controls.Add(lbl1)
    End Sub

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Button = sender
        If selectedBtn.BackColor = Color.White Then
            If Log.CurUser = "" Then
                MessageBox.Show("You must be logged in to book a room!", "Error")
                Console.Write("Failed room booking: User not logged in" & Environment.NewLine)
                Exit Sub
            End If
            Dim ans As String() = Split(selectedBtn.Name.Substring(3), "_")
            '(Me.Controls.Find(send), True)(0)
            'Dim send As Array = Split

            Access.ExecQuery("Update Room Set " & CStr(ans(1)) & "=" & Log.CurID & " where Room_no=" & (ans(0) + 1))
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            MessageBox.Show("Room successfully booked!", "Success")
            Console.Write("User " & Log.CurName & " booked a room")

        End If
    End Sub

End Class