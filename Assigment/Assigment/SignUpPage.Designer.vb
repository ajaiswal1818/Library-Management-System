<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUpPage
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
        Me.sign_label = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.RichTextBox()
        Me.LastName = New System.Windows.Forms.RichTextBox()
        Me.RollNo = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'sign_label
        '
        Me.sign_label.AutoSize = True
        Me.sign_label.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sign_label.Location = New System.Drawing.Point(212, 34)
        Me.sign_label.Name = "sign_label"
        Me.sign_label.Size = New System.Drawing.Size(321, 39)
        Me.sign_label.TabIndex = 0
        Me.sign_label.Text = "Create an account"
        '
        'FirstName
        '
        Me.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FirstName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstName.ForeColor = System.Drawing.Color.Silver
        Me.FirstName.Location = New System.Drawing.Point(219, 89)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(177, 25)
        Me.FirstName.TabIndex = 1
        Me.FirstName.Text = "First Name"
        '
        'LastName
        '
        Me.LastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LastName.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastName.ForeColor = System.Drawing.Color.Silver
        Me.LastName.Location = New System.Drawing.Point(416, 89)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(177, 25)
        Me.LastName.TabIndex = 2
        Me.LastName.Text = "Last Name"
        '
        'RollNo
        '
        Me.RollNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RollNo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollNo.ForeColor = System.Drawing.Color.Silver
        Me.RollNo.Location = New System.Drawing.Point(219, 146)
        Me.RollNo.Name = "RollNo"
        Me.RollNo.Size = New System.Drawing.Size(177, 25)
        Me.RollNo.TabIndex = 3
        Me.RollNo.Text = "Roll Number"
        '
        'SignUpPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.RollNo)
        Me.Controls.Add(Me.LastName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.sign_label)
        Me.Name = "SignUpPage"
        Me.Size = New System.Drawing.Size(824, 366)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sign_label As System.Windows.Forms.Label
    Friend WithEvents FirstName As System.Windows.Forms.RichTextBox
    Friend WithEvents LastName As System.Windows.Forms.RichTextBox
    Friend WithEvents RollNo As System.Windows.Forms.RichTextBox

End Class
