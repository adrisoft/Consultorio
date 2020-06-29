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
    public partial class FrmCarteraCheques : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmCarteraCheques()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
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

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            ValorReturn = "";
            Close();
        }

        private void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Cheque_cartera CC = Datos.Cheque_cartera.GetCheque_carteraRelacional(Txt_Id.Text,"");

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Ciudad", "Ciudad");
                DG_Datos.Columns.Add("Clm_NombreBanco", "Nombre Banco");
                DG_Datos.Columns.Add("Clm_FechaVencimiento", "Fecha de vencimiento");
                DG_Datos.Columns.Add("Clm_FechaEmicion", "Fecha de emisión");
                DG_Datos.Columns.Add("Clm_Importe", "Importe");
                DG_Datos.Columns.Add("Clm_Nombre", "Nombre");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Ciudad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_NombreBanco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_FechaVencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_FechaEmicion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                decimal CreditoTotal = 0;
                foreach (Datos.Cheque_cartera ItemCheque_cartera in CC.ListaCheque_cartera)
                {
                    if (DT_Desde.Value <= ItemCheque_cartera.Fecha_Emicion_Cheque_Cartera && DT_Desde.Value <= ItemCheque_cartera.Fecha_Emicion_Cheque_Cartera)
                    {
                        DG_Datos.Rows.Add();
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemCheque_cartera.Id_Cheque_Cartera;

                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Ciudad"].Value = ItemCheque_cartera.Localidad.Nombre_Localidad;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_NombreBanco"].Value = ItemCheque_cartera.Nombre_Cheque_Cartera;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_FechaVencimiento"].Value = ItemCheque_cartera.Fecha_Vencimiento_Cheque_Cartera;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_FechaEmicion"].Value = ItemCheque_cartera.Fecha_Emicion_Cheque_Cartera;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Importe"].Value =  ItemCheque_cartera.Importe_Cheque_Cartera.ToString(Config.NumeroDecimales);
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Nombre"].Value = ItemCheque_cartera.Nombre_Librador_Cheque_Cartera;

                        CreditoTotal += ItemCheque_cartera.Importe_Cheque_Cartera;
                    }
                }

                Txt_CantidadRegistros.Text = CC.ListaCheque_cartera.Count.ToString();
                Txt_CreditoTotal.Text = "$ " + CreditoTotal.ToString(Config.NumeroDecimales);

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

        private void FrmCarteraCheque_Load(object sender, EventArgs e)
        {
            DateTime DateTimeTemporal = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DT_Desde.Value = DateTimeTemporal;
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
        }
    }
}
