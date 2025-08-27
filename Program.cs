using System;

Console.Clear();

var tirada = new Random();
int SaludHeroe = 10;
int SaludMonstruo = 10;

Console.WriteLine("Combate: Héroe vs Monstruo (ambos empiezan con 10 puntos de salud)");

// Bucle externo del combate: se repite mientras ambos sigan con vida
while (SaludHeroe > 0 && SaludMonstruo > 0)
{
   // Turno del héroe (ataca primero)
   int AtaqueDelHeroe = tirada.Next(1, 11); // 1..10
   SaludMonstruo -= AtaqueDelHeroe;
   Console.WriteLine($"El héroe ataca y causa {AtaqueDelHeroe} puntos de daño. Salud restante del monstruo: {Math.Max(SaludMonstruo, 0)}");

   Console.WriteLine("Pulse una tecla para ell siguiente movimiento");
   Console.ReadLine();

   if (SaludMonstruo > 0)
   {
      int AtaqueDelMonstruo = tirada.Next(1, 11); // 1..10
      SaludHeroe -= AtaqueDelMonstruo;
      Console.WriteLine($"El monstruo contraataca y causa {AtaqueDelMonstruo} puntos de daño. Salud restante del héroe: {Math.Max(SaludHeroe, 0)}");
   }

   Console.WriteLine("Pulse una tecla para el siguiente movimiento");
   Console.ReadLine();
   
}

if (SaludMonstruo <= 0)
{ Console.WriteLine("El héroe ha vencido al monstruo!"); }
else
{ Console.WriteLine("El monstruo ha vencido al héroe."); }


Console.WriteLine("Presione ENTER para salir...");
Console.ReadLine();

