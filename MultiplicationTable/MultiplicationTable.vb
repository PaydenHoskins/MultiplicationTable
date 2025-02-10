'Payden Hoskins
'RCET2265
'Spring 2025
'MultiplicationTable
'https://github.com/PaydenHoskins/MultiplicationTable.git

Option Explicit On
Option Strict On
Option Compare Text

Imports System.Runtime.Remoting.Services

Module MultiplicationTable

    Sub Main()
        Dim UserInput As String
        Dim NumberOne As Integer
        Dim LeaveLoop As Boolean
        LeaveLoop = False
        Dim Result As String
        Do
            Do
                Console.WriteLine("Enter ""Q"" to Leave at any point. ")
                Console.WriteLine("Enter a number to get its multiplication table: ")
                UserInput = Console.ReadLine()
                Try
                    NumberOne = CInt(UserInput)
                    If NumberOne <= 0 Then
                        LeaveLoop = True
                    ElseIf NumberOne >= 0 Then
                        LeaveLoop = True
                    ElseIf NumberOne <= -1 Then
                        LeaveLoop = True
                    End If
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole Number")
                End Try
                Console.WriteLine(StrDup(80, "*"))
            Loop Until UserInput = "Q" Or LeaveLoop = True
            LeaveLoop = False
            Console.WriteLine($"Enjoy your {NumberOne} * {NumberOne} Multiplication Table!")
            For i = 1 To NumberOne
                For j = 1 To NumberOne

                    Result = (j * i).ToString("")
                    Result = Result.PadLeft(8)
                    Console.Write(Result)
                Next
                Console.WriteLine()
            Next
            Console.WriteLine(StrDup(80, "*"))
        Loop Until UserInput = "Q"
    End Sub

End Module
