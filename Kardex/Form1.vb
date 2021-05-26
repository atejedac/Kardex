
Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet5.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter4.Fill(Me.Database1DataSet5.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet4.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter3.Fill(Me.Database1DataSet4.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet3.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter2.Fill(Me.Database1DataSet3.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet2.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter1.Fill(Me.Database1DataSet2.Productos)
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Database1DataSet1.Productos)

        enlace()
        LabelConectado.Text = estado

        'Combo(ComboBox1)'





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MessageBox.Show("Usted saldrá del programa.", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        conexion.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim consulta As String = "SELECT Id_Producto, Nombre_Producto, Unidades FROM Productos"

        Module1.adaptador = New SqlClient.SqlDataAdapter(consulta, Module1.conexion)
        Module1.datos = New DataSet
        adaptador.Fill(datos, "Productos")
        DataGridView1.DataSource = datos
        DataGridView1.DataMember = "Productos"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Agregar.Show()
        Me.Hide()
        Me.Refresh()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBoxPrecio.Text = "Q. " & Val(ComboBox1.SelectedValue)

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Eliminar.Show()
        Me.Hide()
    End Sub
End Class
