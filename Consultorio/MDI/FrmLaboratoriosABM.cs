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
    public partial class FrmLaboratoriosABM : Form
    {
        public FrmLaboratoriosABM()
        {
            InitializeComponent();
        }

        public FrmLaboratoriosABM(string IdLaboratorio)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Medicacion_laboratorio ML = Datos.Medicacion_laboratorio.GetMedicacion_laboratorio(IdLaboratorio,"").ListaMedicacion_laboratorio[0];

                id_Medicacion_LaboratorioNumericUpDown.Value = ML.Id_Medicacion_Laboratorio;
                descripcion_LaboratorioTextBox.Text = ML.Descripcion_Laboratorio;
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
                Datos.Medicacion_laboratorio ML = new Datos.Medicacion_laboratorio();
                ML.Id_Medicacion_Laboratorio = (int)id_Medicacion_LaboratorioNumericUpDown.Value;
                ML.Descripcion_Laboratorio = descripcion_LaboratorioTextBox.Text;

                if (id_Medicacion_LaboratorioNumericUpDown.Value == 0)
                {
                    Datos.Medicacion_laboratorio.Add(ML);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Medicacion_laboratorio.Set(ML);
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
