using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Taladro
    {
        private int _idtaladro;
        private string _label;
        private float _x1;
        private float _y1;
        private float _z1;
        private float _x2;
        private float _y2;
        private float _z2;
        private float _diametro;
        private double _longitud;
        private double _rumbo;
        private double _buzamiento;
        private double _desviacion;
        private double _erroremboquille;
        private double _espaciamiento;
        private double _burden;
        private double _factorcarga;
        private double _factorpotencia;
        private double _tamcaracteristico;
        private double _indiceuniformidad;
        private double _x50;
        private double _x80;
        private double _x95;
        private double _r1;
        private double _r2;
        private int _idtipoTaladro;
        private int _idestadotaladro;
        private int _idproceso;
        private int _idzonaproyecto;

        public int Idtaladro { get => _idtaladro; set => _idtaladro = value; }
        public string Label { get => _label; set => _label = value; }
        public float X1 { get => _x1; set => _x1 = value; }
        public float Y1 { get => _y1; set => _y1 = value; }
        public float Z1 { get => _z1; set => _z1 = value; }
        public float X2 { get => _x2; set => _x2 = value; }
        public float Y2 { get => _y2; set => _y2 = value; }
        public float Z2 { get => _z2; set => _z2 = value; }
        public float Diametro { get => _diametro; set => _diametro = value; }
        public double Longitud { get => _longitud; set => _longitud = value; }
        public double Rumbo { get => _rumbo; set => _rumbo = value; }
        public double Buzamiento { get => _buzamiento; set => _buzamiento = value; }
        public double Desviacion { get => _desviacion; set => _desviacion = value; }
        public double Erroremboquille { get => _erroremboquille; set => _erroremboquille = value; }
        public double Espaciamiento { get => _espaciamiento; set => _espaciamiento = value; }
        public double Burden { get => _burden; set => _burden = value; }
        public double Factorcarga { get => _factorcarga; set => _factorcarga = value; }
        public double Factorpotencia { get => _factorpotencia; set => _factorpotencia = value; }
        public double Tamcaracteristico { get => _tamcaracteristico; set => _tamcaracteristico = value; }
        public double Indiceuniformidad { get => _indiceuniformidad; set => _indiceuniformidad = value; }
        public double X50 { get => _x50; set => _x50 = value; }
        public double X80 { get => _x80; set => _x80 = value; }
        public double X95 { get => _x95; set => _x95 = value; }
        public double R1 { get => _r1; set => _r1 = value; }
        public double R2 { get => _r2; set => _r2 = value; }
        public int IdtipoTaladro { get => _idtipoTaladro; set => _idtipoTaladro = value; }
        public int Idestadotaladro { get => _idestadotaladro; set => _idestadotaladro = value; }
        public int Idproceso { get => _idproceso; set => _idproceso = value; }
        public int Idzonaproyecto { get => _idzonaproyecto; set => _idzonaproyecto = value; }

    }
}
