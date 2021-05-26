Public Class Agregar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Nombre As String = TextBoxNombre.Text
        Dim Unidades As Integer = Val(TextBoxUnidades.Text)
        Dim Compra As Decimal = Val(TextBoxCompra.Text)
        Dim Venta As Decimal = Val(TextBoxVenta.Text)

        Dim consulta As String = "INSERT INTO Productos(Nombre_Producto, Unidades, Precio_Compra, Precio_Venta, Estado_Producto) VALUES('" & Nombre & "', " & Unidades & ", " & Compra & ", " & Venta & ", 'A')"

        Module1.adaptador = New SqlClient.SqlDataAdapter(consulta, Module1.conexion)
        Module1.datos = New DataSet
        adaptador.Fill(datos, "Productos")

        TextBoxNombre.Clear()
        TextBoxUnidades.Clear()
        TextBoxCompra.Clear()
        TextBoxVenta.Clear()
        TextBoxNombre.Focus()



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim consulta As String = "SELECT * FROM Productos"

        Module1.adaptador = New SqlClient.SqlDataAdapter(consulta, Module1.conexion)
        Module1.datos = New DataSet
        adaptador.Fill(datos, "Productos")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "Productos"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class