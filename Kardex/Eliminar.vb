Public Class Eliminar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim productos As String = TextBoxNombre.Text


        Dim consulta As String = "DELETE FROM Productos WHERE Nombre_Producto = '" & productos & "'"

        Module1.adaptador = New SqlClient.SqlDataAdapter(consulta, Module1.conexion)
        Module1.datos = New DataSet
        adaptador.Fill(datos, "Productos")

        TextBoxNombre.Clear()
        TextBoxNombre.Focus()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As String = "SELECT * FROM Productos"

        Module1.adaptador = New SqlClient.SqlDataAdapter(consulta, Module1.conexion)
        Module1.datos = New DataSet
        adaptador.Fill(datos, "Productos")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "Productos"
    End Sub
End Class