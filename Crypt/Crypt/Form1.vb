Public Class Menu_Encrypt
    Private Sub Encryption_Encrypt_Enter_Click(sender As Object, e As EventArgs) Handles Encryption_Encrypt_Enter.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Encryption_Encrypt_Help.Text = "--- Initialised ---"
    End Sub

End Class

Public MustInherit Class Cryption
    Private Decrpyted_Text As String
    Public Property Decrypted_Text_Out() As String
        Get
            Return Decrpyted_Text
        End Get
        Set(ByVal value As String)
            Decrpyted_Text = value
        End Set
    End Property

    Private Encrypted_Text As String
    Public Property Encrypted_Text_Out() As String
        Get
            Return Encrypted_Text
        End Get
        Set(ByVal value As String)
            Encrypted_Text = value
        End Set
    End Property

    Public MustOverride Sub Coalation()

End Class