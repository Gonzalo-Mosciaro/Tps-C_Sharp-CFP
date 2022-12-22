// See https://aka.ms/new-console-template for more information
//Pedir al usuario qué ingrese la base y la altura de un triángulo.
//Calcular y mostrar por pantalla el área del triángulo..  

int baseTriangulo;
int alturaTriangulo;
int area;

Console.Write("Ingrese la base del triangulo: ");
baseTriangulo = int.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del triangulo: ");
alturaTriangulo= int.Parse(Console.ReadLine());

area = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("El area del triangulo es: {0}", area);