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
        Me.cbxSrch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSrch = New System.Windows.Forms.RichTextBox()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.dgvSrch = New System.Windows.Forms.DataGridView()
        Me.lblSrch1 = New System.Windows.Forms.Label()
        Me.btnSrch1 = New System.Windows.Forms.Button()
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSrch
        '
        Me.cbxSrch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSrch.FormattingEnabled = True
        Me.cbxSrch.Location = New System.Drawing.Point(30, 72)
        Me.cbxSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxSrch.Name = "cbxSrch"
        Me.cbxSrch.Size = New System.Drawing.Size(116, 28)
        Me.cbxSrch.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(360, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Text to Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(44, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Keyword"
        '
        'txtSrch
        '
        Me.txtSrch.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrch.Location = New System.Drawing.Point(188, 72)
        Me.txtSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(421, 28)
        Me.txtSrch.TabIndex = 16
        Me.txtSrch.Text = ""
        '
        'SearchBtn
        '
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(656, 72)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(107, 29)
        Me.SearchBtn.TabIndex = 17
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'dgvSrch
        '
        Me.dgvSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSrch.Location = New System.Drawing.Point(113, 138)
        Me.dgvSrch.Name = "dgvSrch"
        Me.dgvSrch.RowTemplate.Height = 24
        Me.dgvSrch.Size = New System.Drawing.Size(623, 150)
        Me.dgvSrch.TabIndex = 19
        '
        'lblSrch1
        '
        Me.lblSrch1.AutoSize = True
        Me.lblSrch1.BackColor = System.Drawing.Color.White
        Me.lblSrch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSrch1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrch1.Location = New System.Drawing.Point(113, 319)
        Me.lblSrch1.Name = "lblSrch1"
        Me.lblSrch1.Size = New System.Drawing.Size(67, 23)
        Me.lblSrch1.TabIndex = 20
        Me.lblSrch1.Text = "Label1"
        '
        'btnSrch1
        '
        Me.btnSrch1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrch1.Location = New System.Drawing.Point(30, 351)
        Me.btnSrch1.Name = "btnSrch1"
        Me.btnSrch1.Size = New System.Drawing.Size(68, 61)
        Me.btnSrch1.TabIndex = 21
        Me.btnSrch1.Text = "Issue Now!"
        Me.btnSrch1.UseVisualStyleBackColor = True
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.btnSrch1)
        Me.Controls.Add(Me.lblSrch1)
        Me.Controls.Add(Me.dgvSrch)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxSrch)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Search"
        Me.Size = New System.Drawing.Size(852, 700)
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSrch As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSrch As System.Windows.Forms.RichTextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents dgvSrch As System.Windows.Forms.DataGridView
    Friend WithEvents lblSrch1 As System.Windows.Forms.Label
    Friend WithEvents btnSrch1 As System.Windows.Forms.Button

End Class
