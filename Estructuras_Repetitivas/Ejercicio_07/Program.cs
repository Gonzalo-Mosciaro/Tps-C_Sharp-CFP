//Gonzalo Mosciaro
//Ejercicio 07 - Repetitivas.

/*Se ingresan 10 números. Determinar cuantos son positivos y 
 * cuantos son negativos.*/

int unNumero;
int i;
int contadorPositivos;
int contadorNegativos;

contadorPositivos = 0;
contadorNegativos = 0;

for (i = 0; i < 10; i++)
{
    Console.Write("Ingrese un numero: ");
    unNumero = int.Parse(Console.ReadLine());

    if (unNumero > 0)
    {
        contadorPositivos++;
    }
    else
    {
        contadorNegativos++;
    }
}

Console.WriteLine("La cantidad de positivos es: {0}", contadorPositivos);
Console.WriteLine("La cantidad de negativos es: {0}", contadorNegativos);