/*Gonzalo Mosciaro
 * Ejercicio 13 - E/S
 * En un hospital existen tres áreas: Cardiología, Pediatría y Traumatología. 
El presupuesto anual del hospital se reparte conforme a la siguiente tabla:
      Área			     Porcentaje del presupuesto
        Cardiología			40%
        Pediatría			45%  
        Traumatología		15% */

double presupuesto;
double porcentajeCardiologia;
double porcentajePediatria;
double porcentajeTraumatologia;

Console.Write("Ingrese el presupuesto anual: ");
presupuesto = double.Parse(Console.ReadLine());

porcentajeCardiologia = presupuesto * 0.4;
porcentajePediatria = presupuesto * 0.45;
porcentajeTraumatologia = presupuesto * 0.15;

Console.Write("El porcentaje de cardiologia es de: {0}", porcentajeCardiologia);
Console.Write('\n');
Console.Write("El porcentaje de pediatria es de: {0}", porcentajePediatria);
Console.Write('\n');
Console.Write("El porcentaje de traumatologia es de: {0}", porcentajeTraumatologia);
