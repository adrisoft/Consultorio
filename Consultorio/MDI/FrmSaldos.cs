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
    public partial class FrmSaldos : Form
    {
        bool SegundaImpresion;
        DataGridViewPrinter MyDataGridViewPrinter;

        int _TipoTercero;
        public FrmSaldos(int TipoTercero)
        {
            InitializeComponent();
            _TipoTercero = TipoTercero;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Datos.Tercero T = Datos.Tercero.GetTercero("", _TipoTercero.ToString());

            DG_Saldo.Rows.Clear();
            decimal Total = 0;
            foreach (Datos.Tercero itemTercero in T.ListaTercero)
            {
                bool MostrarFila = false;
                decimal SALDO = Common.SaldoTercero(itemTercero.Id_Tercero.ToString());

                if (SALDO < 0) //Acreedor
                {
                    if (Chk_Acreedores.Checked)
                    {
                        MostrarFila = true;
                    }
                }

                if (SALDO > 0) //Deudor
                {
                    if (Chk_Deudores.Checked)
                    {
                        MostrarFila = true;
                    }
                }

                if (SALDO == 0) //Deudor
                {
                    if (Chk_SaldoEn0.Checked)
                    {
                        MostrarFila = true;
                    }
                }

                if (MostrarFila)
                {
                    DG_Saldo.Rows.Add();
                    DG_Saldo.Rows[DG_Saldo.Rows.Count - 1].Tag = itemTercero.Id_Tercero;

                    DG_Saldo.Rows[DG_Saldo.Rows.Count - 1].Cells["ClmNombre"].Value = itemTercero.Razon_Social_Tercero;
                    DG_Saldo.Rows[DG_Saldo.Rows.Count - 1].Cells["ClmDireccion"].Value = itemTercero.Direccion_Tercero;
                    DG_Saldo.Rows[DG_Saldo.Rows.Count - 1].Cells["ClmTelefonos"].Value = itemTercero.Telefonos_Tercero;
                    DG_Saldo.Rows[DG_Saldo.Rows.Count - 1].Cells["ClmSaldo"].Value = SALDO.ToString(Config.NumeroDecimales);
                }

                Total += SALDO;
            }

            label1.Text = "Total: $ " + Total.ToString(Config.NumeroDecimales);
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSaldos_Load(object sender, EventArgs e)
        {
            DG_Saldo.Font = new Font(Config.NombreFont, Config.TamañoFont);
            DG_Saldo.Columns["ClmNombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Saldo.Columns["ClmDireccion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Saldo.Columns["ClmTelefonos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Saldo.Columns["ClmSaldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            Btn_Buscar_Click(sender, e);
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics,false);
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

            MyPrintDocument.DocumentName = "Saldos";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 20);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Saldo, MyPrintDocument, false, true, "Saldos de " + Datos.Tercero_tipo.GetTercero_tipo(_TipoTercero.ToString()).ListaTercero_tipo[0].Descripcion_Tercero_Tipo, new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

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

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (SetupThePrinting())
            {
                MyPrintDocument.Print();
            }
            Close();
        }
    }
}
