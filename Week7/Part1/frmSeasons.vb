Public Class frmSeasons
    Private Sub cmdMS_Click(sender As Object, e As EventArgs) Handles cmdMS.Click
        Dim intMonth As Integer, blnMonth As Boolean, strSeason As String

        blnMonth = IsNumeric(txtMonth)
        If Not blnMonth Then
            strSeason = "Error"
            MsgBox("Input a correct number",
                   vbCritical,
                   "Input Error")
        Else
            strSeason = "The season is "
        End If
    End Sub
End Class
