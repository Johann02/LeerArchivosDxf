using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_Taladro
    {
        public List<Taladro> convetirDXFCircleToTaladro(List<DXF_Circle> _circle, List<Taladro> _taladros)
        {
            List<Taladro> lt = new List<Taladro>();
            lt.AddRange(_taladros);
            //lt = agregarTaladrosExistentes(_taladros);
            int idmax = idMaximo(_taladros);
            for (int i = 0; i < _circle.Count; i++)
            {
                lt.Add(new Taladro
                {
                    Idtaladro = idmax + i,
                    X1 = (float)_circle[i].Centro.X,
                    Y1 = (float)_circle[i].Centro.Y,
                    Z1 = (float)_circle[i].Centro.Z,
                    Diametro = (float)_circle[i].Radio * 2f
                });
            }
            return lt;
        }

        private List<Taladro> agregarTaladrosExistentes(List<Taladro> _taladros)
        {
            List<Taladro> lt = new List<Taladro>();
            if (_taladros.Count > 0)
            {
                foreach (var t in _taladros)
                {
                    lt.Add(new Taladro
                    {
                        Idtaladro = t.Idtaladro,
                        Label = t.Label,
                        X1 = t.X1,
                        Y1 = t.Y1,
                        Z1 = t.Z1,
                        X2 = t.X2,
                        Y2 = t.Y2,
                        Z2 = t.Z2,
                        Diametro = t.Diametro,
                        Longitud = t.Longitud,
                        Rumbo = t.Rumbo,
                        Buzamiento = t.Buzamiento,
                        Desviacion = t.Desviacion,
                        Erroremboquille = t.Erroremboquille,
                        Espaciamiento = t.Espaciamiento,
                        Burden = t.Burden,
                        Factorcarga = t.Factorcarga,
                        Factorpotencia = t.Factorpotencia,
                        Tamcaracteristico = t.Tamcaracteristico,
                        Indiceuniformidad = t.Indiceuniformidad,
                        X50 = t.X50,
                        X80 = t.X80,
                        X95 = t.X95,
                        R1 = t.R1,
                        R2 = t.R2,
                        IdtipoTaladro = t.IdtipoTaladro,
                        Idestadotaladro = t.Idestadotaladro,
                        Idproceso = t.Idproceso,
                        Idzonaproyecto = t.Idzonaproyecto
                    });
                }
            }
            return lt;
        }

        private int idMaximo(List<Taladro> _taladros)
        {
            int id = 1;
            if (_taladros.Count > 0)
            {
                List<Taladro> tal = (from t in _taladros orderby t.Idtaladro descending select t).ToList();
                id = tal[0].Idtaladro + 1;
            }
            return id;
        }

        public List<Taladro> agregarTaladro(List<Taladro> _Taladro)
        {
            int idmax = idMaximo(_Taladro);
            List<Taladro> taladro = new List<Taladro>();
            taladro = (from t in _Taladro select t).ToList();
            taladro.Add(new Taladro
            {
                Idtaladro = idmax,
                X1 = (float)(idmax),
                Y1 = (float)(idmax),
                Z1 = (float)(idmax),
                Diametro = (float)(idmax)
            });

            return taladro;
        }

        public List<Taladro> removerTaladro(List<Taladro> _Taladro)
        {
            int idmax = idMaximo(_Taladro);
            List<Taladro> taladro = new List<Taladro>();
            taladro = (from t in _Taladro select t).ToList();
            if (taladro.Count > 0)
            {
                taladro.RemoveAt(taladro.Count - 1);
            }

            return taladro;
        }
    }
}
