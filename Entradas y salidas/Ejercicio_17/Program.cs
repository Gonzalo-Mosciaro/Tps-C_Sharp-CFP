// See https://aka.ms/new-console-template for more information
/*Mostrar la cantidad de alambre a comprar si se ingresara el radio de 
 * un terreno circular y se debe alambrar con tres hilos de alambre.*/

int radio;
int alambre;
int diametro;

Console.Write("Ingresar el diamentro de un circulo: ");
diametro = int.Parse(Console.ReadLine());

radio = diametro / 2;
alambre = radio * 3;

Console.WriteLine("El alambre necesario para el circulo es de: {0}", alambre);