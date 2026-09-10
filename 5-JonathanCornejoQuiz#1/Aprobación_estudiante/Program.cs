float notaFinal;
float asistencia;
int tipoEstudiante;

Console.WriteLine("APROBACION DE ESTUDIANTE");

Console.Write("Ingrese la nota final: "); //se ingresa la nota final
notaFinal = float.Parse(Console.ReadLine());

Console.Write("Ingrese el porcentaje de asistencia: "); //asistencia
asistencia = float.Parse(Console.ReadLine());

Console.WriteLine("Seleccione el tipo de estudiante:");
Console.WriteLine("1 - Regular");
Console.WriteLine("2 - Becado");
Console.WriteLine("3 - Intercambio");

Console.Write("Ingrese una opcion: ");
tipoEstudiante = int.Parse(Console.ReadLine());

if (notaFinal >= 71 && asistencia >= 80 && (tipoEstudiante == 1 || tipoEstudiante == 2 || tipoEstudiante == 3))
        {
     Console.WriteLine("Aprobado");
     Console.WriteLine("Nota final: " + notaFinal);
        }
        else
        {
    Console.WriteLine("No aprobado");
    Console.WriteLine("Nota final: " + notaFinal);
        }
