using System.Collections.Generic;
using CoreEscuela.utils;
using System;

namespace CoreEscuela.Entidades
{
    public class Curso: ObjetoEscuelaBase, ILugar
    {
        public TiposJornada Jornada { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public string Direccion { get; set; }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando Curso...");
            Console.WriteLine($"Curso {Nombre} esta Limpio!");
        }
    }

}
