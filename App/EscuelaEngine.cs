using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.utils;

namespace CoreEscuela.Entidades
{
    public sealed class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {
            Inicializar();
            Printer.WriteTitle($"Bienvenidos a {Escuela.Nombre}");
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            // cargar cursos alumnos asignaturas y evaluaciones
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetosEscuela(
            bool traeEvaluaciones = true,
            bool traerAlumnos = true,
            bool traerAsignaturas = true,
            bool traerCursos = true
            )
        {
            return GetObjetosEscuela(out int dummy, out dummy, out dummy, out dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetosEscuela(
            out int conteoEvaluaciones,
            bool traeEvaluaciones = true,
            bool traerAlumnos = true,
            bool traerAsignaturas = true,
            bool traerCursos = true
            )
        {
            return GetObjetosEscuela(out conteoEvaluaciones, out int dummy, out dummy, out dummy);
        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetosEscuela(
          out int conteoEvaluaciones,
          out int conteoAlumnos,
          bool traeEvaluaciones = true,
          bool traerAlumnos = true,
          bool traerAsignaturas = true,
          bool traerCursos = true
          )
        {
            return GetObjetosEscuela(out conteoEvaluaciones, out conteoAlumnos, out int dummy, out dummy);
        }

        public List<ObjetoEscuelaBase> GetObjetosEscuela(
         out int conteoEvaluaciones,
         out int conteoAlumnos,
         out int conteoAsignaturas,
         bool traeEvaluaciones = true,
         bool traerAlumnos = true,
         bool traerAsignaturas = true,
         bool traerCursos = true
         )
        {
            return GetObjetosEscuela(out conteoEvaluaciones, out conteoAlumnos, out conteoAsignaturas);
        }

        public IReadOnlyList<ObjetoEscuelaBase> GetObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoAlumnos,
            out int conteoAsignaturas,
            out int conteoCursos,
            bool traeEvaluaciones = true,
            bool traerAlumnos = true,
            bool traerAsignaturas = true,
            bool traerCursos = true 
            )
        {
            conteoEvaluaciones = conteoAlumnos = conteoAsignaturas = 0;

            var listaObj = new List<ObjetoEscuelaBase>();
            listaObj.Add(Escuela);

            if (traerCursos)
            {
                listaObj.AddRange(Escuela.Cursos);
            }

            conteoCursos = Escuela.Cursos.Count;

            foreach (var curso in Escuela.Cursos)
            {
                conteoAsignaturas += curso.Asignaturas.Count;
                conteoAlumnos += curso.Alumnos.Count;

                if (traerAsignaturas)
                {
                    listaObj.AddRange(curso.Asignaturas);

                }


                if (traerAlumnos)
                {
                    listaObj.AddRange(curso.Alumnos);
                }

                if (traeEvaluaciones)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        listaObj.AddRange(alumno.ListaEvaluaciones);
                        conteoEvaluaciones += alumno.ListaEvaluaciones.Count;
                    }
                }
               
            }

            return listaObj.AsReadOnly();
        }

        #region Metodos de carga
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
            foreach (var c in Escuela.Cursos)
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
            Random rnd = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                foreach (var asignatura in curso.Asignaturas)
                {
                    foreach (var alumno in curso.Alumnos)
                    {
                        for (var i = 0; i < asignatura.NumeroEvaluaciones; i++)
                        {

                            alumno.ListaEvaluaciones.Add(new Evaluacion()
                            {
                                Nombre = $"evaluacion {i + 1}",
                                Alumno = alumno,
                                Asignatura = asignatura,
                                Nota = (float)(rnd.NextDouble() * (5.0 - 1.0) + 1.0)
                            });
                        }
                    }
                }
            }
        }
        #endregion
    }
}
