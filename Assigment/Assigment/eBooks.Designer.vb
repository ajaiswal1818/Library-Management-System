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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Search = New System.Windows.Forms.RichTextBox()
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(98, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(673, 416)
        Me.Panel1.TabIndex = 2
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(233, 98)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(317, 37)
        Me.Search.TabIndex = 3
        Me.Search.Text = ""
        '
        'Search_Button
        '
        Me.Search_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Search_Button.FlatAppearance.BorderSize = 0
        Me.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search_Button.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button.ForeColor = System.Drawing.Color.Snow
        Me.Search_Button.Location = New System.Drawing.Point(582, 112)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(156, 23)
        Me.Search_Button.TabIndex = 4
        Me.Search_Button.Text = "Search"
        Me.Search_Button.UseVisualStyleBackColor = False
        '
        'eBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Search_Button)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "eBooks"
        Me.Size = New System.Drawing.Size(869, 740)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Search As System.Windows.Forms.RichTextBox
    Friend WithEvents Search_Button As System.Windows.Forms.Button

End Class
