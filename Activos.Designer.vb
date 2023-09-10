<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activos
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
        Me.contrasena = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.modelo = New System.Windows.Forms.TextBox()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.descripcion = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerieDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActivosFijosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cooperativa3DataSet2 = New Inicio.Cooperativa3DataSet2()
        Me.estado = New System.Windows.Forms.TextBox()
        Me.serie = New System.Windows.Forms.TextBox()
        Me.lugar = New System.Windows.Forms.TextBox()
        Me.lugar2 = New System.Windows.Forms.TextBox()
        Me.serie2 = New System.Windows.Forms.TextBox()
        Me.estado2 = New System.Windows.Forms.TextBox()
        Me.modelo2 = New System.Windows.Forms.TextBox()
        Me.marca2 = New System.Windows.Forms.TextBox()
        Me.descripcion2 = New System.Windows.Forms.TextBox()
        Me.ActivosFijosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cooperativa2DataSet = New Inicio.Cooperativa2DataSet()
        Me.ActivosFijosTableAdapter = New Inicio.Cooperativa2DataSetTableAdapters.ActivosFijosTableAdapter()
        Me.ActivosFijosTableAdapter1 = New Inicio.Cooperativa3DataSet2TableAdapters.ActivosFijosTableAdapter()
        Me.serie3 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivosFijosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa3DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActivosFijosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contrasena
        '
        Me.contrasena.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.contrasena.ForeColor = System.Drawing.Color.MidnightBlue
        Me.contrasena.Location = New System.Drawing.Point(688, 581)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(214, 20)
        Me.contrasena.TabIndex = 44
        Me.contrasena.Text = "Contraseña"
        Me.contrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(726, 607)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 44)
        Me.Button2.TabIndex = 42
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(690, 491)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 29)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Eliminar activo"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(994, 429)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 44)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(957, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 29)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Actualizar activo"
        '
        'modelo
        '
        Me.modelo.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.modelo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelo.Location = New System.Drawing.Point(695, 252)
        Me.modelo.Name = "modelo"
        Me.modelo.Size = New System.Drawing.Size(214, 24)
        Me.modelo.TabIndex = 35
        Me.modelo.Text = "Modelo"
        Me.modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'marca
        '
        Me.marca.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.marca.ForeColor = System.Drawing.Color.MidnightBlue
        Me.marca.Location = New System.Drawing.Point(695, 200)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(214, 24)
        Me.marca.TabIndex = 34
        Me.marca.Text = "Marca"
        Me.marca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'descripcion
        '
        Me.descripcion.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.descripcion.ForeColor = System.Drawing.Color.MidnightBlue
        Me.descripcion.Location = New System.Drawing.Point(695, 147)
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Size = New System.Drawing.Size(214, 24)
        Me.descripcion.TabIndex = 33
        Me.descripcion.Text = "Descripcion"
        Me.descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(726, 429)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 44)
        Me.btnAgregar.TabIndex = 32
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(698, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 29)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Agregar activo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(459, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 29)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ACTIVOS FIJOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.SerieDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn, Me.LugarDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ActivosFijosBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(656, 559)
        Me.DataGridView1.TabIndex = 29
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        '
        'SerieDataGridViewTextBoxColumn
        '
        Me.SerieDataGridViewTextBoxColumn.DataPropertyName = "serie"
        Me.SerieDataGridViewTextBoxColumn.HeaderText = "serie"
        Me.SerieDataGridViewTextBoxColumn.Name = "SerieDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'LugarDataGridViewTextBoxColumn
        '
        Me.LugarDataGridViewTextBoxColumn.DataPropertyName = "lugar"
        Me.LugarDataGridViewTextBoxColumn.HeaderText = "lugar"
        Me.LugarDataGridViewTextBoxColumn.Name = "LugarDataGridViewTextBoxColumn"
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        '
        'ActivosFijosBindingSource1
        '
        Me.ActivosFijosBindingSource1.DataMember = "ActivosFijos"
        Me.ActivosFijosBindingSource1.DataSource = Me.Cooperativa3DataSet2
        '
        'Cooperativa3DataSet2
        '
        Me.Cooperativa3DataSet2.DataSetName = "Cooperativa3DataSet2"
        Me.Cooperativa3DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'estado
        '
        Me.estado.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.estado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.estado.Location = New System.Drawing.Point(695, 355)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(214, 24)
        Me.estado.TabIndex = 45
        Me.estado.Text = "Estado"
        Me.estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'serie
        '
        Me.serie.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.serie.ForeColor = System.Drawing.Color.MidnightBlue
        Me.serie.Location = New System.Drawing.Point(695, 301)
        Me.serie.Name = "serie"
        Me.serie.Size = New System.Drawing.Size(214, 24)
        Me.serie.TabIndex = 46
        Me.serie.Text = "Serie"
        Me.serie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lugar
        '
        Me.lugar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lugar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lugar.Location = New System.Drawing.Point(695, 399)
        Me.lugar.Name = "lugar"
        Me.lugar.Size = New System.Drawing.Size(214, 24)
        Me.lugar.TabIndex = 47
        Me.lugar.Text = "Lugar"
        Me.lugar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lugar2
        '
        Me.lugar2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lugar2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lugar2.Location = New System.Drawing.Point(962, 399)
        Me.lugar2.Name = "lugar2"
        Me.lugar2.Size = New System.Drawing.Size(214, 24)
        Me.lugar2.TabIndex = 53
        Me.lugar2.Text = "Lugar"
        Me.lugar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'serie2
        '
        Me.serie2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.serie2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.serie2.Location = New System.Drawing.Point(962, 301)
        Me.serie2.Name = "serie2"
        Me.serie2.Size = New System.Drawing.Size(214, 24)
        Me.serie2.TabIndex = 52
        Me.serie2.Text = "Serie"
        Me.serie2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'estado2
        '
        Me.estado2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.estado2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.estado2.Location = New System.Drawing.Point(962, 355)
        Me.estado2.Name = "estado2"
        Me.estado2.Size = New System.Drawing.Size(214, 24)
        Me.estado2.TabIndex = 51
        Me.estado2.Text = "Estado"
        Me.estado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'modelo2
        '
        Me.modelo2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.modelo2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.modelo2.Location = New System.Drawing.Point(962, 252)
        Me.modelo2.Name = "modelo2"
        Me.modelo2.Size = New System.Drawing.Size(214, 24)
        Me.modelo2.TabIndex = 50
        Me.modelo2.Text = "Modelo"
        Me.modelo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'marca2
        '
        Me.marca2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.marca2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.marca2.Location = New System.Drawing.Point(962, 200)
        Me.marca2.Name = "marca2"
        Me.marca2.Size = New System.Drawing.Size(214, 24)
        Me.marca2.TabIndex = 49
        Me.marca2.Text = "Marca"
        Me.marca2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'descripcion2
        '
        Me.descripcion2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.descripcion2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.descripcion2.Location = New System.Drawing.Point(962, 147)
        Me.descripcion2.Name = "descripcion2"
        Me.descripcion2.Size = New System.Drawing.Size(214, 24)
        Me.descripcion2.TabIndex = 48
        Me.descripcion2.Text = "Descripcion"
        Me.descripcion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ActivosFijosBindingSource
        '
        Me.ActivosFijosBindingSource.DataMember = "ActivosFijos"
        Me.ActivosFijosBindingSource.DataSource = Me.Cooperativa2DataSet
        '
        'Cooperativa2DataSet
        '
        Me.Cooperativa2DataSet.DataSetName = "Cooperativa2DataSet"
        Me.Cooperativa2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ActivosFijosTableAdapter
        '
        Me.ActivosFijosTableAdapter.ClearBeforeFill = True
        '
        'ActivosFijosTableAdapter1
        '
        Me.ActivosFijosTableAdapter1.ClearBeforeFill = True
        '
        'serie3
        '
        Me.serie3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.serie3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.serie3.Location = New System.Drawing.Point(688, 539)
        Me.serie3.Name = "serie3"
        Me.serie3.Size = New System.Drawing.Size(214, 24)
        Me.serie3.TabIndex = 43
        Me.serie3.Text = "Descripcion"
        Me.serie3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Activos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1192, 661)
        Me.Controls.Add(Me.lugar2)
        Me.Controls.Add(Me.serie2)
        Me.Controls.Add(Me.estado2)
        Me.Controls.Add(Me.modelo2)
        Me.Controls.Add(Me.marca2)
        Me.Controls.Add(Me.descripcion2)
        Me.Controls.Add(Me.lugar)
        Me.Controls.Add(Me.serie)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.serie3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.modelo)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.descripcion)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Activos"
        Me.Text = "Activos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivosFijosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa3DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActivosFijosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contrasena As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents modelo As TextBox
    Friend WithEvents marca As TextBox
    Friend WithEvents descripcion As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents estado As TextBox
    Friend WithEvents serie As TextBox
    Friend WithEvents lugar As TextBox
    Friend WithEvents lugar2 As TextBox
    Friend WithEvents serie2 As TextBox
    Friend WithEvents estado2 As TextBox
    Friend WithEvents modelo2 As TextBox
    Friend WithEvents marca2 As TextBox
    Friend WithEvents descripcion2 As TextBox
    Friend WithEvents Cooperativa2DataSet As Cooperativa2DataSet
    Friend WithEvents ActivosFijosBindingSource As BindingSource
    Friend WithEvents ActivosFijosTableAdapter As Cooperativa2DataSetTableAdapters.ActivosFijosTableAdapter
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SerieDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cooperativa3DataSet2 As Cooperativa3DataSet2
    Friend WithEvents ActivosFijosBindingSource1 As BindingSource
    Friend WithEvents ActivosFijosTableAdapter1 As Cooperativa3DataSet2TableAdapters.ActivosFijosTableAdapter
    Friend WithEvents serie3 As TextBox
End Class
