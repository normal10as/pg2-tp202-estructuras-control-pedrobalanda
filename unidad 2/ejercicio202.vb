Module ejercicio202
    Sub main()


        Dim a As Integer
        Dim b As Integer
        Dim c As Integer


        Console.WriteLine("ingrese el primer numero")
        a = Console.ReadLine()
        Console.WriteLine("ingrese el segundo valor")
        b = Console.ReadLine()
        Console.WriteLine("ingrese el tercer valor")
        c = Console.ReadLine()

        If (a > b) And (a > c) Then

            Console.WriteLine("el mayor es " & a)
            

        ElseIf (b > c) Then
            Console.WriteLine("el mayor es " & b)
        Else
            Console.WriteLine("el mayor es " & c)


        End If

        Console.ReadKey()

    End Sub

End Module
