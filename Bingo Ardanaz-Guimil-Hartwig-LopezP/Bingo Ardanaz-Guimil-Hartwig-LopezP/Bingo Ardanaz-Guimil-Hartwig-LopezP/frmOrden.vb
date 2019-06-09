Public Class frmOrden
    Private Sub frmOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = NumeroSeleccionado
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        frmTablero.Show()
        Me.Close()
    End Sub

    Private Sub btnVolver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnVolver.KeyPress
        Select Case e.KeyChar
            Case "c", "C"
                Me.Close()
                frmTablero.Show()
        End Select
    End Sub
End Class