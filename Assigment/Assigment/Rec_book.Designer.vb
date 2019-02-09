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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Rectbn = New System.Windows.Forms.Button()
        Me.Rec_isbn = New System.Windows.Forms.RichTextBox()
        Me.Rec_Auth = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.RichTextBox1.Location = New System.Drawing.Point(289, 80)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(553, 37)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Title"
        '
        'Rectbn
        '
        Me.Rectbn.FlatAppearance.BorderSize = 0
        Me.Rectbn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rectbn.Location = New System.Drawing.Point(467, 358)
        Me.Rectbn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rectbn.Name = "Rectbn"
        Me.Rectbn.Size = New System.Drawing.Size(195, 47)
        Me.Rectbn.TabIndex = 3
        Me.Rectbn.Text = "Recommend"
        Me.Rectbn.UseVisualStyleBackColor = True
        '
        'Rec_isbn
        '
        Me.Rec_isbn.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rec_isbn.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_isbn.ForeColor = System.Drawing.Color.Silver
        Me.Rec_isbn.Location = New System.Drawing.Point(289, 245)
        Me.Rec_isbn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rec_isbn.Name = "Rec_isbn"
        Me.Rec_isbn.Size = New System.Drawing.Size(553, 37)
        Me.Rec_isbn.TabIndex = 4
        Me.Rec_isbn.Text = "ISBN"
        '
        'Rec_Auth
        '
        Me.Rec_Auth.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Rec_Auth.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rec_Auth.ForeColor = System.Drawing.Color.Silver
        Me.Rec_Auth.Location = New System.Drawing.Point(289, 165)
        Me.Rec_Auth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Rec_Auth.Name = "Rec_Auth"
        Me.Rec_Auth.Size = New System.Drawing.Size(553, 37)
        Me.Rec_Auth.TabIndex = 5
        Me.Rec_Auth.Text = "Author"
        '
        'Rec_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Rec_Auth)
        Me.Controls.Add(Me.Rec_isbn)
        Me.Controls.Add(Me.Rectbn)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Rec_book"
        Me.Size = New System.Drawing.Size(1136, 862)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Rectbn As System.Windows.Forms.Button
    Friend WithEvents Rec_isbn As System.Windows.Forms.RichTextBox
    Friend WithEvents Rec_Auth As System.Windows.Forms.RichTextBox

End Class
