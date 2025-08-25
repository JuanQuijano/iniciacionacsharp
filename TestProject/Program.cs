Console.Clear();

string[] fraudulentOrdersId = { "A123", "B456", "C789"};

//fraudulentOrdersId[3] = "D475";

Console.WriteLine($"First:  {fraudulentOrdersId[0]}");
Console.WriteLine($"Second: {fraudulentOrdersId[1]}");
Console.WriteLine($"Third:  {fraudulentOrdersId[2]}");

fraudulentOrdersId[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrdersId[0]}");

Console.WriteLine($"There are {fraudulentOrdersId.Length} fraudulent orders to precess.");

List<string> lista = new List<string>();
lista.add("uno");
lista.add("dos");
lista.add("tres");

