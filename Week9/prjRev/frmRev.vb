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
        GoTo Metka
        a = CLng(TextBox1.Text)
        Do
            digit = a Mod 10
            a \= 10
            strT2 += CStr(digit)
            'Loop While a <> 0
        Loop Until a = 0
Metka:
        Dim n%, strT1$
        strT1 = TextBox1.Text
        For n = Len(strT1) To 1 Step -1
            strT2 += Mid(strT1, n, 1)
        Next
        TextBox2.Text = strT2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
