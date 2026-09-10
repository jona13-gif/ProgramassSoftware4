float Salario_mensual = 0.0f;
int Antiguedad_laboral = 0;
float Monto_Solicitado = 0.0f;
int Tipo_de_prestamo = 0;

Console.WriteLine(""); //Programa con la version selectiva: Switch

Console.WriteLine("Programa 5: Evaluación de préstamo"); //Nombre del programa
Console.WriteLine("");
Console.WriteLine("Ingrese el salario mensual del solicitante: "); //se solicita el salario mensual del solicitante
Salario_mensual = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la antigüedad laboral del solicitante (en años): "); //se solicita la antigüedad laboral del solicitante
Antiguedad_laboral = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto solicitado: "); //se solicita el monto solicitado
Monto_Solicitado = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tipo de préstamo (1: Personal, 2: Auto, 3: Vivienda): "); //se solicita el tipo de préstamo que desea solicitar el solicitante
Tipo_de_prestamo = int.Parse(Console.ReadLine());

switch(Tipo_de_prestamo) //se evalua el tipo de préstamo solicitado
{
    case 1: //Préstamo personal
        if (Salario_mensual >= 1000 && Antiguedad_laboral >= 2 && Monto_Solicitado <= 15000 || Salario_mensual >= 2500 && Antiguedad_laboral >= 1) //se evalua si el solicitante cumple con los requisitos para obtener un préstamo personal
        {
            Console.WriteLine("");
            Console.WriteLine("Tipo de prestamo: Personal");
            Console.WriteLine("");
            Console.WriteLine("Monto solicitado: " + Monto_Solicitado);
            Console.WriteLine("");
            Console.WriteLine("Préstamo APROBADO para préstamo personal.");
        }
        else
        {
            Console.WriteLine("Préstamo DENEGADO para préstamo personal.");
        }
        break;
    case 2: //Préstamo para auto
        if (Salario_mensual >= 1500 && Antiguedad_laboral >= 2 && Monto_Solicitado <= 15000)  //se evalua si el solicitante cumple con los requisitos para obtener un préstamo personal
        {
            Console.WriteLine("");
            Console.WriteLine("Tipo de prestamo: Auto");
            Console.WriteLine("");
            Console.WriteLine("Monto solicitado: " + Monto_Solicitado);
            Console.WriteLine("");
            Console.WriteLine("Préstamo APROBADO para préstamo de auto.");
        }
        else
        {
            Console.WriteLine("Préstamo DENEGADO para préstamo de auto.");
        }
        break;
    case 3: //Préstamo para vivienda
        if (Salario_mensual >= 2000 && Antiguedad_laboral >= 3 && Monto_Solicitado <= 15000)  //se evalua si el solicitante cumple con los requisitos para obtener un préstamo personal
        {
            Console.WriteLine("");
            Console.WriteLine("Tipo de prestamo: Vivienda");
            Console.WriteLine("");
            Console.WriteLine("Monto solicitado: " + Monto_Solicitado);
            Console.WriteLine("");
            Console.WriteLine("Préstamo APROBADO para préstamo de vivienda.");
        }
        else
        {
            Console.WriteLine("Préstamo DENEGADO para préstamo de vivienda.");
        }
        break;
    default:
        Console.WriteLine("Tipo de préstamo no válido.");
        break;
}