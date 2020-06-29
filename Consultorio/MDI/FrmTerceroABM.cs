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
    public partial class FrmTerceroABM : Form
    {
        int _TipoTercero;
        public FrmTerceroABM(int TipoTercero)
        {
            InitializeComponent();
            AcomodarClienteProveedor(TipoTercero);
        }

        public FrmTerceroABM(string IdTercero, int TipoTercero)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Tercero T = Datos.Tercero.GetTerceroRelacional(IdTercero, TipoTercero.ToString(), "");

                id_TerceroNumericUpDown.Value = Convert.ToInt32(IdTercero);
                _TipoTercero = T.ListaTercero[0].Id_Tercero_Tipo;

                id_LocalidadNumericUpDown.Value = T.ListaTercero[0].Id_Localidad;
                Txt_NombreLocalidad.Text = T.ListaTercero[0].Localidad.Nombre_Localidad;

                id_Obra_SocialNumericUpDown.Value = T.ListaTercero[0].Id_Obra_Social;
                Txt_NombreObraSocial.Text = T.ListaTercero[0].Obra_social.Descripcion_Obra_Social;

                Datos.Tercero_iva TI = Datos.Tercero_iva.GetTercero_iva("");

                foreach (Datos.Tercero_iva itemTercero_iva in TI.ListaTercero_iva)
                {
                    CboCondicion.Items.Add(itemTercero_iva.Id_Tercero_IVA.ToString() + "- " + itemTercero_iva.Descripcion_Tercero_IVA);
                }

                CboCondicion.SelectedIndex = T.ListaTercero[0].Id_Tercero_IVA - 1;

                razon_Social_TerceroTextBox.Text = T.ListaTercero[0].Razon_Social_Tercero;
                direccion_TerceroTextBox.Text = T.ListaTercero[0].Direccion_Tercero;
                fecha_Nacimiento_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Nacimiento_Tercero;
                cUIT_TerceroTextBox.Text = T.ListaTercero[0].CUIT_Tercero;
                telefonos_TerceroTextBox.Text = T.ListaTercero[0].Telefonos_Tercero;
                fax_TerceroTextBox.Text = T.ListaTercero[0].Fax_Tercero;
                dNI_TerceroNumericUpDown.Value = T.ListaTercero[0].DNI_Tercero;
                email_TerceroTextBox.Text = T.ListaTercero[0].Email_Tercero;
                fecha_Alta_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Alta_Tercero;
                fecha_Baja_TerceroDateTimePicker.Value = T.ListaTercero[0].Fecha_Baja_Tercero;
                aulado_TerceroCheckBox.Checked = T.ListaTercero[0].Anulado_Tercero;
                observaciones_TerceroTextBox.Text = T.ListaTercero[0].Observaciones_Tercero;

                sexo_TerceroCheckBox.Checked = T.ListaTercero[0].Sexo_Tercero;
                ocupacion_TerceroTextBox.Text = T.ListaTercero[0].Ocupacion_Tercero;
                ultima_Consulta_TerceroDateTimePicker.Value = T.ListaTercero[0].Ultima_Consulta_Tercero;

                //Soltero/a
                //Casado/a
                //Divorciado/a
                //Viudo/a
                //Unión libre
                //Separado/a

                Cbo_EstadoCivil.Items.Add("Soltero/a");
                Cbo_EstadoCivil.Items.Add("Casado/a");
                Cbo_EstadoCivil.Items.Add("Divorciado/a");
                Cbo_EstadoCivil.Items.Add("Viudo/a");
                Cbo_EstadoCivil.Items.Add("Unión libre");
                Cbo_EstadoCivil.Items.Add("Separado/a");

                switch (T.ListaTercero[0].Estado_Civil_Tercero)
                {
                    case "Soltero/a":
                        Cbo_EstadoCivil.SelectedIndex = 0;
                        break;
                    case "Casado/a":
                        Cbo_EstadoCivil.SelectedIndex = 1;
                        break;
                    case "Divorciado/a":
                        Cbo_EstadoCivil.SelectedIndex = 2;
                        break;
                    case "Viudo/a":
                        Cbo_EstadoCivil.SelectedIndex = 3;
                        break;
                    case "Unión libre":
                        Cbo_EstadoCivil.SelectedIndex = 4;
                        break;
                    case "Separado/a":
                        Cbo_EstadoCivil.SelectedIndex = 5;
                        break;
                }

                //Leno la grilla de las relaciones
                Datos.Tercero_relaciones TR = Datos.Tercero_relaciones.GetTercero_relacionesRelacional("", IdTercero);

                foreach (Datos.Tercero_relaciones ItemTercero_relaciones in TR.ListaTercero_relaciones)
                {
                    DG_Relaciones.Rows.Add();
                    DG_Relaciones.Rows[DG_Relaciones.Rows.Count - 1].Tag = ItemTercero_relaciones.Relacion_Tercero_Relaciones;

                    Datos.Tercero TER_TEMP = Datos.Tercero.GetTercero(ItemTercero_relaciones.Relacion_Tercero_Relaciones.ToString(), "");

                    if (TER_TEMP.ListaTercero.Count != 0)
                    {
                        DG_Relaciones.Rows[DG_Relaciones.Rows.Count - 1].Cells["Clm_NombreTercero"].Value = TER_TEMP.ListaTercero[0].Razon_Social_Tercero;
                    }
                    DG_Relaciones.Rows[DG_Relaciones.Rows.Count - 1].Cells["Clm_Observaciones"].Value = ItemTercero_relaciones.Observaciones_Tercero_Relaciones;
                }

                //Leno la grilla de las enfermedades
                Datos.Tercero_enfermedad TE = Datos.Tercero_enfermedad.GetTercero_enfermedadRelacional("", IdTercero);

                foreach (Datos.Tercero_enfermedad ItemTercero_enfermedad in TE.ListaTercero_enfermedad)
                {
                    DG_Enfermedades.Rows.Add();
                    DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Tag = ItemTercero_enfermedad.Id_Enfermedad;

                    DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Cells["ClmNombreEnfermedad"].Value = ItemTercero_enfermedad.Enfermedad.Descripcion_Enfermedad;
                    DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Cells["Clm_ObservacionesEnfermedad"].Value = ItemTercero_enfermedad.Observaciones_Tercero_Enfermedad;
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
            AcomodarClienteProveedor(TipoTercero);
        }

        private void AcomodarClienteProveedor(int TipoTercero)
        {
            this.Text = "Nuevo/Modificar " + Datos.Tercero_tipo.GetTercero_tipo(TipoTercero.ToString()).ListaTercero_tipo[0].Descripcion_Tercero_Tipo;
            _TipoTercero = TipoTercero;
        }

        private void Btn_BuscarLocalidad_Click(object sender, EventArgs e)
        {
            MDI.FrmLocalidad FrmL = new MDI.FrmLocalidad();
            FrmL.ShowDialog();
            if (MDI.FrmLocalidad.ValorReturn != "")
            {
                id_LocalidadNumericUpDown.Value = Convert.ToInt32(MDI.FrmLocalidad.ValorReturn);
                Txt_NombreLocalidad.Text = Datos.Localidad.GetLocalidad(id_LocalidadNumericUpDown.Value.ToString()).ListaLocalidad[0].Nombre_Localidad;
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ControlValores();

                Datos.Tercero T = new Datos.Tercero();
                Datos.Tercero_relaciones TR = new Datos.Tercero_relaciones();
                TR.ListaTercero_relaciones = new List<Datos.Tercero_relaciones>();
                Datos.Tercero_enfermedad TE = new Datos.Tercero_enfermedad();
                TE.ListaTercero_enfermedad = new List<Datos.Tercero_enfermedad>();

                T.Id_Tercero = Convert.ToInt32(id_TerceroNumericUpDown.Value);
                T.Id_Tercero_Tipo = _TipoTercero;

                T.Id_Localidad = Convert.ToInt32(id_LocalidadNumericUpDown.Value);

                T.Id_Tercero_IVA = Convert.ToInt32(CboCondicion.SelectedItem.ToString().Split(Convert.ToChar("-"))[0]);

                T.Razon_Social_Tercero = razon_Social_TerceroTextBox.Text;
                T.Direccion_Tercero = direccion_TerceroTextBox.Text;
                T.Fecha_Nacimiento_Tercero = fecha_Nacimiento_TerceroDateTimePicker.Value;
                T.CUIT_Tercero = cUIT_TerceroTextBox.Text;
                T.Telefonos_Tercero = telefonos_TerceroTextBox.Text;
                T.Fax_Tercero = fax_TerceroTextBox.Text;
                T.DNI_Tercero = Convert.ToInt32(dNI_TerceroNumericUpDown.Value);
                T.Email_Tercero = email_TerceroTextBox.Text;
                T.Fecha_Alta_Tercero = fecha_Alta_TerceroDateTimePicker.Value;
                T.Fecha_Baja_Tercero = fecha_Baja_TerceroDateTimePicker.Value;
                T.Anulado_Tercero = aulado_TerceroCheckBox.Checked;
                T.Observaciones_Tercero = observaciones_TerceroTextBox.Text;

                T.Id_Obra_Social = (int)id_Obra_SocialNumericUpDown.Value;
                T.Sexo_Tercero = sexo_TerceroCheckBox.Checked;
                T.Ocupacion_Tercero = ocupacion_TerceroTextBox.Text;
                T.Ultima_Consulta_Tercero = ultima_Consulta_TerceroDateTimePicker.Value;
                T.Estado_Civil_Tercero = Cbo_EstadoCivil.Text;

                foreach (DataGridViewRow Fila in DG_Relaciones.Rows)
                {
                    Datos.Tercero_relaciones TEMP = new Datos.Tercero_relaciones();

                    TEMP.Relacion_Tercero_Relaciones = Convert.ToInt32(Fila.Tag);
                    if (Fila.Cells["Clm_Observaciones"].Value != null)
                    {
                        TEMP.Observaciones_Tercero_Relaciones = Fila.Cells["Clm_Observaciones"].Value.ToString();
                    }
                    else
                    {
                        TEMP.Observaciones_Tercero_Relaciones = "";
                    }
                    TR.ListaTercero_relaciones.Add(TEMP);
                }


                foreach (DataGridViewRow Fila in DG_Enfermedades.Rows)
                {
                    Datos.Tercero_enfermedad TEMP = new Datos.Tercero_enfermedad();

                    TEMP.Id_Enfermedad = Convert.ToInt32(Fila.Tag);
                    if (Fila.Cells["Clm_ObservacionesEnfermedad"].Value != null)
                    {
                        TEMP.Observaciones_Tercero_Enfermedad = Fila.Cells["Clm_ObservacionesEnfermedad"].Value.ToString();
                    }
                    else
                    {
                        TEMP.Observaciones_Tercero_Enfermedad = "";
                    }
                    TE.ListaTercero_enfermedad.Add(TEMP);
                }


                if (id_TerceroNumericUpDown.Value == 0)
                {
                    Datos.Tercero.Add_TerceroRelacionEnfermedad(T, TR, TE);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Tercero.Set_TerceroRelacionEnfermedad(T, TR, TE);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmTerceroABM_Load(object sender, EventArgs e)
        {
            if (Cbo_EstadoCivil.Items.Count == 0)
            {
                Cbo_EstadoCivil.Items.Add("Soltero/a");
                Cbo_EstadoCivil.Items.Add("Casado/a");
                Cbo_EstadoCivil.Items.Add("Divorciado/a");
                Cbo_EstadoCivil.Items.Add("Viudo/a");
                Cbo_EstadoCivil.Items.Add("Unión libre");
                Cbo_EstadoCivil.Items.Add("Separado/a");

                Cbo_EstadoCivil.SelectedIndex = 0;
            }

            if (CboCondicion.Items.Count == 0)
            {
                Datos.Tercero_iva TI = Datos.Tercero_iva.GetTercero_iva("");

                foreach (Datos.Tercero_iva itemTercero_iva in TI.ListaTercero_iva)
                {
                    CboCondicion.Items.Add(itemTercero_iva.Id_Tercero_IVA.ToString() + "- " + itemTercero_iva.Descripcion_Tercero_IVA);
                }

                if (_TipoTercero == 2)
                {
                    CboCondicion.SelectedIndex = 5;
                }
                else
                {
                    CboCondicion.SelectedIndex = 3;
                }
            }
        }

        private void ControlValores()
        {
            if (id_LocalidadNumericUpDown.Value == 0)
            {
                ProvError.SetError(Txt_NombreLocalidad, "Falta elegir a una localidad.");
            }
            else
            {
                ProvError.SetError(Txt_NombreLocalidad, "");
            }

            if (id_Obra_SocialNumericUpDown.Value == 0)
            {
                ProvError.SetError(Txt_NombreObraSocial, "Falta elegir a una obra social.");
            }
            else
            {
                ProvError.SetError(Txt_NombreObraSocial, "");
            }
        }

        private void cUIT_TerceroTextBox_Leave(object sender, EventArgs e)
        {
            if (cUIT_TerceroTextBox.Text.Split(Convert.ToChar("-")).Length == 3)
            {
                dNI_TerceroNumericUpDown.Value = Convert.ToInt32(cUIT_TerceroTextBox.Text.Split(Convert.ToChar("-"))[1]);
            }
        }

        private void Btn_BuscarObraSocial_Click(object sender, EventArgs e)
        {
            MDI.FrmObrasSociales FrmL = new MDI.FrmObrasSociales();
            FrmL.ShowDialog();
            if (MDI.FrmObrasSociales.ValorReturn != "")
            {
                id_Obra_SocialNumericUpDown.Value = Convert.ToInt32(MDI.FrmObrasSociales.ValorReturn);
                Txt_NombreObraSocial.Text = Datos.Obra_social.GetObra_social(id_Obra_SocialNumericUpDown.Value.ToString(), "").ListaObra_social[0].Descripcion_Obra_Social;
            }
        }

        private void Btn_QuitarRelacion_Click(object sender, EventArgs e)
        {
            if (DG_Relaciones.SelectedRows.Count > 0)
            {
                DG_Relaciones.Rows.RemoveAt(DG_Relaciones.SelectedRows[0].Index);
            }
        }

        private void Btn_AgregarRelacion_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmS = new MDI.FrmTercero(1);
            FrmS.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                Datos.Tercero T = Datos.Tercero.GetTercero(MDI.FrmTercero.ValorReturn, "").ListaTercero[0];
                DG_Relaciones.Rows.Add();

                DG_Relaciones.Rows[DG_Relaciones.Rows.Count - 1].Tag = MDI.FrmTercero.ValorReturn;

                DG_Relaciones.Rows[DG_Relaciones.Rows.Count - 1].Cells["Clm_NombreTercero"].Value = T.Razon_Social_Tercero;
            }
        }

        private void Btn_QuitarEnfermedad_Click(object sender, EventArgs e)
        {
            if (DG_Enfermedades.SelectedRows.Count > 0)
            {
                DG_Enfermedades.Rows.RemoveAt(DG_Enfermedades.SelectedRows[0].Index);
            }
        }

        private void Btn_AgregarEnfermedad_Click(object sender, EventArgs e)
        {
            MDI.FrmEnfermedades FrmS = new MDI.FrmEnfermedades();
            FrmS.ShowDialog();
            if (MDI.FrmEnfermedades.ValorReturn != "")
            {
                Datos.Enfermedad E = Datos.Enfermedad.GetEnfermedad(MDI.FrmEnfermedades.ValorReturn).ListaEnfermedad[0];
                DG_Enfermedades.Rows.Add();

                DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Tag = MDI.FrmEnfermedades.ValorReturn;

                DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Cells["ClmNombreEnfermedad"].Value = E.Descripcion_Enfermedad;
            }
        }
    }
}
