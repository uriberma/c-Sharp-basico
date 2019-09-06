using static System.Guid;

namespace CoreEscuela.Entidades
{
    public class Evaluacion
    {
        public string UniqueId { get; private set; } = NewGuid().ToString();
        public string Nombre { get; set; }
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }
        public float Nota { get; set; }
    }
}
