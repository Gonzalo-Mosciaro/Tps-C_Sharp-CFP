/******************************************************************************
Libreria "Todo por 2 pe".
Es necesario llevar un registro de la venta diaria de lápices, lapiceras y Sacapuntas. 
Para eso, al momento de cada venta, se debe ingresar:
Tipo (lápiz / Sacapuntas / lapicera), 
Marca 
Cantidad.
Sabiendo que el costo de cada producto es de $2:
Se pide calcular:
a) Cantidad y monto recaudado en concepto de cada producto.
b) De las lapiceras cual es la marca de las que menos se vendieron en una sola venta 
c) Cuál fue el tipo del producto que obtuvo la mayor facturación en una sola venta.
d) Cuál fue el producto con mayor facturación total.
e) Porcentaje de sacapuntas, sobre el total de unidades vendidas.

*******************************************************************************/

using System.Threading;

string tipo; // lapiz, sacapuntas, lapicera
string marca;
int cantidad;//sugerido cantidad mayor que cero
string respuesta;
int acumuladorLapices;
int acumuladorSacapuntas;
int acumuladorLapiceras;
float montoAcumuladoLapices;
float montoAcumuladoSacapuntas;
float montoAcumuladoLapiceras;
int menorCantidadLapiceras;
string marcaDelMinimo;
int maximaFacturacion;
bool banderaPrimerIngreso;
string tipoDeLaMaximaFacturacion;
float porcentajeSacapuntas;
int sumaUnidades;

const float PRECIO = 2;

acumuladorLapiceras = 0;
acumuladorLapices = 0;
acumuladorSacapuntas = 0;
menorCantidadLapiceras = 0;
marcaDelMinimo = "";
maximaFacturacion = 0;
banderaPrimerIngreso = false;
tipoDeLaMaximaFacturacion = "";

do
{
    //Entradas
    Console.Write("Ingrese el tipo: (lapiz, sacapuntas, lapicera)");
    tipo = Console.ReadLine();
    while (tipo != "lapiz" && tipo != "sacapuntas" && tipo != "lapicera")
    {
        Console.Write("Reingrese el tipo: (lapiz, sacapuntas, lapicera)");
        tipo = Console.ReadLine();
    }

    Console.Write("Ingrese la marca: ");
    marca = Console.ReadLine();

    Console.Write("Ingrese la cantidad: ");
    cantidad = int.Parse(Console.ReadLine());

    //Procesos

    //a) Cantidad y monto recaudado en concepto de cada producto.
    //b) De las lapiceras cual es la marca de las que menos se vendieron en una sola venta
    //c) Cuál fue el tipo del producto que obtuvo la mayor facturación en una sola venta.
    //d) Cuál fue el producto con mayor facturación total.
    //e) Porcentaje de sacapuntas, sobre el total de unidades vendidas.
    switch (tipo)
    {
        case "lapiz":
            acumuladorLapices = acumuladorLapices + cantidad;
            break;

        case "sacapuntas":
            acumuladorSacapuntas += cantidad;
            break;

        case "lapicera":
            if (cantidad < menorCantidadLapiceras || acumuladorLapiceras == 0)
            {
                menorCantidadLapiceras = cantidad;
                marcaDelMinimo = marca;
            }
            acumuladorLapiceras += cantidad;
            break;
    }

    if (cantidad > maximaFacturacion || banderaPrimerIngreso == false)
    {
        maximaFacturacion = cantidad;
        tipoDeLaMaximaFacturacion = tipo;
        banderaPrimerIngreso = true;
    }

    Console.Write("Desea ingresar otro?: ");
    respuesta = Console.ReadLine();

} while (respuesta == "si");

//Procesos
montoAcumuladoLapiceras = acumuladorLapiceras * PRECIO;
montoAcumuladoLapices = acumuladorLapices * PRECIO;
montoAcumuladoSacapuntas = acumuladorSacapuntas * PRECIO;

//Salidas
//A
Console.WriteLine("Lapiceras:");
Console.WriteLine("Cantidad: {0} -> Monto: {1}", acumuladorLapiceras, montoAcumuladoLapiceras);
Console.WriteLine("Lapices:");
Console.WriteLine("Cantidad: {0} -> Monto: {1}", acumuladorLapices, montoAcumuladoLapices);
Console.WriteLine("Sacapuntas:");
Console.WriteLine("Cantidad: {0} -> Monto: {1}", acumuladorSacapuntas, montoAcumuladoSacapuntas);
//B
if (acumuladorLapiceras != 0)
{
    Console.WriteLine("La marca de lapiceras con menos unidades es una sola venta es: {0}", marcaDelMinimo);
}
else
{
    Console.WriteLine("No se ingresaron lapiceras para calcular la minima marca...");
}
//C
Console.WriteLine("El tipo con mayor facturacion es: {0}", tipoDeLaMaximaFacturacion);
//D
if (montoAcumuladoLapiceras > montoAcumuladoLapices && montoAcumuladoLapiceras > montoAcumuladoSacapuntas)
{
    Console.WriteLine("El tipo con mas facturacion es lapiceras");
}
else
{
    if (montoAcumuladoLapices > montoAcumuladoLapiceras && montoAcumuladoLapices > montoAcumuladoSacapuntas)
    {
        Console.WriteLine("El tipo con mas facturacion es lapices");
    }
    else
    {
        Console.WriteLine("El tipo con mas facturacion es sacapuntas");
    }
}
//e
sumaUnidades = acumuladorLapiceras + acumuladorLapices + acumuladorSacapuntas;
porcentajeSacapuntas = (acumuladorSacapuntas * 100) / sumaUnidades;

Console.WriteLine("El porcentaje de sacapuntas es: {0}%", porcentajeSacapuntas);
