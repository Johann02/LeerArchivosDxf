using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        N_DXF n_DXF = new N_DXF();
        N_Imagen n_Imagen = new N_Imagen();
        N_Taladro n_Taladro = new N_Taladro();
        N_UndoRedo n_UndoRedo = new N_UndoRedo();
        DXFObjetos objEntidad = new DXFObjetos();
        OpenFileDialog ofd = new OpenFileDialog();

        public List<Taladro> taladros = new List<Taladro>();

        Stack<List<Taladro>> stackTaladro = new Stack<List<Taladro>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBox_Image.Image = Image.FromFile(@"assets\camara.png");
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            picBox_Image.Image = n_Imagen.cargarImage(ofd);
        }

        private void btn_dxf_Click(object sender, EventArgs e)
        {
            objEntidad = n_DXF.cargarDxf(ofd);
            //var json = JsonConvert.SerializeObject(objEntidad);
            //txt_dxf.Text = json;
            taladros = n_Taladro.convetirDXFCircleToTaladro(objEntidad.Circle, taladros);
            SerializarTaladro(taladros);
            n_UndoRedo.UndoRedo(taladros);
            //Console.WriteLine("Datos => " + json);
        }

        private void tsbtn_undo_Click(object sender, EventArgs e)
        {
            UndoRedo("undo");
        }

        private void tsbtn_redo_Click(object sender, EventArgs e)
        {
            UndoRedo("redo");
        }

        private void tsbtn_agregarTaladro_Click(object sender, EventArgs e)
        {
            taladros = n_Taladro.agregarTaladro(taladros);
            n_UndoRedo.UndoRedo(taladros);
            SerializarTaladro(taladros);
        }

        private void tsbtn_eliminarTaladro_Click(object sender, EventArgs e)
        {
            taladros = n_Taladro.removerTaladro(taladros);
            n_UndoRedo.UndoRedo(taladros);
            SerializarTaladro(taladros);
        }

        void SerializarTaladro(List<Taladro> taladro)
        {
            var json = JsonConvert.SerializeObject(taladro);
            txt_dxf.Text = json;
        }

        void UndoRedo(string accion)
        {
            switch (accion)
            {
                case "undo":
                    n_UndoRedo.Undo();
                    break;
                case "redo":
                    n_UndoRedo.Redo();
                    break;
            }
            if (n_UndoRedo.StackUndoTaldro.Count > 0)
            {
                tsbtn_undo.Enabled = true;
            }
            else
            {
                tsbtn_undo.Enabled = false;
            }
            if (n_UndoRedo.StackRedoTaldro.Count > 0)
            {
                tsbtn_redo.Enabled = true;
            }
            else
            {
                tsbtn_redo.Enabled = false;
            }
            taladros = n_UndoRedo.Taladro;
            SerializarTaladro(taladros);
        }
    }
}
