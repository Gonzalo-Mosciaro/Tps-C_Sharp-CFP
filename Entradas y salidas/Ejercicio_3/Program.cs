// See https://aka.ms/new-console-template for more information
//Pedir al usuario que ingrese dos números enteros. 
//Sumarlos y mostrar por pantalla dicho resultado.

int primerNumero;
int segundoNumero;
int total;

Console.Write("Ingrese el primer numero a sumar: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero a sumar: ");
segundoNumero = int.Parse(Console.ReadLine());

total = primerNumero + segundoNumero;

Console.WriteLine("El total es: {0}", total);