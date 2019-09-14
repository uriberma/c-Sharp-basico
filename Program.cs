using static System.Console;
using CoreEscuela.Entidades;
using CoreEscuela.utils;
using System;
using System.Linq;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciar escuela
            var engine = new EscuelaEngine();
            engine.Inicializar();

            // ejecucion
            Printer.WriteTitle("Cursos de la Escuela");
            ImprimirCursosEscuela(engine.Escuela);
            var listObjetos = engine.GetObjetosEscuela(
            out int conteoEvaluaciones,
            out int conteoAlumnos,
            out int conteoAsignaturas,
            out int conteoCursos
            );
        }

       /* 
        * Imprimir los cursos de la escuela
        */

        private static void ImprimirCursosEscuela(Escuela escuela)

        {
            if (escuela != null && escuela.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, id: {curso.UniqueId}, Jornada: {curso.Jornada}, Alumnos: {curso.Alumnos.Count}, Asignaturas: {curso.Asignaturas.Count}");
                }
            }
            else
            {
                WriteLine("No hay nada para mostrar");
            }
              
        }

    }
}
