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
    public partial class FrmProvincia : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmProvincia()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmProvinciaABM FrmPABM = new FrmProvinciaABM();
            FrmPABM.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmProvinciaABM FrmPABM = new FrmProvinciaABM(DG_Datos.SelectedRows[0].Tag.ToString());
                if (FrmPABM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
                Datos.Provincia P = Datos.Provincia.GetProvinciaRelacional(Txt_Id.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Provincia", "Provincia");
                DG_Datos.Columns.Add("Clm_Pais", "País");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Provincia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Pais"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                foreach (Datos.Provincia ItemProvincia in P.ListaProvincia)
                {
                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemProvincia.Id_Provincia;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Provincia"].Value = ItemProvincia.Nombre_Provincia;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Pais"].Value = ItemProvincia.Pais.Nombre_Pais;
                }

                Txt_CantidadRegistros.Text = P.ListaProvincia.Count.ToString();

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
                    Datos.Provincia.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
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

        private void FrmProvincia_Load_1(object sender, EventArgs e)
        {
            ValorReturn = "";
            Buscar();
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
