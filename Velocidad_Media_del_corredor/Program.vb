Module MainModule
    Sub Main()
        ' Datos de entrada
        Dim distanciaKm As Double = 42.195
        Dim tiempoHoras As Double = 2
        Dim tiempoMinutos As Double = 30

        ' Calcular la velocidad en diferentes unidades
        Dim velocidadKmPorHora As Double = distanciaKm / tiempoHoras
        Dim velocidadKmPorMinuto As Double = distanciaKm / (tiempoHoras * 60 + tiempoMinutos)
        Dim velocidadKmPorSegundo As Double = distanciaKm / (tiempoHoras * 3600 + tiempoMinutos * 60)
        Dim velocidadMPorMinuto As Double = (distanciaKm * 1000) / (tiempoHoras * 60 + tiempoMinutos)
        Dim velocidadMPorSegundo As Double = (distanciaKm * 1000) / (tiempoHoras * 3600 + tiempoMinutos * 60)

        ' Mostrar resultados
        Console.WriteLine("Velocidad media en Km/h: " & velocidadKmPorHora)
        Console.WriteLine("Velocidad media en Km/min: " & velocidadKmPorMinuto)
        Console.WriteLine("Velocidad media en Km/s: " & velocidadKmPorSegundo)
        Console.WriteLine("Velocidad media en m/min: " & velocidadMPorMinuto)
        Console.WriteLine("Velocidad media en m/s: " & velocidadMPorSegundo)

        ' Datos del desarrollador
        Console.WriteLine("Desarrollado por: Javier Alexander Naranjo Moz, NM0463012022")

        Console.ReadLine() ' Esperar a que el usuario presione Enter
    End Sub
End Module
