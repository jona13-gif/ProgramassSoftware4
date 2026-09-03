float montoTotal = 0.0f;
float Total = 0.0f;
Console.WriteLine("TIENDA: DESCUENTO CHISPIANTE");
Console.WriteLine("");
Console.WriteLine("Ingrese el monto total de su compra:");
montoTotal = float.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Ingrese su tipo de cliente (1: Regular, 2: Frecuente, 3: VIP):");
int tipoCliente = int.Parse(Console.ReadLine());

switch (tipoCliente)
{
    case 1:
        Total = montoTotal; //no hay efecto en el precio
        Console.WriteLine("el Total a pagar SIN descuento aplicado es de: " + Total);
        Console.WriteLine("");
        Console.WriteLine("No se aplico ningún descuento para clientes regulares.");
        break;
    case 2:
        if(montoTotal > 100)
        {
            Total = montoTotal; //no hay efecto en el precio
            montoTotal *= 0.15f; // Descuento del 15% para clientes frecuentes con compras mayores a 100
            Total = Total - montoTotal; //total a pagar con descuento aplicado
            Console.WriteLine("el Total a pagar con descuento aplicado es de: " + Total);
        }
        else
        {
            Console.WriteLine("No se aplico ningún descuento para clientes frecuentes con compras menores o iguales a 100.");
        }
        break;
    case 3:
        if(montoTotal > 100)
        {
            Total = montoTotal; //no hay efecto en el precio
            montoTotal *= 0.15f; // Descuento del 15% para clientes frecuentes con compras mayores a 100
            Total = Total - montoTotal; //total a pagar con descuento aplicado
            Console.WriteLine("el Total a pagar con descuento aplicado es de: " + Total);
        }
        else
        {
            Console.WriteLine("No se aplico ningún descuento para clientes VIP con compras menores o iguales a 100.");
        }
        break;
    default:
        Console.WriteLine("Tipo de cliente no válido. No se aplicará ningún descuento.");
        break;
}