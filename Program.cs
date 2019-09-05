using static System.Console;
using CoreEscuela.Entidades;
using System.Collections.Generic;
using System;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad: "Bogota", pais: "Colombia");

            // colectiones
            escuela.Cursos = new List<Curso>()
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Manana },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Tarde }
            };

            escuela.Cursos.Add(new Curso() { Nombre = "102", Jornada = TiposJornada.Manana });
            escuela.Cursos.Add(new Curso() { Nombre = "103", Jornada = TiposJornada.Manana });

            // ejecucion
            WriteLine(escuela.MuestraEscuela());
            WriteLine("=====================================================");
            WriteLine("Cursos");
            WriteLine("=====================================================");

            // agregar y borrar curso de prueba
            Curso tmp = new Curso() { Nombre = "101-Vacacional", Jornada = TiposJornada.Noche };
            escuela.Cursos.Add(tmp);

            ImprimirCursosEscuela(escuela);

            WriteLine("=====================================================");

            /*
             * implementacion de un predicado para eliminar elementos en una lista
             * un delegado asegura que los parametros de entrada y de salida sean correctos y garantiza que se cumplan
             */
            Predicate<Curso> miAlgoritmo = Predicado;
            escuela.Cursos.RemoveAll(miAlgoritmo);


            // una manera mas corta de hacer lo mismo
            escuela.Cursos.RemoveAll(delegate (Curso cur)
                                    {
                                        return cur.Nombre == "201";
                                    });

            // o usanda una expresion lambda ( usar cuando lo que se comprueba son pocos valores )
            escuela.Cursos.RemoveAll((cur) => cur.Nombre == "101");

            ImprimirCursosEscuela(escuela);

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

/*
 * IF ELSE FOR FOREACH WHILE DO WHILE
 *  
private static void ImprimirCursosWhile(Curso[] cursos)
{
   int contador = 0;
   while (contador < cursos.Length)
   {
       WriteLine($"Nombre: {cursos[contador].Nombre}, id: {cursos[contador].UniqueId}");
       contador++;
   }
}

private static void ImprimirCursosDoWhile(Curso[] cursos)
{
   int contador = 0;
   do
   {
       WriteLine($"Nombre: {cursos[contador].Nombre}, id: {cursos[contador].UniqueId}");
   }
   while (++contador < cursos.Length);
}

private static void ImprimirCursosFor(Curso[] cursos)

{
   for (int i = 0; i < cursos.Length; i++)
   {
       WriteLine($"Nombre: {cursos[i].Nombre}, id: {cursos[i].UniqueId}");
   }
}
*/