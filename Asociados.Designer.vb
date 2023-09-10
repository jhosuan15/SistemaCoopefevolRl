<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asociados
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AsociadosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cooperativa3DataSet20 = New Inicio.Cooperativa3DataSet20()
        Me.AsociadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cooperativa2DataSet1 = New Inicio.Cooperativa2DataSet1()
        Me.identificacionTxt = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nombreTxt = New System.Windows.Forms.TextBox()
        Me.telefonoTxt = New System.Windows.Forms.TextBox()
        Me.nAsociadoTxt = New System.Windows.Forms.TextBox()
        Me.seccionTxt = New System.Windows.Forms.TextBox()
        Me.sinpeTxt = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.AsociadosTableAdapter = New Inicio.Cooperativa2DataSet1TableAdapters.AsociadosTableAdapter()
        Me.AsociadosTableAdapter1 = New Inicio.Cooperativa3DataSet20TableAdapters.AsociadosTableAdapter()
        Me.Cooperativa3DataSet27 = New Inicio.Cooperativa3DataSet27()
        Me.AsociadosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AsociadosTableAdapter2 = New Inicio.Cooperativa3DataSet27TableAdapters.AsociadosTableAdapter()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsociadosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa3DataSet20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsociadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cooperativa3DataSet27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AsociadosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(783, 580)
        Me.DataGridView1.TabIndex = 2
        '
        'AsociadosBindingSource1
        '
        Me.AsociadosBindingSource1.DataMember = "Asociados"
        Me.AsociadosBindingSource1.DataSource = Me.Cooperativa3DataSet20
        '
        'Cooperativa3DataSet20
        '
        Me.Cooperativa3DataSet20.DataSetName = "Cooperativa3DataSet20"
        Me.Cooperativa3DataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsociadosBindingSource
        '
        Me.AsociadosBindingSource.DataMember = "Asociados"
        Me.AsociadosBindingSource.DataSource = Me.Cooperativa2DataSet1
        '
        'Cooperativa2DataSet1
        '
        Me.Cooperativa2DataSet1.DataSetName = "Cooperativa2DataSet1"
        Me.Cooperativa2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'identificacionTxt
        '
        Me.identificacionTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.identificacionTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.identificacionTxt.Location = New System.Drawing.Point(823, 134)
        Me.identificacionTxt.Name = "identificacionTxt"
        Me.identificacionTxt.Size = New System.Drawing.Size(214, 24)
        Me.identificacionTxt.TabIndex = 9
        Me.identificacionTxt.Text = "Identificacion"
        Me.identificacionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregar.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Location = New System.Drawing.Point(849, 603)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(146, 44)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(818, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Agregar asociado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(671, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 29)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ASOCIADOS"
        '
        'nombreTxt
        '
        Me.nombreTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nombreTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nombreTxt.Location = New System.Drawing.Point(823, 183)
        Me.nombreTxt.Name = "nombreTxt"
        Me.nombreTxt.Size = New System.Drawing.Size(214, 24)
        Me.nombreTxt.TabIndex = 13
        Me.nombreTxt.Text = "Nombre Completo"
        Me.nombreTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'telefonoTxt
        '
        Me.telefonoTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.telefonoTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.telefonoTxt.Location = New System.Drawing.Point(823, 235)
        Me.telefonoTxt.Name = "telefonoTxt"
        Me.telefonoTxt.Size = New System.Drawing.Size(214, 24)
        Me.telefonoTxt.TabIndex = 16
        Me.telefonoTxt.Text = "Telefono"
        Me.telefonoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nAsociadoTxt
        '
        Me.nAsociadoTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.nAsociadoTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.nAsociadoTxt.Location = New System.Drawing.Point(823, 403)
        Me.nAsociadoTxt.Name = "nAsociadoTxt"
        Me.nAsociadoTxt.Size = New System.Drawing.Size(214, 24)
        Me.nAsociadoTxt.TabIndex = 17
        Me.nAsociadoTxt.Text = "Numero Asociado"
        Me.nAsociadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'seccionTxt
        '
        Me.seccionTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.seccionTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.seccionTxt.Location = New System.Drawing.Point(823, 344)
        Me.seccionTxt.Name = "seccionTxt"
        Me.seccionTxt.Size = New System.Drawing.Size(214, 24)
        Me.seccionTxt.TabIndex = 18
        Me.seccionTxt.Text = "Seccion"
        Me.seccionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sinpeTxt
        '
        Me.sinpeTxt.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.sinpeTxt.ForeColor = System.Drawing.Color.MidnightBlue
        Me.sinpeTxt.Location = New System.Drawing.Point(823, 288)
        Me.sinpeTxt.Name = "sinpeTxt"
        Me.sinpeTxt.Size = New System.Drawing.Size(214, 24)
        Me.sinpeTxt.TabIndex = 19
        Me.sinpeTxt.Text = "Sinpe Movil"
        Me.sinpeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox8.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox8.Location = New System.Drawing.Point(1089, 130)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(214, 24)
        Me.TextBox8.TabIndex = 22
        Me.TextBox8.Text = "Identificacion"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1120, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 44)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(1071, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 29)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Eliminar asociado"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox1.Location = New System.Drawing.Point(823, 462)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(214, 24)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Text = "Correo"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox4.Location = New System.Drawing.Point(823, 567)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(214, 20)
        Me.TextBox4.TabIndex = 25
        Me.TextBox4.Text = "Contraseña"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox2.Location = New System.Drawing.Point(1089, 186)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(214, 20)
        Me.TextBox2.TabIndex = 26
        Me.TextBox2.Text = "Contraseña"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox3.Location = New System.Drawing.Point(823, 518)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(214, 24)
        Me.TextBox3.TabIndex = 27
        Me.TextBox3.Text = "F:Funcionario E:Estudiante"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AsociadosTableAdapter
        '
        Me.AsociadosTableAdapter.ClearBeforeFill = True
        '
        'AsociadosTableAdapter1
        '
        Me.AsociadosTableAdapter1.ClearBeforeFill = True
        '
        'Cooperativa3DataSet27
        '
        Me.Cooperativa3DataSet27.DataSetName = "Cooperativa3DataSet27"
        Me.Cooperativa3DataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AsociadosBindingSource2
        '
        Me.AsociadosBindingSource2.DataMember = "Asociados"
        Me.AsociadosBindingSource2.DataSource = Me.Cooperativa3DataSet27
        '
        'AsociadosTableAdapter2
        '
        Me.AsociadosTableAdapter2.ClearBeforeFill = True
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox5.Location = New System.Drawing.Point(1090, 492)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(214, 20)
        Me.TextBox5.TabIndex = 31
        Me.TextBox5.Text = "Contraseña"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1120, 518)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 44)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Actualizar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Location = New System.Drawing.Point(1071, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(273, 29)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Actualizar asociado"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Telefono", "Sinpe", "Seccion", "numeroAsociado", "Correo"})
        Me.ComboBox1.Location = New System.Drawing.Point(1089, 360)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(215, 21)
        Me.ComboBox1.TabIndex = 32
        Me.ComboBox1.Text = "Seleccione el dato..."
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox6.Location = New System.Drawing.Point(1090, 446)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(214, 24)
        Me.TextBox6.TabIndex = 33
        Me.TextBox6.Text = "Nuevo "
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TextBox7.Location = New System.Drawing.Point(1090, 403)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(214, 24)
        Me.TextBox7.TabIndex = 34
        Me.TextBox7.Text = "Identificacion"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Asociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1316, 652)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.sinpeTxt)
        Me.Controls.Add(Me.seccionTxt)
        Me.Controls.Add(Me.nAsociadoTxt)
        Me.Controls.Add(Me.telefonoTxt)
        Me.Controls.Add(Me.nombreTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.identificacionTxt)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Asociados"
        Me.Text = "Asociados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsociadosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa3DataSet20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsociadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cooperativa3DataSet27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AsociadosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents identificacionTxt As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nombreTxt As TextBox
    Friend WithEvents telefonoTxt As TextBox
    Friend WithEvents nAsociadoTxt As TextBox
    Friend WithEvents seccionTxt As TextBox
    Friend WithEvents sinpeTxt As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Cooperativa2DataSet1 As Cooperativa2DataSet1
    Friend WithEvents AsociadosBindingSource As BindingSource
    Friend WithEvents AsociadosTableAdapter As Cooperativa2DataSet1TableAdapters.AsociadosTableAdapter
    Friend WithEvents Cooperativa3DataSet20 As Cooperativa3DataSet20
    Friend WithEvents AsociadosBindingSource1 As BindingSource
    Friend WithEvents AsociadosTableAdapter1 As Cooperativa3DataSet20TableAdapters.AsociadosTableAdapter
    Friend WithEvents Cooperativa3DataSet27 As Cooperativa3DataSet27
    Friend WithEvents AsociadosBindingSource2 As BindingSource
    Friend WithEvents AsociadosTableAdapter2 As Cooperativa3DataSet27TableAdapters.AsociadosTableAdapter
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
End Class
