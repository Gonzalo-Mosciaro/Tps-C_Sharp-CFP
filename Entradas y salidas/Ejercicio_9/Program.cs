// See https://aka.ms/new-console-template for more information
//Ingresar el precio de un producto y aplicarle el 30% de descuento.

int precioProducto;
double total;

Console.Write("Ingrese el precio de un producto: ");
precioProducto = int.Parse(Console.ReadLine());

total = precioProducto - (precioProducto * 0.7);

Console.WriteLine("El total del producto con el descuento es de: {0}", total);


