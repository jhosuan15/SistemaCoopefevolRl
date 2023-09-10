Imports System.Data.SqlClient
Imports System.Threading

Public Class Asociados
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Asociados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "SELECT * FROM Asociados"
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

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If TextBox4.Text = "CTPFVJ.Coopefevol" Then
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim query As String = "INSERT INTO Asociados (Identificacion, NombreCompleto, Telefono, Sinpe, Seccion, numeroAsociado,Correo,Calidad) VALUES (@Valor1, @Valor2, @Valor5, @Valor6, @Valor7, @Valor8, @Valor9,@valor10)"
            Dim query2 As String = "INSERT INTO AhorrosCorte (Identificacion, NombreCompleto,totalAhorrado,interes,comision,interesSubcuenta,Correo) VALUES (@Valor1, @valor2,0,0,0,0,@Valor5)"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Parámetros para los valores que deseas agregar
                    command.Parameters.AddWithValue("@Valor1", identificacionTxt.Text)
                    command.Parameters.AddWithValue("@Valor2", nombreTxt.Text)

                    command.Parameters.AddWithValue("@Valor5", telefonoTxt.Text)
                    command.Parameters.AddWithValue("@Valor6", sinpeTxt.Text)
                    command.Parameters.AddWithValue("@Valor7", seccionTxt.Text)
                    command.Parameters.AddWithValue("@Valor8", nAsociadoTxt.Text)
                    command.Parameters.AddWithValue("@Valor9", TextBox1.Text)
                    command.Parameters.AddWithValue("@Valor10", TextBox3.Text)

                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Asociado Agregado Correctamente")
                End Using
            End Using
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query2, connection)
                    ' Parámetros para los valores que deseas agregar
                    command.Parameters.AddWithValue("@Valor1", identificacionTxt.Text)
                    command.Parameters.AddWithValue("@Valor2", nombreTxt.Text)
                    command.Parameters.AddWithValue("@Valor5", TextBox1.Text)
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Asociado Agregado Correctamente")
                End Using
            End Using
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "CTPFVJ.Coopefevol" Then
            Try
                Dim connectionString As String = My.Settings.ReactConnectionString
                Dim query As String = "DELETE FROM Asociados WHERE Identificacion = @Id"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", TextBox8.Text)

                        connection.Open()
                        command.ExecuteNonQuery()

                        MessageBox.Show("Asociado Eliminado Correctamente.")
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("No existe")
            End Try
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "UPDATE Asociados SET @dato = @nuevo where Identificacion = @id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@dato", ComboBox1.SelectedItem)
                command.Parameters.AddWithValue("@nuevo", TextBox6.Text)
                command.Parameters.AddWithValue("@id", TextBox7.Text)

                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using


        MessageBox.Show("Asociado Actualizado Correctamente.")

    End Sub
End Class