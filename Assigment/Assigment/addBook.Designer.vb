<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addBook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addBook))
        Me.bookTitle = New System.Windows.Forms.RichTextBox()
        Me.author = New System.Windows.Forms.RichTextBox()
        Me.ISBN = New System.Windows.Forms.RichTextBox()
        Me.publisher = New System.Windows.Forms.RichTextBox()
        Me.genre = New System.Windows.Forms.RichTextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bookTitle
        '
        Me.bookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bookTitle.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookTitle.ForeColor = System.Drawing.Color.Silver
        Me.bookTitle.Location = New System.Drawing.Point(200, 136)
        Me.bookTitle.Name = "bookTitle"
        Me.bookTitle.Size = New System.Drawing.Size(415, 37)
        Me.bookTitle.TabIndex = 1
        Me.bookTitle.Text = "Title"
        '
        'author
        '
        Me.author.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.author.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.ForeColor = System.Drawing.Color.Silver
        Me.author.Location = New System.Drawing.Point(200, 207)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(415, 37)
        Me.author.TabIndex = 2
        Me.author.Text = "Author"
        '
        'ISBN
        '
        Me.ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ISBN.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.ForeColor = System.Drawing.Color.Silver
        Me.ISBN.Location = New System.Drawing.Point(200, 275)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(230, 37)
        Me.ISBN.TabIndex = 3
        Me.ISBN.Text = "ISBN"
        '
        'publisher
        '
        Me.publisher.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.publisher.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.publisher.ForeColor = System.Drawing.Color.Silver
        Me.publisher.Location = New System.Drawing.Point(200, 356)
        Me.publisher.Name = "publisher"
        Me.publisher.Size = New System.Drawing.Size(415, 37)
        Me.publisher.TabIndex = 4
        Me.publisher.Text = "Publisher"
        '
        'genre
        '
        Me.genre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.genre.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genre.ForeColor = System.Drawing.Color.Silver
        Me.genre.Location = New System.Drawing.Point(452, 275)
        Me.genre.Name = "genre"
        Me.genre.Size = New System.Drawing.Size(163, 37)
        Me.genre.TabIndex = 5
        Me.genre.Text = "Genre"
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.Color.Snow
        Me.addBtn.Location = New System.Drawing.Point(334, 455)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(146, 38)
        Me.addBtn.TabIndex = 6
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'addBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.genre)
        Me.Controls.Add(Me.publisher)
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.bookTitle)
        Me.Name = "addBook"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bookTitle As System.Windows.Forms.RichTextBox
    Friend WithEvents author As System.Windows.Forms.RichTextBox
    Friend WithEvents ISBN As System.Windows.Forms.RichTextBox
    Friend WithEvents publisher As System.Windows.Forms.RichTextBox
    Friend WithEvents genre As System.Windows.Forms.RichTextBox
    Friend WithEvents addBtn As System.Windows.Forms.Button

End Class
