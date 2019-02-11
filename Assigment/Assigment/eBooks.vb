Public Class eBooks


    Private Sub Search_Button_Click(sender As Object, e As EventArgs) Handles Search_Button.Click
        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 39) & "EBook\"

        Me.OpenFileDialog1.FileName = String.Empty
        Me.OpenFileDialog1.InitialDirectory = fullPath
        Me.OpenFileDialog1.ShowDialog()
        Dim file As String = Me.OpenFileDialog1.FileName
        Dim ext As String() = Split(file, ".")
        Dim exten As String = ext(ext.Length - 1)
        If exten = "pdf" Then
            Me.AxAcroPDF1.LoadFile(Me.OpenFileDialog1.FileName)
        Else
            MessageBox.Show("Selected file is not in .pdf format! Try another file!")
        End If


    End Sub
End Class
