﻿using static System.Guid;

namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public Curso() => (UniqueId) = (NewGuid().ToString());

        public string CursoInfo() => $"Nombre: {Nombre}\nJornada: {Jornada}\nUID: {UniqueId}";
        
    }

}
