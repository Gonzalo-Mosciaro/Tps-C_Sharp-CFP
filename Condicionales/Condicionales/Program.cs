// See https://aka.ms/new-console-template for more information
//Ingresar la edad de una persona. Si tiene 15 años mostrar: “Felices 15”.

int edad = 15;
string mensaje;
Console.Write("Ingrese la edad deseada: ");
edad = int.Parse(Console.ReadLine());

if (edad == 15)
{
    mensaje = ("Felices 15");
}
else
{
    mensaje = ("Usted no tiene 15 años");
}

Console.WriteLine(mensaje);