using System.Net.WebSockets;
Console.Clear();

var name = "bob";
var mensaje = "Found Chuck";

if (name == "bob")
    mensaje = "Found Bob";
else if (name == "steve")
    mensaje = "Found Steve";

Console.WriteLine(mensaje);