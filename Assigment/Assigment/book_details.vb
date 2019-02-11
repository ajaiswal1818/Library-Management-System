Public Class book_details
    Private Access As New LMS
    Public Sub load_content(Op1 As String, BkIss As String)

        Op1 &= "Books Issued to: "
        Dim Iss As String() = Split(BkIss, "-")
        For Each temp As String In Iss
            Try
                If IsNumeric(temp) = True Then
                    Dim num As Integer = CInt(temp)
                    'MessageBox.Show(num)
                    If num = 0 Then
                        Continue For
                    End If
                    Access.ExecQuery("Select Title from Users where [ID]=" & num)
                    If Not String.IsNullOrEmpty(Access.Exception) Then MsgBox(Access.Exception) : Exit Sub
                    If Access.DBDT.Rows.Count = 1 Then
                        Op1 &= Access.DBDT.Rows(0).Item(0) & "; "
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Could not convert to integer", "Ërror")
                Console.Write("Could not convert to integer")
            End Try
        Next
        lbl_bookContent.Text = Op1

        Access.ExecQuery("")
    End Sub

End Class
