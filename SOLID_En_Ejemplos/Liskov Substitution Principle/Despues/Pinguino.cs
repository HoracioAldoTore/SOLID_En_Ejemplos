
namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Despues
{
    // 4. Pinguino hereda directamente de Ave (no tiene el método Volar)
    public class Pinguino : Ave
    {
        public void Nadar()
        {
            Console.WriteLine("El pingüino está nadando.");
        }
    }
}
