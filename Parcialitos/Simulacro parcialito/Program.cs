/*Simulacro_Parcialito
 * Gonzalo Mosciaro

ingresar numeros hasta que el usuario quiera se pide:
A) la suma de los negativos
B) la cantidad de positivos
C) el promedio de todos los numeros
D) el maximo de todos los pares*/


int unNumero;
int i;
int cantidad;
int sumaNegativos;
int cantidadPositivos;
double promedio;
int maximoPares;
int totalSuma;
int par;

totalSuma = 0;
cantidadPositivos = 0;
sumaNegativos = 0;

Console.WriteLine("¿Cuantos numeros desea ingresar?");
cantidad = int.Parse(Console.ReadLine());

for (i = 0; i < cantidad; i++)
{
    Console.Write("Ingrese un numero: ");
    unNumero = int.Parse(Console.ReadLine());

    if (unNumero > 0)
    {
        cantidadPositivos++;
    }
    else
    {
        sumaNegativos += unNumero;
    }
    
    if(unNumero % 2 == 0)
    {
        maximoPares = unNumero;

        if (i == 0 )
        {
          if (unNumero > maximoPares)
            {
                maximoPares = unNumero;
            }
        }
    }

    totalSuma += unNumero;
}

promedio = totalSuma / cantidad;

Console.WriteLine("El promedio es: {0}", promedio);
Console.WriteLine("El total de la suma de negativos es: {0}", sumaNegativos);
Console.WriteLine("La cantidad de positivos es: {0}", cantidadPositivos);
Console.WriteLine("El maximo de numeros pares es: {0}", maximoPares);