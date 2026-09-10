// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Timers;

using System;
using System.IO; // <-- IMPORTANTE: Añade esto al principio de tu archivo

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de calculo de factura electrica"); //nombre del programa
        Console.WriteLine("Ingrese el nombre del cliente: "); //solicita el nombre del cliente
        string nombreCliente = Console.ReadLine(); //lee el nombre del cliente ingresado
        Console.WriteLine("Cantidad de Kilovatios consumidos: "); //solicita la cantidad de kilovatios consumidos
        double kilovatiosConsumidos = Convert.ToDouble(Console.ReadLine()); //lee la cantidad de kilovatios consumidos ingresada
        Console.WriteLine("Ingrese el tipo de cliente (1: Residencial, 2: Comercial, 3: Industrial): "); //solicita el tipo de cliente
        int tipoCliente = Convert.ToInt32(Console.ReadLine()); //lee el tipo de cliente ingresado

        double tarifaresidencial = 0.15; //inicializa la variable tarifa
        double tarifacomercial = 0.22; //inicializa la variable tarifa
        double tarifaindustrial = 0.30; //inicializa la variable tarifa
        double subtotal = 0; //inicializa la variable subtotal
        double totalpagar = 0; //inicializa la variable totalpagar
        double itbms = 0.07; //inicializa la variable impuesto

        // Variable para armar el texto de la factura que se guardará
        string tipoClienteTexto = "";

        if (kilovatiosConsumidos <= 0)
        {
            Console.WriteLine("Error: La cantidad de kilovatios consumidos debe ser mayor a cero.");
            return;
        }
        else
        {
            switch (tipoCliente) //evalua el tipo de cliente
            {
                case 1:
                    subtotal = kilovatiosConsumidos * tarifaresidencial;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoClienteTexto = "Residencial";
                    break;
                case 2:
                    subtotal = kilovatiosConsumidos * tarifacomercial;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoClienteTexto = "Comercial";
                    break;
                case 3:
                    subtotal = kilovatiosConsumidos * tarifaindustrial;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoClienteTexto = "Industrial";
                    break;
                default:
                    Console.WriteLine("Error: Tipo de cliente inválido.");
                    return;
            }

            // 1. Estructuramos el contenido de la factura en una sola variable de texto
            string facturaTexto =
                $"========== FACTURA ELÉCTRICA ==========\n" +
                $"Cliente: {nombreCliente}\n" +
                $"Tipo de cliente: {tipoClienteTexto}\n" +
                $"Kilovatios consumidos: {kilovatiosConsumidos} kWh\n" +
                $"Subtotal: {subtotal:C}\n" +
                $"Total a pagar (incluyendo ITBMS): {totalpagar:C}\n" +
                $"=======================================";

            // 2. Definimos el nombre del archivo (se guardará en la carpeta del proyecto)
            string nombreArchivo = "Factura_" + nombreCliente.Replace(" ", "_") + ".txt";

            // 3. Guardamos el archivo de texto
            File.WriteAllText(nombreArchivo, facturaTexto);

            // 4. Avisamos al usuario en la consola que ya se guardó
            Console.WriteLine("\n¡Factura procesada con éxito!");
            Console.WriteLine($"Se ha guardado el archivo de texto como: {nombreArchivo}");
        }
    }
}
