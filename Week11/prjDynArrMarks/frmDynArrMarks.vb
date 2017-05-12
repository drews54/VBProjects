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
    End Sub
End Class
