int edad;
int boletos;
int tipoEntrada;

Console.WriteLine("ENTRADA A UN EVENTO"); //nombre del programa
Console.Write("Ingrese su edad: ");
edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de boletos disponibles: ");
boletos = int.Parse(Console.ReadLine());

Console.WriteLine("Seleccione el tipo de entrada:");
Console.WriteLine("1 - General");
Console.WriteLine("2 - VIP");
Console.WriteLine("3 - Invitado");

Console.Write("Ingrese una opcion: ");
tipoEntrada = int.Parse(Console.ReadLine());

        if (edad >= 18 && boletos >= 1 &&
            (tipoEntrada == 1 || tipoEntrada == 2 || tipoEntrada == 3))
        {
            Console.WriteLine("Entrada autorizada");

            if (tipoEntrada == 1)
            {
                Console.WriteLine("Tipo de entrada: General");
            }
            else if (tipoEntrada == 2)
            {
                Console.WriteLine("Tipo de entrada: VIP");
            }
            else
            {
                Console.WriteLine("Tipo de entrada: Invitado");
            }
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
            Console.WriteLine("No cumple con las condiciones establecidas.");
        }