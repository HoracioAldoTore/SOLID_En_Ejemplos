

namespace SOLID_En_Ejemplos.Dependency_Inversion_Principle.Despues
{
    public class LamparaLed : ILampara
    {
        public void Encender()
        {
            Console.WriteLine("Lámpara LED encendida.");
        }

        public void Apagar()
        {
            Console.WriteLine("Lámpara LED apagada.");
        }
    }
}
