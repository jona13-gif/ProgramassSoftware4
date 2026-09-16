// See https://aka.ms/new-console-template for more information

float nota_parcial1 = 0.0f;
float nota_parcial2 = 0.0f;
float Asistencia = 0.0f;
int nivel_curso_int = 0;

float Promedio_Parcial = 0.0f;
float bonificaciojn_asistencia = 0.0f;
float promedio_final = 0.0f;

Console.WriteLine("Bienvenido al sistema de evaluacion academica"); //El nombre del programa
Console.WriteLine("");
Console.WriteLine("Ingrese la nota del primer parcial:"); //se ingesa la nota del primer parcial
nota_parcial1 = float.Parse(Console.ReadLine());
Console.WriteLine("");
if (nota_parcial1 < 0 || nota_parcial1 > 100) //Condicional para determinar si la nota del primer parcial es valida
{
    Console.WriteLine("La nota ingresada no es valida, por favor ingrese una nota entre 0 y 100"); //Se imprime un mensaje de error si la nota no es valida
    return; //Se termina el programa si la nota no es valida
}
Console.WriteLine("");
Console.WriteLine("Ingrese la nota del segundo parcial:"); //se ingresa la nota del segundo parcial
nota_parcial2 = float.Parse(Console.ReadLine());
Console.WriteLine("");
if (nota_parcial1 < 0 || nota_parcial1 > 100) //Condicional para determinar si la nota del primer parcial es valida
{
    Console.WriteLine("La nota ingresada no es valida, por favor ingrese una nota entre 0 y 100"); //Se imprime un mensaje de error si la nota no es valida
    return; //Se termina el programa si la nota no es valida
}
Console.WriteLine("");
Console.WriteLine("Ingrese el porcentaje de asistencia"); //se ingresa el porcentaje de asistencia
Asistencia = float.Parse(Console.ReadLine());
Console.WriteLine("");
if (Asistencia < 0 || Asistencia > 100) //Condicional para determinar si el porcentaje de asistencia es valido
{
    Console.WriteLine("El porcentaje de asistencia ingresado no es valido, por favor ingrese un porcentaje entre 0 y 100"); //Se imprime un mensaje de error si el porcentaje de asistencia no es valido
    return; //Se termina el programa si el porcentaje de asistencia no es valido
}
Console.WriteLine("");
Console.WriteLine("Ingrese el nivel del curso:"); //se ingresa el nivel del curso
nivel_curso_int = int.Parse(Console.ReadLine());
if (nivel_curso_int < 1 || nivel_curso_int > 5) //Condicional para determinar si el nivel del curso es valido
{
    Console.WriteLine("El nivel del curso ingresado no es valido, por favor ingrese un nivel entre 1 y 5"); //Se imprime un mensaje de error si el nivel del curso no es valido
    return; //Se termina el programa si el nivel del curso no es valido
}
Console.WriteLine("");

Promedio_Parcial = (nota_parcial1 + nota_parcial2) / 2; //Proceso de calculo del promedio de los parciales
bonificaciojn_asistencia = (Asistencia * 0.05f); //Proceso de calculo de la bonificacion por asistencia
promedio_final = Promedio_Parcial + bonificaciojn_asistencia; //Proceso de calculo del promedio final

if (Asistencia < 70 || Promedio_Parcial < 60) //Condicional para determinar si el estudiante esta reprobado
{
    Console.WriteLine("Su nota final es:" + promedio_final); //Se imprime la nota final
    Console.WriteLine("");
    Console.WriteLine("Su estado academico es: Reprobado"); //Se imprime el estado academico del estudiante
    Console.WriteLine("");
    Console.WriteLine("Nivel del curso: "+nivel_curso_int); //Se imprime el nivel del curso
    Console.WriteLine("");
    Console.WriteLine("categoría de certificación asignada: No cumple con los requisitos"); //Se imprime la categoria de certificacion asignada
} else if (Asistencia <= 89 && Promedio_Parcial <= 89 || nota_parcial1 <= 89 && nota_parcial2 <= 89) //Condicional para determinar si el estudiante esta aprobado
{
    Console.WriteLine("Su nota final es:" + promedio_final);
    Console.WriteLine("");
    Console.WriteLine("Su estado academico es: aprobado");
    Console.WriteLine("");
    Console.WriteLine("Nivel del curso: "+nivel_curso_int);
    Console.WriteLine("");
    Console.WriteLine("categoría de certificación asignada: Candidato a excelencia!!");
}
else if (nota_parcial1 >= 90 && nota_parcial2 >= 90 || Asistencia >= 90 && Promedio_Parcial >= 89) //Condicional para determinar si el estudiante esta aprobado con mención honorifica
{
    Console.WriteLine("Su nota final es:" + promedio_final); //Se imprime la nota final
    Console.WriteLine("");
    Console.WriteLine("Su estado academico es: aprobado"); //Se imprime el estado academico del estudiante
    Console.WriteLine("");
    Console.WriteLine("Nivel del curso: "+nivel_curso_int); //Se imprime el nivel del curso
    Console.WriteLine("");
    Console.WriteLine("categoría de certificación asignada: Candidato a mencion honorifica!!");
}