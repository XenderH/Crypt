<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Encrypt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Encryption_Encrypt_Help = New System.Windows.Forms.TextBox()
        Me.Encryption_Encrypt_Enter = New System.Windows.Forms.Button()
        Me.Encryption_Encrypted_Select = New System.Windows.Forms.ComboBox()
        Me.Encryption_Encrypted_Output = New System.Windows.Forms.TextBox()
        Me.Encryption_Encrypted_Input = New System.Windows.Forms.TextBox()
        Me.Encryption_Encrypted_Search = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Encryption_Encrypt_Help
        '
        Me.Encryption_Encrypt_Help.Location = New System.Drawing.Point(12, 67)
        Me.Encryption_Encrypt_Help.Multiline = True
        Me.Encryption_Encrypt_Help.Name = "Encryption_Encrypt_Help"
        Me.Encryption_Encrypt_Help.ReadOnly = True
        Me.Encryption_Encrypt_Help.Size = New System.Drawing.Size(333, 282)
        Me.Encryption_Encrypt_Help.TabIndex = 0
        '
        'Encryption_Encrypt_Enter
        '
        Me.Encryption_Encrypt_Enter.Location = New System.Drawing.Point(182, 39)
        Me.Encryption_Encrypt_Enter.Name = "Encryption_Encrypt_Enter"
        Me.Encryption_Encrypt_Enter.Size = New System.Drawing.Size(163, 23)
        Me.Encryption_Encrypt_Enter.TabIndex = 1
        Me.Encryption_Encrypt_Enter.Text = "Encrypt"
        Me.Encryption_Encrypt_Enter.UseVisualStyleBackColor = True
        '
        'Encryption_Encrypted_Select
        '
        Me.Encryption_Encrypted_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Encryption_Encrypted_Select.FormattingEnabled = True
        Me.Encryption_Encrypted_Select.Items.AddRange(New Object() {"Caesar Cipher", "Vigenère Cipher", "One Time Pad", "R.S.A"})
        Me.Encryption_Encrypted_Select.Location = New System.Drawing.Point(118, 12)
        Me.Encryption_Encrypted_Select.Name = "Encryption_Encrypted_Select"
        Me.Encryption_Encrypted_Select.Size = New System.Drawing.Size(121, 21)
        Me.Encryption_Encrypted_Select.TabIndex = 2
        '
        'Encryption_Encrypted_Output
        '
        Me.Encryption_Encrypted_Output.Location = New System.Drawing.Point(245, 13)
        Me.Encryption_Encrypted_Output.Name = "Encryption_Encrypted_Output"
        Me.Encryption_Encrypted_Output.Size = New System.Drawing.Size(100, 20)
        Me.Encryption_Encrypted_Output.TabIndex = 3
        '
        'Encryption_Encrypted_Input
        '
        Me.Encryption_Encrypted_Input.Location = New System.Drawing.Point(12, 12)
        Me.Encryption_Encrypted_Input.Name = "Encryption_Encrypted_Input"
        Me.Encryption_Encrypted_Input.Size = New System.Drawing.Size(100, 20)
        Me.Encryption_Encrypted_Input.TabIndex = 4
        '
        'Encryption_Encrypted_Search
        '
        Me.Encryption_Encrypted_Search.Location = New System.Drawing.Point(12, 38)
        Me.Encryption_Encrypted_Search.Name = "Encryption_Encrypted_Search"
        Me.Encryption_Encrypted_Search.Size = New System.Drawing.Size(164, 23)
        Me.Encryption_Encrypted_Search.TabIndex = 5
        Me.Encryption_Encrypted_Search.Text = "Search"
        Me.Encryption_Encrypted_Search.UseVisualStyleBackColor = True
        '
        'Menu_Encrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 361)
        Me.Controls.Add(Me.Encryption_Encrypted_Search)
        Me.Controls.Add(Me.Encryption_Encrypted_Input)
        Me.Controls.Add(Me.Encryption_Encrypted_Output)
        Me.Controls.Add(Me.Encryption_Encrypted_Select)
        Me.Controls.Add(Me.Encryption_Encrypt_Enter)
        Me.Controls.Add(Me.Encryption_Encrypt_Help)
        Me.Name = "Menu_Encrypt"
        Me.Text = "Encryption"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Encryption_Encrypt_Help As TextBox
    Friend WithEvents Encryption_Encrypt_Enter As Button
    Friend WithEvents Encryption_Encrypted_Select As ComboBox
    Friend WithEvents Encryption_Encrypted_Output As TextBox
    Friend WithEvents Encryption_Encrypted_Input As TextBox
    Friend WithEvents Encryption_Encrypted_Search As Button
End Class
