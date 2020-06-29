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
    public partial class FrmLibroIVA : Form
    {
        bool SegundaImpresion;
        DataGridViewPrinter MyDataGridViewPrinter;

        public FrmLibroIVA()
        {
            InitializeComponent();
        }

        private void FrmLibroIVA_Load(object sender, EventArgs e)
        {
            Txt_Periodo.Text = DateTime.Now.ToString("MM-yyyy");
            Buscar();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Buscar()
        {
            try
            {
                Datos.Factura F = new Datos.Factura();

                //Borro todo las filas y columnas anteriores
                DG_Facturas.Columns.Clear();
                DG_Facturas.Rows.Clear();

                DG_Facturas.Columns.Add("Clm_Fecha", "Fecha");
                DG_Facturas.Columns.Add("Clm_DetalleMov", "Det");
                DG_Facturas.Columns.Add("Clm_Tipo", "Tipo");
                DG_Facturas.Columns.Add("Clm_NUmero", "Número");
                DG_Facturas.Columns.Add("Clm_Nombre", "Nombre");
                DG_Facturas.Columns.Add("Clm_CUIT", "C.U.I.T.");
                DG_Facturas.Columns.Add("Clm_Importe", "Neto");
                DG_Facturas.Columns.Add("Clm_IVA21", "I.V.A 21%");
                DG_Facturas.Columns.Add("Clm_IVA105", "I.V.A 10,5%");
                DG_Facturas.Columns.Add("Clm_Percepcion", "Percepción");
                DG_Facturas.Columns.Add("Clm_Exentos", "Exentos");
                DG_Facturas.Columns.Add("Clm_Total", "Total");


                DG_Facturas.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Facturas.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_DetalleMov"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Tipo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_NUmero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_CUIT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_IVA21"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_IVA105"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Percepcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Exentos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Facturas.Columns["Clm_Total"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                F = Datos.Factura.GetFacturaRelacional("", "1", "", "", Txt_Periodo.Text, "");

                //Agrego las filas
                DG_Facturas.Rows.Clear();
                decimal TotalNetoGravado = 0;
                decimal TotalIVA21 = 0;
                decimal TotalIVA105 = 0;
                decimal TotalIVARetencioPercepcion = 0;
                decimal TotalPercepcion = 0;
                decimal TotalIVA27 = 0;
                decimal TotalExentos = 0;
                decimal TotalImportesInternos = 0;
                foreach (Datos.Factura ItemFactura in F.ListaFactura)
                {
                    DG_Facturas.Rows.Add();
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Tag = ItemFactura.Id_Factura;


                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemFactura.Fecha_Factura.ToString(Config.FechaMySQL2);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_DetalleMov"].Value = ItemFactura.Factura_tipo.Abreviacion_Factura_Tipo;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Tipo"].Value = ItemFactura.Clase_Factura;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_NUmero"].Value = ItemFactura.Puesto_Factura.ToString("0000") + "-" + ItemFactura.Numero_Factura.ToString("00000000");
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Nombre"].Value = ItemFactura.Tercero.Razon_Social_Tercero;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_CUIT"].Value = ItemFactura.Tercero.CUIT_Tercero;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Importe"].Value = ItemFactura.Neto_Factura.ToString(Config.NumeroDecimales);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_IVA21"].Value = ItemFactura.IVA_21_Factura.ToString(Config.NumeroDecimales);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_IVA105"].Value = ItemFactura.IVA_105_Factura.ToString(Config.NumeroDecimales);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Percepcion"].Value = ItemFactura.Percepcion_Factura.ToString(Config.NumeroDecimales);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Exentos"].Value = ItemFactura.Exentos_Factura.ToString(Config.NumeroDecimales);
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Total"].Value = ItemFactura.Total_Factura.ToString(Config.NumeroDecimales);


                    TotalNetoGravado += ItemFactura.Neto_Factura;
                    TotalIVA21 += ItemFactura.IVA_21_Factura;
                    TotalIVA105 += ItemFactura.IVA_105_Factura;
                    TotalIVARetencioPercepcion += ItemFactura.Retencion_Factura + ItemFactura.Percepcion_Factura;
                    TotalPercepcion += ItemFactura.Percepcion_Factura;
                    TotalIVA27 += ItemFactura.IVA_27_Factura;
                    TotalExentos += ItemFactura.Exentos_Factura;
                    TotalImportesInternos += ItemFactura.Otros_Factura;
                }

                Txt_Totales.Text = "";

                Txt_Totales.Text += "Total neto gravado: \t\t $ " + TotalNetoGravado.ToString(Config.NumeroDecimales) + "\r\n";
                Txt_Totales.Text += "Total I.V.A. 21%: \t\t $ " + TotalIVA21.ToString(Config.NumeroDecimales) + "\r\n";
                Txt_Totales.Text += "Total I.V.A. 10,5%: \t\t $ " + TotalIVA105.ToString(Config.NumeroDecimales) + "\r\n";
                Txt_Totales.Text += "Total percepción: \t\t $ " + TotalPercepcion.ToString(Config.NumeroDecimales) + "\r\n";
                Txt_Totales.Text += "Total exentos: \t\t $ " + TotalExentos.ToString(Config.NumeroDecimales) + "\r\n";
                Txt_Totales.Text += "\t\t\t------------------" + "\r\n";
                Txt_Totales.Text += "Total: \t\t\t $ " + (TotalNetoGravado + TotalIVA21 + TotalIVA105 + TotalPercepcion + TotalExentos).ToString(Config.NumeroDecimales);

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                MyPrintDocument.Print();
            }
            Close();
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics, true);
            if (more == true)
                e.HasMorePages = true;
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

            MyPrintDocument.DocumentName = "Libro de I.V.A. - Ventas";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 20);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Facturas, MyPrintDocument, false, true, "Libro de I.V.A. - Ventas - Periodo: " + Txt_Periodo.Text , new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

            return true;
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

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                PrintPreviewDialog MyPrintPreviewDialog = new PrintPreviewDialog();
                MyPrintPreviewDialog.Document = MyPrintDocument;
                MyPrintPreviewDialog.ShowDialog();
            }
        }
    }
}
