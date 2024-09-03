Imports System.IO

Public Class Demos
    Implements IDemos

    Public Function LoadFile() As List(Of String) Implements IDemos.LoadFile
        Dim outputs As List(Of String) = New List(Of String)
        Dim lines As List(Of String) = File.ReadAllLines("C:\temp\test.txt").ToList()
        For i As Integer = 0 To lines.Count - 1
            If i Mod 2 = 0 Then
                outputs.Add(lines(i))
            End If
        Next

        Return outputs
    End Function


    Public Sub PrintFullName(firstname As String, lastname As String) Implements IDemos.PrintFullName
        Console.WriteLine($"{firstname} {lastname}")
    End Sub
End Class
