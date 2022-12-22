// See https://aka.ms/new-console-template for more information
/*Pinturerias Pigmentos necesita un programa que permita ingresar 
una temperatura en Fahrenheit debemos mostrar la temperatura en 
Centígrados con un mensaje concatenado (ej.: " 32 Fahrenheit son 0 centígrados").*/

double farenheit;
double resultadoFarenheit;

Console.Write("Ingrese la temperatura farenheit a convertir: ");
farenheit = double.Parse(Console.ReadLine());

resultadoFarenheit = (farenheit - 32) * 5 / 9;

Console.WriteLine("La temperatura de {0} farenheit son {1} graados centigrados"
    , farenheit, resultadoFarenheit);