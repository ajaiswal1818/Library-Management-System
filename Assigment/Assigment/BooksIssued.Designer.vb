<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksIssued
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BooksIssued))
        Me.lblBklt = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRet1 = New System.Windows.Forms.Button()
        Me.lblRet1 = New System.Windows.Forms.Label()
        Me.tempRet1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBklt
        '
        Me.lblBklt.AutoSize = True
        Me.lblBklt.BackColor = System.Drawing.Color.Transparent
        Me.lblBklt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBklt.Location = New System.Drawing.Point(166, 110)
        Me.lblBklt.Name = "lblBklt"
        Me.lblBklt.Size = New System.Drawing.Size(94, 21)
        Me.lblBklt.TabIndex = 29
        Me.lblBklt.Text = "Issue Books"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(258, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(338, 42)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Your Current Books"
        '
        'btnRet1
        '
        Me.btnRet1.BackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnRet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet1.ForeColor = System.Drawing.Color.Snow
        Me.btnRet1.Location = New System.Drawing.Point(40, 187)
        Me.btnRet1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRet1.Name = "btnRet1"
        Me.btnRet1.Size = New System.Drawing.Size(72, 50)
        Me.btnRet1.TabIndex = 27
        Me.btnRet1.Text = "Return Book"
        Me.btnRet1.UseVisualStyleBackColor = False
        '
        'lblRet1
        '
        Me.lblRet1.AutoSize = True
        Me.lblRet1.BackColor = System.Drawing.Color.Snow
        Me.lblRet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRet1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRet1.Location = New System.Drawing.Point(153, 163)
        Me.lblRet1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRet1.Name = "lblRet1"
        Me.lblRet1.Size = New System.Drawing.Size(57, 21)
        Me.lblRet1.TabIndex = 26
        Me.lblRet1.Text = "Label1"
        '
        'tempRet1
        '
        Me.tempRet1.AutoSize = True
        Me.tempRet1.BackColor = System.Drawing.Color.Transparent
        Me.tempRet1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempRet1.Location = New System.Drawing.Point(675, 39)
        Me.tempRet1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.tempRet1.Name = "tempRet1"
        Me.tempRet1.Size = New System.Drawing.Size(55, 19)
        Me.tempRet1.TabIndex = 31
        Me.tempRet1.Text = "Label1"
        Me.tempRet1.Visible = False
        '
        'BooksIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.tempRet1)
        Me.Controls.Add(Me.lblBklt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRet1)
        Me.Controls.Add(Me.lblRet1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "BooksIssued"
        Me.Size = New System.Drawing.Size(869, 740)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBklt As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRet1 As System.Windows.Forms.Button
    Friend WithEvents lblRet1 As System.Windows.Forms.Label
    Friend WithEvents tempRet1 As System.Windows.Forms.Label

End Class
