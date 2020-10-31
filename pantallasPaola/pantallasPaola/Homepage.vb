Public Class Homepage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LoginBoxEmployee As New LoginBoxEmployee
        LoginBoxEmployee.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LoginBoxAdmin As New LoginBoxAdmin
        LoginBoxAdmin.Show()

    End Sub
End Class