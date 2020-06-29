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
    public partial class FrmCarteraChequesABM : Form
    {
        /// <summary>
        /// Valor de retorno.
        /// </summary>
        public static Datos.Cheque_cartera ValorReturn = null;

        public FrmCarteraChequesABM()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ValorReturn = null;
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Cheque_cartera CC = new Datos.Cheque_cartera();
                CC.Id_Localidad = Convert.ToInt32(id_LocalidadNumericUpDown.Value);
                CC.Numero_Recibo_Cheque_Cartera = 0;
                CC.Nombre_Cheque_Cartera = nombre_Cheque_CarteraTextBox.Text;
                CC.Fecha_Emicion_Cheque_Cartera = fecha_Emicion_Cheque_CarteraDateTimePicker.Value;
                CC.Fecha_Vencimiento_Cheque_Cartera = fecha_Vencimiento_Cheque_CarteraDateTimePicker.Value;
                CC.Nombre_Librador_Cheque_Cartera = nombre_Librador_Cheque_CarteraTextBox.Text;
                CC.Marca_Cheque_Cartera = false;
                CC.Importe_Cheque_Cartera = importe_Cheque_CarteraNumericUpDown.Value;
                CC.Detalle_Cheque_Cartera = detalle_Cheque_CarteraTextBox.Text;
                CC.Codigo_Cheque_Cartera = CodigotextBox.Text;

                if (CC.Id_Localidad == 0 || CC.Nombre_Librador_Cheque_Cartera == "" || CC.Nombre_Cheque_Cartera == "" || CC.Importe_Cheque_Cartera == 0 || CC.Codigo_Cheque_Cartera == "")
                {
                    throw new Exception("Faltan completar algunos campos");
                }

                ValorReturn = CC;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarLocalidad_Click(object sender, EventArgs e)
        {
            MDI.FrmLocalidad FrmP = new MDI.FrmLocalidad();
            FrmP.ShowDialog();
            if (MDI.FrmLocalidad.ValorReturn != "")
            {
                id_LocalidadNumericUpDown.Value = Convert.ToInt32(MDI.FrmLocalidad.ValorReturn);
                Txt_NombreLocalidad.Text = Datos.Localidad.GetLocalidad(id_LocalidadNumericUpDown.Value.ToString()).ListaLocalidad[0].Nombre_Localidad;
            }
        }
    }
}
