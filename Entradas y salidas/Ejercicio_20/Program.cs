// See https://aka.ms/new-console-template for more information
/*Pinturerias Pigmentos necesita un programa que permita ingresar una 
 * temperatura en Centígrados debemos mostrar la temperatura en Fahrenheit 
 * (ej.: "0 centígrados son 32 Fahrenheit ").*/

double centigrados;
double centigradosResultado;

Console.Write("Ingrese la temperatura en grados " +
    "centigrados que desee convertir a farenheit: ");
centigrados = double.Parse(Console.ReadLine());

centigradosResultado = (centigrados * 9 / 5) + 32;

Console.WriteLine("La temperatura de {0} grados centigrados son {1} farenheit", 
    centigrados, centigradosResultado);
