abstract class Pago
{
    public string Titular { get; set; }
    public decimal Monto { get; set; }

    public Pago(string titular, decimal monto)
    {
        Titular = titular;
        Monto = monto;
    }

    public abstract decimal CalcularComision();

    public abstract void ProcesarPago();

    public void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Monto original: $" + Monto);
    }
}
