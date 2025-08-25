/*
Dada una frase, la invierte y me muestra cuantas veces aparece la letra o
*/


string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int x = 0;
foreach (char i in charMessage) 
{
    if (i == 'o')
    { x++; } 
}

Console.WriteLine(charMessage);
Console.WriteLine($"'o' appears {x} times.");