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
    public partial class FrmResumenCuenta : Form
    {
        bool SegundaImpresion;
        DataGridViewPrinter MyDataGridViewPrinter;

        int _TipoFactura;
        public FrmResumenCuenta(bool EsProveedor)
        {
            InitializeComponent();
            if (EsProveedor)
            {
                this.Text = "Cuenta corriente de Pacientes";
                label1.Text = "Paciente:";
                _TipoFactura = 1;
            }
            else
            {
                this.Text = "Cuenta corriente de Clientes";
                label1.Text = "Cliente:";
                _TipoFactura = 2;
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            DT_Desde.Value = DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day - 1, 0, 0, 0));
            Btn_BuscarTercero_Click(sender, e);
            Btn_Buscar_Click(sender, e);

            DG_Cuenta.Font = new Font(Config.NombreFont, Config.TamañoFont);
            DG_Cuenta.Columns["ClmFecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Cuenta.Columns["ClmReferencia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Cuenta.Columns["ClmNumeros"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Cuenta.Columns["ClmDebito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Cuenta.Columns["ClmCredito"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DG_Cuenta.Columns["ClmSaldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            ControlValores();

            Datos.Factura F = Datos.Factura.GetFacturaRelacional("", "", id_TerceroTextBox.Text, "", "", "");

            DG_Cuenta.Rows.Clear();
            decimal Saldo = 0;
            foreach (Datos.Factura itemFactura in F.ListaFactura)
            {
                if (DT_Desde.Value <= itemFactura.Fecha_Factura && DT_Desde.Value <= itemFactura.Fecha_Factura)
                {
                    DG_Cuenta.Rows.Add();
                    DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Tag = itemFactura.Id_Factura;

                    DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmFecha"].Value = itemFactura.Fecha_Factura;
                    DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmReferencia"].Value = itemFactura.Factura_tipo.Descripcion_Factura_Tipo;
                    DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmNumeros"].Value = itemFactura.Clase_Factura + " " + itemFactura.Puesto_Factura.ToString("0000") + "-" + itemFactura.Numero_Factura.ToString("00000000");

                    switch (itemFactura.Id_Factura_Tipo)
                    {
                        case 1:
                            if (!itemFactura.Pagado_Factura)
                            {
                                Saldo += itemFactura.Total_Factura;
                                //DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                                DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmDebito"].Value = "$ " + (0).ToString(Config.NumeroDecimales);
                                DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmCredito"].Value = "$ " + itemFactura.Total_Factura.ToString(Config.NumeroDecimales);
                            }
                            else
                            {
                                DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmDebito"].Value = "$ " + (0).ToString(Config.NumeroDecimales);
                                DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmCredito"].Value = "$ " + itemFactura.Total_Factura.ToString(Config.NumeroDecimales);
                            }
                            break;
                        case 2:
                            Saldo += itemFactura.Total_Factura;
                            if (!itemFactura.Facturado_Factura)
                            {
                                DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SkyBlue;
                            }
                            DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmDebito"].Value = "$ " + (0).ToString(Config.NumeroDecimales);
                            DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmCredito"].Value = "$ " + itemFactura.Total_Factura.ToString(Config.NumeroDecimales);
                            break;
                        case 3:
                            Saldo -= itemFactura.Total_Factura;
                            DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmDebito"].Value = "$ " + itemFactura.Total_Factura.ToString(Config.NumeroDecimales);
                            DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmCredito"].Value = "$ " + (0).ToString(Config.NumeroDecimales);
                            break;
                    }
                    DG_Cuenta.Rows[DG_Cuenta.Rows.Count - 1].Cells["ClmSaldo"].Value = "$ " + (Saldo).ToString(Config.NumeroDecimales);
                }
                else
                {
                    switch (itemFactura.Id_Factura_Tipo)
                    {
                        case 1:
                            if (!itemFactura.Pagado_Factura)
                            {
                                Saldo += itemFactura.Total_Factura;
                            }
                            break;
                        case 2:
                            Saldo += itemFactura.Total_Factura;
                            break;
                        case 3:
                            Saldo -= itemFactura.Total_Factura;
                            break;
                    }
                }
            }

            Txt_SaldoTotal.Text = "$ " + Saldo.ToString(Config.NumeroDecimales);
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            int TipoTercero;
            if (_TipoFactura == 1)
            {
                TipoTercero = 1;
            }
            else
            {
                TipoTercero = 2;
            }
            MDI.FrmTercero FrmV = new MDI.FrmTercero(TipoTercero);
            FrmV.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text,"").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ControlValores()
        {
            if (id_TerceroTextBox.Text == "")
            {
                ProvError.SetError(Txt_NombreTercero, "Falta elegir a un tercero.");
            }
            else
            {
                ProvError.SetError(Txt_NombreTercero, "");
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool more = MyDataGridViewPrinter.DrawDataGridView(e.Graphics, false);
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

            MyPrintDocument.DocumentName = "Resumen de cuenta";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 20);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Cuenta, MyPrintDocument, false, true, "Resumen de cuenta de " + Txt_NombreTercero.Text + " (" + DateTime.Now.ToString("dd/MM/yy") + ")", new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

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
