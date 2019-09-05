using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.utils;

namespace CoreEscuela.Entidades
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Inicializar();
            Printer.DibujarTitulo($"Bienvenidos a {Escuela.Nombre}");
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            // cargar cursos alumnos asignaturas y evaluaciones
            CargarCursos();
            CargarAsignaturas();

        }

        public void CargarCursos()
        {
            Escuela.Cursos = new List<Curso>()
                {
                    new Curso() { Nombre = "101", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "201", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "301", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "401", Jornada = TiposJornada.Manana },
                    new Curso() { Nombre = "501", Jornada = TiposJornada.Tarde },
                    new Curso() { Nombre = "601", Jornada = TiposJornada.Tarde }
                };
            Random rnd = new Random();
            foreach(var c in Escuela.Cursos)
            {
                int cantidadRandom = rnd.Next(20, 45);
                c.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }


        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>()
                {
                    new Asignatura{ Nombre = "Matematicas" },
                    new Asignatura{ Nombre = "Educacion Fisica" },
                    new Asignatura{ Nombre = "Castellano" },
                    new Asignatura{ Nombre = "Ciencias de la Naturaleza" },
                    new Asignatura{ Nombre = "Educacion So" }
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}" };
            return listaAlumnos.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();

        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }


    }
}
