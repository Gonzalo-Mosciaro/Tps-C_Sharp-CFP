// See https://aka.ms/new-console-template for more information
//Ingresar tres precios de productos y mostrar el promedio de los mismos

int productoUno;
int productoDos;
int productoTres;
int promedio;

Console.Write("Ingrese el precio del primer producto: ");
productoUno = int.Parse(Console.ReadLine());
Console.Write("Ingrese el precio del segundo producto: ");
productoDos = int.Parse(Console.ReadLine());
Console.Write("Ingrese el precio del tercer producto: ");
productoTres = int.Parse(Console.ReadLine());

promedio = (productoUno + productoDos + productoTres) / 3;

Console.WriteLine("El promedio de los tres productos es: {0}", promedio);
