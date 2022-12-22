// See https://aka.ms/new-console-template for more information
/*Al ingresar una edad debemos informar si la persona es adolescente, 
 * edad entre 13 y 17 años (inclusive).*/

int edad;

Console.Write("Ingrese una edad: ");
edad = int.Parse(Console.ReadLine());

if (edad > 12 && edad <18)
{
    Console.Write("Usted es un adolescente");
}
