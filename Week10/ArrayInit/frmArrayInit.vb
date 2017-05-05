Public Class frmArrayInit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim A(1 To 5) As String 'Apparently you cannot declare arrays beginning with anything but 0 - thanks CLS!
        Dim A(4) As String 'This is a 0 to 4 array of strings
        Dim i As Integer, strA As String
        For i = 0 To 4
            A(i) = InputBox($"Input name({i})", "Students' names initialization")
        Next i
        strA = String.Empty
        For i = 0 To 4
            strA += A(i) + vbCrLf
        Next i
        TextBox1.Text = strA
    End Sub
End Class
