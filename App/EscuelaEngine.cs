using System;
using System.Collections.Generic;

namespace CoreEscuela.Entidades
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia")
            {
                Cursos = new List<Curso>()
                {
                    new Curso() { Nombre = "101", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "201", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "301", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "401", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde },
                    new Curso() { Nombre = "601", Jornada = TiposJornada.Tarde }
                }
            };
        }
    }
}
