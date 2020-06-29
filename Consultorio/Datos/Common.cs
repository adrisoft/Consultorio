using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Consultorio.Datos
{
    public static class Common
    {
        /// <summary>
        /// Conexión global.
        /// </summary>
        public static MySqlConnection Cnn;

        /// <summary>
        /// Transacción global.
        /// </summary>
        public static MySqlTransaction Transaccion;

        /// <summary>
        /// Hace una peticion "SELECT" contra la base de datos.
        /// </summary>
        /// <param name="SQLString">Peticion SQL</param>
        /// <returns>Devuelve un dataset con los datos devueltos por la petición.</returns>
        public static DataSet Peticion(string SQLString)
        {
            MySqlDataAdapter DA = new MySqlDataAdapter(SQLString, Cnn);
            DataSet DS = new DataSet();
            try
            {
                DA.Fill(DS);
                return DS;
            }
            catch (MySqlException Error)//Aca van detallado segun el numero Error, el error al español
            {
                switch (Error.Number)
                {
                    case 1042:
                        throw new Exception("Ha ocurrido error en la conexión a la base de datos, intente en unos minutos..\r\nDetalles:\r\n" + Error.Message + "\r\nNúmero: " + Error.Number.ToString());
                    default:
                        throw new Exception("Ha ocurrido un error con la base de datos.\r\nDetalles:\r\n" + Error.Message + "\r\nNúmero: " + Error.Number.ToString());
                }
            }
            catch (Exception Error)//Este es un error en general
            {
                throw new Exception("Ha ocurrido un error en la aplicación.\r\nDetalles:\r\n" + Error.Message);
            }
        }

        /// <summary>
        /// Hace una "Insert" o "Update" contra la base de datos. Tambien lo agrega a la tabla "HistorialSQL"
        /// </summary>
        /// <param name="SQLString">"Insert" o "Update" a realizar</param>
        /// <returns>Devuelve true si todo salió bien.</returns>
        public static bool InsertUpdate(string SQLString)
        {
            MySqlCommand ComandoSQL = new MySqlCommand(SQLString, Cnn, Transaccion);
            ComandoSQL.CommandType = CommandType.Text;
            ComandoSQL.Parameters.Clear();
            try
            {
                ComandoSQL.ExecuteNonQuery();
                ComandoSQL.CommandText = "INSERT INTO historial_sql(`SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`,`Nombre_Host_Historial_SQL`) VALUES(\"" + SQLString + "\", NOW(), '" + System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList[0].ToString() + "','" + System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).HostName + "');";
                ComandoSQL.Parameters.Clear();
                ComandoSQL.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException Error)//Aca van detallado segun el numero Error, el error al español
            {
                Transaccion.Rollback();
                switch (Error.Number)
                {
                    case 1042:
                        throw new Exception("Ha ocurrido error en la conexión a la base de datos, intente en unos minutos.\r\nDetalles:\r\n" + Error.Message + "\r\nNúmero: " + Error.Number.ToString());
                    case 1451:
                        throw new Exception("No se puede eliminar este registro porque está siendo usado por otros registros.\r\nDetalles:\r\n" + Error.Message + "\r\nNúmero: " + Error.Number.ToString());
                    default:
                        throw new Exception("Ha ocurrido un error con la base de datos.\r\nDetalles:\r\n" + Error.Message + "\r\nNúmero: " + Error.Number.ToString());
                }
            }
            catch (Exception Error)//Este es un error en general
            {
                Transaccion.Rollback();
                throw new Exception("Ha ocurrido un error en la aplicación.\r\nDetalles:\r\n" + Error.Message);
            }
        }

        /// <summary>
        /// Verifica que la coneccion cerrada, en ese caso la abre. Además inicia una transacción.
        /// </summary>
        public static void AbrirConexion()
        {
            try
            {
                if (Cnn.State == ConnectionState.Open)
                {
                    Cnn.Close();
                    Cnn.Open();
                }
                else
                {
                    Cnn.Open();
                }
                Transaccion = Cnn.BeginTransaction();
            }
            catch (Exception Error)
            {
                throw new Exception("Ha ocurrido un error al intertar abrir la conexión.\r\nDetalles:\r\n" + Error.Message);
            }
        }

        /// <summary>
        /// Prueba la conexion del Objeto Cnn
        /// </summary>
        /// <returns>Devuel true si la conexión se realizó con exito</returns>
        public static bool ProbarCnn()
        {
            try
            {
                Datos.Common.Cnn.Open();
                Datos.Common.Cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Convierte un valor boleano a string
        /// </summary>
        /// <param name="Valor">Valor a convertir</param>
        /// <returns>Valor boleano convertido a string</returns>
        public static string BoolToString(bool Valor)
        {
            if (Valor)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }
    }
}
