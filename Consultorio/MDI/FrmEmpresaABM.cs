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
    public partial class FrmEmpresaABM : Form
    {
        public FrmEmpresaABM()
        {
            InitializeComponent();
        }

        private void FrmEmpresaABM_Load(object sender, EventArgs e)
        {
            Datos.Tercero_iva TI = Datos.Tercero_iva.GetTercero_iva("");

            foreach (Datos.Tercero_iva itemTercero_iva in TI.ListaTercero_iva)
            {
                CboCondicion.Items.Add(itemTercero_iva.Id_Tercero_IVA.ToString() + "- " + itemTercero_iva.Descripcion_Tercero_IVA);
            }

            try
            {
                Datos.Empresa E = Datos.Empresa.GetEmpresaRelacional("1");

                id_LocalidadNumericUpDown.Value = E.ListaEmpresa[0].Id_Localidad;
                Txt_NombreLocalidad.Text = E.ListaEmpresa[0].Localidad.Nombre_Localidad;

                CboCondicion.SelectedIndex = E.ListaEmpresa[0].Id_Tercero_IVA - 1;
                razon_Social_EmpresaTextBox.Text = E.ListaEmpresa[0].Razon_Social_Empresa;
                titular_EmpresaTextBox.Text = E.ListaEmpresa[0].Titular_Empresa;
                cUIT_EmpresaTextBox.Text = E.ListaEmpresa[0].CUIT_Empresa;
                direccion_EmpresaTextBox.Text = E.ListaEmpresa[0].Direccion_Empresa;
                telefonos_EmpresaTextBox.Text = E.ListaEmpresa[0].Telefonos_Empresa;
                fax_EmpresaTextBox.Text = E.ListaEmpresa[0].Fax_Empresa;
                email_EmpresaTextBox.Text = E.ListaEmpresa[0].Email_Empresa;
                web_EmpresaTextBox.Text = E.ListaEmpresa[0].Web_Empresa;
                IngresosBrutostextBox.Text = E.ListaEmpresa[0].Ingresos_Brutos_Empresa;
                InicioActuvidaddateTimePicker.Value = E.ListaEmpresa[0].Inicio_Actividades_Empresa;
            }
            catch
            {
                Txt_NombreLocalidad.Text = "";
                razon_Social_EmpresaTextBox.Text = "";
                titular_EmpresaTextBox.Text = "";
                cUIT_EmpresaTextBox.Text = "";
                direccion_EmpresaTextBox.Text = "";
                telefonos_EmpresaTextBox.Text = "";
                fax_EmpresaTextBox.Text = "";
                email_EmpresaTextBox.Text = "";
                web_EmpresaTextBox.Text = "";
                IngresosBrutostextBox.Text = "";
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
                Datos.Empresa E = new Datos.Empresa();
                E.Id_Empresa = 1;

                E.Id_Localidad = Convert.ToInt32(id_LocalidadNumericUpDown.Value);
                E.Id_Tercero_IVA = Convert.ToInt32(CboCondicion.SelectedItem.ToString().Split(Convert.ToChar("-"))[0]);
                E.Razon_Social_Empresa = razon_Social_EmpresaTextBox.Text;
                E.Titular_Empresa = titular_EmpresaTextBox.Text;
                E.CUIT_Empresa = cUIT_EmpresaTextBox.Text;
                E.Direccion_Empresa = direccion_EmpresaTextBox.Text;
                E.Telefonos_Empresa = telefonos_EmpresaTextBox.Text;
                E.Fax_Empresa = fax_EmpresaTextBox.Text;
                E.Email_Empresa = email_EmpresaTextBox.Text;
                E.Web_Empresa = web_EmpresaTextBox.Text;
                E.Inicio_Actividades_Empresa = InicioActuvidaddateTimePicker.Value;
                E.Ingresos_Brutos_Empresa = IngresosBrutostextBox.Text;

                Datos.Empresa.Set(E);
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarLocalidad_Click(object sender, EventArgs e)
        {
            MDI.FrmLocalidad FrmL = new MDI.FrmLocalidad();
            FrmL.ShowDialog();
            if (MDI.FrmLocalidad.ValorReturn != "")
            {
                id_LocalidadNumericUpDown.Value = Convert.ToInt32(MDI.FrmLocalidad.ValorReturn);
                Txt_NombreLocalidad.Text = Datos.Localidad.GetLocalidad(id_LocalidadNumericUpDown.Value.ToString()).ListaLocalidad[0].Nombre_Localidad;
            }
        }
    }
}
