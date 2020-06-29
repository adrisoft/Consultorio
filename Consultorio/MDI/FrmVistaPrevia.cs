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
    public partial class FrmVistaPrevia : Form
    {
        public FrmVistaPrevia()
        {
            InitializeComponent();
        }

        private void VistaPrevia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                VistaPrevia.Zoom += 0.5;
            }
            else if(e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (VistaPrevia.Zoom > 0.5)
                {
                    VistaPrevia.Zoom -= 0.5;
                }
            }
        }
    }
}
