// See https://aka.ms/new-console-template for more information
/*Calcular el número de pulsaciones que una persona debe tener por
cada 10 segundos de ejercicio, si la fórmula es:  pulsaciones = (220 - edad)/10.
Luego del ingreso de los datos de la persona se aplica la fórmula
correspondiente y se muestra el resultado*/

int pulsaciones;
int edad;

Console.Write("Ingrese una edad: ");
edad = int.Parse(Console.ReadLine());

pulsaciones = (220 - edad) / 10;

Console.WriteLine("La cantidadd de pulsaciones cada 10 segundos es de: {0}", edad);