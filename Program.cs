using static System.Console;
using CoreEscuela.Entidades;
using CoreEscuela.utils;
using System;

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
            Printer.DibujarTitulo("Cursos de la Escuela");
            /*
             * implementacion de un predicado para eliminar elementos en una lista
             * un delegado asegura que los parametros de entrada y de salida sean correctos y garantiza que se cumplan
             */
            Predicate<Curso> miAlgoritmo = Predicado;
            engine.Escuela.Cursos.RemoveAll(miAlgoritmo);


            // una manera mas corta de hacer lo mismo
            engine.Escuela.Cursos.RemoveAll(delegate (Curso cur)
                                    {
                                        return cur.Nombre == "201";
                                    });

            // o usanda una expresion lambda ( usar cuando lo que se comprueba son pocos valores )
            engine.Escuela.Cursos.RemoveAll((cur) => cur.Nombre == "101");

            ImprimirCursosEscuela(engine.Escuela);

        }


        /*
         * Algoritmo del predicado para la comprobacion d
         */
        private static bool Predicado (Curso cursoobj)
        {
            return cursoobj.Nombre == "101-Vacacional";
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
                    WriteLine($"Nombre: {curso.Nombre}, id: {curso.UniqueId}, Jornada: {curso.Jornada}");
                }
            }
            else
            {
                WriteLine("No hay nada para mostrar");
            }
              
        }

    }
}
