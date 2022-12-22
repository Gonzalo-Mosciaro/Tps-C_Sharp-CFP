/*Al ingresar una edad menor a 18 años y un estado civil distinto a soltero, 
 * mostrar el mensaje: “Es muy pequeño para NO ser soltero”*/

int edad;
string estadoCivil;

Console.Write("Ingrese una edad: ");
edad = int.Parse(Console.ReadLine());
Console.Write("Ingrese un esado civil: ");
estadoCivil = Console.ReadLine();

if (edad < 18 && estadoCivil != "soltero")
{
    Console.Write("Es muy pequeño para no ser soltero");
}
