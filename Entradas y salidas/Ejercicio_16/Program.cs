// See https://aka.ms/new-console-template for more information
/*Mostrar la cantidad de alambre a comprar si se ingresara el largo 
 * y el ancho de un terreno rectangular y se debe alambrar 
 * con tres hilos de alambre. */

int largoTerreno;
int anchoTerreno;
int alambre;

Console.Write("Ingrese el largo del terreno: ");
largoTerreno = int.Parse(Console.ReadLine());
Console.Write("Ingrese el ancho del terreno: ");
anchoTerreno= int.Parse(Console.ReadLine());

alambre = (largoTerreno * 2 + anchoTerreno * 2) * 3;

Console.WriteLine("El tamaño de cada alabre es de: {0}", alambre);
