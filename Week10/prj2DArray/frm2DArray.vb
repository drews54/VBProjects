﻿Public Class frm2DArray
#Region "Deprecated code (not used in build)"
    'The following code is an example of VB5/6 possibilities.
    'VB.NET, however, does not support changing lower bound of arrays,
    'so there will be a workaround later in the code.
    'Const MIN_B As Integer = 2
    'Const MAX_B As Integer = 9
    'Dim a%(MIN_B To MAX_B, MIN_B To MAX_B)
#End Region
    Const MIN_B As Integer = 0
    Const MAX_B As Integer = 7
    Dim a%(MIN_B To MAX_B, MIN_B To MAX_B)
    Dim i%, j%

    Private Sub frm2DArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = MIN_B To MAX_B
            For j = MIN_B To MAX_B
                a(i, j) = (i + 2) * (j + 2) 'A workaround for deprecated code on line 2
            Next j
        Next i
    End Sub
End Class
