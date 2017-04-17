Public Class frmSeasons
    Private Sub cmdMS_Click(sender As Object, e As EventArgs) Handles cmdMS.Click
        Dim intMonth As Integer, blnMonth As Boolean, strSeason As String

        blnMonth = IsNumeric(txtMonth.Text)
        If Not blnMonth Then
            strSeason = "Error"
            MsgBox("Input a correct number",
                   vbCritical,
                   "Input Error")
            Exit Sub
        End If
        txtMonth.Text = CStr(CInt(txtMonth.Text))
        intMonth = CInt(txtMonth.Text)
        strSeason = "The season is "
        'If intMonth = 12 Or intMonth = 1 Or intMonth = 2 Then
        '    strSeason += "winter"
        'End If
        'If intMonth = 3 Or intMonth = 4 Or intMonth = 5 Then
        '    strSeason += "spring"
        'End If
        'If intMonth = 6 Or intMonth = 7 Or intMonth = 8 Then
        '    strSeason += "summer"
        'End If
        'If intMonth = 9 Or intMonth = 10 Or intMonth = 11 Then
        '    strSeason += "fall"
        'End If
        'If intMonth < 1 Or intMonth > 12 Then strSeason = "Not a season"
        '------------------------------------------------------
        'If intMonth = 12 Or intMonth = 1 Or intMonth = 2 Then
        '    strSeason += "winter"
        'ElseIf intMonth = 3 Or intMonth = 4 Or intMonth = 5 Then
        '    strSeason += "spring"
        'ElseIf intMonth = 6 Or intMonth = 7 Or intMonth = 8 Then
        '    strSeason += "summer"
        'ElseIf intMonth = 9 Or intMonth = 10 Or intMonth = 11 Then
        '    strSeason += "fall"
        '    'ElseIf intMonth < 1 Or intMonth > 12 Then
        'Else
        '    strSeason = "Not a season"
        'End If
        '------------------------------------------------------
        Select Case intMonth
            Case 1, 2, 12
                strSeason += "winter"
                'Case 3, 4, 5
            Case 3 To 5
                strSeason += "spring"
                'Case 6, 7, 8
            Case 6 To 8
                strSeason += "summer"
                'Case 9, 10, 11
            Case 9 To 11
                strSeason += "fall"
                'Case Is < 1, Is > 12
            Case Else
                MsgBox("Input the number of a month",
                       vbExclamation,
                       "Input Error")
                strSeason = "Not a season"
        End Select

        txtSeason.Text = strSeason
        txtMonth.Focus()
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtMonth.Clear()
        txtSeason.Clear()
    End Sub
End Class
