// See https://aka.ms/new-console-template for more information

/*Al ingresar una edad debemos informar solo si la persona es mayor de edad 
 * (mayor o igual a 18).*/

int edad;


Console.Write("Ingrese una edad: ");
edad = int.Parse(Console.ReadLine());

if (edad >= 18)
{
    Console.WriteLine("Usted es mayor de edad");
}
