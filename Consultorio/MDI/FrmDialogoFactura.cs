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
    public partial class FrmDialogoFactura : Form
    {
        string _TipoFactura;
        string _Clase;
        string _Puesto;
        public string _NumeroComprobante;

        public FrmDialogoFactura(string TipoFactura,string Clase,string Puesto,string NumeroCampobante)
        {
            InitializeComponent();
            _TipoFactura = TipoFactura;
            _Clase = Clase;
            _Puesto = Puesto;
            _NumeroComprobante = NumeroCampobante;
            Actualizar();
        }

        private void Temporisador_Tick(object sender, EventArgs e)
        {
            if (_TipoFactura != "")
            {
                _NumeroComprobante = Datos.Series.UltimoNumeroComprobante(_TipoFactura).ToString("00000000");
                //Datos.Series.Desbloquear(_TipoFactura);
            }
            Actualizar();
        }

        private void Actualizar()
        {
            Lbl_Msj.Text = "¿Esta seguro que el número de comprobante es " + _Clase + " " + _Puesto + "-" + _NumeroComprobante + "?";
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Temporisador.Enabled = false;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Temporisador.Enabled = false;
        }
    }
}
