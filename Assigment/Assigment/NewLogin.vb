Imports System.IO

Public Class NewLogin

    Public CurUser As String = ""


    Dim BookLimit As Integer

    Private Access As New LMS

    Private Sub NewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        cmbStf.AllowDrop() = True
        cmbStf.Items.Clear()
        cmbStf.Items.Add("Faculty")
        cmbStf.Items.Add("Student")

        cmbDisc.AllowDrop() = True
        cmbDisc.Items.Clear()
        cmbDisc.Items.Add("B.Tech")
        cmbDisc.Items.Add("B.Des")
        cmbDisc.Items.Add("M.Tech")
        cmbDisc.Items.Add("MSc")
        cmbDisc.Items.Add("MA")
        cmbDisc.Items.Add("PhD")
        cmbDisc.Items.Add("PostDoc")
        cmbDisc.Items.Add("Other")

        cmbDept.AllowDrop() = True
        cmbDept.Items.Clear()
        cmbDept.Items.Add("CSE")
        cmbDept.Items.Add("MnC")
        cmbDept.Items.Add("ECE")
        cmbDept.Items.Add("EEE")
        cmbDept.Items.Add("ME")
        cmbDept.Items.Add("CL")
        cmbDept.Items.Add("CST")
        cmbDept.Items.Add("CE")
        cmbDept.Items.Add("EP")
        cmbDept.Items.Add("BT")
        cmbDept.Items.Add("HSS")
        cmbDept.Items.Add("Design")

        Dim StoredPath As String = "/bin/Debug/Resource"
        If File.Exists(StoredPath) Then
            profilePic.Image = Image.FromFile(StoredPath)
            profilePic.Refresh()
        End If

    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        txtName.Text = ""
    End Sub

    Private Sub txtRoll_Click(sender As Object, e As EventArgs) Handles txtRoll.Click
        txtRoll.Text = ""
    End Sub

    Private Sub txtMail_Click(sender As Object, e As EventArgs) Handles txtMail.Click
        txtMail.Text = ""
    End Sub

    Private Sub txtPass_Click(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.Text = ""
    End Sub

    Private Sub txtConf_Click(sender As Object, e As EventArgs) Handles txtConf.Click
        txtConf.Text = ""
    End Sub

    Private Sub cmbStf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStf.SelectedIndexChanged
        If cmbStf.SelectedItem = "Faculty" Then
            cmbDisc.Items.Clear()
            cmbDisc.Items.Add("Other")
            BookLimit = 7

        ElseIf cmbStf.SelectedItem = "Student" Then
            cmbDisc.Items.Clear()
            cmbDisc.Items.Add("B.Tech")
            cmbDisc.Items.Add("B.Des")
            cmbDisc.Items.Add("M.Tech")
            cmbDisc.Items.Add("MSc")
            cmbDisc.Items.Add("MA")
            cmbDisc.Items.Add("PhD")
            cmbDisc.Items.Add("PostDoc")
            BookLimit = 5
        End If
    End Sub

    Private Sub cmbDisc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDisc.SelectedIndexChanged
        If cmbDisc.SelectedItem = "B.Des" Then
            cmbDept.Items.Clear()
            cmbDept.Items.Add("Design")
        ElseIf cmbDisc.SelectedItem = "MA" Then
            cmbDept.Items.Clear()
            cmbDept.Items.Add("HSS")
        Else
            cmbDept.Items.Clear()
            cmbDept.Items.Add("CSE")
            cmbDept.Items.Add("MnC")
            cmbDept.Items.Add("ECE")
            cmbDept.Items.Add("EEE")
            cmbDept.Items.Add("ME")
            cmbDept.Items.Add("CL")
            cmbDept.Items.Add("CST")
            cmbDept.Items.Add("CE")
            cmbDept.Items.Add("EP")
            cmbDept.Items.Add("BT")
        End If
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click

        Access.ExecQuery("SELECT * FROM Users WHERE Username = '" & txtMail.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If txtName.Text = "" Or txtRoll.Text = "" Or txtPass.Text = "" Or txtConf.Text = "" Or txtMail.Text = "" Or cmbDept.SelectedItem = "" Or cmbDisc.SelectedItem = "" Or cmbStf.SelectedItem = "" Then
            MessageBox.Show("Please enter all fields!", "Error")
            Console.Write("Error: Field left empty")
            Exit Sub
        ElseIf Access.DBDT.Rows.Count <> 0 Then
            MessageBox.Show("Webmail already exists!", "Error")
            Console.Write("Error: Webmail already exists")
            Exit Sub
        ElseIf txtPass.Text <> txtConf.Text Then
            MessageBox.Show("Passwords do not match", "Error")
            Console.Write("Error: Passwords do not match")
            Exit Sub
        ElseIf IsNumeric(txtRoll) <> False Then
            MessageBox.Show("Roll number not numeric", "Error")
            Console.Write("Error: Roll number not numeric")
            Exit Sub
        End If
        AddUser()
        Form1.Panel4.Visible = True
        Form1.BringToFront()
        txtName.Text = ""
        txtRoll.Text = ""
        txtPass.Text = ""
        txtConf.Text = ""
        txtMail.Text = ""
    End Sub

    Private Sub AddUser()

        Dim tmp As String = "0"
        Dim insert As String = "Insert into Users (Username, Psswd, Roll_No, Title, Access, Program, Department, Book_Limit, Books_Issued) values ('" & txtMail.Text & "','" & txtPass.Text & "'," & txtRoll.Text & ",'" & txtName.Text & "','" & cmbStf.SelectedItem & "','" & cmbDisc.SelectedItem & "','" & cmbDept.SelectedItem & "'," & BookLimit & ",'" & tmp & "')"
        Access.ExecQuery(insert)
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        Access.ExecQuery("Select * from Users where Username = '" & txtMail.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
        If Access.DBDT.Rows.Count = 1 Then
            MessageBox.Show("User " & txtMail.Text & " successfully created")
            Console.WriteLine("User " & txtMail.Text & " successfully created")

            Access.ExecQuery("Select * From Users Where Username = '" & txtMail.Text & "'")
            If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
            If Access.DBDT.Rows.Count = 1 Then
                Log.CurID = Access.DBDT.Rows(0).Item(0)
                Log.CurUser = Access.DBDT.Rows(0).Item(1)
                Log.CurPass = Access.DBDT.Rows(0).Item(2)
                Log.CurRoll = Access.DBDT.Rows(0).Item(3)
                Log.CurName = Access.DBDT.Rows(0).Item(4)
                Log.CurAccess = Access.DBDT.Rows(0).Item(5)
                Log.CurProg = Access.DBDT.Rows(0).Item(6)
                Log.CurDept = Access.DBDT.Rows(0).Item(7)
                Log.CurBkLimit = Access.DBDT.Rows(0).Item(8)
                Log.CurBooks = Access.DBDT.Rows(0).Item(9)
            End If
            Form1.Label3.Text = "Welcome!  " & Log.CurUser
            Form1.Myprofile.Visible = True
            Form1.Myprofile.BringToFront()
            Form1.SidePanel.Height = Form1.MyAccount.Height
            Form1.SidePanel.Top = Form1.MyAccount.Top
            Form1.CurProfile.Visible = True
            Form1.CurProfile.BringToFront()
            Form1.Myprofile.Arrow.Height = Form1.Myprofile.btnmyprofile.Height
            Form1.Myprofile.Arrow.Top = Form1.Myprofile.btnmyprofile.Top + 12
            Form1.CurProfile.CurProfile_Load()
        Else
            Console.WriteLine("User " & txtMail.Text & " creation failed")
        End If

    End Sub

    'Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OFGSelectImage.FileOk
    '    OFGSelectImage.ShowDialog()
    '    profilePic.Image = Image.FromFile(OFGSelectImage.FileName)
    'End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles BtnView.Click
        'If OFGSelectImage.ShowDialog = DialogResult.OK Then
        '    profilePic.Image = Image.FromFile(OFGSelectImage.FileName)
        'End If

        If (Not System.IO.Directory.Exists("Resource")) Then
            System.IO.Directory.CreateDirectory("Resource")
        End If


        Dim OpenFileDialog1 As New OpenFileDialog
        With OpenFileDialog1
            .CheckFileExists = True
            .ShowReadOnly = False
            .Filter = "All Files|*.*|Bitmap Files|*.bmp|GIF Files|*.gif|JPG Files|*.jpg|JPEG Files|*.jpeg|PNG Files|*.png"
            .FilterIndex = 1

            '
            If .ShowDialog = DialogResult.OK Then
                Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
                fullPath = fullPath.Substring(0, fullPath.Length - 39) & "\Resource\"

                Dim FName() As String = OpenFileDialog1.FileName.Split("\\")
                'MessageBox.Show(FName())
                Dim ext() As String = FName(FName.Length - 1).Split(".")
                Dim extension As String = ext(ext.Length - 1)
                If extension <> "jpg" Or extension <> "jpeg" Or extension <> "png" Or extension <> "bmp" Or extension <> "gif" Then
                    Try
                        System.IO.File.Copy(OpenFileDialog1.FileName, fullPath + Form1.NewLogin.txtMail.Text + ".jpg")
                    Catch ex As Exception
                        MessageBox.Show("image can not be added")
                    End Try

                    profilePic.Image = Image.FromFile(.FileName)

                End If
            End If
        End With

    End Sub

    Private Sub NewLogin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.Click
        txtName.ForeColor = Color.Black
    End Sub

    Private Sub txtRoll_TextChanged(sender As Object, e As EventArgs) Handles txtRoll.Click
        txtRoll.ForeColor = Color.Black
    End Sub

    Private Sub txtMail_TextChanged(sender As Object, e As EventArgs) Handles txtMail.Click
        txtMail.ForeColor = Color.Black
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.ForeColor = Color.Black

    End Sub

    Private Sub txtConf_TextChanged(sender As Object, e As EventArgs) Handles txtConf.Click
        txtConf.ForeColor = Color.Black
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtPass.PasswordChar = Nothing
            txtConf.PasswordChar = Nothing
        Else
            txtPass.PasswordChar = "*"
            txtConf.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPass_TextChanged_1(sender As Object, e As EventArgs) Handles txtPass.Click
        txtPass.PasswordChar = "*"
    End Sub

    Private Sub txtConf_TextChanged_1(sender As Object, e As EventArgs) Handles txtConf.Click
        txtConf.PasswordChar = "*"
    End Sub
End Class