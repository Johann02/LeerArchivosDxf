using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class N_Imagen
    {
        public System.Drawing.Image cargarImage(OpenFileDialog ofd)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(@"assets\camara.png");
            ofd.Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|JPEG (*.jpeg)|*.jpeg|Todos los Archivos|*.*";
            ofd.Title = "Seleccione el archivo ...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                image = System.Drawing.Image.FromFile(ruta);
            }
            return image;
        }
    }
}
