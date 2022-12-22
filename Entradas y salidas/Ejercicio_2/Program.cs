// See https://aka.ms/new-console-template for more information
//Pedir al usuario que ingrese dos números enteros.
//Mostrarlos por pantalla con el siguiente formato:
//“El primer número ingresado es: …. y el segundo: …..”

int primerNumero;
int segundoNumero;

Console.Write("Ingrese el primer numero: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
segundoNumero= int.Parse(Console.ReadLine());

Console.WriteLine("El primer numero ingresado es {0}, y el segundo es {1}", primerNumero, segundoNumero);