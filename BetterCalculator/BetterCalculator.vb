'Jacob Horsley 
'Spring 2025
'RCET 2265
'Better Calculator
' 

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim getOutofHere As Boolean = False
        Dim userInput As String

        Do
            'Get first number from user
            'Always runs at least once
            'run until valid number or user quits
            Do
                Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quit.")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered {userInput}")

                Try
                    firstNumber = CInt(userInput)
                    getOutofHere = True

                Catch ex As Exception
                    If userInput <> "Q" Then

                        Console.WriteLine("Please enter a whole number")

                    Else
                        getOutofHere = True
                        Console.WriteLine("Have a nice day")
                    End If
                End Try


            Loop Until getOutofHere = True

            'get second number from user
            'only runs if user has not already quit
            'run until valid number or user quits
            getOutofHere = False 'reset flag
            Do While userInput <> "Q" And getOutofHere = False
                Console.WriteLine("Choose a Number")
                userInput = Console.ReadLine()
                Console.WriteLine($"you entered {userInput}")

                Try
                    secondNumber = CInt(userInput)
                    getOutofHere = True

                Catch ex As Exception
                    If userInput <> "Q" Then
                        Console.WriteLine($"{userInput} is not a whole number")
                    Else
                        getOutofHere = True
                        Console.WriteLine("Have a nice day.")
                        Exit Sub
                    End If
                End Try
            Loop


            'get user choice only runs if user has not already quit
            'run until valid choice or user quits

            Console.WriteLine("Choose one of the following options" & vbNewLine _
              & "1. add" & vbNewLine _
              & "2. Subtract" & vbNewLine _
              & "3. Multiply" & vbNewLine _
              & "4. Divide")

            userInput = Console.ReadLine() ' user decides

            'Results of userInput

            If userInput = "1" Then
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
            ElseIf userInput = "2" Then
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
            ElseIf userInput = "3" Then
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
            ElseIf userInput = "4" Then
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
            ElseIf userInput = "Q" Then
                Console.WriteLine("Have a nice day")
            Else
                Console.WriteLine($"You entered {userInput}")
            End If

        Loop While userInput <> "Q"


    End Sub

End Module
