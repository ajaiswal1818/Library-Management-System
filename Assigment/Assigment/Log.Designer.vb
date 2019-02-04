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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Log))
        Me.LogIn = New ns1.BunifuThinButton2()
        Me.UserName = New ns1.BunifuTextbox()
        Me.Password = New ns1.BunifuTextbox()
        Me.Sign = New ns1.BunifuThinButton2()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.Forgot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LogIn
        '
        Me.LogIn.ActiveBorderThickness = 1
        Me.LogIn.ActiveCornerRadius = 20
        Me.LogIn.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.LogIn.ActiveForecolor = System.Drawing.Color.White
        Me.LogIn.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.LogIn.BackColor = System.Drawing.SystemColors.Control
        Me.LogIn.BackgroundImage = CType(resources.GetObject("LogIn.BackgroundImage"), System.Drawing.Image)
        Me.LogIn.ButtonText = "Login"
        Me.LogIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogIn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn.ForeColor = System.Drawing.Color.SeaGreen
        Me.LogIn.IdleBorderThickness = 1
        Me.LogIn.IdleCornerRadius = 20
        Me.LogIn.IdleFillColor = System.Drawing.Color.White
        Me.LogIn.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.LogIn.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.LogIn.Location = New System.Drawing.Point(300, 173)
        Me.LogIn.Margin = New System.Windows.Forms.Padding(5)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(181, 41)
        Me.LogIn.TabIndex = 0
        Me.LogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.BackColor = System.Drawing.Color.Silver
        Me.UserName.BackgroundImage = CType(resources.GetObject("UserName.BackgroundImage"), System.Drawing.Image)
        Me.UserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UserName.ForeColor = System.Drawing.Color.SeaGreen
        Me.UserName.Icon = CType(resources.GetObject("UserName.Icon"), System.Drawing.Image)
        Me.UserName.Location = New System.Drawing.Point(276, 24)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(250, 42)
        Me.UserName.TabIndex = 1
        Me.UserName.text = "UserName"
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Silver
        Me.Password.BackgroundImage = CType(resources.GetObject("Password.BackgroundImage"), System.Drawing.Image)
        Me.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Password.ForeColor = System.Drawing.Color.SeaGreen
        Me.Password.Icon = CType(resources.GetObject("Password.Icon"), System.Drawing.Image)
        Me.Password.Location = New System.Drawing.Point(276, 83)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(250, 42)
        Me.Password.TabIndex = 2
        Me.Password.text = "Password"
        '
        'Sign
        '
        Me.Sign.ActiveBorderThickness = 1
        Me.Sign.ActiveCornerRadius = 20
        Me.Sign.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Sign.ActiveForecolor = System.Drawing.Color.White
        Me.Sign.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Sign.BackColor = System.Drawing.SystemColors.Control
        Me.Sign.BackgroundImage = CType(resources.GetObject("Sign.BackgroundImage"), System.Drawing.Image)
        Me.Sign.ButtonText = "Sign up"
        Me.Sign.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sign.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign.ForeColor = System.Drawing.Color.SeaGreen
        Me.Sign.IdleBorderThickness = 1
        Me.Sign.IdleCornerRadius = 20
        Me.Sign.IdleFillColor = System.Drawing.Color.White
        Me.Sign.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.Sign.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Sign.Location = New System.Drawing.Point(300, 214)
        Me.Sign.Margin = New System.Windows.Forms.Padding(5)
        Me.Sign.Name = "Sign"
        Me.Sign.Size = New System.Drawing.Size(181, 41)
        Me.Sign.TabIndex = 3
        Me.Sign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(93, 204)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(0, 17)
        Me.BunifuCustomLabel1.TabIndex = 4
        '
        'Forgot
        '
        Me.Forgot.BackColor = System.Drawing.Color.White
        Me.Forgot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Forgot.FlatAppearance.BorderSize = 0
        Me.Forgot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Forgot.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forgot.Location = New System.Drawing.Point(332, 142)
        Me.Forgot.Name = "Forgot"
        Me.Forgot.Size = New System.Drawing.Size(109, 23)
        Me.Forgot.TabIndex = 5
        Me.Forgot.Text = "Forget Password"
        Me.Forgot.UseVisualStyleBackColor = False
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Forgot)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.Sign)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.LogIn)
        Me.Name = "Log"
        Me.Size = New System.Drawing.Size(824, 366)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LogIn As ns1.BunifuThinButton2
    Friend WithEvents UserName As ns1.BunifuTextbox
    Friend WithEvents Password As ns1.BunifuTextbox
    Friend WithEvents Sign As ns1.BunifuThinButton2
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents Forgot As System.Windows.Forms.Button

End Class
