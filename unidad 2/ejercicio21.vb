Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Integer

        Console.WriteLine("ingrese el primer numero :")
        a = Console.ReadLine
        Console.WriteLine("ingrese el segundo numero :")
        b = Console.ReadLine

        If a = b Then
            Console.WriteLine(a & " es igual a " & b)
        ElseIf a < b Then
            Console.WriteLine(a & " es menor que " & b)
        Else
            Console.WriteLine(a & " es mayor que " & b)

        End If



        Console.ReadKey()
        Call ejercicio202.main()

    End Sub

End Module
