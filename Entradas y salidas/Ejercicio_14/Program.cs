// See https://aka.ms/new-console-template for more information

/*Diseñar el algoritmo necesario para que habiéndose leído el valor 
de 2 variables NUM1 y NUM2 se intercambien los valores de las variables, 
es decir que el valor que tenía NUM1 ahora lo contenga NUM2 y viceversa*/

int primerNumero;
int segundoNumero;
int auxiliar;

Console.Write("Ingresar el primer numero: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
segundoNumero= int.Parse(Console.ReadLine());

auxiliar = primerNumero;
primerNumero = segundoNumero;
segundoNumero = auxiliar;

Console.WriteLine("El valor del primer numero es {0} y del segundo numero " +
"es {1}", primerNumero, segundoNumero);
