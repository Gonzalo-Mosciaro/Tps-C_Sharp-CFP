// See https://aka.ms/new-console-template for more information
/* Pedir el ingreso de dos números (divisor y dividendo), realizar la división de
 * los mismos, si el divisor es un cero mostrar un mensaje de error.*/

int divisor;
int dividendo;
double total;

Console.Write("Ingrese el dividendo: ");
dividendo = int.Parse(Console.ReadLine());
Console.Write("Ingrese el divisor: ");
divisor = int.Parse(Console.ReadLine());

if (divisor == 0)
{
    Console.Write("Errro al dividir");
}
else
{
    total = dividendo/ divisor;
    Console.Write("La division dio un total de {0}", total);
}
