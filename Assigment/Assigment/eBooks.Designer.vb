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
        Me.Search_Button = New System.Windows.Forms.Button()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search_Button
        '
        Me.Search_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Search_Button.FlatAppearance.BorderSize = 0
        Me.Search_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search_Button.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_Button.ForeColor = System.Drawing.Color.Snow
        Me.Search_Button.Location = New System.Drawing.Point(61, 111)
        Me.Search_Button.Name = "Search_Button"
        Me.Search_Button.Size = New System.Drawing.Size(156, 23)
        Me.Search_Button.TabIndex = 4
        Me.Search_Button.Text = "Load E-Book"
        Me.Search_Button.UseVisualStyleBackColor = False
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(61, 149)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(751, 546)
        Me.AxAcroPDF1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(296, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 78)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "E-Books"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'eBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.Search_Button)
        Me.Name = "eBooks"
        Me.Size = New System.Drawing.Size(869, 740)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Search_Button As System.Windows.Forms.Button
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
