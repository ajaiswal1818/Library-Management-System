<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recommendBook
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
        Me.BookName = New System.Windows.Forms.RichTextBox()
        Me.recommend = New System.Windows.Forms.Button()
        Me.Author = New System.Windows.Forms.RichTextBox()
        Me.ISBN = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'BookName
        '
        Me.BookName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BookName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookName.ForeColor = System.Drawing.Color.Silver
        Me.BookName.Location = New System.Drawing.Point(187, 158)
        Me.BookName.Name = "BookName"
        Me.BookName.Size = New System.Drawing.Size(460, 34)
        Me.BookName.TabIndex = 0
        Me.BookName.Text = "BookName"
        '
        'recommend
        '
        Me.recommend.FlatAppearance.BorderSize = 0
        Me.recommend.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recommend.Location = New System.Drawing.Point(306, 397)
        Me.recommend.Name = "recommend"
        Me.recommend.Size = New System.Drawing.Size(229, 51)
        Me.recommend.TabIndex = 3
        Me.recommend.Text = "Recommend"
        Me.recommend.UseVisualStyleBackColor = True
        '
        'Author
        '
        Me.Author.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Author.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Author.ForeColor = System.Drawing.Color.Silver
        Me.Author.Location = New System.Drawing.Point(187, 235)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(460, 34)
        Me.Author.TabIndex = 4
        Me.Author.Text = "Author"
        '
        'ISBN
        '
        Me.ISBN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ISBN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ISBN.ForeColor = System.Drawing.Color.Silver
        Me.ISBN.Location = New System.Drawing.Point(187, 312)
        Me.ISBN.Name = "ISBN"
        Me.ISBN.Size = New System.Drawing.Size(460, 34)
        Me.ISBN.TabIndex = 5
        Me.ISBN.Text = "ISBN"
        '
        'recommendBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ISBN)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.recommend)
        Me.Controls.Add(Me.BookName)
        Me.Name = "recommendBook"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BookName As System.Windows.Forms.RichTextBox
    Friend WithEvents recommend As System.Windows.Forms.Button
    Friend WithEvents Author As System.Windows.Forms.RichTextBox
    Friend WithEvents ISBN As System.Windows.Forms.RichTextBox

End Class
