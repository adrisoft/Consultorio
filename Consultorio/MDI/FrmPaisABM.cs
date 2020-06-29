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
    public partial class FrmPaisABM : Form
    {
        public FrmPaisABM()
        {
            InitializeComponent();
        }

        public FrmPaisABM(string IdPais)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Pais P = Datos.Pais.GetPais(IdPais);

                Txt_Id.Text = IdPais;
                nombreTextBox.Text = P.ListaPais[0].Nombre_Pais;
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

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Pais P = new Datos.Pais();
                P.Id_Pais = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);
                P.Nombre_Pais = nombreTextBox.Text;

                if (Txt_Id.Text == "")
                {
                    Datos.Pais.Add(P);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Pais.Set(P);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
