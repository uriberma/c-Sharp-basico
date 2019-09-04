using System.Collections.Generic;


namespace CoreEscuela.Entidades
{
    class Escuela
    {
        public string Nombre { get; set; }
        public int AnioDeCreacion { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }       
        public TiposEscuela TipoEscuela { get; set; }
        public List<Curso> Cursos { get; set; }

        public Escuela(string nombre, int anio) => (Nombre, AnioDeCreacion) = (nombre, anio);
        public Escuela(string nombre, int anio, TiposEscuela tipo, string pais = "", string ciudad = "") =>
                        (Nombre, AnioDeCreacion, TipoEscuela, Pais, Ciudad) = 
                        (nombre, anio, tipo, pais, ciudad);

        public string MuestraEscuela()
        {
            return $"Nombre: {Nombre}\nTipo: {TipoEscuela}\nPais: {Pais}\nCiudad: {Ciudad}";
        }
    }
}