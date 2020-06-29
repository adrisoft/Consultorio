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
    public partial class FrmEstudiosABM : Form
    {
        public FrmEstudiosABM()
        {
            InitializeComponent();
        }

        public FrmEstudiosABM(string IdEstudio)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Estudio E = Datos.Estudio.GetEstudio(IdEstudio,"").ListaEstudio[0];

                id_EstudioNumericUpDown.Value = E.Id_Estudio;
                descripcion_EstudioTextBox.Text = E.Descripcion_Estudio;
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
                Datos.Estudio E = new Datos.Estudio();
                E.Id_Estudio = (int)id_EstudioNumericUpDown.Value;
                E.Descripcion_Estudio = descripcion_EstudioTextBox.Text;

                if (id_EstudioNumericUpDown.Value == 0)
                {
                    Datos.Estudio.Add(E);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Estudio.Set(E);
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
