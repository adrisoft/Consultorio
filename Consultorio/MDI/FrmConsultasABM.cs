using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Consultorio.MDI
{
    public partial class FrmConsultasABM : Form
    {

        bool GuardarCambios = false;
        List<string> ListaImagenesBorrar = new List<string>();

        public FrmConsultasABM()
        {
            InitializeComponent();
        }

        public FrmConsultasABM(string IdConsulta)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Consulta C = Datos.Consulta.GetConsultaRelacional(IdConsulta, "").ListaConsulta[0];

                id_ConsultaNumericUpDown.Value = C.Id_Consulta;
                id_TerceroNumericUpDown.Value = C.Id_Tercero;
                Txt_NombrePaciente.Text = C.Tercero.Razon_Social_Tercero;

                fecha_ConsultaDateTimePicker.Value = C.Fecha_Consulta;
                motivo_ConsultaTextBox.Text = C.Motivo_Consulta;
                analisis_Visual_ConsultaTextBox.Text = C.Analisis_Visual_Consulta;
                evolucion_ConsultaTextBox.Text = C.Evolucion_Consulta;
                alta_ConsultaCheckBox.Checked = C.Alta_Consulta;
                alta_Medica_ConsultaTextBox.Text = C.Alta_Medica_Consulta;
                fecha_Alta_ConsultaDateTimePicker.Value = C.Fecha_Alta_Consulta;
                observaciones_ConsultaTextBox.Text = C.Observaciones_Consulta;

                //CARGAR
                //1-ESTUDIOS
                //2-DIAGNOSTICO
                //3-TRATAMIENTO
                //4-IMAGENES
                //5-MEDICACION
                //6-VISITAS

                Datos.Consulta_estudio CE = Datos.Consulta_estudio.GetConsulta_estudioRelacional("", IdConsulta);
                foreach (Datos.Consulta_estudio Fila in CE.ListaConsulta_estudio)
                {
                    DG_Estudios.Rows.Add();
                    DG_Estudios.Rows[DG_Estudios.Rows.Count - 1].Tag = Fila.Id_Estudio;
                    DG_Estudios.Rows[DG_Estudios.Rows.Count - 1].Cells["Clm_NombreEstudio"].Value = Fila.Estudio.Descripcion_Estudio;
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_enfermedad C_ENFERMEDAD = Datos.Consulta_enfermedad.GetConsulta_enfermedadRelacional("", IdConsulta);
                foreach (Datos.Consulta_enfermedad Fila in C_ENFERMEDAD.ListaConsulta_enfermedad)
                {
                    DG_Enfermedades.Rows.Add();
                    DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Tag = Fila.Id_Enfermedad;
                    DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Cells["Clm_NombreEnfermedad"].Value = Fila.Enfermedad.Descripcion_Enfermedad;
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_tratamiento CT = Datos.Consulta_tratamiento.GetConsulta_tratamientoRelacional("", IdConsulta);
                foreach (Datos.Consulta_tratamiento Fila in CT.ListaConsulta_tratamiento)
                {
                    DG_Tratamiento.Rows.Add();
                    DG_Tratamiento.Rows[DG_Tratamiento.Rows.Count - 1].Tag = Fila.Id_Tratamiento;
                    DG_Tratamiento.Rows[DG_Tratamiento.Rows.Count - 1].Cells["Clm_NombreTratamiento"].Value = Fila.Tratamiento.Descripcion_Tratamiento;
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_imagenes CI = Datos.Consulta_imagenes.GetConsulta_imagenes("", IdConsulta);
                foreach (Datos.Consulta_imagenes Fila in CI.ListaConsulta_imagenes)
                {
                    DG_Imagenes.Rows.Add();
                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Tag = Fila.Imagen_Consulta_Imagenes;

                    FileInfo FI = new FileInfo(Config.RutaImagenes + Fila.Imagen_Consulta_Imagenes);
                    if (FI.Exists)
                    {
                        System.IO.FileStream fs = null;
                        fs = new System.IO.FileStream(Config.RutaImagenes + Fila.Imagen_Consulta_Imagenes, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                        DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Imagen"].Value = System.Drawing.Image.FromStream(fs);
                        fs.Close();
                    }
                    else
                    {
                        DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Imagen"].Value = Properties.Resources._1318513481_Delete;
                    }

                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Height = 100;
                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Observacion"].Value = Fila.Observaciones_Consulta_Imagenes;
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_medicacion CM = Datos.Consulta_medicacion.GetConsulta_medicacionRelacional("", IdConsulta);
                foreach (Datos.Consulta_medicacion Fila in CM.ListaConsulta_medicacion)
                {
                    DG_Medicacion.Rows.Add();
                    DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Tag = Fila.Id_Medicacion;
                    DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_PrincipioActivo"].Value = Fila.Medicacion.Principio_Activo_Medicacion;
                    DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_NombreComercial"].Value = Fila.Medicacion.Nombre_Comercial_Medicacion;
                    DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_Presentacion"].Value = Fila.Medicacion.Presentacion_Medicacion;
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_visita CV = Datos.Consulta_visita.GetConsulta_visita("", IdConsulta);
                foreach (Datos.Consulta_visita Fila in CV.ListaConsulta_visita)
                {
                    DG_Visitas.Rows.Add();
                    DG_Visitas.Rows[DG_Visitas.Rows.Count - 1].Cells["Clm_FechaVisita"].Value = Fila.Fecha_Consulta_Visita;
                    DG_Visitas.Rows[DG_Visitas.Rows.Count - 1].Cells["Clm_ObservacionesVisita"].Value = Fila.Observaciones_Consulta_Visita;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmConsultasABM_Load(object sender, EventArgs e)
        {
            if (id_ConsultaNumericUpDown.Value == 0)
            {
                Btn_BuscarPaciente_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_ConsultaNumericUpDown.Value = 0;
            List<string[]> ListaImagenes = new List<string[]>();
            foreach (DataGridViewRow Fila in DG_Imagenes.Rows)
            {
                string[] temp = new string[2];
                if (Fila.Tag != null)
                {
                    temp[0] = Fila.Tag.ToString();
                }
                temp[1] = Fila.Cells["Clm_Observacion"].Value.ToString();
                ListaImagenes.Add(temp);
            }

            //Aca selecciono la filas que se tiene que eliminar
            List<DataGridViewRow> Filas = new List<DataGridViewRow>();
            foreach (DataGridViewRow Fila in DG_Imagenes.Rows)
            {
                if (Fila.Tag != null)
                {
                    Filas.Add(Fila);
                }
            }

            //aca borros las filas seleccionadas
            foreach (DataGridViewRow itemDataGridViewRow in Filas)
            {
                DG_Imagenes.Rows.Remove(itemDataGridViewRow);
            }

            foreach (string[] itemString in ListaImagenes)
            {
                if (itemString[0] != null)
                {
                    DG_Imagenes.Rows.Add();
                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Imagen"].Value = Image.FromFile(Config.RutaImagenes + itemString[0]);
                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Observacion"].Value = itemString[1];
                    DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Height = 100;
                }
            }

            Btn_BuscarPaciente_Click(sender, e);
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Consulta C = new Datos.Consulta();

                C.Id_Consulta = (int)id_ConsultaNumericUpDown.Value;
                C.Id_Tercero = (int)id_TerceroNumericUpDown.Value;

                C.Fecha_Consulta = fecha_ConsultaDateTimePicker.Value;
                C.Motivo_Consulta = motivo_ConsultaTextBox.Text;
                C.Analisis_Visual_Consulta = analisis_Visual_ConsultaTextBox.Text;
                C.Evolucion_Consulta = evolucion_ConsultaTextBox.Text;
                C.Alta_Consulta = alta_ConsultaCheckBox.Checked;
                C.Alta_Medica_Consulta = alta_Medica_ConsultaTextBox.Text;
                C.Fecha_Alta_Consulta = fecha_Alta_ConsultaDateTimePicker.Value;
                C.Observaciones_Consulta = observaciones_ConsultaTextBox.Text;

                //GUARDAR
                //1-ESTUDIOS
                //2-DIAGNOSTICO
                //3-TRATAMIENTO
                //4-IMAGENES
                //5-MEDICACION
                //6-VISITAS

                Datos.Consulta_estudio CE = new Datos.Consulta_estudio();
                CE.ListaConsulta_estudio = new List<Datos.Consulta_estudio>();

                foreach (DataGridViewRow Fila in DG_Estudios.Rows)
                {
                    Datos.Consulta_estudio TEMP = new Datos.Consulta_estudio();

                    TEMP.Id_Estudio = Convert.ToInt32(Fila.Tag);
                    CE.ListaConsulta_estudio.Add(TEMP);
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_enfermedad C_ENFERMEDAD = new Datos.Consulta_enfermedad();
                C_ENFERMEDAD.ListaConsulta_enfermedad = new List<Datos.Consulta_enfermedad>();

                foreach (DataGridViewRow Fila in DG_Enfermedades.Rows)
                {
                    Datos.Consulta_enfermedad TEMP = new Datos.Consulta_enfermedad();

                    TEMP.Id_Enfermedad = Convert.ToInt32(Fila.Tag);
                    C_ENFERMEDAD.ListaConsulta_enfermedad.Add(TEMP);
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_tratamiento CT = new Datos.Consulta_tratamiento();
                CT.ListaConsulta_tratamiento = new List<Datos.Consulta_tratamiento>();

                foreach (DataGridViewRow Fila in DG_Tratamiento.Rows)
                {
                    Datos.Consulta_tratamiento TEMP = new Datos.Consulta_tratamiento();

                    TEMP.Id_Tratamiento = Convert.ToInt32(Fila.Tag);
                    CT.ListaConsulta_tratamiento.Add(TEMP);
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_imagenes CI = new Datos.Consulta_imagenes();
                CI.ListaConsulta_imagenes = new List<Datos.Consulta_imagenes>();

                foreach (DataGridViewRow Fila in DG_Imagenes.Rows)
                {
                    Datos.Consulta_imagenes TEMP = new Datos.Consulta_imagenes();

                    if (Fila.Tag != null)
                    {
                        TEMP.Imagen_Consulta_Imagenes = Fila.Tag.ToString();
                    }
                    else
                    {
                        try
                        {
                            string NombreImagen = Guid.NewGuid().ToString();
                            Image ImagenActual = (Image)Fila.Cells["Clm_Imagen"].Value;
                            ImagenActual.Save(Config.RutaImagenes + NombreImagen + ".jpeg", ImageFormat.Jpeg);
                            TEMP.Imagen_Consulta_Imagenes = NombreImagen + ".jpeg";
                            Fila.DefaultCellStyle.BackColor = Color.White;
                        }
                        catch (Exception Exc_Error)
                        {
                            Fila.DefaultCellStyle.BackColor = Color.Red;
                            throw Exc_Error;
                        }

                    }

                    TEMP.Observaciones_Consulta_Imagenes = (Fila.Cells["Clm_Observacion"].Value == null) ? "" : Fila.Cells["Clm_Observacion"].Value.ToString();
                    CI.ListaConsulta_imagenes.Add(TEMP);
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_medicacion CM = new Datos.Consulta_medicacion();
                CM.ListaConsulta_medicacion = new List<Datos.Consulta_medicacion>();

                foreach (DataGridViewRow Fila in DG_Medicacion.Rows)
                {
                    Datos.Consulta_medicacion TEMP = new Datos.Consulta_medicacion();

                    TEMP.Id_Medicacion = Convert.ToInt32(Fila.Tag);
                    CM.ListaConsulta_medicacion.Add(TEMP);
                }

                //------------------------------------------------------------------------------------
                Datos.Consulta_visita CV = new Datos.Consulta_visita();
                CV.ListaConsulta_visita = new List<Datos.Consulta_visita>();

                foreach (DataGridViewRow Fila in DG_Visitas.Rows)
                {
                    Datos.Consulta_visita TEMP = new Datos.Consulta_visita();

                    TEMP.Fecha_Consulta_Visita = (Fila.Cells["Clm_FechaVisita"].Value == null) ? DateTime.Now : Convert.ToDateTime(Fila.Cells["Clm_FechaVisita"].Value);
                    TEMP.Observaciones_Consulta_Visita = (Fila.Cells["Clm_ObservacionesVisita"].Value == null) ? "" : Fila.Cells["Clm_ObservacionesVisita"].Value.ToString();
                    CV.ListaConsulta_visita.Add(TEMP);
                }

                if (id_ConsultaNumericUpDown.Value == 0)
                {
                    Datos.Consulta.Add_ConsultaCompleta(C, CE, C_ENFERMEDAD, CT, CI, CM, CV);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Consulta.Set_ConsultaCompleta(C, CE, C_ENFERMEDAD, CT, CI, CM, CV);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                GuardarCambios = true;
                Close();
            }
            catch (Exception Error)
            {
                GuardarCambios = false;
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_BuscarPaciente_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmP = new MDI.FrmTercero(1);
            FrmP.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroNumericUpDown.Value = Convert.ToInt32(MDI.FrmTercero.ValorReturn);
                Txt_NombrePaciente.Text = Datos.Tercero.GetTercero(id_TerceroNumericUpDown.Value.ToString(), "").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void Btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            DialogResult ResultadoDialogo;
            AbrirImagen.Filter = @"Archivos JPEG's|*.jpg|Archivos GIF's|*.gif|Archivos Bitmaps|*.bmp|Archivos PNG's|*.png";
            AbrirImagen.FilterIndex = 1;
            AbrirImagen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            AbrirImagen.Title = "Seleccione una imagen";
            AbrirImagen.CheckFileExists = true;
            AbrirImagen.CheckPathExists = true;
            AbrirImagen.FileName = "";
            ResultadoDialogo = AbrirImagen.ShowDialog();
            if (ResultadoDialogo == DialogResult.OK)
            {
                DG_Imagenes.Rows.Add();
                DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Imagen"].Value = Image.FromFile(AbrirImagen.FileName);
                DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Height = 100;
            }
        }

        private void Btn_AgregarVisita_Click(object sender, EventArgs e)
        {
            DG_Visitas.Rows.Add();
            DG_Visitas.Rows[DG_Visitas.Rows.Count - 1].Cells["Clm_FechaVisita"].Value = DateTime.Now;
        }

        private void Btn_AgregarMedicacion_Click(object sender, EventArgs e)
        {
            MDI.FrmMedicamentos FrmS = new MDI.FrmMedicamentos();
            FrmS.ShowDialog();
            if (MDI.FrmMedicamentos.ValorReturn != "")
            {
                Datos.Medicacion M = Datos.Medicacion.GetMedicacion(MDI.FrmMedicamentos.ValorReturn).ListaMedicacion[0];
                DG_Medicacion.Rows.Add();

                DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Tag = MDI.FrmMedicamentos.ValorReturn;

                DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_PrincipioActivo"].Value = M.Principio_Activo_Medicacion;
                DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_NombreComercial"].Value = M.Nombre_Comercial_Medicacion;
                DG_Medicacion.Rows[DG_Medicacion.Rows.Count - 1].Cells["Clm_Presentacion"].Value = M.Presentacion_Medicacion;
            }
        }

        private void Btn_QuitarVisita_Click(object sender, EventArgs e)
        {
            if (DG_Visitas.SelectedRows.Count > 0)
            {
                DG_Visitas.Rows.RemoveAt(DG_Visitas.SelectedRows[0].Index);
            }
        }

        private void Btn_QuitarMedicacion_Click(object sender, EventArgs e)
        {
            if (DG_Medicacion.SelectedRows.Count > 0)
            {
                DG_Medicacion.Rows.RemoveAt(DG_Medicacion.SelectedRows[0].Index);
            }
        }

        private void Btn_QuitarImagen_Click(object sender, EventArgs e)
        {
            if (DG_Imagenes.SelectedRows.Count > 0)
            {
                if (DG_Imagenes.Rows[DG_Imagenes.SelectedRows[0].Index].Tag != null)
                {
                    ListaImagenesBorrar.Add(DG_Imagenes.Rows[DG_Imagenes.SelectedRows[0].Index].Tag.ToString());
                }
                DG_Imagenes.Rows.RemoveAt(DG_Imagenes.SelectedRows[0].Index);
            }
        }

        private void Btn_QuitarTratamiento_Click(object sender, EventArgs e)
        {
            if (DG_Tratamiento.SelectedRows.Count > 0)
            {
                DG_Tratamiento.Rows.RemoveAt(DG_Tratamiento.SelectedRows[0].Index);
            }
        }

        private void Btn_QuitarEnfermedad_Click(object sender, EventArgs e)
        {
            if (DG_Enfermedades.SelectedRows.Count > 0)
            {
                DG_Enfermedades.Rows.RemoveAt(DG_Enfermedades.SelectedRows[0].Index);
            }
        }

        private void Btn_QuitarEstudio_Click(object sender, EventArgs e)
        {
            if (DG_Estudios.SelectedRows.Count > 0)
            {
                DG_Estudios.Rows.RemoveAt(DG_Estudios.SelectedRows[0].Index);
            }
        }

        private void Btn_AgregarTratameinto_Click(object sender, EventArgs e)
        {
            MDI.FrmTratamientos FrmS = new MDI.FrmTratamientos();
            FrmS.ShowDialog();
            if (MDI.FrmTratamientos.ValorReturn != "")
            {
                Datos.Tratamiento T = Datos.Tratamiento.GetTratamiento(MDI.FrmTratamientos.ValorReturn, "").ListaTratamiento[0];
                DG_Tratamiento.Rows.Add();

                DG_Tratamiento.Rows[DG_Tratamiento.Rows.Count - 1].Tag = MDI.FrmTratamientos.ValorReturn;

                DG_Tratamiento.Rows[DG_Tratamiento.Rows.Count - 1].Cells["Clm_NombreTratamiento"].Value = T.Descripcion_Tratamiento;
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

                DG_Enfermedades.Rows[DG_Enfermedades.Rows.Count - 1].Cells["Clm_NombreEnfermedad"].Value = E.Descripcion_Enfermedad;
            }
        }

        private void Btn_AgregarEstudio_Click(object sender, EventArgs e)
        {
            MDI.FrmEstudios FrmS = new MDI.FrmEstudios();
            FrmS.ShowDialog();
            if (MDI.FrmEstudios.ValorReturn != "")
            {
                Datos.Estudio E = Datos.Estudio.GetEstudio(MDI.FrmEstudios.ValorReturn, "").ListaEstudio[0];
                DG_Estudios.Rows.Add();

                DG_Estudios.Rows[DG_Estudios.Rows.Count - 1].Tag = MDI.FrmEstudios.ValorReturn;

                DG_Estudios.Rows[DG_Estudios.Rows.Count - 1].Cells["Clm_NombreEstudio"].Value = E.Descripcion_Estudio;
            }
        }

        private void Btn_VisualizarImagen_Click(object sender, EventArgs e)
        {
            if (DG_Imagenes.SelectedRows.Count > 0)
            {
                FrmVisualizarImagen FrmVI = new FrmVisualizarImagen((Image)DG_Imagenes.Rows[DG_Imagenes.SelectedRows[0].Index].Cells["Clm_Imagen"].Value);
                FrmVI.ShowDialog();
            }
        }

        private void DG_Imagenes_DoubleClick(object sender, EventArgs e)
        {
            Btn_VisualizarImagen_Click(sender, e);
        }

        private void FrmConsultasABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GuardarCambios)
            {
                foreach (string itemString in ListaImagenesBorrar)
                {
                    FileInfo FI = new FileInfo(Config.RutaImagenes + itemString);
                    if (FI.Exists)
                    {
                        FI.Delete();
                    }
                }
            }
        }

        private void Btn_WebCam_Click(object sender, EventArgs e)
        {
            Webcam.Form1 frm = new Webcam.Form1();
            frm.ShowDialog();

            if (Webcam.ModuloDeLaImage.ImagenCompartida != null)
            {
                DG_Imagenes.Rows.Add();
                DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Cells["Clm_Imagen"].Value = Webcam.ModuloDeLaImage.ImagenCompartida;
                DG_Imagenes.Rows[DG_Imagenes.Rows.Count - 1].Height = 100;
            }
        }
    }
}
