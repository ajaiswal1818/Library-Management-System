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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.rollNo = New System.Windows.Forms.Label()
        Me.discipline = New System.Windows.Forms.Label()
        Me.webmail = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblissue1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(77, 50)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(331, 63)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(84, 28)
        Me.nameLabel.TabIndex = 1
        Me.nameLabel.Text = "Name"
        '
        'rollNo
        '
        Me.rollNo.AutoSize = True
        Me.rollNo.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rollNo.Location = New System.Drawing.Point(331, 106)
        Me.rollNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.rollNo.Name = "rollNo"
        Me.rollNo.Size = New System.Drawing.Size(82, 30)
        Me.rollNo.TabIndex = 2
        Me.rollNo.Text = "rollNo"
        '
        'discipline
        '
        Me.discipline.AutoSize = True
        Me.discipline.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discipline.Location = New System.Drawing.Point(331, 155)
        Me.discipline.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.discipline.Name = "discipline"
        Me.discipline.Size = New System.Drawing.Size(126, 30)
        Me.discipline.TabIndex = 3
        Me.discipline.Text = "discipline"
        '
        'webmail
        '
        Me.webmail.AutoSize = True
        Me.webmail.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.webmail.Location = New System.Drawing.Point(331, 202)
        Me.webmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.webmail.Name = "webmail"
        Me.webmail.Size = New System.Drawing.Size(117, 30)
        Me.webmail.TabIndex = 4
        Me.webmail.Text = "webmail"
        '
        'Dept
        '
        Me.Dept.AutoSize = True
        Me.Dept.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept.Location = New System.Drawing.Point(676, 155)
        Me.Dept.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(69, 30)
        Me.Dept.TabIndex = 5
        Me.Dept.Text = "dept"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(1, 261)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1132, 4)
        Me.Panel1.TabIndex = 6
        '
        'lblissue1
        '
        Me.lblissue1.AutoSize = True
        Me.lblissue1.BackColor = System.Drawing.Color.White
        Me.lblissue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblissue1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissue1.Location = New System.Drawing.Point(77, 336)
        Me.lblissue1.Name = "lblissue1"
        Me.lblissue1.Size = New System.Drawing.Size(67, 23)
        Me.lblissue1.TabIndex = 23
        Me.lblissue1.Text = "Label1"
        '
        'userDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.lblissue1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Dept)
        Me.Controls.Add(Me.webmail)
        Me.Controls.Add(Me.discipline)
        Me.Controls.Add(Me.rollNo)
        Me.Controls.Add(Me.nameLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "userDetail"
        Me.Size = New System.Drawing.Size(1136, 862)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents rollNo As System.Windows.Forms.Label
    Friend WithEvents discipline As System.Windows.Forms.Label
    Friend WithEvents webmail As System.Windows.Forms.Label
    Friend WithEvents Dept As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblissue1 As System.Windows.Forms.Label

End Class
