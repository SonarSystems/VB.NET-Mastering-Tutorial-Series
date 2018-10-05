Imports System.IO

Module Module1

    Sub Main()
        Dim file As FileStream = New FileStream("File.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim itr As Integer

        ' Reading Code
        For itr = 0 To file.Length
            Console.WriteLine(file.ReadByte)
        Next

        ' Writing Code
        'For itr = 0 To 100
        '    file.WriteByte(CByte(itr))
        'Next

        file.Close()
    End Sub

End Module
