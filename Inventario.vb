Imports System.Data.SqlClient

Public Class Inventario
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Cooperativa3DataSet.Inventario' Puede moverla o quitarla según sea necesario.
        Me.InventarioTableAdapter.Fill(Me.Cooperativa3DataSet.Inventario)
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "SELECT * FROM Inventario"
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

        Dim query As String = "SELECT COUNT(*) FROM Inventario WHERE Producto = @Id"

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
        Dim id As String = identificacionTxt.Text
        Dim monto As String = montoTxt.Text
        Dim idEncargado As String = identificacionEncargadoTxt.Text
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")
        Dim query As String = "INSERT INTO Inventario (Producto,Cantidad,Precio,Fecha) VALUES (@Valor1, @Valor2, @Valor3, @Valor4)"
        Dim query2 As String = "INSERT INTO Productos (Producto,Cantidad,Precio,Fecha) VALUES (@Valor1, @Valor2, @Valor3, @Valor4)"
        Dim encontrado As Boolean = VerificarIdEnTabla(id)

        If encontrado Then

            MessageBox.Show("el Producto ya se ha ingresado")
        Else
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Parámetros para los valores que deseas agregar
                    command.Parameters.AddWithValue("@Valor1", id)
                    command.Parameters.AddWithValue("@Valor2", monto)
                    command.Parameters.AddWithValue("@Valor3", idEncargado)
                    command.Parameters.AddWithValue("@Valor4", fechaFormateada)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query2, connection)
                    ' Parámetros para los valores que deseas agregar
                    command.Parameters.AddWithValue("@Valor1", id)
                    command.Parameters.AddWithValue("@Valor2", monto)
                    command.Parameters.AddWithValue("@Valor3", idEncargado)
                    command.Parameters.AddWithValue("@Valor4", fechaFormateada)

                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Producto Ingresado Correctamente!")
        End If

    End Sub
    Private Sub ActualizarDinero(Id As String, montoSumar As String, montoSumar2 As String, fecha As String)
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "UPDATE Inventario SET Cantidad = @NuevoDinero, Precio=@precio, Fecha=@fecha WHERE Producto = @Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@precio", montoSumar2)
                command.Parameters.AddWithValue("@NuevoDinero", montoSumar)
                command.Parameters.AddWithValue("@fecha", fecha)
                command.Parameters.AddWithValue("@Id", Id)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox3.Text
        Dim monto As String = TextBox2.Text
        Dim idEncargado As String = TextBox1.Text
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim fechaActual As DateTime = DateTime.Now
        Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")

        Dim encontrado As Boolean = VerificarIdEnTabla(id)

        If encontrado Then

            ActualizarDinero(id, monto, idEncargado, fechaFormateada)

            MessageBox.Show("Producto Actualizado Correctamente.")
        Else
            MessageBox.Show("El producto no existe.")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox4.Text Then
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim producto As String = TextBox6.Text
            Dim query As String = "DELETE FROM Inventario WHERE Producto = @FechaActual"

            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FechaActual", producto)

                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Producto eliminado correctamente.")
                    Else
                        MessageBox.Show("No se encontro el producto para eliminar.")
                    End If
                End Using
            End Using
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub identificacionTxt_TextChanged(sender As Object, e As EventArgs) Handles identificacionTxt.TextChanged

    End Sub
End Class