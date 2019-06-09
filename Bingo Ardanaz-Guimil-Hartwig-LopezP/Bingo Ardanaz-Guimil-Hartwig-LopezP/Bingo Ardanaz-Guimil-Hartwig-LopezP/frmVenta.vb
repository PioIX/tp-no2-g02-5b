Public Class frmVenta
    Private Sub btnVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnVolver.KeyPress
        Select Case e.KeyChar

            Case "c", "C"
                Me.Hide()
                frmTablero.Show()
        End Select
    End Sub

    Private Sub frmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class