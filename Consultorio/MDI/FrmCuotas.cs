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
    public partial class FrmCuotas : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private string InFactura = "";

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmCuotas(string IdTercero)
        {
            InitializeComponent();

            Datos.Factura F = Datos.Factura.GetFacturaRelacional("", "", "", "1,2", "","");

            foreach ( Datos.Factura itemFactura in F.ListaFactura)
            {
                InFactura += itemFactura.Id_Factura.ToString() + ",";
            }

            if (InFactura != "")
            {
                InFactura = InFactura.Substring(0, InFactura.Length - 1);
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Couta C = Datos.Couta.GetCoutaRelacional("", DT_Desde.Value.ToString(Config.FechaMySQL), DT_Hasta.Value.ToString(Config.FechaMySQL), "0", InFactura,"");

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Remito", "Remito");
                DG_Datos.Columns.Add("Clm_Numero", "Número");
                DG_Datos.Columns.Add("Clm_FechaVencimiento", "Fecha vencimiento");
                DG_Datos.Columns.Add("Clm_Importe", "Importe");
                DG_Datos.Columns.Add("Clm_Observaciones", "Observaciones");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Remito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_FechaVencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                foreach (Datos.Couta ItemCouta in C.ListaCouta)
                {
                    DG_Datos.Rows.Add();
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemCouta.Id_Couta;

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Remito"].Value = ItemCouta.Factura.Clase_Factura + " " + ItemCouta.Factura.Puesto_Factura.ToString("0000") + "-" + ItemCouta.Factura.Numero_Factura.ToString("00000000");
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Numero"].Value = ItemCouta.Numero_Couta_Couta;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_FechaVencimiento"].Value = ItemCouta.Fecha_Vencimineto_Couta;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Importe"].Value = (ItemCouta.Importe_Couta - ItemCouta.Asignacion_Cuota).ToString(Config.NumeroDecimales);
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemCouta.Observaciones_Couta;
                }

                Txt_CantidadRegistros.Text = C.ListaCouta.Count.ToString();

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

        private void FrmCategoria_Load_1(object sender, EventArgs e)
        {
            //DT_Desde.Value = DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day - 1, 0, 0, 0));
            //DT_Hasta.Value = DT_Desde.Value.AddMonths(1).Subtract(new TimeSpan(1, 0, 0, 0));

            DT_Desde.Value = Properties.Settings.Default.FechaCuotaDesde;
            DT_Hasta.Value = Properties.Settings.Default.FechaCuotaHasta;

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

        private void FrmCuotas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Aca tengo que guardar la configuracion de las fechas que se usan.
            Properties.Settings.Default.FechaCuotaDesde = DT_Desde.Value;
            Properties.Settings.Default.FechaCuotaHasta = DT_Hasta.Value;

            Properties.Settings.Default.Save();
        }
    }
}
