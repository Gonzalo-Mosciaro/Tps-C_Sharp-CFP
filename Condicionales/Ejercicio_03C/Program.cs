// See https://aka.ms/new-console-template for more information
/*Pedir el ingreso de un número e informar si es positivo o negativo.*/

int unNumero;

Console.Write("Ingrese un numero: ");
unNumero = int.Parse(Console.ReadLine());

if (unNumero > 0)
{
    Console.Write("El mumero es positivo");
}
else
{
    Console.Write("EL numero es negativo");
}