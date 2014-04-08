Public Class frm_principal2

    Private Sub frm_principal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cerramos la pantalla de bienvenida
        frm_presentacion.Close()

        'agregamos una linea en el datagridview de detalle del inventario
        Me.DataGridView_kardex.Rows.Add()
    End Sub

    Private Sub BarButtonItem_salir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_salir.ItemClick
        'cerramos esta ventana
        Me.Close()
    End Sub

    Private Sub SimpleButton_remover_Click(sender As Object, e As EventArgs)
        'solo si hay mas de una linea en el datagridview, procedemos a eliminarla
        If Me.DataGridView_kardex.Rows.Count > 1 Then
            'indicamos que linea eliminar por medio del indice seleccionado
            Me.DataGridView_kardex.Rows.RemoveAt(Me.DataGridView_kardex.CurrentRow.Index)
        End If
    End Sub

    Private Sub BarButtonItem_guardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_guardar.ItemClick
        '---------------------------------------------------
        'Header del inventario
        '---------------------------------------------------
        'declaracion y asignacion de variables del header
        Dim id_header As Integer = Me.INVENTARIO_HEADERTableAdapter.MaxID() + 1
        Dim producto As String = Me.TextEdit_producto.Text
        Dim cod_inventario As String = Me.TextEdit_inventario.Text
        Dim unidad_medida As String = Me.TextEdit_unidad.Text
        Dim periodo As String = Me.TextEdit_periodo.Text

        'almacenamos los datos ingresados en el header
        Try
            Me.INVENTARIO_HEADERTableAdapter.Insert(id_header, producto, cod_inventario, unidad_medida, periodo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        '---------------------------------------------------
        'Detalle del inventario
        '---------------------------------------------------
        'si al mas de un fila en el datagridview
        If Me.DataGridView_kardex.RowCount > 0 Then
            'almacenamos cada registro del datagridview
            For i As Integer = 1 To DataGridView_kardex.RowCount
                'declaracion y asignacion de variables
                Dim id_detalle As Integer = Me.INVENTARIO_DETALLETableAdapter.MaxID() + 1
                Dim fecha As Date = Me.DataGridView_kardex.Rows(i).Cells(0).Value
                Dim factura As String = Me.DataGridView_kardex.Rows(i).Cells(1).Value
                Dim Proveedor As String = Me.DataGridView_kardex.Rows(i).Cells(2).Value
                Dim Costo_Unit As Decimal = Me.DataGridView_kardex.Rows(i).Cells(3).Value
                Dim Num_req_salida As String = Me.DataGridView_kardex.Rows(i).Cells(4).Value
                Dim Entrada As Integer = Me.DataGridView_kardex.Rows(i).Cells(5).Value
                Dim Salida As Integer = Me.DataGridView_kardex.Rows(i).Cells(6).Value
                Dim Saldo As Integer = Me.DataGridView_kardex.Rows(i).Cells(7).Value
                Dim Descripcion As String = Me.DataGridView_kardex.Rows(i).Cells(8).Value

                'almacenamos los datos ingresados en el detalle
                Try
                    Me.INVENTARIO_DETALLETableAdapter.Insert(id_detalle, id_header, fecha, factura, Proveedor, Costo_Unit, Num_req_salida, Entrada, Salida, Saldo, Descripcion)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
    End Sub

    Private Sub DataGridView_kardex_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub SimpleButton_adicionar_Click(sender As Object, e As EventArgs)
        'agregamos una linea en el datagridview de detalle del inventario
        Me.DataGridView_kardex.Rows.Add()
    End Sub

    Private Sub BarButtonItem_buscar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem_buscar.ItemClick
        frm_buscar_inventario.Show()
    End Sub
End Class