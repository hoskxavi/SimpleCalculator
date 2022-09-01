'Xavier Hoskins
'RCET0265
'Spring 2022
'Simple Calculator
'https://github.com/hoskxavi/SimpleCalculator.git

Option Explicit On
Option Strict On

Imports System

Module Program
    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim result As Integer
        Dim sign As String = "0"

        Console.Write("Please enter a number:")
        firstNumber = CInt(Console.ReadLine())
        Console.Write("Enter a second number:")
        secondNumber = CInt(Console.ReadLine())
        Console.WriteLine("Select an option:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Multiply")
        userInput = Console.ReadLine()

        Select Case userInput
            Case "1"
                result = firstNumber + secondNumber
                sign = "+"
            Case "2"
                result = firstNumber * secondNumber
                sign = "*"
        End Select

        Console.Write(firstNumber)
        Console.Write(sign)
        Console.Write(secondNumber)
        Console.Write("=")
        Console.WriteLine(result)

    End Sub
End Module
