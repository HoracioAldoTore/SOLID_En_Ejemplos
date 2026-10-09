using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_En_Ejemplos.Liskov_Substitution_Principle.Antes
{
    public class Pinguino : Ave
    {
        public override void Volar()
        {
            // Violación de LSP: Al heredar de Ave, fuerza a implementar Volar(), 
            // rompiendo el comportamiento esperado de la clase base.
            throw new NotSupportedException("Los pingüinos no vuelan.");
        }
    }
}
