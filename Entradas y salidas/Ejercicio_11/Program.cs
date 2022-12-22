// See https://aka.ms/new-console-template for more information

//De un alumno del curso de ingreso a la UTN se ingresan
//las notas obtenidas en los exámenes de las 3 materias
//(programación, matemática y lectura. Ingresar los valores para las 3 materias)
//: realizar el pseudocódigo de un algoritmo que realice las siguientes acciones:
//-Calcular y mostrar la suma de las notas
//-Calcular y mostrar el promedio de las notas

int programacion;
int matematica;
int lectura;
int promedio;
int totalNotas;

Console.Write("Ingrese la nota de programacion: ");
programacion = int.Parse(Console.ReadLine());
Console.Write("Ingrese la nota de matematica: ");
matematica= int.Parse(Console.ReadLine());
Console.Write("Ingrese la nota de lectura: ");
lectura= int.Parse(Console.ReadLine());

totalNotas = programacion + matematica + lectura;
promedio = totalNotas / 3;

Console.WriteLine("El total de las notas es de {0}, " +
"y el promedio para ingresar a la UTN es de {1}", totalNotas, promedio);