Imports System

Module Program
    Sub Main()
        Static wek() As Double = {3,2}
        Dim Aplikacja As App = New App($"Przesunięcie punktu o wektor [{wek(0)},{wek(1)}]")
        Dim A() As Double = {App.OdpUzytkownika("Podaj współrzędną x punktu A: ", "*"),App.OdpUzytkownika("Podaj współrzędną y punktu A: ", "*")}
        Dzialania.Przesun(A, wek)
        Console.WriteLine($"Współrzędne punktu po przesunięciu o wektor [{wek(0)},{wek(1)}] wynoszą: ({A(0)},{A(1)})")
    End Sub
End Module
