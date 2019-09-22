using static System.Console;
using CoreEscuela.Entidades;
using CoreEscuela.utils;
using System;
using System.Linq;
using System.Collections.Generic;
using CoreEscuela.App;

namespace CoreEscuela
{
    class Program
    {
        static void Main(string[] args)
        {
            // AppDomain.CurrentDomain.ProcessExit += AccionEvento;
            // instanciar escuela
            var engine = new EscuelaEngine();
            engine.Inicializar();

            // ejecucion
            Printer.WriteTitle("Cursos de la Escuela");

            var diccionarioObjs = engine.GetDiccionarioObjetos();
            engine.ImprimirDiccionario(diccionarioObjs, true);

            var reporteador = new Reporteador(diccionarioObjs);
            var evalList = reporteador.GetListaDeEvaluaciones();
            var asignaturaList = reporteador.GetListaAsignaturas();
            var listaEvalAsig = reporteador.GetDicEvaluaciones();
        }

    }
}
