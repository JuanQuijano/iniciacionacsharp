Console.Clear();

/* Declarar matriz con estos valores
B123
C234
A345
C15
B177
G3003
C235
B179
*/

string[] pedidofraudulentos = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (var pedido in pedidofraudulentos)
{
    if (pedido.StartsWith("B"))
    { Console.WriteLine(pedido); }
}







/* La salida que debo obtener es
B123
B177
B179
*/