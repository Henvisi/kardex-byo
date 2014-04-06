Public NotInheritable Class frm_presentacion
    'declaracion de variables del formulario
    Dim val_timer As Integer

    Private Sub frm_presentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer_close.Start()
        Me.Timer_progressbar.Start()
    End Sub

    Private Sub Timer_close_Tick(sender As Object, e As EventArgs) Handles Timer_close.Tick
        Me.val_timer += 1

        If Me.val_timer = 4 Then
            frm_principal2.Show()
        End If
    End Sub

    Private Sub Timer_progressbar_Tick(sender As Object, e As EventArgs) Handles Timer_progressbar.Tick        
        If Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
        End If
    End Sub
End Class
