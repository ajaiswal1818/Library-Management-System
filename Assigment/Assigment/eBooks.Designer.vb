<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(eBooks))
        Me.Search = New ns1.BunifuTextbox()
        Me.Search_Button = New ns1.BunifuThinButton2()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.BackColor = System.Drawing.Color.Silver
        Me.Search.BackgroundImage = CType(resources.GetObject("Search.BackgroundImage"), System.Drawing.Image)
        Me.Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search.ForeColor = System.Drawing.Color.SeaGreen
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Image)
        Me.Search.Location = New System.Drawing.Point(271, 15)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(250, 42)
        Me.Search.TabIndex = 0
        Me.Search.text = "Enter Text"
        '
        'Search_Button
        '
        Me.Search_Button.ActiveBorderThickness = 1
        Me.Search_Button.ActiveCornerRadius = 20
        Me.Search_Button.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.Search_Button.ActiveForecolor = System.Drawing.Color.White
        Me.Search_Button.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.Search_Button.BackColor = System.Drawing.SystemColors.Control
        Me.Search_Button.BackgroundImage = CType(resources.GetObject("Search_Button.BackgroundImage"), System.Drawing.Image)
        Me.Search_Button.ButtonText = "Search"
        Me.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Search_Button.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button.ForeColor = System.Drawing.Color.SeaGreen
        Me.Search_Button.IdleBorderThickness = 1
        Me.Search_Button.IdleCornerRadius = 20
        Me.Search_Button.IdleFillColor = System.Drawing.Color.White
        Me.Search_Button.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.Search_Button.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.Search_Button.Location = New System.Drawing.Point(293, 65)
        Me.Search_Button.Margin = New System.Windows.Forms.Padding(5)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(181, 41)
        Me.Search_Button.TabIndex = 1
        Me.Search_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(63, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(658, 229)
        Me.Panel1.TabIndex = 2
        '
        'eBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Search_Button)
        Me.Controls.Add(Me.Search)
        Me.Name = "eBooks"
        Me.Size = New System.Drawing.Size(824, 366)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Search As ns1.BunifuTextbox
    Friend WithEvents Search_Button As ns1.BunifuThinButton2
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
