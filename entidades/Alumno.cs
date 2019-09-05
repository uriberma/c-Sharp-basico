using CoreEscuela.Entidades;
using static System.Guid;

namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; } = NewGuid().ToString();
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }
    }
}
