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
        Me.lblRet1 = New System.Windows.Forms.Label()
        Me.btnRet1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblBklt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRet1
        '
        Me.lblRet1.AutoSize = True
        Me.lblRet1.BackColor = System.Drawing.Color.White
        Me.lblRet1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRet1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRet1.Location = New System.Drawing.Point(194, 188)
        Me.lblRet1.Name = "lblRet1"
        Me.lblRet1.Size = New System.Drawing.Size(67, 23)
        Me.lblRet1.TabIndex = 22
        Me.lblRet1.Text = "Label1"
        '
        'btnRet1
        '
        Me.btnRet1.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet1.Location = New System.Drawing.Point(58, 218)
        Me.btnRet1.Name = "btnRet1"
        Me.btnRet1.Size = New System.Drawing.Size(81, 61)
        Me.btnRet1.TabIndex = 23
        Me.btnRet1.Text = "Return Book"
        Me.btnRet1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(244, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(385, 49)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Your Current Books"
        '
        'lblBklt
        '
        Me.lblBklt.AutoSize = True
        Me.lblBklt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBklt.Location = New System.Drawing.Point(54, 143)
        Me.lblBklt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBklt.Name = "lblBklt"
        Me.lblBklt.Size = New System.Drawing.Size(117, 23)
        Me.lblBklt.TabIndex = 25
        Me.lblBklt.Text = "Issue Books"
        '
        'BooksIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblBklt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRet1)
        Me.Controls.Add(Me.lblRet1)
        Me.Name = "BooksIssued"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRet1 As System.Windows.Forms.Label
    Friend WithEvents btnRet1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblBklt As System.Windows.Forms.Label

End Class
