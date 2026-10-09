using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_En_Ejemplos.Open_Closed_Principle.Despues
{
    // 4. Extensión: Se agrega SpaceInvaders sin modificar las clases existentes
    public class SpaceInvaders : IJuego
    {
        public string Titulo => "SpaceInvaders";

        public void Iniciar()
        {
            Console.WriteLine("Iniciando la invasión de SpaceInvaders...");
        }
    }
}
