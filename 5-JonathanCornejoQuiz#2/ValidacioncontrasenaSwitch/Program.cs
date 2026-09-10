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

switch(Longitudcontrasena) //Inicia un switch para validar la longitud de la contraseña
{
    case < 8: //Si la longitud es menor a 8
        Console.WriteLine("La contraseña debe tener al menos 8 caracteres.(CONSTRASEÑA DEBIL)"); //Mensaje de error
        break;
    case >=8: //Si la longitud es mayor o igual a 8, se hace otra validacion para verificar numeros y caracter especiales
        if(CantidadNumeros < 1) //Si la cantidad de números es menor a 1
        {
            Console.WriteLine("La contraseña debe tener al menos un número.(CONTRASEÑA DEBIL)"); //Mensaje de error
        }
        else if (CaracteresEspeciales < 1) //Si la cantidad de caracteres especiales es menor a 1
        {
            Console.WriteLine("La contraseña debe tener al menos un caracter especial.(CONTRASEÑA DEBIL)"); //Mensaje de error
        }
        else //Si la longitud, cantidad de números y cantidad de caracteres especiales son válidos
        {
            Console.WriteLine("La contraseña es válida.(CONTRASEÑA SEGURA)"); //Mensaje de éxito
        }
        break;
}
