using System;

public class Program{
    static void Main()
    {
        int opcion;
        Console.Write("Ingrese el nombre del titular: ");
        string titular = Console.ReadLine();

        Console.Write("Ingrese el monto: $");
        decimal monto = decimal.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine("======== SISTEMA DE PAGOS =======");
            Console.WriteLine(@"Seleccione método de pago:
1 - Efectivo (sin comision)
2 - Tarjeta (8% de comisión)
3 - Salir
Opción");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("--- PROCESANDO PAGO ---");

            switch (opcion)
            {
                case 1:
                    PagoEfectivo efectivo = new PagoEfectivo(titular, monto);
                    efectivo.MostrarInformacion();
                    efectivo.ProcesarPago();
                    break;
                    
                case 2:
                    PagoTarjeta tarjeta = new PagoTarjeta(titular, monto);
                    tarjeta.MostrarInformacion();
                    tarjeta.ProcesarPago();
                    break;

                case 3:
                    Console.WriteLine("Saliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        } while (opcion != 3);
    }
}