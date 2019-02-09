<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChngPass
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newpass2 = New System.Windows.Forms.TextBox()
        Me.oldpass = New System.Windows.Forms.TextBox()
        Me.newpass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 362)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 30)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Confirm Password"
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(355, 470)
        Me.update.Margin = New System.Windows.Forms.Padding(4)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(156, 49)
        Me.update.TabIndex = 13
        Me.update.Text = "update"
        Me.update.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 30)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Old Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(157, 277)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 30)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "New Password"
        '
        'newpass2
        '
        Me.newpass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpass2.Location = New System.Drawing.Point(447, 362)
        Me.newpass2.Margin = New System.Windows.Forms.Padding(4)
        Me.newpass2.Name = "newpass2"
        Me.newpass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpass2.Size = New System.Drawing.Size(249, 34)
        Me.newpass2.TabIndex = 10
        '
        'oldpass
        '
        Me.oldpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oldpass.Location = New System.Drawing.Point(447, 181)
        Me.oldpass.Margin = New System.Windows.Forms.Padding(4)
        Me.oldpass.Name = "oldpass"
        Me.oldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldpass.Size = New System.Drawing.Size(249, 34)
        Me.oldpass.TabIndex = 9
        '
        'newpass
        '
        Me.newpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newpass.Location = New System.Drawing.Point(447, 269)
        Me.newpass.Margin = New System.Windows.Forms.Padding(4)
        Me.newpass.Name = "newpass"
        Me.newpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newpass.Size = New System.Drawing.Size(249, 34)
        Me.newpass.TabIndex = 8
        '
        'ChngPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newpass2)
        Me.Controls.Add(Me.oldpass)
        Me.Controls.Add(Me.newpass)
        Me.Name = "ChngPass"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newpass2 As System.Windows.Forms.TextBox
    Friend WithEvents oldpass As System.Windows.Forms.TextBox
    Friend WithEvents newpass As System.Windows.Forms.TextBox

End Class
