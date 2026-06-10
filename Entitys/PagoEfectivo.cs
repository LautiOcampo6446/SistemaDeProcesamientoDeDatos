class PagoEfectivo : Pago
{
    public PagoEfectivo(string titular, decimal monto) : base(titular, monto)
    {
    }

    public override decimal CalcularComision()
    {
        return 0;
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
