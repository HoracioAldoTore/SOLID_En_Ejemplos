namespace SOLID_En_Ejemplos.Open_Closed_Principle.Despues
{
    // 5. Clase Hardware (Cerrada a modificación, usa la interfaz IJuego)
    public class Hardware
    {
        /// <summary>
        /// Arcade se refiere a videojuegos rápidos y sencillos con controles fáciles
        /// </summary>
        public string Modelo { get; set; } = "Arcade Retro";

        public void EjecutarJuego(IJuego juego)
        {
            Console.WriteLine($"[{Modelo}] Ejecutando: {juego.Titulo}");
            juego.Iniciar();
        }
    }
}
