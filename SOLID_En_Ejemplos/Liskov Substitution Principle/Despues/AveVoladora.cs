
namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Despues
{
    // 2. Subclase intermedia exclusiva para aves que vuelan
    public class AveVoladora : Ave
    {
        public virtual void Volar()
        {
            Console.WriteLine("El ave voladora está alzando vuelo...");
        }
    }
}
