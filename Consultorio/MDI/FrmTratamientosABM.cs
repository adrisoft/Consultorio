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
    public partial class FrmTratamientosABM : Form
    {
        public FrmTratamientosABM()
        {
            InitializeComponent();
        }

        public FrmTratamientosABM(string IdTratamiento)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Tratamiento T = Datos.Tratamiento.GetTratamiento(IdTratamiento,"").ListaTratamiento[0];

                id_TratamientoNumericUpDown.Value = T.Id_Tratamiento;
                descripcion_TratamientoTextBox.Text = T.Descripcion_Tratamiento;
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
                Datos.Tratamiento T = new Datos.Tratamiento();
                T.Id_Tratamiento = (int)id_TratamientoNumericUpDown.Value;
                T.Descripcion_Tratamiento = descripcion_TratamientoTextBox.Text;

                if (id_TratamientoNumericUpDown.Value == 0)
                {
                    Datos.Tratamiento.Add(T);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Tratamiento.Set(T);
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
