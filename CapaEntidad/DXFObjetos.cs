using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DXFObjetos
    {
        private List<DXF_Circle> _circle = new List<DXF_Circle>();
        private List<DXF_Line> _line = new List<DXF_Line>();
        private List<DXF_Point> _point = new List<DXF_Point>();
        private List<DXF_Polyline> _polyline = new List<DXF_Polyline>();
        private List<DXF_Text> _text = new List<DXF_Text>();

        public List<DXF_Circle> Circle { get => _circle;  set => _circle = value; }
        public List<DXF_Line> Line { get => _line; set => _line = value; }
        public List<DXF_Point> Point { get => _point; set => _point = value; }
        public List<DXF_Polyline> Polyline { get => _polyline; set => _polyline = value; }
        public List<DXF_Text> Text { get => _text; set => _text = value; }
    }
}
