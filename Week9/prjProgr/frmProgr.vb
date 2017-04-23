Public Class frmProgr
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a%, sum%, strProgr$
        'a = 1
        sum = 0
        strProgr = vbEmpty
        'Do While a <= 5
        'Do 'Until a > 5
        For a = 1 To 5 Step 1
            sum += a
            strProgr +=
                "a = " + CStr(a) + Space(6) +
                "sum = " + CStr(sum) + vbCrLf
        Next a
        'a += 1
        'If a > 5 Then
        '    Exit Do
        'End If
        'Loop Until a > 5
        'Loop While a <= 5
        TextBox1.Text = strProgr
    End Sub
End Class
