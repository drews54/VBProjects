Public Class frm2DArray
#Region "Deprecated code (not used in build, works in VB5/6 only)"
    'Const MIN_B As Integer = 2
    'Const MAX_B As Integer = 9
    'Dim a%(MIN_B To MAX_B, MIN_B To MAX_B)
#End Region
    Const MIN_B As Integer = 0
    Const MAX_B As Integer = 7
    Dim a%(MIN_B To MAX_B, MIN_B To MAX_B)
    Dim i%, j%

    Friend ReadOnly Property MultiplyingTableString
        Get
            Dim s$ = Space(6)
            For j = MIN_B To MAX_B
                s += Format(j + 2, "00") + Space(2)
            Next
            s += vbCrLf

            For i = MIN_B To MAX_B
                s += Format(i + 2, "00") + Space(2)
                For j = MIN_B To MAX_B
                    s += Format(a(i, j), "00") + Space(2)
                Next j
                s += vbCrLf
            Next i
            s += vbCrLf
            Return s
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gr = PictureBox1.CreateGraphics()
        Dim s$ = MultiplyingTableString
        gr.DrawString(s, TextBox1.Font, SystemBrushes.WindowText, New PointF(0.0!, 4.0!))
        gr.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '   Since DrawString method also utilizes similar string for output,
        '   it was taken out of a handler sub and moved into a separate property for reusability.
        TextBox1.Text = MultiplyingTableString
    End Sub

    Private Sub frm2DArray_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = MIN_B To MAX_B
            For j = MIN_B To MAX_B
                a(i, j) = (i + 2) * (j + 2) 'A workaround for deprecated code on line 2
            Next j
        Next i
    End Sub
End Class
