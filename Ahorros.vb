Imports System.Data.SqlClient

Public Class Ahorros
    Private Sub Ahorros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "SELECT * FROM AhorrosCorte"
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Function VerificarIdEnTabla(Id As String) As Boolean
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "SELECT COUNT(*) FROM AhorrosCorte WHERE Identificacion = @Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", Id)

                connection.Open()

                Dim count As Integer = CInt(command.ExecuteScalar())

                Return count > 0
            End Using
        End Using
    End Function
    Private Function ObtenerDineroActual(Id As String) As Decimal
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "SELECT totalAhorrado FROM AhorrosCorte WHERE Identificacion = @Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Id", Id)

                connection.Open()

                Dim dinero As Object = command.ExecuteScalar()
                If dinero IsNot Nothing AndAlso Not DBNull.Value.Equals(dinero) Then
                    Return Decimal.Parse(dinero)
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function
    Private Sub ActualizarDinero(Id As String, montoSumar As Integer)
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "UPDATE AhorrosCorte SET totalAhorrado = @NuevoDinero WHERE Identificacion = @Id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@NuevoDinero", CStr(montoSumar))
                command.Parameters.AddWithValue("@Id", Id)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TextBox4.Text = "CTPFVJ.Coopefevol" Then
            Dim id As String = identificacionTxt.Text
            Dim monto As String = montoTxt.Text
            Dim idEncargado As String = identificacionEncargadoTxt.Text
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim fechaActual As DateTime = DateTime.Now
            Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")
            Dim query As String = "INSERT INTO Ahorros (Identificacion, Ahorrado,Retirado, identificacionEncargado, Fecha) VALUES (@Valor1, @Valor2, 0,@Valor4, @Valor5)"
            Dim encontrado As Boolean = VerificarIdEnTabla(id)

            If encontrado Then
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        ' Parámetros para los valores que deseas agregar
                        command.Parameters.AddWithValue("@Valor1", id)
                        command.Parameters.AddWithValue("@Valor2", monto)
                        command.Parameters.AddWithValue("@Valor4", idEncargado)
                        command.Parameters.AddWithValue("@Valor5", fechaFormateada)

                        connection.Open()
                        command.ExecuteNonQuery()
                    End Using
                End Using
                Dim montoSumar As Integer = CInt(monto)
                Dim dineroActual As Integer = ObtenerDineroActual(id)
                Dim nuevoDinero As Integer = dineroActual + montoSumar

                ActualizarDinero(id, nuevoDinero)

                MessageBox.Show("Dinero actualizado correctamente. Nuevo saldo: " & nuevoDinero.ToString())
            Else
                MessageBox.Show("La identificacion que ingresaste no es de un asociado.")
            End If
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = "CTPFVJ.Coopefevol" Then
            Dim id As String = TextBox3.Text
            Dim monto As String = TextBox2.Text
            Dim idEncargado As String = TextBox1.Text
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim fechaActual As DateTime = DateTime.Now
            Dim fechaFormateada As String = fechaActual.ToString("dd-MM-yyyy")
            Dim query As String = "INSERT INTO Ahorros (Identificacion, Ahorrado,Retirado, identificacionEncargado, Fecha) VALUES (@Valor1,0, @Valor2,@Valor4, @Valor5)"
            Dim encontrado As Boolean = VerificarIdEnTabla(id)

            If encontrado Then

                Dim dineroActual As Decimal = ObtenerDineroActual(id)
                Dim nuevoDinero As Decimal = dineroActual - Decimal.Parse(monto)
                If nuevoDinero > 0 Then
                    ActualizarDinero(id, nuevoDinero.ToString())
                    Using connection As New SqlConnection(connectionString)
                        Using command As New SqlCommand(query, connection)
                            ' Parámetros para los valores que deseas agregar
                            command.Parameters.AddWithValue("@Valor1", id)
                            command.Parameters.AddWithValue("@Valor2", monto)
                            command.Parameters.AddWithValue("@Valor4", idEncargado)
                            command.Parameters.AddWithValue("@Valor5", fechaFormateada)

                            connection.Open()
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Dinero retirado correctamente. Nuevo saldo: " & nuevoDinero.ToString())
                Else
                    MessageBox.Show("La cuenta quedaria en menos cero, retiro no hecho.")
                End If


            Else
                MessageBox.Show("La identificacion que ingresaste no es de un asociado.")
            End If
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class