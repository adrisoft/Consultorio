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
    public partial class FrmMedicamentosABM : Form
    {
        bool CerrarVentana = false;

        public FrmMedicamentosABM()
        {
            InitializeComponent();
        }

        public FrmMedicamentosABM(string IdMedicamentos)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Medicacion M = Datos.Medicacion.GetMedicacionRelacional(IdMedicamentos,"","","").ListaMedicacion[0];

                id_MedicacionNumericUpDown.Value = M.Id_Medicacion;
                id_Medicacion_Accion_FarmacologicaNumericUpDown.Value = M.Id_Medicacion_Accion_Farmacologica;
                Txt_NombreAccionFarmacologica.Text = M.Medicacion_accion_farmacologica.Descripcion_Medicacion_Accion_Farmacologica;
                id_Medicacion_AutorizacionNumericUpDown.Value = M.Id_Medicacion_Autorizacion;
                Txt_NombreAutorizacion.Text = M.Medicacion_autorizacion.Descripcion_Medicacion_Autorizacion;
                id_Medicacion_LaboratorioNumericUpDown.Value = M.Id_Medicacion_Laboratorio;
                Txt_NombreLaboratorio.Text = M.Medicacion_laboratorio.Descripcion_Laboratorio;

                principio_Activo_MedicacionTextBox.Text = M.Principio_Activo_Medicacion;
                nombre_Comercial_MedicacionTextBox.Text = M.Nombre_Comercial_Medicacion;
                presentacion_MedicacionTextBox.Text = M.Presentacion_Medicacion;
                regis_MedicacionTextBox.Text = M.Regis_Medicacion;
                troquel_MedicacionTextBox.Text = M.Troquel_Medicacion;
                observaciones_MedicacionTextBox.Text = M.Observaciones_Medicacion;
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
                Datos.Medicacion M = new Datos.Medicacion();
                M.Id_Medicacion = (int)id_MedicacionNumericUpDown.Value;
                M.Id_Medicacion_Accion_Farmacologica = (int)id_Medicacion_Accion_FarmacologicaNumericUpDown.Value;
                M.Id_Medicacion_Autorizacion = (int)id_Medicacion_AutorizacionNumericUpDown.Value;
                M.Id_Medicacion_Laboratorio = (int)id_Medicacion_LaboratorioNumericUpDown.Value;

                M.Principio_Activo_Medicacion = principio_Activo_MedicacionTextBox.Text;
                M.Nombre_Comercial_Medicacion = nombre_Comercial_MedicacionTextBox.Text;
                M.Presentacion_Medicacion = presentacion_MedicacionTextBox.Text;
                M.Regis_Medicacion = regis_MedicacionTextBox.Text;
                M.Troquel_Medicacion = troquel_MedicacionTextBox.Text;
                M.Observaciones_Medicacion = observaciones_MedicacionTextBox.Text;

                if (id_MedicacionNumericUpDown.Value == 0)
                {
                    Datos.Medicacion.Add(M);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Medicacion.Set(M);
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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void Btn_BuscarAccionFarmacologica_Click(object sender, EventArgs e)
        {
            MDI.FrmAccionesFarmacologicas FrmP = new MDI.FrmAccionesFarmacologicas();
            FrmP.ShowDialog();
            if (MDI.FrmAccionesFarmacologicas.ValorReturn != "")
            {
                id_Medicacion_Accion_FarmacologicaNumericUpDown.Value = Convert.ToInt32(MDI.FrmAccionesFarmacologicas.ValorReturn);
                Txt_NombreAccionFarmacologica.Text = Datos.Medicacion_accion_farmacologica.GetMedicacion_accion_farmacologica(id_Medicacion_Accion_FarmacologicaNumericUpDown.Value.ToString(),"").ListaMedicacion_accion_farmacologica[0].Descripcion_Medicacion_Accion_Farmacologica;
            }
        }

        private void Btn_BuscarAutorizacion_Click(object sender, EventArgs e)
        {
            MDI.FrmAutorizaciones FrmP = new MDI.FrmAutorizaciones();
            FrmP.ShowDialog();
            if (MDI.FrmAutorizaciones.ValorReturn != "")
            {
                id_Medicacion_AutorizacionNumericUpDown.Value = Convert.ToInt32(MDI.FrmAutorizaciones.ValorReturn);
                Txt_NombreAutorizacion.Text = Datos.Medicacion_autorizacion.GetMedicacion_autorizacion(id_Medicacion_AutorizacionNumericUpDown.Value.ToString(),"").ListaMedicacion_autorizacion[0].Descripcion_Medicacion_Autorizacion;
            }
        }

        private void Btn_BuscarLaboratorio_Click(object sender, EventArgs e)
        {
            MDI.FrmLaboratorios FrmP = new MDI.FrmLaboratorios();
            FrmP.ShowDialog();
            if (MDI.FrmLaboratorios.ValorReturn != "")
            {
                id_Medicacion_LaboratorioNumericUpDown.Value = Convert.ToInt32(MDI.FrmLaboratorios.ValorReturn);
                Txt_NombreLaboratorio.Text = Datos.Medicacion_laboratorio.GetMedicacion_laboratorio(id_Medicacion_LaboratorioNumericUpDown.Value.ToString(),"").ListaMedicacion_laboratorio[0].Descripcion_Laboratorio;
            }
        }

        private void FrmMedicamentosABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CerrarVentana;
        }
    }
}
