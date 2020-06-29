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
    public partial class FrmGenerarHistoriaClinica : Form
    {
        int paginas = 0;
        string IdConsulta_ = "";

        public FrmGenerarHistoriaClinica(string IdConsulta)
        {
            InitializeComponent();
            IdConsulta_ = IdConsulta;
        }

        private void FrmGenerarHistoriaClinica_Load(object sender, EventArgs e)
        {
            ImprimirDocumento.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(10, 10, 10, 10);
            foreach (System.Drawing.Printing.PaperSize itemPaperSize in ImprimirDocumento.PrinterSettings.PaperSizes)
            {
                if (itemPaperSize.PaperName == "A4")
                {
                    ImprimirDocumento.DefaultPageSettings.PaperSize = itemPaperSize;
                    pageSetupDialog1.PageSettings.PaperSize = itemPaperSize;
                }
            }
            printDialog1.Document = ImprimirDocumento;
            ArmarTXT();
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

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirDocumento.Print();
        }

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {

                FrmVistaPrevia VP = new FrmVistaPrevia();
                VP.VistaPrevia.Document = ImprimirDocumento;
                VP.ShowDialog();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font Arial16 = new Font("Arial", 16, FontStyle.Bold);
            Font Arial12 = new Font("Arial", 12, FontStyle.Bold);
            Font Arial12Normal = new Font("Arial", 12);
            Font CourierNew12 = new Font("Courier New", 12);
            Font CourierNew12Bold = new Font("Courier New", 12, FontStyle.Bold);
            Font Arial10 = new Font("Arial", 10);
            Font Arial8 = new Font("Arial", 8);
            int MitadPagina = e.MarginBounds.Width / 2;
            int Y_Reglon = 50;
            float TEMP = 0;
            string Texto = "";

            int linesPerPage = (int)(e.MarginBounds.Height / CourierNew12.GetHeight(e.Graphics)) - 10;

            int LimiteMax = (paginas + linesPerPage > motivo_ConsultaTextBox.Lines.Length) ? linesPerPage - (paginas + linesPerPage - motivo_ConsultaTextBox.Lines.Length) : linesPerPage;

            for (int i = paginas; i < paginas + LimiteMax; i++)
            {
                if (motivo_ConsultaTextBox.Lines[i].Length > 6)
                {
                    if (motivo_ConsultaTextBox.Lines[i].Substring(0, 6) == "{bold}")
                    {
                        Y_Reglon += 20;
                        Texto = motivo_ConsultaTextBox.Lines[i].Substring(6);
                        TEMP = 22;
                        e.Graphics.DrawString(Texto, CourierNew12Bold, Brushes.Black, TEMP, Y_Reglon);
                    }
                    else
                    {
                        Y_Reglon += 20;
                        Texto = motivo_ConsultaTextBox.Lines[i];
                        TEMP = 22;
                        e.Graphics.DrawString(Texto, CourierNew12, Brushes.Black, TEMP, Y_Reglon);
                    }
                }
                else
                {
                    Y_Reglon += 20;
                    Texto = motivo_ConsultaTextBox.Lines[i];
                    TEMP = 22;
                    e.Graphics.DrawString(Texto, CourierNew12, Brushes.Black, TEMP, Y_Reglon);
                }
            }

            paginas += linesPerPage;

            if (paginas < motivo_ConsultaTextBox.Lines.Length)
            {
                e.HasMorePages = true;
            }
            else
            {
                paginas = 0;
            }
        }

        private void Btn_Ajustar_Click(object sender, EventArgs e)
        {
            bool LlamarDeNuevo = false;

            StringBuilder SB = new StringBuilder();
            foreach (string item in motivo_ConsultaTextBox.Lines)
            {
                string TEMP = "";
                if (item.Length > 71)
                {
                    int indexEspacio = item.LastIndexOf(" ", 70, 70) + 1;
                    TEMP = item.Substring(0, indexEspacio) + "\r\n" + item.Substring(indexEspacio) + "\r\n";
                    if (item.Length > 72)
                    {
                        LlamarDeNuevo = true;
                    }
                }
                else
                {
                    TEMP = item + "\r\n";
                }
                SB.Append(TEMP);
            }
            motivo_ConsultaTextBox.Text = SB.ToString().TrimEnd();

            if (LlamarDeNuevo)
            {
                Btn_Ajustar_Click(sender, e);
            }
        }

        private void ArmarTXT()
        {
            Datos.Consulta C = Datos.Consulta.GetConsultaRelacional(IdConsulta_, "").ListaConsulta[0];
            Datos.Consulta_estudio CE = Datos.Consulta_estudio.GetConsulta_estudioRelacional("", IdConsulta_);
            Datos.Consulta_enfermedad CENFER = Datos.Consulta_enfermedad.GetConsulta_enfermedadRelacional("", IdConsulta_);
            Datos.Consulta_tratamiento CT = Datos.Consulta_tratamiento.GetConsulta_tratamientoRelacional("", IdConsulta_);
            Datos.Consulta_medicacion CM = Datos.Consulta_medicacion.GetConsulta_medicacionRelacional("", IdConsulta_);
            Datos.Consulta_visita CV = Datos.Consulta_visita.GetConsulta_visita("", IdConsulta_);

            motivo_ConsultaTextBox.Text = "";
            motivo_ConsultaTextBox.Text += "Paciente : " + C.Tercero.Razon_Social_Tercero;
            motivo_ConsultaTextBox.Text += "\r\n";
            motivo_ConsultaTextBox.Text += "Fecha : " + C.Fecha_Consulta.ToLongDateString();
            motivo_ConsultaTextBox.Text += "\r\n";
            motivo_ConsultaTextBox.Text += "______________________________________________";
            motivo_ConsultaTextBox.Text += "\r\n";
            motivo_ConsultaTextBox.Text += "\r\n";


            if (C.Motivo_Consulta != "")
            {
                motivo_ConsultaTextBox.Text += "{bold}Motivo:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += C.Motivo_Consulta;
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (C.Analisis_Visual_Consulta != "")
            {
                motivo_ConsultaTextBox.Text += "{bold}Analisis visual:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += C.Analisis_Visual_Consulta;
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (C.Evolucion_Consulta != "")
            {
                motivo_ConsultaTextBox.Text += "{bold}Evolución:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += C.Evolucion_Consulta;
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (C.Observaciones_Consulta != "")
            {
                motivo_ConsultaTextBox.Text += "{bold}Observaciones:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += C.Observaciones_Consulta;
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (CE.ListaConsulta_estudio.Count != 0)
            {
                motivo_ConsultaTextBox.Text += "{bold}Estudios:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";

                foreach (Datos.Consulta_estudio item in CE.ListaConsulta_estudio)
                {
                    motivo_ConsultaTextBox.Text += item.Estudio.Descripcion_Estudio;
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (CENFER.ListaConsulta_enfermedad.Count != 0)
            {
                motivo_ConsultaTextBox.Text += "{bold}Diagnosticos:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";

                foreach (Datos.Consulta_enfermedad item in CENFER.ListaConsulta_enfermedad)
                {
                    motivo_ConsultaTextBox.Text += item.Enfermedad.Descripcion_Enfermedad;
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (CT.ListaConsulta_tratamiento.Count != 0)
            {
                motivo_ConsultaTextBox.Text += "{bold}Tratamientos:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";

                foreach (Datos.Consulta_tratamiento item in CT.ListaConsulta_tratamiento)
                {
                    motivo_ConsultaTextBox.Text += item.Tratamiento.Descripcion_Tratamiento;
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (CM.ListaConsulta_medicacion.Count != 0)
            {
                motivo_ConsultaTextBox.Text += "{bold}Medicación:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";

                foreach (Datos.Consulta_medicacion item in CM.ListaConsulta_medicacion)
                {
                    motivo_ConsultaTextBox.Text += item.Medicacion.Nombre_Comercial_Medicacion.Trim() + " (" + item.Medicacion.Presentacion_Medicacion.Trim() + ")";
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (CV.ListaConsulta_visita.Count != 0)
            {
                motivo_ConsultaTextBox.Text += "{bold}Visitas:";
                motivo_ConsultaTextBox.Text += "\r\n";
                motivo_ConsultaTextBox.Text += "\r\n";

                foreach (Datos.Consulta_visita item in CV.ListaConsulta_visita)
                {
                    motivo_ConsultaTextBox.Text += item.Fecha_Consulta_Visita + ((item.Observaciones_Consulta_Visita != "") ? " | " + item.Observaciones_Consulta_Visita : "");
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
                motivo_ConsultaTextBox.Text += "\r\n";
            }

            if (C.Alta_Consulta)
            {
                if (C.Alta_Medica_Consulta!= "")
                {
                    motivo_ConsultaTextBox.Text += "{bold}Descripción del alta médica:";
                    motivo_ConsultaTextBox.Text += "\r\n";
                    motivo_ConsultaTextBox.Text += "\r\n";

                    motivo_ConsultaTextBox.Text += "Fecha de alta : " + C.Fecha_Alta_Consulta.ToLongDateString();
                    motivo_ConsultaTextBox.Text += "\r\n";
                    motivo_ConsultaTextBox.Text += "\r\n";

                    motivo_ConsultaTextBox.Text += C.Alta_Medica_Consulta;
                    motivo_ConsultaTextBox.Text += "\r\n";
                    motivo_ConsultaTextBox.Text += "\r\n";
                }
            }
        }
    }
}
