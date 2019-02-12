<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Search))
        Me.cbxSrch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSrch = New System.Windows.Forms.RichTextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.lblSrch1 = New System.Windows.Forms.Label()
        Me.btnSrch1 = New System.Windows.Forms.Button()
        Me.tempSrch1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSrch
        '
        Me.cbxSrch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSrch.FormattingEnabled = True
        Me.cbxSrch.Location = New System.Drawing.Point(21, 196)
        Me.cbxSrch.Name = "cbxSrch"
        Me.cbxSrch.Size = New System.Drawing.Size(100, 25)
        Me.cbxSrch.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Keyword"
        '
        'txtSrch
        '
        Me.txtSrch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSrch.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrch.ForeColor = System.Drawing.Color.Silver
        Me.txtSrch.Location = New System.Drawing.Point(149, 189)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(517, 31)
        Me.txtSrch.TabIndex = 16
        Me.txtSrch.Text = "Search"
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.Snow
        Me.SearchBtn.Location = New System.Drawing.Point(689, 195)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(99, 24)
        Me.SearchBtn.TabIndex = 17
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'lblSrch1
        '
        Me.lblSrch1.AutoSize = True
        Me.lblSrch1.BackColor = System.Drawing.Color.Snow
        Me.lblSrch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSrch1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrch1.Location = New System.Drawing.Point(168, 260)
        Me.lblSrch1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSrch1.Name = "lblSrch1"
        Me.lblSrch1.Size = New System.Drawing.Size(57, 21)
        Me.lblSrch1.TabIndex = 20
        Me.lblSrch1.Text = "Label1"
        '
        'btnSrch1
        '
        Me.btnSrch1.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSrch1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrch1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrch1.ForeColor = System.Drawing.Color.Snow
        Me.btnSrch1.Location = New System.Drawing.Point(73, 294)
        Me.btnSrch1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSrch1.Name = "btnSrch1"
        Me.btnSrch1.Size = New System.Drawing.Size(61, 50)
        Me.btnSrch1.TabIndex = 21
        Me.btnSrch1.Text = "Issue Now!"
        Me.btnSrch1.UseVisualStyleBackColor = False
        '
        'tempSrch1
        '
        Me.tempSrch1.AutoSize = True
        Me.tempSrch1.BackColor = System.Drawing.Color.Transparent
        Me.tempSrch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.tempSrch1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempSrch1.Location = New System.Drawing.Point(775, 157)
        Me.tempSrch1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tempSrch1.Name = "tempSrch1"
        Me.tempSrch1.Size = New System.Drawing.Size(57, 21)
        Me.tempSrch1.TabIndex = 23
        Me.tempSrch1.Text = "Label1"
        Me.tempSrch1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(86, 57)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(178, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(472, 78)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Search Library"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tempSrch1)
        Me.Controls.Add(Me.btnSrch1)
        Me.Controls.Add(Me.lblSrch1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxSrch)
        Me.Name = "Search"
        Me.Size = New System.Drawing.Size(855, 740)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSrch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSrch As System.Windows.Forms.RichTextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents lblSrch1 As System.Windows.Forms.Label
    Friend WithEvents btnSrch1 As System.Windows.Forms.Button
    Friend WithEvents tempSrch1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
