using static System.Console;
using CoreEscuela.Entidades;

namespace etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            Escuela escuela = new Escuela("Platzi Escuela", 2012, TiposEscuela.Primaria, ciudad: "Bogota")
            {
                Pais = "Colombia"
            };

            // array de cursos

            escuela.Cursos = new Curso[]
            {
                new Curso() { Nombre = "101", Jornada = TiposJornada.Manana },
                new Curso() { Nombre = "201", Jornada = TiposJornada.Tarde },
                new Curso() { Nombre = "301", Jornada = TiposJornada.Noche }
            };

            // ejecucion
            WriteLine(escuela.MuestraEscuela());
            WriteLine("=====================================================");
            WriteLine("Cursos");
            WriteLine("=====================================================");
            ImprimirCursosEscuela(escuela);

        }
        private static void ImprimirCursosEscuela(Escuela escuela)

        {
            if (escuela != null && escuela.Cursos != null)
            {
                foreach (var curso in escuela.Cursos)
                {
                    WriteLine($"Nombre: {curso.Nombre}, id: {curso.UniqueId}");
                }
            }
            else
            {
                WriteLine("No hay nada para mostrar");
            }
              
        }

    }
}


//private static void ImprimirCursosWhile(Curso[] cursos)
//{
//    int contador = 0;
//    while (contador < cursos.Length)
//    {
//        WriteLine($"Nombre: {cursos[contador].Nombre}, id: {cursos[contador].UniqueId}");
//        contador++;
//    }
//}

//private static void ImprimirCursosDoWhile(Curso[] cursos)
//{
//    int contador = 0;
//    do
//    {
//        WriteLine($"Nombre: {cursos[contador].Nombre}, id: {cursos[contador].UniqueId}");
//    }
//    while (++contador < cursos.Length);
//}

//private static void ImprimirCursosFor(Curso[] cursos)

//{
//    for (int i = 0; i < cursos.Length; i++)
//    {
//        WriteLine($"Nombre: {cursos[i].Nombre}, id: {cursos[i].UniqueId}");
//    }
//}