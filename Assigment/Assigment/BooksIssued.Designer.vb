﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lblissue1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblissue1
        '
        Me.lblissue1.AutoSize = True
        Me.lblissue1.BackColor = System.Drawing.Color.White
        Me.lblissue1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblissue1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblissue1.Location = New System.Drawing.Point(194, 188)
        Me.lblissue1.Name = "lblissue1"
        Me.lblissue1.Size = New System.Drawing.Size(67, 23)
        Me.lblissue1.TabIndex = 22
        Me.lblissue1.Text = "Label1"
        '
        'BooksIssued
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblissue1)
        Me.Name = "BooksIssued"
        Me.Size = New System.Drawing.Size(852, 700)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblissue1 As System.Windows.Forms.Label

End Class
