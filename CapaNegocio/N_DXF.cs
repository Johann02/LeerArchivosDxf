using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using netDxf;
using CapaEntidad;

namespace CapaNegocio
{
    public class N_DXF
    {        
        private DxfDocument dxf;

        public DXFObjetos cargarDxf(OpenFileDialog ofd)
        {
            DXFObjetos objEntidad = new DXFObjetos();
            ofd.Filter = "DXF (*.dxf)|*.dxf|Todos los Archivos|*.*";
            ofd.Title = "Seleccione el archivo ...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //string ruta = "pruebas.dxf";
                string ruta = ofd.FileName;
                dxf = DxfDocument.Load(ruta);
                foreach (var c in dxf.Circles)
                {
                    objEntidad.Circle.Add(new DXF_Circle
                    {
                        Centro = new DXF_Point(c.Center.X, c.Center.Y, c.Center.Z),
                        Radio = c.Radius
                    });
                }
                foreach (var l in dxf.Lines)
                {
                    objEntidad.Line.Add(new DXF_Line
                    {
                        PuntoInicio = new DXF_Point(l.StartPoint.X, l.StartPoint.Y, l.StartPoint.Z),
                        PuntoFin = new DXF_Point(l.EndPoint.X, l.EndPoint.Y, l.EndPoint.Z)
                    });
                }
                foreach (var p in dxf.Points)
                {
                    objEntidad.Point.Add(new DXF_Point(p.Position.X, p.Position.Y, p.Position.Z));
                }
                foreach (var lP in dxf.Polylines)
                {
                    List<DXF_Point> puntos = new List<DXF_Point>();
                    foreach (var v in lP.Vertexes)
                    {
                        puntos.Add(new DXF_Point(v.Position.X, v.Position.Y, v.Position.Z));
                    }
                    objEntidad.Polyline.Add(new DXF_Polyline
                    {
                        Linea = puntos
                    });
                }
                foreach (var lP in dxf.LwPolylines)
                {
                    List<DXF_Point> puntos = new List<DXF_Point>();
                    foreach (var v in lP.Vertexes)
                    {
                        puntos.Add(new DXF_Point(v.Position.X, v.Position.Y, 0));
                    }
                    objEntidad.Polyline.Add(new DXF_Polyline
                    {
                        LwLinea = puntos
                    });
                }
                foreach (var t in dxf.Texts)
                {
                    objEntidad.Text.Add(new DXF_Text
                    {
                       Posicion = new DXF_Point(t.Position.X, t.Position.Y, t.Position.Z),
                       Texto = t.Value
                    });
                }
            }

            return objEntidad;
        }
    }
}
