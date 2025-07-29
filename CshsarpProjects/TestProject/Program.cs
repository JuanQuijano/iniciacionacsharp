Console.Clear();

Random dado = new();
var tirada1 = dado.Next();
var tirada2 = dado.Next(101);
var tirada3 = dado.Next(50, 101);
var tirada4 = dado.Next(1, 7);

Console.WriteLine($"Primera tirada: {tirada1}");
Console.WriteLine($"Segunda tirada: {tirada2}");
Console.WriteLine($"Tercera tirada: {tirada3}");
Console.WriteLine($"Cuarta tirada: {tirada4}");
