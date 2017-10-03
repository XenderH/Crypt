Public Class Menu_Crypt
    Private Sub Encryption_Encrypt_Enter_Click(sender As Object, e As EventArgs) Handles Encryption_Encrypt_Enter.Click
        Encryption_Method()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encryption_Encrypt_Help.Text = "--- Initialised ---"
    End Sub

End Class
