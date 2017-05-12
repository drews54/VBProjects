Public Class frmDynArrMarks
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim student$(), n%, s$, mark%()

        n = -1
        Do
            n += 1
            s = InputBox($"Input Name({n + 1})", "Students' Names Input")
            ReDim Preserve student(n)
            student(n) = s
        Loop Until s = String.Empty

        n -= 1
        If n <= -1 Then
            TextBox1.Text = "No students"
            Exit Sub
        End If
        ReDim Preserve student(n)
        ReDim Preserve mark(n)
    End Sub
End Class
