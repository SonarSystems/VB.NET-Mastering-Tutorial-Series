Imports System.Xml

Module Module1
    Sub Main()
        Dim xr As XmlReader = XmlReader.Create("File.xml")
        Do While xr.Read()
            If xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "owner" Then
                Console.WriteLine(xr.ReadElementString)
            ElseIf xr.NodeType = XmlNodeType.Element AndAlso xr.Name = "company" Then
                Console.WriteLine(xr.ReadElementString)
            Else
                xr.Read()
            End If
        Loop
    End Sub
End Module
