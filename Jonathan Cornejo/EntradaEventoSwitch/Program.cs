int edad;
int boletos;
int tipoEntrada;

Console.WriteLine("ENTRADA A UN EVENTO"); //Nombre del programa 

Console.Write("Ingrese su edad: "); //se solicita la edad del usuario
edad = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de boletos disponibles: "); //se solicita la cantidad de boletos disponibles
boletos = int.Parse(Console.ReadLine());

Console.WriteLine("Seleccione el tipo de entrada:"); //se solicita el tipo de entrada que desea el usuario
Console.WriteLine("1 - General");
Console.WriteLine("2 - VIP");
Console.WriteLine("3 - Invitado");

Console.Write("Ingrese una opcion: ");
tipoEntrada = int.Parse(Console.ReadLine());

switch (tipoEntrada) //se utiliza un switch para determinar el tipo de entrada que desea el usuario
{
    case 1:
        if (edad >= 18 && boletos >= 1)
        {
            Console.WriteLine("Entrada autorizada");
            Console.WriteLine("Tipo de entrada: General");
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
            Console.WriteLine("No cumple con las condiciones establecidas.");
        }
        break;

    case 2:
        if (edad >= 18 && boletos >= 1)
        {
            Console.WriteLine("Entrada autorizada");
            Console.WriteLine("Tipo de entrada: VIP");
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
            Console.WriteLine("No cumple con las condiciones establecidas.");
        }
        break;

    case 3:
        if (edad >= 18 && boletos >= 1)
        {
            Console.WriteLine("Entrada autorizada");
            Console.WriteLine("Tipo de entrada: Invitado");
        }
        else
        {
            Console.WriteLine("Entrada rechazada");
            Console.WriteLine("No cumple con las condiciones establecidas.");
        }
        break;

    default:
        Console.WriteLine("Tipo de entrada no valido.");
        break;
}
