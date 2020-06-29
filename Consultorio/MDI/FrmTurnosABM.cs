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
    public partial class FrmTurnosABM : Form
    {
        bool Cerrar = false;
        public FrmTurnosABM()
        {
            InitializeComponent();
        }

        public FrmTurnosABM(string IdTurno)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Turno T = Datos.Turno.GetTurnoRelacional(IdTurno,"").ListaTurno[0];

                id_TurnoNumericUpDown.Value = T.Id_Turno;
                id_TerceroNumericUpDown.Value = T.Id_Tercero;
                Txt_NombrePaciente.Text = T.Tercero.Razon_Social_Tercero;

                Hora_TurnoDateTimePicker.Value = T.Fecha_Turno;
                fecha_TurnoDateTimePicker.Value = T.Fecha_Turno;
                observaciones_TurnoTextBox.Text = T.Observaciones_Turno;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Turno T = new Datos.Turno();

                T.Id_Turno = (int)id_TurnoNumericUpDown.Value;
                T.Id_Tercero = (int)id_TerceroNumericUpDown.Value;

                DateTime FechaHora = Convert.ToDateTime(fecha_TurnoDateTimePicker.Value.ToShortDateString() + " " + Hora_TurnoDateTimePicker.Value.ToString("HH:mm:ss"));
                T.Fecha_Turno = FechaHora;
                T.Observaciones_Turno = observaciones_TurnoTextBox.Text;

                if (id_TurnoNumericUpDown.Value == 0)
                {
                    Datos.Turno.Add(T);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Turno.Set(T);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Cerrar = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cerrar = true;
            Close();
        }

        private void Btn_BuscarPaciente_Click(object sender, EventArgs e)
        {
            MDI.FrmTercero FrmP = new MDI.FrmTercero(1);
            FrmP.ShowDialog();
            if (MDI.FrmTercero.ValorReturn != "")
            {
                id_TerceroNumericUpDown.Value = Convert.ToInt32(MDI.FrmTercero.ValorReturn);
                Txt_NombrePaciente.Text = Datos.Tercero.GetTercero(id_TerceroNumericUpDown.Value.ToString(),"").ListaTercero[0].Razon_Social_Tercero;
            }
        }

        private void FrmTurnosABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Cerrar)
            {
                e.Cancel = true;
            }
        }
    }
}
