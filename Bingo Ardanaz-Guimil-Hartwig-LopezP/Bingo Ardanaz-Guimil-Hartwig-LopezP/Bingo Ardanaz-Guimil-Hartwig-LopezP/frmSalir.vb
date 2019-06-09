Public Class frmSalir
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        frmTablero.Show()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frmTablero.Close()
    End Sub

    Private Sub btnVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnVolver.KeyPress
        Select Case e.KeyChar

            Case "c", "C"
                Me.Hide()
                frmTablero.Show()
            Case "z", "Z"
                Me.Hide()
                frmTablero.Close()
        End Select
    End Sub


End Class