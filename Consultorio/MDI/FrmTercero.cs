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
    public partial class FrmTercero : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";
        int _TipoTercero;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmTercero(int TipoTercero)
        {
            InitializeComponent();
            try
            {
                this.Text = Datos.Tercero_tipo.GetTercero_tipo(TipoTercero.ToString()).ListaTercero_tipo[0].Descripcion_Tercero_Tipo;
            }
            catch
            {
                this.Text = "";
            }
            _TipoTercero = TipoTercero;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmTerceroABM FrmTABM = new FrmTerceroABM(_TipoTercero);
            FrmTABM.ShowDialog();
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmTerceroABM FrmTABM = new FrmTerceroABM(DG_Datos.SelectedRows[0].Tag.ToString(), _TipoTercero);
                if (FrmTABM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
                Datos.Tercero T = Datos.Tercero.GetTerceroRelacional(Txt_Id.Text, _TipoTercero.ToString(),razon_social_textBox1.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_RSocial", "Razón social");
                DG_Datos.Columns.Add("Clm_Dirección", "Dirección");
                DG_Datos.Columns.Add("Clm_Teléfonos", "Teléfonos");
                DG_Datos.Columns.Add("Clm_Localidad", "Localidad");
                DG_Datos.Columns.Add("Clm_Email", "Email");
                //DG_Datos.Columns.Add("Clm_Saldo", "Saldo");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_RSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Dirección"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Teléfonos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Localidad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                //DG_Datos.Columns["Clm_Saldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                //decimal SaldoTotal = 0;
                foreach (Datos.Tercero ItemTercero in T.ListaTercero)
                {
                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemTercero.Id_Tercero;

                    if (ItemTercero.Anulado_Tercero)
                    {
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                    }

                    //decimal SaldoTercero = Common.SaldoTercero(ItemTercero.Id_Tercero.ToString());

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_RSocial"].Value = ItemTercero.Razon_Social_Tercero;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Dirección"].Value = ItemTercero.Direccion_Tercero;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Teléfonos"].Value = ItemTercero.Telefonos_Tercero;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Localidad"].Value = ItemTercero.Localidad.Nombre_Localidad;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Email"].Value = ItemTercero.Email_Tercero;
                    //DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Saldo"].Value = "$ " + SaldoTercero.ToString(Config.NumeroDecimales);

                    //SaldoTotal += SaldoTercero;
                }

                Txt_CantidadRegistros.Text = T.ListaTercero.Count.ToString();
                //Txt_SaldoTotal.Text = "$ " + SaldoTotal.ToString(Config.NumeroDecimales);

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

        private void Btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea dar de baja este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Baja", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Tercero T = Datos.Tercero.GetTercero(DG_Datos.SelectedRows[0].Tag.ToString(),"");
                    T.ListaTercero[0].Anulado_Tercero = true;
                    Datos.Tercero.Set(T.ListaTercero[0]);
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea dar de alta este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Tercero T = Datos.Tercero.GetTercero(DG_Datos.SelectedRows[0].Tag.ToString(),"");
                    T.ListaTercero[0].Anulado_Tercero = false;
                    Datos.Tercero.Set(T.ListaTercero[0]);
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmTercero_Load_1(object sender, EventArgs e)
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
                    Datos.Tercero.Delete_TerceroRelacionesEnfermedades(DG_Datos.SelectedRows[0].Tag.ToString());
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
