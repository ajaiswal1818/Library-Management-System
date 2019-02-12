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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reco))
        Me.btn_del1 = New System.Windows.Forms.Button()
        Me.lbl_rec1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tempRec1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_del1
        '
        Me.btn_del1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btn_del1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del1.ForeColor = System.Drawing.Color.Snow
        Me.btn_del1.Location = New System.Drawing.Point(103, 186)
        Me.btn_del1.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_del1.Name = "btn_del1"
        Me.btn_del1.Size = New System.Drawing.Size(137, 57)
        Me.btn_del1.TabIndex = 32
        Me.btn_del1.Text = "Delete Recommendation"
        Me.btn_del1.UseVisualStyleBackColor = False
        '
        'lbl_rec1
        '
        Me.lbl_rec1.AutoSize = True
        Me.lbl_rec1.BackColor = System.Drawing.Color.Snow
        Me.lbl_rec1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rec1.Location = New System.Drawing.Point(302, 186)
        Me.lbl_rec1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_rec1.Name = "lbl_rec1"
        Me.lbl_rec1.Size = New System.Drawing.Size(55, 19)
        Me.lbl_rec1.TabIndex = 31
        Me.lbl_rec1.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 58)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Current Recommendations"
        '
        'tempRec1
        '
        Me.tempRec1.AutoSize = True
        Me.tempRec1.BackColor = System.Drawing.Color.Transparent
        Me.tempRec1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempRec1.Location = New System.Drawing.Point(25, 120)
        Me.tempRec1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tempRec1.Name = "tempRec1"
        Me.tempRec1.Size = New System.Drawing.Size(55, 19)
        Me.tempRec1.TabIndex = 34
        Me.tempRec1.Text = "Label1"
        Me.tempRec1.Visible = False
        '
        'reco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.tempRec1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_del1)
        Me.Controls.Add(Me.lbl_rec1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "reco"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Size = New System.Drawing.Size(869, 740)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_del1 As System.Windows.Forms.Button
    Friend WithEvents lbl_rec1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tempRec1 As System.Windows.Forms.Label

End Class
