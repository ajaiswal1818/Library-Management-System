<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Myprofile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Myprofile))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Arrow = New System.Windows.Forms.PictureBox()
        Me.btnPasschange = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnmyprofile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Arrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.Controls.Add(Me.Arrow)
        Me.Panel1.Controls.Add(Me.btnPasschange)
        Me.Panel1.Controls.Add(Me.btnItems)
        Me.Panel1.Controls.Add(Me.btnmyprofile)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(172, 418)
        Me.Panel1.TabIndex = 1
        '
        'Arrow
        '
        Me.Arrow.Image = CType(resources.GetObject("Arrow.Image"), System.Drawing.Image)
        Me.Arrow.Location = New System.Drawing.Point(16, 18)
        Me.Arrow.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Arrow.Name = "Arrow"
        Me.Arrow.Size = New System.Drawing.Size(33, 22)
        Me.Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Arrow.TabIndex = 6
        Me.Arrow.TabStop = False
        Me.Arrow.Visible = False
        '
        'btnPasschange
        '
        Me.btnPasschange.FlatAppearance.BorderSize = 0
        Me.btnPasschange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasschange.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasschange.ForeColor = System.Drawing.Color.Black
        Me.btnPasschange.Location = New System.Drawing.Point(52, 134)
        Me.btnPasschange.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPasschange.Name = "btnPasschange"
        Me.btnPasschange.Size = New System.Drawing.Size(116, 58)
        Me.btnPasschange.TabIndex = 5
        Me.btnPasschange.Text = "Change Password"
        Me.btnPasschange.UseVisualStyleBackColor = True
        '
        'btnItems
        '
        Me.btnItems.FlatAppearance.BorderSize = 0
        Me.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItems.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.ForeColor = System.Drawing.Color.Black
        Me.btnItems.Location = New System.Drawing.Point(53, 69)
        Me.btnItems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(116, 58)
        Me.btnItems.TabIndex = 4
        Me.btnItems.Text = "Items Checked out"
        Me.btnItems.UseVisualStyleBackColor = True
        '
        'btnmyprofile
        '
        Me.btnmyprofile.FlatAppearance.BorderSize = 0
        Me.btnmyprofile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmyprofile.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmyprofile.ForeColor = System.Drawing.Color.Black
        Me.btnmyprofile.Location = New System.Drawing.Point(53, 4)
        Me.btnmyprofile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmyprofile.Name = "btnmyprofile"
        Me.btnmyprofile.Size = New System.Drawing.Size(116, 58)
        Me.btnmyprofile.TabIndex = 0
        Me.btnmyprofile.Text = "My Profile"
        Me.btnmyprofile.UseVisualStyleBackColor = True
        '
        'Myprofile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Myprofile"
        Me.Size = New System.Drawing.Size(173, 768)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Arrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnPasschange As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents btnmyprofile As System.Windows.Forms.Button
    Friend WithEvents Arrow As System.Windows.Forms.PictureBox

End Class
