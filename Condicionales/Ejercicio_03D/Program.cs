// See https://aka.ms/new-console-template for more information
/*Pedir el ingreso de un número e informar si es par o impar.*/

using System.Reflection;

int unNumero;

Console.Write("Ingrese un numero: ");
unNumero = int.Parse(Console.ReadLine());

if (unNumero % 2 == 0)
{
    Console.Write("El numero es par");
}
else
{
    Console.Write("El numero es impar");
}