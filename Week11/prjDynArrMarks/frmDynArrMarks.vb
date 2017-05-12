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

        Dim sum!, aver!
        For Each i In mark
            sum += i
        Next
        aver = sum / mark.Length
        TextBox1.Text += $"The average mark is {FormatNumber(aver, 1)}" + vbCrLf + vbCrLf

        Dim max% = mark(LBound(mark))
        For Each i In mark
            If i > max Then max = i
        Next
        TextBox1.Text += $"The best students with a mark of {max} are:" + vbCrLf
        For i = LBound(mark) To UBound(mark)
            If mark(i) = max Then TextBox1.Text += student(i) + vbCrLf
        Next
    End Sub
End Class
