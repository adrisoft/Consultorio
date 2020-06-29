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
    public partial class FrmObrasSocialesABM : Form
    {
        public FrmObrasSocialesABM()
        {
            InitializeComponent();
        }

        public FrmObrasSocialesABM(string IdObraSocial)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Obra_social OS = Datos.Obra_social.GetObra_social(IdObraSocial,"").ListaObra_social[0];

                id_Obra_SocialNumericUpDown.Value = OS.Id_Obra_Social;
                descripcion_Obra_SocialTextBox.Text = OS.Descripcion_Obra_Social;
                observaciones_Obra_SocialTextBox.Text = OS.Observaciones_Obra_Social;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Obra_social OS = new Datos.Obra_social();

                OS.Id_Obra_Social = (int)id_Obra_SocialNumericUpDown.Value;
                OS.Descripcion_Obra_Social = descripcion_Obra_SocialTextBox.Text;
                OS.Observaciones_Obra_Social = observaciones_Obra_SocialTextBox.Text;

                if (id_Obra_SocialNumericUpDown.Value == 0)
                {
                    Datos.Obra_social.Add(OS);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Obra_social.Set(OS);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
