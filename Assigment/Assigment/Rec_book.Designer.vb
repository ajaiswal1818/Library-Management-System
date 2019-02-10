<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rec_book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rec_book))
        Me.Rec_Auth = New System.Windows.Forms.RichTextBox()
        Me.Rec_isbn = New System.Windows.Forms.RichTextBox()
        Me.Rectbn = New System.Windows.Forms.Button()
        Me.Rec_title = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rec_Auth
        '
        Me.Rec_Auth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rec_Auth.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_Auth.ForeColor = System.Drawing.Color.Silver
        Me.Rec_Auth.Location = New System.Drawing.Point(201, 273)
        Me.Rec_Auth.Name = "Rec_Auth"
        Me.Rec_Auth.Size = New System.Drawing.Size(415, 30)
        Me.Rec_Auth.TabIndex = 9
        Me.Rec_Auth.Text = "Author"
        '
        'Rec_isbn
        '
        Me.Rec_isbn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rec_isbn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_isbn.ForeColor = System.Drawing.Color.Silver
        Me.Rec_isbn.Location = New System.Drawing.Point(201, 338)
        Me.Rec_isbn.Name = "Rec_isbn"
        Me.Rec_isbn.Size = New System.Drawing.Size(415, 30)
        Me.Rec_isbn.TabIndex = 8
        Me.Rec_isbn.Text = "ISBN"
        '
        'Rectbn
        '
        Me.Rectbn.FlatAppearance.BorderSize = 0
        Me.Rectbn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rectbn.Location = New System.Drawing.Point(334, 429)
        Me.Rectbn.Name = "Rectbn"
        Me.Rectbn.Size = New System.Drawing.Size(146, 38)
        Me.Rectbn.TabIndex = 7
        Me.Rectbn.Text = "Recommend"
        Me.Rectbn.UseVisualStyleBackColor = True
        '
        'Rec_title
        '
        Me.Rec_title.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rec_title.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_title.ForeColor = System.Drawing.Color.Silver
        Me.Rec_title.Location = New System.Drawing.Point(201, 204)
        Me.Rec_title.Name = "Rec_title"
        Me.Rec_title.Size = New System.Drawing.Size(415, 30)
        Me.Rec_title.TabIndex = 6
        Me.Rec_title.Text = "Title"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(318, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Rec_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Rec_Auth)
        Me.Controls.Add(Me.Rec_isbn)
        Me.Controls.Add(Me.Rectbn)
        Me.Controls.Add(Me.Rec_title)
        Me.Name = "Rec_book"
        Me.Size = New System.Drawing.Size(852, 700)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Rec_Auth As System.Windows.Forms.RichTextBox
    Friend WithEvents Rec_isbn As System.Windows.Forms.RichTextBox
    Friend WithEvents Rectbn As System.Windows.Forms.Button
    Friend WithEvents Rec_title As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
