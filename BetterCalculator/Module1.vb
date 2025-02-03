Module Module1

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim getOutofHere As Boolean = False
        Dim userinput As String

        Console.WriteLine("Please enter two numbers. Enter 'Q' at any time to quite")
        Console.WriteLine()

        Do
            'Get first number from user
            'Always runs at least once
            'run until valid number or user quits
            Do
                Console.WriteLine("Choose a Number")
                userinput = Console.ReadLine()
                Console.WriteLine($"you entered {userinput}")

                Try
                    firstNumber = CInt(userinput)
                    getOutofHere = True

                Catch ex As Exception
                    If userinput <> "Q" Then
                        Console.WriteLine($"You entered {userinput},
                            please enter a whole number")

                    Else
                        getOutofHere = True
                    End If
                End Try

            Loop Until getOutofHere = True

            'get second number from user
            'only runs if user has not already quit
            'run until valid number or user quits
            getOutofHere = False 'reset flag
            Do While userinput <> "Q" And getOutofHere = False
                Console.WriteLine("Choose a Number")
                userinput = Console.ReadLine()
                Console.WriteLine($"you entered {userinput}")

                Try
                    secondNumber = CInt(userinput)
                    getOutofHere = True

                Catch ex As Exception
                    If userinput <> "Q" Then
                        Console.WriteLine($"Userinput is not a whole number")
                    Else
                        getOutofHere = True
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

            userinput = Console.ReadLine() ' user decides

            'Results of userInput

            If userinput = "1" Then
                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
            ElseIf userinput = "2" Then
                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
            ElseIf userinput = "3" Then
                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}")
            ElseIf userinput = "4" Then
                Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}")
            Else
                Console.WriteLine($"You entered {userinput}")
            End If

        Loop While userinput <> "Q"


    End Sub

End Module
