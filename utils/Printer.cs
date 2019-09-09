using static System.Console;

namespace CoreEscuela.utils
{
    public static class Printer
    {
        public static void DrawLine(int tam = 10)
        {
            var linea = "".PadLeft(tam, '=');
            WriteLine(linea);
        }

        public static void WriteTitle(string titulo)
        {
            DrawLine(titulo.Length + 6);
            WriteLine($" | {titulo} | ");
            DrawLine(titulo.Length + 6);
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
