Public Class frm_buscar_inventario

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
    End Sub

    Private Sub SimpleButton_cerrar_Click(sender As Object, e As EventArgs) Handles SimpleButton_cerrar.Click

        Me.Close()

    End Sub

    Private Sub SimpleButton_seleccionar_Click(sender As Object, e As EventArgs) Handles SimpleButton_seleccionar.Click

        'declaracion y asignacion de variables
        Dim row_index As Integer = Me.DataGridView_consulta.CurrentCell.RowIndex

        'verificamos si se selecciono algun registro
        If row_index >= 0 Then
            'enviamos el ID del header seleccionado a formulario del inventario por medio de una label oculta
            frm_principal2.LabelControl_ID.Text = Me.DataGridView_consulta.Rows(row_index).Cells(0).Value
            Me.Close()
        Else
            MsgBox("Seleccione un item para continuar", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub frm_buscar_inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'KardexDataSet.INVENTARIO_HEADER' Puede moverla o quitarla según sea necesario.
        Me.INVENTARIO_HEADERTableAdapter.Fill(Me.KardexDataSet.INVENTARIO_HEADER)

    End Sub

    Private Sub SimpleButton_consultar_Click(sender As Object, e As EventArgs) Handles SimpleButton_consultar.Click

        'declaracion de variables
        Dim producto As String = Me.TextEdit_producto.Text
        Dim inventario As String = Me.TextEdit_inventario.Text
        Dim periodo As String = Me.TextEdit_periodo.Text

        'establecemos los filtros a utilizar
        If producto = Nothing Then
            producto = "%"
        Else
            producto = "%" & producto & "%"
        End If

        If inventario = Nothing Then
            inventario = "%"
        Else
            inventario = "%" & inventario & "%"
        End If

        If periodo = Nothing Then
            periodo = "%"
        Else
            periodo = "%" & periodo & "%"
        End If

        'ejecutamos la consulta con los filtros
        Try
            Me.INVENTARIO_HEADERTableAdapter.FillBy(Me.KardexDataSet.INVENTARIO_HEADER, producto, inventario, periodo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class