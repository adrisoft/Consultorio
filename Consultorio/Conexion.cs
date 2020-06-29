using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace Consultorio
{
    public partial class Conexion : Form
    {
        public Conexion()
        {
            InitializeComponent();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Clave = "adrian12";
            UTF8Encoding Encoder = new UTF8Encoding();
            byte[] Datos = Encoder.GetBytes(ArmarConeccion() + "|" + Txt_CarpetaImagenes.Text);
            MemoryStream MS = new MemoryStream(Datos);
            FileStream FS = new FileStream(Application.StartupPath + @"\Conección.cnn", FileMode.Create, FileAccess.Write);
            DESCryptoServiceProvider EncriptacionServicio = new DESCryptoServiceProvider();
            EncriptacionServicio.Key = Encoding.Default.GetBytes(Clave.Substring(0, 8));
            EncriptacionServicio.IV = Encoding.Default.GetBytes(Clave.Substring(0, 8));
            CryptoStream CS = new CryptoStream(FS, EncriptacionServicio.CreateEncryptor(), CryptoStreamMode.Write);
            CS.Write(Datos, 0, Datos.Length);
            CS.Flush();
            CS.Close();
            MS.Close();
            FS.Close();
        }

        private void Btn_ProbarConexion_Click(object sender, EventArgs e)
        {
            Datos.Common.Cnn = new MySqlConnection(ArmarConeccion());

            try
            {
                Datos.Common.Cnn.Open();
                Datos.Common.Cnn.Close();

                DirectoryInfo DI = new DirectoryInfo(Txt_CarpetaImagenes.Text);
                if (!DI.Exists)
                {
                    throw new Exception("No existe el directorio de las imagenes");
                }

                MessageBox.Show("Conexión exitosa!");
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se puede realizar la coneccion con estos datos.\r\nDetalles:\r\n" + Error.Message);
            }
        }

        private void Conexion_Load(object sender, EventArgs e)
        {
            if (Common.ExisteArchivoCnn())
            {
                MySqlConnectionStringBuilder CadenaCnn = Common.RecuperarCnn();

                Txt_Servidor.Text = CadenaCnn.Server;
                Txt_DB.Text = CadenaCnn.Database;
                Txt_Usuario.Text = CadenaCnn.UserID;
                Txt_Contraseña.Text = CadenaCnn.Password;
            }
        }

        private string ArmarConeccion()
        {
            return "server="+ Txt_Servidor.Text + ";User Id=" + Txt_Usuario.Text +";database=" + Txt_DB.Text + ";password=" + Txt_Contraseña.Text + ";";
        }

        private void Btn_BuscarCarpeta_Click(object sender, EventArgs e)
        {
            BuscarCarpeta.ShowDialog();
            Txt_CarpetaImagenes.Text = BuscarCarpeta.SelectedPath + "\\";
        }
    }
}
