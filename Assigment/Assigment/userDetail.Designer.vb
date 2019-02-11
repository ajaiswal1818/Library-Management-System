<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userDetail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(userDetail))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Udetail = New System.Windows.Forms.RichTextBox()
        Me.Usearch = New System.Windows.Forms.Button()
        Me.uPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.Label()
        Me.webmail = New System.Windows.Forms.Label()
        Me.discipline = New System.Windows.Forms.Label()
        Me.rollNo = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.displayPic = New System.Windows.Forms.PictureBox()
        Me.lblissue = New System.Windows.Forms.Label()
        Me.uPanel.SuspendLayout()
        CType(Me.displayPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(10, 104)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 3)
        Me.Panel1.TabIndex = 25
        '
        'Udetail
        '
        Me.Udetail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Udetail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Udetail.EnableAutoDragDrop = True
        Me.Udetail.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Udetail.ForeColor = System.Drawing.Color.LightGray
        Me.Udetail.Location = New System.Drawing.Point(134, 41)
        Me.Udetail.Name = "Udetail"
        Me.Udetail.Size = New System.Drawing.Size(408, 31)
        Me.Udetail.TabIndex = 26
        Me.Udetail.Text = "User Name"
        '
        'Usearch
        '
        Me.Usearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Usearch.FlatAppearance.BorderSize = 0
        Me.Usearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Usearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usearch.ForeColor = System.Drawing.Color.Snow
        Me.Usearch.Location = New System.Drawing.Point(588, 42)
        Me.Usearch.Name = "Usearch"
        Me.Usearch.Size = New System.Drawing.Size(95, 30)
        Me.Usearch.TabIndex = 27
        Me.Usearch.Text = "Search"
        Me.Usearch.UseVisualStyleBackColor = False
        '
        'uPanel
        '
        Me.uPanel.BackColor = System.Drawing.Color.Transparent
        Me.uPanel.Controls.Add(Me.Label1)
        Me.uPanel.Controls.Add(Me.Dept)
        Me.uPanel.Controls.Add(Me.webmail)
        Me.uPanel.Controls.Add(Me.discipline)
        Me.uPanel.Controls.Add(Me.rollNo)
        Me.uPanel.Controls.Add(Me.nameLabel)
        Me.uPanel.Controls.Add(Me.displayPic)
        Me.uPanel.Location = New System.Drawing.Point(10, 111)
        Me.uPanel.Name = "uPanel"
        Me.uPanel.Size = New System.Drawing.Size(812, 277)
        Me.uPanel.TabIndex = 28
        Me.uPanel.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 33)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Books Issued"
        '
        'Dept
        '
        Me.Dept.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Dept.AutoSize = True
        Me.Dept.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.Location = New System.Drawing.Point(455, 99)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(55, 22)
        Me.Dept.TabIndex = 30
        Me.Dept.Text = "dept"
        '
        'webmail
        '
        Me.webmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.webmail.AutoSize = True
        Me.webmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webmail.Location = New System.Drawing.Point(196, 137)
        Me.webmail.Name = "webmail"
        Me.webmail.Size = New System.Drawing.Size(87, 22)
        Me.webmail.TabIndex = 29
        Me.webmail.Text = "webmail"
        '
        'discipline
        '
        Me.discipline.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.discipline.AutoSize = True
        Me.discipline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discipline.Location = New System.Drawing.Point(196, 99)
        Me.discipline.Name = "discipline"
        Me.discipline.Size = New System.Drawing.Size(91, 22)
        Me.discipline.TabIndex = 28
        Me.discipline.Text = "discipline"
        '
        'rollNo
        '
        Me.rollNo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rollNo.AutoSize = True
        Me.rollNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollNo.Location = New System.Drawing.Point(196, 59)
        Me.rollNo.Name = "rollNo"
        Me.rollNo.Size = New System.Drawing.Size(60, 22)
        Me.rollNo.TabIndex = 27
        Me.rollNo.Text = "rollNo"
        '
        'nameLabel
        '
        Me.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(196, 24)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(67, 23)
        Me.nameLabel.TabIndex = 26
        Me.nameLabel.Text = "Name"
        '
        'displayPic
        '
        Me.displayPic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.displayPic.Image = CType(resources.GetObject("displayPic.Image"), System.Drawing.Image)
        Me.displayPic.Location = New System.Drawing.Point(17, 15)
        Me.displayPic.Name = "displayPic"
        Me.displayPic.Size = New System.Drawing.Size(150, 184)
        Me.displayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPic.TabIndex = 25
        Me.displayPic.TabStop = False
        '
        'lblissue
        '
        Me.lblissue.AutoSize = True
        Me.lblissue.BackColor = System.Drawing.Color.Transparent
        Me.lblissue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblissue.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissue.Location = New System.Drawing.Point(61, 427)
        Me.lblissue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblissue.Name = "lblissue"
        Me.lblissue.Size = New System.Drawing.Size(57, 21)
        Me.lblissue.TabIndex = 31
        Me.lblissue.Text = "Label1"
        '
        'userDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.uPanel)
        Me.Controls.Add(Me.lblissue)
        Me.Controls.Add(Me.Usearch)
        Me.Controls.Add(Me.Udetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "userDetail"
        Me.Size = New System.Drawing.Size(869, 740)
        Me.uPanel.ResumeLayout(False)
        Me.uPanel.PerformLayout()
        CType(Me.displayPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Udetail As System.Windows.Forms.RichTextBox
    Friend WithEvents Usearch As System.Windows.Forms.Button
    Friend WithEvents uPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblissue As System.Windows.Forms.Label
    Friend WithEvents Dept As System.Windows.Forms.Label
    Friend WithEvents webmail As System.Windows.Forms.Label
    Friend WithEvents discipline As System.Windows.Forms.Label
    Friend WithEvents rollNo As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents displayPic As System.Windows.Forms.PictureBox

End Class
