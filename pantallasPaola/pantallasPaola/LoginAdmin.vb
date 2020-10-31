Public Class LoginAdmin
    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim Homepage As New Homepage
        Homepage.Show() 'Función para que se muestre el homepage cuando se aprete el botón de Go Back'
        Me.Close() 'Cierra la pantalla abierta actual, en este caso el Profile del Admin'
    End Sub
End Class