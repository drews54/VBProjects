'Option Base 1 'Appears to be excluded from VB.NET - thanks CLS!

Public Class frmArrayInit
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim A(1 To 5) As String 'Apparently you cannot declare arrays beginning with anything but 0. Once again - thanks CLS!
        Dim A(0 To 4) As String 'This is a 0 to 4 array of strings - we will have to deal with that.
        Dim i As Integer, strA As String
        For i = 0 To 4
            A(i) = InputBox($"Input name({i})", "Students' names initialization")
        Next i
        'A(i) = "Nikolaj"
        strA = String.Empty
        For i = 0 To 4
            strA += A(i) + vbCrLf
        Next i
        TextBox1.Text = strA
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim A(4) As String
        Dim i%, strA$
        A(0) = "Spoilers"
        A(1) = "Flaps"
        A(2) = "Slats"
        A(3) = "Ailerons"
        A(4) = "Winglets"
        strA = String.Empty
        For i = 0 To 4
            strA += A(i) + vbCrLf
        Next i
        TextBox2.Text = strA
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim A$(4), B
        Dim i%, strA$
        B = {"Spoilers", "Flaps", "Slats", "Ailerons", "Winglets"} 'B is actually an Object type which boxes an Array (also has new init syntax).
        For i = 0 To 4
            A(i) = B(i)
        Next i
        strA = String.Empty
        For i = 0 To 4
            strA += A(i) + vbCrLf
        Next i
        TextBox3.Text = strA
    End Sub
End Class
