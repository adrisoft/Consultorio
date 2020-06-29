using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace Consultorio
{
    public static class Common
    {
        /// <summary>
        /// Comprueba que exista un archivo
        /// </summary>
        /// <returns>Devuelve verdadero si existe el archivo</returns>
        public static bool ExisteArchivoCnn()
        {
            if (File.Exists(Application.StartupPath + @"\Conección.cnn"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Arma la coneccion desde el archivo
        /// </summary>
        /// <returns>Cadena de coneccion armada</returns>
        public static MySqlConnectionStringBuilder RecuperarCnn()
        {
            try
            {           //se abre el fiche Coneccion.cnn encriptado con la siguiente clave
                string Clave = "adrian12";
                DESCryptoServiceProvider EncriptacionServicio = new DESCryptoServiceProvider();
                EncriptacionServicio.Key = Encoding.Default.GetBytes(Clave.Substring(0, 8));
                EncriptacionServicio.IV = Encoding.Default.GetBytes(Clave.Substring(0, 8));
                FileStream FS = new FileStream(Application.StartupPath + @"\Conección.cnn", FileMode.Open, FileAccess.Read);
                CryptoStream CS = new CryptoStream(FS, EncriptacionServicio.CreateDecryptor(), CryptoStreamMode.Read);
                StreamReader SR = new StreamReader(CS);
                //Esta cadena ya esta desencriptada
                string CadenaCompleta = SR.ReadToEnd();
                string CadenaConeccion = CadenaCompleta.Split(Convert.ToChar("|"))[0];
                Config.RutaImagenes = CadenaCompleta.Split(Convert.ToChar("|"))[1];
                SR.Close();
                CS.Close();
                FS.Close();

                return new MySqlConnectionStringBuilder(CadenaConeccion);
            }
            catch (Exception Error)
            {
                throw new Exception("Ha ocurrido un error al intentar abrir los datos de la conexión al servidor.\r\nDetalles:\r\n" + Error.Message);
            }

        }

        /// <summary>
        /// Para saber el saldo de un tercero
        /// </summary>
        /// <param name="IdTercero">ID del tercero</param>
        /// <returns>Saldo del tercero</returns>
        public static decimal SaldoTercero(string IdTercero)
        {
            Datos.Factura F = Datos.Factura.GetFacturaRelacional("", "", IdTercero, "", "", "");

            decimal Saldo = 0;
            foreach (Datos.Factura itemFactura in F.ListaFactura)
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
            return Saldo;
        }

        /// <summary>
        /// Convierte un valor numero y palabras
        /// </summary>
        /// <param name="Valor">Valor a conevertir</param>
        /// <returns>Cadena con la frase del valor numerico</returns>
        public static string ConvertirToLetra(decimal Valor)
        {
            return Conv.enletras(Valor.ToString());
        }

        /// <summary>
        /// Suma el porcentaje de iva a un valor
        /// </summary>
        /// <param name="Valor">Valor a sumar</param>
        /// <param name="IVA">Porcentaje de IVA</param>
        /// <returns>Valor más el porcentaje.</returns>
        public static decimal SumarIVA(decimal Valor, decimal IVA)
        {
            return (Valor * IVA / 100) + Valor;
        }

        /// <summary>
        /// Devuelve el nombre del numero de mes espesificado
        /// </summary>
        /// <param name="NumeroMes">Numero del mes</param>
        /// <returns>Nombre del mes</returns>
        public static string NombreMes(int NumeroMes)
        {
            switch (NumeroMes)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "Febrero";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                case 7:
                    return "Julio";
                    break;
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Septiembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;
                default:
                    return "";
                    break;
            }
        }
    }

    public static class Conv
    {
        public static string enletras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;
            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }
            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));
            if (decimales > 0)
            {
                dec = " PESOS CON " + decimales.ToString() + " CENTAVOS.";
            }
            res = toText(Convert.ToDecimal(entero)) + dec;
            return res;
        }

        public static string toText(decimal value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }
            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }
    }

    /// <summary>
    /// Imprime un datagridview
    /// </summary>
    public class DataGridViewPrinter
    {
        // The DataGridView Control which will be printed
        private DataGridView TheDataGridView;
        // The PrintDocument to be used for printing
        private PrintDocument ThePrintDocument;
        // Determine if the report will be
        // printed in the Top-Center of the page
        private bool IsCenterOnPage;
        // Determine if the page contain title text
        private bool IsWithTitle;
        // The title text to be printed
        // in each page (if IsWithTitle is set to true)
        private string TheTitleText;
        // The font to be used with the title
        // text (if IsWithTitle is set to true)
        private Font TheTitleFont;
        // The color to be used with the title
        // text (if IsWithTitle is set to true)
        private Color TheTitleColor;
        // Determine if paging is used
        private bool IsWithPaging;

        // A static parameter that keep track
        // on which Row (in the DataGridView control)
        // that should be printed
        static int CurrentRow;

        static int PageNumber;

        private int PageWidth;
        private int PageHeight;
        private int LeftMargin;
        private int TopMargin;
        private int RightMargin;
        private int BottomMargin;

        // A parameter that keep track
        // on the y coordinate of the page,
        // so the next object to be printed
        // will start from this y coordinate
        private float CurrentY;

        private float RowHeaderHeight;
        private List<float> RowsHeight;
        private List<float> ColumnsWidth;
        private float TheDataGridViewWidth;

        // Maintain a generic list to hold start/stop
        // points for the column printing
        // This will be used for wrapping
        // in situations where the DataGridView will not
        // fit on a single page
        private List<int[]> mColumnPoints;
        private List<float> mColumnPointsWidth;
        private int mColumnPoint;

        // The class constructor
        public DataGridViewPrinter(DataGridView aDataGridView,
            PrintDocument aPrintDocument,
            bool CenterOnPage, bool WithTitle,
            string aTitleText, Font aTitleFont,
            Color aTitleColor, bool WithPaging)
        {
            TheDataGridView = aDataGridView;
            ThePrintDocument = aPrintDocument;
            IsCenterOnPage = CenterOnPage;
            IsWithTitle = WithTitle;
            TheTitleText = aTitleText;
            TheTitleFont = aTitleFont;
            TheTitleColor = aTitleColor;
            IsWithPaging = WithPaging;

            PageNumber = 0;

            RowsHeight = new List<float>();
            ColumnsWidth = new List<float>();

            mColumnPoints = new List<int[]>();
            mColumnPointsWidth = new List<float>();

            // Claculating the PageWidth and the PageHeight
            if (!ThePrintDocument.DefaultPageSettings.Landscape)
            {
                PageWidth =
                  ThePrintDocument.DefaultPageSettings.PaperSize.Width;
                PageHeight =
                  ThePrintDocument.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                PageHeight =
                  ThePrintDocument.DefaultPageSettings.PaperSize.Width;
                PageWidth =
                  ThePrintDocument.DefaultPageSettings.PaperSize.Height;
            }

            // Claculating the page margins
            LeftMargin = ThePrintDocument.DefaultPageSettings.Margins.Left;
            TopMargin = ThePrintDocument.DefaultPageSettings.Margins.Top;
            RightMargin = ThePrintDocument.DefaultPageSettings.Margins.Right;
            BottomMargin = ThePrintDocument.DefaultPageSettings.Margins.Bottom;

            // First, the current row to be printed
            // is the first row in the DataGridView control
            CurrentRow = 0;
        }

        // The function that calculate
        // the height of each row (including the header row),
        // the width of each column (according
        // to the longest text in all its cells including
        // the header cell), and the whole DataGridView width
        private void Calculate(Graphics g)
        {
            if (PageNumber == 0)
            // Just calculate once
            {
                SizeF tmpSize = new SizeF();
                Font tmpFont;
                float tmpWidth;

                TheDataGridViewWidth = 0;
                for (int i = 0; i < TheDataGridView.Columns.Count; i++)
                {
                    tmpFont = TheDataGridView.ColumnHeadersDefaultCellStyle.Font;
                    if (tmpFont == null)
                        // If there is no special HeaderFont style,
                        // then use the default DataGridView font style
                        tmpFont = TheDataGridView.DefaultCellStyle.Font;

                    tmpSize = g.MeasureString(
                              TheDataGridView.Columns[i].HeaderText,
                              tmpFont);
                    tmpWidth = tmpSize.Width;
                    RowHeaderHeight = tmpSize.Height;

                    for (int j = 0; j < TheDataGridView.Rows.Count; j++)
                    {
                        tmpFont = TheDataGridView.Rows[j].DefaultCellStyle.Font;
                        if (tmpFont == null)
                            // If the there is no special font style of the
                            // CurrentRow, then use the default one associated
                            // with the DataGridView control
                            tmpFont = TheDataGridView.DefaultCellStyle.Font;

                        tmpSize = g.MeasureString("Anything", tmpFont);
                        RowsHeight.Add(tmpSize.Height);

                        tmpSize =
                            g.MeasureString(
                            TheDataGridView.Rows[j].Cells[i].
                                     EditedFormattedValue.ToString(),
                            tmpFont);
                        if (tmpSize.Width > tmpWidth)
                            tmpWidth = tmpSize.Width;
                    }
                    if (TheDataGridView.Columns[i].Visible)
                        TheDataGridViewWidth += tmpWidth;
                    ColumnsWidth.Add(tmpWidth);
                }

                // Define the start/stop column points
                // based on the page width and
                // the DataGridView Width
                // We will use this to determine
                // the columns which are drawn on each page
                // and how wrapping will be handled
                // By default, the wrapping will occurr
                // such that the maximum number of
                // columns for a page will be determine
                int k;

                int mStartPoint = 0;
                for (k = 0; k < TheDataGridView.Columns.Count; k++)
                    if (TheDataGridView.Columns[k].Visible)
                    {
                        mStartPoint = k;
                        break;
                    }

                int mEndPoint = TheDataGridView.Columns.Count;
                for (k = TheDataGridView.Columns.Count - 1; k >= 0; k--)
                    if (TheDataGridView.Columns[k].Visible)
                    {
                        mEndPoint = k + 1;
                        break;
                    }

                float mTempWidth = TheDataGridViewWidth;
                float mTempPrintArea = (float)PageWidth - (float)LeftMargin -
                    (float)RightMargin;

                // We only care about handling
                // where the total datagridview width is bigger
                // then the print area
                if (TheDataGridViewWidth > mTempPrintArea)
                {
                    mTempWidth = 0.0F;
                    for (k = 0; k < TheDataGridView.Columns.Count; k++)
                    {
                        if (TheDataGridView.Columns[k].Visible)
                        {
                            mTempWidth += ColumnsWidth[k];
                            // If the width is bigger
                            // than the page area, then define a new
                            // column print range
                            if (mTempWidth > mTempPrintArea)
                            {
                                mTempWidth -= ColumnsWidth[k];
                                mColumnPoints.Add(new int[] { mStartPoint, mEndPoint });
                                mColumnPointsWidth.Add(mTempWidth);
                                mStartPoint = k;
                                mTempWidth = ColumnsWidth[k];
                            }
                        }
                        // Our end point is actually
                        // one index above the current index
                        mEndPoint = k + 1;
                    }
                }
                // Add the last set of columns
                mColumnPoints.Add(new int[] { mStartPoint, mEndPoint });
                mColumnPointsWidth.Add(mTempWidth);
                mColumnPoint = 0;
            }
        }

        // The funtion that print the title, page number, and the header row
        private void DrawHeader(Graphics g, bool EnumerarLibriIVA)
        {
            CurrentY = (float)TopMargin;

            // Printing the page number (if isWithPaging is set to true)
            if (IsWithPaging)
            {
                PageNumber++;
                string PageString = "";

                if (EnumerarLibriIVA)
                {
                    PageString = Datos.Series.Bloquear("IVA").ToString();
                    Datos.Series.DesbloquearSumar("IVA");
                }
                else
                {
                    PageString = "Página " + PageNumber.ToString();
                }

                StringFormat PageStringFormat = new StringFormat();
                PageStringFormat.Trimming = StringTrimming.Word;
                PageStringFormat.FormatFlags = StringFormatFlags.NoWrap |
                    StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                PageStringFormat.Alignment = StringAlignment.Far;

                Font PageStringFont = new Font("Arial", 10, FontStyle.Regular,
                    GraphicsUnit.Point);

                RectangleF PageStringRectangle =
                   new RectangleF((float)LeftMargin, CurrentY,
                   (float)PageWidth - (float)RightMargin - (float)LeftMargin - 50,
                   g.MeasureString(PageString, PageStringFont).Height);

                g.DrawString(PageString, PageStringFont,
                   new SolidBrush(Color.Black),
                   PageStringRectangle, PageStringFormat);

                CurrentY += g.MeasureString(PageString,
                                     PageStringFont).Height;
            }

            // Printing the title (if IsWithTitle is set to true)
            if (IsWithTitle)
            {
                StringFormat TitleFormat = new StringFormat();
                TitleFormat.Trimming = StringTrimming.Word;
                TitleFormat.FormatFlags = StringFormatFlags.NoWrap |
                    StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                if (IsCenterOnPage)
                    TitleFormat.Alignment = StringAlignment.Center;
                else
                    TitleFormat.Alignment = StringAlignment.Near;

                RectangleF TitleRectangle =
                    new RectangleF((float)LeftMargin, CurrentY,
                    (float)PageWidth - (float)RightMargin - (float)LeftMargin,
                    g.MeasureString(TheTitleText, TheTitleFont).Height);

                g.DrawString(TheTitleText, TheTitleFont,
                    new SolidBrush(TheTitleColor),
                    TitleRectangle, TitleFormat);

                CurrentY += g.MeasureString(TheTitleText, TheTitleFont).Height;
            }

            // Calculating the starting x coordinate
            // that the printing process will start from
            float CurrentX = (float)LeftMargin;
            if (IsCenterOnPage)
                CurrentX += (((float)PageWidth - (float)RightMargin -
                  (float)LeftMargin) - mColumnPointsWidth[mColumnPoint]) / 2.0F;

            // Setting the HeaderFore style
            Color HeaderForeColor =
                  TheDataGridView.ColumnHeadersDefaultCellStyle.ForeColor;
            if (HeaderForeColor.IsEmpty)
                // If there is no special HeaderFore style,
                // then use the default DataGridView style
                HeaderForeColor = TheDataGridView.DefaultCellStyle.ForeColor;
            SolidBrush HeaderForeBrush = new SolidBrush(HeaderForeColor);

            // Setting the HeaderBack style
            Color HeaderBackColor =
                  TheDataGridView.ColumnHeadersDefaultCellStyle.BackColor;
            if (HeaderBackColor.IsEmpty)
                // If there is no special HeaderBack style,
                // then use the default DataGridView style
                HeaderBackColor = TheDataGridView.DefaultCellStyle.BackColor;
            SolidBrush HeaderBackBrush = new SolidBrush(HeaderBackColor);

            // Setting the LinePen that will
            // be used to draw lines and rectangles
            // (derived from the GridColor property
            // of the DataGridView control)
            Pen TheLinePen = new Pen(TheDataGridView.GridColor, 1);

            // Setting the HeaderFont style
            Font HeaderFont = TheDataGridView.ColumnHeadersDefaultCellStyle.Font;
            if (HeaderFont == null)
                // If there is no special HeaderFont style,
                // then use the default DataGridView font style
                HeaderFont = TheDataGridView.DefaultCellStyle.Font;

            // Calculating and drawing the HeaderBounds        
            RectangleF HeaderBounds = new RectangleF(CurrentX, CurrentY,
                mColumnPointsWidth[mColumnPoint], RowHeaderHeight);
            g.FillRectangle(HeaderBackBrush, HeaderBounds);

            // Setting the format that will be
            // used to print each cell of the header row
            StringFormat CellFormat = new StringFormat();
            CellFormat.Trimming = StringTrimming.Word;
            CellFormat.FormatFlags = StringFormatFlags.NoWrap |
               StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            // Printing each visible cell of the header row
            RectangleF CellBounds;
            float ColumnWidth;
            for (int i = (int)mColumnPoints[mColumnPoint].GetValue(0);
                i < (int)mColumnPoints[mColumnPoint].GetValue(1); i++)
            {
                // If the column is not visible then ignore this iteration
                if (!TheDataGridView.Columns[i].Visible) continue;

                ColumnWidth = ColumnsWidth[i];

                // Check the CurrentCell alignment
                // and apply it to the CellFormat
                if (TheDataGridView.ColumnHeadersDefaultCellStyle.
                           Alignment.ToString().Contains("Right"))
                    CellFormat.Alignment = StringAlignment.Far;
                else if (TheDataGridView.ColumnHeadersDefaultCellStyle.
                         Alignment.ToString().Contains("Center"))
                    CellFormat.Alignment = StringAlignment.Center;
                else
                    CellFormat.Alignment = StringAlignment.Near;

                CellBounds = new RectangleF(CurrentX, CurrentY,
                             ColumnWidth, RowHeaderHeight);

                // Printing the cell text
                g.DrawString(TheDataGridView.Columns[i].HeaderText,
                             HeaderFont, HeaderForeBrush,
                   CellBounds, CellFormat);

                // Drawing the cell bounds
                // Draw the cell border only if the HeaderBorderStyle is not None
                if (TheDataGridView.RowHeadersBorderStyle !=
                                DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(TheLinePen, CurrentX, CurrentY, ColumnWidth,
                        RowHeaderHeight);

                CurrentX += ColumnWidth;
            }

            CurrentY += RowHeaderHeight;
        }

        // The function that print a bunch of rows that fit in one page
        // When it returns true, meaning that
        // there are more rows still not printed,
        // so another PagePrint action is required
        // When it returns false, meaning that all rows are printed
        // (the CureentRow parameter reaches
        // the last row of the DataGridView control)
        // and no further PagePrint action is required
        private bool DrawRows(Graphics g)
        {
            // Setting the LinePen that will be used to draw lines and rectangles
            // (derived from the GridColor property of the DataGridView control)
            Pen TheLinePen = new Pen(TheDataGridView.GridColor, 1);

            // The style paramters that will be used to print each cell
            Font RowFont;
            Color RowForeColor;
            Color RowBackColor;
            SolidBrush RowForeBrush;
            SolidBrush RowBackBrush;
            SolidBrush RowAlternatingBackBrush;

            // Setting the format that will be used to print each cell
            StringFormat CellFormat = new StringFormat();
            CellFormat.Trimming = StringTrimming.Word;
            CellFormat.FormatFlags = StringFormatFlags.NoWrap |
                                     StringFormatFlags.LineLimit;

            // Printing each visible cell
            RectangleF RowBounds;
            float CurrentX;
            float ColumnWidth;
            while (CurrentRow < TheDataGridView.Rows.Count)
            {
                // Print the cells of the CurrentRow only if that row is visible
                if (TheDataGridView.Rows[CurrentRow].Visible)
                {
                    // Setting the row font style
                    RowFont = TheDataGridView.Rows[CurrentRow].DefaultCellStyle.Font;
                    // If the there is no special font style of the CurrentRow,
                    // then use the default one associated with the DataGridView control
                    if (RowFont == null)
                        RowFont = TheDataGridView.DefaultCellStyle.Font;

                    // Setting the RowFore style
                    RowForeColor =
                      TheDataGridView.Rows[CurrentRow].DefaultCellStyle.ForeColor;
                    // If the there is no special RowFore style of the CurrentRow,
                    // then use the default one associated with the DataGridView control
                    if (RowForeColor.IsEmpty)
                        RowForeColor = TheDataGridView.DefaultCellStyle.ForeColor;
                    RowForeBrush = new SolidBrush(RowForeColor);

                    // Setting the RowBack (for even rows) and the RowAlternatingBack
                    // (for odd rows) styles
                    RowBackColor =
                      TheDataGridView.Rows[CurrentRow].DefaultCellStyle.BackColor;
                    // If the there is no special RowBack style of the CurrentRow,
                    // then use the default one associated with the DataGridView control
                    if (RowBackColor.IsEmpty)
                    {
                        RowBackBrush = new SolidBrush(
                              TheDataGridView.DefaultCellStyle.BackColor);
                        RowAlternatingBackBrush = new
                            SolidBrush(
                            TheDataGridView.AlternatingRowsDefaultCellStyle.BackColor);
                    }
                    // If the there is a special RowBack style of the CurrentRow,
                    // then use it for both the RowBack and the RowAlternatingBack styles
                    else
                    {
                        RowBackBrush = new SolidBrush(RowBackColor);
                        RowAlternatingBackBrush = new SolidBrush(RowBackColor);
                    }

                    // Calculating the starting x coordinate
                    // that the printing process will
                    // start from
                    CurrentX = (float)LeftMargin;
                    if (IsCenterOnPage)
                        CurrentX += (((float)PageWidth - (float)RightMargin -
                            (float)LeftMargin) -
                            mColumnPointsWidth[mColumnPoint]) / 2.0F;

                    // Calculating the entire CurrentRow bounds                
                    RowBounds = new RectangleF(CurrentX, CurrentY,
                        mColumnPointsWidth[mColumnPoint], RowsHeight[CurrentRow]);

                    // Filling the back of the CurrentRow
                    if (CurrentRow % 2 == 0)
                        g.FillRectangle(RowBackBrush, RowBounds);
                    else
                        g.FillRectangle(RowAlternatingBackBrush, RowBounds);

                    // Printing each visible cell of the CurrentRow                
                    for (int CurrentCell = (int)mColumnPoints[mColumnPoint].GetValue(0);
                        CurrentCell < (int)mColumnPoints[mColumnPoint].GetValue(1);
                        CurrentCell++)
                    {
                        // If the cell is belong to invisible
                        // column, then ignore this iteration
                        if (!TheDataGridView.Columns[CurrentCell].Visible) continue;

                        // Check the CurrentCell alignment
                        // and apply it to the CellFormat
                        if (TheDataGridView.Columns[CurrentCell].DefaultCellStyle.
                                Alignment.ToString().Contains("Right"))
                            CellFormat.Alignment = StringAlignment.Far;
                        else if (TheDataGridView.Columns[CurrentCell].DefaultCellStyle.
                                Alignment.ToString().Contains("Center"))
                            CellFormat.Alignment = StringAlignment.Center;
                        else
                            CellFormat.Alignment = StringAlignment.Near;

                        ColumnWidth = ColumnsWidth[CurrentCell];
                        RectangleF CellBounds = new RectangleF(CurrentX, CurrentY,
                            ColumnWidth, RowsHeight[CurrentRow]);

                        // Printing the cell text
                        g.DrawString(
                          TheDataGridView.Rows[CurrentRow].Cells[CurrentCell].
                          EditedFormattedValue.ToString(), RowFont, RowForeBrush,
                          CellBounds, CellFormat);

                        // Drawing the cell bounds
                        // Draw the cell border only
                        // if the CellBorderStyle is not None
                        if (TheDataGridView.CellBorderStyle !=
                                    DataGridViewCellBorderStyle.None)
                            g.DrawRectangle(TheLinePen, CurrentX, CurrentY,
                                  ColumnWidth, RowsHeight[CurrentRow]);

                        CurrentX += ColumnWidth;
                    }
                    CurrentY += RowsHeight[CurrentRow];

                    // Checking if the CurrentY is exceeds the page boundries
                    // If so then exit the function and returning true meaning another
                    // PagePrint action is required
                    if ((int)CurrentY > (PageHeight - TopMargin - BottomMargin))
                    {
                        CurrentRow++;
                        return true;
                    }
                }
                CurrentRow++;
            }

            CurrentRow = 0;
            // Continue to print the next group of columns
            mColumnPoint++;

            if (mColumnPoint == mColumnPoints.Count)
            // Which means all columns are printed
            {
                mColumnPoint = 0;
                return false;
            }
            else
                return true;
        }

        // The method that calls all other functions
        public bool DrawDataGridView(Graphics g, bool EnumerarLibriIVA)
        {
            try
            {
                Calculate(g);
                DrawHeader(g, EnumerarLibriIVA);
                bool bContinue = DrawRows(g);
                return bContinue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la operación: " + ex.Message.ToString(),
                    Application.ProductName + " - Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
