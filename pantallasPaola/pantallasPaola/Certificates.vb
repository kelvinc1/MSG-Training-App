Public Class Certificates
    'Esta clase representa la ventana de certificadoos. Abre ya cuando el usuario hace login.'

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load






























    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        Dim Profile As New Profile
        Profile.Show() 'Función para que la ventana de profile se muestre cuando apretes go back button'
        Me.Hide() 'hides la ventana Certificates al apretar go back, vuelve a la ventana de profile'
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
