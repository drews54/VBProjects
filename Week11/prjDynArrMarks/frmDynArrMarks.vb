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

        Dim i%
        For i = LBound(mark) To UBound(mark)
            s = InputBox($"Input the mark for {student(i)}", "Students' Marks Input")
            If Not IsNumeric(s) Or Len(s) > 4 Then
                TextBox1.Text = "Not a mark"
                Exit Sub
            End If
            mark(i) = CInt(s)
        Next

        TextBox1.Clear()
        For i = LBound(mark) To UBound(mark)
            TextBox1.Text += student(i) + Space(4) + CStr(mark(i)) + vbCrLf
        Next
        TextBox1.Text += vbCrLf
    End Sub
End Class
