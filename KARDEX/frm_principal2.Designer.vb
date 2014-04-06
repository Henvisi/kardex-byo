<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_principal2
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarButtonItem_nuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_eliminar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_modificar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_imprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_excel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_salir = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem_correcto = New DevExpress.XtraBars.BarStaticItem()
        Me.BarButtonItem_guardar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem_buscar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem_error = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage_inicio = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage_ayuda = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemPictureEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.RepositoryItemImageEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageEdit()
        Me.RibbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit_producto = New DevExpress.XtraEditors.TextEdit()
        Me.INVENTARIOHEADERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KardexDataSet = New KARDEX.kardexDataSet()
        Me.TextEdit_inventario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit_unidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit_periodo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.DataGridView_kardex = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_req_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVENTARIODETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton_adicionar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_remover = New DevExpress.XtraEditors.SimpleButton()
        Me.INVENTARIO_HEADERTableAdapter = New KARDEX.kardexDataSetTableAdapters.INVENTARIO_HEADERTableAdapter()
        Me.INVENTARIO_DETALLETableAdapter = New KARDEX.kardexDataSetTableAdapters.INVENTARIO_DETALLETableAdapter()
        Me.LabelControl_ID = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_producto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOHEADERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KardexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_inventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_unidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_periodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_kardex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIODETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl
        '
        Me.RibbonControl.ExpandCollapseItem.Id = 0
        Me.RibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl.ExpandCollapseItem, Me.BarButtonItem_nuevo, Me.BarButtonItem_eliminar, Me.BarButtonItem_modificar, Me.BarButtonItem_imprimir, Me.BarButtonItem_excel, Me.BarButtonItem_salir, Me.BarStaticItem_correcto, Me.BarButtonItem_guardar, Me.BarButtonItem_buscar, Me.BarStaticItem_error})
        Me.RibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl.MaxItemId = 20
        Me.RibbonControl.Name = "RibbonControl"
        Me.RibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage_inicio, Me.RibbonPage_ayuda})
        Me.RibbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.RepositoryItemPictureEdit2, Me.RepositoryItemImageEdit1})
        Me.RibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007
        Me.RibbonControl.Size = New System.Drawing.Size(901, 144)
        Me.RibbonControl.StatusBar = Me.RibbonStatusBar
        '
        'BarButtonItem_nuevo
        '
        Me.BarButtonItem_nuevo.Caption = "Nuevo documento"
        Me.BarButtonItem_nuevo.Glyph = Global.KARDEX.My.Resources.Resources.new_16x16
        Me.BarButtonItem_nuevo.Id = 1
        Me.BarButtonItem_nuevo.LargeGlyph = Global.KARDEX.My.Resources.Resources.new_32x32
        Me.BarButtonItem_nuevo.Name = "BarButtonItem_nuevo"
        '
        'BarButtonItem_eliminar
        '
        Me.BarButtonItem_eliminar.Caption = "Eliminar documento"
        Me.BarButtonItem_eliminar.Glyph = Global.KARDEX.My.Resources.Resources.deletelist2_16x16
        Me.BarButtonItem_eliminar.Id = 5
        Me.BarButtonItem_eliminar.LargeGlyph = Global.KARDEX.My.Resources.Resources.deletelist2_32x32
        Me.BarButtonItem_eliminar.Name = "BarButtonItem_eliminar"
        Me.BarButtonItem_eliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem_modificar
        '
        Me.BarButtonItem_modificar.Caption = "Editar documento"
        Me.BarButtonItem_modificar.Glyph = Global.KARDEX.My.Resources.Resources.edit_16x16
        Me.BarButtonItem_modificar.Id = 6
        Me.BarButtonItem_modificar.LargeGlyph = Global.KARDEX.My.Resources.Resources.edit_32x32
        Me.BarButtonItem_modificar.Name = "BarButtonItem_modificar"
        Me.BarButtonItem_modificar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem_imprimir
        '
        Me.BarButtonItem_imprimir.Caption = "Imprimir documento"
        Me.BarButtonItem_imprimir.Glyph = Global.KARDEX.My.Resources.Resources.print_16x16
        Me.BarButtonItem_imprimir.Id = 8
        Me.BarButtonItem_imprimir.LargeGlyph = Global.KARDEX.My.Resources.Resources.print_32x32
        Me.BarButtonItem_imprimir.Name = "BarButtonItem_imprimir"
        '
        'BarButtonItem_excel
        '
        Me.BarButtonItem_excel.Caption = "Exportar a Excel"
        Me.BarButtonItem_excel.Glyph = Global.KARDEX.My.Resources.Resources.grid_16x16
        Me.BarButtonItem_excel.Id = 9
        Me.BarButtonItem_excel.LargeGlyph = Global.KARDEX.My.Resources.Resources.grid_32x32
        Me.BarButtonItem_excel.Name = "BarButtonItem_excel"
        '
        'BarButtonItem_salir
        '
        Me.BarButtonItem_salir.Caption = "Salir de KARDEX"
        Me.BarButtonItem_salir.Glyph = Global.KARDEX.My.Resources.Resources.close_16x16
        Me.BarButtonItem_salir.Id = 10
        Me.BarButtonItem_salir.LargeGlyph = Global.KARDEX.My.Resources.Resources.close_32x32
        Me.BarButtonItem_salir.Name = "BarButtonItem_salir"
        '
        'BarStaticItem_correcto
        '
        Me.BarStaticItem_correcto.Caption = "Correcto"
        Me.BarStaticItem_correcto.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarStaticItem_correcto.Glyph = Global.KARDEX.My.Resources.Resources.apply_16x16
        Me.BarStaticItem_correcto.Id = 11
        Me.BarStaticItem_correcto.Name = "BarStaticItem_correcto"
        Me.BarStaticItem_correcto.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem_correcto.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem_guardar
        '
        Me.BarButtonItem_guardar.Caption = "Guardar documento"
        Me.BarButtonItem_guardar.Glyph = Global.KARDEX.My.Resources.Resources.save_16x16
        Me.BarButtonItem_guardar.Id = 17
        Me.BarButtonItem_guardar.LargeGlyph = Global.KARDEX.My.Resources.Resources.save_32x32
        Me.BarButtonItem_guardar.Name = "BarButtonItem_guardar"
        '
        'BarButtonItem_buscar
        '
        Me.BarButtonItem_buscar.Caption = "Buscar documento"
        Me.BarButtonItem_buscar.Glyph = Global.KARDEX.My.Resources.Resources.zoom100_16x16
        Me.BarButtonItem_buscar.Id = 18
        Me.BarButtonItem_buscar.LargeGlyph = Global.KARDEX.My.Resources.Resources.zoom100_32x32
        Me.BarButtonItem_buscar.Name = "BarButtonItem_buscar"
        '
        'BarStaticItem_error
        '
        Me.BarStaticItem_error.Caption = "Error"
        Me.BarStaticItem_error.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarStaticItem_error.Glyph = Global.KARDEX.My.Resources.Resources.cancel_16x16
        Me.BarStaticItem_error.Id = 19
        Me.BarStaticItem_error.Name = "BarStaticItem_error"
        Me.BarStaticItem_error.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem_error.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'RibbonPage_inicio
        '
        Me.RibbonPage_inicio.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage_inicio.Name = "RibbonPage_inicio"
        Me.RibbonPage_inicio.Text = "Inicio"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_nuevo)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_buscar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_guardar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_modificar)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem_eliminar)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Acciones del documento"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem_imprimir)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem_excel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Exportar"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.BarButtonItem_salir)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Opciones"
        '
        'RibbonPage_ayuda
        '
        Me.RibbonPage_ayuda.Name = "RibbonPage_ayuda"
        Me.RibbonPage_ayuda.Text = "Ayuda"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        '
        'RepositoryItemPictureEdit2
        '
        Me.RepositoryItemPictureEdit2.Name = "RepositoryItemPictureEdit2"
        '
        'RepositoryItemImageEdit1
        '
        Me.RepositoryItemImageEdit1.AutoHeight = False
        Me.RepositoryItemImageEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageEdit1.Name = "RepositoryItemImageEdit1"
        '
        'RibbonStatusBar
        '
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_correcto)
        Me.RibbonStatusBar.ItemLinks.Add(Me.BarStaticItem_error)
        Me.RibbonStatusBar.Location = New System.Drawing.Point(0, 460)
        Me.RibbonStatusBar.Name = "RibbonStatusBar"
        Me.RibbonStatusBar.Ribbon = Me.RibbonControl
        Me.RibbonStatusBar.Size = New System.Drawing.Size(901, 31)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 172)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Nombre del producto"
        '
        'TextEdit_producto
        '
        Me.TextEdit_producto.Location = New System.Drawing.Point(126, 169)
        Me.TextEdit_producto.MenuManager = Me.RibbonControl
        Me.TextEdit_producto.Name = "TextEdit_producto"
        Me.TextEdit_producto.Size = New System.Drawing.Size(147, 20)
        Me.TextEdit_producto.TabIndex = 3
        '
        'INVENTARIOHEADERBindingSource
        '
        Me.INVENTARIOHEADERBindingSource.DataMember = "INVENTARIO_HEADER"
        Me.INVENTARIOHEADERBindingSource.DataSource = Me.KardexDataSet
        '
        'KardexDataSet
        '
        Me.KardexDataSet.DataSetName = "kardexDataSet"
        Me.KardexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextEdit_inventario
        '
        Me.TextEdit_inventario.Location = New System.Drawing.Point(126, 195)
        Me.TextEdit_inventario.MenuManager = Me.RibbonControl
        Me.TextEdit_inventario.Name = "TextEdit_inventario"
        Me.TextEdit_inventario.Size = New System.Drawing.Size(147, 20)
        Me.TextEdit_inventario.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 198)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Codigo inventario"
        '
        'TextEdit_unidad
        '
        Me.TextEdit_unidad.Location = New System.Drawing.Point(506, 169)
        Me.TextEdit_unidad.MenuManager = Me.RibbonControl
        Me.TextEdit_unidad.Name = "TextEdit_unidad"
        Me.TextEdit_unidad.Size = New System.Drawing.Size(147, 20)
        Me.TextEdit_unidad.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(406, 172)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Unidad de medida"
        '
        'TextEdit_periodo
        '
        Me.TextEdit_periodo.Location = New System.Drawing.Point(506, 195)
        Me.TextEdit_periodo.MenuManager = Me.RibbonControl
        Me.TextEdit_periodo.Name = "TextEdit_periodo"
        Me.TextEdit_periodo.Size = New System.Drawing.Size(147, 20)
        Me.TextEdit_periodo.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(406, 198)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Periodo"
        '
        'DataGridView_kardex
        '
        Me.DataGridView_kardex.AllowUserToAddRows = False
        Me.DataGridView_kardex.AllowUserToDeleteRows = False
        Me.DataGridView_kardex.AllowUserToResizeColumns = False
        Me.DataGridView_kardex.AllowUserToResizeRows = False
        Me.DataGridView_kardex.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView_kardex.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_kardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_kardex.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Factura, Me.Proveedor, Me.Costo_Unit, Me.Num_req_salida, Me.Entrada, Me.Salida, Me.Saldo, Me.Descripcion})
        Me.DataGridView_kardex.Location = New System.Drawing.Point(52, 253)
        Me.DataGridView_kardex.MultiSelect = False
        Me.DataGridView_kardex.Name = "DataGridView_kardex"
        Me.DataGridView_kardex.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_kardex.RowHeadersVisible = False
        Me.DataGridView_kardex.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView_kardex.Size = New System.Drawing.Size(833, 196)
        Me.DataGridView_kardex.TabIndex = 10
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "FECHA"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 70
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "FACTURA"
        Me.Factura.HeaderText = "Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 70
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "PROVEEDOR"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 110
        '
        'Costo_Unit
        '
        Me.Costo_Unit.DataPropertyName = "COSTO_UNIT"
        Me.Costo_Unit.HeaderText = "Costo Unit."
        Me.Costo_Unit.Name = "Costo_Unit"
        Me.Costo_Unit.Width = 70
        '
        'Num_req_salida
        '
        Me.Num_req_salida.DataPropertyName = "REQ_SALIDA"
        Me.Num_req_salida.HeaderText = "Nº Req Salida"
        Me.Num_req_salida.Name = "Num_req_salida"
        '
        'Entrada
        '
        Me.Entrada.DataPropertyName = "ENTRADA"
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Width = 70
        '
        'Salida
        '
        Me.Salida.DataPropertyName = "SALIDA"
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.Width = 70
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "SALDO"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.Width = 70
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "DESCRIPCION"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 200
        '
        'INVENTARIODETALLEBindingSource
        '
        Me.INVENTARIODETALLEBindingSource.DataMember = "INVENTARIO_DETALLE"
        Me.INVENTARIODETALLEBindingSource.DataSource = Me.KardexDataSet
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl5.Location = New System.Drawing.Point(123, 238)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(251, 18)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Datos del proveedor"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl6.Location = New System.Drawing.Point(473, 238)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(211, 18)
        Me.LabelControl6.TabIndex = 18
        Me.LabelControl6.Text = "Cantidades"
        '
        'SimpleButton_adicionar
        '
        Me.SimpleButton_adicionar.Image = Global.KARDEX.My.Resources.Resources.add_16x16
        Me.SimpleButton_adicionar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton_adicionar.Location = New System.Drawing.Point(13, 253)
        Me.SimpleButton_adicionar.Name = "SimpleButton_adicionar"
        Me.SimpleButton_adicionar.Size = New System.Drawing.Size(33, 23)
        Me.SimpleButton_adicionar.TabIndex = 20
        Me.SimpleButton_adicionar.ToolTip = "Adicionar linea"
        '
        'SimpleButton_remover
        '
        Me.SimpleButton_remover.Image = Global.KARDEX.My.Resources.Resources.remove_16x16
        Me.SimpleButton_remover.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.SimpleButton_remover.Location = New System.Drawing.Point(12, 282)
        Me.SimpleButton_remover.Name = "SimpleButton_remover"
        Me.SimpleButton_remover.Size = New System.Drawing.Size(33, 23)
        Me.SimpleButton_remover.TabIndex = 23
        Me.SimpleButton_remover.ToolTip = "Remover linea"
        '
        'INVENTARIO_HEADERTableAdapter
        '
        Me.INVENTARIO_HEADERTableAdapter.ClearBeforeFill = True
        '
        'INVENTARIO_DETALLETableAdapter
        '
        Me.INVENTARIO_DETALLETableAdapter.ClearBeforeFill = True
        '
        'LabelControl_ID
        '
        Me.LabelControl_ID.Location = New System.Drawing.Point(800, 172)
        Me.LabelControl_ID.Name = "LabelControl_ID"
        Me.LabelControl_ID.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl_ID.TabIndex = 26
        Me.LabelControl_ID.Visible = False
        '
        'frm_principal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 491)
        Me.Controls.Add(Me.LabelControl_ID)
        Me.Controls.Add(Me.SimpleButton_remover)
        Me.Controls.Add(Me.SimpleButton_adicionar)
        Me.Controls.Add(Me.DataGridView_kardex)
        Me.Controls.Add(Me.TextEdit_periodo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TextEdit_unidad)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TextEdit_inventario)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.TextEdit_producto)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.RibbonStatusBar)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.RibbonControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_principal2"
        Me.Ribbon = Me.RibbonControl
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.StatusBar = Me.RibbonStatusBar
        Me.Text = "KARDEX - Menu Principal"
        CType(Me.RibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_producto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOHEADERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KardexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_inventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_unidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_periodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_kardex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIODETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage_inicio As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents BarButtonItem_nuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage_ayuda As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem_eliminar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_modificar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_imprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem_excel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem_salir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit_producto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit_inventario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit_unidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit_periodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DataGridView_kardex As System.Windows.Forms.DataGridView
    Friend WithEvents BarStaticItem_correcto As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemPictureEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents RepositoryItemImageEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemImageEdit
    Friend WithEvents BarButtonItem_guardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarButtonItem_buscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem_error As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SimpleButton_adicionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_remover As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents KardexDataSet As KARDEX.kardexDataSet
    Friend WithEvents INVENTARIOHEADERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTARIO_HEADERTableAdapter As KARDEX.kardexDataSetTableAdapters.INVENTARIO_HEADERTableAdapter
    Friend WithEvents INVENTARIODETALLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTARIO_DETALLETableAdapter As KARDEX.kardexDataSetTableAdapters.INVENTARIO_DETALLETableAdapter
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Costo_Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_req_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Entrada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Saldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelControl_ID As DevExpress.XtraEditors.LabelControl


End Class
