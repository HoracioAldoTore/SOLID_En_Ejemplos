
namespace SOLID_En_Ejemplos.Interface_Segregation_Principle.Despues
{
    // 4. Humano implementa ambas interfaces
    public class Humano : ITrabajador, INecesidades
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
