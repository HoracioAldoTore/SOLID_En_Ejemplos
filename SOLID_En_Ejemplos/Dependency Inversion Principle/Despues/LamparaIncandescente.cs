

namespace SOLID_En_Ejemplos.Dependency_Inversion_Principle.Despues
{
    // 2. Clases de bajo nivel (Implementaciones concretas)
    public class LamparaIncandescente : ILampara
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
