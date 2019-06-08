Public Class frmBingo
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim botones As New List(Of Button)
        Dim boton As New Button()
        boton.Height = 55
        boton.Width = 55
        Dim a, b, c As Integer
        For i = 0 To 9 Step 1
            For j = 0 To 8 Step 1
                a = j & i
                boton.Text = a + 1
                c = j + 1
                b = i
                boton.Location = New Point(b * 55, c * 55)
                botones.Add(boton)
                boton.Enabled = True
                boton = New Button()
                boton.Height = 55
                boton.Width = 55
                Me.Controls.AddRange(botones.ToArray())
            Next
        Next
    End Sub
End Class

