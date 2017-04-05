Option Explicit On

Public Class FrmFeet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim answer%
        answer = MsgBox("End?", vbYesNo + vbQuestion, "Question")
        If answer = vbYes Then
            End
        Else
            MsgBox(CStr(FrmTypesAndScopes.Vfm))
        End If
    End Sub

    Private Sub FrmFeet_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        TextBox1.Text = FrmTypesAndScopes.Vfm
    End Sub
End Class