/* Gonzalo Mosciaro
Ejercicio 05 - Condicionales

Al ingresar una edad debemos informar si la persona es adolescente, 
edad entre 13 y 17 años (inclusive), mayor de edad (mayor o igual a 18) 
o menor de edad (menor a 13).*/

int edad;

Console.Write("Ingrese una edad: ");
edad = int.Parse(Console.ReadLine());

if (edad > 17)
{
    Console.Write("Usted es mayor de edad");
}
else
{
    if (edad > 12)
    {
        Console.Write("Usted es adolescente");
    }
    else
    {
        Console.Write("Usted es menor de 13 años");
    }
}