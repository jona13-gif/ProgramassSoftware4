using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Variables
        string nombre;
        int cantidadBoletos;
        int categoria;
        double precioUnitario = 0;
        double subtotal;
        double descuento = 0;
        double totalFinal;
        string nombreCategoria;

        // Solicitar datos
        Console.Write("Ingrese el nombre del comprador: ");
        nombre = Console.ReadLine();

        Console.Write("Ingrese la cantidad de boletos (1-10): ");
        cantidadBoletos = int.Parse(Console.ReadLine());

        // Validar cantidad de boletos usando if-else
        if (cantidadBoletos >= 1 && cantidadBoletos <= 10)
        {
            Console.WriteLine("\nCategorías disponibles:");
            Console.WriteLine("1 = General ($15.00)");
            Console.WriteLine("2 = Preferencial ($30.00)");
            Console.WriteLine("3 = VIP ($50.00)");

            Console.Write("Seleccione una categoría: ");
            categoria = int.Parse(Console.ReadLine());

            // Determinar precio usando switch
            switch (categoria)
            {
                case 1:
                    precioUnitario = 15.00;
                    nombreCategoria = "General";
                    break;

                case 2:
                    precioUnitario = 30.00;
                    nombreCategoria = "Preferencial";
                    break;

                case 3:
                    precioUnitario = 50.00;
                    nombreCategoria = "VIP";
                    break;

                default:
                    Console.WriteLine("Categoría no válida.");
                    return;
            }

            // Calcular subtotal
            subtotal = cantidadBoletos * precioUnitario;

            // Aplicar descuento del 12% si compra 5 o más boletos
            if (cantidadBoletos >= 5)
            {
                descuento = subtotal * 0.12;
            }

            // Calcular total final
            totalFinal = subtotal - descuento;

            // Mostrar resultados
            Console.WriteLine("\n===== RESUMEN DE LA COMPRA =====");
            Console.WriteLine("Comprador: " + nombre);
            Console.WriteLine("Categoría: " + nombreCategoria);
            Console.WriteLine("Cantidad de boletos: " + cantidadBoletos);
            Console.WriteLine("Precio unitario: $" + precioUnitario.ToString("F2"));
            Console.WriteLine("Subtotal: $" + subtotal.ToString("F2"));
            Console.WriteLine("Descuento: $" + descuento.ToString("F2"));
            Console.WriteLine("Total final a pagar: $" + totalFinal.ToString("F2"));

            // Obtener fecha y hora
            string fechaHora = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Crear contenido del reporte
            string reporte =
                "===== REPORTE DE VENTA DE BOLETOS =====\r\n" +
                "Nombre del comprador: " + nombre + "\r\n" +
                "Categoría: " + nombreCategoria + "\r\n" +
                "Cantidad de boletos: " + cantidadBoletos + "\r\n" +
                "Precio unitario: $" + precioUnitario.ToString("F2") + "\r\n" +
                "Subtotal: $" + subtotal.ToString("F2") + "\r\n" +
                "Descuento: $" + descuento.ToString("F2") + "\r\n" +
                "Total final a pagar: $" + totalFinal.ToString("F2") + "\r\n" +
                "Fecha y hora: " + fechaHora + "\r\n";

            // Guardar en archivo de texto
            File.WriteAllText("reporte_boletos.txt", reporte);

            Console.WriteLine("\nEl reporte se guardó correctamente en reporte_boletos.txt");
        }
        else
        {
            Console.WriteLine("Cantidad de boletos no válida. Debe estar entre 1 y 10.");
        }

        Console.WriteLine("\nPresione una tecla para finalizar...");
        Console.ReadKey();
    }
}
