float notaFinal = 0.0f;
float asistencia;
int tipoEstudiante;

Console.WriteLine("APROBACION DE ESTUDIANTE"); //Nombre del programa

Console.Write("Ingrese la nota final: ");
notaFinal = float.Parse(Console.ReadLine());

Console.Write("Ingrese el porcentaje de asistencia: "); //Se ingresa el porcentaje de asistencia
asistencia = float.Parse(Console.ReadLine());
Console.WriteLine("Seleccione el tipo de estudiante:"); //se selecciona el tipo de estudiante
Console.WriteLine("1 - Regular");
Console.WriteLine("2 - Becado");
Console.WriteLine("3 - Intercambio");

Console.Write("Ingrese una opcion: "); //se ingresa una opción
tipoEstudiante = int.Parse(Console.ReadLine());

 switch (tipoEstudiante)
        {
            case 1:
                if (notaFinal >= 71 && asistencia >= 80)
                {
                    Console.WriteLine("Aprobado - Estudiante Regular");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                else
                {
                    Console.WriteLine("No aprobado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                break;

            case 2:
                if (notaFinal >= 71 && asistencia >= 80)
                {
                    Console.WriteLine("Aprobado - Estudiante Becado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                else
                {
                    Console.WriteLine("No aprobado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                break;

            case 3:
                if (notaFinal >= 71 && asistencia >= 80)
                {
                    Console.WriteLine("Aprobado - Estudiante de Intercambio");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                else
                {
                    Console.WriteLine("No aprobado");
                    Console.WriteLine("Nota final: " + notaFinal);
                }
                break;

            default:
                Console.WriteLine("Tipo de estudiante no valido.");
                break;
        }
