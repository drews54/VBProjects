Option Explicit On

Public Class frmRev
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Long, strT2 As String, digit As Byte
        If Not IsNumeric(TextBox1.Text) Then
            TextBox2.Text = "Error"
            MsgBox("Input a number", vbCritical, "Input Error")
            Exit Sub
        End If
        TextBox1.Text = CStr(CLng(TextBox1.Text))
        strT2 = String.Empty
        a = CLng(TextBox1.Text)
        Do
            digit = a Mod 10
            a \= 10
            strT2 += CStr(digit)
        Loop While a <> 0
        TextBox2.Text = strT2
    End Sub
End Class
