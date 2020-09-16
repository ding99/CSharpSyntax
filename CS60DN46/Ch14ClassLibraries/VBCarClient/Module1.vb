Imports CarLibrary

Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("***** VB CarLibrary Client APP *****")
        Dim van As New MiniVan()
        van.TurboBoost()

        Dim sports As New SportsCar()
        sports.TurboBoost()

        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Use VB class which derives from C# class")
        Dim dream As New PerformanceCar()
        dream.TurboBoost()
    End Sub

End Module
