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
            AddHandler Boton(i).Click, AddressOf Button_Click
            AddHandler Boton(i).KeyDown, AddressOf frmTablero_KeyDown
        Next
    End Sub
    Private Sub Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        Numero = Integer.Parse(sender.tag)
        If Borrado = False Then

            If Boton(Numero).BackColor = Color.White Then
                If NumeroSeleccionado = "" Then
                    NumeroSeleccionado = NumeroSeleccionado + Convert.ToString(Numero)
                    Boton(Numero).BackColor = Color.Yellow
                Else NumeroSeleccionado = NumeroSeleccionado + "; " + Convert.ToString(Numero)
                    Boton(Numero).BackColor = Color.Yellow
                End If
            End If
            frmNumero.Show()
            Me.Hide()
        Else
            Boton(Numero).BackColor = Color.White
        End If
    End Sub

    Private Sub frmTablero_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim tecla As New System.Windows.Forms.Keys()
        If e.KeyCode = Keys.Z Then
            Me.Hide()
            frmSalir.ShowDialog()
        End If
        If e.KeyCode = Keys.O Then
            Me.Hide()
            frmOrden.ShowDialog()
        End If
        If e.KeyCode = Keys.V Then
            Me.Hide()
            frmVenta.ShowDialog()
        End If
        If e.KeyCode = Keys.L Then
            Me.Hide()
            frmLinea.ShowDialog()
        End If
        If e.KeyCode = Keys.B Then
            Me.Hide()
            frmBingo.ShowDialog()
        End If
        If e.KeyCode = Keys.W Then
            For Y = 1 To 90
                If Boton(Y).BackColor = Color.Yellow Then
                    Boton(Y).BackColor = Color.White
                End If
            Next
            NumeroSeleccionado = ""
        End If
        If e.KeyCode = Keys.D Then
            j = 1 - j
            If j = 0 Then
                Borrado = True
                lblBorrar.Visible = True
            Else
                Borrado = False
                lblBorrar.Visible = False
            End If
        End If
    End Sub
End Class
