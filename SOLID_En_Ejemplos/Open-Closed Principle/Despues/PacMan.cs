namespace SOLID_En_Ejemplos.Open_Closed_Principle.Despues
{
    // 2. Implementación de PacMan
    public class PacMan : IJuego
    {
        public string Titulo => "PacMan";

        public void Iniciar()
        {
            Console.WriteLine("Cargando el laberinto de PacMan...");
        }
    }
}
