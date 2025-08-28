
using System;

Console.Clear();

Console.WriteLine("Introduce un número entre 5 y 10");
var acceptedValue = 0;
var mensaje = "";

do
{
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int value) == true)
    {
        if (value < 5 || value > 10)
        {
            mensaje = $"Has introducido el número ({input}), pero debe estar entre 5 y 10;";
        }
        else
        {
            acceptedValue = value;
            mensaje = $"El número ({acceptedValue}) ha sido aceptado.";
        }
    }
    else
        {
            mensaje = $"El valor introducido no es un número. Intentalo de nuevo.";
        }
    
    Console.WriteLine(mensaje);

} while (acceptedValue == 0);




