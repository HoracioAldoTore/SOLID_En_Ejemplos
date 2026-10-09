
namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Despues
{
    // 3. Aves voladoras heredan de AveVoladora
    public class Paloma : AveVoladora
    {
        public override void Volar()
        {
            Console.WriteLine("La paloma está volando.");
        }
    }
}
