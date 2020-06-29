using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Consultorio.MDI
{
    public partial class FrmConsultas : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";

        private bool CancelarBusqueda = false;
        private bool DetenerBusqueda = false;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            FrmConsultasABM FrmCABM = new FrmConsultasABM();
            FrmCABM.ShowDialog();
            Buscar();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Btn_Buscar.Enabled = false;
            Btn_Detener.Enabled = true;
            Buscar();
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsultasABM FrmCABM = new FrmConsultasABM(DG_Datos.SelectedRows[0].Tag.ToString());
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
                Datos.Consulta C = Datos.Consulta.GetConsultaRelacional(Txt_Id.Text, id_TerceroTextBox.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_Paciente", "Paciente");
                DG_Datos.Columns.Add("Clm_Fecha", "Fecha");
                DG_Datos.Columns.Add("Clm_Motivo", "Motivo");
                DG_Datos.Columns.Add("Clm_Observaciones", "Observaciones");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_Paciente"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Motivo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Observaciones"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                Progreso.Minimum = 0;
                Progreso.Maximum = C.ListaConsulta.Count;
                Progreso.Value = 0;
                LblPorcentaje.Text = "0 %";
                Txt_CantidadRegistros.Text = C.ListaConsulta.Count.ToString();

                CancelarBusqueda = false;
                //Agrego las filas
                foreach (Datos.Consulta ItemConsulta in C.ListaConsulta)
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
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemConsulta.Id_Consulta;

                    if (!ItemConsulta.Alta_Consulta)
                    {
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.MediumAquamarine;
                    }

                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Paciente"].Value = ItemConsulta.Tercero.Razon_Social_Tercero;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemConsulta.Fecha_Consulta;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Motivo"].Value = ItemConsulta.Motivo_Consulta;
                    DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemConsulta.Observaciones_Consulta;
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
                    Datos.Consulta_imagenes CI = Datos.Consulta_imagenes.GetConsulta_imagenes("", DG_Datos.SelectedRows[0].Tag.ToString());

                    Datos.Consulta.Delete_ConsultaCompleta(DG_Datos.SelectedRows[0].Tag.ToString());

                    foreach (Datos.Consulta_imagenes itemConsulta_imagenes in CI.ListaConsulta_imagenes)
                    {
                        FileInfo FI = new FileInfo(Config.RutaImagenes + itemConsulta_imagenes.Imagen_Consulta_Imagenes);
                        if (FI.Exists)
                        {
                            FI.Delete();
                        }
                    }

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

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            ValorReturn = "";
            //Buscar();
            Btn_Detener.Enabled = false;
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

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmC = new MDI.FrmTercero(1);
            FrmC.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_TerceroTextBox.Text = "";
            Txt_NombreTercero.Text = "";
        }

        private void FrmConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelarBusqueda = true;
        }

        private void Btn_Detener_Click(object sender, EventArgs e)
        {
            DetenerBusqueda = true;
            Btn_Detener.Enabled = false;
            Btn_Buscar.Enabled = true;
        }

        private void Btn_Opciones_Click(object sender, EventArgs e)
        {
            try
            {
                printDialog1.Document = ImprimirDocumento;
                printDialog1.ShowDialog();
                ImprimirDocumento.PrinterSettings = printDialog1.PrinterSettings;
                ImprimirDocumento.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
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
                pageSetupDialog1.Document = ImprimirDocumento;
                pageSetupDialog1.ShowDialog();
                ImprimirDocumento.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (id_TerceroTextBox.Text != "")
            {
                ImprimirDocumento.Print();
            }
            else
            {
                MessageBox.Show("Debe fitrar la lista con un paciente solamente.", "Imprimir historial clínico", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font Arial16 = new Font("Arial", 16, FontStyle.Bold);
            Font Arial12 = new Font("Arial", 12, FontStyle.Bold);
            Font Arial10 = new Font("Arial", 10);
            Font Arial8 = new Font("Arial", 8);
            int MitadPagina = e.MarginBounds.Width / 2;
            int Y_Reglon = 50;
            float TEMP = 0;
            string Texto = "";


            Texto = "Normal";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            for (int i = 0; i < 500; i++)
            {

                Y_Reglon += 20;
                Texto = "Normal Abajo " + i.ToString();
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 20;
                Texto = "Mitad " + i.ToString();
                TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 24;
                Texto = "Izquierda " + i.ToString();
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
                e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);
                e.HasMorePages = true;
            }
            e.HasMorePages = false;
        }

        private void Btn_ImpHC_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                MDI.FrmGenerarHistoriaClinica GHC = new FrmGenerarHistoriaClinica(DG_Datos.SelectedRows[0].Tag.ToString());
                GHC.ShowDialog();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }
    }
}
