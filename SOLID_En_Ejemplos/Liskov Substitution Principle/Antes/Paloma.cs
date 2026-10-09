

namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Antes
{
    public class Paloma : Ave
    {
        public override void Volar()
        {
            Console.WriteLine("La paloma vuela alto.");
        }
    }
}
