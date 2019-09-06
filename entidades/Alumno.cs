using System.Collections.Generic;
using static System.Guid;

namespace CoreEscuela.Entidades
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluacion> ListaEvaluaciones { get; set; } = new List<Evaluacion>();
    }
}
