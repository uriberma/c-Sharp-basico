using System;
using System.Linq;
using System.Collections.Generic;
using CoreEscuela.Entidades;

namespace CoreEscuela.App
{
    public class Reporteador
    {
        Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaBase>> _diccionario;
            
        public Reporteador(Dictionary<LlavesDiccionario, IEnumerable<ObjetoEscuelaBase>> dicObjEsc)
        {
            _diccionario = dicObjEsc ?? throw new ArgumentNullException(nameof(dicObjEsc));
        }

        public IEnumerable<Evaluacion> GetListaDeEvaluaciones()
        {
            if (_diccionario.TryGetValue(LlavesDiccionario.Evaluacion, out IEnumerable<ObjetoEscuelaBase> lista))
            {

                return lista.Cast<Evaluacion>();
            }
            {
                return new List<Evaluacion>();
            }
        }
    }
}
