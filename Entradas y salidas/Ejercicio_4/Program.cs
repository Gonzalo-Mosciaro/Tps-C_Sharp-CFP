// See https://aka.ms/new-console-template for more information
//Pedir al usuario que ingrese dos números enteros. Mostrar por pantalla:
//La suma, la resta, la multiplicación y la división de dichos números.

int primerNumero;
int segundoNumero;
int totalSuma;
int totalResta;
int totalMultiplicacion;
int totalDivision;

Console.Write("Ingrese el primero numero: ");
primerNumero = int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero: ");
segundoNumero= int.Parse(Console.ReadLine());

totalSuma = primerNumero + segundoNumero;
totalResta = primerNumero - segundoNumero;
totalMultiplicacion = primerNumero * segundoNumero;
totalDivision = primerNumero / segundoNumero;

Console.Write("El total de la suma es: {0}", totalSuma);
Console.Write('\n');
Console.Write("El total de la resta es: {0}", totalResta);
Console.Write('\n');
Console.Write("El total de la multiplicacion es: {0}", totalMultiplicacion);
Console.Write('\n');
Console.Write("El total de la division es: {0}", totalDivision);