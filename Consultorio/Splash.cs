using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Consultorio
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progreso.Value++;
            if(Progreso.Value >= 200)
            {
                Close();
            }

            if (Progreso.Value == 83)
            {
                Lbl_Cargando.Text = "Cargando archivos...";
            }

            if (Progreso.Value == 140)
            {
                Lbl_Cargando.Text = "Cargando componentes...";
            }

            if (Progreso.Value == 170)
            {
                Lbl_Cargando.Text = "Finalizando..";
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Lbl_Cargando.Text = "Cargando configuración...";
            bool Cargar = true;
            if (!Common.ExisteArchivoCnn())
            {
                Conexion FrmCnn = new Conexion();
                DialogResult ResultadoDialogo = FrmCnn.ShowDialog();
                if (ResultadoDialogo == System.Windows.Forms.DialogResult.Cancel)
                {
                    Cargar = false;
                }
                else if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Common.Cnn = new MySqlConnection(Common.RecuperarCnn().ConnectionString);
                }
            }
            else
            {
                Datos.Common.Cnn = new MySqlConnection(Common.RecuperarCnn().ConnectionString);
            }

            Lbl_Cargando.Text = "Probando la conección...";
            if (!Datos.Common.ProbarCnn())
            {
                Cargar = false;
                MessageBox.Show("La conexión al servidor no esta disponible.");
            }

            if (Cargar)
            {
                Config.CargarFormPrincipal = true;
                timer1.Enabled = true;
            }
            else
            {
                Close();
            }
            Lbl_Cargando.Text = "Cargando modulos...";
        }
    }
}
