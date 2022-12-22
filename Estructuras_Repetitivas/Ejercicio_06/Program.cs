/* Gonzalo Mosciaro
 Ejercicio 06 - Repetitivas
    
Realizar un programa que permite calcular la tabla de multiplicar 
de un número que ingrese el usuario:
Por ejemplo: si el usuario ingresa el numero 3, 
el programa deberá mostrar:
3 x 0 = 0
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
3 x 4 = 12
3 x 5 = 15
3 x 6 = 18
3 x 7 = 21
3 x 8 = 24
3 x 9 = 27
3 x 10 = 30
*/

int i;
int unNumero;
int total;

Console.Write("Ingrese el numero a multiplicar: ");
unNumero = int.Parse(Console.ReadLine());

for (i = 0; i < 11; i++)
{
    total = unNumero * i;
    Console.WriteLine("{0} X {1} = {2}", unNumero, i, total);
}