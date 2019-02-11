<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class book_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(book_details))
        Me.lbl_bookContent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_bookContent
        '
        Me.lbl_bookContent.AutoSize = True
        Me.lbl_bookContent.BackColor = System.Drawing.Color.White
        Me.lbl_bookContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_bookContent.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_bookContent.Location = New System.Drawing.Point(169, 148)
        Me.lbl_bookContent.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_bookContent.Name = "lbl_bookContent"
        Me.lbl_bookContent.Size = New System.Drawing.Size(57, 21)
        Me.lbl_bookContent.TabIndex = 27
        Me.lbl_bookContent.Text = "Label1"
        '
        'book_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lbl_bookContent)
        Me.Name = "book_details"
        Me.Size = New System.Drawing.Size(869, 740)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_bookContent As System.Windows.Forms.Label

End Class
