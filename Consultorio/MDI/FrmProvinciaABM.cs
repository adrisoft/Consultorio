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
    public partial class FrmProvinciaABM : Form
    {
        bool CerrarVentana = false;

        public FrmProvinciaABM()
        {
            InitializeComponent();
        }

        public FrmProvinciaABM(string IdProvincia)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Provincia P = Datos.Provincia.GetProvinciaRelacional(IdProvincia);

                Txt_Id.Text = IdProvincia;

                id_PaisTextBox.Text = P.ListaProvincia[0].Id_Pais.ToString();
                Txt_NombrePais.Text = P.ListaProvincia[0].Pais.Nombre_Pais;

                nombreTextBox.Text = P.ListaProvincia[0].Nombre_Provincia;
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

                Datos.Provincia P = new Datos.Provincia();
                P.Id_Provincia = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);

                P.Id_Pais = Convert.ToInt32(id_PaisTextBox.Text);
                P.Nombre_Provincia = nombreTextBox.Text;

                if (Txt_Id.Text == "")
                {
                    Datos.Provincia.Add(P);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Provincia.Set(P);
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

        private void Btn_BuscarPais_Click(object sender, EventArgs e)
        {
            MDI.FrmPais FrmP = new MDI.FrmPais();
            FrmP.ShowDialog();
            if (MDI.FrmPais.ValorReturn != "")
            {
                id_PaisTextBox.Text = MDI.FrmPais.ValorReturn;
                Txt_NombrePais.Text = Datos.Pais.GetPais(id_PaisTextBox.Text).ListaPais[0].Nombre_Pais;
            }
        }

        private void ControlValores()
        {
            if (id_PaisTextBox.Text == "")
            {
                ProvError.SetError(Txt_NombrePais, "Falta elegir a un pais.");
            }
            else
            {
                ProvError.SetError(Txt_NombrePais, "");
            }
        }

        private void FrmProvinciaABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CerrarVentana;
        }
    }
}
