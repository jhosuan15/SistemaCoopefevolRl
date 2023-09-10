Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Activos
    Private Sub Activos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Cooperativa3DataSet2.ActivosFijos' Puede moverla o quitarla según sea necesario.
        Me.ActivosFijosTableAdapter1.Fill(Me.Cooperativa3DataSet2.ActivosFijos)
        'TODO: esta línea de código carga datos en la tabla 'Cooperativa2DataSet.ActivosFijos' Puede moverla o quitarla según sea necesario.
        Me.ActivosFijosTableAdapter.Fill(Me.Cooperativa2DataSet.ActivosFijos)
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "SELECT * FROM ActivosFijos"
        Dim connection As New SqlConnection(connectionString)
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)

        DataGridView1.DataSource = dataTable
        ' Calcula el ancho total de todas las columnas
        Dim totalColumnWidth As Integer = 0
        For Each column As DataGridViewColumn In DataGridView1.Columns
            totalColumnWidth += column.Width
        Next



        ' Establece el ancho proporcional para cada columna
        For Each column As DataGridViewColumn In DataGridView1.Columns
            column.Width = CInt((column.Width / totalColumnWidth) * DataGridView1.Width)
        Next
    End Sub

    Private Function VerificarIdEnTabla(Id As String) As Boolean
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "SELECT COUNT(*) FROM ActivosFijos WHERE serie = @Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", Id)

                connection.Open()

                Dim count As Integer = CInt(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim descripcionText As String = descripcion.Text
        Dim marcaText As String = marca.Text
        Dim modeloText As String = modelo.Text
        Dim serieText As String = serie.Text
        Dim estadoText As String = estado.Text
        Dim lugarText As String = lugar.Text
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")
        Dim query As String = "INSERT INTO ActivosFijos (descripcion,marca,modelo,serie,estado,lugar,fecha) VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6, @Valor7)"
        Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Parámetros para los valores que deseas agregar
                    command.Parameters.AddWithValue("@Valor1", descripcionText)
                    command.Parameters.AddWithValue("@Valor2", marcaText)
                    command.Parameters.AddWithValue("@Valor3", modeloText)
                    command.Parameters.AddWithValue("@Valor4", serieText)
                    command.Parameters.AddWithValue("@Valor5", estadoText)
                    command.Parameters.AddWithValue("@Valor6", lugarText)
                    command.Parameters.AddWithValue("@Valor7", fechaFormateada)


                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

        MessageBox.Show("Activo  Ingresado Correctamente!")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim descripcionText As String = descripcion2.Text
        Dim marcaText As String = marca2.Text
        Dim modeloText As String = modelo2.Text
        Dim serieText As String = serie2.Text
        Dim estadoText As String = estado2.Text
        Dim lugarText As String = lugar2.Text
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")
        Dim query As String = "UPDATE ActivosFijos SET descripcion=@1, marca=@2, modelo=@3, estado=@5, lugar=@6, fecha=@7 where serie=@4"
        Dim encontrado As Boolean = VerificarIdEnTabla(serieText)

        If encontrado Then
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@1", descripcionText)
                    command.Parameters.AddWithValue("@2", marcaText)
                    command.Parameters.AddWithValue("@3", modeloText)
                    command.Parameters.AddWithValue("@4", serieText)
                    command.Parameters.AddWithValue("@5", estadoText)
                    command.Parameters.AddWithValue("@6", lugarText)
                    command.Parameters.AddWithValue("@7", fechaFormateada)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Activo Actualizado Correctamente!")
        Else
            MessageBox.Show("Activo No Encontrado")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If contrasena.Text = "CTPFVJ.Coopefevol" Then
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim serieText As String = serie3.Text
            Dim query As String = "DELETE FROM ActivosFijos WHERE descripcion = @serie"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@serie", serieText)

                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Activo eliminado correctamente.")
                    Else
                        MessageBox.Show("No se encontro el Activo para eliminar.")
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If
    End Sub
End Class