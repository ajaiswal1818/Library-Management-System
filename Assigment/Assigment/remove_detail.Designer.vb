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
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.lblSrch1 = New System.Windows.Forms.Label()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.txtSrch = New System.Windows.Forms.RichTextBox()
        Me.cbxSrch = New System.Windows.Forms.ComboBox()
        Me.details = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'removeBtn
        '
        Me.removeBtn.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBtn.Location = New System.Drawing.Point(140, 306)
        Me.removeBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(83, 36)
        Me.removeBtn.TabIndex = 26
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'lblSrch1
        '
        Me.lblSrch1.AutoSize = True
        Me.lblSrch1.BackColor = System.Drawing.Color.White
        Me.lblSrch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSrch1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrch1.Location = New System.Drawing.Point(140, 267)
        Me.lblSrch1.Name = "lblSrch1"
        Me.lblSrch1.Size = New System.Drawing.Size(67, 23)
        Me.lblSrch1.TabIndex = 25
        Me.lblSrch1.Text = "Label1"
        '
        'SearchBtn
        '
        Me.SearchBtn.FlatAppearance.BorderSize = 0
        Me.SearchBtn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(717, 144)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(107, 30)
        Me.SearchBtn.TabIndex = 24
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'txtSrch
        '
        Me.txtSrch.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSrch.Location = New System.Drawing.Point(249, 144)
        Me.txtSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSrch.Name = "txtSrch"
        Me.txtSrch.Size = New System.Drawing.Size(421, 29)
        Me.txtSrch.TabIndex = 23
        Me.txtSrch.Text = ""
        '
        'cbxSrch
        '
        Me.cbxSrch.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSrch.FormattingEnabled = True
        Me.cbxSrch.Location = New System.Drawing.Point(90, 144)
        Me.cbxSrch.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxSrch.Name = "cbxSrch"
        Me.cbxSrch.Size = New System.Drawing.Size(116, 28)
        Me.cbxSrch.TabIndex = 22
        '
        'details
        '
        Me.details.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.details.Location = New System.Drawing.Point(244, 306)
        Me.details.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(83, 36)
        Me.details.TabIndex = 27
        Me.details.Text = "Details"
        Me.details.UseVisualStyleBackColor = True
        '
        'remove_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.details)
        Me.Controls.Add(Me.removeBtn)
        Me.Controls.Add(Me.lblSrch1)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.txtSrch)
        Me.Controls.Add(Me.cbxSrch)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "remove_detail"
        Me.Size = New System.Drawing.Size(1136, 862)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents removeBtn As System.Windows.Forms.Button
    Friend WithEvents lblSrch1 As System.Windows.Forms.Label
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents txtSrch As System.Windows.Forms.RichTextBox
    Friend WithEvents cbxSrch As System.Windows.Forms.ComboBox
    Friend WithEvents details As System.Windows.Forms.Button

End Class
