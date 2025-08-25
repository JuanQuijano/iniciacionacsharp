Console.Clear();

int[] inventory = {200,450,700,175,250};
var indice = 1;
var suma = 0;
foreach (var number in inventory)
{
    Console.WriteLine($"Numero de inventario: {indice}, valor: {number}, Total parcial: {suma += number} ");
    indice++;
}

Console.WriteLine($"Hay {indice} items en la matriz, y dan una suma total: {suma}");


