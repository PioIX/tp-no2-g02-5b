Public Class frmTablero
    Dim Estado As Single
    Dim Boton(90) As Button
    Dim i, j As Integer
    Private Borrado As Boolean
    Dim X = 20, Y = 120
    Private Sub frmTablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 1050
        Me.Height = 850
        lblBorrar.Visible = False
        Borrado = False
        j = 1
        Botones()
    End Sub
    Private Sub Botones()
        For i = 1 To 90
            Boton(i) = New Button()
            Me.Controls.Add(Boton(i))
            If X > 1000 Then
                X = 20
                Y = Y + 75
            End If
            Boton(i).Visible = True
            Boton(i).Text = i
            Boton(i).Height = 75
            Boton(i).Width = 100
            Boton(i).Top = Y
            Boton(i).Left = X
            Boton(i).Tag = i
            Boton(i).BackColor = Color.White
            Boton(i).Font = New Font("Calibri", 18)
            If i < 10 Then
                Boton(i).Text = "0" & i
            End If
            X = X + 100
        Next
    End Sub
End Class
