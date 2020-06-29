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
    public partial class FrmEnfermedadesCategorias : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private bool CancelarBusqueda = false;
        private bool DetenerBusqueda = false;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmEnfermedadesCategorias()
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
            FrmEnfermedadesCategoriasABM FrmCABM = new FrmEnfermedadesCategoriasABM();
            FrmCABM.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEnfermedadesCategoriasABM FrmCABM = new FrmEnfermedadesCategoriasABM(DG_Datos.SelectedRows[0].Tag.ToString());
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
                Datos.Enfermedad_categoria EC = Datos.Enfermedad_categoria.GetEnfermedad_categoria(Txt_Id.Text,Txt_Codigo.Text,Txt_Categoria.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Codigo", "Codigo");
                DG_Datos.Columns.Add("Clm_Categoria", "Categoría");
                DG_Datos.Columns.Add("Clm_Observacion", "Observación");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observacion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                Progreso.Minimum = 0;
                Progreso.Maximum = EC.ListaEnfermedad_categoria.Count;
                Progreso.Value = 0;
                LblPorcentaje.Text = "0 %";
                Txt_CantidadRegistros.Text = EC.ListaEnfermedad_categoria.Count.ToString();

                CancelarBusqueda = false;
                //Agrego las filas
                foreach (Datos.Enfermedad_categoria ItemEnfermedad_categoria in EC.ListaEnfermedad_categoria)
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
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemEnfermedad_categoria.Id_Enfermedad_Categoria;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Codigo"].Value = ItemEnfermedad_categoria.Codigo_Enfermedad_Categoria;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Categoria"].Value = ItemEnfermedad_categoria.Descripcion_Enfermedad_Categoria;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observacion"].Value = ItemEnfermedad_categoria.Observaciones_Enfermedad_Categoria;
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
                    Datos.Enfermedad_categoria.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
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

        private void FrmEnfermedadesCategorias_Load(object sender, EventArgs e)
        {
            //Buscar();
            ValorReturn = "";
            Btn_Detener.Enabled = false;
        }

        private void FrmEnfermedadesCategorias_FormClosing(object sender, FormClosingEventArgs e)
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
