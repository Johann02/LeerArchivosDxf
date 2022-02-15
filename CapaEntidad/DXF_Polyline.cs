using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DXF_Polyline
    {
        private List<DXF_Point> _linea = new List<DXF_Point>();
        private List<DXF_Point> _lwLinea = new List<DXF_Point>();

        public List<DXF_Point> Linea { get => _linea; set => _linea = value; }
        public List<DXF_Point> LwLinea { get => _lwLinea; set => _lwLinea = value; }
    }
}
