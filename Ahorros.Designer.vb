<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ahorros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AhorrosCorteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cooperativa2DataSet2 = New Inicio.Cooperativa2DataSet2()
        Me.AhorrosCorteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReactDataSet14 = New Inicio.ReactDataSet14()
        Me.AhorrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AhorrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AhorrosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.montoTxt = New System.Windows.Forms.TextBox()
        Me.identificacionEncargadoTxt = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.AhorrosCorteTableAdapter = New Inicio.ReactDataSet14TableAdapters.AhorrosCorteTableAdapter()
        Me.AhorrosCorteTableAdapter1 = New Inicio.Cooperativa2DataSet2TableAdapters.AhorrosCorteTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorrosCorteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa2DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorrosCorteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReactDataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AhorrosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(733, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AHORROS"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(877, 549)
        Me.DataGridView1.TabIndex = 1
        '
        'AhorrosCorteBindingSource1
        '
        Me.AhorrosCorteBindingSource1.DataMember = "AhorrosCorte"
        Me.AhorrosCorteBindingSource1.DataSource = Me.Cooperativa2DataSet2
        '
        'Cooperativa2DataSet2
        '
        Me.Cooperativa2DataSet2.DataSetName = "Cooperativa2DataSet2"
        Me.Cooperativa2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AhorrosCorteBindingSource
        '
        Me.AhorrosCorteBindingSource.DataMember = "AhorrosCorte"
        Me.AhorrosCorteBindingSource.DataSource = Me.ReactDataSet14
        '
        'ReactDataSet14
        '
        Me.ReactDataSet14.DataSetName = "ReactDataSet14"
        Me.ReactDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(931, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Agregar ahorro"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(972, 351)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 44)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'identificacionTxt
        '
        Me.identificacionTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.identificacionTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.identificacionTxt.Location = New System.Drawing.Point(936, 147)
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.Size = New System.Drawing.Size(214, 24)
        Me.identificacionTxt.TabIndex = 4
        Me.identificacionTxt.Text = "Identificacion"
        Me.identificacionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'montoTxt
        '
        Me.montoTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.montoTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.montoTxt.Location = New System.Drawing.Point(936, 200)
        Me.montoTxt.Name = "montoTxt"
        Me.montoTxt.Size = New System.Drawing.Size(214, 24)
        Me.montoTxt.TabIndex = 5
        Me.montoTxt.Text = "Monto"
        Me.montoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'identificacionEncargadoTxt
        '
        Me.identificacionEncargadoTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.identificacionEncargadoTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.identificacionEncargadoTxt.Location = New System.Drawing.Point(936, 252)
        Me.identificacionEncargadoTxt.Name = "identificacionEncargadoTxt"
        Me.identificacionEncargadoTxt.Size = New System.Drawing.Size(214, 24)
        Me.identificacionEncargadoTxt.TabIndex = 6
        Me.identificacionEncargadoTxt.Text = "Identificacion Encargado"
        Me.identificacionEncargadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox1.Location = New System.Drawing.Point(1174, 255)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 24)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Identificacion Encargado"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox2.Location = New System.Drawing.Point(1174, 203)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 24)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "Monto a retirar"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox3.Location = New System.Drawing.Point(1174, 150)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 24)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Identificacion"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1210, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Retirar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(1184, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 29)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Retirar ahorro"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox4.Location = New System.Drawing.Point(936, 301)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 20)
        Me.TextBox4.TabIndex = 24
        Me.TextBox4.Text = "Contraseña"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox5.Location = New System.Drawing.Point(1174, 306)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(214, 20)
        Me.TextBox5.TabIndex = 25
        Me.TextBox5.Text = "Contraseña"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AhorrosCorteTableAdapter
        '
        Me.AhorrosCorteTableAdapter.ClearBeforeFill = True
        '
        'AhorrosCorteTableAdapter1
        '
        Me.AhorrosCorteTableAdapter1.ClearBeforeFill = True
        '
        'Ahorros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1370, 648)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.identificacionEncargadoTxt)
        Me.Controls.Add(Me.montoTxt)
        Me.Controls.Add(Me.identificacionTxt)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ahorros"
        Me.Text = "Ahorros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorrosCorteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa2DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorrosCorteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReactDataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AhorrosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView

    Friend WithEvents AhorrosBindingSource As BindingSource

    Friend WithEvents AhorrosBindingSource1 As BindingSource

    Friend WithEvents AhorrosBindingSource2 As BindingSource

    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents montoTxt As TextBox
    Friend WithEvents identificacionEncargadoTxt As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ReactDataSet14 As ReactDataSet14
    Friend WithEvents AhorrosCorteBindingSource As BindingSource
    Friend WithEvents AhorrosCorteTableAdapter As ReactDataSet14TableAdapters.AhorrosCorteTableAdapter
    Friend WithEvents Cooperativa2DataSet2 As Cooperativa2DataSet2
    Friend WithEvents AhorrosCorteBindingSource1 As BindingSource
    Friend WithEvents AhorrosCorteTableAdapter1 As Cooperativa2DataSet2TableAdapters.AhorrosCorteTableAdapter
End Class
