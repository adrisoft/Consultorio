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
    public partial class FrmCaja : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        bool SegundaImpresion;
        DataGridViewPrinter MyDataGridViewPrinter;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmCaja()
        {
            InitializeComponent();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmCajaABM FrmCABM = new FrmCajaABM();
            FrmCABM.ShowDialog();
            Buscar();
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
                    Datos.Caja.Delete(DG_Datos.SelectedRows[0].Tag.ToString());
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
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
                Datos.Caja C = Datos.Caja.GetCajaRelacional("");

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Nombre", "Observación");
                DG_Datos.Columns.Add("Clm_Fecha", "Fecha");
                DG_Datos.Columns.Add("Clm_Referencia", "Referencia");
                DG_Datos.Columns.Add("Clm_Entrada", "Entrada");
                DG_Datos.Columns.Add("Clm_Salida", "Salida");
                DG_Datos.Columns.Add("Clm_Saldo", "Saldo");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Referencia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Entrada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Salida"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Saldo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                decimal TotalEntrada = 0;
                decimal TotalSalida = 0;
                decimal Saldo = 0;
                foreach (Datos.Caja ItemCaja in C.ListaCaja)
                {
                    switch (ItemCaja.Id_Caja_Tipo)
                    {
                        case 1:
                            Saldo += ItemCaja.Importe_Caja;
                            break;
                        case 2:
                            Saldo += ItemCaja.Importe_Caja;
                            break;
                        case 3:;
                            Saldo -= ItemCaja.Importe_Caja;
                            break;
                    }

                    if (DT_Desde.Value <= ItemCaja.Fecha_Caja && DT_Desde.Value <= ItemCaja.Fecha_Caja)
                    {
                        DG_Datos.Rows.Add();
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemCaja.Id_Caja;

                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Nombre"].Value = ItemCaja.Tag_Caja;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemCaja.Fecha_Caja;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Referencia"].Value = ItemCaja.Caja_tipo.Descripcion_Caja_Tipo;

                        switch (ItemCaja.Id_Caja_Tipo)
                        {
                            case 1:
                                TotalEntrada += ItemCaja.Importe_Caja;
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Entrada"].Value = ItemCaja.Importe_Caja.ToString(Config.NumeroDecimales);
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Salida"].Value = (0).ToString(Config.NumeroDecimales);
                                break;
                            case 2:
                                TotalEntrada += ItemCaja.Importe_Caja;
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Entrada"].Value = ItemCaja.Importe_Caja.ToString(Config.NumeroDecimales);
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Salida"].Value = (0).ToString(Config.NumeroDecimales);
                                break;
                            case 3:
                                TotalSalida += ItemCaja.Importe_Caja;
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Entrada"].Value = (0).ToString(Config.NumeroDecimales);
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Salida"].Value = ItemCaja.Importe_Caja.ToString(Config.NumeroDecimales);
                                break;
                        }
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Saldo"].Value = Saldo.ToString(Config.NumeroDecimales);
                    }
                }

                Txt_CantidadRegistros.Text = C.ListaCaja.Count.ToString();
                Txt_TotalEntrada.Text = "$ " + TotalEntrada.ToString(Config.NumeroDecimales);
                Txt_TotalSalida.Text = "$ " + TotalSalida.ToString(Config.NumeroDecimales);

                Txt_Total.Text = "$ " + (Saldo).ToString(Config.NumeroDecimales);

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

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            DT_Desde.Value = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            DT_Hasta.Value = DateTime.Now.AddDays(1);
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

            MyPrintDocument.DocumentName = "Caja";
            MyPrintDocument.PrinterSettings = printDialog1.PrinterSettings;
            MyPrintDocument.DefaultPageSettings = printDialog1.PrinterSettings.DefaultPageSettings;
            MyPrintDocument.DefaultPageSettings.Margins = new Margins(12, 12, 20, 20);

            MyDataGridViewPrinter = new DataGridViewPrinter(DG_Datos, MyPrintDocument, false, true, "Caja : (" + DT_Desde.Value.ToString("dd/MM/yy") + " - " + DT_Hasta.Value.ToString("dd/MM/yy") + ")", new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, true);

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
