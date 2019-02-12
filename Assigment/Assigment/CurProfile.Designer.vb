<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurProfile))
        Me.Dept = New System.Windows.Forms.Label()
        Me.webmail = New System.Windows.Forms.Label()
        Me.discipline = New System.Windows.Forms.Label()
        Me.rollNo = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.PicProfile = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Address = New System.Windows.Forms.Label()
        Me.pincode = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.Label()
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dept
        '
        Me.Dept.AutoSize = True
        Me.Dept.BackColor = System.Drawing.Color.Transparent
        Me.Dept.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.Location = New System.Drawing.Point(345, 288)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(55, 22)
        Me.Dept.TabIndex = 12
        Me.Dept.Text = "dept"
        '
        'webmail
        '
        Me.webmail.AutoSize = True
        Me.webmail.BackColor = System.Drawing.Color.Transparent
        Me.webmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webmail.Location = New System.Drawing.Point(345, 257)
        Me.webmail.Name = "webmail"
        Me.webmail.Size = New System.Drawing.Size(87, 22)
        Me.webmail.TabIndex = 11
        Me.webmail.Text = "webmail"
        '
        'discipline
        '
        Me.discipline.AutoSize = True
        Me.discipline.BackColor = System.Drawing.Color.Transparent
        Me.discipline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discipline.Location = New System.Drawing.Point(345, 224)
        Me.discipline.Name = "discipline"
        Me.discipline.Size = New System.Drawing.Size(91, 22)
        Me.discipline.TabIndex = 10
        Me.discipline.Text = "discipline"
        '
        'rollNo
        '
        Me.rollNo.AutoSize = True
        Me.rollNo.BackColor = System.Drawing.Color.Transparent
        Me.rollNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollNo.Location = New System.Drawing.Point(345, 189)
        Me.rollNo.Name = "rollNo"
        Me.rollNo.Size = New System.Drawing.Size(60, 22)
        Me.rollNo.TabIndex = 9
        Me.rollNo.Text = "rollNo"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.BackColor = System.Drawing.Color.Transparent
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(345, 134)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(67, 23)
        Me.nameLabel.TabIndex = 8
        Me.nameLabel.Text = "Name"
        '
        'PicProfile
        '
        Me.PicProfile.BackColor = System.Drawing.Color.Transparent
        Me.PicProfile.Image = CType(resources.GetObject("PicProfile.Image"), System.Drawing.Image)
        Me.PicProfile.Location = New System.Drawing.Point(89, 115)
        Me.PicProfile.Name = "PicProfile"
        Me.PicProfile.Size = New System.Drawing.Size(184, 200)
        Me.PicProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicProfile.TabIndex = 7
        Me.PicProfile.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(14, 345)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 3)
        Me.Panel1.TabIndex = 26
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.BackColor = System.Drawing.Color.Transparent
        Me.Address.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(97, 400)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(71, 22)
        Me.Address.TabIndex = 27
        Me.Address.Text = "Label1"
        '
        'pincode
        '
        Me.pincode.AutoSize = True
        Me.pincode.BackColor = System.Drawing.Color.Transparent
        Me.pincode.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pincode.Location = New System.Drawing.Point(97, 477)
        Me.pincode.Name = "pincode"
        Me.pincode.Size = New System.Drawing.Size(71, 22)
        Me.pincode.TabIndex = 28
        Me.pincode.Text = "Label2"
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(97, 552)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(71, 22)
        Me.year.TabIndex = 29
        Me.year.Text = "Label3"
        '
        'CurProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.pincode)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dept)
        Me.Controls.Add(Me.webmail)
        Me.Controls.Add(Me.discipline)
        Me.Controls.Add(Me.rollNo)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.PicProfile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CurProfile"
        Me.Size = New System.Drawing.Size(852, 740)
        CType(Me.PicProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dept As System.Windows.Forms.Label
    Friend WithEvents webmail As System.Windows.Forms.Label
    Friend WithEvents discipline As System.Windows.Forms.Label
    Friend WithEvents rollNo As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents PicProfile As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Address As System.Windows.Forms.Label
    Friend WithEvents pincode As System.Windows.Forms.Label
    Friend WithEvents year As System.Windows.Forms.Label

End Class
