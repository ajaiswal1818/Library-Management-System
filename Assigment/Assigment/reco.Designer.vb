<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reco
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
        Me.btn_del1 = New System.Windows.Forms.Button()
        Me.lbl_rec1 = New System.Windows.Forms.Label()
        Me.rec_table = New System.Windows.Forms.DataGridView()
        CType(Me.rec_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_del1
        '
        Me.btn_del1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del1.Location = New System.Drawing.Point(73, 426)
        Me.btn_del1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_del1.Name = "btn_del1"
        Me.btn_del1.Size = New System.Drawing.Size(145, 62)
        Me.btn_del1.TabIndex = 32
        Me.btn_del1.Text = "Delete Recommendation"
        Me.btn_del1.UseVisualStyleBackColor = True
        '
        'lbl_rec1
        '
        Me.lbl_rec1.AutoSize = True
        Me.lbl_rec1.BackColor = System.Drawing.Color.White
        Me.lbl_rec1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rec1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rec1.Location = New System.Drawing.Point(275, 426)
        Me.lbl_rec1.Name = "lbl_rec1"
        Me.lbl_rec1.Size = New System.Drawing.Size(67, 23)
        Me.lbl_rec1.TabIndex = 31
        Me.lbl_rec1.Text = "Label1"
        '
        'rec_table
        '
        Me.rec_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rec_table.Location = New System.Drawing.Point(157, 213)
        Me.rec_table.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rec_table.Name = "rec_table"
        Me.rec_table.RowTemplate.Height = 24
        Me.rec_table.Size = New System.Drawing.Size(623, 150)
        Me.rec_table.TabIndex = 30
        '
        'reco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.btn_del1)
        Me.Controls.Add(Me.lbl_rec1)
        Me.Controls.Add(Me.rec_table)
        Me.Name = "reco"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(852, 700)
        CType(Me.rec_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_del1 As System.Windows.Forms.Button
    Friend WithEvents lbl_rec1 As System.Windows.Forms.Label
    Friend WithEvents rec_table As System.Windows.Forms.DataGridView

End Class
