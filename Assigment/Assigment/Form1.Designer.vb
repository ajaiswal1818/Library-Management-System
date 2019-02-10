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
        Me.MyAccount = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.eBookBtn = New System.Windows.Forms.Button()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RecommendBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.logoutBtn = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.adminPanel = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.recommended = New System.Windows.Forms.Button()
        Me.BookDetail = New System.Windows.Forms.Button()
        Me.UserDetail = New System.Windows.Forms.Button()
        Me.RemoveBook = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.AddBook = New System.Windows.Forms.Button()
        Me.ChngPass = New Assigment.ChngPass()
        Me.UserDetail1 = New Assigment.userDetail()
        Me.Myprofile = New Assigment.Myprofile()
        Me.Reco = New Assigment.reco()
        Me.Rec_book1 = New Assigment.Rec_book()
        Me.AddBookP = New Assigment.addBook()
        Me.remove_detail = New Assigment.remove_detail()
        Me.Log1 = New Assigment.Log()
        Me.BooksIssued = New Assigment.BooksIssued()
        Me.Search1 = New Assigment.Search()
        Me.NewLogin = New Assigment.NewLogin()
        Me.EBooks1 = New Assigment.eBooks()
        Me.DiscRoom = New Assigment.DiscRoom()
        Me.CurProfile = New Assigment.CurProfile()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.adminPanel.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.RecommendBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(129, 798)
        Me.Panel1.TabIndex = 0
        '
        'MyAccount
        '
        Me.MyAccount.FlatAppearance.BorderSize = 0
        Me.MyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyAccount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyAccount.ForeColor = System.Drawing.Color.Black
        Me.MyAccount.Location = New System.Drawing.Point(15, 286)
        Me.MyAccount.Name = "MyAccount"
        Me.MyAccount.Size = New System.Drawing.Size(111, 38)
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
        Me.SearchBtn.Location = New System.Drawing.Point(15, 242)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(111, 38)
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
        Me.eBookBtn.Location = New System.Drawing.Point(15, 198)
        Me.eBookBtn.Name = "eBookBtn"
        Me.eBookBtn.Size = New System.Drawing.Size(111, 38)
        Me.eBookBtn.TabIndex = 4
        Me.eBookBtn.Text = "eBooks"
        Me.eBookBtn.UseVisualStyleBackColor = True
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.MidnightBlue
        Me.SidePanel.Location = New System.Drawing.Point(3, 154)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(10, 38)
        Me.SidePanel.TabIndex = 3
        Me.SidePanel.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(123, 131)
        Me.Panel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Library"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "IIT Guwahati"
        '
        'RecommendBtn
        '
        Me.RecommendBtn.FlatAppearance.BorderSize = 0
        Me.RecommendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RecommendBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecommendBtn.ForeColor = System.Drawing.Color.Black
        Me.RecommendBtn.Location = New System.Drawing.Point(15, 154)
        Me.RecommendBtn.Name = "RecommendBtn"
        Me.RecommendBtn.Size = New System.Drawing.Size(111, 47)
        Me.RecommendBtn.TabIndex = 0
        Me.RecommendBtn.Text = "Recommend Book"
        Me.RecommendBtn.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(129, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1171, 14)
        Me.Panel3.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(386, 19)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(158, 26)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Discussion Room"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Welcome!"
        '
        'logoutBtn
        '
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), System.Drawing.Image)
        Me.logoutBtn.Location = New System.Drawing.Point(125, 3)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(25, 25)
        Me.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoutBtn.TabIndex = 24
        Me.logoutBtn.TabStop = False
        Me.ToolTip1.SetToolTip(Me.logoutBtn, "LogOut")
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.logoutBtn)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(582, 19)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(163, 31)
        Me.Panel4.TabIndex = 25
        Me.Panel4.Visible = False
        '
        'adminPanel
        '
        Me.adminPanel.BackColor = System.Drawing.Color.Snow
        Me.adminPanel.Controls.Add(Me.Panel7)
        Me.adminPanel.Controls.Add(Me.recommended)
        Me.adminPanel.Controls.Add(Me.BookDetail)
        Me.adminPanel.Controls.Add(Me.UserDetail)
        Me.adminPanel.Controls.Add(Me.RemoveBook)
        Me.adminPanel.Controls.Add(Me.Panel6)
        Me.adminPanel.Controls.Add(Me.AddBook)
        Me.adminPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.adminPanel.Location = New System.Drawing.Point(129, 14)
        Me.adminPanel.Name = "adminPanel"
        Me.adminPanel.Size = New System.Drawing.Size(129, 784)
        Me.adminPanel.TabIndex = 30
        Me.adminPanel.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Snow
        Me.Panel7.Controls.Add(Me.PictureBox3)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(123, 131)
        Me.Panel7.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Library"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "IIT Guwahati"
        '
        'recommended
        '
        Me.recommended.FlatAppearance.BorderSize = 0
        Me.recommended.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recommended.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recommended.ForeColor = System.Drawing.Color.Black
        Me.recommended.Location = New System.Drawing.Point(9, 287)
        Me.recommended.Name = "recommended"
        Me.recommended.Size = New System.Drawing.Size(111, 45)
        Me.recommended.TabIndex = 7
        Me.recommended.Text = "Recommended Books"
        Me.recommended.UseVisualStyleBackColor = True
        '
        'BookDetail
        '
        Me.BookDetail.FlatAppearance.BorderSize = 0
        Me.BookDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BookDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookDetail.ForeColor = System.Drawing.Color.Black
        Me.BookDetail.Location = New System.Drawing.Point(15, 242)
        Me.BookDetail.Name = "BookDetail"
        Me.BookDetail.Size = New System.Drawing.Size(111, 38)
        Me.BookDetail.TabIndex = 6
        Me.BookDetail.Text = "Books Detail"
        Me.BookDetail.UseVisualStyleBackColor = True
        '
        'UserDetail
        '
        Me.UserDetail.FlatAppearance.BorderSize = 0
        Me.UserDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UserDetail.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserDetail.ForeColor = System.Drawing.Color.Black
        Me.UserDetail.Location = New System.Drawing.Point(9, 332)
        Me.UserDetail.Name = "UserDetail"
        Me.UserDetail.Size = New System.Drawing.Size(111, 38)
        Me.UserDetail.TabIndex = 5
        Me.UserDetail.Text = "Users Detail"
        Me.UserDetail.UseVisualStyleBackColor = True
        '
        'RemoveBook
        '
        Me.RemoveBook.FlatAppearance.BorderSize = 0
        Me.RemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RemoveBook.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBook.ForeColor = System.Drawing.Color.Black
        Me.RemoveBook.Location = New System.Drawing.Point(15, 198)
        Me.RemoveBook.Name = "RemoveBook"
        Me.RemoveBook.Size = New System.Drawing.Size(111, 38)
        Me.RemoveBook.TabIndex = 4
        Me.RemoveBook.Text = "Remove Book"
        Me.RemoveBook.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel6.Location = New System.Drawing.Point(3, 154)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(10, 38)
        Me.Panel6.TabIndex = 3
        Me.Panel6.Visible = False
        '
        'AddBook
        '
        Me.AddBook.FlatAppearance.BorderSize = 0
        Me.AddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBook.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBook.ForeColor = System.Drawing.Color.Black
        Me.AddBook.Location = New System.Drawing.Point(15, 148)
        Me.AddBook.Name = "AddBook"
        Me.AddBook.Size = New System.Drawing.Size(111, 47)
        Me.AddBook.TabIndex = 0
        Me.AddBook.Text = "Add Book"
        Me.AddBook.UseVisualStyleBackColor = True
        '
        'ChngPass
        '
        Me.ChngPass.Location = New System.Drawing.Point(129, 98)
        Me.ChngPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChngPass.Name = "ChngPass"
        Me.ChngPass.Size = New System.Drawing.Size(852, 700)
        Me.ChngPass.TabIndex = 32
        Me.ChngPass.Visible = False
        '
        'UserDetail1
        '
        Me.UserDetail1.AutoScroll = True
        Me.UserDetail1.Location = New System.Drawing.Point(129, 53)
        Me.UserDetail1.Name = "UserDetail1"
        Me.UserDetail1.Size = New System.Drawing.Size(852, 700)
        Me.UserDetail1.TabIndex = 36
        Me.UserDetail1.Visible = False
        '
        'Myprofile
        '
        Me.Myprofile.Location = New System.Drawing.Point(0, 330)
        Me.Myprofile.Margin = New System.Windows.Forms.Padding(4)
        Me.Myprofile.Name = "Myprofile"
        Me.Myprofile.Size = New System.Drawing.Size(128, 250)
        Me.Myprofile.TabIndex = 29
        Me.Myprofile.Visible = False
        '
        'Reco
        '
        Me.Reco.AutoScroll = True
        Me.Reco.Location = New System.Drawing.Point(125, 57)
        Me.Reco.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Reco.Name = "Reco"
        Me.Reco.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Reco.Size = New System.Drawing.Size(852, 700)
        Me.Reco.TabIndex = 34
        Me.Reco.Visible = False
        '
        'Rec_book1
        '
        Me.Rec_book1.Location = New System.Drawing.Point(130, 60)
        Me.Rec_book1.Name = "Rec_book1"
        Me.Rec_book1.Size = New System.Drawing.Size(852, 700)
        Me.Rec_book1.TabIndex = 35
        Me.Rec_book1.Visible = False
        '
        'AddBookP
        '
        Me.AddBookP.Location = New System.Drawing.Point(132, 57)
        Me.AddBookP.Margin = New System.Windows.Forms.Padding(4)
        Me.AddBookP.Name = "AddBookP"
        Me.AddBookP.Size = New System.Drawing.Size(852, 700)
        Me.AddBookP.TabIndex = 34
        Me.AddBookP.Visible = False
        '
        'remove_detail
        '
        Me.remove_detail.Location = New System.Drawing.Point(130, 60)
        Me.remove_detail.Margin = New System.Windows.Forms.Padding(4)
        Me.remove_detail.Name = "remove_detail"
        Me.remove_detail.Size = New System.Drawing.Size(852, 700)
        Me.remove_detail.TabIndex = 32
        Me.remove_detail.Visible = False
        '
        'Log1
        '
        Me.Log1.BackColor = System.Drawing.SystemColors.Control
        Me.Log1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Log1.Location = New System.Drawing.Point(129, 54)
        Me.Log1.Margin = New System.Windows.Forms.Padding(4)
        Me.Log1.Name = "Log1"
        Me.Log1.Size = New System.Drawing.Size(852, 700)
        Me.Log1.TabIndex = 20
        Me.Log1.Visible = False
        '
        'BooksIssued
        '
        Me.BooksIssued.Location = New System.Drawing.Point(134, 50)
        Me.BooksIssued.Margin = New System.Windows.Forms.Padding(2)
        Me.BooksIssued.Name = "BooksIssued"
        Me.BooksIssued.Size = New System.Drawing.Size(852, 700)
        Me.BooksIssued.TabIndex = 29
        Me.BooksIssued.Visible = False
        '
        'Search1
        '
        Me.Search1.AutoScroll = True
        Me.Search1.Location = New System.Drawing.Point(130, 57)
        Me.Search1.Margin = New System.Windows.Forms.Padding(4)
        Me.Search1.Name = "Search1"
        Me.Search1.Size = New System.Drawing.Size(852, 700)
        Me.Search1.TabIndex = 21
        '
        'NewLogin
        '
        Me.NewLogin.Location = New System.Drawing.Point(132, 55)
        Me.NewLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.NewLogin.Name = "NewLogin"
        Me.NewLogin.Size = New System.Drawing.Size(852, 700)
        Me.NewLogin.TabIndex = 28
        Me.NewLogin.Visible = False
        '
        'EBooks1
        '
        Me.EBooks1.Location = New System.Drawing.Point(132, 57)
        Me.EBooks1.Margin = New System.Windows.Forms.Padding(4)
        Me.EBooks1.Name = "EBooks1"
        Me.EBooks1.Size = New System.Drawing.Size(852, 700)
        Me.EBooks1.TabIndex = 19
        Me.EBooks1.Visible = False
        '
        'DiscRoom
        '
        Me.DiscRoom.Location = New System.Drawing.Point(129, 57)
        Me.DiscRoom.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscRoom.Name = "DiscRoom"
        Me.DiscRoom.Size = New System.Drawing.Size(852, 700)
        Me.DiscRoom.TabIndex = 31
        Me.DiscRoom.Visible = False
        '
        'CurProfile
        '
        Me.CurProfile.Location = New System.Drawing.Point(133, 55)
        Me.CurProfile.Margin = New System.Windows.Forms.Padding(2)
        Me.CurProfile.Name = "CurProfile"
        Me.CurProfile.Size = New System.Drawing.Size(852, 700)
        Me.CurProfile.TabIndex = 33
        Me.CurProfile.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1317, 609)
        Me.Controls.Add(Me.adminPanel)
        Me.Controls.Add(Me.ChngPass)
        Me.Controls.Add(Me.UserDetail1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Reco)
        Me.Controls.Add(Me.Rec_book1)
        Me.Controls.Add(Me.AddBookP)
        Me.Controls.Add(Me.remove_detail)
        Me.Controls.Add(Me.Log1)
        Me.Controls.Add(Me.BooksIssued)
        Me.Controls.Add(Me.Search1)
        Me.Controls.Add(Me.NewLogin)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.EBooks1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.DiscRoom)
        Me.Controls.Add(Me.CurProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "LIB"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.adminPanel.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RecommendBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents MyAccount As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents eBookBtn As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents EBooks1 As Assigment.eBooks
    Friend WithEvents Log1 As Assigment.Log
    Friend WithEvents Search1 As Assigment.Search
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents logoutBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents NewLogin As Assigment.NewLogin
    Friend WithEvents Myprofile As Assigment.Myprofile
    Friend WithEvents BooksIssued As Assigment.BooksIssued
    Friend WithEvents adminPanel As System.Windows.Forms.Panel
    Friend WithEvents BookDetail As System.Windows.Forms.Button
    Friend WithEvents UserDetail As System.Windows.Forms.Button
    Friend WithEvents RemoveBook As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AddBook As System.Windows.Forms.Button
    Friend WithEvents DiscRoom As Assigment.DiscRoom
    Friend WithEvents ChngPass As Assigment.ChngPass
    Friend WithEvents remove_detail As Assigment.remove_detail
    Friend WithEvents CurProfile As Assigment.CurProfile
    Friend WithEvents recommended As System.Windows.Forms.Button
    Friend WithEvents Reco As Assigment.reco
    Friend WithEvents AddBookP As Assigment.addBook
    Friend WithEvents Rec_book1 As Assigment.Rec_book
    Friend WithEvents UserDetail1 As Assigment.userDetail

End Class
