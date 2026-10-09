// See https://aka.ms/new-console-template for more information
int dia = 0;
Console.WriteLine("Programa que identifica el dia de la semana!!"); //nomnbre del programa
Console.WriteLine("");
Console.WriteLine("Ingrese un numero del 1 al 7 correspondiente al dia de la semana:"); //mensaje para el usuario
dia = Convert.ToInt32(Console.ReadLine());

switch(dia) //estructura de control switch donde muestra el dia de la semana correspondiente al numero ingresado por el usuario
{
    case 1:
        Console.WriteLine("El dia de la semana es Lunes"); //al ingrear el numero 1, el programa muestra que el dia de la semana es lunes
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 1");
        break;
    case 2:
        Console.WriteLine("El dia de la semana es Martes"); //al ingresar el numero 2, el programa muestra que el dia de la semana es martes
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 2");
        break;
    case 3:
        Console.WriteLine("El dia de la semana es Miercoles"); //al ingresar el numero 3, el programa muestra que el dia de la semana es miercoles
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 3");
        break;
    case 4:
        Console.WriteLine("El dia de la semana es Jueves"); //al ingresar el numero 4, el programa muestra que el dia de la semana es jueves
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 4");
        break;
    case 5:
        Console.WriteLine("El dia de la semana es Viernes"); //al ingresar el numero 5, el programa muestra que el dia de la semana es viernes
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 5");
        break;
    case 6:
        Console.WriteLine("El dia de la semana es Sabado"); //al ingresar el numero 6, el programa muestra que el dia de la semana es sabado
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 6");
        break;
    case 7:
        Console.WriteLine("El dia de la semana es Domingo"); //al ingresar el numero 7, el programa muestra que el dia de la semana es domingo
        Console.WriteLine("");
        Console.WriteLine("Numero ingresado: 7");
        break;
    default:
        Console.WriteLine("Numero invalido, por favor ingrese un numero del 1 al 7."); //mensaje de error si el usuario ingresa un numero fuera del rango
        break;
}
