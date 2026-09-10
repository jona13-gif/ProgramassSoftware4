float Salario_mensual = 0.0f;
int Antiguedad_laboral = 0;
float Monto_Solicitado = 0.0f;
int Tipo_de_prestamo = 0;

Console.WriteLine(""); //Programa con la version selectiva: IF
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

if(Salario_mensual >= 1000 && Antiguedad_laboral >= 2 || Salario_mensual > 2500 && Antiguedad_laboral >= 1) //Condición para evaluar si el solicitante cumple con los requisitos mínimos de salario y antigüedad laboral
{
    if (Tipo_de_prestamo == 1 && Monto_Solicitado <= 15000) //Condición para evaluar si el solicitante cumple con los requisitos mínimos de salario y antigüedad laboral
    {
        Console.WriteLine("");
        Console.WriteLine("Tipo de prestamo: Personal");
        Console.WriteLine("");
        Console.WriteLine("El monto solicitado es: " + Monto_Solicitado);
        Console.WriteLine("");
        Console.WriteLine("Resultado de la evaluación: APROBADO");
    }
    else if (Tipo_de_prestamo == 2 && Monto_Solicitado <= 15000) //Condición para evaluar si el solicitante cumple con los requisitos mínimos de salario y antigüedad laboral
    {
        Console.WriteLine("");
        Console.WriteLine("Tipo de prestamo: Auto");
        Console.WriteLine("");
        Console.WriteLine("El monto solicitado es: " + Monto_Solicitado);
        Console.WriteLine("");
        Console.WriteLine("Resultado de la evaluación: APROBADO");
    }
    else if (Tipo_de_prestamo == 3 && Monto_Solicitado <= 15000) //Condición para evaluar si el solicitante cumple con los requisitos mínimos de salario y antigüedad laboral
    {
        Console.WriteLine("");
        Console.WriteLine("Tipo de prestamo: Vivienda");
        Console.WriteLine("");
        Console.WriteLine("El monto solicitado es: " + Monto_Solicitado);
        Console.WriteLine("");
        Console.WriteLine("Resultado de la evaluación: APROBADO");
    }
    else
    {
        Console.WriteLine("Monto solicitado excede el límite para el tipo de préstamo seleccionado."); //mensaje que se muestra si el solicitante no cumple con los requisitos mínimos de salario o antigüedad laboral
    }
}
else
{
    Console.WriteLine("No cumple con los requisitos mínimos de salario o antigüedad laboral para solicitar un préstamo."); //mensaje que se muestra si el solicitante no cumple con los requisitos mínimos de salario o antigüedad laboral
}
