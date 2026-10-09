namespace SOLID_En_Ejemplos.Open_Closed_Principle.Despues
{
    // 1. Interfaz que establece el contrato común
    public interface IJuego
    {
        string Titulo { get; }
        void Iniciar();
    }
}
