double num1, num2, num3, num4;
int mayor = 0; //variables a utilizar para almacenar los números y el número mayor

Console.Write("Ingrese el primer número: ");
num1 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
num2 = double.Parse(Console.ReadLine());   //se ingresan los números por consola y se convierten a double para poder compararlos

Console.Write("Ingrese el tercer número: ");
num3 = double.Parse(Console.ReadLine());

Console.Write("Ingrese el cuarto número: ");
num4 = double.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3 && num1 > num4) //se comparan los números para determinar cuál es el mayor
{
            mayor = 1; //se asigna el valor 1 a la variable mayor si el primer número es el mayor
}

        if (num2 > num1 && num2 > num3 && num2 > num4)
        {
            mayor = 2; //se asigna el valor 2 a la variable mayor si el segundo número es el mayor
}

        if (num3 > num1 && num3 > num2 && num3 > num4)
        {
            mayor = 3; //se asigna el valor 3 a la variable mayor si el tercer número es el mayor
        }

        if (num4 > num1 && num4 > num2 && num4 > num3)
        {
            mayor = 4; //se asigna el valor 4 a la variable mayor si el cuarto número es el mayor
}

        switch (mayor)
        {
            case 1:
                Console.WriteLine("El número mayor es: " + num1); //se imprime el número mayor según el valor de la variable mayor
        break;

            case 2:
                Console.WriteLine("El número mayor es: " + num2);
                break;

            case 3:
                Console.WriteLine("El número mayor es: " + num3);
                break;

            case 4:
                Console.WriteLine("El número mayor es: " + num4);
                break;
        }
