using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Consultorio.MDI
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDialogo.FileName = "BACKUP-" + DateTime.Now.ToString("dd-MM-yyyy") + ".SQL";
                SaveDialogo.Filter = ".SQL|Backup de bases de datos en formato sql.";
                SaveDialogo.InitialDirectory = Consultorio.Properties.Settings.Default.UltimaRutaGuardarBackup;
                SaveDialogo.OverwritePrompt = true;
                SaveDialogo.Title = "Guardar backup de base de datos.";
                SaveDialogo.ShowDialog();

                Consultorio.Properties.Settings.Default.UltimaRutaGuardarBackup = SaveDialogo.FileName.Substring(0, SaveDialogo.FileName.LastIndexOf(@"\"));

                ProcessStartInfo info = new ProcessStartInfo(Application.StartupPath + @"\MYSQLD.exe");
                info.Arguments = String.Format("--add-drop-table --host=" + Txt_Servidor.Text + " --opt " + Txt_DB.Text + " --password=" + Txt_Contraseña.Text + " --port=" + "3306" + " --user=" + Txt_Usuario.Text + " --first-slave --result-file=" + SaveDialogo.FileName);

                info.UseShellExecute = false;
                info.CreateNoWindow = true;
                info.RedirectStandardError = true;
                Process backup = new Process();
                backup.StartInfo = info;
                backup.Start();
                backup.WaitForExit();
                if (backup.ExitCode != 0)
                {
                    MessageBox.Show(backup.StandardError.ReadToEnd());
                }

                Consultorio.Properties.Settings.Default.Save();
                Close();
            }
            catch
            {
                MessageBox.Show("Error al intentar hacer un backup de datos.", "Backup");
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder CnnTemp = Common.RecuperarCnn();
            Txt_Servidor.Text = CnnTemp.Server;
            Txt_DB.Text = CnnTemp.Database;
            Txt_Usuario.Text = CnnTemp.UserID;
            Txt_Contraseña.Text = CnnTemp.Password;
        }

        private void Btn_ProbarConexion_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder MyCnnString = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            MyCnnString.Server = Txt_Servidor.Text;
            MyCnnString.UserID = Txt_Usuario.Text;
            MyCnnString.Database = Txt_DB.Text;
            MyCnnString.Password = Txt_Contraseña.Text;
            MySql.Data.MySqlClient.MySqlConnection MyCnn = new MySql.Data.MySqlClient.MySqlConnection(MyCnnString.ConnectionString);

            try
            {
                MyCnn.Open();
                MyCnn.Close();
                MessageBox.Show("Conexión exitosa!");
            }
            catch (Exception Error)
            {
                MessageBox.Show("No se puede realizar la coneccion con estos datos.\r\nDetalles:\r\n" + Error.Message);
            }
        }

        private void Btn_Restablecer_Click(object sender, EventArgs e)
        {
            string Caracteres = "ABCDEFGHIJKLMNOPWRSTYVWYZX123456789";
            string Capcha = "";

            Random Ran = new Random();

            for (int i = 0; i < 5; i++)
            {
                Capcha += Caracteres.Substring(Ran.Next(Caracteres.Length - 1), 1);
            }

            string RespuestaInput = Microsoft.VisualBasic.Interaction.InputBox("Introdusca el siguente texto (Todo en mayusculas): " + Capcha, "Chequeo de seguridad");

            if (Capcha != RespuestaInput)
            {
                if (RespuestaInput != "")
                {
                    MessageBox.Show("Los caracteres ingresados son incorrectos, vuelva a intentarlo. Recuerde que solamente se usan MAYUSCULAS", "Error al ingresar los caracteres", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                return;
            }

            OpenDialogo.InitialDirectory = Consultorio.Properties.Settings.Default.UltimaRutaGuardarBackup;
            OpenDialogo.DefaultExt = ".SQL";
            OpenDialogo.Multiselect = false;
            OpenDialogo.FileName = "";
            OpenDialogo.Title = "Abrir backup de base de datos.";
            OpenDialogo.ShowDialog();

            string comando = null;
            bool resp = false;
            try
            {
                comando = "cd " + Application.StartupPath + "\r\n" + "mysql.exe --host=" + Txt_Servidor.Text + " --user=" + Txt_Usuario.Text + " --password=" + Txt_Contraseña.Text + " --force " + Txt_DB.Text + " < " + OpenDialogo.FileName;
                try
                {
                    resp = creararchivobat(comando, Application.StartupPath + @"\restaurar.bat");
                    if (resp == true)
                    {
                        Process Ps = new Process();
                        Ps.StartInfo.CreateNoWindow = true;
                        Ps.StartInfo.UseShellExecute = false;
                        Ps.StartInfo.FileName = Application.StartupPath + @"\restaurar.bat";
                        Ps.Start();
                        Ps.WaitForExit();
                        File.Delete(Application.StartupPath + @"\restaurar.bat");
                    }
                    else
                    {
                        MessageBox.Show("Error al tratar de crear el archivo de respaldo.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al restaurar la base de datos.\r\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar la base de datos.\r\n" + ex.Message);
            }
        }

        public bool creararchivobat(string comand, string ruta, string ErrInfo = "")
        {
            bool terminado = false;
            StreamWriter objReader = default(StreamWriter);
            try
            {
                objReader = new StreamWriter(ruta);
                objReader.Write(comand);
                objReader.Close();
                terminado = true;
            }
            catch (Exception Ex)
            {
                ErrInfo = Ex.Message;
            }
            return terminado;
        }

    }
}
