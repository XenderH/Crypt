Imports System.Numerics
Module Prime_Numbers

    Function Find_Prime(ByVal Choice As String)
        Select Case Choice
            Case 1
                Return Eratosthenes()
            Case 2
                Return Sundaram()
            Case 3
                Return Atkin()
            Case Else
                Return Eratosthenes() 'Default sieve
        End Select
    End Function

    Function Eratosthenes()

        'List set up
        Dim n As BigInteger = 500
        Dim Max As BigInteger = Math.Sqrt(n)
        Dim Primes As List(Of BigInteger) = New List(Of BigInteger)
        Dim i As BigInteger
        For i = 2 To n
            Primes.Add(i)
        Next

        'Prime checking
        For i = 2 To Max

            If Primes.Contains(i) Then

                For k = i + 1 To n

                    If Primes.Contains(k) Then

                        If (k Mod i) = 0 Then
                            Primes.Remove(k)
                        End If

                    End If
                Next
            End If
        Next

        'Convert and output
        Dim RandomNumber As New Random
        Dim Prim() As BigInteger
        Prim = Primes.ToArray
        Return Prim(RandomNumber.Next(2, Prim.LongLength))

    End Function

    Function Sundaram()

    End Function

    Function Atkin()

    End Function

End Module
