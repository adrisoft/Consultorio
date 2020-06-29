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
    public partial class FrmLocalidadABM : Form
    {
        bool CerrarVentana = false;

        public FrmLocalidadABM()
        {
            InitializeComponent();
        }

        public FrmLocalidadABM(string IdLocalidad)
        {
            InitializeComponent();

            try
            {
                //Busco el una unica fila por su id
                Datos.Localidad L = Datos.Localidad.GetLocalidadRelacional(IdLocalidad);

                Txt_Id.Text = IdLocalidad;
                id_ProvinciaTextBox.Text = L.ListaLocalidad[0].Id_Provincia.ToString();
                Txt_NombreProvincia.Text = L.ListaLocalidad[0].Provincia.Nombre_Provincia;

                codigo_PostalTextBox.Text = L.ListaLocalidad[0].Codigo_Postal_Localidad.ToString();
                nombreTextBox.Text = L.ListaLocalidad[0].Nombre_Localidad;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlValores();

                Datos.Localidad L = new Datos.Localidad();
                L.Id_Localidad = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);

                L.Id_Provincia = Convert.ToInt32(id_ProvinciaTextBox.Text);
                L.Codigo_Postal_Localidad = Convert.ToInt32(codigo_PostalTextBox.Text);
                L.Nombre_Localidad = nombreTextBox.Text;

                if (Txt_Id.Text == "")
                {
                    Datos.Localidad.Add(L);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Localidad.Set(L);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                CerrarVentana = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarProvincia_Click(object sender, EventArgs e)
        {
            MDI.FrmProvincia FrmP = new MDI.FrmProvincia();
            FrmP.ShowDialog();
            if (MDI.FrmProvincia.ValorReturn != "")
            {
                id_ProvinciaTextBox.Text = MDI.FrmProvincia.ValorReturn;
                Txt_NombreProvincia.Text = Datos.Provincia.GetProvincia(id_ProvinciaTextBox.Text).ListaProvincia[0].Nombre_Provincia;
            }
        }

        private void ControlValores()
        {
            if (id_ProvinciaTextBox.Text == "")
            {
                ProvError.SetError(Txt_NombreProvincia, "Falta elegir a una provincia.");
            }
            else
            {
                ProvError.SetError(Txt_NombreProvincia, "");
            }
        }

        private void FrmLocalidadABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CerrarVentana;
        }
    }
}
