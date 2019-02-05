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
        Me.txtSrch = New ns1.BunifuTextbox()
        Me.BunifuThinButton21 = New ns1.BunifuThinButton2()
        Me.cbxSrch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvSrch = New System.Windows.Forms.DataGridView()
        Me.SrchPnl1 = New System.Windows.Forms.Panel()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.SrchLbl1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SrchPnl1.SuspendLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSrch
        '
        Me.txtSrch.BackColor = System.Drawing.Color.Silver
        Me.txtSrch.BackgroundImage = CType(resources.GetObject("txtSrch.BackgroundImage"), System.Drawing.Image)
        Me.txtSrch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.txtSrch.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtSrch.Icon = CType(resources.GetObject("txtSrch.Icon"), System.Drawing.Image)
        Me.txtSrch.Location = New System.Drawing.Point(191, 64)
        Me.txtSrch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(653, 43)
        Me.txtSrch.TabIndex = 0
        Me.txtSrch.text = "Enter Text"
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 20
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "Search"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton21.Location = New System.Drawing.Point(872, 64)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(187, 43)
        Me.BunifuThinButton21.TabIndex = 1
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxSrch
        '
        Me.cbxSrch.FormattingEnabled = True
        Me.cbxSrch.Location = New System.Drawing.Point(4, 64)
        Me.cbxSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxSrch.Name = "cbxSrch"
        Me.cbxSrch.Size = New System.Drawing.Size(160, 24)
        Me.cbxSrch.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 39)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 39)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Keyword"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.SrchPnl1)
        Me.FlowLayoutPanel1.Controls.Add(Me.dgvSrch)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(131, 138)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(785, 497)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'dgvSrch
        '
        Me.dgvSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSrch.Location = New System.Drawing.Point(3, 148)
        Me.dgvSrch.Name = "dgvSrch"
        Me.dgvSrch.RowTemplate.Height = 24
        Me.dgvSrch.Size = New System.Drawing.Size(507, 156)
        Me.dgvSrch.TabIndex = 3
        '
        'SrchPnl1
        '
        Me.SrchPnl1.Controls.Add(Me.SrchLbl1)
        Me.SrchPnl1.Controls.Add(Me.pic1)
        Me.SrchPnl1.Location = New System.Drawing.Point(3, 3)
        Me.SrchPnl1.Name = "SrchPnl1"
        Me.SrchPnl1.Size = New System.Drawing.Size(775, 139)
        Me.SrchPnl1.TabIndex = 0
        '
        'pic1
        '
        Me.pic1.Location = New System.Drawing.Point(30, 28)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(57, 81)
        Me.pic1.TabIndex = 0
        Me.pic1.TabStop = False
        '
        'SrchLbl1
        '
        Me.SrchLbl1.AutoSize = True
        Me.SrchLbl1.Location = New System.Drawing.Point(128, 28)
        Me.SrchLbl1.Name = "SrchLbl1"
        Me.SrchLbl1.Size = New System.Drawing.Size(51, 17)
        Me.SrchLbl1.TabIndex = 1
        Me.SrchLbl1.Text = "Label1"
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxSrch)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.txtSrch)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Search"
        Me.Size = New System.Drawing.Size(1024, 768)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SrchPnl1.ResumeLayout(False)
        Me.SrchPnl1.PerformLayout()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSrch As ns1.BunifuTextbox
    Friend WithEvents BunifuThinButton21 As ns1.BunifuThinButton2
    Friend WithEvents cbxSrch As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents dgvSrch As System.Windows.Forms.DataGridView
    Friend WithEvents SrchPnl1 As System.Windows.Forms.Panel
    Friend WithEvents SrchLbl1 As System.Windows.Forms.Label
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox

End Class
