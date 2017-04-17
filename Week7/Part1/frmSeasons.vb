Public Class frmSeasons
    Private Sub cmdMS_Click(sender As Object, e As EventArgs) Handles cmdMS.Click
        Dim intMonth As Integer, blnMonth As Boolean, strSeason As String

        blnMonth = IsNumeric(txtMonth)
        If blnMonth Then
            strSeason = "The season is "
        Else
            strSeason ="Error"
            MsgBox("Input a correct number",
                   vbCritical,
                   "Input Error")
        End If
    End Sub
End Class
