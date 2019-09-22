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

        public IEnumerable<string> GetListaAsignaturas()
        {
            return GetListaAsignaturas(out var dummy);
        }

        public IEnumerable<string> GetListaAsignaturas(out IEnumerable<Evaluacion> listaEvaluaciones)
        {
            listaEvaluaciones = GetListaDeEvaluaciones();

            return (from Evaluacion ev in listaEvaluaciones
                    select ev.Asignatura.Nombre).Distinct();
        }

        public Dictionary<string, IEnumerable<Evaluacion>> GetDicEvaluaciones()
        {
            var dictRta = new Dictionary<string, IEnumerable<Evaluacion>>();
            var listaAsig = GetListaAsignaturas(out var listEval);

            foreach (var asig in listaAsig)
            {
                var evalAsig = from eval in listEval
                               where eval.Asignatura.Nombre == asig
                               select eval;

                dictRta.Add(asig, evalAsig);
            }
            return dictRta;
        }

    }
}