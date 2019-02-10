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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Udetail = New System.Windows.Forms.RichTextBox()
        Me.Usearch = New System.Windows.Forms.Button()
        Me.uPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblissue1 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.Label()
        Me.webmail = New System.Windows.Forms.Label()
        Me.discipline = New System.Windows.Forms.Label()
        Me.rollNo = New System.Windows.Forms.Label()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.uPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
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
        Me.Usearch.FlatAppearance.BorderSize = 0
        Me.Usearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usearch.Location = New System.Drawing.Point(588, 42)
        Me.Usearch.Name = "Usearch"
        Me.Usearch.Size = New System.Drawing.Size(95, 30)
        Me.Usearch.TabIndex = 27
        Me.Usearch.Text = "Search"
        Me.Usearch.UseVisualStyleBackColor = True
        '
        'uPanel
        '
        Me.uPanel.AutoScroll = True
        Me.uPanel.Controls.Add(Me.Label1)
        Me.uPanel.Controls.Add(Me.lblissue1)
        Me.uPanel.Controls.Add(Me.Dept)
        Me.uPanel.Controls.Add(Me.webmail)
        Me.uPanel.Controls.Add(Me.discipline)
        Me.uPanel.Controls.Add(Me.rollNo)
        Me.uPanel.Controls.Add(Me.nameLabel)
        Me.uPanel.Controls.Add(Me.PictureBox1)
        Me.uPanel.Location = New System.Drawing.Point(21, 111)
        Me.uPanel.Name = "uPanel"
        Me.uPanel.Size = New System.Drawing.Size(801, 430)
        Me.uPanel.TabIndex = 28
        Me.uPanel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 33)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Books Issued"
        '
        'lblissue1
        '
        Me.lblissue1.AutoSize = True
        Me.lblissue1.BackColor = System.Drawing.Color.White
        Me.lblissue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblissue1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissue1.Location = New System.Drawing.Point(37, 274)
        Me.lblissue1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblissue1.Name = "lblissue1"
        Me.lblissue1.Size = New System.Drawing.Size(57, 21)
        Me.lblissue1.TabIndex = 31
        Me.lblissue1.Text = "Label1"
        '
        'Dept
        '
        Me.Dept.AutoSize = True
        Me.Dept.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.Location = New System.Drawing.Point(475, 99)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(55, 22)
        Me.Dept.TabIndex = 30
        Me.Dept.Text = "dept"
        '
        'webmail
        '
        Me.webmail.AutoSize = True
        Me.webmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webmail.Location = New System.Drawing.Point(216, 137)
        Me.webmail.Name = "webmail"
        Me.webmail.Size = New System.Drawing.Size(87, 22)
        Me.webmail.TabIndex = 29
        Me.webmail.Text = "webmail"
        '
        'discipline
        '
        Me.discipline.AutoSize = True
        Me.discipline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discipline.Location = New System.Drawing.Point(216, 99)
        Me.discipline.Name = "discipline"
        Me.discipline.Size = New System.Drawing.Size(91, 22)
        Me.discipline.TabIndex = 28
        Me.discipline.Text = "discipline"
        '
        'rollNo
        '
        Me.rollNo.AutoSize = True
        Me.rollNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollNo.Location = New System.Drawing.Point(216, 59)
        Me.rollNo.Name = "rollNo"
        Me.rollNo.Size = New System.Drawing.Size(60, 22)
        Me.rollNo.TabIndex = 27
        Me.rollNo.Text = "rollNo"
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(216, 24)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(67, 23)
        Me.nameLabel.TabIndex = 26
        Me.nameLabel.Text = "Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(26, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'userDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.uPanel)
        Me.Controls.Add(Me.Usearch)
        Me.Controls.Add(Me.Udetail)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "userDetail"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.uPanel.ResumeLayout(False)
        Me.uPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Udetail As System.Windows.Forms.RichTextBox
    Friend WithEvents Usearch As System.Windows.Forms.Button
    Friend WithEvents uPanel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblissue1 As System.Windows.Forms.Label
    Friend WithEvents Dept As System.Windows.Forms.Label
    Friend WithEvents webmail As System.Windows.Forms.Label
    Friend WithEvents discipline As System.Windows.Forms.Label
    Friend WithEvents rollNo As System.Windows.Forms.Label
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
