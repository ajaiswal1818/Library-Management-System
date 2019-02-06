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
        Me.Forgot = New System.Windows.Forms.Button()
        Me.Sign_up = New System.Windows.Forms.Button()
        Me.LogIn = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Forgot
        '
        Me.Forgot.AutoSize = True
        Me.Forgot.BackColor = System.Drawing.SystemColors.Control
        Me.Forgot.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Forgot.FlatAppearance.BorderSize = 0
        Me.Forgot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Forgot.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forgot.Location = New System.Drawing.Point(344, 227)
        Me.Forgot.Margin = New System.Windows.Forms.Padding(4)
        Me.Forgot.Name = "Forgot"
        Me.Forgot.Size = New System.Drawing.Size(145, 37)
        Me.Forgot.TabIndex = 5
        Me.Forgot.Text = "Forgot Password"
        Me.Forgot.UseVisualStyleBackColor = False
        '
        'Sign_up
        '
        Me.Sign_up.FlatAppearance.BorderSize = 0
        Me.Sign_up.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sign_up.Location = New System.Drawing.Point(314, 366)
        Me.Sign_up.Margin = New System.Windows.Forms.Padding(4)
        Me.Sign_up.Name = "Sign_up"
        Me.Sign_up.Size = New System.Drawing.Size(208, 42)
        Me.Sign_up.TabIndex = 8
        Me.Sign_up.Text = "Sign up"
        Me.Sign_up.UseVisualStyleBackColor = True
        '
        'LogIn
        '
        Me.LogIn.FlatAppearance.BorderSize = 0
        Me.LogIn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogIn.Location = New System.Drawing.Point(314, 304)
        Me.LogIn.Margin = New System.Windows.Forms.Padding(4)
        Me.LogIn.Name = "LogIn"
        Me.LogIn.Size = New System.Drawing.Size(208, 42)
        Me.LogIn.TabIndex = 9
        Me.LogIn.Text = "Login"
        Me.LogIn.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(266, 147)
        Me.txtPass.Multiline = True
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(304, 44)
        Me.txtPass.TabIndex = 10
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(266, 83)
        Me.txtUser.Multiline = True
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(304, 44)
        Me.txtUser.TabIndex = 11
        '
        'dgvUser
        '
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Location = New System.Drawing.Point(125, 460)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.RowTemplate.Height = 24
        Me.dgvUser.Size = New System.Drawing.Size(590, 150)
        Me.dgvUser.TabIndex = 12
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.dgvUser)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.LogIn)
        Me.Controls.Add(Me.Sign_up)
        Me.Controls.Add(Me.Forgot)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Log"
        Me.Size = New System.Drawing.Size(852, 700)
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents Forgot As System.Windows.Forms.Button
    Friend WithEvents Sign_up As System.Windows.Forms.Button
    Friend WithEvents LogIn As System.Windows.Forms.Button
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView

End Class
