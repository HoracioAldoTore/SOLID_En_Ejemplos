namespace SOLID_En_Ejemplos.Open_Closed_Principle.Antes
{
    // MAL: Viola OCP. Para agregar otro juego hay que MODIFICAR Hardware.
    public class Hardware
    {
        public void EjecutarJuego(object juego)
        {
            if (juego is PacMan pacman)
            {
                pacman.CargarLaberinto();
            }
            else if (juego is Tetris tetris)
            {
                tetris.IniciarMatriz();
            }
            else
            {
                throw new ArgumentException("Argumento pasado a un método no válido");
            }
            // ¡Agregar un juego nuevo exige romper esta clase agregando más 'if'!
        }
    }
}
