Imports MySql.Data.MySqlClient
Public Class Primeros
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim das1 As DataSet
    Dim resultado As Integer
    Dim adap1 As MySqlDataAdapter
    Dim cadenaconexion As String = "server=127.0.0.1;database=restaurante;user id=root2;password=root2;port=3306"

    Private Sub Primeros_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ControlBox = False
        Dim cnn As New MySqlConnection(cadenaconexion)
        sql = "SELECT IdProducto,Nombre,Precio,Descripcion  FROM productos WHERE Orden like '" & 1 & "'"
        Dim cmd As New MySqlCommand(sql, cnn)
        adap1 = New MySqlDataAdapter(cmd)
        das1 = New DataSet

        Try
            cnn.Open()
            adap1.Fill(das1, "productos")
            Me.DataGridView1.DataSource = das1.Tables("productos")
            DataGridView1.Columns(0).Width = 60
            DataGridView1.Columns(1).Width = 100
            DataGridView1.Columns(2).Width = 60
            DataGridView1.Columns(3).Width = 400


        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        cnn.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class