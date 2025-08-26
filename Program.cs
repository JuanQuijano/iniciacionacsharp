Console.Clear();

Console.WriteLine("a" == "a ");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

var value1 = " a";
var value2 = "A ";
Console.WriteLine($"{value1.Trim().ToLower()} es igual que {value2.Trim().ToLower()}");
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine();

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine(myValue != "a");

Console.WriteLine();
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine();
var pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine();
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));


Console.WriteLine();
var a = 7;
var b = 6;

Console.WriteLine(a != b); // output: True
var s1 = "Hello";
var s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False