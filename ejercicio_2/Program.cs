﻿int a, b;
float resultado;
Console.Write("Ingrese el primer digito: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingrese el segundo Digito: ");
b = Convert.ToInt32(Console.ReadLine());

resultado = a / b;

Console.WriteLine("De la Division de {0} y {1} es: {2}", a, b, resultado);