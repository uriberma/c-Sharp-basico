using System;
using static System.Guid;

namespace CoreEscuela.Entidades
{
    public abstract class ObjetoEscuelaBase
    {
        public string UniqueId { get; private set; } 
        public string Nombre { get; set; }

        public ObjetoEscuelaBase()
        {
            UniqueId = NewGuid().ToString();
        }
    }
}
