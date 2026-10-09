using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_En_Ejemplos.Interface_Segregation_Principle.Antes
{
    public class Robot : ITrabajador
    {
        public void Trabajar()
        {
            Console.WriteLine("El robot está trabajando...");
        }

        // Violación de ISP: Se fuerza al robot a implementar miembros que no necesita
        public void Comer()
        {
            throw new NotImplementedException("Un robot no come.");
        }

        public void Descansar()
        {
            throw new NotImplementedException("Un robot no descansa.");
        }
    }
}
