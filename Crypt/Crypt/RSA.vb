Imports System.Numerics
Module RSA

    Dim Original_Message, Encrypted_Message, Prime_P, Prime_Q, Public_Key As BigInteger
    Dim Public_Exponant, Private_Exponant, Phi_Public_Key As BigInteger
    Dim MUE, CUD As BigInteger
    Dim Error_Count As Integer

    Function LargeFloor(ByVal x As Long, ByVal y As Long) As Decimal
        Dim x1 As Decimal = Convert.ToDecimal(x)
        Dim y1 As Decimal = Convert.ToDecimal(y)
        Return Math.Floor(x1 / y1)
    End Function

    Function Find_d(ByVal Phi As Long, ByVal e As BigInteger, ByVal p As BigInteger, ByVal q As BigInteger, ByVal n As BigInteger)
        Dim Table(2, 1), Temp As Long
        Dim d As BigInteger
        'Phi = 40
        'e = 7
        Const left As Integer = 0
        Const right As Integer = 1
        Const top As Integer = 0
        Const middle As Integer = 1
        Const bottom As Integer = 2

        Table(top, left) = Phi
        Table(top, right) = Phi
        Table(middle, left) = e
        Table(middle, right) = 1
        Try
            Do

                Temp = (Table(top, left) \ Table(middle, left))
                Table(bottom, left) = Temp * Table(middle, left)
                Table(bottom, right) = Temp * Table(middle, right)

                Table(bottom, left) = Table(top, left) - Table(bottom, left)
                Table(bottom, right) = Table(top, right) - Table(bottom, right)

                Do Until Table(bottom, right) > 0 'This deals with the negative number mod positive number case if (middle, right) is less than or equal to 0
                    Table(bottom, right) = Table(bottom, right) - (Phi * LargeFloor(Table(bottom, right), Phi))
                    Menu_Crypt.Encryption_Encrypt_Help.Text = Menu_Crypt.Encryption_Encrypt_Help.Text & "@|" & Environment.NewLine
                Loop

                'Moves each row up 1
                Table(top, left) = Table(middle, left)
                Table(middle, left) = Table(bottom, left)
                Table(bottom, left) = 0

                Table(top, right) = Table(middle, right)
                Table(middle, right) = Table(bottom, right)
                Table(bottom, right) = 0
                Temp = 0
                Menu_Crypt.Encryption_Encrypt_Help.Text = Menu_Crypt.Encryption_Encrypt_Help.Text & ".|" & Environment.NewLine
            Loop Until Table(middle, left) = 1
            d = Table(middle, right)
            Return d
        Catch ex As Exception
            Menu_Crypt.Encryption_Encrypt_Help.Text = Menu_Crypt.Encryption_Encrypt_Help.Text & "p: " & p.ToString & ", q: " & q.ToString & ", n: " & n.ToString & ", Phi: " & Phi.ToString & ", e: " & e.ToString & ", d: " & d.ToString & Environment.NewLine & ex.ToString & Environment.NewLine
        End Try

    End Function

    Public Function Encryption_Method()
        Dim Response As Integer
        Response = InputBox("Please select one of the following: " & Environment.NewLine &
            "[1] Sieve of Eratosthenes" & Environment.NewLine & "[2] Sieve of Sundaram" & Environment.NewLine & "[3] Sieve of Atkin" & Environment.NewLine)
        Do
            Prime_P = Find_Prime(Response)
            Prime_Q = Find_Prime(Response)
        Loop Until Prime_P <> Prime_Q And Prime_P <> Original_Message And Prime_Q <> Original_Message And Prime_P > 100 And Prime_Q > 100

        Public_Key = BigInteger.Multiply(Prime_P, Prime_Q)
        Phi_Public_Key = (Prime_P - 1) * (Prime_Q - 1)

        Do
            Public_Exponant = Find_Prime(Response)
        Loop Until Public_Exponant < Phi_Public_Key And 1 < Public_Exponant And Public_Exponant <> Prime_P And Public_Exponant <> Prime_Q And BigInteger.GreatestCommonDivisor(Public_Exponant, Phi_Public_Key) = 1 And BigInteger.GreatestCommonDivisor(Public_Exponant, Public_Key) = 1 And Public_Exponant <> Original_Message And Public_Exponant < 100

        MUE = BigInteger.Pow(Original_Message, Public_Exponant)
        Encrypted_Message = MUE Mod Public_Key
        Return Encrypted_Message
    End Function

    Public Function Decryption_Method()


        Return Original_Message
    End Function

End Module