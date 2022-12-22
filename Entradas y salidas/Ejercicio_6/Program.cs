// See https://aka.ms/new-console-template for more information

//Pedir al usuario que ingrese la base y la altura de un rectángulo.
//Calcular y mostrar por pantalla el perímetro
//y la superficie de dicha figura.  

int baseRectangulo;
int alturaRectangulo;
int superficie;
int perimetro;

Console.Write("Ingrese la base de un rectangulo: ");
baseRectangulo = int.Parse(Console.ReadLine());
Console.Write("Ingrese la altura de un rectangulo: ");
alturaRectangulo = int.Parse(Console.ReadLine());

superficie = baseRectangulo * alturaRectangulo;
perimetro = baseRectangulo * 2 + alturaRectangulo * 2;

Console.WriteLine("La superficie del rectangulo es {0} y el perimetro " +
    "es {1}", superficie, perimetro);