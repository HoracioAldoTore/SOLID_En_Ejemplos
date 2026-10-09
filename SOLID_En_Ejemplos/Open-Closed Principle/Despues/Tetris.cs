using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_En_Ejemplos.Open_Closed_Principle.Despues
{
    // 3. Implementación de Tetris
    public class Tetris : IJuego
    {
        public string Titulo => "Tetris";

        public void Iniciar()
        {
            Console.WriteLine("Preparando la matriz de fichas de Tetris...");
        }
    }
}
