

namespace SOLID_En_Ejemplos.Interface_Segregation_Principle.Antes
{
    public class Humano : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El humano está trabajando...");
        }

        public void Comer()
        {
            Console.WriteLine("El humano está comiendo...");
        }

        public void Descansar()
        {
            Console.WriteLine("El humano está descansando...");
        }
    }
}
