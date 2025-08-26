using System.Net.WebSockets;

Console.Clear();
int value;

var flag = true;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
value = 11;
Console.WriteLine($"Outside the code block: {value}");