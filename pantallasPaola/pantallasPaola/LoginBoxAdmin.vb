Public Class LoginBoxAdmin
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click

        'Funcionalidad provisional para test el login de la app. Luego, link con la database de los usernames & passwords'


        'Asigna Username'
        TextBox_User.Text = "paola"

        'Validar Password'
        If (TextBox_Password.Text = "123456") Then
            Dim LoginAdmin As New LoginAdmin
            LoginAdmin.Show()
            Me.Close()
            Dim Homepage As New Homepage
            Homepage.Close()
        Else
            MessageBox.Show("The password entered is incorrect.")

        End If

    End Sub

    Private Sub TextBox_Password_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Password.TextChanged
    End Sub

    Private Sub TextBox_User_TextChanged(sender As Object, e As EventArgs) Handles TextBox_User.TextChanged

    End Sub
End Class