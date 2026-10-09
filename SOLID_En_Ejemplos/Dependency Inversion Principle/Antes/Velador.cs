
namespace SOLID_En_Ejemplos.Dependency_Inversion_Principle.Antes
{
    // Clase de alto nivel
    public class Velador
    {
        // Acoplamiento fuerte: Depende directamente de la clase concreta
        private LamparaIncandescente _lampara;

        public Velador()
        {
            // El velador crea su propia instancia rígida de la lámpara
            _lampara = new LamparaIncandescente();
        }

        public void PresionarInterruptor(bool encender)
        {
            if (encender)
            {
                _lampara.Encender();
            }
            else
            {
                _lampara.Apagar();
            }
        }
    }
}
