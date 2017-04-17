Public Class frmFunction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const X_MAX As Double = 10 ^ 100
        Dim x, y As Double

        If Not IsNumeric(TextBox1.Text) Then
            TextBox2.Clear()
            TextBox3.Clear()
            MsgBox("Input a correct number",
                   vbCritical,
                   "Input Error")
            Exit Sub
        End If
        x = CDbl(TextBox1.Text)
        'If x > X_MAX Or x < -X_MAX Then
        '    If x >= 0 Then
        '        x = X_MAX
        '    Else
        '        x = -X_MAX
        '    End If
        '    TextBox1.Text = CStr(x)
        'End If
        If Math.Abs(x) > X_MAX Then
            x = Math.Sign(x) * X_MAX
            TextBox1.Text = CStr(x)
        End If
        'y = x
        'If x < 1 Then
        '    y = Math.Sign(x) * x ^ 2
        'ElseIf x >= 1 And x < 3 Then
        '    y = 2 / (1 + Math.Abs(2 - x)) / x
        'ElseIf x >= 3 And x < 11 Then
        '    y = 1 / 3 * Math.Sqrt(x - 2)
        '    'ElseIf x >= 11 Then
        'Else
        '    y = Math.Exp(3 * Math.Log(x - 10))
        'End If
        'Select Case x
        '    Case Is < 1
        '        y = Math.Sign(x) * x ^ 2
        '    Case 1 To 3
        '        y = 2 / ((1 + Math.Abs(2 - x)) * x)
        '    Case 3 To 11
        '        y = Math.Sqrt(x - 2) / 3
        '    Case Else
        '        y = Math.Exp(3 * Math.Log(x - 10))
        'End Select
        Select Case True
            Case x < 1
                y = Math.Sign(x) * x ^ 2
            Case x >= 1 And x < 3
                y = 2 / (1 + Math.Abs(2 - x)) / x
            Case x >= 3 And x < 11
                y = 1 / 3 * Math.Sqrt(x - 2)
            Case Else
                y = (x - 10) ^ 3
        End Select
        TextBox2.Text = Format(y, "0.000")
        TextBox3.Text = Format(y, "scientific")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
