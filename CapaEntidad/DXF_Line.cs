using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DXF_Line
    {
        private DXF_Point _puntoInicio;
        private DXF_Point _puntoFin;

        public DXF_Point PuntoInicio { get => _puntoInicio; set => _puntoInicio = value; }
        public DXF_Point PuntoFin { get => _puntoFin; set => _puntoFin = value; }
    }
}
