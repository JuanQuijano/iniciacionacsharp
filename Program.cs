Console.Clear();

var acceptedRole = string.Empty;
var mensaje = "";

Console.WriteLine("Introduce un rol (Administrador, Director o Usuario)");

do
{
    string? input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        mensaje = "No se ha introducido ningún valor. Introduce un rol (Administrador, Director o Usuario)";
    }
    else
    {
        string trimmed = input.Trim();
        string normalized = trimmed.ToLower();

        if (normalized == "administrador" || normalized == "director" || normalized == "usuario")
        {
            acceptedRole = trimmed;
            mensaje = $"Tu valor de entrada ({acceptedRole}) ha sido aceptado.";
        }
        else
        { mensaje = $"El nombre de rol que has introducido ({input}), no es válido. Introduce un rol (Administrador, Director o Usuario)"; }
    }

    Console.WriteLine(mensaje);

} while (string.IsNullOrEmpty(acceptedRole));
