Public Class frmDynArrFib
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i%, n%, gr1!, gr2!
        Dim F#()

        If Not IsNumeric(TextBox1.Text) Then
            TextBox2.Clear() : TextBox3.Clear() : TextBox4.Clear()
            MsgBox("Input a nonnegative integer number", vbCritical, "Input Error")
            TextBox1.Select()
            Exit Sub
        End If

        TextBox1.Text = CInt(TextBox1.Text)
        n = TextBox1.Text
        If n < 0 Then
            n = 0
            TextBox1.Text = n
        End If

        ReDim F(n)

        For i = 0 To n
            Select Case i
                'Case 0
                '    F(i) = 0
                'Case 1
                '    F(i) = 1
                Case 0, 1
                    F(i) = i
                Case Else
                    F(i) = F(i - 1) + F(i - 2)
            End Select
        Next
    End Sub
End Class
