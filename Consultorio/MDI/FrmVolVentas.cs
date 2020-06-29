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
    public partial class FrmVolVentas : Form
    {
        public FrmVolVentas()
        {
            InitializeComponent();
        }

        private void FrmVolVentas_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\RepBanlance.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            //COMPRA-VENTA----------------------------------------------------------------------------
            List<Datos.DatosReportes> DR = new List<Datos.DatosReportes>();

            Datos.Factura FACTURAS = Datos.Factura.GetFactura("", "", "", "", "", "", DateTime.Now.Subtract(new TimeSpan(DateTime.Now.Day - 1,0,0,0)).ToString());

            Datos.DatosReportes VENTAS = new Datos.DatosReportes();
            VENTAS.Descripcion = "VENTAS";
            VENTAS.ValorDecimal = 0;


            Datos.DatosReportes COMPRAS = new Datos.DatosReportes();
            COMPRAS.Descripcion = "COMPRAS";
            COMPRAS.ValorDecimal = 0;

            int ArtComprados = 0;
            int ArtVendidos = 0;
            foreach (Datos.Factura itemListaFactura in FACTURAS.ListaFactura)
            {
                    int CantidadTem = 0;
                    Datos.Factura_detalle DF = Datos.Factura_detalle.GetFactura_detalle("", itemListaFactura.Id_Factura.ToString());

                    foreach (Datos.Factura_detalle itemFactura_detalle in DF.ListaFactura_detalle)
                    {
                        CantidadTem += itemFactura_detalle.Cantidad_Factura_Detalle;
                    }

                    if (itemListaFactura.Id_Factura_Tipo == 1)
                    {
                        COMPRAS.ValorDecimal += itemListaFactura.Total_Factura;
                        ArtComprados += CantidadTem;
                    }

                    if (itemListaFactura.Id_Factura_Tipo == 2)
                    {
                        VENTAS.ValorDecimal += itemListaFactura.Total_Factura;
                        ArtVendidos += CantidadTem;
                    }
            }


            DR.Add(VENTAS);
            DR.Add(COMPRAS);

            Microsoft.Reporting.WinForms.ReportDataSource RDS = new Microsoft.Reporting.WinForms.ReportDataSource("DATOS1", DR);
            reportViewer1.LocalReport.DataSources.Add(RDS);

            //GRAFICO LINEAL----------------------------------------------------------------------------
            List<Datos.DatosReportes> DR1 = new List<Datos.DatosReportes>();

            for (int i = 7; i >= 0; i--)
            {
                DateTime dt = new DateTime(DateTime.Now.Year, DateTime.Now.Month - i, 1);
                string Fecha = dt.ToString();

                Datos.DatosReportes TEMP = new Datos.DatosReportes();
                TEMP.Descripcion = Common.NombreMes(dt.Month).ToString();
                TEMP.ValorDecimal = GananciaXmes(Fecha);
                DR1.Add(TEMP);
            }

            Microsoft.Reporting.WinForms.ReportDataSource RDS1 = new Microsoft.Reporting.WinForms.ReportDataSource("DATOS2", DR1);
            reportViewer1.LocalReport.DataSources.Add(RDS1);

            //PARAMETROS-------------------------------------------------------------------------------
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("VarVenta","$ " + VENTAS.ValorDecimal.ToString(Config.NumeroDecimales)));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("VarCompra", "$ " + COMPRAS.ValorDecimal.ToString(Config.NumeroDecimales)));
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("VarResultado", "$ " + (VENTAS.ValorDecimal - COMPRAS.ValorDecimal).ToString(Config.NumeroDecimales)));

            reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }

        private decimal GananciaXmes(string Fecha)
        {
            Datos.Factura FACTURAS = Datos.Factura.GetFactura("", "", "", "", "", "", Fecha);

            decimal COMPRA = 0;
            decimal VENTA = 0;
            foreach (Datos.Factura itemListaFactura in FACTURAS.ListaFactura)
            {
                if (itemListaFactura.Id_Factura_Tipo == 1)
                {
                    COMPRA += itemListaFactura.Total_Factura;
                }

                if (itemListaFactura.Id_Factura_Tipo == 2)
                {
                    VENTA += itemListaFactura.Total_Factura;
                }
            }

            return VENTA - COMPRA;
        }
    }
}
