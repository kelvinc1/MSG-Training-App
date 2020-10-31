Public Class Profile
    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Certificates As New Certificates
        Certificates.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Homepage As New Homepage
        Homepage.Show() 'Función para que se muestre el homepage cuando se aprete el botón de Go Back'
        Me.Hide() 'Cierra la pantalla abierta actual, en este caso el Profile del Admin'
    End Sub
End Class