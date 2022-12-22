// See https://aka.ms/new-console-template for more information
//Pedir al usuario que ingrese la base de un cuadrado.
//Calcular y mostrar por pantalla el perímetro
//y la superficie de dicha figura.

int superficie;
int baseCuadrado;
int perimetro;

Console.Write("Ingrese la base del cuadrado: ");
baseCuadrado = int.Parse(Console.ReadLine());

superficie = baseCuadrado * baseCuadrado;
perimetro = baseCuadrado * 4;

Console.WriteLine("La base del cuadrado es {0} y el perimetro del mismo es {1}", superficie, perimetro);