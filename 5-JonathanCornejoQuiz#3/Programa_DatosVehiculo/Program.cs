// See https://aka.ms/new-console-template for more information
using System;
using System.IO; // <-- IMPORTANTE: Añade esto al principio de tu archivo

class Program
{
    static void Main()
    {
        Console.WriteLine("Programa de calculo de factura de VEHICULOS.."); //nombre del programa
        Console.WriteLine("Ingrese el nombre del cliente: "); //solicita el nombre del cliente
        string nombreCliente = Console.ReadLine(); //lee el nombre del cliente ingresado
        Console.WriteLine("Ingrese la placa del vehiculo"); //se ingresa la placa el vehiculo
        string PlacaVehiculo = Console.ReadLine(); //lee la placa del vehiculo ingresado
        Console.WriteLine("Cantidad de hora estacinado: "); //solicita la cantidad de horas estacionados
        double horasEstacionado = Convert.ToDouble(Console.ReadLine()); //lee la cantidad de horas estacionadas
        Console.WriteLine("Ingrese el tipo de vehiculo (1: Moto, 2: Auto, 3: Camioneta): "); //solicita el tipo de cliente
        int tipoVehiculo = Convert.ToInt32(Console.ReadLine()); //lee el tipo de vehiculo ingresado

        double tarifaMoto = 0.75; //inicializa la variable tarifa de moto
        double tarifaAuto = 1.50; //inicializa la variable tarifaAuto  
        double tarifaCamioneta = 2.25; //inicializa la variable tarifaCamioneta
        double subtotal = 0; //inicializa la variable subtotal
        double totalpagar = 0; //inicializa la variable totalpagar
        double itbms = 0.07; //inicializa la variable impuesto

        // Variable para armar el texto de la factura que se guardará
        string tipoVehiculoTexto = "";

        // 1. Obtenemos la fecha y hora actual con el formato que desees
        string fechaHoraActual = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");

        if (horasEstacionado < 1 || horasEstacionado > 24)
        {
            Console.WriteLine("Error: La cantidad de horas estacionadas debe estar entre 1 y 24.");
            return;
        }
        else
        {
            switch (tipoVehiculo) //evalua el tipo de cliente
            {
                case 1:
                    subtotal = horasEstacionado * tarifaMoto;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoVehiculoTexto = "Moto";
                    break;
                case 2:
                    subtotal = horasEstacionado * tarifaAuto;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoVehiculoTexto = "Auto";
                    break;
                case 3:
                    subtotal = horasEstacionado * tarifaCamioneta;
                    totalpagar = subtotal + (subtotal * itbms);
                    tipoVehiculoTexto = "Camioneta";
                    break;
                default:
                    Console.WriteLine("Error: Tipo de cliente inválido.");
                    return;
            }

            // 1. Estructuramos el contenido de la factura en una sola variable de texto
            string facturaTexto =
                $"========== FACTURA ELÉCTRICA ==========\n" +
                $"Fecha y Hora de creación: {fechaHoraActual}\n" +
                $"Cliente: {nombreCliente}\n" +
                $"Tipo de Vehiculo: {tipoVehiculoTexto}\n" +
                $"Horas estacionadas: {horasEstacionado} Horas\n" +
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

