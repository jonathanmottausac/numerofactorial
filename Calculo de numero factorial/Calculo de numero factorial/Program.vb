Imports System

Module Program
    Sub Main(args As String())
        Dim num, fact As Integer
        fact = 1
        Console.Write("Ingrese el numero a calcular: ")
        num = Integer.Parse(Console.ReadLine())
        For i = num To 2 Step -1
            fact *= i
        Next
        Console.WriteLine("{0}! = {1}", num, fact)
        Console.Read()
    End Sub
End Module
