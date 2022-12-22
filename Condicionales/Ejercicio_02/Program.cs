// See https://aka.ms/new-console-template for more information
/*Ingresar 2 números y determinar cuál es el mayor de los dos.*/

int primerNumero;
int segundoNumero;
string mensaje;

Console.Write("Ingrese el primer numero: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
segundoNumero= int.Parse(Console.ReadLine());

if (primerNumero > segundoNumero)
{
    mensaje = "El primer numero es mayor que el segundo ";
}
else
{
    mensaje = "El segundo numero es mayor que el segundo";
}

Console.WriteLine(mensaje);
