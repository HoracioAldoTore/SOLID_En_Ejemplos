namespace SOLID_En_Ejemplos.Single_Responsibility_Principle.Antes
{
    // ANTES: Una sola clase asume todas las responsabilidades
    public class Factura
    {
        public decimal Monto { get; set; }

        public decimal CalcularTotal()
        {
            // Lógica de cálculo de total e impuestos
            return Monto * 1.21m; // Ejemplo con IVA
        }

        public void EnviarPorEmail(string destinatario)
        {
            // Lógica para enviar la factura por correo electrónico
        }

        public void Imprimir()
        {
            // Lógica para enviar la factura a la impresora
        }
    }
}
