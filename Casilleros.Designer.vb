<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Casilleros
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.seccionTxt = New System.Windows.Forms.TextBox()
        Me.nAsociadoTxt = New System.Windows.Forms.TextBox()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CasilleroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReactDataSet13 = New Inicio.ReactDataSet13()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CasilleroTableAdapter = New Inicio.ReactDataSet13TableAdapters.CasilleroTableAdapter()
        Me.Cooperativa3DataSet14 = New Inicio.Cooperativa3DataSet14()
        Me.CasilleroBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasilleroTableAdapter1 = New Inicio.Cooperativa3DataSet14TableAdapters.CasilleroTableAdapter()
        Me.Cooperativa3DataSet15 = New Inicio.Cooperativa3DataSet15()
        Me.CasilleroBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasilleroTableAdapter2 = New Inicio.Cooperativa3DataSet15TableAdapters.CasilleroTableAdapter()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasilleroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReactDataSet13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa3DataSet14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasilleroBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa3DataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasilleroBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox2.Location = New System.Drawing.Point(1079, 165)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 20)
        Me.TextBox2.TabIndex = 44
        Me.TextBox2.Text = "Contraseña"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox4.Location = New System.Drawing.Point(817, 413)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 20)
        Me.TextBox4.TabIndex = 43
        Me.TextBox4.Text = "Contraseña"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox8.Location = New System.Drawing.Point(1079, 109)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(214, 24)
        Me.TextBox8.TabIndex = 41
        Me.TextBox8.Text = "Numero Casillero"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1110, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 44)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(1065, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 29)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Eliminar casillero"
        '
        'seccionTxt
        '
        Me.seccionTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.seccionTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.seccionTxt.Location = New System.Drawing.Point(817, 225)
        Me.seccionTxt.Name = "seccionTxt"
        Me.seccionTxt.Size = New System.Drawing.Size(214, 24)
        Me.seccionTxt.TabIndex = 37
        Me.seccionTxt.Text = "Seccion"
        Me.seccionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nAsociadoTxt
        '
        Me.nAsociadoTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nAsociadoTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nAsociadoTxt.Location = New System.Drawing.Point(817, 283)
        Me.nAsociadoTxt.Name = "nAsociadoTxt"
        Me.nAsociadoTxt.Size = New System.Drawing.Size(214, 24)
        Me.nAsociadoTxt.TabIndex = 36
        Me.nAsociadoTxt.Text = "Recibo"
        Me.nAsociadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nombreTxt
        '
        Me.nombreTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nombreTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nombreTxt.Location = New System.Drawing.Point(817, 109)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(214, 24)
        Me.nombreTxt.TabIndex = 32
        Me.nombreTxt.Text = "Nombre Completo"
        Me.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(674, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CASILLEROS"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(849, 448)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 44)
        Me.btnAgregar.TabIndex = 29
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(812, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 29)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Agregar casillero"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(773, 475)
        Me.DataGridView1.TabIndex = 27
        '
        'CasilleroBindingSource
        '
        Me.CasilleroBindingSource.DataMember = "Casillero"
        Me.CasilleroBindingSource.DataSource = Me.ReactDataSet13
        '
        'ReactDataSet13
        '
        Me.ReactDataSet13.DataSetName = "ReactDataSet13"
        Me.ReactDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox3.Location = New System.Drawing.Point(817, 165)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 24)
        Me.TextBox3.TabIndex = 45
        Me.TextBox3.Text = "Numero Casillero"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox1.Location = New System.Drawing.Point(817, 331)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 24)
        Me.TextBox1.TabIndex = 46
        Me.TextBox1.Text = "Tipo de arrendamiento"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CasilleroTableAdapter
        '
        Me.CasilleroTableAdapter.ClearBeforeFill = True
        '
        'Cooperativa3DataSet14
        '
        Me.Cooperativa3DataSet14.DataSetName = "Cooperativa3DataSet14"
        Me.Cooperativa3DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CasilleroBindingSource1
        '
        Me.CasilleroBindingSource1.DataMember = "Casillero"
        Me.CasilleroBindingSource1.DataSource = Me.Cooperativa3DataSet14
        '
        'CasilleroTableAdapter1
        '
        Me.CasilleroTableAdapter1.ClearBeforeFill = True
        '
        'Cooperativa3DataSet15
        '
        Me.Cooperativa3DataSet15.DataSetName = "Cooperativa3DataSet15"
        Me.Cooperativa3DataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CasilleroBindingSource2
        '
        Me.CasilleroBindingSource2.DataMember = "Casillero"
        Me.CasilleroBindingSource2.DataSource = Me.Cooperativa3DataSet15
        '
        'CasilleroTableAdapter2
        '
        Me.CasilleroTableAdapter2.ClearBeforeFill = True
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox5.Location = New System.Drawing.Point(817, 370)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(214, 24)
        Me.TextBox5.TabIndex = 47
        Me.TextBox5.Text = "Costo"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Casilleros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1314, 550)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.seccionTxt)
        Me.Controls.Add(Me.nAsociadoTxt)
        Me.Controls.Add(Me.nombreTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Casilleros"
        Me.Text = "Casilleros"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasilleroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReactDataSet13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa3DataSet14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasilleroBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa3DataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasilleroBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents seccionTxt As TextBox
    Friend WithEvents nAsociadoTxt As TextBox
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ReactDataSet13 As ReactDataSet13
    Friend WithEvents CasilleroBindingSource As BindingSource
    Friend WithEvents CasilleroTableAdapter As ReactDataSet13TableAdapters.CasilleroTableAdapter
    Friend WithEvents Cooperativa3DataSet14 As Cooperativa3DataSet14
    Friend WithEvents CasilleroBindingSource1 As BindingSource
    Friend WithEvents CasilleroTableAdapter1 As Cooperativa3DataSet14TableAdapters.CasilleroTableAdapter
    Friend WithEvents Cooperativa3DataSet15 As Cooperativa3DataSet15
    Friend WithEvents CasilleroBindingSource2 As BindingSource
    Friend WithEvents CasilleroTableAdapter2 As Cooperativa3DataSet15TableAdapters.CasilleroTableAdapter
    Friend WithEvents TextBox5 As TextBox
End Class
