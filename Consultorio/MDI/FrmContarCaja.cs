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
    public partial class FrmContarCaja : Form
    {
        public FrmContarCaja()
        {
            InitializeComponent();
        }

        private void FrmContarCaja_Load(object sender, EventArgs e)
        {
            Datos.Caja C = Datos.Caja.GetCajaRelacional("");

            decimal Saldo = 0;
            foreach (Datos.Caja ItemCaja in C.ListaCaja)
            {
                switch (ItemCaja.Id_Caja_Tipo)
                {
                    case 1:
                        Saldo += ItemCaja.Importe_Caja;
                        break;
                    case 2:
                        Saldo += ItemCaja.Importe_Caja;
                        break;
                    case 3: ;
                        Saldo -= ItemCaja.Importe_Caja;
                        break;
                }
            }
            TotalInicial.Value = Saldo;
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Resultado_ValueChanged(object sender, EventArgs e)
        {
            decimal TotalCaja = 0;

            TotalCaja += B100.Value * 100;
            TotalCaja += B50.Value * 50;
            TotalCaja += B20.Value * 20;
            TotalCaja += B10.Value * 10;
            TotalCaja += B5.Value * 5;
            TotalCaja += B2.Value * 2;
            TotalCaja += M2.Value * 2;
            TotalCaja += M1.Value * 1;
            TotalCaja += M050.Value * 0.50M;
            TotalCaja += M025.Value * 0.25M;
            TotalCaja += M010.Value * 0.10M;
            TotalCaja += M005.Value * 0.05M;

            DineroCaja.Value = TotalCaja;
            Resultado.Value = TotalInicial.Value - DineroCaja.Value;
        }

        private void Btn_VueltoIdeal_Click(object sender, EventArgs e)
        {
            decimal TotalVariable = Vuelto.Value;

            decimal Dec_B100 = Math.Truncate(TotalVariable / 100);
            TotalVariable = TotalVariable % 100;

            decimal Dec_B50 = Math.Truncate(TotalVariable / 50);
            TotalVariable = TotalVariable % 50;

            decimal Dec_B20 = Math.Truncate(TotalVariable / 20);
            TotalVariable = TotalVariable % 20;

            decimal Dec_B10 = Math.Truncate(TotalVariable / 10);
            TotalVariable = TotalVariable % 10;

            decimal Dec_B5 = Math.Truncate(TotalVariable / 5);
            TotalVariable = TotalVariable % 5;

            decimal Dec_B2 = Math.Truncate(TotalVariable / 2);
            TotalVariable = TotalVariable % 2;

            decimal Dec_M2 = Math.Truncate(TotalVariable / 2);
            TotalVariable = TotalVariable % 2;

            decimal Dec_M1 = Math.Truncate(TotalVariable / 1);
            TotalVariable = TotalVariable % 1;

            decimal Dec_M050 = Math.Truncate(TotalVariable / 0.50M);
            TotalVariable = TotalVariable % 0.50M;

            decimal Dec_M025 = Math.Truncate(TotalVariable / 0.25M);
            TotalVariable = TotalVariable % 0.25M;

            decimal Dec_M010 = Math.Truncate(TotalVariable / 0.10M);
            TotalVariable = TotalVariable % 0.10M;

            decimal Dec_M005 = Math.Truncate(TotalVariable / 0.05M);
            TotalVariable = TotalVariable % 0.005M;

            string Msj = (Dec_B100 > 0)?Dec_B100.ToString() + " billetes de $100\n\r":"";
            Msj += (Dec_B50 > 0) ? Dec_B50.ToString() + " billetes de $50\n\r" : "";
            Msj += (Dec_B20 > 0) ? Dec_B20.ToString() + " billetes de $20\n\r" : "";
            Msj += (Dec_B10 > 0) ? Dec_B10.ToString() + " billetes de $10\n\r" : "";
            Msj += (Dec_B5 > 0) ? Dec_B5.ToString() + " billetes de $5\n\r" : "";
            Msj += (Dec_B2 > 0) ? Dec_B2.ToString() + " billetes de $2\n\r" : "";
            Msj += (Dec_M2 > 0) ? Dec_M2.ToString() + " monedas de $2\n\r" : "";
            Msj += (Dec_M1 > 0) ? Dec_M1.ToString() + " monedas de $1\n\r" : "";
            Msj += (Dec_M050 > 0) ? Dec_M050.ToString() + " monedas de $0,50\n\r" : "";
            Msj += (Dec_M025 > 0) ? Dec_M025.ToString() + " monedas de $0,25\n\r" : "";
            Msj += (Dec_M010 > 0) ? Dec_M010.ToString() + " monedas de $0,10\n\r" : "";
            Msj += (Dec_M005 > 0) ? Dec_M005.ToString() + " monedas de $0,05\n\r" : "";

            MessageBox.Show(Msj, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
