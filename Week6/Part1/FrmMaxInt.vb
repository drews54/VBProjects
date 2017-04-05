Public Class FrmMaxInt
    Dim a%, b%, c%, max%
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim a%, b%, c%, max%

        TextBox1.Text = CStr(CInt(Val(TextBox1.Text)))
        TextBox2.Text = CStr(CInt(Val(TextBox2.Text)))
        TextBox3.Text = CStr(CInt(Val(TextBox3.Text)))
        a = CInt(TextBox1.Text)
        b = CInt(TextBox2.Text)
        c = CInt(TextBox3.Text)

        'If a > b Then max = a
        'If a < b Then max = b
        '---------------------------------------------
        'If a >= b Then max = a
        'If a < b Then max = b
        '---------------------------------------------
        'If a >= b Then
        '    max = a
        'Else
        '    max = b
        'End If
        '---------------------------------------------
        'If a >= b Then
        '    If a >= c Then
        '        max = a
        '    Else
        '        max = c
        '    End If
        'Else
        '    If b >= c Then
        '        max = b
        '    Else
        '        max = c
        '    End If
        'End If
        '---------------------------------------------
        'If a >= b And a >= c Then max = a
        'If b >= a And b >= c Then max = b
        'If c >= a And c >= b Then max = c
        '---------------------------------------------
        max = a
        If b > max Then max = b
        If c > max Then max = c

        TextBox4.Text = CStr(max)
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'Dim a%
        TextBox1.Text = CStr(CInt(Val(TextBox1.Text)))
        a = CInt(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'Dim b%
        TextBox2.Text = CStr(CInt(Val(TextBox2.Text)))
        b = CInt(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        'Dim c%
        TextBox3.Text = CStr(CInt(Val(TextBox3.Text)))
        c = CInt(TextBox3.Text)
    End Sub
End Class
