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
    public partial class FrmFactura : Form
    {
        /// <summary>
        /// Valor que devuelve este formulario
        /// </summary>
        public static string ValorReturn = "";
        int _TipoFactura;

        private int NumeroFilaUltimaSeleccion = 0;

        public FrmFactura(int TipoFactura)
        {
            InitializeComponent();
            try { 
                this.Text = Datos.Factura_tipo.GetFactura_tipo(TipoFactura.ToString()).ListaFactura_tipo[0].Descripcion_Factura_Tipo;
            }
            catch
            {
                this.Text = "";
            }
    _TipoFactura = TipoFactura;
            if (TipoFactura == 3)
            {
                Btn_Anular.Enabled = false;
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (_TipoFactura == 3)
            {
                FrmOrdenPagoABM FrmFABM = new FrmOrdenPagoABM(1);
                FrmFABM.ShowDialog();
                Buscar();
            }
            else
            {
                FrmFacturaABM FrmFABM = new FrmFacturaABM(_TipoFactura);
                FrmFABM.ShowDialog();
                Buscar();
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.DialogResult Resultado;
                if (_TipoFactura == 3)
                {
                    FrmOrdenPagoABM FrmOP = new FrmOrdenPagoABM(DG_Datos.SelectedRows[0].Tag.ToString());
                    Resultado = FrmOP.ShowDialog();
                }
                else
                {
                    FrmFacturaABM FrmFABM = new FrmFacturaABM(DG_Datos.SelectedRows[0].Tag.ToString(), _TipoFactura);
                    Resultado = FrmFABM.ShowDialog();
                }
                if (Resultado == System.Windows.Forms.DialogResult.OK)
                {
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
                Datos.Factura F = Datos.Factura.GetFacturaRelacional(Txt_Id.Text, _TipoFactura.ToString(), "", "", "", razon_social_textBox1.Text);

                //Agrego las columnas de la regilla de datos.
                DG_Datos.Columns.Add("Clm_RSocial", "Razón social");
                DG_Datos.Columns.Add("Clm_Dirección", "Dirección");
                DG_Datos.Columns.Add("Clm_Teléfonos", "Teléfonos");
                DG_Datos.Columns.Add("Clm_Fecha", "Fecha");
                DG_Datos.Columns.Add("Clm_CPN", "Clase Puesto-Número");
                DG_Datos.Columns.Add("Clm_Importe", "Importe");
                DG_Datos.Columns.Add("Clm_ImporteInteres", "Interés");

                DG_Datos.Font = new Font(Config.NombreFont, Config.TamañoFont);
                DG_Datos.Columns["Clm_RSocial"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Dirección"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Teléfonos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_CPN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_Importe"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                DG_Datos.Columns["Clm_ImporteInteres"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                //Agrego las filas
                foreach (Datos.Factura ItemFactura in F.ListaFactura)
                {
                    bool Mostrar = true;
                    if (Chk_Pendientes.Checked)
                    {
                        if (Datos.Couta.GetCouta("", ItemFactura.Id_Factura.ToString(), "0").ListaCouta.Count == 0)
                        {
                            Mostrar = false;
                        }
                    }

                    if (Mostrar)
                    {
                        DG_Datos.Rows.Add();
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Tag = ItemFactura.Id_Factura;

                        if (_TipoFactura == 1)
                        {
                            //if (ItemFactura.Pagado_Factura == false && ItemFactura.Id_Factura_Tipo != 3)
                            //{
                            //    DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SkyBlue;
                            //}
                        }
                        else
                        {
                            if (ItemFactura.Facturado_Factura == false && ItemFactura.Id_Factura_Tipo != 3)
                            {
                                DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.SkyBlue;
                            }
                        }

                        if (ItemFactura.Anulado_Factura == true)
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Red;
                        }

                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_RSocial"].Value = ItemFactura.Tercero.Razon_Social_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Dirección"].Value = ItemFactura.Tercero.Direccion_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Teléfonos"].Value = ItemFactura.Tercero.Telefonos_Tercero;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Fecha"].Value = ItemFactura.Fecha_Factura;
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_CPN"].Value = ItemFactura.Clase_Factura + " " + ItemFactura.Puesto_Factura.ToString("0000") + "-" + ItemFactura.Numero_Factura.ToString("00000000");
                        if (_TipoFactura == 3)
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Importe"].Value = "$ " + (ItemFactura.Total_Factura + ItemFactura.Otros_Factura).ToString(Config.NumeroDecimales);
                        }
                        else
                        {
                            DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_Importe"].Value = "$ " + ItemFactura.Total_Factura.ToString(Config.NumeroDecimales);
                        }
                        DG_Datos.Rows[DG_Datos.Rows.Count - 1].Cells["Clm_ImporteInteres"].Value = "$ " + ItemFactura.Otros_Factura.ToString(Config.NumeroDecimales);
                    }
                }

                Txt_CantidadRegistros.Text = F.ListaFactura.Count.ToString();

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

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            if (_TipoFactura == 1)
            {
                Btn_PF.Visible = false;
            }
            else if (_TipoFactura == 2)
            {
                Btn_PF.Text = "Facturado";
            }
            else if (_TipoFactura == 3)
            {
                Btn_PF.Enabled = false;
            }
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
                    if (_TipoFactura == 3)
                    {
                        Datos.Factura.DeleteRecibo_OrdenPago(DG_Datos.SelectedRows[0].Tag.ToString());
                    }
                    else
                    {
                        Datos.Factura.DeleteFactura_detalle(DG_Datos.SelectedRows[0].Tag.ToString());
                    }
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Baja_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea anular este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    Datos.Factura.AnularFactura_detalle(DG_Datos.SelectedRows[0].Tag.ToString());
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_PF_Click(object sender, EventArgs e)
        {
            try
            {
                if (DG_Datos.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una fila de la grilla de datos.");
                }

                string Str = "";
                if (_TipoFactura == 1)
                {
                    Str = "Pagar";
                }
                else
                {
                    Str = "Facturar";
                }

                DialogResult ResultadoDialogo = MessageBox.Show("¿Desea " + Str + " este registro? \r\nID: " + DG_Datos.SelectedRows[0].Tag.ToString(), Str, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (ResultadoDialogo == System.Windows.Forms.DialogResult.OK)
                {
                    if (_TipoFactura == 1)
                    {
                        Datos.Factura F = Datos.Factura.GetFactura(DG_Datos.SelectedRows[0].Tag.ToString(), "", "", "", "","","").ListaFactura[0];
                        F.Pagado_Factura = true;
                        Datos.Factura.Set(F);
                    }
                    else
                    {
                        Datos.Factura F = Datos.Factura.GetFactura(DG_Datos.SelectedRows[0].Tag.ToString(), "", "", "", "", "","").ListaFactura[0];
                        F.Facturado_Factura = true;
                        Datos.Factura.Set(F);
                    }
                    Buscar();
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
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
            else
            {
                Btn_Editar_Click(sender, e);
            }
        }
    }
}
