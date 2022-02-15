using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DXF_Text
    {
        private DXF_Point _posicion;
        private string texto;

        public DXF_Point Posicion { get => _posicion; set => _posicion = value; }
        public string Texto { get => texto; set => texto = value; }
    }
}
