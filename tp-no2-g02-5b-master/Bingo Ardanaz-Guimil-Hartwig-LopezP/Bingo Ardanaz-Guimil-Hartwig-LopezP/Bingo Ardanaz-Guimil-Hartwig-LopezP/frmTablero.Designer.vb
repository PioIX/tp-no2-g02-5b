<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTablero
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBorrar = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBorrar
        '
        Me.lblBorrar.AutoSize = True
        Me.lblBorrar.Font = New System.Drawing.Font("Rockwell", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBorrar.ForeColor = System.Drawing.Color.Goldenrod
        Me.lblBorrar.Location = New System.Drawing.Point(4, 11)
        Me.lblBorrar.Name = "lblBorrar"
        Me.lblBorrar.Size = New System.Drawing.Size(145, 23)
        Me.lblBorrar.TabIndex = 3
        Me.lblBorrar.Text = "Modo Borrado"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Copperplate Gothic Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(273, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(374, 44)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Bingo PioIx G02"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 688)
        Me.Controls.Add(Me.lblBorrar)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmTablero"
        Me.Text = "Bingo Pio IX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBorrar As Label
    Friend WithEvents lblTitulo As Label
End Class
