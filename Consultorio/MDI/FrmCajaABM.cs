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
    public partial class FrmCajaABM : Form
    {
        public FrmCajaABM()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Datos.Caja C = new Datos.Caja();
            C.Id_Caja_Tipo = (Ingreso_radioButton.Checked) ? 2 : 3;
            C.Fecha_Caja = fecha_CajaDateTimePicker.Value;
            C.Importe_Caja = importe_CajaNumericUpDown.Value;
            C.Tag_Caja = tag_CajaTextBox.Text;
            try
            {
                if (importe_CajaNumericUpDown.Value == 0)
                {
                    if (MessageBox.Show("Esta agregando un movimiento en la caja con un importe de 0(Cero) pesos, ¿Desea continuar?", "Sin importe!", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                }

                Datos.Caja.Add(C);
                MessageBox.Show("Se ha agregado un nuevo registro.");
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
