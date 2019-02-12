<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewLogin
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtRoll = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbStf = New System.Windows.Forms.ComboBox()
        Me.cmbDisc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConf = New System.Windows.Forms.TextBox()
        Me.btnSign = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.profilePic = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.profilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 61)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(477, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Create an Account"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Silver
        Me.txtName.Location = New System.Drawing.Point(282, 214)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(190, 25)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = "Name"
        '
        'txtRoll
        '
        Me.txtRoll.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRoll.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoll.ForeColor = System.Drawing.Color.Silver
        Me.txtRoll.Location = New System.Drawing.Point(497, 214)
        Me.txtRoll.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRoll.Multiline = True
        Me.txtRoll.Name = "txtRoll"
        Me.txtRoll.Size = New System.Drawing.Size(190, 25)
        Me.txtRoll.TabIndex = 2
        Me.txtRoll.Text = "Roll Number"
        '
        'txtMail
        '
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMail.ForeColor = System.Drawing.Color.Silver
        Me.txtMail.Location = New System.Drawing.Point(282, 266)
        Me.txtMail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMail.Multiline = True
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(190, 25)
        Me.txtMail.TabIndex = 3
        Me.txtMail.Text = "Webmail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(476, 268)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "@iitg.ac.in"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(279, 325)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Faculty/Student"
        '
        'cmbStf
        '
        Me.cmbStf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStf.FormattingEnabled = True
        Me.cmbStf.Location = New System.Drawing.Point(282, 346)
        Me.cmbStf.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbStf.Name = "cmbStf"
        Me.cmbStf.Size = New System.Drawing.Size(110, 29)
        Me.cmbStf.TabIndex = 6
        '
        'cmbDisc
        '
        Me.cmbDisc.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDisc.FormattingEnabled = True
        Me.cmbDisc.Location = New System.Drawing.Point(435, 346)
        Me.cmbDisc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDisc.Name = "cmbDisc"
        Me.cmbDisc.Size = New System.Drawing.Size(110, 29)
        Me.cmbDisc.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 325)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Discipline"
        '
        'cmbDept
        '
        Me.cmbDept.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(578, 346)
        Me.cmbDept.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(110, 29)
        Me.cmbDept.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(575, 325)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Department"
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Silver
        Me.txtPass.Location = New System.Drawing.Point(282, 410)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(190, 25)
        Me.txtPass.TabIndex = 11
        Me.txtPass.Text = "Password"
        '
        'txtConf
        '
        Me.txtConf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConf.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConf.ForeColor = System.Drawing.Color.Silver
        Me.txtConf.Location = New System.Drawing.Point(497, 410)
        Me.txtConf.Margin = New System.Windows.Forms.Padding(2)
        Me.txtConf.Multiline = True
        Me.txtConf.Name = "txtConf"
        Me.txtConf.Size = New System.Drawing.Size(190, 25)
        Me.txtConf.TabIndex = 12
        Me.txtConf.Text = "Confirm Password"
        '
        'btnSign
        '
        Me.btnSign.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSign.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSign.ForeColor = System.Drawing.Color.Snow
        Me.btnSign.Location = New System.Drawing.Point(414, 493)
        Me.btnSign.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSign.Name = "btnSign"
        Me.btnSign.Size = New System.Drawing.Size(112, 50)
        Me.btnSign.TabIndex = 13
        Me.btnSign.Text = "Sign Up"
        Me.btnSign.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnView.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.ForeColor = System.Drawing.Color.Snow
        Me.BtnView.Location = New System.Drawing.Point(93, 348)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(117, 26)
        Me.BtnView.TabIndex = 17
        Me.BtnView.Text = "Choose Image"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'profilePic
        '
        Me.profilePic.BackColor = System.Drawing.Color.Transparent
        Me.profilePic.Image = CType(resources.GetObject("profilePic.Image"), System.Drawing.Image)
        Me.profilePic.Location = New System.Drawing.Point(93, 214)
        Me.profilePic.Name = "profilePic"
        Me.profilePic.Size = New System.Drawing.Size(117, 132)
        Me.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.profilePic.TabIndex = 16
        Me.profilePic.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(360, 3721)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 29)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Choose Image"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(121, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(692, 414)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 21)
        Me.CheckBox1.TabIndex = 20
        Me.CheckBox1.Text = "Hide/Show"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'NewLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.profilePic)
        Me.Controls.Add(Me.btnSign)
        Me.Controls.Add(Me.txtConf)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.cmbDept)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbDisc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbStf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.txtRoll)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "NewLogin"
        Me.Size = New System.Drawing.Size(869, 740)
        CType(Me.profilePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtRoll As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbStf As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDisc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtConf As System.Windows.Forms.TextBox
    Friend WithEvents btnSign As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents profilePic As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
