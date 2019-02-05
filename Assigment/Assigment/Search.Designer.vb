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
        Me.pnlSrch = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlSrch1 = New System.Windows.Forms.Panel()
        Me.lblSrch1 = New System.Windows.Forms.Label()
        Me.dgvSrch = New System.Windows.Forms.DataGridView()
        Me.pnlSrch.SuspendLayout()
        Me.pnlSrch1.SuspendLayout()
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtSrch
        '
        Me.txtSrch.Location = New System.Drawing.Point(289, 64)
        Me.txtSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(421, 45)
        Me.txtSrch.TabIndex = 16
        Me.txtSrch.Text = ""
        '
        'SearchBtn
        '
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(765, 81)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(208, 28)
        Me.SearchBtn.TabIndex = 17
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'pnlSrch
        '
        Me.pnlSrch.Controls.Add(Me.dgvSrch)
        Me.pnlSrch.Controls.Add(Me.pnlSrch1)
        Me.pnlSrch.Location = New System.Drawing.Point(151, 166)
        Me.pnlSrch.Name = "pnlSrch"
        Me.pnlSrch.Size = New System.Drawing.Size(787, 272)
        Me.pnlSrch.TabIndex = 18
        '
        'pnlSrch1
        '
        Me.pnlSrch1.Controls.Add(Me.lblSrch1)
        Me.pnlSrch1.Location = New System.Drawing.Point(3, 159)
        Me.pnlSrch1.Name = "pnlSrch1"
        Me.pnlSrch1.Size = New System.Drawing.Size(772, 149)
        Me.pnlSrch1.TabIndex = 0
        '
        'lblSrch1
        '
        Me.lblSrch1.AutoSize = True
        Me.lblSrch1.Location = New System.Drawing.Point(166, 63)
        Me.lblSrch1.Name = "lblSrch1"
        Me.lblSrch1.Size = New System.Drawing.Size(51, 17)
        Me.lblSrch1.TabIndex = 0
        Me.lblSrch1.Text = "Label1"
        '
        'dgvSrch
        '
        Me.dgvSrch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSrch.Location = New System.Drawing.Point(3, 3)
        Me.dgvSrch.Name = "dgvSrch"
        Me.dgvSrch.RowTemplate.Height = 24
        Me.dgvSrch.Size = New System.Drawing.Size(772, 150)
        Me.dgvSrch.TabIndex = 1
        '
        'Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlSrch)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbxSrch)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Search"
        Me.Size = New System.Drawing.Size(1099, 450)
        Me.pnlSrch.ResumeLayout(False)
        Me.pnlSrch1.ResumeLayout(False)
        Me.pnlSrch1.PerformLayout()
        CType(Me.dgvSrch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSrch As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSrch As System.Windows.Forms.RichTextBox
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents pnlSrch As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlSrch1 As System.Windows.Forms.Panel
    Friend WithEvents lblSrch1 As System.Windows.Forms.Label
    Friend WithEvents dgvSrch As System.Windows.Forms.DataGridView

End Class
