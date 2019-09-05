using static System.Console;

namespace CoreEscuela.utils
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea = "".PadLeft(tam, '=');
            WriteLine(linea);
        }

        public static void DibujarTitulo(string titulo)
        {
            DibujarLinea(titulo.Length + 6);
            WriteLine($" | {titulo} | ");
            DibujarLinea(titulo.Length + 6);
        }

        public static void Beep(int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz, tiempo);
            }
        }
    }
}
