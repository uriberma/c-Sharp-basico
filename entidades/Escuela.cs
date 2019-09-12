using System.Collections.Generic;
using System;
using CoreEscuela.utils;

namespace CoreEscuela.Entidades
{
    public class Escuela: ObjetoEscuelaBase, ILugar
    {
        public int AnioDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }       
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }
        public string Direccion { get; set; }

        public Escuela(string nombre, int anio) => (Nombre, AnioDeCreacion) = (nombre, anio);

        public Escuela(string nombre, int anio, TiposEscuela tipo, string pais = "", string ciudad = "") =>
                        (Nombre, AnioDeCreacion, TipoEscuela, Pais, Ciudad) = 
                        (nombre, anio, tipo, pais, ciudad);

        public string MuestraEscuela()
        {
            return $"Nombre: {Nombre}\nTipo: {TipoEscuela}\nPais: {Pais}\nCiudad: {Ciudad}";
        }

        public void LimpiarLugar()
        {
            Printer.DrawLine();
            Console.WriteLine("Limpiando Establecimiento...");

            foreach (var curso in Cursos)
            {
                curso.LimpiarLugar();
            }
        }
    }
}   