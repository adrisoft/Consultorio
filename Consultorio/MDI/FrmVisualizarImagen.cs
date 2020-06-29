using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultorio.MDI
{
    public partial class FrmVisualizarImagen : Form
    {
        public FrmVisualizarImagen(Image Imagen)
        {
            InitializeComponent();
            CuadroImagen.Image = Imagen;
        }

        private void CuadroImagen_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
