

namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Despues
{
    public class Gorrion : AveVoladora
    {
        public override void Volar()
        {
            Console.WriteLine("El gorrión está volando.");
        }
    }
}
