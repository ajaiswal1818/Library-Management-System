<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Myprofile = New Assigment.Myprofile()
        Me.MyAccount = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.eBookBtn = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logoutBtn = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BooksIssued = New Assigment.BooksIssued()
        Me.Search1 = New Assigment.Search()
        Me.NewLogin = New Assigment.NewLogin()
        Me.NewLogin1 = New Assigment.NewLogin()
        Me.MyprofileSidePanel = New Assigment.Myprofile()
        Me.Log1 = New Assigment.Log()
        Me.EBooks1 = New Assigment.eBooks()
        Me.ChngPass = New Assigment.ChngPass()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Myprofile)
        Me.Panel1.Controls.Add(Me.MyAccount)
        Me.Panel1.Controls.Add(Me.SearchBtn)
        Me.Panel1.Controls.Add(Me.eBookBtn)
        Me.Panel1.Controls.Add(Me.SidePanel)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 768)
        Me.Panel1.TabIndex = 0
        '
        'Myprofile
        '
        Me.Myprofile.Location = New System.Drawing.Point(0, 406)
        Me.Myprofile.Margin = New System.Windows.Forms.Padding(5)
        Me.Myprofile.Name = "Myprofile"
        Me.Myprofile.Size = New System.Drawing.Size(171, 308)
        Me.Myprofile.TabIndex = 29
        Me.Myprofile.Visible = False
        '
        'MyAccount
        '
        Me.MyAccount.FlatAppearance.BorderSize = 0
        Me.MyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyAccount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyAccount.ForeColor = System.Drawing.Color.Black
        Me.MyAccount.Location = New System.Drawing.Point(20, 352)
        Me.MyAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.MyAccount.Name = "MyAccount"
        Me.MyAccount.Size = New System.Drawing.Size(148, 47)
        Me.MyAccount.TabIndex = 6
        Me.MyAccount.Text = "My Account"
        Me.MyAccount.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.Black
        Me.SearchBtn.Location = New System.Drawing.Point(20, 298)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(148, 47)
        Me.SearchBtn.TabIndex = 5
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'eBookBtn
        '
        Me.eBookBtn.FlatAppearance.BorderSize = 0
        Me.eBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eBookBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eBookBtn.ForeColor = System.Drawing.Color.Black
        Me.eBookBtn.Location = New System.Drawing.Point(20, 244)
        Me.eBookBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.eBookBtn.Name = "eBookBtn"
        Me.eBookBtn.Size = New System.Drawing.Size(148, 47)
        Me.eBookBtn.TabIndex = 4
        Me.eBookBtn.Text = "eBooks"
        Me.eBookBtn.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.MidnightBlue
        Me.SidePanel.Location = New System.Drawing.Point(4, 190)
        Me.SidePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(13, 47)
        Me.SidePanel.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(164, 161)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Library"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IIT Guwahati"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(20, 190)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Recommend Book"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(172, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(857, 17)
        Me.Panel3.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(515, 23)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(211, 32)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Discussion Room"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(97, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 28)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Welcome!"
        '
        'logoutBtn
        '
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), System.Drawing.Image)
        Me.logoutBtn.Location = New System.Drawing.Point(167, 4)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(33, 31)
        Me.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoutBtn.TabIndex = 24
        Me.logoutBtn.TabStop = False
        Me.ToolTip1.SetToolTip(Me.logoutBtn, "LogOut")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.logoutBtn)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(776, 23)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(217, 38)
        Me.Panel4.TabIndex = 25
        Me.Panel4.Visible = False
        '
        'BooksIssued
        '
        Me.BooksIssued.Location = New System.Drawing.Point(171, 68)
        Me.BooksIssued.Name = "BooksIssued"
        Me.BooksIssued.Size = New System.Drawing.Size(852, 700)
        Me.BooksIssued.TabIndex = 29
        Me.BooksIssued.Visible = False
        '
        'Search1
        '
        Me.Search1.AutoScroll = True
        Me.Search1.Location = New System.Drawing.Point(173, 70)
        Me.Search1.Margin = New System.Windows.Forms.Padding(5)
        Me.Search1.Name = "Search1"
        Me.Search1.Size = New System.Drawing.Size(855, 652)
        Me.Search1.TabIndex = 21
        '
        'NewLogin
        '
        Me.NewLogin.Location = New System.Drawing.Point(176, 68)
        Me.NewLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewLogin.Name = "NewLogin"
        Me.NewLogin.Size = New System.Drawing.Size(852, 700)
        Me.NewLogin.TabIndex = 28
        Me.NewLogin.Visible = False
        '
        'NewLogin1
        '
        Me.NewLogin1.Location = New System.Drawing.Point(187, 78)
        Me.NewLogin1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NewLogin1.Name = "NewLogin1"
        Me.NewLogin1.Size = New System.Drawing.Size(115, 267)
        Me.NewLogin1.TabIndex = 27
        '
        'MyprofileSidePanel
        '
        Me.MyprofileSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MyprofileSidePanel.Location = New System.Drawing.Point(172, 17)
        Me.MyprofileSidePanel.Margin = New System.Windows.Forms.Padding(5)
        Me.MyprofileSidePanel.Name = "MyprofileSidePanel"
        Me.MyprofileSidePanel.Size = New System.Drawing.Size(173, 751)
        Me.MyprofileSidePanel.TabIndex = 26
        Me.MyprofileSidePanel.Visible = False
        '
        'Log1
        '
        Me.Log1.BackColor = System.Drawing.SystemColors.Control
        Me.Log1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Log1.Location = New System.Drawing.Point(176, 70)
        Me.Log1.Margin = New System.Windows.Forms.Padding(5)
        Me.Log1.Name = "Log1"
        Me.Log1.Size = New System.Drawing.Size(853, 652)
        Me.Log1.TabIndex = 20
        Me.Log1.Visible = False
        '
        'EBooks1
        '
        Me.EBooks1.Location = New System.Drawing.Point(176, 70)
        Me.EBooks1.Margin = New System.Windows.Forms.Padding(5)
        Me.EBooks1.Name = "EBooks1"
        Me.EBooks1.Size = New System.Drawing.Size(852, 652)
        Me.EBooks1.TabIndex = 19
        Me.EBooks1.Visible = False
        '
        'ChngPass
        '
        Me.ChngPass.Location = New System.Drawing.Point(175, 70)
        Me.ChngPass.Name = "ChngPass"
        Me.ChngPass.Size = New System.Drawing.Size(852, 659)
        Me.ChngPass.TabIndex = 30
        Me.ChngPass.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1048, 750)
        Me.Controls.Add(Me.ChngPass)
        Me.Controls.Add(Me.BooksIssued)
        Me.Controls.Add(Me.Search1)
        Me.Controls.Add(Me.NewLogin)
        Me.Controls.Add(Me.NewLogin1)
        Me.Controls.Add(Me.MyprofileSidePanel)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.EBooks1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "LIB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents MyAccount As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents eBookBtn As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents EBooks1 As Assigment.eBooks
    Friend WithEvents Log1 As Assigment.Log
    Friend WithEvents Search1 As Assigment.Search
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logoutBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents MyprofileSidePanel As Assigment.Myprofile
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NewLogin1 As Assigment.NewLogin
    Friend WithEvents NewLogin As Assigment.NewLogin
    Friend WithEvents Myprofile As Assigment.Myprofile
    Friend WithEvents BooksIssued As Assigment.BooksIssued
    Friend WithEvents ChngPass As Assigment.ChngPass

End Class
