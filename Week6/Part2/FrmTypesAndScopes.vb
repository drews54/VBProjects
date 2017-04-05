Option Explicit On

Public Class FrmTypesAndScopes
    Const V_MAX_KNOTS As Double = 5000
    Dim Vknots As Double, Vkmh As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Static n As Byte
        Vknots = Val(InputBox("Velocity in knots:", "Input"))
        If Vknots < 0 Then Vknots = -Vknots
        If Vknots > V_MAX_KNOTS Then Vknots = V_MAX_KNOTS
        TextBox1.Text = Format(Vknots, "0.0")
        Vknots = Val(TextBox1.Text)
        Button3.Focus()
        n += 1
        If n >= 3 Then Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Vknots = Val(TextBox1.Text)
        If Vknots < 0 Then Vknots = -Vknots
        If Vknots > V_MAX_KNOTS Then Vknots = V_MAX_KNOTS
        TextBox1.Text = Format(Vknots, "0.0")
        Vknots = Val(TextBox1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Const C1 As Single = 1.852
        Vkmh = C1 * Vknots
        TextBox2.Text = Format(Vkmh, "0.0")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Const C2 As Single = 1000 / 3600, C3! = 0.305 / 60
        Dim Vms!
        Vms = Vkmh * C2
        TextBox3.Text = Format(Vms, "0.0")
        Vfm = CLng(Vms / C3)
        TextBox1.Focus()
        FrmFeet.Show()
    End Sub

    Public Vfm As Long
End Class
