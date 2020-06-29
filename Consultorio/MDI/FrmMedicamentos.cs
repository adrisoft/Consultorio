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
    public partial class FrmMedicamentos : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private bool CancelarBusqueda = false;
        private bool DetenerBusqueda = false;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmMedicamentos()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Btn_Buscar.Enabled = false;
            Btn_Detener.Enabled = true;
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmMedicamentosABM FrmCABM = new FrmMedicamentosABM();
            FrmCABM.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmMedicamentosABM FrmCABM = new FrmMedicamentosABM(DG_Datos.SelectedRows[0].Tag.ToString());
                if (FrmCABM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Btn_Buscar.Enabled = false;
                    Btn_Detener.Enabled = true;
                    Buscar();
                }
            }
            catch
            {
                MessageBox.Show("Debe seleccionar una fila de la grilla de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Medicacion M = Datos.Medicacion.GetMedicacionRelacional(Txt_Id.Text, TXT_PrincipioActico.Text, TXT_NombreComercial.Text, id_TerceroTextBox.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_PrincipioActivo", "Principio activo");
                DG_Datos.Columns.Add("Clm_NombreComercial", "Nombre comercial");
                DG_Datos.Columns.Add("Clm_Presentacion", "Presentación");
                DG_Datos.Columns.Add("Clm_AccionFarmacologica", "Acción farmacológica");
                DG_Datos.Columns.Add("Clm_Laboratorio", "Laboratorio");
                DG_Datos.Columns.Add("Clm_Observaciones", "Observaciones");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_PrincipioActivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_NombreComercial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Presentacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_AccionFarmacologica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Laboratorio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                Progreso.Minimum = 0;
                Progreso.Maximum = M.ListaMedicacion.Count;
                Progreso.Value = 0;
                LblPorcentaje.Text = "0 %";
                Txt_CantidadRegistros.Text = M.ListaMedicacion.Count.ToString();

                CancelarBusqueda = false;
                //Agrego las filas
                foreach (Datos.Medicacion ItemMedicacion in M.ListaMedicacion)
                {
                    if (CancelarBusqueda)
                    {
                        break;
                    }

                    if (DetenerBusqueda)
                    {
                        DetenerBusqueda = false;
                        break;
                    }

                    Application.DoEvents();
                    Progreso.Value++;
                    LblPorcentaje.Text = (Progreso.Value * 100 / Progreso.Maximum).ToString("##0") + " %";

                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemMedicacion.Id_Medicacion;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_PrincipioActivo"].Value = ItemMedicacion.Principio_Activo_Medicacion;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_NombreComercial"].Value = ItemMedicacion.Nombre_Comercial_Medicacion;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Presentacion"].Value = ItemMedicacion.Presentacion_Medicacion;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_AccionFarmacologica"].Value = ItemMedicacion.Medicacion_accion_farmacologica.Descripcion_Medicacion_Accion_Farmacologica;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Laboratorio"].Value = ItemMedicacion.Medicacion_laboratorio.Descripcion_Laboratorio;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemMedicacion.Observaciones_Medicacion;
                }
                LblPorcentaje.Text = "0 %";
                Progreso.Value = 0;
                if (NumeroFilaUltimaSeleccion != 0 && DG_Datos.Rows.Count > NumeroFilaUltimaSeleccion)
                {
                    DG_Datos.Rows[NumeroFilaUltimaSeleccion].Selected = true;
                }

                Btn_Buscar.Enabled = true;
                Btn_Detener.Enabled = false;
            }
            catch (Exception Error)
            {
                if (!CancelarBusqueda)
                {
                    MessageBox.Show(Error.Message);
                }
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ValorReturn = "";
            Close();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea eliminar este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Medicacion.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (DG_Datos.SelectedRows.Count == 0)
            {
                ValorReturn = "";
            }
            else
            {
                ValorReturn = DG_Datos.SelectedRows[0].Tag.ToString();
            }
            CancelarBusqueda = true;
            Close();
        }

        private void DG_Datos_Click(object sender, EventArgs e)
        {
            try
            {
                NumeroFilaUltimaSeleccion = DG_Datos.SelectedRows[0].Index;
            }
            catch
            {
                NumeroFilaUltimaSeleccion = 0;
            }
        }

        private void DG_Datos_DoubleClick(object sender, EventArgs e)
        {
            if (this.MdiParent == null)
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    ValorReturn = "";
                }
                else
                {
                    ValorReturn = DG_Datos.SelectedRows[0].Tag.ToString();
                }
                CancelarBusqueda = true;
                Close();
            }
            else
            {
                Btn_Editar_Click(sender, e);
            }
        }

        private void FrmMedicamentos_Load(object sender, EventArgs e)
        {
            ValorReturn = "";
            //Buscar();
            Btn_Detener.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_TerceroTextBox.Text = "";
            Txt_NombreTercero.Text = "";
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmAccionesFarmacologicas FrmC = new MDI.FrmAccionesFarmacologicas();
            FrmC.ShowDialog();
            if (MDI.FrmAccionesFarmacologicas.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmAccionesFarmacologicas.ValorReturn;
                Txt_NombreTercero.Text = Datos.Medicacion_accion_farmacologica.GetMedicacion_accion_farmacologica(id_TerceroTextBox.Text, "").ListaMedicacion_accion_farmacologica[0].Descripcion_Medicacion_Accion_Farmacologica;
            }
        }

        private void FrmMedicamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelarBusqueda = true;
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            DetenerBusqueda = true;
            Btn_Detener.Enabled = false;
            Btn_Buscar.Enabled = true;
        }
    }
}
