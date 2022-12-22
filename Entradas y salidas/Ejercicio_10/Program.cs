// See https://aka.ms/new-console-template for more information
//Escribir en Pseudocódigo un algoritmo que realice
//las siguientes acciones:
//Ingrese valores para 2 variables NUMERO1 y NUMERO2
//Efectúe el producto de dichas variables y muestre
//el resultado por pantalla
//Obtenga el cuadrado de NUMERO1 y lo muestre por pantalla

int primerNumero;
int segundoNumero;
int total;
double cuadrado;

Console.Write("Ingrese el valor del primer numero: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el valor del seguno numero: ");
segundoNumero= int.Parse(Console.ReadLine());

total = primerNumero * segundoNumero;
cuadrado = Math.Pow(primerNumero, 2);
Console.WriteLine("El producto de ambos numeros es: {0} y el cuadrado del primer numero es {1}", total, cuadrado);