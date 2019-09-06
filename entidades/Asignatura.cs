using System.Collections.Generic;
using static System.Guid;

namespace CoreEscuela.Entidades
{
    public class Asignatura
    {
        public string UniqueId { get; private set; } = NewGuid().ToString();
        public string Nombre { get; set; }
        public int NumeroEvaluaciones { get; set; } = 5;
    }
}
