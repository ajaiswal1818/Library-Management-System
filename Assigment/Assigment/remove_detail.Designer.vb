<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class remove_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(remove_detail))
        Me.btnSrch1 = New System.Windows.Forms.Button()
        Me.lblSrch1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.srchTxt = New System.Windows.Forms.RichTextBox()
        Me.Srchcbx = New System.Windows.Forms.ComboBox()
        Me.btnDel1 = New System.Windows.Forms.Button()
        Me.lbltemp1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSrch1
        '
        Me.btnSrch1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSrch1.Location = New System.Drawing.Point(15, 274)
        Me.btnSrch1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSrch1.Name = "btnSrch1"
        Me.btnSrch1.Size = New System.Drawing.Size(79, 29)
        Me.btnSrch1.TabIndex = 26
        Me.btnSrch1.Text = "Remove"
        Me.btnSrch1.UseVisualStyleBackColor = True
        '
        'lblSrch1
        '
        Me.lblSrch1.AutoSize = True
        Me.lblSrch1.BackColor = System.Drawing.Color.White
        Me.lblSrch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSrch1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrch1.Location = New System.Drawing.Point(105, 217)
        Me.lblSrch1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSrch1.Name = "lblSrch1"
        Me.lblSrch1.Size = New System.Drawing.Size(57, 21)
        Me.lblSrch1.TabIndex = 25
        Me.lblSrch1.Text = "Label1"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Snow
        Me.btnSearch.Location = New System.Drawing.Point(538, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 25)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'srchTxt
        '
        Me.srchTxt.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srchTxt.Location = New System.Drawing.Point(187, 117)
        Me.srchTxt.Name = "srchTxt"
        Me.srchTxt.Size = New System.Drawing.Size(317, 24)
        Me.srchTxt.TabIndex = 23
        Me.srchTxt.Text = ""
        '
        'Srchcbx
        '
        Me.Srchcbx.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Srchcbx.FormattingEnabled = True
        Me.Srchcbx.Location = New System.Drawing.Point(68, 117)
        Me.Srchcbx.Name = "Srchcbx"
        Me.Srchcbx.Size = New System.Drawing.Size(88, 25)
        Me.Srchcbx.TabIndex = 22
        '
        'btnDel1
        '
        Me.btnDel1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel1.Location = New System.Drawing.Point(15, 227)
        Me.btnDel1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDel1.Name = "btnDel1"
        Me.btnDel1.Size = New System.Drawing.Size(79, 29)
        Me.btnDel1.TabIndex = 27
        Me.btnDel1.Text = "Details"
        Me.btnDel1.UseVisualStyleBackColor = True
        '
        'lbltemp1
        '
        Me.lbltemp1.AutoSize = True
        Me.lbltemp1.Location = New System.Drawing.Point(730, 108)
        Me.lbltemp1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltemp1.Name = "lbltemp1"
        Me.lbltemp1.Size = New System.Drawing.Size(39, 13)
        Me.lbltemp1.TabIndex = 29
        Me.lbltemp1.Text = "Label1"
        Me.lbltemp1.Visible = False
        '
        'remove_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lbltemp1)
        Me.Controls.Add(Me.btnDel1)
        Me.Controls.Add(Me.btnSrch1)
        Me.Controls.Add(Me.lblSrch1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.srchTxt)
        Me.Controls.Add(Me.Srchcbx)
        Me.Name = "remove_detail"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSrch1 As System.Windows.Forms.Button
    Friend WithEvents lblSrch1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents srchTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Srchcbx As System.Windows.Forms.ComboBox
    Friend WithEvents btnDel1 As System.Windows.Forms.Button
    Friend WithEvents lbltemp1 As System.Windows.Forms.Label

End Class
