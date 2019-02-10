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
        Me.lblSrch2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.srchTxt = New System.Windows.Forms.RichTextBox()
        Me.Srchcbx = New System.Windows.Forms.ComboBox()
        Me.details = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'removeBtn
        '
        Me.removeBtn.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBtn.Location = New System.Drawing.Point(493, 264)
        Me.removeBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Size = New System.Drawing.Size(62, 29)
        Me.removeBtn.TabIndex = 26
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.UseVisualStyleBackColor = True
        '
        'lblSrch2
        '
        Me.lblSrch2.AutoSize = True
        Me.lblSrch2.BackColor = System.Drawing.Color.White
        Me.lblSrch2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSrch2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSrch2.Location = New System.Drawing.Point(105, 217)
        Me.lblSrch2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSrch2.Name = "lblSrch2"
        Me.lblSrch2.Size = New System.Drawing.Size(57, 21)
        Me.lblSrch2.TabIndex = 25
        Me.lblSrch2.Text = "Label1"
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(538, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 24)
        Me.btnSearch.TabIndex = 24
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
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
        'details
        '
        Me.details.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.details.Location = New System.Drawing.Point(493, 217)
        Me.details.Margin = New System.Windows.Forms.Padding(2)
        Me.details.Name = "details"
        Me.details.Size = New System.Drawing.Size(62, 29)
        Me.details.TabIndex = 27
        Me.details.Text = "Details"
        Me.details.UseVisualStyleBackColor = True
        '
        'remove_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.details)
        Me.Controls.Add(Me.removeBtn)
        Me.Controls.Add(Me.lblSrch2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.srchTxt)
        Me.Controls.Add(Me.Srchcbx)
        Me.Name = "remove_detail"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents removeBtn As System.Windows.Forms.Button
    Friend WithEvents lblSrch2 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents srchTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Srchcbx As System.Windows.Forms.ComboBox
    Friend WithEvents details As System.Windows.Forms.Button

End Class
