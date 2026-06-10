class PagoTarjeta : Pago
{
    public PagoTarjeta(string titular, decimal monto) : base(titular, monto)
    {
    }

    public override decimal CalcularComision()
    {
        return Monto * 0.08m;
    }

    public override void ProcesarPago()
    {
        Console.WriteLine("Procesando pago...");

        decimal comision = CalcularComision();
        decimal montoFinal = Monto + comision;

        Console.WriteLine("Comision aplicada: $" + comision);
        Console.WriteLine("Monto final: $" + montoFinal);
        Console.WriteLine("Pago realizado correctamente.");
    }
}
