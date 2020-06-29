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
    public partial class FrmSeries : Form
    {
        public FrmSeries()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Series S = Datos.Series.GetSeries("");

                S.ListaSeries[0].Numero = Convert.ToInt32(NUD_Presupuesto.Value);
                S.ListaSeries[0].Bloqueado = false;
                S.ListaSeries[1].Numero = Convert.ToInt32(NUD_FACA.Value);
                S.ListaSeries[1].Bloqueado = false;
                S.ListaSeries[2].Numero = Convert.ToInt32(NUD_FACB.Value);
                S.ListaSeries[2].Bloqueado = false;
                S.ListaSeries[3].Numero = Convert.ToInt32(NUD_FACC.Value);
                S.ListaSeries[3].Bloqueado = false;
                S.ListaSeries[4].Numero = Convert.ToInt32(NUD_Recibos.Value);
                S.ListaSeries[4].Bloqueado = false;

                Datos.Series.SetComillas(S.ListaSeries[0]);
                Datos.Series.SetComillas(S.ListaSeries[1]);
                Datos.Series.SetComillas(S.ListaSeries[2]);
                Datos.Series.SetComillas(S.ListaSeries[3]);
                Datos.Series.SetComillas(S.ListaSeries[4]);
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void FrmSeries_Load(object sender, EventArgs e)
        {
            Datos.Series S = Datos.Series.GetSeries("");

            try
            {
                NUD_Presupuesto.Value = S.ListaSeries[0].Numero;
                NUD_FACA.Value = S.ListaSeries[1].Numero;
                NUD_FACB.Value = S.ListaSeries[2].Numero;
                NUD_FACC.Value = S.ListaSeries[3].Numero;
                NUD_Recibos.Value = S.ListaSeries[4].Numero;
            }
            catch
            {
                NUD_Presupuesto.Value = 0;
                NUD_FACA.Value = 0;
                NUD_FACB.Value = 0;
                NUD_FACC.Value = 0;
                NUD_Recibos.Value = 0;
            }
        }
    }
}
