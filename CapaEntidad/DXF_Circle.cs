using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DXF_Circle
    {
        private DXF_Point _centro;
        private double radio;

        public DXF_Point Centro { get => _centro; set => _centro = value; }
        public double Radio { get => radio; set => radio = value; }
    }
}
