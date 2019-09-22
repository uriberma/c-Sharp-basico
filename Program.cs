using static System.Console;
using CoreEscuela.Entidades;
using CoreEscuela.utils;
using System;
using System.Linq;
using System.Collections.Generic;

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

            var diccionarioobj = engine.GetDiccionarioObjetos();
            engine.ImprimirDiccionario(diccionarioobj, true);
        }

    }
}
