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
    public partial class FrmAcercaDe : Form
    {
        public FrmAcercaDe()
        {
            InitializeComponent();
        }

        private void FrmAcercaDe_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAcercaDe_Load(object sender, EventArgs e)
        {
            Lbl_Version.Text = "Versión : " + Application.ProductVersion;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.adriansosa.com.ar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
