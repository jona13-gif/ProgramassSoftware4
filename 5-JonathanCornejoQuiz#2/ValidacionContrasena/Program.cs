int Longitudcontrasena = 0; //Variable para almacenar la longitud deseada de la contraseña
int CantidadNumeros = 0; //Variavle para almacenar la cantidad mínima de números deseada
int CaracteresEspeciales = 0; //Variable para almacenar la cantidad mínima de caracteres especiales deseada

Console.WriteLine("");
Console.WriteLine("Programa de validación de contraseña"); //Mensaje de bienvenida al usuario
Console.WriteLine("");
Console.WriteLine("Ingrese la longitud deseada para la contraseña: "); //Solicita al usuario que ingrese la longitud deseada para la contraseña
Longitudcontrasena = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad mínima de números deseada: "); //Solicita al usuario que ingrese la cantidad mínima de números deseada
CantidadNumeros = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad mínima de caracteres especiales deseada: "); //Solicita al usuario que ingrese la cantidad mínima de caracteres especiales deseada
CaracteresEspeciales = int.Parse(Console.ReadLine());

if(Longitudcontrasena > 8 && CantidadNumeros >= 1 && CaracteresEspeciales >= 1) //Condición que valida si la contraseña cumple con los requisitos de seguridad
{
    Console.WriteLine("Contraseña segura: Bien hecho!"); //Mensaje que indica que la contraseña es segura
}
else
{
    Console.WriteLine("Contraseña no segura/debil: Intente de nuevo."); //Mensaje que indica que la contraseña no es segura y solicita al usuario que intente de nuevo
}