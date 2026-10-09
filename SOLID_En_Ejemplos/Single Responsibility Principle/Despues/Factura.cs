namespace SOLID_En_Ejemplos.Single_Responsibility_Principle.Despues
{
    // DESPUÉS: Separación de responsabilidades

    // 1. Dominio de la Factura
    public class Factura
    {
        public decimal Monto { get; set; }

        public decimal CalcularTotal()
        {
            return Monto * 1.21m;
        }
    }
}
