
namespace SOLID_En_Ejemplos.Interface_Segregation_Principle.Despues
{
    // 3. Robot implementa únicamente la interfaz que necesita
    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot está trabajando...");
        }
    }
}
