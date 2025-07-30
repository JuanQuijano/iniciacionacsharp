using System.Text;


Console.Clear();
var firstName = "Bob";
var saludo = "Hola";
var message = saludo + " " + firstName + "!";
Console.WriteLine(message);
Console.WriteLine(string.Concat(saludo, " ", firstName, "!"));
Console.WriteLine($"{saludo} {firstName}!");
Console.WriteLine(string.Format("{0} {1}!", saludo, firstName));

var saludoBuilder = new StringBuilder();

saludoBuilder.Append(saludo);
saludoBuilder.Append(" ");
saludoBuilder.Append(firstName);
saludoBuilder.Append("!");

Console.WriteLine(saludoBuilder.ToString());

string[] palabras = [saludo, " ", firstName, "!"];
string saludoString = string.Join("", palabras);
Console.WriteLine(saludoString);