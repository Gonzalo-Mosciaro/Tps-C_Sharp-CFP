// See https://aka.ms/new-console-template for more information
//Ingresar el precio de un producto y aplicarle el 21% de iva.

int precio;
int total;

Console.Write("Ingrese el precio de un producto: ");
precio = int.Parse(Console.ReadLine());

total = precio + (precio * 21) / 100;

Console.WriteLine("El total con el IVA(21%) es de: {0}", total);