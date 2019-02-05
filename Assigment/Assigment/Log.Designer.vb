<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        'Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.Forgot = New System.Windows.Forms.Button()
        Me.Password = New System.Windows.Forms.RichTextBox()
        Me.UserName = New System.Windows.Forms.RichTextBox()
        Me.Sign_up = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        'Me.BunifuCustomLabel1.AutoSize = True
        'Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'Me.BunifuCustomLabel1.Location = New System.Drawing.Point(93, 204)
        'Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        'Me.BunifuCustomLabel1.Size = New System.Drawing.Size(0, 17)
        'Me.BunifuCustomLabel1.TabIndex = 4
        ''
        'Forgot
        '
        Me.Forgot.BackColor = System.Drawing.SystemColors.Control
        Me.Forgot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Forgot.FlatAppearance.BorderSize = 0
        Me.Forgot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Forgot.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forgot.Location = New System.Drawing.Point(343, 133)
        Me.Forgot.Name = "Forgot"
        Me.Forgot.Size = New System.Drawing.Size(109, 23)
        Me.Forgot.TabIndex = 5
        Me.Forgot.Text = "Forget Password"
        Me.Forgot.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Password.Location = New System.Drawing.Point(284, 80)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(228, 37)
        Me.Password.TabIndex = 6
        Me.Password.Text = ""
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserName.Location = New System.Drawing.Point(284, 20)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(228, 37)
        Me.UserName.TabIndex = 7
        Me.UserName.Text = ""
        '
        'Sign_up
        '
        Me.Sign_up.FlatAppearance.BorderSize = 0
        Me.Sign_up.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign_up.Location = New System.Drawing.Point(322, 221)
        Me.Sign_up.Name = "Sign_up"
        Me.Sign_up.Size = New System.Drawing.Size(156, 34)
        Me.Sign_up.TabIndex = 8
        Me.Sign_up.Text = "Sign up"
        Me.Sign_up.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.FlatAppearance.BorderSize = 0
        Me.LogIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn.Location = New System.Drawing.Point(322, 171)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(156, 34)
        Me.LogIn.TabIndex = 9
        Me.LogIn.Text = "Login"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.Sign_up)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Forgot)
        'Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Name = "Log"
        Me.Size = New System.Drawing.Size(822, 364)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents Forgot As System.Windows.Forms.Button
    Friend WithEvents Password As System.Windows.Forms.RichTextBox
    Friend WithEvents UserName As System.Windows.Forms.RichTextBox
    Friend WithEvents Sign_up As System.Windows.Forms.Button
    Friend WithEvents LogIn As System.Windows.Forms.Button

End Class
