// See https://aka.ms/new-console-template for more information
/*A partir del ingreso de la cantidad de camisas compradas, si la cantidad 
 * es mayor que 10 camisas aplico un 10% de descuento, de otra forma aplica 
 * un 3%. Todas las camisas valen $5000. Determinar cuál es el precio con el 
 * descuento.*/

int camisas = 5000;
int cantidad;
double totalDescuento;
double totalBruto;

Console.Write("Ingrese la cantidad de camisas deseadas: ");
cantidad = int.Parse(Console.ReadLine());
totalBruto = cantidad * camisas;


if (cantidad > 10)
{
    totalDescuento = totalBruto - totalBruto * 0.9;
    Console.Write("El precio de {0} camisas con el 10% de descuento " +
        "es de ${1}", cantidad, totalDescuento);
}
else
{
    totalDescuento = totalBruto - totalBruto * 0.03;
    Console.Write("El precio de {0} camisas con el 3% de descuento " +
        "es de ${1}", cantidad, totalDescuento);
}
