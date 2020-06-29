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
    public partial class FrmOrdenPagoABM : Form
    {
        int _TipoTercero;
        public bool Abrir = true;
        bool SegundaImpresion = true;

        bool CerrarVentana = false;

        public Datos.Cheque_cartera CHECARTE = new Datos.Cheque_cartera();

        public FrmOrdenPagoABM(int TipoTercero)
        {
            InitializeComponent();
            _TipoTercero = TipoTercero;

            try
            {
                if (_TipoTercero == 1)
                {
                    numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                    Datos.Series.Desbloquear("RECIBOS");
                }
                else if (_TipoTercero == 2)
                {
                    numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                    Datos.Series.Desbloquear("RECIBOS");
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
                Abrir = false;
            }
        }

        public FrmOrdenPagoABM(string IdRecivoOrdenPago)
        {
            InitializeComponent();
            try
            {
                //Desabilito el boton para que no se pueda modificar
                Btn_Aceptar.Enabled = false;

                Datos.Factura F = Datos.Factura.GetFacturaRelacional(IdRecivoOrdenPago, "", "", "", "", "");


                id_TerceroTextBox.Text = F.ListaFactura[0].Id_Tercero.ToString();
                Txt_NombreTercero.Text = F.ListaFactura[0].Tercero.Razon_Social_Tercero;

                puesto_FacturaTextBox.Text = F.ListaFactura[0].Puesto_Factura.ToString("0000");
                numero_Comprobante_FacturaTextBox.Text = F.ListaFactura[0].Numero_Factura.ToString("00000000");

                Txt_Id.Text = IdRecivoOrdenPago;

                Datos.Factura_recibo_asignaciones FRA = Datos.Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", IdRecivoOrdenPago, "");

                foreach (Datos.Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
                {
                    Datos.Couta C = Datos.Couta.GetCoutaRelacional(itemFactura_recibo_asignaciones.Factura_Asignada_Factura_Recibo_Asignaciones.ToString(), "", "", "", "", "").ListaCouta[0];
                    DG_Facturas.Rows.Add();

                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Tag = MDI.FrmFactura.ValorReturn;

                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Detalle"].Value = Datos.Factura_tipo.GetFactura_tipo(C.Factura.Id_Factura_Tipo.ToString()).ListaFactura_tipo[0].Abreviacion_Factura_Tipo;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Remito"].Value = C.Factura.Clase_Factura + " " + C.Factura.Puesto_Factura.ToString("0000") + "-" + C.Factura.Numero_Factura.ToString("00000000");
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Numero"].Value = C.Numero_Couta_Couta;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_FechaDeVencimiento"].Value = C.Fecha_Vencimineto_Couta;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Importe1"].Value = C.Asignacion_Cuota;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Interes"].Value = C.Importe_Interes_Couta;
                    DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Observaciones"].Value = C.Observaciones_Couta;
                }

                Datos.Caja CAJA = Datos.Caja.GetCaja("", F.ListaFactura[0].Id_Factura.ToString());

                foreach (Datos.Caja itemCaja in CAJA.ListaCaja)
                {
                    DG_Efectivo.Rows.Add();
                    DG_Efectivo.Rows[DG_Efectivo.Rows.Count - 2].Cells["Clm_Importe"].Value = itemCaja.Importe_Caja;
                }

                CHECARTE.ListaCheque_cartera = new List<Datos.Cheque_cartera>();
                Datos.Cheque_cartera CC = Datos.Cheque_cartera.GetCheque_carteraRelacional("", F.ListaFactura[0].Id_Factura.ToString());
                foreach (Datos.Cheque_cartera itemCheque_cartera in CC.ListaCheque_cartera)
                {
                    CHECARTE.ListaCheque_cartera.Add(itemCheque_cartera);
                }

                CalcularAsignacionesFacturas();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_BuscarTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmV = new MDI.FrmTercero(_TipoTercero);
            FrmV.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroTextBox.Text = MDI.FrmTercero.ValorReturn;
                Txt_NombreTercero.Text = Datos.Tercero.GetTercero(id_TerceroTextBox.Text, "").ListaTercero[0].Razon_Social_Tercero;
            }

            DG_Facturas.Rows.Clear();
            CalcularAsignacionesFacturas();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void FrmOrdenPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CerrarVentana)
            {
                e.Cancel = !CerrarVentana;
            }
            else
            {
                if (_TipoTercero == 1)
                {
                    Datos.Series.Desbloquear("RECIBOS");
                }
                else if (_TipoTercero == 2)
                {
                    Datos.Series.Desbloquear("RECIBOS");
                }
            }
        }

        private void Btn_AgregarFactura_Click(object sender, EventArgs e)
        {
            if (id_TerceroTextBox.Text == "")
            {
                MessageBox.Show("Debe seleccionar un tercero.", "Selección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MDI.FrmCuotas Frm = new MDI.FrmCuotas(id_TerceroTextBox.Text);
                Frm.ShowDialog();
                if (MDI.FrmCuotas.ValorReturn != "")
                {
                    bool Existe = false;
                    foreach (DataGridViewRow Fila in DG_Facturas.Rows)
                    {
                        if (Fila.Tag.ToString() == MDI.FrmCuotas.ValorReturn.ToString())
                        {
                            Existe = true;
                        }
                    }

                    if (!Existe)
                    {
                        Datos.Couta C = Datos.Couta.GetCoutaRelacional(MDI.FrmCuotas.ValorReturn, "", "", "", "", "");
                        DG_Facturas.Rows.Add();

                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Tag = MDI.FrmCuotas.ValorReturn;

                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Detalle"].Value = Datos.Factura_tipo.GetFactura_tipo(C.ListaCouta[0].Factura.Id_Factura_Tipo.ToString()).ListaFactura_tipo[0].Abreviacion_Factura_Tipo;
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Remito"].Value = C.ListaCouta[0].Factura.Clase_Factura + " " + C.ListaCouta[0].Factura.Puesto_Factura.ToString("0000") + "-" + C.ListaCouta[0].Factura.Numero_Factura.ToString("00000000");
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Numero"].Value = C.ListaCouta[0].Numero_Couta_Couta;
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_FechaDeVencimiento"].Value = C.ListaCouta[0].Fecha_Vencimineto_Couta;
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Importe1"].Value = C.ListaCouta[0].Importe_Couta - C.ListaCouta[0].Asignacion_Cuota;
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Interes"].Value = "0,0000";
                        DG_Facturas.Rows[DG_Facturas.Rows.Count - 1].Cells["Clm_Observaciones"].Value = "";
                    }
                }
            }
            CalcularAsignacionesFacturas();
            DG_Facturas_CellEndEdit(sender, new DataGridViewCellEventArgs(0, 0));
        }

        private void Btn_QuitarFactura_Click(object sender, EventArgs e)
        {
            if (DG_Facturas.SelectedRows.Count > 0)
            {
                DG_Facturas.Rows.RemoveAt(DG_Facturas.SelectedRows[0].Index);
                CalcularAsignacionesFacturas();
            }
        }

        private void CalcularAsignacionesFacturas()
        {
            DG_ChequeTercero.Rows.Clear();
            foreach (Datos.Cheque_cartera itemCheque_cartera in CHECARTE.ListaCheque_cartera)
            {
                DG_ChequeTercero.Rows.Add();

                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Tag = itemCheque_cartera.Codigo_Cheque_Cartera;

                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_Codigo"].Value = itemCheque_cartera.Codigo_Cheque_Cartera;
                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_Ciudad"].Value = Datos.Localidad.GetLocalidad(itemCheque_cartera.Id_Localidad.ToString()).ListaLocalidad[0].Nombre_Localidad;
                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_Nombre"].Value = itemCheque_cartera.Nombre_Cheque_Cartera;
                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_FechaVencimiento"].Value = itemCheque_cartera.Fecha_Vencimiento_Cheque_Cartera;
                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_Importe2"].Value = itemCheque_cartera.Importe_Cheque_Cartera;
                DG_ChequeTercero.Rows[DG_ChequeTercero.Rows.Count - 1].Cells["Clm_Nombre2"].Value = itemCheque_cartera.Nombre_Librador_Cheque_Cartera;
            }

            decimal TotalAsignado = 0;
            foreach (DataGridViewRow Fila in DG_Facturas.Rows)
            {
                try
                {
                    TotalAsignado += Convert.ToDecimal(Fila.Cells["Clm_Importe1"].Value) + Convert.ToDecimal(Fila.Cells["Clm_Interes"].Value);
                    DG_Facturas.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    DG_Facturas.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            decimal TotalEfetivo = 0;
            foreach (DataGridViewRow Fila in DG_Efectivo.Rows)
            {
                try
                {
                    TotalEfetivo += Convert.ToDecimal(Fila.Cells["Clm_Importe"].Value);
                    DG_Efectivo.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    DG_Efectivo.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            decimal TotalChequeCartera = 0;
            foreach (DataGridViewRow Fila in DG_ChequeTercero.Rows)
            {
                try
                {
                    TotalChequeCartera += Convert.ToDecimal(Fila.Cells["Clm_Importe2"].Value);
                    DG_ChequeTercero.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.White;
                }
                catch
                {
                    DG_ChequeTercero.Rows[Fila.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }

            NUD_TotalAsignado.Value = TotalAsignado;
            NUD_Total.Value = TotalEfetivo + TotalChequeCartera;
        }

        private void DG_Facturas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            CalcularAsignacionesFacturas();
        }

        private void Btn_AgregarChequeTercero_Click(object sender, EventArgs e)
        {
            MDI.FrmCarteraChequesABM Frm = new MDI.FrmCarteraChequesABM();
            Frm.ShowDialog();
            if (MDI.FrmCarteraChequesABM.ValorReturn != null)
            {
                CHECARTE.ListaCheque_cartera.Add(MDI.FrmCarteraChequesABM.ValorReturn);

                CalcularAsignacionesFacturas();
            }
        }

        private void Btn_QuitarChequeTercero_Click(object sender, EventArgs e)
        {
            if (DG_ChequeTercero.SelectedRows.Count > 0)
            {
                for (int i = 0; i < CHECARTE.ListaCheque_cartera.Count; i++)
                {
                    if (CHECARTE.ListaCheque_cartera[i].Codigo_Cheque_Cartera == DG_ChequeTercero.SelectedRows[0].Tag.ToString())
                    {
                        CHECARTE.ListaCheque_cartera.RemoveAt(i);
                    }
                }

                CalcularAsignacionesFacturas();
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlValores();

                Datos.Factura F = new Datos.Factura();
                Datos.Couta Cuotas = new Datos.Couta();
                Cuotas.ListaCouta = new List<Datos.Couta>();

                decimal TotalInteres = 0;
                foreach (DataGridViewRow Fila in DG_Facturas.Rows)
                {
                    try
                    {
                        TotalInteres += Convert.ToDecimal(Fila.Cells["Clm_Interes"].Value);
                    }
                    catch
                    {
                        //none
                    }
                }

                Datos.Caja ObjCaja = new Datos.Caja();
                ObjCaja.ListaCaja = new List<Datos.Caja>();

                F.Id_Factura = (Txt_Id.Text == "") ? 0 : Convert.ToInt32(Txt_Id.Text);
                F.Id_Factura_Tipo = 3;
                F.Id_Tercero = Convert.ToInt32(id_TerceroTextBox.Text);

                F.Fecha_Factura = DateTime.Now;
                F.Fecha_Vencimiento_Factura = DateTime.Now;
                F.Puesto_Factura = Convert.ToInt32(puesto_FacturaTextBox.Text);
                F.Numero_Factura = Convert.ToInt32(numero_Comprobante_FacturaTextBox.Text);
                F.Clase_Factura = "X";
                F.Neto_Factura = 0;
                F.IVA_105_Factura = 0;
                F.IVA_21_Factura = 0;
                F.IVA_27_Factura = 0;
                F.Percepcion_Factura = 0;
                F.Exentos_Factura = 0;
                F.Otros_Factura = TotalInteres;
                F.Total_Factura = NUD_Total.Value - TotalInteres;
                F.Retencion_Factura = 0;
                F.Anulado_Factura = false;
                F.Observaciones_Factura = "";
                F.Interes_Factura = 0;

                foreach (DataGridViewRow Fila in DG_Facturas.Rows)
                {
                    Datos.Couta TEMP = Datos.Couta.GetCouta(Fila.Tag.ToString(), "", "0");
                    TEMP.ListaCouta[0].Pagado_Couta = ((TEMP.ListaCouta[0].Importe_Couta - TEMP.ListaCouta[0].Asignacion_Cuota) - Convert.ToDecimal(Fila.Cells["Clm_Importe1"].Value) <= 0) ? true : false;
                    TEMP.ListaCouta[0].Fecha_Pago_Couta = DateTime.Now;
                    TEMP.ListaCouta[0].Importe_Interes_Couta = Convert.ToDecimal(Fila.Cells["Clm_Interes"].Value);
                    TEMP.ListaCouta[0].Asignacion_Cuota += Convert.ToDecimal(Fila.Cells["Clm_Importe1"].Value);
                    TEMP.ListaCouta[0].Observaciones_Couta = Fila.Cells["Clm_Observaciones"].Value.ToString();
                    Cuotas.ListaCouta.Add(TEMP.ListaCouta[0]);
                }

                foreach (DataGridViewRow Fila in DG_Efectivo.Rows)
                {
                    Datos.Caja TEMP = new Datos.Caja();
                    TEMP.Id_Caja_Tipo = 1;
                    TEMP.Fecha_Caja = DateTime.Now;
                    TEMP.Importe_Caja = Convert.ToDecimal(Fila.Cells["Clm_Importe"].Value);
                    TEMP.Tag_Caja = Txt_NombreTercero.Text;

                    if (TEMP.Importe_Caja != 0 || TEMP.Importe_Caja != 0)
                    {
                        ObjCaja.ListaCaja.Add(TEMP);
                    }
                }

                if (Txt_Id.Text == "")
                {
                    if (_TipoTercero == 1)
                    {
                        numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                        Datos.Series.Desbloquear("RECIBOS");
                    }
                    else if (_TipoTercero == 2)
                    {
                        numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                        Datos.Series.Desbloquear("RECIBOS");
                    }

                    string TipoComprobanteAnterior = "";
                    if (_TipoTercero == 1)
                    {
                        TipoComprobanteAnterior = "RECIBOS";
                    }
                    else if (_TipoTercero == 2)
                    {
                        TipoComprobanteAnterior = "RECIBOS";
                    }

                    MDI.FrmDialogoFactura FDF = new FrmDialogoFactura(TipoComprobanteAnterior, "X", puesto_FacturaTextBox.Text, numero_Comprobante_FacturaTextBox.Text);
                    if (FDF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (_TipoTercero == 1)
                        {
                            numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                            Datos.Series.Desbloquear("RECIBOS");
                        }
                        else if (_TipoTercero == 2)
                        {
                            numero_Comprobante_FacturaTextBox.Text = Datos.Series.Bloquear("RECIBOS").ToString("00000000");
                            Datos.Series.Desbloquear("RECIBOS");
                        }

                        if (Chk_ImprimirComprobante.Checked)
                        {
                            ImprimirDocumento.Print();
                        }

                        Datos.Factura.AddRecibo_OrdenPago(F, Cuotas, CHECARTE, ObjCaja);

                        if (_TipoTercero == 1)
                        {
                            Datos.Series.DesbloquearSumar("RECIBOS");
                        }
                        else if (_TipoTercero == 2)
                        {
                            Datos.Series.DesbloquearSumar("RECIBOS");
                        }
                        MessageBox.Show("Se ha agregado un nuevo registro.");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    //Datos.Factura.SetRecibo_OrdenPago(F, Facturas, ObjChequePropio, ObjDeposito, ObjTransferencia, ObjCheque_Cartera, ObjCaja, ObjTarjeta);
                    //MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                CerrarVentana = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmOrdenPagoABM_Load(object sender, EventArgs e)
        {
            if (CHECARTE.ListaCheque_cartera == null)
            {
                CHECARTE.ListaCheque_cartera = new List<Datos.Cheque_cartera>();
            }
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
            if (id_TerceroTextBox.Text == "")
            {
                Btn_BuscarTercero_Click(sender, e);
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

        private void ImprimirDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            Font Arial12 = new Font("Arial", 12, FontStyle.Bold);
            Font Arial10 = new Font("Arial", 10);
            Font Arial8 = new Font("Arial", 8);
            int MitadPagina = e.MarginBounds.Width / 2;
            int Y_Reglon = 50;
            float TEMP = 0;
            string Texto = "";

            Datos.Empresa Emp = Datos.Empresa.GetEmpresaRelacional("1").ListaEmpresa[0];
            Datos.Tercero Ter = Datos.Tercero.GetTerceroRelacional(id_TerceroTextBox.Text, "", "").ListaTercero[0];

            Texto = Emp.Razon_Social_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = Emp.Direccion_Empresa + " - " + Emp.Localidad.Nombre_Localidad + " - " + Datos.Provincia.GetProvincia(Emp.Localidad.Id_Provincia.ToString()).ListaProvincia[0].Nombre_Provincia;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Tel.: " + Emp.Telefonos_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Email: " + Emp.Email_Empresa;
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "CUIT.: " + Emp.CUIT_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "I.V.A.: " + Emp.Tercero_iva.Descripcion_Tercero_IVA; ;
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Ing. Brutos: " + Emp.Ingresos_Brutos_Empresa;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Email: " + Emp.Inicio_Actividades_Empresa.ToString(Config.FechaMySQL2);
            TEMP = 170;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


            Y_Reglon += 20;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);


            Y_Reglon += 30;
            Texto = "-X-";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial12).Width / 2);
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            if (SegundaImpresion)
            {
                Texto = "RECIBO ORIGINAL";
            }
            else
            {
                Texto = "RECIBO DUPLICADO";
            }
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial12).Width;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 24;
            Texto = "Nro. : " + puesto_FacturaTextBox.Text + "-" + numero_Comprobante_FacturaTextBox.Text;
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Fecha : " + DateTime.Now.ToString(Config.FechaMySQL2);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "R. Social : " + Ter.Razon_Social_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Dirección : " + Ter.Direccion_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "CUIT: " + Ter.CUIT_Tercero;
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Localidad : " + Ter.Localidad.Nombre_Localidad + " (" + Ter.Localidad.Codigo_Postal_Localidad + ")";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Cons. Final";
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = "Email : " + Ter.Email_Tercero;
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = "Tel. : " + Ter.Telefonos_Tercero;
            TEMP = 400;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "DETALLE DEL PAGO";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 10;

            foreach (DataGridViewRow Fila in DG_Efectivo.Rows)
            {
                if (Convert.ToDecimal(Fila.Cells["Clm_Importe"].Value) != 0)
                {
                    Y_Reglon += 15;
                    Texto = DateTime.Now.ToString(Config.FechaMySQL2);
                    TEMP = 22;
                    e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                    Y_Reglon += 0;
                    Texto = "Efectivo";
                    TEMP = 150;
                    e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);


                    Y_Reglon += 0;
                    Texto = "$";
                    TEMP = 640;
                    e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                    Y_Reglon += 0;
                    Texto = Convert.ToDecimal(Fila.Cells["Clm_Importe"].Value).ToString(Config.NumeroDecimales);
                    TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                    e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);
                }
            }

            foreach (Datos.Cheque_cartera ItemCheque_cartera in CHECARTE.ListaCheque_cartera)
            {
                Y_Reglon += 15;
                Texto = DateTime.Now.ToString(Config.FechaMySQL2);
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = ItemCheque_cartera.Nombre_Cheque_Cartera;
                TEMP = 150;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = ItemCheque_cartera.Codigo_Cheque_Cartera;
                TEMP = 300;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = Datos.Localidad.GetLocalidad(ItemCheque_cartera.Id_Localidad.ToString()).ListaLocalidad[0].Nombre_Localidad;
                TEMP = 400;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = ItemCheque_cartera.Fecha_Vencimiento_Cheque_Cartera.ToString(Config.FechaMySQL2);
                TEMP = 500;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "$";
                TEMP = 640;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = ItemCheque_cartera.Importe_Cheque_Cartera.ToString(Config.NumeroDecimales);
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);
            }

            Y_Reglon += 315;
            Texto = "TOTAL $";
            TEMP = 600;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = NUD_Total.Value.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "DETALLE DE LAS ASIGNACIONES";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial12, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 10;

            foreach (DataGridViewRow Fila in DG_Facturas.Rows)
            {
                Y_Reglon += 15;
                Texto = Fila.Cells["Clm_Detalle"].Value.ToString() + " " + Fila.Cells["Clm_Remito"].Value.ToString() + " - CUOTA N° " + Fila.Cells["Clm_Numero"].Value.ToString();
                TEMP = 22;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = "$";
                TEMP = 250;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = Convert.ToDecimal(Fila.Cells["Clm_Importe1"].Value).ToString(Config.NumeroDecimales);
                TEMP = (MitadPagina * 2) - 480 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

                Y_Reglon += 0;
                Texto = DateTime.Now.ToString(Config.FechaMySQL2);
                TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
                e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);
            }

            decimal TotalInteres = 0;
            foreach (DataGridViewRow Fila in DG_Facturas.Rows)
            {
                TotalInteres += Convert.ToDecimal(Fila.Cells["Clm_Interes"].Value);
            }

            decimal TotalSinInteres = 0;
            foreach (DataGridViewRow Fila in DG_Facturas.Rows)
            {
                TotalSinInteres += Convert.ToDecimal(Fila.Cells["Clm_Importe1"].Value);
            }

            Y_Reglon += 145;
            Texto = "TOTAL INTERESES   $";
            TEMP = 550;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = TotalInteres.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "TOTAL                        $";
            TEMP = 550;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 0;
            Texto = TotalSinInteres.ToString(Config.NumeroDecimales);
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial10).Width;
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "______________________________________________________________________________________________";
            TEMP = MitadPagina - (e.Graphics.MeasureString(Texto, Arial10).Width / 2);
            e.Graphics.DrawString(Texto, Arial10, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 30;
            Texto = "Recibimos de la persona antes mencionada la suma de PESOS:";
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = Common.ConvertirToLetra(NUD_Total.Value);
            TEMP = 22;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 20;
            Texto = ". . . . . . . . . . . . . . . . . . . . . . . . . . . .";
            TEMP = 550;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            Y_Reglon += 15;
            Texto = "Por : " + Emp.Razon_Social_Empresa;
            TEMP = (MitadPagina * 2) - 40 - e.Graphics.MeasureString(Texto, Arial8).Width;
            e.Graphics.DrawString(Texto, Arial8, Brushes.Black, TEMP, Y_Reglon);

            if (SegundaImpresion)
            {
                e.HasMorePages = true;
                SegundaImpresion = false;
            }
            else
            {
                e.HasMorePages = false;
                SegundaImpresion = true;
            }
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

        private void Btn_VistaPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                FrmVistaPrevia VP = new FrmVistaPrevia();
                VP.VistaPrevia.Document = ImprimirDocumento;
                VP.VistaPrevia.Columns = 2;
                VP.ShowDialog();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void NUD_TotalAsignado_ValueChanged(object sender, EventArgs e)
        {
            DG_Efectivo.Rows.Clear();
            DG_Efectivo.Rows.Add();
            DG_Efectivo.Rows[DG_Efectivo.Rows.Count - 2].Cells[0].Value = NUD_TotalAsignado.Value;
        }

        private void Txt_NombreTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
