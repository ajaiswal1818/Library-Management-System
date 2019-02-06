Public Class NewLogin

    Private Access As New LMS

    Private Sub NewLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStf.AllowDrop() = True
        cmbStf.Items.Add("Faculty")
        cmbStf.Items.Add("Student")

        cmbDisc.AllowDrop() = True
        cmbDisc.Items.Add("B.Tech")
        cmbDisc.Items.Add("B.Des")
        cmbDisc.Items.Add("M.Tech")
        cmbDisc.Items.Add("MSc")
        cmbDisc.Items.Add("MA")
        cmbDisc.Items.Add("PhD")
        cmbDisc.Items.Add("PostDoc")
        cmbDisc.Items.Add("Staff")

        cmbDept.AllowDrop() = True
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
            cmbDisc.Items.Add("Staff")
        ElseIf cmbStf.SelectedItem = "Student" Then
            cmbDisc.Items.Clear()
            cmbDisc.Items.Add("B.Tech")
            cmbDisc.Items.Add("B.Des")
            cmbDisc.Items.Add("M.Tech")
            cmbDisc.Items.Add("MSc")
            cmbDisc.Items.Add("MA")
            cmbDisc.Items.Add("PhD")
            cmbDisc.Items.Add("PostDoc")
        End If
    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click

        Access.ExecQuery("SELECT * FROM Users WHERE Username = '" & txtMail.Text & "'")
        If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub

        If txtName.Text = "" Or txtRoll.Text = "" Or txtPass.Text = "" Or txtConf.Text = "" Or txtMail.Text = "" Or cmbDept.SelectedItem = "" Or cmbDisc.SelectedItem = "" Or cmbStf.SelectedItem = "" Then
            MessageBox.Show("Please enter all fields!", "Error")
            Console.Write("Error: Field left empty")
        ElseIf Access.DBDT.Rows.Count <> 0 Then
            MessageBox.Show("Webmail already exists!", "Error")
            Console.Write("Error: Webmail already exists")
        ElseIf txtPass.Text <> txtConf.Text Then
            MessageBox.Show("Passwords do not match", "Error")
            Console.Write("Error: Passwords do not match")
        ElseIf IsNumeric(txtRoll) = False Then
            MessageBox.Show("Roll number not numeric", "Error")
            Console.Write("Error: Roll number not numeric")
        End If

        AddUser()
    End Sub

    Private Sub AddUser()
        Dim insert As String = "Insert into User values('" & txtName.Text & "','" & txtPass.Text & "');"
        Access.ExecQuery(insert)
        'Access.AddParam("@user", txtName.Text)
        'Access.AddParam("@roll", txtRoll.Text)
        'Access.AddParam("@", txtRoll.Text)

    End Sub
End Class
