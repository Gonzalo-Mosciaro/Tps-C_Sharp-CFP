// See https://aka.ms/new-console-template for more information
/*Para hacer un contrapiso de 1m x 1m se necesitan 2 bolsas de cemento 
 * y 3 de cal, debemos mostrar cuántas bolsas se necesitan de cada uno para 
 * las medidas que nos ingresen.*/

int cal;
int cemento;
int largo;
int ancho;
int superficie;

Console.Write("Ingrese el largo del contrapiso: ");
largo = int.Parse(Console.ReadLine());
Console.Write("Ingrese el ancho del contrapiso: ");
ancho = int.Parse(Console.ReadLine());

superficie = largo * ancho;
cemento = superficie * 2;
cal = superficie * 3;

Console.Write("Para {0} mts(2), se precisan {1} bolsas de cemento " +
"y {2} bolsas de cal ", superficie, cemento, cal);