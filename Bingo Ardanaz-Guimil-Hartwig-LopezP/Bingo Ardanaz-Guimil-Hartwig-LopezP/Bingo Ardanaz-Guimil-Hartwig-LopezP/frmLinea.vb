Public Class frmLinea
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
        frmTablero.Show()
    End Sub
    Private Sub btnVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnVolver.KeyPress
        Select Case e.KeyChar

            Case "c", "C"
                Me.Hide()
                frmTablero.Show()
        End Select
    End Sub


End Class
