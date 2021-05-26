Imports System.Data.SqlClient

Module Module1
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public adaptador As New SqlDataAdapter
    Public respuesta As SqlDataReader
    Public datos As DataSet

    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Análisis\Kardex\Kardex\Database1.mdf;Integrated Security=True"
            conexion.Open()

            estado = "conectado"
        Catch ex As Exception
            estado = "desconectado"
        End Try
    End Sub

    'Sub Combo(ByVal cb As ComboBox)
    'Try
    '        comando = New SqlCommand("SELECT Nombre_Producto FROM Productos", conexion)
    '        respuesta = comando.ExecuteReader

    '        While respuesta.Read
    '            ComboBox1.Items.Add(respuesta.Item("Nombre_Producto"))

    '        End While
    '        respuesta.Close()

    '    Catch ex As Exception

    'End Try
    'End Sub


End Module
