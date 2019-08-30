using System;
using CoreEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {   
            var escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad:"Bogota");
            escuela.Pais = "Colombia";

            var escuela2 = new Escuela("Platzi Escuela", 2012, TiposEscuela.Secundaria, "Venezuela", "Maturin");

            // array de cursos

            Curso[] cursos = new Curso[3];

            cursos[0] = new Curso()
            {
                Nombre = "Informatica",
                Jornada = TiposJornada.Manana,
            };

            cursos[1] = new Curso()
            {
                Nombre = "Ciencias",
                Jornada = TiposJornada.Tarde,
            };

            cursos[2] = new Curso()
            {
                Nombre = "Ciencias",
                Jornada = TiposJornada.Tarde,
            };

            // ejecucion
            Console.WriteLine(escuela2.MuestraEscuela());
            Console.WriteLine("===============CURSOS=========");
            ImprimirCursosWhile(cursos);

        }

        private static void ImprimirCursosWhile(Curso[] cursos)
        {
            int contador = 0;
            while (contador < cursos.Length)
            {
                Console.WriteLine($"Nombre: {cursos[contador].Nombre}, id: {cursos[contador].UniqueId}");
                contador++;
            }
        }
    }
}
