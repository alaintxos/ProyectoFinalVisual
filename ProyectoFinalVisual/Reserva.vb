Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class Reserva
    Dim cnn As MySqlConnection
    Dim sql As String
    Dim resultado As Integer
    Dim cadenaconexion As String = "server=127.0.0.1;database=restaurante;user id=root2;password=root2;port=3306"
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        TextBox3.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()

    End Sub

    Private Sub Reserva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.MinDate = Date.Today
        Me.ControlBox = False
        Dim coon As New MySqlConnection(cadenaconexion)
        Try
            coon.Open()

        Catch ex As Exception
            MsgBox("Fallo en la conexión")
        End Try
        coon.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim hora As String

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.SelectedItem = Nothing Or ComboBox2.SelectedItem = Nothing Then
            MsgBox("Faltan campos por reyenar", MsgBoxStyle.Exclamation)
        Else
            hora = ComboBox1.SelectedItem.ToString & ":" & ComboBox2.SelectedItem.ToString
            MsgBox(hora)
            cnn = New MySqlConnection(cadenaconexion)
            sql = "INSERT INTO reservas (Nombre,Telefono,Numero,Fecha,Hora) values (@nombre,@Telefono,@Numero,@Fecha,@Hora)"
            Dim cmd As New MySqlCommand(sql, cnn)
            cmd.Parameters.AddWithValue("@nombre", Me.TextBox1.Text)
            cmd.Parameters.AddWithValue("@Telefono", Me.TextBox2.Text)
            cmd.Parameters.AddWithValue("@Numero", Me.NumericUpDown1.Value.ToString)
            cmd.Parameters.AddWithValue("@Fecha", Me.TextBox3.Text)
            cmd.Parameters.AddWithValue("@Hora", hora)

            Try
                cnn.Open()
                resultado = cmd.ExecuteNonQuery()
                MsgBox("Reserva realizada con exito")
                Dim message As New MailMessage
                Dim smtp As New SmtpClient

                With message
                    .From = New System.Net.Mail.MailAddress("alaintxos7@gmail.com")
                    .To.Add("alain.mansodi@gmail.com")
                    .Body = "Encantados de tenerte como cliente"
                    .Subject = "reservarealizada"
                    .Priority = System.Net.Mail.MailPriority.Normal

                End With
                With smtp
                    .EnableSsl = True
                    .Port = "587"
                    .Host = "smtp.gmail.com"
                    .Credentials = New Net.NetworkCredential("alaintxos7@gmail.com", "Remoto01")
                    .Send(message)

                End With
                Try
                    MessageBox.Show("Su mensaje de correo ha sido enviado.", "Correo enviado", MessageBoxButtons.OK)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error al enviar correo", MessageBoxButtons.OK)
                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If cnn.State = ConnectionState.Open Then
                    cnn.Close()
                End If
            End Try
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub
End Class