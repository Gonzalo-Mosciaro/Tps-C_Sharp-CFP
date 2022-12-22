// See https://aka.ms/new-console-template for more information

//Pedir al usuario que su nombre y apellido y mostrarlo
//por pantalla con el siguiente formato: “Hola me llamo: ……”

string nombre;
string apeliido;

Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();
Console.Write("Ingrese su apeliido: ");
apeliido = Console.ReadLine();

Console.WriteLine("Su nombre es {0}, y su apellido es {1}", nombre, apeliido);
