
namespace SOLID_En_Ejemplos.Dependency_Inversion_Principle.Antes
{
    // ANTES: Violación de DIP (Acoplamiento fuerte a un detalle concreto)

    // Clase de bajo nivel (Detalle concreto)
    public class LamparaIncandescente
    {
        public void Encender()
        {
            Console.WriteLine("Lámpara incandescente encendida.");
        }

        public void Apagar()
        {
            Console.WriteLine("Lámpara incandescente apagada.");
        }
    }
}
