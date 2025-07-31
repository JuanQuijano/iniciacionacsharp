Console.Clear();


var sum = 7 + 5;
var difference = 7 - 5;
var product = 7 * 5;
var quotient = 7 / 5;
// var decimalQuotient = 7.0m / 5;
// decimalQuotient = 7 / 5.0m;
// decimalQuotient = 7.0m / 5.0m;

//int decimalQuotient = (int)(7 / 5.0m);
//var decimalQuotient = 7.0m / 5;
//int decimalQuotient = (int)(7.0m / 5.0m);
//int decimalQuotient = 7 / 5;

var num1 = 7;
var num2 = 5;
var decimalQuotient = (decimal)num1 / (decimal)num2;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

/*
Parentesis ()
Exponentes ^
M Multiplicación 
D División
A Suma (Add)
S Resta (Substraction)
*/

int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);


int value = 0;     // value is now 0.
value = value + 5; // value is now 5.
value += 5;
value++;

Console.WriteLine(value);

value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);


value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (value++));