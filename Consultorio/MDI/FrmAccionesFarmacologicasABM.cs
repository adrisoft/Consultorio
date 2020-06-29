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
    public partial class FrmAccionesFarmacologicasABM : Form
    {
        public FrmAccionesFarmacologicasABM()
        {
            InitializeComponent();
        }

        public FrmAccionesFarmacologicasABM(string IdAccionesFarmacologicas)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Medicacion_accion_farmacologica MAF = Datos.Medicacion_accion_farmacologica.GetMedicacion_accion_farmacologica(IdAccionesFarmacologicas,"").ListaMedicacion_accion_farmacologica[0];

                id_Medicacion_Accion_FarmacologicaNumericUpDown.Value = Convert.ToInt32(IdAccionesFarmacologicas);

                descripcion_Medicacion_Accion_FarmacologicaTextBox.Text = MAF.Descripcion_Medicacion_Accion_Farmacologica;
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
                Datos.Medicacion_accion_farmacologica MAF = new Datos.Medicacion_accion_farmacologica();
                MAF.Id_Medicacion_Accion_Farmacologica = (int)id_Medicacion_Accion_FarmacologicaNumericUpDown.Value;
                MAF.Descripcion_Medicacion_Accion_Farmacologica = descripcion_Medicacion_Accion_FarmacologicaTextBox.Text;

                if (id_Medicacion_Accion_FarmacologicaNumericUpDown.Value == 0)
                {
                    Datos.Medicacion_accion_farmacologica.Add(MAF);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Medicacion_accion_farmacologica.Set(MAF);
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
