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
    public partial class FrmAccionesFarmacologicas : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmAccionesFarmacologicas()
        {
            InitializeComponent();
        }

        private void FrmAccionesFarmacologicas_Load(object sender, EventArgs e)
        {
            ValorReturn = "";
            Buscar();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmAccionesFarmacologicasABM FrmCABM = new FrmAccionesFarmacologicasABM();
            FrmCABM.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAccionesFarmacologicasABM FrmCABM = new FrmAccionesFarmacologicasABM(DG_Datos.SelectedRows[0].Tag.ToString());
                if (FrmCABM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
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
                Datos.Medicacion_accion_farmacologica MAF = Datos.Medicacion_accion_farmacologica.GetMedicacion_accion_farmacologica(Txt_Id.Text, Txt_AccionFarmacologica.Text );

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_AccionFarmacologica", "Acción farmacológica");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_AccionFarmacologica"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                foreach (Datos.Medicacion_accion_farmacologica ItemMedicacion_accion_farmacologica in MAF.ListaMedicacion_accion_farmacologica)
                {
                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemMedicacion_accion_farmacologica.Id_Medicacion_Accion_Farmacologica;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_AccionFarmacologica"].Value = ItemMedicacion_accion_farmacologica.Descripcion_Medicacion_Accion_Farmacologica;

                }

                Txt_CantidadRegistros.Text = MAF.ListaMedicacion_accion_farmacologica.Count.ToString();

                if (NumeroFilaUltimaSeleccion != 0 && DG_Datos.Rows.Count > NumeroFilaUltimaSeleccion)
                {
                    DG_Datos.Rows[NumeroFilaUltimaSeleccion].Selected = true;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
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
                    Datos.Medicacion_accion_farmacologica.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
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
                Close();
            }
            else
            {
                Btn_Editar_Click(sender, e);
            }
        }
    }
}
