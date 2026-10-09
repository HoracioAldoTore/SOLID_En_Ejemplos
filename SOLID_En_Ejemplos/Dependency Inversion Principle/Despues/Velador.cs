
namespace SOLID_En_Ejemplos.Dependency_Inversion_Principle.Despues
{
    // 3. Clase de alto nivel refactorizada
    public class Velador
    {
        // Dependemos de la abstracción, no del detalle
        private readonly ILampara _lampara;

        // Inyección de dependencias a través del constructor
        public Velador(ILampara lampara)
        {
            _lampara = lampara;
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
