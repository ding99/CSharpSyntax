Module Program
    Sub Main()
        Console.WriteLine("VB Xml Literal Example")
        Dim literal As New XmlLiteralExample
        literal.MakeXmlFileUsingLiterals()
    End Sub

    Public Class XmlLiteralExample
        Public Sub MakeXmlFileUsingLiterals()
            ' Notice that we can inline XML data to an XElement
            Dim doc As XElement =
                <Inventory>
                    <Car ID="1000">
                        <PetName>Jimbo</PetName>
                        <Color>Red</Color>
                        <Make>Ford</Make>
                    </Car>
                </Inventory>
            ' Save to file
            doc.Save("InventoryVBStyle.xml")
        End Sub
    End Class

End Module


