using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Antes
{
    public class Gorrion : Ave
    {
        public override void Volar()
        {
            Console.WriteLine("El gorrión vuela rápido.");
        }
    }
}
