Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Casilleros
    Private Function VerificarIdEnTabla(Id As String) As Boolean
        Dim connectionString As String = My.Settings.ReactConnectionString

        Dim query As String = "SELECT COUNT(*) FROM Casillero WHERE NumeroCasillero = @Id"

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
        If TextBox4.Text = "CTPFVJ.Coopefevol" Then
            Dim connectionString As String = My.Settings.ReactConnectionString
            Dim query As String = "INSERT INTO Casillero (NombreCompleto, NumeroCasillero, Seccion, recibo, tipoDeArrendamiento, Costo) VALUES (@Valor2, @Valor5, @Valor6, @Valor7, @Valor8, @Valor9)"
            Dim bol As Boolean = VerificarIdEnTabla(TextBox3.Text)
            If bol = False Then
                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        ' Parámetros para los valores que deseas agregar
                        command.Parameters.AddWithValue("@Valor2", nombreTxt.Text)
                        command.Parameters.AddWithValue("@Valor5", TextBox3.Text)
                        command.Parameters.AddWithValue("@Valor6", seccionTxt.Text)
                        command.Parameters.AddWithValue("@Valor7", nAsociadoTxt.Text)
                        command.Parameters.AddWithValue("@Valor8", TextBox1.Text)
                        command.Parameters.AddWithValue("@Valor9", TextBox5.Text)
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Casillero Agregado Correctamente")
                    End Using
                End Using
            Else
                MessageBox.Show("Casillero Ya Se Ha Agregado")
            End If

        Else
                MessageBox.Show("Contraseña Incorrecta")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "CTPFVJ.Coopefevol" Then
            Try
                Dim connectionString As String = My.Settings.ReactConnectionString
                Dim query As String = "DELETE FROM Casillero WHERE NumeroCasillero = @Id"

                Using connection As New SqlConnection(connectionString)
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", TextBox8.Text)

                        connection.Open()
                        command.ExecuteNonQuery()

                        MessageBox.Show("Casillero Eliminado Correctamente.")
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("No existe")
            End Try
        Else
            MessageBox.Show("Contraseña Incorrecta")
        End If

    End Sub

    Private Sub Casilleros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = My.Settings.ReactConnectionString
        Dim query As String = "SELECT * FROM Casillero"
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class