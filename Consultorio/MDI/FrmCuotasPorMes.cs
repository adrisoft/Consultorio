using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Consultorio.MDI
{
    public partial class FrmCuotasPorMes : Form
    {

        bool SegundaImpresion;
        DataGridViewPrinter MyDataGridViewPrinter;

        public FrmCuotasPorMes()
        {
            InitializeComponent();
        }

        private void FrmCuotasPorMes_Load(object sender, EventArgs e)
        {
            DT_Desde.Value = DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day - 1, 0, 0, 0));
            DT_Hasta.Value = DT_Desde.Value.AddMonths(1).Subtract(new TimeSpan(1, 0, 0, 0));
            Buscar();

            MyPrintDocument.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            foreach (System.Drawing.Printing.PaperSize itemPaperSize in MyPrintDocument.PrinterSettings.PaperSizes)
            {
                if (itemPaperSize.PaperName == "A4")
                {
                    MyPrintDocument.DefaultPageSettings.PaperSize = itemPaperSize;
                    pageSetupDialog1.PageSettings.PaperSize = itemPaperSize;
                }
            }
            printDialog1.Document = MyPrintDocument;
        }

        public void Buscar()
        {
            try
            {
                //Borro todo las filas y columnas anteriores
                DG_Datos.Columns.Clear();
                DG_Datos.Rows.Clear();

                //Busco la lista de datos
                Datos.Couta C = Datos.Couta.GetCoutaRelacional("", DT_Desde.Value.ToString(Config.FechaMySQL), DT_Hasta.Value.ToString(Config.FechaMySQL), "0", "",id_TerceroTextBox.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Nombre", "R. Social");
                DG_Datos.Columns.Add("Clm_Direccion", "Dirección");
                DG_Datos.Columns.Add("Clm_Tel", "Teléfono");
                DG_Datos.Columns.Add("Clm_FechaVencimiento", "Fecha V.");
                DG_Datos.Columns.Add("Clm_NCuota", "N°");
                DG_Datos.Columns.Add("Clm_Importe", "Imp.");
                DG_Datos.Columns.Add("Clm_Observaciones", "Obs.");

                //Configuraciones de las celdas
                DG_Datos.Columns["Clm_Importe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //DG_Datos.Columns["Clm_Importe"].DefaultCellStyle.ForeColor = Color.Red;

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Direccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Tel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_FechaVencimiento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_NCuota"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                decimal CreditoTotal = 0;
                foreach (Datos.Couta ItemCouta in C.ListaCouta)
                {
                    int TipoFac = Datos.Factura.GetFactura(ItemCouta.Id_Factura.ToString(), "", "", "", "", "", "").ListaFactura[0].Id_Factura_Tipo;
                    if (TipoFac == 1 || TipoFac == 2)
                    {
                        DG_Datos.Rows.Add();
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemCouta.Id_Couta;

                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Nombre"].Value = Datos.Tercero.GetTercero(ItemCouta.Factura.Id_Tercero.ToString(), "").ListaTercero[0].Razon_Social_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Direccion"].Value = Datos.Tercero.GetTercero(ItemCouta.Factura.Id_Tercero.ToString(), "").ListaTercero[0].Direccion_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Tel"].Value = Datos.Tercero.GetTercero(ItemCouta.Factura.Id_Tercero.ToString(), "").ListaTercero[0].Telefonos_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_FechaVencimiento"].Value = ItemCouta.Fecha_Vencimineto_Couta.ToString("dd/MM/yy");
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_NCuota"].Value = ItemCouta.Numero_Couta_Couta;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Importe"].Value = "$ " + (ItemCouta.Importe_Couta - ItemCouta.Asignacion_Cuota).ToString(Config.NumeroDecimales);
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemCouta.Observaciones_Couta;

                        CreditoTotal += ItemCouta.Importe_Couta;
                    }
                }

                Txt_CantidadRegistros.Text = C.ListaCouta.Count.ToString();
                Txt_CreditoTotal.Text = "$ " + CreditoTotal.ToString(Config.NumeroDecimales);
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                MyPrintDocument.Print();
            }
            Close();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = MyPrintDocument;
                printDialog1.ShowDialog();
                MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Papel_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.Document = MyPrintDocument;
                pageSetupDialog1.ShowDialog();
                MyPrintDocument.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics, false);
            if (more == true)
                e.HasMorePages = true;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool SetupThePrinting()
        {
            //PrintDialog MyPrintDialog = new PrintDialog();
            printDialog1.AllowCurrentPage = false;
            printDialog1.AllowPrintToFile = false;
            printDialog1.AllowSelection = false;
            printDialog1.AllowSomePages = false;
            printDialog1.PrintToFile = false;
            printDialog1.ShowHelp = false;
            printDialog1.ShowNetwork = false;

            if (printDialog1.ShowDialog() != DialogResult.OK)
            {
                return false;
            }

            MyPrintDocument.DocumentName = "Lista de Cuotas de este mes";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 20);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Datos, MyPrintDocument, false, true, "Cuotas a cobrar (" + DT_Desde.Value.ToString("dd/MM/yy") + " - " + DT_Hasta.Value.ToString("dd/MM/yy") + ")", new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmV = new MDI.FrmTercero(1);
            FrmV.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_NombreTercero.Text = "";
            id_TerceroTextBox.Text = "";
        }
    }
}
