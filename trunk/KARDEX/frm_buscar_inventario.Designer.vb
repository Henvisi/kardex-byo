<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_buscar_inventario
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
        Me.components = New System.ComponentModel.Container()
        Me.TextEdit_producto = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit_inventario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit_periodo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton_seleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridView_consulta = New System.Windows.Forms.DataGridView()
        Me.SimpleButton_cerrar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton_consultar = New DevExpress.XtraEditors.SimpleButton()
        Me.INVENTARIOHEADERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KardexDataSet = New KARDEX.kardexDataSet()
        Me.INVENTARIO_HEADERTableAdapter = New KARDEX.kardexDataSetTableAdapters.INVENTARIO_HEADERTableAdapter()
        Me.ID_HEADER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_req_salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Periodo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TextEdit_producto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_inventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit_periodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOHEADERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KardexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit_producto
        '
        Me.TextEdit_producto.Location = New System.Drawing.Point(117, 12)
        Me.TextEdit_producto.Name = "TextEdit_producto"
        Me.TextEdit_producto.Size = New System.Drawing.Size(125, 20)
        Me.TextEdit_producto.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Producto"
        '
        'TextEdit_inventario
        '
        Me.TextEdit_inventario.Location = New System.Drawing.Point(117, 38)
        Me.TextEdit_inventario.Name = "TextEdit_inventario"
        Me.TextEdit_inventario.Size = New System.Drawing.Size(125, 20)
        Me.TextEdit_inventario.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Codigo de inventario"
        '
        'TextEdit_periodo
        '
        Me.TextEdit_periodo.Location = New System.Drawing.Point(117, 64)
        Me.TextEdit_periodo.Name = "TextEdit_periodo"
        Me.TextEdit_periodo.Size = New System.Drawing.Size(125, 20)
        Me.TextEdit_periodo.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Periodo"
        '
        'SimpleButton_seleccionar
        '
        Me.SimpleButton_seleccionar.Image = Global.KARDEX.My.Resources.Resources.apply_16x16
        Me.SimpleButton_seleccionar.Location = New System.Drawing.Point(86, 137)
        Me.SimpleButton_seleccionar.Name = "SimpleButton_seleccionar"
        Me.SimpleButton_seleccionar.Size = New System.Drawing.Size(82, 23)
        Me.SimpleButton_seleccionar.TabIndex = 6
        Me.SimpleButton_seleccionar.Text = "Seleccionar"
        '
        'DataGridView_consulta
        '
        Me.DataGridView_consulta.AllowUserToAddRows = False
        Me.DataGridView_consulta.AllowUserToDeleteRows = False
        Me.DataGridView_consulta.AllowUserToResizeColumns = False
        Me.DataGridView_consulta.AllowUserToResizeRows = False
        Me.DataGridView_consulta.AutoGenerateColumns = False
        Me.DataGridView_consulta.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.DataGridView_consulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView_consulta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_HEADER, Me.Fecha, Me.Factura, Me.Num_req_salida, Me.Periodo})
        Me.DataGridView_consulta.DataSource = Me.INVENTARIOHEADERBindingSource
        Me.DataGridView_consulta.Location = New System.Drawing.Point(248, 12)
        Me.DataGridView_consulta.MultiSelect = False
        Me.DataGridView_consulta.Name = "DataGridView_consulta"
        Me.DataGridView_consulta.ReadOnly = True
        Me.DataGridView_consulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView_consulta.RowHeadersVisible = False
        Me.DataGridView_consulta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_consulta.Size = New System.Drawing.Size(453, 148)
        Me.DataGridView_consulta.TabIndex = 13
        '
        'SimpleButton_cerrar
        '
        Me.SimpleButton_cerrar.Image = Global.KARDEX.My.Resources.Resources.close_16x16
        Me.SimpleButton_cerrar.Location = New System.Drawing.Point(167, 137)
        Me.SimpleButton_cerrar.Name = "SimpleButton_cerrar"
        Me.SimpleButton_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton_cerrar.TabIndex = 7
        Me.SimpleButton_cerrar.Text = "Cancelar"
        '
        'SimpleButton_consultar
        '
        Me.SimpleButton_consultar.Image = Global.KARDEX.My.Resources.Resources.zoom_16x16
        Me.SimpleButton_consultar.Location = New System.Drawing.Point(12, 137)
        Me.SimpleButton_consultar.Name = "SimpleButton_consultar"
        Me.SimpleButton_consultar.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton_consultar.TabIndex = 5
        Me.SimpleButton_consultar.Text = "Consultar"
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
        'INVENTARIO_HEADERTableAdapter
        '
        Me.INVENTARIO_HEADERTableAdapter.ClearBeforeFill = True
        '
        'ID_HEADER
        '
        Me.ID_HEADER.DataPropertyName = "ID_HEADER"
        Me.ID_HEADER.HeaderText = "ID_HEADER"
        Me.ID_HEADER.Name = "ID_HEADER"
        Me.ID_HEADER.ReadOnly = True
        Me.ID_HEADER.Visible = False
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "NOM_PRODUCTO"
        Me.Fecha.HeaderText = "Producto"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 160
        '
        'Factura
        '
        Me.Factura.DataPropertyName = "COD_INVENTARIO"
        Me.Factura.HeaderText = "Cod. inventario"
        Me.Factura.Name = "Factura"
        Me.Factura.ReadOnly = True
        '
        'Num_req_salida
        '
        Me.Num_req_salida.DataPropertyName = "UNIDAD_MEDIDA"
        Me.Num_req_salida.HeaderText = "Unidad"
        Me.Num_req_salida.Name = "Num_req_salida"
        Me.Num_req_salida.ReadOnly = True
        Me.Num_req_salida.Width = 70
        '
        'Periodo
        '
        Me.Periodo.DataPropertyName = "PERIODO"
        Me.Periodo.HeaderText = "Periodo"
        Me.Periodo.Name = "Periodo"
        Me.Periodo.ReadOnly = True
        Me.Periodo.Width = 120
        '
        'frm_buscar_inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 172)
        Me.Controls.Add(Me.DataGridView_consulta)
        Me.Controls.Add(Me.SimpleButton_cerrar)
        Me.Controls.Add(Me.SimpleButton_seleccionar)
        Me.Controls.Add(Me.SimpleButton_consultar)
        Me.Controls.Add(Me.TextEdit_periodo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.TextEdit_inventario)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.TextEdit_producto)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frm_buscar_inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARDEX - Buscar Inventario"
        CType(Me.TextEdit_producto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_inventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit_periodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_consulta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOHEADERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KardexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextEdit_producto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit_inventario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit_periodo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton_consultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_seleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton_cerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView_consulta As System.Windows.Forms.DataGridView
    Friend WithEvents KardexDataSet As KARDEX.kardexDataSet
    Friend WithEvents INVENTARIOHEADERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTARIO_HEADERTableAdapter As KARDEX.kardexDataSetTableAdapters.INVENTARIO_HEADERTableAdapter
    Friend WithEvents ID_HEADER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Factura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Num_req_salida As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Periodo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
