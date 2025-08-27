using System;

Console.Clear();

for (int numero = 1; numero <= 100; numero++)
{
	// Usamos la forma clásica switch/case/break mediante una clave entera:
	// 0 = ninguno, 1 = divisible por 3, 2 = divisible por 5, 3 = ambos
	int divisiblePor = (numero % 3 == 0 ? 1 : 0) + (numero % 5 == 0 ? 2 : 0);
	string term = string.Empty;

	switch (divisiblePor)
	{
		case 3:
			term = "FizzBuzz";
			break;
		case 1:
			term = "Fizz";
			break;
		case 2:
			term = "Buzz";
			break;
		default:
			term = string.Empty;
			break;
	}

   Console.WriteLine(string.IsNullOrEmpty(term) ? numero.ToString() : $"{numero} {term}");
}
