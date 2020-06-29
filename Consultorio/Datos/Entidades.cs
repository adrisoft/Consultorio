using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Consultorio.Datos
{
    /// <summary>
    /// Comentarios de la tabla: Se guarda todos las salidas y entradas de la caja en efectiv
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 04:09:28 p.m.
    /// </summary>
    public partial class Caja
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Caja()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Caja</param>
        public Caja(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja"))
            {
                if (DataRowConstructor["Id_Caja"] != DBNull.Value)
                {
                    this.Id_Caja = Convert.ToInt32(DataRowConstructor["Id_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja_Tipo"))
            {
                if (DataRowConstructor["Id_Caja_Tipo"] != DBNull.Value)
                {
                    this.Id_Caja_Tipo = Convert.ToInt32(DataRowConstructor["Id_Caja_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Caja"))
            {
                if (DataRowConstructor["Importe_Caja"] != DBNull.Value)
                {
                    this.Importe_Caja = Convert.ToDecimal(DataRowConstructor["Importe_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Caja"))
            {
                if (DataRowConstructor["Fecha_Caja"] != DBNull.Value)
                {
                    this.Fecha_Caja = Convert.ToDateTime(DataRowConstructor["Fecha_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Remito_Caja"))
            {
                if (DataRowConstructor["Numero_Remito_Caja"] != DBNull.Value)
                {
                    this.Numero_Remito_Caja = Convert.ToInt32(DataRowConstructor["Numero_Remito_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Cuota_Caja"))
            {
                if (DataRowConstructor["Numero_Cuota_Caja"] != DBNull.Value)
                {
                    this.Numero_Cuota_Caja = Convert.ToInt32(DataRowConstructor["Numero_Cuota_Caja"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Tag_Caja"))
            {
                if (DataRowConstructor["Tag_Caja"] != DBNull.Value)
                {
                    this.Tag_Caja = DataRowConstructor["Tag_Caja"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Caja</param>
        public Caja(DataSet DataSetConstructor)
        {
            this.ListaCaja = new List<Caja>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Caja TEMP = new Caja(Fila);
                TEMP.Caja_tipo = new Caja_tipo(Fila);
                this.ListaCaja.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Caja> ListaCaja { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Caja { get; set; }
        /// <summary>
        /// Tipo de caja, define si es entrada o salida
        /// </summary>
        public int Id_Caja_Tipo { get; set; }
        /// <summary>
        /// De cuanto es el movimiento, siempre en pesos
        /// </summary>
        public decimal Importe_Caja { get; set; }
        /// <summary>
        /// Fecha del movimiento
        /// </summary>
        public DateTime Fecha_Caja { get; set; }
        /// <summary>
        /// Numero del remito, si lo tiene
        /// </summary>
        public int Numero_Remito_Caja { get; set; }
        /// <summary>
        /// Numero de cuota de pago del remito
        /// </summary>
        public int Numero_Cuota_Caja { get; set; }
        /// <summary>
        /// Para almacenar datos de la aplicacion
        /// </summary>
        public string Tag_Caja { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Caja_tipo, Para saber que tipo de modificacion se le puede hacer a la c
        /// </summary>
        public Caja_tipo Caja_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla caja.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Caja`, `Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja` FROM caja " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla caja.
        /// </summary>
        /// <param name="Id_Caja">ID de la tabla</param>
        /// <param name="Id_Caja_Tipo">Tipo de caja, define si es entrada o salida</param>
        /// <param name="Importe_Caja">De cuanto es el movimiento, siempre en pesos</param>
        /// <param name="Fecha_Caja">Fecha del movimiento</param>
        /// <param name="Numero_Remito_Caja">Numero del remito, si lo tiene</param>
        /// <param name="Numero_Cuota_Caja">Numero de cuota de pago del remito</param>
        /// <param name="Tag_Caja">Para almacenar datos de la aplicacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Caja, int Id_Caja_Tipo, decimal Importe_Caja, DateTime Fecha_Caja, int Numero_Remito_Caja, int Numero_Cuota_Caja, string Tag_Caja)
        {
            return "INSERT INTO caja(`Id_Caja`, `Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`) VALUES ('" + Id_Caja.ToString() + "', '" + Id_Caja_Tipo.ToString() + "', '" + Importe_Caja.ToString() + "', '" + Fecha_Caja.ToString() + "', '" + Numero_Remito_Caja.ToString() + "', '" + Numero_Cuota_Caja.ToString() + "', '" + Tag_Caja.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla caja.
        /// </summary>
        /// <param name="Id_Caja">ID de la tabla</param>
        /// <param name="Id_Caja_Tipo">Tipo de caja, define si es entrada o salida</param>
        /// <param name="Importe_Caja">De cuanto es el movimiento, siempre en pesos</param>
        /// <param name="Fecha_Caja">Fecha del movimiento</param>
        /// <param name="Numero_Remito_Caja">Numero del remito, si lo tiene</param>
        /// <param name="Numero_Cuota_Caja">Numero de cuota de pago del remito</param>
        /// <param name="Tag_Caja">Para almacenar datos de la aplicacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Caja, int Id_Caja_Tipo, decimal Importe_Caja, DateTime Fecha_Caja, int Numero_Remito_Caja, int Numero_Cuota_Caja, string Tag_Caja, string Filtro)
        {
            return "UPDATE caja SET `Id_Caja` = '" + Id_Caja.ToString() + "', `Id_Caja_Tipo` = '" + Id_Caja_Tipo.ToString() + "', `Importe_Caja` = '" + Importe_Caja.ToString() + "', `Fecha_Caja` = '" + Fecha_Caja.ToString() + "', `Numero_Remito_Caja` = '" + Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` = '" + Numero_Cuota_Caja.ToString() + "', `Tag_Caja` = '" + Tag_Caja.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO caja(`Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`)VALUES( " + "'" + Obj.Id_Caja_Tipo.ToString() + "', " + "'" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', " + "'" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Numero_Remito_Caja.ToString() + "', " + "'" + Obj.Numero_Cuota_Caja.ToString() + "', " + "'" + Obj.Tag_Caja + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE caja SET `Id_Caja_Tipo` =  '" + Obj.Id_Caja_Tipo.ToString() + "', `Importe_Caja` =  '" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', `Fecha_Caja` =  '" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', `Numero_Remito_Caja` =  '" + Obj.Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` =  '" + Obj.Numero_Cuota_Caja.ToString() + "', `Tag_Caja` =  '" + Obj.Tag_Caja + "' WHERE caja.Id_Caja = " + Obj.Id_Caja.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM caja WHERE caja.Id_Caja = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO caja(`Id_Caja_Tipo`, `Importe_Caja`, `Fecha_Caja`, `Numero_Remito_Caja`, `Numero_Cuota_Caja`, `Tag_Caja`)VALUES( " + "'" + Obj.Id_Caja_Tipo.ToString() + "', " + "'" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', " + "'" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Numero_Remito_Caja.ToString() + "', " + "'" + Obj.Numero_Cuota_Caja.ToString() + "', " + "'" + Obj.Tag_Caja + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Caja Obj)
        {
            if (Obj.Fecha_Caja == null)
            {
                throw new Exception("Fecha_Caja no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE caja SET `Id_Caja_Tipo` =  '" + Obj.Id_Caja_Tipo.ToString() + "', `Importe_Caja` =  '" + Obj.Importe_Caja.ToString().Replace(",", ".") + "', `Fecha_Caja` =  '" + Obj.Fecha_Caja.ToString("yyyy-MM-dd HH:mm:ss") + "', `Numero_Remito_Caja` =  '" + Obj.Numero_Remito_Caja.ToString() + "', `Numero_Cuota_Caja` =  '" + Obj.Numero_Cuota_Caja.ToString() + "', `Tag_Caja` =  '" + Obj.Tag_Caja + "' WHERE caja.Id_Caja = " + Obj.Id_Caja.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM caja WHERE caja.Id_Caja = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Para saber que tipo de modificacion se le puede hacer a la c
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 04:10:02 p.m.
    /// </summary>
    public partial class Caja_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Caja_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Caja_tipo</param>
        public Caja_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Caja_Tipo"))
            {
                if (DataRowConstructor["Id_Caja_Tipo"] != DBNull.Value)
                {
                    this.Id_Caja_Tipo = Convert.ToInt32(DataRowConstructor["Id_Caja_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Caja_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Caja_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Caja_Tipo = DataRowConstructor["Descripcion_Caja_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Caja_tipo</param>
        public Caja_tipo(DataSet DataSetConstructor)
        {
            this.ListaCaja_tipo = new List<Caja_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Caja_tipo TEMP = new Caja_tipo(Fila);
                this.ListaCaja_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Caja_tipo> ListaCaja_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Caja_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de caja, con esto se define si es entrada o salida
        /// </summary>
        public string Descripcion_Caja_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla caja_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Caja_Tipo`, `Descripcion_Caja_Tipo` FROM caja_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla caja_tipo.
        /// </summary>
        /// <param name="Id_Caja_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Caja_Tipo">Descripcion del tipo de caja, con esto se define si es entrada o salida</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Caja_Tipo, string Descripcion_Caja_Tipo)
        {
            return "INSERT INTO caja_tipo(`Id_Caja_Tipo`, `Descripcion_Caja_Tipo`) VALUES ('" + Id_Caja_Tipo.ToString() + "', '" + Descripcion_Caja_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla caja_tipo.
        /// </summary>
        /// <param name="Id_Caja_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Caja_Tipo">Descripcion del tipo de caja, con esto se define si es entrada o salida</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Caja_Tipo, string Descripcion_Caja_Tipo, string Filtro)
        {
            return "UPDATE caja_tipo SET `Id_Caja_Tipo` = '" + Id_Caja_Tipo.ToString() + "', `Descripcion_Caja_Tipo` = '" + Descripcion_Caja_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO caja_tipo(`Descripcion_Caja_Tipo`)VALUES( " + "'" + Obj.Descripcion_Caja_Tipo + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE caja_tipo SET `Descripcion_Caja_Tipo` =  '" + Obj.Descripcion_Caja_Tipo + "' WHERE caja_tipo.Id_Caja_Tipo = " + Obj.Id_Caja_Tipo.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM caja_tipo WHERE caja_tipo.Id_Caja_Tipo = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO caja_tipo(`Descripcion_Caja_Tipo`)VALUES( " + "'" + Obj.Descripcion_Caja_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Caja_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Caja_tipo Obj)
        {
            if (Obj.Descripcion_Caja_Tipo == null)
            {
                throw new Exception("Descripcion_Caja_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE caja_tipo SET `Descripcion_Caja_Tipo` =  '" + Obj.Descripcion_Caja_Tipo + "' WHERE caja_tipo.Id_Caja_Tipo = " + Obj.Id_Caja_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Caja_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM caja_tipo WHERE caja_tipo.Id_Caja_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Cheques que entregan como forma de pago los clientes
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:15 p.m.
    /// </summary>
    public partial class Cheque_cartera
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Cheque_cartera()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Cheque_cartera</param>
        public Cheque_cartera(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Cheque_Cartera"))
            {
                if (DataRowConstructor["Id_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Id_Cheque_Cartera = Convert.ToInt32(DataRowConstructor["Id_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Cheque_Cartera"))
            {
                if (DataRowConstructor["Codigo_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Codigo_Cheque_Cartera = DataRowConstructor["Codigo_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Recibo_Cheque_Cartera"))
            {
                if (DataRowConstructor["Numero_Recibo_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Numero_Recibo_Cheque_Cartera = Convert.ToInt32(DataRowConstructor["Numero_Recibo_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Cheque_Cartera"))
            {
                if (DataRowConstructor["Nombre_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Nombre_Cheque_Cartera = DataRowConstructor["Nombre_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Emicion_Cheque_Cartera"))
            {
                if (DataRowConstructor["Fecha_Emicion_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Fecha_Emicion_Cheque_Cartera = Convert.ToDateTime(DataRowConstructor["Fecha_Emicion_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimiento_Cheque_Cartera"))
            {
                if (DataRowConstructor["Fecha_Vencimiento_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Fecha_Vencimiento_Cheque_Cartera = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimiento_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Librador_Cheque_Cartera"))
            {
                if (DataRowConstructor["Nombre_Librador_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Nombre_Librador_Cheque_Cartera = DataRowConstructor["Nombre_Librador_Cheque_Cartera"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Marca_Cheque_Cartera"))
            {
                if (DataRowConstructor["Marca_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Marca_Cheque_Cartera = Convert.ToBoolean(DataRowConstructor["Marca_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Cheque_Cartera"))
            {
                if (DataRowConstructor["Importe_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Importe_Cheque_Cartera = Convert.ToDecimal(DataRowConstructor["Importe_Cheque_Cartera"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Detalle_Cheque_Cartera"))
            {
                if (DataRowConstructor["Detalle_Cheque_Cartera"] != DBNull.Value)
                {
                    this.Detalle_Cheque_Cartera = DataRowConstructor["Detalle_Cheque_Cartera"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Cheque_cartera</param>
        public Cheque_cartera(DataSet DataSetConstructor)
        {
            this.ListaCheque_cartera = new List<Cheque_cartera>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Cheque_cartera TEMP = new Cheque_cartera(Fila);
                TEMP.Localidad = new Localidad(Fila);
                this.ListaCheque_cartera.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Cheque_cartera> ListaCheque_cartera { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Cheque_Cartera { get; set; }
        /// <summary>
        /// Localidad del cheque
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// Numero, codigo del cheque
        /// </summary>
        public string Codigo_Cheque_Cartera { get; set; }
        /// <summary>
        /// Numero de recibo con el que entregaron el cheque
        /// </summary>
        public int Numero_Recibo_Cheque_Cartera { get; set; }
        /// <summary>
        /// Nombre del banco de donde sale el cheque
        /// </summary>
        public string Nombre_Cheque_Cartera { get; set; }
        /// <summary>
        /// Fecha de cuando se emite el cheque
        /// </summary>
        public DateTime Fecha_Emicion_Cheque_Cartera { get; set; }
        /// <summary>
        /// Cuando se vence
        /// </summary>
        public DateTime Fecha_Vencimiento_Cheque_Cartera { get; set; }
        /// <summary>
        /// Nombre del que libera el cheque
        /// </summary>
        public string Nombre_Librador_Cheque_Cartera { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Marca_Cheque_Cartera { get; set; }
        /// <summary>
        /// Importe del cheque
        /// </summary>
        public decimal Importe_Cheque_Cartera { get; set; }
        /// <summary>
        /// Algunos detalles sobre este cheque
        /// </summary>
        public string Detalle_Cheque_Cartera { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Cheque_Cartera`, `Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera` FROM cheque_cartera " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Id_Cheque_Cartera">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad del cheque</param>
        /// <param name="Codigo_Cheque_Cartera">Numero, codigo del cheque</param>
        /// <param name="Numero_Recibo_Cheque_Cartera">Numero de recibo con el que entregaron el cheque</param>
        /// <param name="Nombre_Cheque_Cartera">Nombre del banco de donde sale el cheque</param>
        /// <param name="Fecha_Emicion_Cheque_Cartera">Fecha de cuando se emite el cheque</param>
        /// <param name="Fecha_Vencimiento_Cheque_Cartera">Cuando se vence</param>
        /// <param name="Nombre_Librador_Cheque_Cartera">Nombre del que libera el cheque</param>
        /// <param name="Marca_Cheque_Cartera"></param>
        /// <param name="Importe_Cheque_Cartera">Importe del cheque</param>
        /// <param name="Detalle_Cheque_Cartera">Algunos detalles sobre este cheque</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Cheque_Cartera, int Id_Localidad, string Codigo_Cheque_Cartera, int Numero_Recibo_Cheque_Cartera, string Nombre_Cheque_Cartera, DateTime Fecha_Emicion_Cheque_Cartera, DateTime Fecha_Vencimiento_Cheque_Cartera, string Nombre_Librador_Cheque_Cartera, bool Marca_Cheque_Cartera, decimal Importe_Cheque_Cartera, string Detalle_Cheque_Cartera)
        {
            return "INSERT INTO cheque_cartera(`Id_Cheque_Cartera`, `Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`) VALUES ('" + Id_Cheque_Cartera.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Codigo_Cheque_Cartera.ToString() + "', '" + Numero_Recibo_Cheque_Cartera.ToString() + "', '" + Nombre_Cheque_Cartera.ToString() + "', '" + Fecha_Emicion_Cheque_Cartera.ToString() + "', '" + Fecha_Vencimiento_Cheque_Cartera.ToString() + "', '" + Nombre_Librador_Cheque_Cartera.ToString() + "', '" + Marca_Cheque_Cartera.ToString() + "', '" + Importe_Cheque_Cartera.ToString() + "', '" + Detalle_Cheque_Cartera.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla cheque_cartera.
        /// </summary>
        /// <param name="Id_Cheque_Cartera">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad del cheque</param>
        /// <param name="Codigo_Cheque_Cartera">Numero, codigo del cheque</param>
        /// <param name="Numero_Recibo_Cheque_Cartera">Numero de recibo con el que entregaron el cheque</param>
        /// <param name="Nombre_Cheque_Cartera">Nombre del banco de donde sale el cheque</param>
        /// <param name="Fecha_Emicion_Cheque_Cartera">Fecha de cuando se emite el cheque</param>
        /// <param name="Fecha_Vencimiento_Cheque_Cartera">Cuando se vence</param>
        /// <param name="Nombre_Librador_Cheque_Cartera">Nombre del que libera el cheque</param>
        /// <param name="Marca_Cheque_Cartera"></param>
        /// <param name="Importe_Cheque_Cartera">Importe del cheque</param>
        /// <param name="Detalle_Cheque_Cartera">Algunos detalles sobre este cheque</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Cheque_Cartera, int Id_Localidad, string Codigo_Cheque_Cartera, int Numero_Recibo_Cheque_Cartera, string Nombre_Cheque_Cartera, DateTime Fecha_Emicion_Cheque_Cartera, DateTime Fecha_Vencimiento_Cheque_Cartera, string Nombre_Librador_Cheque_Cartera, bool Marca_Cheque_Cartera, decimal Importe_Cheque_Cartera, string Detalle_Cheque_Cartera, string Filtro)
        {
            return "UPDATE cheque_cartera SET `Id_Cheque_Cartera` = '" + Id_Cheque_Cartera.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` = '" + Codigo_Cheque_Cartera.ToString() + "', `Numero_Recibo_Cheque_Cartera` = '" + Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` = '" + Nombre_Cheque_Cartera.ToString() + "', `Fecha_Emicion_Cheque_Cartera` = '" + Fecha_Emicion_Cheque_Cartera.ToString() + "', `Fecha_Vencimiento_Cheque_Cartera` = '" + Fecha_Vencimiento_Cheque_Cartera.ToString() + "', `Nombre_Librador_Cheque_Cartera` = '" + Nombre_Librador_Cheque_Cartera.ToString() + "', `Marca_Cheque_Cartera` = '" + Marca_Cheque_Cartera.ToString() + "', `Importe_Cheque_Cartera` = '" + Importe_Cheque_Cartera.ToString() + "', `Detalle_Cheque_Cartera` = '" + Detalle_Cheque_Cartera.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO cheque_cartera(`Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Codigo_Cheque_Cartera + "', " + "'" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', " + "'" + Obj.Nombre_Cheque_Cartera + "', " + "'" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Nombre_Librador_Cheque_Cartera + "', " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", " + "'" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', " + "'" + Obj.Detalle_Cheque_Cartera + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE cheque_cartera SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` =  '" + Obj.Codigo_Cheque_Cartera + "', `Numero_Recibo_Cheque_Cartera` =  '" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` =  '" + Obj.Nombre_Cheque_Cartera + "', `Fecha_Emicion_Cheque_Cartera` =  '" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Cheque_Cartera` =  '" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Nombre_Librador_Cheque_Cartera` =  '" + Obj.Nombre_Librador_Cheque_Cartera + "', `Marca_Cheque_Cartera` = " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", `Importe_Cheque_Cartera` =  '" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', `Detalle_Cheque_Cartera` =  '" + Obj.Detalle_Cheque_Cartera + "' WHERE cheque_cartera.Id_Cheque_Cartera = " + Obj.Id_Cheque_Cartera.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Cheque_cartera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM cheque_cartera WHERE cheque_cartera.Id_Cheque_Cartera = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO cheque_cartera(`Id_Localidad`, `Codigo_Cheque_Cartera`, `Numero_Recibo_Cheque_Cartera`, `Nombre_Cheque_Cartera`, `Fecha_Emicion_Cheque_Cartera`, `Fecha_Vencimiento_Cheque_Cartera`, `Nombre_Librador_Cheque_Cartera`, `Marca_Cheque_Cartera`, `Importe_Cheque_Cartera`, `Detalle_Cheque_Cartera`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Codigo_Cheque_Cartera + "', " + "'" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', " + "'" + Obj.Nombre_Cheque_Cartera + "', " + "'" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Nombre_Librador_Cheque_Cartera + "', " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", " + "'" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', " + "'" + Obj.Detalle_Cheque_Cartera + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Cheque_cartera</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Cheque_cartera Obj)
        {
            if (Obj.Codigo_Cheque_Cartera == null)
            {
                throw new Exception("Codigo_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Emicion_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Emicion_Cheque_Cartera no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Cheque_Cartera == null)
            {
                throw new Exception("Fecha_Vencimiento_Cheque_Cartera no puede ser null");
            }
            if (Obj.Nombre_Librador_Cheque_Cartera == null)
            {
                throw new Exception("Nombre_Librador_Cheque_Cartera no puede ser null");
            }
            if (Obj.Detalle_Cheque_Cartera == null)
            {
                throw new Exception("Detalle_Cheque_Cartera no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE cheque_cartera SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Codigo_Cheque_Cartera` =  '" + Obj.Codigo_Cheque_Cartera + "', `Numero_Recibo_Cheque_Cartera` =  '" + Obj.Numero_Recibo_Cheque_Cartera.ToString() + "', `Nombre_Cheque_Cartera` =  '" + Obj.Nombre_Cheque_Cartera + "', `Fecha_Emicion_Cheque_Cartera` =  '" + Obj.Fecha_Emicion_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Cheque_Cartera` =  '" + Obj.Fecha_Vencimiento_Cheque_Cartera.ToString("yyyy-MM-dd HH:mm:ss") + "', `Nombre_Librador_Cheque_Cartera` =  '" + Obj.Nombre_Librador_Cheque_Cartera + "', `Marca_Cheque_Cartera` = " + Common.BoolToString(Obj.Marca_Cheque_Cartera) + ", `Importe_Cheque_Cartera` =  '" + Obj.Importe_Cheque_Cartera.ToString().Replace(",", ".") + "', `Detalle_Cheque_Cartera` =  '" + Obj.Detalle_Cheque_Cartera + "' WHERE cheque_cartera.Id_Cheque_Cartera = " + Obj.Id_Cheque_Cartera.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Cheque_cartera. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM cheque_cartera WHERE cheque_cartera.Id_Cheque_Cartera = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se guardan las consultas medicas
    /// La última modificación fué el martes, 06 de diciembre de 2011 a las 03:17:36 p.m.
    /// </summary>
    public partial class Consulta
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta</param>
        public Consulta(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Motivo_Consulta"))
            {
                if (DataRowConstructor["Motivo_Consulta"] != DBNull.Value)
                {
                    this.Motivo_Consulta = DataRowConstructor["Motivo_Consulta"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Analisis_Visual_Consulta"))
            {
                if (DataRowConstructor["Analisis_Visual_Consulta"] != DBNull.Value)
                {
                    this.Analisis_Visual_Consulta = DataRowConstructor["Analisis_Visual_Consulta"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Evolucion_Consulta"))
            {
                if (DataRowConstructor["Evolucion_Consulta"] != DBNull.Value)
                {
                    this.Evolucion_Consulta = DataRowConstructor["Evolucion_Consulta"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Alta_Medica_Consulta"))
            {
                if (DataRowConstructor["Alta_Medica_Consulta"] != DBNull.Value)
                {
                    this.Alta_Medica_Consulta = DataRowConstructor["Alta_Medica_Consulta"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Consulta"))
            {
                if (DataRowConstructor["Fecha_Consulta"] != DBNull.Value)
                {
                    this.Fecha_Consulta = Convert.ToDateTime(DataRowConstructor["Fecha_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Alta_Consulta"))
            {
                if (DataRowConstructor["Fecha_Alta_Consulta"] != DBNull.Value)
                {
                    this.Fecha_Alta_Consulta = Convert.ToDateTime(DataRowConstructor["Fecha_Alta_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Alta_Consulta"))
            {
                if (DataRowConstructor["Alta_Consulta"] != DBNull.Value)
                {
                    this.Alta_Consulta = Convert.ToBoolean(DataRowConstructor["Alta_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Consulta"))
            {
                if (DataRowConstructor["Observaciones_Consulta"] != DBNull.Value)
                {
                    this.Observaciones_Consulta = DataRowConstructor["Observaciones_Consulta"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta</param>
        public Consulta(DataSet DataSetConstructor)
        {
            this.ListaConsulta = new List<Consulta>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta TEMP = new Consulta(Fila);
                TEMP.Tercero = new Tercero(Fila);
                this.ListaConsulta.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta> ListaConsulta { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// id del tercero al que estara relacionada esta consulta
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Motivo de la consulta
        /// </summary>
        public string Motivo_Consulta { get; set; }
        /// <summary>
        /// Analisis visual de la consulta
        /// </summary>
        public string Analisis_Visual_Consulta { get; set; }
        /// <summary>
        /// Evolucion de la consulta
        /// </summary>
        public string Evolucion_Consulta { get; set; }
        /// <summary>
        /// Detalles del alta medica
        /// </summary>
        public string Alta_Medica_Consulta { get; set; }
        /// <summary>
        /// Fecha en la cual se inicio la consulta
        /// </summary>
        public DateTime Fecha_Consulta { get; set; }
        /// <summary>
        /// Fecha en la que se da de alta un cliente
        /// </summary>
        public DateTime Fecha_Alta_Consulta { get; set; }
        /// <summary>
        /// Es verdadero cuando el paciente tiene un alta medica
        /// </summary>
        public bool Alta_Consulta { get; set; }
        /// <summary>
        /// Observaciones de la consulta
        /// </summary>
        public string Observaciones_Consulta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta`, `Id_Tercero`, `Motivo_Consulta`, `Analisis_Visual_Consulta`, `Evolucion_Consulta`, `Alta_Medica_Consulta`, `Fecha_Consulta`, `Fecha_Alta_Consulta`, `Alta_Consulta`, `Observaciones_Consulta` FROM consulta " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta.
        /// </summary>
        /// <param name="Id_Consulta">Id de la tabla</param>
        /// <param name="Id_Tercero">id del tercero al que estara relacionada esta consulta</param>
        /// <param name="Motivo_Consulta">Motivo de la consulta</param>
        /// <param name="Analisis_Visual_Consulta">Analisis visual de la consulta</param>
        /// <param name="Evolucion_Consulta">Evolucion de la consulta</param>
        /// <param name="Alta_Medica_Consulta">Detalles del alta medica</param>
        /// <param name="Fecha_Consulta">Fecha en la cual se inicio la consulta</param>
        /// <param name="Fecha_Alta_Consulta">Fecha en la que se da de alta un cliente</param>
        /// <param name="Alta_Consulta">Es verdadero cuando el paciente tiene un alta medica</param>
        /// <param name="Observaciones_Consulta">Observaciones de la consulta</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta, int Id_Tercero, string Motivo_Consulta, string Analisis_Visual_Consulta, string Evolucion_Consulta, string Alta_Medica_Consulta, DateTime Fecha_Consulta, DateTime Fecha_Alta_Consulta, bool Alta_Consulta, string Observaciones_Consulta)
        {
            return "INSERT INTO consulta(`Id_Consulta`, `Id_Tercero`, `Motivo_Consulta`, `Analisis_Visual_Consulta`, `Evolucion_Consulta`, `Alta_Medica_Consulta`, `Fecha_Consulta`, `Fecha_Alta_Consulta`, `Alta_Consulta`, `Observaciones_Consulta`) VALUES ('" + Id_Consulta.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Motivo_Consulta.ToString() + "', '" + Analisis_Visual_Consulta.ToString() + "', '" + Evolucion_Consulta.ToString() + "', '" + Alta_Medica_Consulta.ToString() + "', '" + Fecha_Consulta.ToString() + "', '" + Fecha_Alta_Consulta.ToString() + "', '" + Alta_Consulta.ToString() + "', '" + Observaciones_Consulta.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta.
        /// </summary>
        /// <param name="Id_Consulta">Id de la tabla</param>
        /// <param name="Id_Tercero">id del tercero al que estara relacionada esta consulta</param>
        /// <param name="Motivo_Consulta">Motivo de la consulta</param>
        /// <param name="Analisis_Visual_Consulta">Analisis visual de la consulta</param>
        /// <param name="Evolucion_Consulta">Evolucion de la consulta</param>
        /// <param name="Alta_Medica_Consulta">Detalles del alta medica</param>
        /// <param name="Fecha_Consulta">Fecha en la cual se inicio la consulta</param>
        /// <param name="Fecha_Alta_Consulta">Fecha en la que se da de alta un cliente</param>
        /// <param name="Alta_Consulta">Es verdadero cuando el paciente tiene un alta medica</param>
        /// <param name="Observaciones_Consulta">Observaciones de la consulta</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta, int Id_Tercero, string Motivo_Consulta, string Analisis_Visual_Consulta, string Evolucion_Consulta, string Alta_Medica_Consulta, DateTime Fecha_Consulta, DateTime Fecha_Alta_Consulta, bool Alta_Consulta, string Observaciones_Consulta, string Filtro)
        {
            return "UPDATE consulta SET `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Motivo_Consulta` = '" + Motivo_Consulta.ToString() + "', `Analisis_Visual_Consulta` = '" + Analisis_Visual_Consulta.ToString() + "', `Evolucion_Consulta` = '" + Evolucion_Consulta.ToString() + "', `Alta_Medica_Consulta` = '" + Alta_Medica_Consulta.ToString() + "', `Fecha_Consulta` = '" + Fecha_Consulta.ToString() + "', `Fecha_Alta_Consulta` = '" + Fecha_Alta_Consulta.ToString() + "', `Alta_Consulta` = '" + Alta_Consulta.ToString() + "', `Observaciones_Consulta` = '" + Observaciones_Consulta.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta Obj)
        {
            if (Obj.Motivo_Consulta == null)
            {
                throw new Exception("Motivo_Consulta no puede ser null");
            }
            if (Obj.Analisis_Visual_Consulta == null)
            {
                throw new Exception("Analisis_Visual_Consulta no puede ser null");
            }
            if (Obj.Evolucion_Consulta == null)
            {
                throw new Exception("Evolucion_Consulta no puede ser null");
            }
            if (Obj.Alta_Medica_Consulta == null)
            {
                throw new Exception("Alta_Medica_Consulta no puede ser null");
            }
            if (Obj.Fecha_Consulta == null)
            {
                throw new Exception("Fecha_Consulta no puede ser null");
            }
            if (Obj.Fecha_Alta_Consulta == null)
            {
                throw new Exception("Fecha_Alta_Consulta no puede ser null");
            }
            if (Obj.Observaciones_Consulta == null)
            {
                throw new Exception("Observaciones_Consulta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta(`Id_Tercero`, `Motivo_Consulta`, `Analisis_Visual_Consulta`, `Evolucion_Consulta`, `Alta_Medica_Consulta`, `Fecha_Consulta`, `Fecha_Alta_Consulta`, `Alta_Consulta`, `Observaciones_Consulta`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Motivo_Consulta + "', " + "'" + Obj.Analisis_Visual_Consulta + "', " + "'" + Obj.Evolucion_Consulta + "', " + "'" + Obj.Alta_Medica_Consulta + "', " + "'" + Obj.Fecha_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Alta_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Alta_Consulta) + ", " + "'" + Obj.Observaciones_Consulta + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta Obj)
        {
            if (Obj.Motivo_Consulta == null)
            {
                throw new Exception("Motivo_Consulta no puede ser null");
            }
            if (Obj.Analisis_Visual_Consulta == null)
            {
                throw new Exception("Analisis_Visual_Consulta no puede ser null");
            }
            if (Obj.Evolucion_Consulta == null)
            {
                throw new Exception("Evolucion_Consulta no puede ser null");
            }
            if (Obj.Alta_Medica_Consulta == null)
            {
                throw new Exception("Alta_Medica_Consulta no puede ser null");
            }
            if (Obj.Fecha_Consulta == null)
            {
                throw new Exception("Fecha_Consulta no puede ser null");
            }
            if (Obj.Fecha_Alta_Consulta == null)
            {
                throw new Exception("Fecha_Alta_Consulta no puede ser null");
            }
            if (Obj.Observaciones_Consulta == null)
            {
                throw new Exception("Observaciones_Consulta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Motivo_Consulta` =  '" + Obj.Motivo_Consulta + "', `Analisis_Visual_Consulta` =  '" + Obj.Analisis_Visual_Consulta + "', `Evolucion_Consulta` =  '" + Obj.Evolucion_Consulta + "', `Alta_Medica_Consulta` =  '" + Obj.Alta_Medica_Consulta + "', `Fecha_Consulta` =  '" + Obj.Fecha_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Alta_Consulta` =  '" + Obj.Fecha_Alta_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Alta_Consulta` = " + Common.BoolToString(Obj.Alta_Consulta) + ", `Observaciones_Consulta` =  '" + Obj.Observaciones_Consulta + "' WHERE consulta.Id_Consulta = " + Obj.Id_Consulta.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta WHERE consulta.Id_Consulta = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta Obj)
        {
            if (Obj.Motivo_Consulta == null)
            {
                throw new Exception("Motivo_Consulta no puede ser null");
            }
            if (Obj.Analisis_Visual_Consulta == null)
            {
                throw new Exception("Analisis_Visual_Consulta no puede ser null");
            }
            if (Obj.Evolucion_Consulta == null)
            {
                throw new Exception("Evolucion_Consulta no puede ser null");
            }
            if (Obj.Alta_Medica_Consulta == null)
            {
                throw new Exception("Alta_Medica_Consulta no puede ser null");
            }
            if (Obj.Fecha_Consulta == null)
            {
                throw new Exception("Fecha_Consulta no puede ser null");
            }
            if (Obj.Fecha_Alta_Consulta == null)
            {
                throw new Exception("Fecha_Alta_Consulta no puede ser null");
            }
            if (Obj.Observaciones_Consulta == null)
            {
                throw new Exception("Observaciones_Consulta no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO consulta(`Id_Tercero`, `Motivo_Consulta`, `Analisis_Visual_Consulta`, `Evolucion_Consulta`, `Alta_Medica_Consulta`, `Fecha_Consulta`, `Fecha_Alta_Consulta`, `Alta_Consulta`, `Observaciones_Consulta`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Motivo_Consulta + "', " + "'" + Obj.Analisis_Visual_Consulta + "', " + "'" + Obj.Evolucion_Consulta + "', " + "'" + Obj.Alta_Medica_Consulta + "', " + "'" + Obj.Fecha_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Alta_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Alta_Consulta) + ", " + "'" + Obj.Observaciones_Consulta + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta Obj)
        {
            if (Obj.Motivo_Consulta == null)
            {
                throw new Exception("Motivo_Consulta no puede ser null");
            }
            if (Obj.Analisis_Visual_Consulta == null)
            {
                throw new Exception("Analisis_Visual_Consulta no puede ser null");
            }
            if (Obj.Evolucion_Consulta == null)
            {
                throw new Exception("Evolucion_Consulta no puede ser null");
            }
            if (Obj.Alta_Medica_Consulta == null)
            {
                throw new Exception("Alta_Medica_Consulta no puede ser null");
            }
            if (Obj.Fecha_Consulta == null)
            {
                throw new Exception("Fecha_Consulta no puede ser null");
            }
            if (Obj.Fecha_Alta_Consulta == null)
            {
                throw new Exception("Fecha_Alta_Consulta no puede ser null");
            }
            if (Obj.Observaciones_Consulta == null)
            {
                throw new Exception("Observaciones_Consulta no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE consulta SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Motivo_Consulta` =  '" + Obj.Motivo_Consulta + "', `Analisis_Visual_Consulta` =  '" + Obj.Analisis_Visual_Consulta + "', `Evolucion_Consulta` =  '" + Obj.Evolucion_Consulta + "', `Alta_Medica_Consulta` =  '" + Obj.Alta_Medica_Consulta + "', `Fecha_Consulta` =  '" + Obj.Fecha_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Alta_Consulta` =  '" + Obj.Fecha_Alta_Consulta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Alta_Consulta` = " + Common.BoolToString(Obj.Alta_Consulta) + ", `Observaciones_Consulta` =  '" + Obj.Observaciones_Consulta + "' WHERE consulta.Id_Consulta = " + Obj.Id_Consulta.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta WHERE consulta.Id_Consulta = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se guarda el diagnostico de la consulta
    /// La última modificación fué el lunes, 05 de diciembre de 2011 a las 11:48:09 a.m.
    /// </summary>
    public partial class Consulta_enfermedad
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_enfermedad()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_enfermedad</param>
        public Consulta_enfermedad(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Enfermedad"))
            {
                if (DataRowConstructor["Id_Consulta_Enfermedad"] != DBNull.Value)
                {
                    this.Id_Consulta_Enfermedad = Convert.ToInt32(DataRowConstructor["Id_Consulta_Enfermedad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Enfermedad"))
            {
                if (DataRowConstructor["Id_Enfermedad"] != DBNull.Value)
                {
                    this.Id_Enfermedad = Convert.ToInt32(DataRowConstructor["Id_Enfermedad"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_enfermedad</param>
        public Consulta_enfermedad(DataSet DataSetConstructor)
        {
            this.ListaConsulta_enfermedad = new List<Consulta_enfermedad>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_enfermedad TEMP = new Consulta_enfermedad(Fila);
                TEMP.Consulta = new Consulta(Fila);
                TEMP.Enfermedad = new Enfermedad(Fila);
                this.ListaConsulta_enfermedad.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_enfermedad> ListaConsulta_enfermedad { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Enfermedad { get; set; }
        /// <summary>
        /// Id de la consulta conrrespondiente
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// Id de la enfermedad, diagnostico de la consulta
        /// </summary>
        public int Id_Enfermedad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Enfermedad, Se guardan las enfermedades, los datos iniciales se sacaron de: CLASIFICACION ESTADISTICA INTERNACIONAL DE ENFERMEDADES Y PROBLEMAS RELACIONADOS CON LA SALUD. DECIMA REVISION. - CIE 10- CODIGOS Y DESCRIPCION A TRES Y CUATRO DIGITOS.
        /// </summary>
        public Enfermedad Enfermedad { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_enfermedad.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Enfermedad`, `Id_Consulta`, `Id_Enfermedad` FROM consulta_enfermedad " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_enfermedad.
        /// </summary>
        /// <param name="Id_Consulta_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Enfermedad">Id de la enfermedad, diagnostico de la consulta</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Enfermedad, int Id_Consulta, int Id_Enfermedad)
        {
            return "INSERT INTO consulta_enfermedad(`Id_Consulta_Enfermedad`, `Id_Consulta`, `Id_Enfermedad`) VALUES ('" + Id_Consulta_Enfermedad.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Id_Enfermedad.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_enfermedad.
        /// </summary>
        /// <param name="Id_Consulta_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Enfermedad">Id de la enfermedad, diagnostico de la consulta</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Enfermedad, int Id_Consulta, int Id_Enfermedad, string Filtro)
        {
            return "UPDATE consulta_enfermedad SET `Id_Consulta_Enfermedad` = '" + Id_Consulta_Enfermedad.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Id_Enfermedad` = '" + Id_Enfermedad.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_enfermedad Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_enfermedad(`Id_Consulta`, `Id_Enfermedad`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Enfermedad.ToString() + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_enfermedad Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_enfermedad SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Enfermedad` =  '" + Obj.Id_Enfermedad.ToString() + "' WHERE consulta_enfermedad.Id_Consulta_Enfermedad = " + Obj.Id_Consulta_Enfermedad.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_enfermedad.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_enfermedad WHERE consulta_enfermedad.Id_Consulta_Enfermedad = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_enfermedad Obj)
        {
            if (Common.InsertUpdate("INSERT INTO consulta_enfermedad(`Id_Consulta`, `Id_Enfermedad`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Enfermedad.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_enfermedad Obj)
        {
            if (Common.InsertUpdate("UPDATE consulta_enfermedad SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Enfermedad` =  '" + Obj.Id_Enfermedad.ToString() + "' WHERE consulta_enfermedad.Id_Consulta_Enfermedad = " + Obj.Id_Consulta_Enfermedad.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_enfermedad WHERE consulta_enfermedad.Id_Consulta_Enfermedad = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: asignaciones de estudios a las consultas
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:15 p.m.
    /// </summary>
    public partial class Consulta_estudio
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_estudio()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_estudio</param>
        public Consulta_estudio(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Estudio"))
            {
                if (DataRowConstructor["Id_Consulta_Estudio"] != DBNull.Value)
                {
                    this.Id_Consulta_Estudio = Convert.ToInt32(DataRowConstructor["Id_Consulta_Estudio"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Estudio"))
            {
                if (DataRowConstructor["Id_Estudio"] != DBNull.Value)
                {
                    this.Id_Estudio = Convert.ToInt32(DataRowConstructor["Id_Estudio"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_estudio</param>
        public Consulta_estudio(DataSet DataSetConstructor)
        {
            this.ListaConsulta_estudio = new List<Consulta_estudio>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_estudio TEMP = new Consulta_estudio(Fila);
                TEMP.Consulta = new Consulta(Fila);
                TEMP.Estudio = new Estudio(Fila);
                this.ListaConsulta_estudio.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_estudio> ListaConsulta_estudio { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Estudio { get; set; }
        /// <summary>
        /// Consulta a la que se le va a asisganar un estudio
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// Estudio asignado a la consulta anterior
        /// </summary>
        public int Id_Estudio { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Estudio, En esta tabla se encuentran los estudios
        /// </summary>
        public Estudio Estudio { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_estudio.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Estudio`, `Id_Consulta`, `Id_Estudio` FROM consulta_estudio " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_estudio.
        /// </summary>
        /// <param name="Id_Consulta_Estudio">Id de la tabla</param>
        /// <param name="Id_Consulta">Consulta a la que se le va a asisganar un estudio</param>
        /// <param name="Id_Estudio">Estudio asignado a la consulta anterior</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Estudio, int Id_Consulta, int Id_Estudio)
        {
            return "INSERT INTO consulta_estudio(`Id_Consulta_Estudio`, `Id_Consulta`, `Id_Estudio`) VALUES ('" + Id_Consulta_Estudio.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Id_Estudio.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_estudio.
        /// </summary>
        /// <param name="Id_Consulta_Estudio">Id de la tabla</param>
        /// <param name="Id_Consulta">Consulta a la que se le va a asisganar un estudio</param>
        /// <param name="Id_Estudio">Estudio asignado a la consulta anterior</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Estudio, int Id_Consulta, int Id_Estudio, string Filtro)
        {
            return "UPDATE consulta_estudio SET `Id_Consulta_Estudio` = '" + Id_Consulta_Estudio.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Id_Estudio` = '" + Id_Estudio.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_estudio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_estudio Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_estudio(`Id_Consulta`, `Id_Estudio`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Estudio.ToString() + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_estudio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_estudio Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_estudio SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Estudio` =  '" + Obj.Id_Estudio.ToString() + "' WHERE consulta_estudio.Id_Consulta_Estudio = " + Obj.Id_Consulta_Estudio.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_estudio.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_estudio WHERE consulta_estudio.Id_Consulta_Estudio = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_estudio Obj)
        {
            if (Common.InsertUpdate("INSERT INTO consulta_estudio(`Id_Consulta`, `Id_Estudio`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Estudio.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_estudio Obj)
        {
            if (Common.InsertUpdate("UPDATE consulta_estudio SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Estudio` =  '" + Obj.Id_Estudio.ToString() + "' WHERE consulta_estudio.Id_Consulta_Estudio = " + Obj.Id_Consulta_Estudio.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_estudio WHERE consulta_estudio.Id_Consulta_Estudio = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se guardan las imagenes de las consulta
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:15 p.m.
    /// </summary>
    public partial class Consulta_imagenes
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_imagenes()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_imagenes</param>
        public Consulta_imagenes(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Imagenes"))
            {
                if (DataRowConstructor["Id_Consulta_Imagenes"] != DBNull.Value)
                {
                    this.Id_Consulta_Imagenes = Convert.ToInt32(DataRowConstructor["Id_Consulta_Imagenes"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Imagen_Consulta_Imagenes"))
            {
                if (DataRowConstructor["Imagen_Consulta_Imagenes"] != DBNull.Value)
                {
                    this.Imagen_Consulta_Imagenes = DataRowConstructor["Imagen_Consulta_Imagenes"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Consulta_Imagenes"))
            {
                if (DataRowConstructor["Observaciones_Consulta_Imagenes"] != DBNull.Value)
                {
                    this.Observaciones_Consulta_Imagenes = DataRowConstructor["Observaciones_Consulta_Imagenes"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_imagenes</param>
        public Consulta_imagenes(DataSet DataSetConstructor)
        {
            this.ListaConsulta_imagenes = new List<Consulta_imagenes>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_imagenes TEMP = new Consulta_imagenes(Fila);
                TEMP.Consulta = new Consulta(Fila);
                this.ListaConsulta_imagenes.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_imagenes> ListaConsulta_imagenes { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Imagenes { get; set; }
        /// <summary>
        /// Id de la consulta conrrespondiente
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// Nombre de una imagen y su extencion
        /// </summary>
        public string Imagen_Consulta_Imagenes { get; set; }
        /// <summary>
        /// Observaciones de la imagen
        /// </summary>
        public string Observaciones_Consulta_Imagenes { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_imagenes.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Imagenes`, `Id_Consulta`, `Imagen_Consulta_Imagenes`, `Observaciones_Consulta_Imagenes` FROM consulta_imagenes " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_imagenes.
        /// </summary>
        /// <param name="Id_Consulta_Imagenes">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Imagen_Consulta_Imagenes">Nombre de una imagen y su extencion</param>
        /// <param name="Observaciones_Consulta_Imagenes">Observaciones de la imagen</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Imagenes, int Id_Consulta, string Imagen_Consulta_Imagenes, string Observaciones_Consulta_Imagenes)
        {
            return "INSERT INTO consulta_imagenes(`Id_Consulta_Imagenes`, `Id_Consulta`, `Imagen_Consulta_Imagenes`, `Observaciones_Consulta_Imagenes`) VALUES ('" + Id_Consulta_Imagenes.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Imagen_Consulta_Imagenes.ToString() + "', '" + Observaciones_Consulta_Imagenes.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_imagenes.
        /// </summary>
        /// <param name="Id_Consulta_Imagenes">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Imagen_Consulta_Imagenes">Nombre de una imagen y su extencion</param>
        /// <param name="Observaciones_Consulta_Imagenes">Observaciones de la imagen</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Imagenes, int Id_Consulta, string Imagen_Consulta_Imagenes, string Observaciones_Consulta_Imagenes, string Filtro)
        {
            return "UPDATE consulta_imagenes SET `Id_Consulta_Imagenes` = '" + Id_Consulta_Imagenes.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Imagen_Consulta_Imagenes` = '" + Imagen_Consulta_Imagenes.ToString() + "', `Observaciones_Consulta_Imagenes` = '" + Observaciones_Consulta_Imagenes.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_imagenes.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_imagenes</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_imagenes Obj)
        {
            if (Obj.Imagen_Consulta_Imagenes == null)
            {
                throw new Exception("Imagen_Consulta_Imagenes no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Imagenes == null)
            {
                throw new Exception("Observaciones_Consulta_Imagenes no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_imagenes(`Id_Consulta`, `Imagen_Consulta_Imagenes`, `Observaciones_Consulta_Imagenes`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Imagen_Consulta_Imagenes + "', " + "'" + Obj.Observaciones_Consulta_Imagenes + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_imagenes.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_imagenes</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_imagenes Obj)
        {
            if (Obj.Imagen_Consulta_Imagenes == null)
            {
                throw new Exception("Imagen_Consulta_Imagenes no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Imagenes == null)
            {
                throw new Exception("Observaciones_Consulta_Imagenes no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_imagenes SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Imagen_Consulta_Imagenes` =  '" + Obj.Imagen_Consulta_Imagenes + "', `Observaciones_Consulta_Imagenes` =  '" + Obj.Observaciones_Consulta_Imagenes + "' WHERE consulta_imagenes.Id_Consulta_Imagenes = " + Obj.Id_Consulta_Imagenes.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_imagenes.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_imagenes WHERE consulta_imagenes.Id_Consulta_Imagenes = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_imagenes. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_imagenes</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_imagenes Obj)
        {
            if (Obj.Imagen_Consulta_Imagenes == null)
            {
                throw new Exception("Imagen_Consulta_Imagenes no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Imagenes == null)
            {
                throw new Exception("Observaciones_Consulta_Imagenes no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO consulta_imagenes(`Id_Consulta`, `Imagen_Consulta_Imagenes`, `Observaciones_Consulta_Imagenes`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Imagen_Consulta_Imagenes + "', " + "'" + Obj.Observaciones_Consulta_Imagenes + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_imagenes. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_imagenes</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_imagenes Obj)
        {
            if (Obj.Imagen_Consulta_Imagenes == null)
            {
                throw new Exception("Imagen_Consulta_Imagenes no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Imagenes == null)
            {
                throw new Exception("Observaciones_Consulta_Imagenes no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE consulta_imagenes SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Imagen_Consulta_Imagenes` =  '" + Obj.Imagen_Consulta_Imagenes + "', `Observaciones_Consulta_Imagenes` =  '" + Obj.Observaciones_Consulta_Imagenes + "' WHERE consulta_imagenes.Id_Consulta_Imagenes = " + Obj.Id_Consulta_Imagenes.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_imagenes. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_imagenes WHERE consulta_imagenes.Id_Consulta_Imagenes = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Medicamentos que tiene una consulta
    /// La última modificación fué el lunes, 05 de diciembre de 2011 a las 11:48:47 a.m.
    /// </summary>
    public partial class Consulta_medicacion
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_medicacion()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_medicacion</param>
        public Consulta_medicacion(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Medicacion"))
            {
                if (DataRowConstructor["Id_Consulta_Medicacion"] != DBNull.Value)
                {
                    this.Id_Consulta_Medicacion = Convert.ToInt32(DataRowConstructor["Id_Consulta_Medicacion"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion"))
            {
                if (DataRowConstructor["Id_Medicacion"] != DBNull.Value)
                {
                    this.Id_Medicacion = Convert.ToInt32(DataRowConstructor["Id_Medicacion"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_medicacion</param>
        public Consulta_medicacion(DataSet DataSetConstructor)
        {
            this.ListaConsulta_medicacion = new List<Consulta_medicacion>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_medicacion TEMP = new Consulta_medicacion(Fila);
                TEMP.Consulta = new Consulta(Fila);
                TEMP.Medicacion = new Medicacion(Fila);
                this.ListaConsulta_medicacion.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_medicacion> ListaConsulta_medicacion { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Medicacion { get; set; }
        /// <summary>
        /// Id de la consulta conrrespondiente
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// Medicacamentos asignados a una consulta
        /// </summary>
        public int Id_Medicacion { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Medicacion, En esta tabla se guardan los medicamentos
        /// </summary>
        public Medicacion Medicacion { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_medicacion.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Medicacion`, `Id_Consulta`, `Id_Medicacion` FROM consulta_medicacion " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_medicacion.
        /// </summary>
        /// <param name="Id_Consulta_Medicacion">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Medicacion">Medicacamentos asignados a una consulta</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Medicacion, int Id_Consulta, int Id_Medicacion)
        {
            return "INSERT INTO consulta_medicacion(`Id_Consulta_Medicacion`, `Id_Consulta`, `Id_Medicacion`) VALUES ('" + Id_Consulta_Medicacion.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Id_Medicacion.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_medicacion.
        /// </summary>
        /// <param name="Id_Consulta_Medicacion">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Medicacion">Medicacamentos asignados a una consulta</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Medicacion, int Id_Consulta, int Id_Medicacion, string Filtro)
        {
            return "UPDATE consulta_medicacion SET `Id_Consulta_Medicacion` = '" + Id_Consulta_Medicacion.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Id_Medicacion` = '" + Id_Medicacion.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_medicacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_medicacion Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_medicacion(`Id_Consulta`, `Id_Medicacion`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Medicacion.ToString() + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_medicacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_medicacion Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_medicacion SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Medicacion` =  '" + Obj.Id_Medicacion.ToString() + "' WHERE consulta_medicacion.Id_Consulta_Medicacion = " + Obj.Id_Consulta_Medicacion.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_medicacion.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_medicacion WHERE consulta_medicacion.Id_Consulta_Medicacion = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_medicacion Obj)
        {
            if (Common.InsertUpdate("INSERT INTO consulta_medicacion(`Id_Consulta`, `Id_Medicacion`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Medicacion.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_medicacion Obj)
        {
            if (Common.InsertUpdate("UPDATE consulta_medicacion SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Medicacion` =  '" + Obj.Id_Medicacion.ToString() + "' WHERE consulta_medicacion.Id_Consulta_Medicacion = " + Obj.Id_Consulta_Medicacion.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_medicacion WHERE consulta_medicacion.Id_Consulta_Medicacion = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: asignaciones de tratamientos a las consultas
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:15 p.m.
    /// </summary>
    public partial class Consulta_tratamiento
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_tratamiento()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_tratamiento</param>
        public Consulta_tratamiento(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Tratamiento"))
            {
                if (DataRowConstructor["Id_Consulta_Tratamiento"] != DBNull.Value)
                {
                    this.Id_Consulta_Tratamiento = Convert.ToInt32(DataRowConstructor["Id_Consulta_Tratamiento"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tratamiento"))
            {
                if (DataRowConstructor["Id_Tratamiento"] != DBNull.Value)
                {
                    this.Id_Tratamiento = Convert.ToInt32(DataRowConstructor["Id_Tratamiento"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_tratamiento</param>
        public Consulta_tratamiento(DataSet DataSetConstructor)
        {
            this.ListaConsulta_tratamiento = new List<Consulta_tratamiento>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_tratamiento TEMP = new Consulta_tratamiento(Fila);
                TEMP.Consulta = new Consulta(Fila);
                TEMP.Tratamiento = new Tratamiento(Fila);
                this.ListaConsulta_tratamiento.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_tratamiento> ListaConsulta_tratamiento { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Tratamiento { get; set; }
        /// <summary>
        /// Id de la consulta conrrespondiente
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// id del tratamiento que se le va a asignar
        /// </summary>
        public int Id_Tratamiento { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tratamiento, En esta tabla se encuentran los tratamientos
        /// </summary>
        public Tratamiento Tratamiento { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_tratamiento.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Tratamiento`, `Id_Consulta`, `Id_Tratamiento` FROM consulta_tratamiento " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_tratamiento.
        /// </summary>
        /// <param name="Id_Consulta_Tratamiento">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Tratamiento">id del tratamiento que se le va a asignar</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Tratamiento, int Id_Consulta, int Id_Tratamiento)
        {
            return "INSERT INTO consulta_tratamiento(`Id_Consulta_Tratamiento`, `Id_Consulta`, `Id_Tratamiento`) VALUES ('" + Id_Consulta_Tratamiento.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Id_Tratamiento.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_tratamiento.
        /// </summary>
        /// <param name="Id_Consulta_Tratamiento">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Id_Tratamiento">id del tratamiento que se le va a asignar</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Tratamiento, int Id_Consulta, int Id_Tratamiento, string Filtro)
        {
            return "UPDATE consulta_tratamiento SET `Id_Consulta_Tratamiento` = '" + Id_Consulta_Tratamiento.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Id_Tratamiento` = '" + Id_Tratamiento.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_tratamiento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_tratamiento Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_tratamiento(`Id_Consulta`, `Id_Tratamiento`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Tratamiento.ToString() + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_tratamiento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_tratamiento Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_tratamiento SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Tratamiento` =  '" + Obj.Id_Tratamiento.ToString() + "' WHERE consulta_tratamiento.Id_Consulta_Tratamiento = " + Obj.Id_Consulta_Tratamiento.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_tratamiento.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_tratamiento WHERE consulta_tratamiento.Id_Consulta_Tratamiento = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_tratamiento Obj)
        {
            if (Common.InsertUpdate("INSERT INTO consulta_tratamiento(`Id_Consulta`, `Id_Tratamiento`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Id_Tratamiento.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_tratamiento Obj)
        {
            if (Common.InsertUpdate("UPDATE consulta_tratamiento SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Id_Tratamiento` =  '" + Obj.Id_Tratamiento.ToString() + "' WHERE consulta_tratamiento.Id_Consulta_Tratamiento = " + Obj.Id_Consulta_Tratamiento.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_tratamiento WHERE consulta_tratamiento.Id_Consulta_Tratamiento = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se guardan las visitas que tubo una consulta
    /// La última modificación fué el miércoles, 07 de diciembre de 2011 a las 12:36:35 p.m.
    /// </summary>
    public partial class Consulta_visita
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Consulta_visita()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Consulta_visita</param>
        public Consulta_visita(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta_Visita"))
            {
                if (DataRowConstructor["Id_Consulta_Visita"] != DBNull.Value)
                {
                    this.Id_Consulta_Visita = Convert.ToInt32(DataRowConstructor["Id_Consulta_Visita"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Consulta"))
            {
                if (DataRowConstructor["Id_Consulta"] != DBNull.Value)
                {
                    this.Id_Consulta = Convert.ToInt32(DataRowConstructor["Id_Consulta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Consulta_Visita"))
            {
                if (DataRowConstructor["Fecha_Consulta_Visita"] != DBNull.Value)
                {
                    this.Fecha_Consulta_Visita = Convert.ToDateTime(DataRowConstructor["Fecha_Consulta_Visita"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Consulta_Visita"))
            {
                if (DataRowConstructor["Observaciones_Consulta_Visita"] != DBNull.Value)
                {
                    this.Observaciones_Consulta_Visita = DataRowConstructor["Observaciones_Consulta_Visita"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Consulta_visita</param>
        public Consulta_visita(DataSet DataSetConstructor)
        {
            this.ListaConsulta_visita = new List<Consulta_visita>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Consulta_visita TEMP = new Consulta_visita(Fila);
                TEMP.Consulta = new Consulta(Fila);
                this.ListaConsulta_visita.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Consulta_visita> ListaConsulta_visita { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Consulta_Visita { get; set; }
        /// <summary>
        /// Id de la consulta conrrespondiente
        /// </summary>
        public int Id_Consulta { get; set; }
        /// <summary>
        /// Fecha en que se realiza la visita
        /// </summary>
        public DateTime Fecha_Consulta_Visita { get; set; }
        /// <summary>
        /// Observaciones de la visita
        /// </summary>
        public string Observaciones_Consulta_Visita { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Consulta, En esta tabla se guardan las consultas medicas
        /// </summary>
        public Consulta Consulta { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla consulta_visita.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Consulta_Visita`, `Id_Consulta`, `Fecha_Consulta_Visita`, `Observaciones_Consulta_Visita` FROM consulta_visita " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla consulta_visita.
        /// </summary>
        /// <param name="Id_Consulta_Visita">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Fecha_Consulta_Visita">Fecha en que se realiza la visita</param>
        /// <param name="Observaciones_Consulta_Visita">Observaciones de la visita</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Consulta_Visita, int Id_Consulta, DateTime Fecha_Consulta_Visita, string Observaciones_Consulta_Visita)
        {
            return "INSERT INTO consulta_visita(`Id_Consulta_Visita`, `Id_Consulta`, `Fecha_Consulta_Visita`, `Observaciones_Consulta_Visita`) VALUES ('" + Id_Consulta_Visita.ToString() + "', '" + Id_Consulta.ToString() + "', '" + Fecha_Consulta_Visita.ToString() + "', '" + Observaciones_Consulta_Visita.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla consulta_visita.
        /// </summary>
        /// <param name="Id_Consulta_Visita">Id de la tabla</param>
        /// <param name="Id_Consulta">Id de la consulta conrrespondiente</param>
        /// <param name="Fecha_Consulta_Visita">Fecha en que se realiza la visita</param>
        /// <param name="Observaciones_Consulta_Visita">Observaciones de la visita</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Consulta_Visita, int Id_Consulta, DateTime Fecha_Consulta_Visita, string Observaciones_Consulta_Visita, string Filtro)
        {
            return "UPDATE consulta_visita SET `Id_Consulta_Visita` = '" + Id_Consulta_Visita.ToString() + "', `Id_Consulta` = '" + Id_Consulta.ToString() + "', `Fecha_Consulta_Visita` = '" + Fecha_Consulta_Visita.ToString() + "', `Observaciones_Consulta_Visita` = '" + Observaciones_Consulta_Visita.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_visita.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_visita</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Consulta_visita Obj)
        {
            if (Obj.Fecha_Consulta_Visita == null)
            {
                throw new Exception("Fecha_Consulta_Visita no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Visita == null)
            {
                throw new Exception("Observaciones_Consulta_Visita no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO consulta_visita(`Id_Consulta`, `Fecha_Consulta_Visita`, `Observaciones_Consulta_Visita`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Fecha_Consulta_Visita.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Consulta_Visita + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_visita.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_visita</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Consulta_visita Obj)
        {
            if (Obj.Fecha_Consulta_Visita == null)
            {
                throw new Exception("Fecha_Consulta_Visita no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Visita == null)
            {
                throw new Exception("Observaciones_Consulta_Visita no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE consulta_visita SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Fecha_Consulta_Visita` =  '" + Obj.Fecha_Consulta_Visita.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Consulta_Visita` =  '" + Obj.Observaciones_Consulta_Visita + "' WHERE consulta_visita.Id_Consulta_Visita = " + Obj.Id_Consulta_Visita.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_visita.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM consulta_visita WHERE consulta_visita.Id_Consulta_Visita = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Consulta_visita. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_visita</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Consulta_visita Obj)
        {
            if (Obj.Fecha_Consulta_Visita == null)
            {
                throw new Exception("Fecha_Consulta_Visita no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Visita == null)
            {
                throw new Exception("Observaciones_Consulta_Visita no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO consulta_visita(`Id_Consulta`, `Fecha_Consulta_Visita`, `Observaciones_Consulta_Visita`)VALUES( " + "'" + Obj.Id_Consulta.ToString() + "', " + "'" + Obj.Fecha_Consulta_Visita.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Consulta_Visita + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Consulta_visita. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Consulta_visita</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Consulta_visita Obj)
        {
            if (Obj.Fecha_Consulta_Visita == null)
            {
                throw new Exception("Fecha_Consulta_Visita no puede ser null");
            }
            if (Obj.Observaciones_Consulta_Visita == null)
            {
                throw new Exception("Observaciones_Consulta_Visita no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE consulta_visita SET `Id_Consulta` =  '" + Obj.Id_Consulta.ToString() + "', `Fecha_Consulta_Visita` =  '" + Obj.Fecha_Consulta_Visita.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Consulta_Visita` =  '" + Obj.Observaciones_Consulta_Visita + "' WHERE consulta_visita.Id_Consulta_Visita = " + Obj.Id_Consulta_Visita.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Consulta_visita. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM consulta_visita WHERE consulta_visita.Id_Consulta_Visita = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se lleva el control de las coutas
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:15 p.m.
    /// </summary>
    public partial class Couta
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Couta()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Couta</param>
        public Couta(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Couta"))
            {
                if (DataRowConstructor["Id_Couta"] != DBNull.Value)
                {
                    this.Id_Couta = Convert.ToInt32(DataRowConstructor["Id_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Couta_Couta"))
            {
                if (DataRowConstructor["Numero_Couta_Couta"] != DBNull.Value)
                {
                    this.Numero_Couta_Couta = Convert.ToInt32(DataRowConstructor["Numero_Couta_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimineto_Couta"))
            {
                if (DataRowConstructor["Fecha_Vencimineto_Couta"] != DBNull.Value)
                {
                    this.Fecha_Vencimineto_Couta = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimineto_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Pago_Couta"))
            {
                if (DataRowConstructor["Fecha_Pago_Couta"] != DBNull.Value)
                {
                    this.Fecha_Pago_Couta = Convert.ToDateTime(DataRowConstructor["Fecha_Pago_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Couta"))
            {
                if (DataRowConstructor["Importe_Couta"] != DBNull.Value)
                {
                    this.Importe_Couta = Convert.ToDecimal(DataRowConstructor["Importe_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Interes_Couta"))
            {
                if (DataRowConstructor["Importe_Interes_Couta"] != DBNull.Value)
                {
                    this.Importe_Interes_Couta = Convert.ToDecimal(DataRowConstructor["Importe_Interes_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Asignacion_Cuota"))
            {
                if (DataRowConstructor["Asignacion_Cuota"] != DBNull.Value)
                {
                    this.Asignacion_Cuota = Convert.ToDecimal(DataRowConstructor["Asignacion_Cuota"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Pagado_Couta"))
            {
                if (DataRowConstructor["Pagado_Couta"] != DBNull.Value)
                {
                    this.Pagado_Couta = Convert.ToBoolean(DataRowConstructor["Pagado_Couta"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Couta"))
            {
                if (DataRowConstructor["Observaciones_Couta"] != DBNull.Value)
                {
                    this.Observaciones_Couta = DataRowConstructor["Observaciones_Couta"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Couta</param>
        public Couta(DataSet DataSetConstructor)
        {
            this.ListaCouta = new List<Couta>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Couta TEMP = new Couta(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaCouta.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Couta> ListaCouta { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Couta { get; set; }
        /// <summary>
        /// ID de la factura
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Numero de la cuota
        /// </summary>
        public int Numero_Couta_Couta { get; set; }
        /// <summary>
        /// Fecha vencimiento
        /// </summary>
        public DateTime Fecha_Vencimineto_Couta { get; set; }
        /// <summary>
        /// Fecha del pago de la cuota
        /// </summary>
        public DateTime Fecha_Pago_Couta { get; set; }
        /// <summary>
        /// Importe de la cuota
        /// </summary>
        public decimal Importe_Couta { get; set; }
        /// <summary>
        /// Este interes se agrecuando se pago fuera de termino
        /// </summary>
        public decimal Importe_Interes_Couta { get; set; }
        /// <summary>
        /// Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)
        /// </summary>
        public decimal Asignacion_Cuota { get; set; }
        /// <summary>
        /// Este campo es vendadero cuando esta cuota ya esta pagada
        /// </summary>
        public bool Pagado_Couta { get; set; }
        /// <summary>
        /// Algunas observaciones en el pago de la cuota
        /// </summary>
        public string Observaciones_Couta { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla couta.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Couta`, `Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta` FROM couta " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla couta.
        /// </summary>
        /// <param name="Id_Couta">ID de la tabla</param>
        /// <param name="Id_Factura">ID de la factura</param>
        /// <param name="Numero_Couta_Couta">Numero de la cuota</param>
        /// <param name="Fecha_Vencimineto_Couta">Fecha vencimiento</param>
        /// <param name="Fecha_Pago_Couta">Fecha del pago de la cuota</param>
        /// <param name="Importe_Couta">Importe de la cuota</param>
        /// <param name="Importe_Interes_Couta">Este interes se agrecuando se pago fuera de termino</param>
        /// <param name="Asignacion_Cuota">Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)</param>
        /// <param name="Pagado_Couta">Este campo es vendadero cuando esta cuota ya esta pagada</param>
        /// <param name="Observaciones_Couta">Algunas observaciones en el pago de la cuota</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Couta, int Id_Factura, int Numero_Couta_Couta, DateTime Fecha_Vencimineto_Couta, DateTime Fecha_Pago_Couta, decimal Importe_Couta, decimal Importe_Interes_Couta, decimal Asignacion_Cuota, bool Pagado_Couta, string Observaciones_Couta)
        {
            return "INSERT INTO couta(`Id_Couta`, `Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`) VALUES ('" + Id_Couta.ToString() + "', '" + Id_Factura.ToString() + "', '" + Numero_Couta_Couta.ToString() + "', '" + Fecha_Vencimineto_Couta.ToString() + "', '" + Fecha_Pago_Couta.ToString() + "', '" + Importe_Couta.ToString() + "', '" + Importe_Interes_Couta.ToString() + "', '" + Asignacion_Cuota.ToString() + "', '" + Pagado_Couta.ToString() + "', '" + Observaciones_Couta.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla couta.
        /// </summary>
        /// <param name="Id_Couta">ID de la tabla</param>
        /// <param name="Id_Factura">ID de la factura</param>
        /// <param name="Numero_Couta_Couta">Numero de la cuota</param>
        /// <param name="Fecha_Vencimineto_Couta">Fecha vencimiento</param>
        /// <param name="Fecha_Pago_Couta">Fecha del pago de la cuota</param>
        /// <param name="Importe_Couta">Importe de la cuota</param>
        /// <param name="Importe_Interes_Couta">Este interes se agrecuando se pago fuera de termino</param>
        /// <param name="Asignacion_Cuota">Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)</param>
        /// <param name="Pagado_Couta">Este campo es vendadero cuando esta cuota ya esta pagada</param>
        /// <param name="Observaciones_Couta">Algunas observaciones en el pago de la cuota</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Couta, int Id_Factura, int Numero_Couta_Couta, DateTime Fecha_Vencimineto_Couta, DateTime Fecha_Pago_Couta, decimal Importe_Couta, decimal Importe_Interes_Couta, decimal Asignacion_Cuota, bool Pagado_Couta, string Observaciones_Couta, string Filtro)
        {
            return "UPDATE couta SET `Id_Couta` = '" + Id_Couta.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Numero_Couta_Couta` = '" + Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` = '" + Fecha_Vencimineto_Couta.ToString() + "', `Fecha_Pago_Couta` = '" + Fecha_Pago_Couta.ToString() + "', `Importe_Couta` = '" + Importe_Couta.ToString() + "', `Importe_Interes_Couta` = '" + Importe_Interes_Couta.ToString() + "', `Asignacion_Cuota` = '" + Asignacion_Cuota.ToString() + "', `Pagado_Couta` = '" + Pagado_Couta.ToString() + "', `Observaciones_Couta` = '" + Observaciones_Couta.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Couta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO couta(`Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Numero_Couta_Couta.ToString() + "', " + "'" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Pagado_Couta) + ", " + "'" + Obj.Observaciones_Couta + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Couta.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE couta SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Numero_Couta_Couta` =  '" + Obj.Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` =  '" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Pago_Couta` =  '" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Importe_Couta` =  '" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', `Importe_Interes_Couta` =  '" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', `Asignacion_Cuota` =  '" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', `Pagado_Couta` = " + Common.BoolToString(Obj.Pagado_Couta) + ", `Observaciones_Couta` =  '" + Obj.Observaciones_Couta + "' WHERE couta.Id_Couta = " + Obj.Id_Couta.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Couta.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM couta WHERE couta.Id_Couta = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO couta(`Id_Factura`, `Numero_Couta_Couta`, `Fecha_Vencimineto_Couta`, `Fecha_Pago_Couta`, `Importe_Couta`, `Importe_Interes_Couta`, `Asignacion_Cuota`, `Pagado_Couta`, `Observaciones_Couta`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Numero_Couta_Couta.ToString() + "', " + "'" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', " + "'" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Pagado_Couta) + ", " + "'" + Obj.Observaciones_Couta + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Couta</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Couta Obj)
        {
            if (Obj.Fecha_Vencimineto_Couta == null)
            {
                throw new Exception("Fecha_Vencimineto_Couta no puede ser null");
            }
            if (Obj.Fecha_Pago_Couta == null)
            {
                throw new Exception("Fecha_Pago_Couta no puede ser null");
            }
            if (Obj.Observaciones_Couta == null)
            {
                throw new Exception("Observaciones_Couta no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE couta SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Numero_Couta_Couta` =  '" + Obj.Numero_Couta_Couta.ToString() + "', `Fecha_Vencimineto_Couta` =  '" + Obj.Fecha_Vencimineto_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Pago_Couta` =  '" + Obj.Fecha_Pago_Couta.ToString("yyyy-MM-dd HH:mm:ss") + "', `Importe_Couta` =  '" + Obj.Importe_Couta.ToString().Replace(",", ".") + "', `Importe_Interes_Couta` =  '" + Obj.Importe_Interes_Couta.ToString().Replace(",", ".") + "', `Asignacion_Cuota` =  '" + Obj.Asignacion_Cuota.ToString().Replace(",", ".") + "', `Pagado_Couta` = " + Common.BoolToString(Obj.Pagado_Couta) + ", `Observaciones_Couta` =  '" + Obj.Observaciones_Couta + "' WHERE couta.Id_Couta = " + Obj.Id_Couta.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Couta. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM couta WHERE couta.Id_Couta = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Datos de la empresa
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Empresa
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Empresa()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Empresa</param>
        public Empresa(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Empresa"))
            {
                if (DataRowConstructor["Id_Empresa"] != DBNull.Value)
                {
                    this.Id_Empresa = Convert.ToInt32(DataRowConstructor["Id_Empresa"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Razon_Social_Empresa"))
            {
                if (DataRowConstructor["Razon_Social_Empresa"] != DBNull.Value)
                {
                    this.Razon_Social_Empresa = DataRowConstructor["Razon_Social_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Titular_Empresa"))
            {
                if (DataRowConstructor["Titular_Empresa"] != DBNull.Value)
                {
                    this.Titular_Empresa = DataRowConstructor["Titular_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("CUIT_Empresa"))
            {
                if (DataRowConstructor["CUIT_Empresa"] != DBNull.Value)
                {
                    this.CUIT_Empresa = DataRowConstructor["CUIT_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Direccion_Empresa"))
            {
                if (DataRowConstructor["Direccion_Empresa"] != DBNull.Value)
                {
                    this.Direccion_Empresa = DataRowConstructor["Direccion_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Telefonos_Empresa"))
            {
                if (DataRowConstructor["Telefonos_Empresa"] != DBNull.Value)
                {
                    this.Telefonos_Empresa = DataRowConstructor["Telefonos_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fax_Empresa"))
            {
                if (DataRowConstructor["Fax_Empresa"] != DBNull.Value)
                {
                    this.Fax_Empresa = DataRowConstructor["Fax_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Email_Empresa"))
            {
                if (DataRowConstructor["Email_Empresa"] != DBNull.Value)
                {
                    this.Email_Empresa = DataRowConstructor["Email_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Web_Empresa"))
            {
                if (DataRowConstructor["Web_Empresa"] != DBNull.Value)
                {
                    this.Web_Empresa = DataRowConstructor["Web_Empresa"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Inicio_Actividades_Empresa"))
            {
                if (DataRowConstructor["Inicio_Actividades_Empresa"] != DBNull.Value)
                {
                    this.Inicio_Actividades_Empresa = Convert.ToDateTime(DataRowConstructor["Inicio_Actividades_Empresa"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Ingresos_Brutos_Empresa"))
            {
                if (DataRowConstructor["Ingresos_Brutos_Empresa"] != DBNull.Value)
                {
                    this.Ingresos_Brutos_Empresa = DataRowConstructor["Ingresos_Brutos_Empresa"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Empresa</param>
        public Empresa(DataSet DataSetConstructor)
        {
            this.ListaEmpresa = new List<Empresa>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Empresa TEMP = new Empresa(Fila);
                TEMP.Localidad = new Localidad(Fila);
                TEMP.Tercero_iva = new Tercero_iva(Fila);
                this.ListaEmpresa.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Empresa> ListaEmpresa { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Empresa { get; set; }
        /// <summary>
        /// Localidad de la empresa
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// IVA de la empresa
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// Razon Social o nombre de la empresa
        /// </summary>
        public string Razon_Social_Empresa { get; set; }
        /// <summary>
        /// Titular de dueño de la empresa
        /// </summary>
        public string Titular_Empresa { get; set; }
        /// <summary>
        /// CUIT de la empresa
        /// </summary>
        public string CUIT_Empresa { get; set; }
        /// <summary>
        /// Direccion de la empresa
        /// </summary>
        public string Direccion_Empresa { get; set; }
        /// <summary>
        /// Telefonos de la empresa
        /// </summary>
        public string Telefonos_Empresa { get; set; }
        /// <summary>
        /// Fax de la empresa
        /// </summary>
        public string Fax_Empresa { get; set; }
        /// <summary>
        /// Email de la empresa
        /// </summary>
        public string Email_Empresa { get; set; }
        /// <summary>
        /// Web de la empresa
        /// </summary>
        public string Web_Empresa { get; set; }
        /// <summary>
        /// Cuando se inicio la actividad de la empresa
        /// </summary>
        public DateTime Inicio_Actividades_Empresa { get; set; }
        /// <summary>
        /// Ingresos brutos de la empresa
        /// </summary>
        public string Ingresos_Brutos_Empresa { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_iva, Tipo de condicion de IVA
        /// </summary>
        public Tercero_iva Tercero_iva { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla empresa.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Empresa`, `Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa` FROM empresa " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla empresa.
        /// </summary>
        /// <param name="Id_Empresa">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad de la empresa</param>
        /// <param name="Id_Tercero_IVA">IVA de la empresa</param>
        /// <param name="Razon_Social_Empresa">Razon Social o nombre de la empresa</param>
        /// <param name="Titular_Empresa">Titular de dueño de la empresa</param>
        /// <param name="CUIT_Empresa">CUIT de la empresa</param>
        /// <param name="Direccion_Empresa">Direccion de la empresa</param>
        /// <param name="Telefonos_Empresa">Telefonos de la empresa</param>
        /// <param name="Fax_Empresa">Fax de la empresa</param>
        /// <param name="Email_Empresa">Email de la empresa</param>
        /// <param name="Web_Empresa">Web de la empresa</param>
        /// <param name="Inicio_Actividades_Empresa">Cuando se inicio la actividad de la empresa</param>
        /// <param name="Ingresos_Brutos_Empresa">Ingresos brutos de la empresa</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Empresa, int Id_Localidad, int Id_Tercero_IVA, string Razon_Social_Empresa, string Titular_Empresa, string CUIT_Empresa, string Direccion_Empresa, string Telefonos_Empresa, string Fax_Empresa, string Email_Empresa, string Web_Empresa, DateTime Inicio_Actividades_Empresa, string Ingresos_Brutos_Empresa)
        {
            return "INSERT INTO empresa(`Id_Empresa`, `Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`) VALUES ('" + Id_Empresa.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Id_Tercero_IVA.ToString() + "', '" + Razon_Social_Empresa.ToString() + "', '" + Titular_Empresa.ToString() + "', '" + CUIT_Empresa.ToString() + "', '" + Direccion_Empresa.ToString() + "', '" + Telefonos_Empresa.ToString() + "', '" + Fax_Empresa.ToString() + "', '" + Email_Empresa.ToString() + "', '" + Web_Empresa.ToString() + "', '" + Inicio_Actividades_Empresa.ToString() + "', '" + Ingresos_Brutos_Empresa.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla empresa.
        /// </summary>
        /// <param name="Id_Empresa">ID de la tabla</param>
        /// <param name="Id_Localidad">Localidad de la empresa</param>
        /// <param name="Id_Tercero_IVA">IVA de la empresa</param>
        /// <param name="Razon_Social_Empresa">Razon Social o nombre de la empresa</param>
        /// <param name="Titular_Empresa">Titular de dueño de la empresa</param>
        /// <param name="CUIT_Empresa">CUIT de la empresa</param>
        /// <param name="Direccion_Empresa">Direccion de la empresa</param>
        /// <param name="Telefonos_Empresa">Telefonos de la empresa</param>
        /// <param name="Fax_Empresa">Fax de la empresa</param>
        /// <param name="Email_Empresa">Email de la empresa</param>
        /// <param name="Web_Empresa">Web de la empresa</param>
        /// <param name="Inicio_Actividades_Empresa">Cuando se inicio la actividad de la empresa</param>
        /// <param name="Ingresos_Brutos_Empresa">Ingresos brutos de la empresa</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Empresa, int Id_Localidad, int Id_Tercero_IVA, string Razon_Social_Empresa, string Titular_Empresa, string CUIT_Empresa, string Direccion_Empresa, string Telefonos_Empresa, string Fax_Empresa, string Email_Empresa, string Web_Empresa, DateTime Inicio_Actividades_Empresa, string Ingresos_Brutos_Empresa, string Filtro)
        {
            return "UPDATE empresa SET `Id_Empresa` = '" + Id_Empresa.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` = '" + Razon_Social_Empresa.ToString() + "', `Titular_Empresa` = '" + Titular_Empresa.ToString() + "', `CUIT_Empresa` = '" + CUIT_Empresa.ToString() + "', `Direccion_Empresa` = '" + Direccion_Empresa.ToString() + "', `Telefonos_Empresa` = '" + Telefonos_Empresa.ToString() + "', `Fax_Empresa` = '" + Fax_Empresa.ToString() + "', `Email_Empresa` = '" + Email_Empresa.ToString() + "', `Web_Empresa` = '" + Web_Empresa.ToString() + "', `Inicio_Actividades_Empresa` = '" + Inicio_Actividades_Empresa.ToString() + "', `Ingresos_Brutos_Empresa` = '" + Ingresos_Brutos_Empresa.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Empresa.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO empresa(`Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Razon_Social_Empresa + "', " + "'" + Obj.Titular_Empresa + "', " + "'" + Obj.CUIT_Empresa + "', " + "'" + Obj.Direccion_Empresa + "', " + "'" + Obj.Telefonos_Empresa + "', " + "'" + Obj.Fax_Empresa + "', " + "'" + Obj.Email_Empresa + "', " + "'" + Obj.Web_Empresa + "', " + "'" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Ingresos_Brutos_Empresa + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Empresa.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE empresa SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` =  '" + Obj.Razon_Social_Empresa + "', `Titular_Empresa` =  '" + Obj.Titular_Empresa + "', `CUIT_Empresa` =  '" + Obj.CUIT_Empresa + "', `Direccion_Empresa` =  '" + Obj.Direccion_Empresa + "', `Telefonos_Empresa` =  '" + Obj.Telefonos_Empresa + "', `Fax_Empresa` =  '" + Obj.Fax_Empresa + "', `Email_Empresa` =  '" + Obj.Email_Empresa + "', `Web_Empresa` =  '" + Obj.Web_Empresa + "', `Inicio_Actividades_Empresa` =  '" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', `Ingresos_Brutos_Empresa` =  '" + Obj.Ingresos_Brutos_Empresa + "' WHERE empresa.Id_Empresa = " + Obj.Id_Empresa.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Empresa.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM empresa WHERE empresa.Id_Empresa = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO empresa(`Id_Localidad`, `Id_Tercero_IVA`, `Razon_Social_Empresa`, `Titular_Empresa`, `CUIT_Empresa`, `Direccion_Empresa`, `Telefonos_Empresa`, `Fax_Empresa`, `Email_Empresa`, `Web_Empresa`, `Inicio_Actividades_Empresa`, `Ingresos_Brutos_Empresa`)VALUES( " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Razon_Social_Empresa + "', " + "'" + Obj.Titular_Empresa + "', " + "'" + Obj.CUIT_Empresa + "', " + "'" + Obj.Direccion_Empresa + "', " + "'" + Obj.Telefonos_Empresa + "', " + "'" + Obj.Fax_Empresa + "', " + "'" + Obj.Email_Empresa + "', " + "'" + Obj.Web_Empresa + "', " + "'" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Ingresos_Brutos_Empresa + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Empresa</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Empresa Obj)
        {
            if (Obj.Razon_Social_Empresa == null)
            {
                throw new Exception("Razon_Social_Empresa no puede ser null");
            }
            if (Obj.Titular_Empresa == null)
            {
                throw new Exception("Titular_Empresa no puede ser null");
            }
            if (Obj.CUIT_Empresa == null)
            {
                throw new Exception("CUIT_Empresa no puede ser null");
            }
            if (Obj.Direccion_Empresa == null)
            {
                throw new Exception("Direccion_Empresa no puede ser null");
            }
            if (Obj.Telefonos_Empresa == null)
            {
                throw new Exception("Telefonos_Empresa no puede ser null");
            }
            if (Obj.Fax_Empresa == null)
            {
                throw new Exception("Fax_Empresa no puede ser null");
            }
            if (Obj.Email_Empresa == null)
            {
                throw new Exception("Email_Empresa no puede ser null");
            }
            if (Obj.Web_Empresa == null)
            {
                throw new Exception("Web_Empresa no puede ser null");
            }
            if (Obj.Inicio_Actividades_Empresa == null)
            {
                throw new Exception("Inicio_Actividades_Empresa no puede ser null");
            }
            if (Obj.Ingresos_Brutos_Empresa == null)
            {
                throw new Exception("Ingresos_Brutos_Empresa no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE empresa SET `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Razon_Social_Empresa` =  '" + Obj.Razon_Social_Empresa + "', `Titular_Empresa` =  '" + Obj.Titular_Empresa + "', `CUIT_Empresa` =  '" + Obj.CUIT_Empresa + "', `Direccion_Empresa` =  '" + Obj.Direccion_Empresa + "', `Telefonos_Empresa` =  '" + Obj.Telefonos_Empresa + "', `Fax_Empresa` =  '" + Obj.Fax_Empresa + "', `Email_Empresa` =  '" + Obj.Email_Empresa + "', `Web_Empresa` =  '" + Obj.Web_Empresa + "', `Inicio_Actividades_Empresa` =  '" + Obj.Inicio_Actividades_Empresa.ToString("yyyy-MM-dd HH:mm:ss") + "', `Ingresos_Brutos_Empresa` =  '" + Obj.Ingresos_Brutos_Empresa + "' WHERE empresa.Id_Empresa = " + Obj.Id_Empresa.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Empresa. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM empresa WHERE empresa.Id_Empresa = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se guardan las enfermedades, los datos iniciales se sacaron de: CLASIFICACION ESTADISTICA INTERNACIONAL DE ENFERMEDADES Y PROBLEMAS RELACIONADOS CON LA SALUD. DECIMA REVISION. - CIE 10- CODIGOS Y DESCRIPCION A TRES Y CUATRO DIGITOS.
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Enfermedad
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Enfermedad()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Enfermedad</param>
        public Enfermedad(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Enfermedad"))
            {
                if (DataRowConstructor["Id_Enfermedad"] != DBNull.Value)
                {
                    this.Id_Enfermedad = Convert.ToInt32(DataRowConstructor["Id_Enfermedad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Enfermedad_Categoria"))
            {
                if (DataRowConstructor["Id_Enfermedad_Categoria"] != DBNull.Value)
                {
                    this.Id_Enfermedad_Categoria = Convert.ToInt32(DataRowConstructor["Id_Enfermedad_Categoria"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Enfermedad"))
            {
                if (DataRowConstructor["Codigo_Enfermedad"] != DBNull.Value)
                {
                    this.Codigo_Enfermedad = DataRowConstructor["Codigo_Enfermedad"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Enfermedad"))
            {
                if (DataRowConstructor["Descripcion_Enfermedad"] != DBNull.Value)
                {
                    this.Descripcion_Enfermedad = DataRowConstructor["Descripcion_Enfermedad"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Enfermedad"))
            {
                if (DataRowConstructor["Observaciones_Enfermedad"] != DBNull.Value)
                {
                    this.Observaciones_Enfermedad = DataRowConstructor["Observaciones_Enfermedad"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Enfermedad</param>
        public Enfermedad(DataSet DataSetConstructor)
        {
            this.ListaEnfermedad = new List<Enfermedad>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Enfermedad TEMP = new Enfermedad(Fila);
                TEMP.Enfermedad_categoria = new Enfermedad_categoria(Fila);
                this.ListaEnfermedad.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Enfermedad> ListaEnfermedad { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Enfermedad { get; set; }
        /// <summary>
        /// Id de la categoria de la enfermedad
        /// </summary>
        public int Id_Enfermedad_Categoria { get; set; }
        /// <summary>
        /// codigo de la enfermedad
        /// </summary>
        public string Codigo_Enfermedad { get; set; }
        /// <summary>
        /// descripcion o nombre de la enfermedad
        /// </summary>
        public string Descripcion_Enfermedad { get; set; }
        /// <summary>
        /// Obsercaciones de la enfermedad
        /// </summary>
        public string Observaciones_Enfermedad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Enfermedad_categoria, Estas son las categorias que hay en las enfermedades.
        /// </summary>
        public Enfermedad_categoria Enfermedad_categoria { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla enfermedad.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Enfermedad`, `Id_Enfermedad_Categoria`, `Codigo_Enfermedad`, `Descripcion_Enfermedad`, `Observaciones_Enfermedad` FROM enfermedad " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla enfermedad.
        /// </summary>
        /// <param name="Id_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Enfermedad_Categoria">Id de la categoria de la enfermedad</param>
        /// <param name="Codigo_Enfermedad">codigo de la enfermedad</param>
        /// <param name="Descripcion_Enfermedad">descripcion o nombre de la enfermedad</param>
        /// <param name="Observaciones_Enfermedad">Obsercaciones de la enfermedad</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Enfermedad, int Id_Enfermedad_Categoria, string Codigo_Enfermedad, string Descripcion_Enfermedad, string Observaciones_Enfermedad)
        {
            return "INSERT INTO enfermedad(`Id_Enfermedad`, `Id_Enfermedad_Categoria`, `Codigo_Enfermedad`, `Descripcion_Enfermedad`, `Observaciones_Enfermedad`) VALUES ('" + Id_Enfermedad.ToString() + "', '" + Id_Enfermedad_Categoria.ToString() + "', '" + Codigo_Enfermedad.ToString() + "', '" + Descripcion_Enfermedad.ToString() + "', '" + Observaciones_Enfermedad.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla enfermedad.
        /// </summary>
        /// <param name="Id_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Enfermedad_Categoria">Id de la categoria de la enfermedad</param>
        /// <param name="Codigo_Enfermedad">codigo de la enfermedad</param>
        /// <param name="Descripcion_Enfermedad">descripcion o nombre de la enfermedad</param>
        /// <param name="Observaciones_Enfermedad">Obsercaciones de la enfermedad</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Enfermedad, int Id_Enfermedad_Categoria, string Codigo_Enfermedad, string Descripcion_Enfermedad, string Observaciones_Enfermedad, string Filtro)
        {
            return "UPDATE enfermedad SET `Id_Enfermedad` = '" + Id_Enfermedad.ToString() + "', `Id_Enfermedad_Categoria` = '" + Id_Enfermedad_Categoria.ToString() + "', `Codigo_Enfermedad` = '" + Codigo_Enfermedad.ToString() + "', `Descripcion_Enfermedad` = '" + Descripcion_Enfermedad.ToString() + "', `Observaciones_Enfermedad` = '" + Observaciones_Enfermedad.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Enfermedad Obj)
        {
            if (Obj.Codigo_Enfermedad == null)
            {
                throw new Exception("Codigo_Enfermedad no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad == null)
            {
                throw new Exception("Descripcion_Enfermedad no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad == null)
            {
                throw new Exception("Observaciones_Enfermedad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO enfermedad(`Id_Enfermedad_Categoria`, `Codigo_Enfermedad`, `Descripcion_Enfermedad`, `Observaciones_Enfermedad`)VALUES( " + "'" + Obj.Id_Enfermedad_Categoria.ToString() + "', " + "'" + Obj.Codigo_Enfermedad + "', " + "'" + Obj.Descripcion_Enfermedad + "', " + "'" + Obj.Observaciones_Enfermedad + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Enfermedad Obj)
        {
            if (Obj.Codigo_Enfermedad == null)
            {
                throw new Exception("Codigo_Enfermedad no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad == null)
            {
                throw new Exception("Descripcion_Enfermedad no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad == null)
            {
                throw new Exception("Observaciones_Enfermedad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE enfermedad SET `Id_Enfermedad_Categoria` =  '" + Obj.Id_Enfermedad_Categoria.ToString() + "', `Codigo_Enfermedad` =  '" + Obj.Codigo_Enfermedad + "', `Descripcion_Enfermedad` =  '" + Obj.Descripcion_Enfermedad + "', `Observaciones_Enfermedad` =  '" + Obj.Observaciones_Enfermedad + "' WHERE enfermedad.Id_Enfermedad = " + Obj.Id_Enfermedad.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Enfermedad.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM enfermedad WHERE enfermedad.Id_Enfermedad = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Enfermedad Obj)
        {
            if (Obj.Codigo_Enfermedad == null)
            {
                throw new Exception("Codigo_Enfermedad no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad == null)
            {
                throw new Exception("Descripcion_Enfermedad no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad == null)
            {
                throw new Exception("Observaciones_Enfermedad no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO enfermedad(`Id_Enfermedad_Categoria`, `Codigo_Enfermedad`, `Descripcion_Enfermedad`, `Observaciones_Enfermedad`)VALUES( " + "'" + Obj.Id_Enfermedad_Categoria.ToString() + "', " + "'" + Obj.Codigo_Enfermedad + "', " + "'" + Obj.Descripcion_Enfermedad + "', " + "'" + Obj.Observaciones_Enfermedad + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Enfermedad Obj)
        {
            if (Obj.Codigo_Enfermedad == null)
            {
                throw new Exception("Codigo_Enfermedad no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad == null)
            {
                throw new Exception("Descripcion_Enfermedad no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad == null)
            {
                throw new Exception("Observaciones_Enfermedad no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE enfermedad SET `Id_Enfermedad_Categoria` =  '" + Obj.Id_Enfermedad_Categoria.ToString() + "', `Codigo_Enfermedad` =  '" + Obj.Codigo_Enfermedad + "', `Descripcion_Enfermedad` =  '" + Obj.Descripcion_Enfermedad + "', `Observaciones_Enfermedad` =  '" + Obj.Observaciones_Enfermedad + "' WHERE enfermedad.Id_Enfermedad = " + Obj.Id_Enfermedad.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM enfermedad WHERE enfermedad.Id_Enfermedad = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Estas son las categorias que hay en las enfermedades.
    /// La última modificación fué el lunes, 05 de diciembre de 2011 a las 05:23:34 p.m.
    /// </summary>
    public partial class Enfermedad_categoria
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Enfermedad_categoria()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Enfermedad_categoria</param>
        public Enfermedad_categoria(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Enfermedad_Categoria"))
            {
                if (DataRowConstructor["Id_Enfermedad_Categoria"] != DBNull.Value)
                {
                    this.Id_Enfermedad_Categoria = Convert.ToInt32(DataRowConstructor["Id_Enfermedad_Categoria"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Enfermedad_Categoria"))
            {
                if (DataRowConstructor["Codigo_Enfermedad_Categoria"] != DBNull.Value)
                {
                    this.Codigo_Enfermedad_Categoria = DataRowConstructor["Codigo_Enfermedad_Categoria"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Enfermedad_Categoria"))
            {
                if (DataRowConstructor["Descripcion_Enfermedad_Categoria"] != DBNull.Value)
                {
                    this.Descripcion_Enfermedad_Categoria = DataRowConstructor["Descripcion_Enfermedad_Categoria"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Enfermedad_Categoria"))
            {
                if (DataRowConstructor["Observaciones_Enfermedad_Categoria"] != DBNull.Value)
                {
                    this.Observaciones_Enfermedad_Categoria = DataRowConstructor["Observaciones_Enfermedad_Categoria"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Enfermedad_categoria</param>
        public Enfermedad_categoria(DataSet DataSetConstructor)
        {
            this.ListaEnfermedad_categoria = new List<Enfermedad_categoria>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Enfermedad_categoria TEMP = new Enfermedad_categoria(Fila);
                this.ListaEnfermedad_categoria.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Enfermedad_categoria> ListaEnfermedad_categoria { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Enfermedad_Categoria { get; set; }
        /// <summary>
        /// Codigo de la categoria
        /// </summary>
        public string Codigo_Enfermedad_Categoria { get; set; }
        /// <summary>
        /// descripcion de la categoria
        /// </summary>
        public string Descripcion_Enfermedad_Categoria { get; set; }
        /// <summary>
        /// Observaciones de la categoria
        /// </summary>
        public string Observaciones_Enfermedad_Categoria { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla enfermedad_categoria.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Enfermedad_Categoria`, `Codigo_Enfermedad_Categoria`, `Descripcion_Enfermedad_Categoria`, `Observaciones_Enfermedad_Categoria` FROM enfermedad_categoria " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla enfermedad_categoria.
        /// </summary>
        /// <param name="Id_Enfermedad_Categoria">Id de la tabla</param>
        /// <param name="Codigo_Enfermedad_Categoria">Codigo de la categoria</param>
        /// <param name="Descripcion_Enfermedad_Categoria">descripcion de la categoria</param>
        /// <param name="Observaciones_Enfermedad_Categoria">Observaciones de la categoria</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Enfermedad_Categoria, string Codigo_Enfermedad_Categoria, string Descripcion_Enfermedad_Categoria, string Observaciones_Enfermedad_Categoria)
        {
            return "INSERT INTO enfermedad_categoria(`Id_Enfermedad_Categoria`, `Codigo_Enfermedad_Categoria`, `Descripcion_Enfermedad_Categoria`, `Observaciones_Enfermedad_Categoria`) VALUES ('" + Id_Enfermedad_Categoria.ToString() + "', '" + Codigo_Enfermedad_Categoria.ToString() + "', '" + Descripcion_Enfermedad_Categoria.ToString() + "', '" + Observaciones_Enfermedad_Categoria.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla enfermedad_categoria.
        /// </summary>
        /// <param name="Id_Enfermedad_Categoria">Id de la tabla</param>
        /// <param name="Codigo_Enfermedad_Categoria">Codigo de la categoria</param>
        /// <param name="Descripcion_Enfermedad_Categoria">descripcion de la categoria</param>
        /// <param name="Observaciones_Enfermedad_Categoria">Observaciones de la categoria</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Enfermedad_Categoria, string Codigo_Enfermedad_Categoria, string Descripcion_Enfermedad_Categoria, string Observaciones_Enfermedad_Categoria, string Filtro)
        {
            return "UPDATE enfermedad_categoria SET `Id_Enfermedad_Categoria` = '" + Id_Enfermedad_Categoria.ToString() + "', `Codigo_Enfermedad_Categoria` = '" + Codigo_Enfermedad_Categoria.ToString() + "', `Descripcion_Enfermedad_Categoria` = '" + Descripcion_Enfermedad_Categoria.ToString() + "', `Observaciones_Enfermedad_Categoria` = '" + Observaciones_Enfermedad_Categoria.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Enfermedad_categoria.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad_categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Enfermedad_categoria Obj)
        {
            if (Obj.Codigo_Enfermedad_Categoria == null)
            {
                throw new Exception("Codigo_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad_Categoria == null)
            {
                throw new Exception("Descripcion_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad_Categoria == null)
            {
                throw new Exception("Observaciones_Enfermedad_Categoria no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO enfermedad_categoria(`Codigo_Enfermedad_Categoria`, `Descripcion_Enfermedad_Categoria`, `Observaciones_Enfermedad_Categoria`)VALUES( " + "'" + Obj.Codigo_Enfermedad_Categoria + "', " + "'" + Obj.Descripcion_Enfermedad_Categoria + "', " + "'" + Obj.Observaciones_Enfermedad_Categoria + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Enfermedad_categoria.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad_categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Enfermedad_categoria Obj)
        {
            if (Obj.Codigo_Enfermedad_Categoria == null)
            {
                throw new Exception("Codigo_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad_Categoria == null)
            {
                throw new Exception("Descripcion_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad_Categoria == null)
            {
                throw new Exception("Observaciones_Enfermedad_Categoria no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE enfermedad_categoria SET `Codigo_Enfermedad_Categoria` =  '" + Obj.Codigo_Enfermedad_Categoria + "', `Descripcion_Enfermedad_Categoria` =  '" + Obj.Descripcion_Enfermedad_Categoria + "', `Observaciones_Enfermedad_Categoria` =  '" + Obj.Observaciones_Enfermedad_Categoria + "' WHERE enfermedad_categoria.Id_Enfermedad_Categoria = " + Obj.Id_Enfermedad_Categoria.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Enfermedad_categoria.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM enfermedad_categoria WHERE enfermedad_categoria.Id_Enfermedad_Categoria = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Enfermedad_categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad_categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Enfermedad_categoria Obj)
        {
            if (Obj.Codigo_Enfermedad_Categoria == null)
            {
                throw new Exception("Codigo_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad_Categoria == null)
            {
                throw new Exception("Descripcion_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad_Categoria == null)
            {
                throw new Exception("Observaciones_Enfermedad_Categoria no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO enfermedad_categoria(`Codigo_Enfermedad_Categoria`, `Descripcion_Enfermedad_Categoria`, `Observaciones_Enfermedad_Categoria`)VALUES( " + "'" + Obj.Codigo_Enfermedad_Categoria + "', " + "'" + Obj.Descripcion_Enfermedad_Categoria + "', " + "'" + Obj.Observaciones_Enfermedad_Categoria + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Enfermedad_categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Enfermedad_categoria</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Enfermedad_categoria Obj)
        {
            if (Obj.Codigo_Enfermedad_Categoria == null)
            {
                throw new Exception("Codigo_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Descripcion_Enfermedad_Categoria == null)
            {
                throw new Exception("Descripcion_Enfermedad_Categoria no puede ser null");
            }
            if (Obj.Observaciones_Enfermedad_Categoria == null)
            {
                throw new Exception("Observaciones_Enfermedad_Categoria no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE enfermedad_categoria SET `Codigo_Enfermedad_Categoria` =  '" + Obj.Codigo_Enfermedad_Categoria + "', `Descripcion_Enfermedad_Categoria` =  '" + Obj.Descripcion_Enfermedad_Categoria + "', `Observaciones_Enfermedad_Categoria` =  '" + Obj.Observaciones_Enfermedad_Categoria + "' WHERE enfermedad_categoria.Id_Enfermedad_Categoria = " + Obj.Id_Enfermedad_Categoria.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Enfermedad_categoria. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM enfermedad_categoria WHERE enfermedad_categoria.Id_Enfermedad_Categoria = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se encuentran los estudios
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Estudio
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Estudio()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Estudio</param>
        public Estudio(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Estudio"))
            {
                if (DataRowConstructor["Id_Estudio"] != DBNull.Value)
                {
                    this.Id_Estudio = Convert.ToInt32(DataRowConstructor["Id_Estudio"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Estudio"))
            {
                if (DataRowConstructor["Descripcion_Estudio"] != DBNull.Value)
                {
                    this.Descripcion_Estudio = DataRowConstructor["Descripcion_Estudio"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Estudio</param>
        public Estudio(DataSet DataSetConstructor)
        {
            this.ListaEstudio = new List<Estudio>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Estudio TEMP = new Estudio(Fila);
                this.ListaEstudio.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Estudio> ListaEstudio { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Estudio { get; set; }
        /// <summary>
        /// Decripcion del Estudio
        /// </summary>
        public string Descripcion_Estudio { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla estudio.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Estudio`, `Descripcion_Estudio` FROM estudio " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla estudio.
        /// </summary>
        /// <param name="Id_Estudio">Id de la tabla</param>
        /// <param name="Descripcion_Estudio">Decripcion del Estudio</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Estudio, string Descripcion_Estudio)
        {
            return "INSERT INTO estudio(`Id_Estudio`, `Descripcion_Estudio`) VALUES ('" + Id_Estudio.ToString() + "', '" + Descripcion_Estudio.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla estudio.
        /// </summary>
        /// <param name="Id_Estudio">Id de la tabla</param>
        /// <param name="Descripcion_Estudio">Decripcion del Estudio</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Estudio, string Descripcion_Estudio, string Filtro)
        {
            return "UPDATE estudio SET `Id_Estudio` = '" + Id_Estudio.ToString() + "', `Descripcion_Estudio` = '" + Descripcion_Estudio.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Estudio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Estudio Obj)
        {
            if (Obj.Descripcion_Estudio == null)
            {
                throw new Exception("Descripcion_Estudio no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO estudio(`Descripcion_Estudio`)VALUES( " + "'" + Obj.Descripcion_Estudio + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Estudio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Estudio Obj)
        {
            if (Obj.Descripcion_Estudio == null)
            {
                throw new Exception("Descripcion_Estudio no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE estudio SET `Descripcion_Estudio` =  '" + Obj.Descripcion_Estudio + "' WHERE estudio.Id_Estudio = " + Obj.Id_Estudio.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Estudio.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM estudio WHERE estudio.Id_Estudio = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Estudio Obj)
        {
            if (Obj.Descripcion_Estudio == null)
            {
                throw new Exception("Descripcion_Estudio no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO estudio(`Descripcion_Estudio`)VALUES( " + "'" + Obj.Descripcion_Estudio + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Estudio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Estudio Obj)
        {
            if (Obj.Descripcion_Estudio == null)
            {
                throw new Exception("Descripcion_Estudio no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE estudio SET `Descripcion_Estudio` =  '" + Obj.Descripcion_Estudio + "' WHERE estudio.Id_Estudio = " + Obj.Id_Estudio.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Estudio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM estudio WHERE estudio.Id_Estudio = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Aca van todas las facturas
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Factura
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura</param>
        public Factura(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Factura"))
            {
                if (DataRowConstructor["Fecha_Factura"] != DBNull.Value)
                {
                    this.Fecha_Factura = Convert.ToDateTime(DataRowConstructor["Fecha_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Vencimiento_Factura"))
            {
                if (DataRowConstructor["Fecha_Vencimiento_Factura"] != DBNull.Value)
                {
                    this.Fecha_Vencimiento_Factura = Convert.ToDateTime(DataRowConstructor["Fecha_Vencimiento_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Factura"))
            {
                if (DataRowConstructor["Clase_Factura"] != DBNull.Value)
                {
                    this.Clase_Factura = DataRowConstructor["Clase_Factura"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Puesto_Factura"))
            {
                if (DataRowConstructor["Puesto_Factura"] != DBNull.Value)
                {
                    this.Puesto_Factura = Convert.ToInt32(DataRowConstructor["Puesto_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero_Factura"))
            {
                if (DataRowConstructor["Numero_Factura"] != DBNull.Value)
                {
                    this.Numero_Factura = Convert.ToInt32(DataRowConstructor["Numero_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Neto_Factura"))
            {
                if (DataRowConstructor["Neto_Factura"] != DBNull.Value)
                {
                    this.Neto_Factura = Convert.ToDecimal(DataRowConstructor["Neto_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_105_Factura"))
            {
                if (DataRowConstructor["IVA_105_Factura"] != DBNull.Value)
                {
                    this.IVA_105_Factura = Convert.ToDecimal(DataRowConstructor["IVA_105_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_21_Factura"))
            {
                if (DataRowConstructor["IVA_21_Factura"] != DBNull.Value)
                {
                    this.IVA_21_Factura = Convert.ToDecimal(DataRowConstructor["IVA_21_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IVA_27_Factura"))
            {
                if (DataRowConstructor["IVA_27_Factura"] != DBNull.Value)
                {
                    this.IVA_27_Factura = Convert.ToDecimal(DataRowConstructor["IVA_27_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Percepcion_Factura"))
            {
                if (DataRowConstructor["Percepcion_Factura"] != DBNull.Value)
                {
                    this.Percepcion_Factura = Convert.ToDecimal(DataRowConstructor["Percepcion_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Exentos_Factura"))
            {
                if (DataRowConstructor["Exentos_Factura"] != DBNull.Value)
                {
                    this.Exentos_Factura = Convert.ToDecimal(DataRowConstructor["Exentos_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Otros_Factura"))
            {
                if (DataRowConstructor["Otros_Factura"] != DBNull.Value)
                {
                    this.Otros_Factura = Convert.ToDecimal(DataRowConstructor["Otros_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Total_Factura"))
            {
                if (DataRowConstructor["Total_Factura"] != DBNull.Value)
                {
                    this.Total_Factura = Convert.ToDecimal(DataRowConstructor["Total_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Retencion_Factura"))
            {
                if (DataRowConstructor["Retencion_Factura"] != DBNull.Value)
                {
                    this.Retencion_Factura = Convert.ToDecimal(DataRowConstructor["Retencion_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Interes_Factura"))
            {
                if (DataRowConstructor["Interes_Factura"] != DBNull.Value)
                {
                    this.Interes_Factura = Convert.ToDecimal(DataRowConstructor["Interes_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Anulado_Factura"))
            {
                if (DataRowConstructor["Anulado_Factura"] != DBNull.Value)
                {
                    this.Anulado_Factura = Convert.ToBoolean(DataRowConstructor["Anulado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Facturado_Factura"))
            {
                if (DataRowConstructor["Facturado_Factura"] != DBNull.Value)
                {
                    this.Facturado_Factura = Convert.ToBoolean(DataRowConstructor["Facturado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Pagado_Factura"))
            {
                if (DataRowConstructor["Pagado_Factura"] != DBNull.Value)
                {
                    this.Pagado_Factura = Convert.ToBoolean(DataRowConstructor["Pagado_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Factura"))
            {
                if (DataRowConstructor["Observaciones_Factura"] != DBNull.Value)
                {
                    this.Observaciones_Factura = DataRowConstructor["Observaciones_Factura"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura</param>
        public Factura(DataSet DataSetConstructor)
        {
            this.ListaFactura = new List<Factura>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura TEMP = new Factura(Fila);
                TEMP.Tercero = new Tercero(Fila);
                TEMP.Factura_tipo = new Factura_tipo(Fila);
                this.ListaFactura.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura> ListaFactura { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// ID del tercero responsable del comprobante
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Tipo de factura
        /// </summary>
        public int Id_Factura_Tipo { get; set; }
        /// <summary>
        /// Facha en que se realiaza la factura
        /// </summary>
        public DateTime Fecha_Factura { get; set; }
        /// <summary>
        /// Fecha de vencimiento de la factura
        /// </summary>
        public DateTime Fecha_Vencimiento_Factura { get; set; }
        /// <summary>
        /// Clase de la factura
        /// </summary>
        public string Clase_Factura { get; set; }
        /// <summary>
        /// Puesto de la factura
        /// </summary>
        public int Puesto_Factura { get; set; }
        /// <summary>
        /// Numero de la factura
        /// </summary>
        public int Numero_Factura { get; set; }
        /// <summary>
        /// Valor total del Neto de la factura
        /// </summary>
        public decimal Neto_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 10,5%
        /// </summary>
        public decimal IVA_105_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 21%
        /// </summary>
        public decimal IVA_21_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos con IVA 27%
        /// </summary>
        public decimal IVA_27_Factura { get; set; }
        /// <summary>
        /// Valor de la percepcion
        /// </summary>
        public decimal Percepcion_Factura { get; set; }
        /// <summary>
        /// Valor total de los articulos sin IVA
        /// </summary>
        public decimal Exentos_Factura { get; set; }
        /// <summary>
        /// Otros valores, recargos, importes internos, etc.
        /// </summary>
        public decimal Otros_Factura { get; set; }
        /// <summary>
        /// Total de la factura
        /// </summary>
        public decimal Total_Factura { get; set; }
        /// <summary>
        /// Retencion de la factura
        /// </summary>
        public decimal Retencion_Factura { get; set; }
        /// <summary>
        /// Interes que se le agrega a las cuotas
        /// </summary>
        public decimal Interes_Factura { get; set; }
        /// <summary>
        /// Si es verdadero la factura esta anulada
        /// </summary>
        public bool Anulado_Factura { get; set; }
        /// <summary>
        /// Si es verdadero la factura esta facturada
        /// </summary>
        public bool Facturado_Factura { get; set; }
        /// <summary>
        /// Se usa para los proveedores, para saber cuando esta pagada la factura de compra
        /// </summary>
        public bool Pagado_Factura { get; set; }
        /// <summary>
        /// Observaciones de la factura
        /// </summary>
        public string Observaciones_Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura_tipo, Tipo de comprobantes
        /// </summary>
        public Factura_tipo Factura_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura`, `Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura` FROM factura " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura.
        /// </summary>
        /// <param name="Id_Factura">ID de la tabla</param>
        /// <param name="Id_Tercero">ID del tercero responsable del comprobante</param>
        /// <param name="Id_Factura_Tipo">Tipo de factura</param>
        /// <param name="Fecha_Factura">Facha en que se realiaza la factura</param>
        /// <param name="Fecha_Vencimiento_Factura">Fecha de vencimiento de la factura</param>
        /// <param name="Clase_Factura">Clase de la factura</param>
        /// <param name="Puesto_Factura">Puesto de la factura</param>
        /// <param name="Numero_Factura">Numero de la factura</param>
        /// <param name="Neto_Factura">Valor total del Neto de la factura</param>
        /// <param name="IVA_105_Factura">Valor total de los articulos con IVA 10,5%</param>
        /// <param name="IVA_21_Factura">Valor total de los articulos con IVA 21%</param>
        /// <param name="IVA_27_Factura">Valor total de los articulos con IVA 27%</param>
        /// <param name="Percepcion_Factura">Valor de la percepcion</param>
        /// <param name="Exentos_Factura">Valor total de los articulos sin IVA</param>
        /// <param name="Otros_Factura">Otros valores, recargos, importes internos, etc.</param>
        /// <param name="Total_Factura">Total de la factura</param>
        /// <param name="Retencion_Factura">Retencion de la factura</param>
        /// <param name="Interes_Factura">Interes que se le agrega a las cuotas</param>
        /// <param name="Anulado_Factura">Si es verdadero la factura esta anulada</param>
        /// <param name="Facturado_Factura">Si es verdadero la factura esta facturada</param>
        /// <param name="Pagado_Factura">Se usa para los proveedores, para saber cuando esta pagada la factura de compra</param>
        /// <param name="Observaciones_Factura">Observaciones de la factura</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura, int Id_Tercero, int Id_Factura_Tipo, DateTime Fecha_Factura, DateTime Fecha_Vencimiento_Factura, string Clase_Factura, int Puesto_Factura, int Numero_Factura, decimal Neto_Factura, decimal IVA_105_Factura, decimal IVA_21_Factura, decimal IVA_27_Factura, decimal Percepcion_Factura, decimal Exentos_Factura, decimal Otros_Factura, decimal Total_Factura, decimal Retencion_Factura, decimal Interes_Factura, bool Anulado_Factura, bool Facturado_Factura, bool Pagado_Factura, string Observaciones_Factura)
        {
            return "INSERT INTO factura(`Id_Factura`, `Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`) VALUES ('" + Id_Factura.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Id_Factura_Tipo.ToString() + "', '" + Fecha_Factura.ToString() + "', '" + Fecha_Vencimiento_Factura.ToString() + "', '" + Clase_Factura.ToString() + "', '" + Puesto_Factura.ToString() + "', '" + Numero_Factura.ToString() + "', '" + Neto_Factura.ToString() + "', '" + IVA_105_Factura.ToString() + "', '" + IVA_21_Factura.ToString() + "', '" + IVA_27_Factura.ToString() + "', '" + Percepcion_Factura.ToString() + "', '" + Exentos_Factura.ToString() + "', '" + Otros_Factura.ToString() + "', '" + Total_Factura.ToString() + "', '" + Retencion_Factura.ToString() + "', '" + Interes_Factura.ToString() + "', '" + Anulado_Factura.ToString() + "', '" + Facturado_Factura.ToString() + "', '" + Pagado_Factura.ToString() + "', '" + Observaciones_Factura.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura.
        /// </summary>
        /// <param name="Id_Factura">ID de la tabla</param>
        /// <param name="Id_Tercero">ID del tercero responsable del comprobante</param>
        /// <param name="Id_Factura_Tipo">Tipo de factura</param>
        /// <param name="Fecha_Factura">Facha en que se realiaza la factura</param>
        /// <param name="Fecha_Vencimiento_Factura">Fecha de vencimiento de la factura</param>
        /// <param name="Clase_Factura">Clase de la factura</param>
        /// <param name="Puesto_Factura">Puesto de la factura</param>
        /// <param name="Numero_Factura">Numero de la factura</param>
        /// <param name="Neto_Factura">Valor total del Neto de la factura</param>
        /// <param name="IVA_105_Factura">Valor total de los articulos con IVA 10,5%</param>
        /// <param name="IVA_21_Factura">Valor total de los articulos con IVA 21%</param>
        /// <param name="IVA_27_Factura">Valor total de los articulos con IVA 27%</param>
        /// <param name="Percepcion_Factura">Valor de la percepcion</param>
        /// <param name="Exentos_Factura">Valor total de los articulos sin IVA</param>
        /// <param name="Otros_Factura">Otros valores, recargos, importes internos, etc.</param>
        /// <param name="Total_Factura">Total de la factura</param>
        /// <param name="Retencion_Factura">Retencion de la factura</param>
        /// <param name="Interes_Factura">Interes que se le agrega a las cuotas</param>
        /// <param name="Anulado_Factura">Si es verdadero la factura esta anulada</param>
        /// <param name="Facturado_Factura">Si es verdadero la factura esta facturada</param>
        /// <param name="Pagado_Factura">Se usa para los proveedores, para saber cuando esta pagada la factura de compra</param>
        /// <param name="Observaciones_Factura">Observaciones de la factura</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura, int Id_Tercero, int Id_Factura_Tipo, DateTime Fecha_Factura, DateTime Fecha_Vencimiento_Factura, string Clase_Factura, int Puesto_Factura, int Numero_Factura, decimal Neto_Factura, decimal IVA_105_Factura, decimal IVA_21_Factura, decimal IVA_27_Factura, decimal Percepcion_Factura, decimal Exentos_Factura, decimal Otros_Factura, decimal Total_Factura, decimal Retencion_Factura, decimal Interes_Factura, bool Anulado_Factura, bool Facturado_Factura, bool Pagado_Factura, string Observaciones_Factura, string Filtro)
        {
            return "UPDATE factura SET `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Factura_Tipo` = '" + Id_Factura_Tipo.ToString() + "', `Fecha_Factura` = '" + Fecha_Factura.ToString() + "', `Fecha_Vencimiento_Factura` = '" + Fecha_Vencimiento_Factura.ToString() + "', `Clase_Factura` = '" + Clase_Factura.ToString() + "', `Puesto_Factura` = '" + Puesto_Factura.ToString() + "', `Numero_Factura` = '" + Numero_Factura.ToString() + "', `Neto_Factura` = '" + Neto_Factura.ToString() + "', `IVA_105_Factura` = '" + IVA_105_Factura.ToString() + "', `IVA_21_Factura` = '" + IVA_21_Factura.ToString() + "', `IVA_27_Factura` = '" + IVA_27_Factura.ToString() + "', `Percepcion_Factura` = '" + Percepcion_Factura.ToString() + "', `Exentos_Factura` = '" + Exentos_Factura.ToString() + "', `Otros_Factura` = '" + Otros_Factura.ToString() + "', `Total_Factura` = '" + Total_Factura.ToString() + "', `Retencion_Factura` = '" + Retencion_Factura.ToString() + "', `Interes_Factura` = '" + Interes_Factura.ToString() + "', `Anulado_Factura` = '" + Anulado_Factura.ToString() + "', `Facturado_Factura` = '" + Facturado_Factura.ToString() + "', `Pagado_Factura` = '" + Pagado_Factura.ToString() + "', `Observaciones_Factura` = '" + Observaciones_Factura.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura(`Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Factura_Tipo.ToString() + "', " + "'" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Clase_Factura + "', " + "'" + Obj.Puesto_Factura.ToString() + "', " + "'" + Obj.Numero_Factura.ToString() + "', " + "'" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Total_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Anulado_Factura) + ", " + Common.BoolToString(Obj.Facturado_Factura) + ", " + Common.BoolToString(Obj.Pagado_Factura) + ", " + "'" + Obj.Observaciones_Factura + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Factura_Tipo` =  '" + Obj.Id_Factura_Tipo.ToString() + "', `Fecha_Factura` =  '" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Factura` =  '" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Clase_Factura` =  '" + Obj.Clase_Factura + "', `Puesto_Factura` =  '" + Obj.Puesto_Factura.ToString() + "', `Numero_Factura` =  '" + Obj.Numero_Factura.ToString() + "', `Neto_Factura` =  '" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', `IVA_105_Factura` =  '" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', `IVA_21_Factura` =  '" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', `IVA_27_Factura` =  '" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', `Percepcion_Factura` =  '" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', `Exentos_Factura` =  '" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', `Otros_Factura` =  '" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', `Total_Factura` =  '" + Obj.Total_Factura.ToString().Replace(",", ".") + "', `Retencion_Factura` =  '" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', `Interes_Factura` =  '" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', `Anulado_Factura` = " + Common.BoolToString(Obj.Anulado_Factura) + ", `Facturado_Factura` = " + Common.BoolToString(Obj.Facturado_Factura) + ", `Pagado_Factura` = " + Common.BoolToString(Obj.Pagado_Factura) + ", `Observaciones_Factura` =  '" + Obj.Observaciones_Factura + "' WHERE factura.Id_Factura = " + Obj.Id_Factura.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura WHERE factura.Id_Factura = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura(`Id_Tercero`, `Id_Factura_Tipo`, `Fecha_Factura`, `Fecha_Vencimiento_Factura`, `Clase_Factura`, `Puesto_Factura`, `Numero_Factura`, `Neto_Factura`, `IVA_105_Factura`, `IVA_21_Factura`, `IVA_27_Factura`, `Percepcion_Factura`, `Exentos_Factura`, `Otros_Factura`, `Total_Factura`, `Retencion_Factura`, `Interes_Factura`, `Anulado_Factura`, `Facturado_Factura`, `Pagado_Factura`, `Observaciones_Factura`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Factura_Tipo.ToString() + "', " + "'" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Clase_Factura + "', " + "'" + Obj.Puesto_Factura.ToString() + "', " + "'" + Obj.Numero_Factura.ToString() + "', " + "'" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Total_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', " + "'" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', " + Common.BoolToString(Obj.Anulado_Factura) + ", " + Common.BoolToString(Obj.Facturado_Factura) + ", " + Common.BoolToString(Obj.Pagado_Factura) + ", " + "'" + Obj.Observaciones_Factura + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura Obj)
        {
            if (Obj.Fecha_Factura == null)
            {
                throw new Exception("Fecha_Factura no puede ser null");
            }
            if (Obj.Fecha_Vencimiento_Factura == null)
            {
                throw new Exception("Fecha_Vencimiento_Factura no puede ser null");
            }
            if (Obj.Clase_Factura == null)
            {
                throw new Exception("Clase_Factura no puede ser null");
            }
            if (Obj.Observaciones_Factura == null)
            {
                throw new Exception("Observaciones_Factura no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Factura_Tipo` =  '" + Obj.Id_Factura_Tipo.ToString() + "', `Fecha_Factura` =  '" + Obj.Fecha_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Vencimiento_Factura` =  '" + Obj.Fecha_Vencimiento_Factura.ToString("yyyy-MM-dd HH:mm:ss") + "', `Clase_Factura` =  '" + Obj.Clase_Factura + "', `Puesto_Factura` =  '" + Obj.Puesto_Factura.ToString() + "', `Numero_Factura` =  '" + Obj.Numero_Factura.ToString() + "', `Neto_Factura` =  '" + Obj.Neto_Factura.ToString().Replace(",", ".") + "', `IVA_105_Factura` =  '" + Obj.IVA_105_Factura.ToString().Replace(",", ".") + "', `IVA_21_Factura` =  '" + Obj.IVA_21_Factura.ToString().Replace(",", ".") + "', `IVA_27_Factura` =  '" + Obj.IVA_27_Factura.ToString().Replace(",", ".") + "', `Percepcion_Factura` =  '" + Obj.Percepcion_Factura.ToString().Replace(",", ".") + "', `Exentos_Factura` =  '" + Obj.Exentos_Factura.ToString().Replace(",", ".") + "', `Otros_Factura` =  '" + Obj.Otros_Factura.ToString().Replace(",", ".") + "', `Total_Factura` =  '" + Obj.Total_Factura.ToString().Replace(",", ".") + "', `Retencion_Factura` =  '" + Obj.Retencion_Factura.ToString().Replace(",", ".") + "', `Interes_Factura` =  '" + Obj.Interes_Factura.ToString().Replace(",", ".") + "', `Anulado_Factura` = " + Common.BoolToString(Obj.Anulado_Factura) + ", `Facturado_Factura` = " + Common.BoolToString(Obj.Facturado_Factura) + ", `Pagado_Factura` = " + Common.BoolToString(Obj.Pagado_Factura) + ", `Observaciones_Factura` =  '" + Obj.Observaciones_Factura + "' WHERE factura.Id_Factura = " + Obj.Id_Factura.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura WHERE factura.Id_Factura = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Detalle de la factura, los articulos.
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Factura_detalle
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_detalle()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_detalle</param>
        public Factura_detalle(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Detalle"))
            {
                if (DataRowConstructor["Id_Factura_Detalle"] != DBNull.Value)
                {
                    this.Id_Factura_Detalle = Convert.ToInt32(DataRowConstructor["Id_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Articulo_Factura_Detalle"))
            {
                if (DataRowConstructor["Articulo_Factura_Detalle"] != DBNull.Value)
                {
                    this.Articulo_Factura_Detalle = DataRowConstructor["Articulo_Factura_Detalle"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Cantidad_Factura_Detalle"))
            {
                if (DataRowConstructor["Cantidad_Factura_Detalle"] != DBNull.Value)
                {
                    this.Cantidad_Factura_Detalle = Convert.ToInt32(DataRowConstructor["Cantidad_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Precio_Unitario_Factura_Detalle"))
            {
                if (DataRowConstructor["Precio_Unitario_Factura_Detalle"] != DBNull.Value)
                {
                    this.Precio_Unitario_Factura_Detalle = Convert.ToDecimal(DataRowConstructor["Precio_Unitario_Factura_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Bonifica_Factura_Detalle"))
            {
                if (DataRowConstructor["Bonifica_Factura_Detalle"] != DBNull.Value)
                {
                    this.Bonifica_Factura_Detalle = Convert.ToDecimal(DataRowConstructor["Bonifica_Factura_Detalle"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_detalle</param>
        public Factura_detalle(DataSet DataSetConstructor)
        {
            this.ListaFactura_detalle = new List<Factura_detalle>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_detalle TEMP = new Factura_detalle(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaFactura_detalle.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_detalle> ListaFactura_detalle { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Detalle { get; set; }
        /// <summary>
        /// Id de la factura
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Id del articulo
        /// </summary>
        public string Articulo_Factura_Detalle { get; set; }
        /// <summary>
        /// Cantidad de articulos
        /// </summary>
        public int Cantidad_Factura_Detalle { get; set; }
        /// <summary>
        /// Precio unitario del articulo
        /// </summary>
        public decimal Precio_Unitario_Factura_Detalle { get; set; }
        /// <summary>
        /// Bonificacion del articulo
        /// </summary>
        public decimal Bonifica_Factura_Detalle { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_detalle.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Detalle`, `Id_Factura`, `Articulo_Factura_Detalle`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle` FROM factura_detalle " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_detalle.
        /// </summary>
        /// <param name="Id_Factura_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la factura</param>
        /// <param name="Articulo_Factura_Detalle">Id del articulo</param>
        /// <param name="Cantidad_Factura_Detalle">Cantidad de articulos</param>
        /// <param name="Precio_Unitario_Factura_Detalle">Precio unitario del articulo</param>
        /// <param name="Bonifica_Factura_Detalle">Bonificacion del articulo</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Detalle, int Id_Factura, string Articulo_Factura_Detalle, int Cantidad_Factura_Detalle, decimal Precio_Unitario_Factura_Detalle, decimal Bonifica_Factura_Detalle)
        {
            return "INSERT INTO factura_detalle(`Id_Factura_Detalle`, `Id_Factura`, `Articulo_Factura_Detalle`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`) VALUES ('" + Id_Factura_Detalle.ToString() + "', '" + Id_Factura.ToString() + "', '" + Articulo_Factura_Detalle.ToString() + "', '" + Cantidad_Factura_Detalle.ToString() + "', '" + Precio_Unitario_Factura_Detalle.ToString() + "', '" + Bonifica_Factura_Detalle.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_detalle.
        /// </summary>
        /// <param name="Id_Factura_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la factura</param>
        /// <param name="Articulo_Factura_Detalle">Id del articulo</param>
        /// <param name="Cantidad_Factura_Detalle">Cantidad de articulos</param>
        /// <param name="Precio_Unitario_Factura_Detalle">Precio unitario del articulo</param>
        /// <param name="Bonifica_Factura_Detalle">Bonificacion del articulo</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Detalle, int Id_Factura, string Articulo_Factura_Detalle, int Cantidad_Factura_Detalle, decimal Precio_Unitario_Factura_Detalle, decimal Bonifica_Factura_Detalle, string Filtro)
        {
            return "UPDATE factura_detalle SET `Id_Factura_Detalle` = '" + Id_Factura_Detalle.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Articulo_Factura_Detalle` = '" + Articulo_Factura_Detalle.ToString() + "', `Cantidad_Factura_Detalle` = '" + Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` = '" + Precio_Unitario_Factura_Detalle.ToString() + "', `Bonifica_Factura_Detalle` = '" + Bonifica_Factura_Detalle.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_detalle Obj)
        {
            if (Obj.Articulo_Factura_Detalle == null)
            {
                throw new Exception("Articulo_Factura_Detalle no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_detalle(`Id_Factura`, `Articulo_Factura_Detalle`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Articulo_Factura_Detalle + "', " + "'" + Obj.Cantidad_Factura_Detalle.ToString() + "', " + "'" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_detalle Obj)
        {
            if (Obj.Articulo_Factura_Detalle == null)
            {
                throw new Exception("Articulo_Factura_Detalle no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Articulo_Factura_Detalle` =  '" + Obj.Articulo_Factura_Detalle + "', `Cantidad_Factura_Detalle` =  '" + Obj.Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` =  '" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', `Bonifica_Factura_Detalle` =  '" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "' WHERE factura_detalle.Id_Factura_Detalle = " + Obj.Id_Factura_Detalle.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_detalle.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_detalle WHERE factura_detalle.Id_Factura_Detalle = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_detalle Obj)
        {
            if (Obj.Articulo_Factura_Detalle == null)
            {
                throw new Exception("Articulo_Factura_Detalle no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_detalle(`Id_Factura`, `Articulo_Factura_Detalle`, `Cantidad_Factura_Detalle`, `Precio_Unitario_Factura_Detalle`, `Bonifica_Factura_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Articulo_Factura_Detalle + "', " + "'" + Obj.Cantidad_Factura_Detalle.ToString() + "', " + "'" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_detalle Obj)
        {
            if (Obj.Articulo_Factura_Detalle == null)
            {
                throw new Exception("Articulo_Factura_Detalle no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Articulo_Factura_Detalle` =  '" + Obj.Articulo_Factura_Detalle + "', `Cantidad_Factura_Detalle` =  '" + Obj.Cantidad_Factura_Detalle.ToString() + "', `Precio_Unitario_Factura_Detalle` =  '" + Obj.Precio_Unitario_Factura_Detalle.ToString().Replace(",", ".") + "', `Bonifica_Factura_Detalle` =  '" + Obj.Bonifica_Factura_Detalle.ToString().Replace(",", ".") + "' WHERE factura_detalle.Id_Factura_Detalle = " + Obj.Id_Factura_Detalle.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_detalle WHERE factura_detalle.Id_Factura_Detalle = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Asignaciones que se le hacen a las facturas
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Factura_recibo_asignaciones
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_asignaciones()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_asignaciones</param>
        public Factura_recibo_asignaciones(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Asignaciones = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Factura_Asignada_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Factura_Asignada_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Factura_Asignada_Factura_Recibo_Asignaciones = Convert.ToInt32(DataRowConstructor["Factura_Asignada_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Impresa_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Impresa_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Impresa_Factura_Recibo_Asignaciones = Convert.ToBoolean(DataRowConstructor["Impresa_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Det1_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Det1_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Det1_Factura_Recibo_Asignaciones = DataRowConstructor["Det1_Factura_Recibo_Asignaciones"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Importe_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Importe_Factura_Recibo_Asignaciones = Convert.ToDecimal(DataRowConstructor["Importe_Factura_Recibo_Asignaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Descuento_Factura_Recibo_Asignaciones"))
            {
                if (DataRowConstructor["Importe_Descuento_Factura_Recibo_Asignaciones"] != DBNull.Value)
                {
                    this.Importe_Descuento_Factura_Recibo_Asignaciones = Convert.ToDecimal(DataRowConstructor["Importe_Descuento_Factura_Recibo_Asignaciones"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_asignaciones</param>
        public Factura_recibo_asignaciones(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_asignaciones = new List<Factura_recibo_asignaciones>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_asignaciones TEMP = new Factura_recibo_asignaciones(Fila);
                TEMP.Factura = new Factura(Fila);
                this.ListaFactura_recibo_asignaciones.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_asignaciones> ListaFactura_recibo_asignaciones { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Factura, que seria el recibo u orden de pago a que se le van a asignar facturas
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// factura que se le asigna a esta orden o recibo
        /// </summary>
        public int Factura_Asignada_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool Impresa_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Det1_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Importe de lo que se le va a asignar a esta factura
        /// </summary>
        public decimal Importe_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Descuento que tiene esta facturas
        /// </summary>
        public decimal Importe_Descuento_Factura_Recibo_Asignaciones { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Asignaciones`, `Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones` FROM factura_recibo_asignaciones " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Asignaciones">ID de la tabla</param>
        /// <param name="Id_Factura">Factura, que seria el recibo u orden de pago a que se le van a asignar facturas</param>
        /// <param name="Factura_Asignada_Factura_Recibo_Asignaciones">factura que se le asigna a esta orden o recibo</param>
        /// <param name="Impresa_Factura_Recibo_Asignaciones"></param>
        /// <param name="Det1_Factura_Recibo_Asignaciones"></param>
        /// <param name="Importe_Factura_Recibo_Asignaciones">Importe de lo que se le va a asignar a esta factura</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Asignaciones">Descuento que tiene esta facturas</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Asignaciones, int Id_Factura, int Factura_Asignada_Factura_Recibo_Asignaciones, bool Impresa_Factura_Recibo_Asignaciones, string Det1_Factura_Recibo_Asignaciones, decimal Importe_Factura_Recibo_Asignaciones, decimal Importe_Descuento_Factura_Recibo_Asignaciones)
        {
            return "INSERT INTO factura_recibo_asignaciones(`Id_Factura_Recibo_Asignaciones`, `Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`) VALUES ('" + Id_Factura_Recibo_Asignaciones.ToString() + "', '" + Id_Factura.ToString() + "', '" + Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', '" + Impresa_Factura_Recibo_Asignaciones.ToString() + "', '" + Det1_Factura_Recibo_Asignaciones.ToString() + "', '" + Importe_Factura_Recibo_Asignaciones.ToString() + "', '" + Importe_Descuento_Factura_Recibo_Asignaciones.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Asignaciones">ID de la tabla</param>
        /// <param name="Id_Factura">Factura, que seria el recibo u orden de pago a que se le van a asignar facturas</param>
        /// <param name="Factura_Asignada_Factura_Recibo_Asignaciones">factura que se le asigna a esta orden o recibo</param>
        /// <param name="Impresa_Factura_Recibo_Asignaciones"></param>
        /// <param name="Det1_Factura_Recibo_Asignaciones"></param>
        /// <param name="Importe_Factura_Recibo_Asignaciones">Importe de lo que se le va a asignar a esta factura</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Asignaciones">Descuento que tiene esta facturas</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Asignaciones, int Id_Factura, int Factura_Asignada_Factura_Recibo_Asignaciones, bool Impresa_Factura_Recibo_Asignaciones, string Det1_Factura_Recibo_Asignaciones, decimal Importe_Factura_Recibo_Asignaciones, decimal Importe_Descuento_Factura_Recibo_Asignaciones, string Filtro)
        {
            return "UPDATE factura_recibo_asignaciones SET `Id_Factura_Recibo_Asignaciones` = '" + Id_Factura_Recibo_Asignaciones.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` = '" + Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = '" + Impresa_Factura_Recibo_Asignaciones.ToString() + "', `Det1_Factura_Recibo_Asignaciones` = '" + Det1_Factura_Recibo_Asignaciones.ToString() + "', `Importe_Factura_Recibo_Asignaciones` = '" + Importe_Factura_Recibo_Asignaciones.ToString() + "', `Importe_Descuento_Factura_Recibo_Asignaciones` = '" + Importe_Descuento_Factura_Recibo_Asignaciones.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_asignaciones(`Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", " + "'" + Obj.Det1_Factura_Recibo_Asignaciones + "', " + "'" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_asignaciones SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` =  '" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", `Det1_Factura_Recibo_Asignaciones` =  '" + Obj.Det1_Factura_Recibo_Asignaciones + "', `Importe_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "' WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Obj.Id_Factura_Recibo_Asignaciones.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_asignaciones.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_asignaciones WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_recibo_asignaciones(`Id_Factura`, `Factura_Asignada_Factura_Recibo_Asignaciones`, `Impresa_Factura_Recibo_Asignaciones`, `Det1_Factura_Recibo_Asignaciones`, `Importe_Factura_Recibo_Asignaciones`, `Importe_Descuento_Factura_Recibo_Asignaciones`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", " + "'" + Obj.Det1_Factura_Recibo_Asignaciones + "', " + "'" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_asignaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_asignaciones Obj)
        {
            if (Obj.Det1_Factura_Recibo_Asignaciones == null)
            {
                throw new Exception("Det1_Factura_Recibo_Asignaciones no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_recibo_asignaciones SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Factura_Asignada_Factura_Recibo_Asignaciones` =  '" + Obj.Factura_Asignada_Factura_Recibo_Asignaciones.ToString() + "', `Impresa_Factura_Recibo_Asignaciones` = " + Common.BoolToString(Obj.Impresa_Factura_Recibo_Asignaciones) + ", `Det1_Factura_Recibo_Asignaciones` =  '" + Obj.Det1_Factura_Recibo_Asignaciones + "', `Importe_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Asignaciones` =  '" + Obj.Importe_Descuento_Factura_Recibo_Asignaciones.ToString().Replace(",", ".") + "' WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Obj.Id_Factura_Recibo_Asignaciones.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_asignaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_asignaciones WHERE factura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Detalle de los recibo y ordenes
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Factura_recibo_detalle
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_detalle()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_detalle</param>
        public Factura_recibo_detalle(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Detalle = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura"))
            {
                if (DataRowConstructor["Id_Factura"] != DBNull.Value)
                {
                    this.Id_Factura = Convert.ToInt32(DataRowConstructor["Id_Factura"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Importe_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Importe_Factura_Recibo_Detalle = Convert.ToDecimal(DataRowConstructor["Importe_Factura_Recibo_Detalle"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Importe_Descuento_Factura_Recibo_Detalle"))
            {
                if (DataRowConstructor["Importe_Descuento_Factura_Recibo_Detalle"] != DBNull.Value)
                {
                    this.Importe_Descuento_Factura_Recibo_Detalle = Convert.ToDecimal(DataRowConstructor["Importe_Descuento_Factura_Recibo_Detalle"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_detalle</param>
        public Factura_recibo_detalle(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_detalle = new List<Factura_recibo_detalle>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle(Fila);
                TEMP.Factura = new Factura(Fila);
                TEMP.Factura_recibo_tipo = new Factura_recibo_tipo(Fila);
                this.ListaFactura_recibo_detalle.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_detalle> ListaFactura_recibo_detalle { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Id de la orden de pago o recibo
        /// </summary>
        public int Id_Factura { get; set; }
        /// <summary>
        /// Tipo asignacion a este recibo u orden
        /// </summary>
        public int Id_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Importe de la asignacion
        /// </summary>
        public decimal Importe_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Algun descuento a la asignacion
        /// </summary>
        public decimal Importe_Descuento_Factura_Recibo_Detalle { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura, Aca van todas las facturas
        /// </summary>
        public Factura Factura { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Factura_recibo_tipo, Tipo de pagos en recibos
        /// </summary>
        public Factura_recibo_tipo Factura_recibo_tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Detalle`, `Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle` FROM factura_recibo_detalle " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la orden de pago o recibo</param>
        /// <param name="Id_Factura_Recibo_Tipo">Tipo asignacion a este recibo u orden</param>
        /// <param name="Importe_Factura_Recibo_Detalle">Importe de la asignacion</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Detalle">Algun descuento a la asignacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Detalle, int Id_Factura, int Id_Factura_Recibo_Tipo, decimal Importe_Factura_Recibo_Detalle, decimal Importe_Descuento_Factura_Recibo_Detalle)
        {
            return "INSERT INTO factura_recibo_detalle(`Id_Factura_Recibo_Detalle`, `Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`) VALUES ('" + Id_Factura_Recibo_Detalle.ToString() + "', '" + Id_Factura.ToString() + "', '" + Id_Factura_Recibo_Tipo.ToString() + "', '" + Importe_Factura_Recibo_Detalle.ToString() + "', '" + Importe_Descuento_Factura_Recibo_Detalle.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_detalle.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Detalle">ID de la tabla</param>
        /// <param name="Id_Factura">Id de la orden de pago o recibo</param>
        /// <param name="Id_Factura_Recibo_Tipo">Tipo asignacion a este recibo u orden</param>
        /// <param name="Importe_Factura_Recibo_Detalle">Importe de la asignacion</param>
        /// <param name="Importe_Descuento_Factura_Recibo_Detalle">Algun descuento a la asignacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Detalle, int Id_Factura, int Id_Factura_Recibo_Tipo, decimal Importe_Factura_Recibo_Detalle, decimal Importe_Descuento_Factura_Recibo_Detalle, string Filtro)
        {
            return "UPDATE factura_recibo_detalle SET `Id_Factura_Recibo_Detalle` = '" + Id_Factura_Recibo_Detalle.ToString() + "', `Id_Factura` = '" + Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` = '" + Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` = '" + Importe_Factura_Recibo_Detalle.ToString() + "', `Importe_Descuento_Factura_Recibo_Detalle` = '" + Importe_Descuento_Factura_Recibo_Detalle.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_detalle(`Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', " + "'" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_detalle Obj)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` =  '" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` =  '" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Detalle` =  '" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "' WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Obj.Id_Factura_Recibo_Detalle.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_detalle.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_detalle WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_detalle Obj)
        {
            if (Common.InsertUpdate("INSERT INTO factura_recibo_detalle(`Id_Factura`, `Id_Factura_Recibo_Tipo`, `Importe_Factura_Recibo_Detalle`, `Importe_Descuento_Factura_Recibo_Detalle`)VALUES( " + "'" + Obj.Id_Factura.ToString() + "', " + "'" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', " + "'" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', " + "'" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_detalle</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_detalle Obj)
        {
            if (Common.InsertUpdate("UPDATE factura_recibo_detalle SET `Id_Factura` =  '" + Obj.Id_Factura.ToString() + "', `Id_Factura_Recibo_Tipo` =  '" + Obj.Id_Factura_Recibo_Tipo.ToString() + "', `Importe_Factura_Recibo_Detalle` =  '" + Obj.Importe_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "', `Importe_Descuento_Factura_Recibo_Detalle` =  '" + Obj.Importe_Descuento_Factura_Recibo_Detalle.ToString().Replace(",", ".") + "' WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Obj.Id_Factura_Recibo_Detalle.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_detalle. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_detalle WHERE factura_recibo_detalle.Id_Factura_Recibo_Detalle = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de pagos en recibos
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:16 p.m.
    /// </summary>
    public partial class Factura_recibo_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_recibo_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_recibo_tipo</param>
        public Factura_recibo_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Recibo_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Recibo_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Factura_Recibo_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Factura_Recibo_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Factura_Recibo_Tipo = DataRowConstructor["Descripcion_Factura_Recibo_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_recibo_tipo</param>
        public Factura_recibo_tipo(DataSet DataSetConstructor)
        {
            this.ListaFactura_recibo_tipo = new List<Factura_recibo_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_recibo_tipo TEMP = new Factura_recibo_tipo(Fila);
                this.ListaFactura_recibo_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_recibo_tipo> ListaFactura_recibo_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de recibo, es la forma de pago
        /// </summary>
        public string Descripcion_Factura_Recibo_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Recibo_Tipo`, `Descripcion_Factura_Recibo_Tipo` FROM factura_recibo_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Recibo_Tipo">Descripcion del tipo de recibo, es la forma de pago</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Recibo_Tipo, string Descripcion_Factura_Recibo_Tipo)
        {
            return "INSERT INTO factura_recibo_tipo(`Id_Factura_Recibo_Tipo`, `Descripcion_Factura_Recibo_Tipo`) VALUES ('" + Id_Factura_Recibo_Tipo.ToString() + "', '" + Descripcion_Factura_Recibo_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_recibo_tipo.
        /// </summary>
        /// <param name="Id_Factura_Recibo_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Recibo_Tipo">Descripcion del tipo de recibo, es la forma de pago</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Recibo_Tipo, string Descripcion_Factura_Recibo_Tipo, string Filtro)
        {
            return "UPDATE factura_recibo_tipo SET `Id_Factura_Recibo_Tipo` = '" + Id_Factura_Recibo_Tipo.ToString() + "', `Descripcion_Factura_Recibo_Tipo` = '" + Descripcion_Factura_Recibo_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_recibo_tipo(`Descripcion_Factura_Recibo_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Recibo_Tipo + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_recibo_tipo SET `Descripcion_Factura_Recibo_Tipo` =  '" + Obj.Descripcion_Factura_Recibo_Tipo + "' WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Obj.Id_Factura_Recibo_Tipo.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_recibo_tipo WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_recibo_tipo(`Descripcion_Factura_Recibo_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Recibo_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_recibo_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_recibo_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Recibo_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Recibo_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_recibo_tipo SET `Descripcion_Factura_Recibo_Tipo` =  '" + Obj.Descripcion_Factura_Recibo_Tipo + "' WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Obj.Id_Factura_Recibo_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_recibo_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_recibo_tipo WHERE factura_recibo_tipo.Id_Factura_Recibo_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de comprobantes
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Factura_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Factura_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Factura_tipo</param>
        public Factura_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Factura_Tipo"))
            {
                if (DataRowConstructor["Id_Factura_Tipo"] != DBNull.Value)
                {
                    this.Id_Factura_Tipo = Convert.ToInt32(DataRowConstructor["Id_Factura_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Factura_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Factura_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Factura_Tipo = DataRowConstructor["Descripcion_Factura_Tipo"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Abreviacion_Factura_Tipo"))
            {
                if (DataRowConstructor["Abreviacion_Factura_Tipo"] != DBNull.Value)
                {
                    this.Abreviacion_Factura_Tipo = DataRowConstructor["Abreviacion_Factura_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Factura_tipo</param>
        public Factura_tipo(DataSet DataSetConstructor)
        {
            this.ListaFactura_tipo = new List<Factura_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Factura_tipo TEMP = new Factura_tipo(Fila);
                this.ListaFactura_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Factura_tipo> ListaFactura_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Factura_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de factura
        /// </summary>
        public string Descripcion_Factura_Tipo { get; set; }
        /// <summary>
        /// Abreviatura del tipo de factura
        /// </summary>
        public string Abreviacion_Factura_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla factura_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Factura_Tipo`, `Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo` FROM factura_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla factura_tipo.
        /// </summary>
        /// <param name="Id_Factura_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Tipo">Descripcion del tipo de factura</param>
        /// <param name="Abreviacion_Factura_Tipo">Abreviatura del tipo de factura</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Factura_Tipo, string Descripcion_Factura_Tipo, string Abreviacion_Factura_Tipo)
        {
            return "INSERT INTO factura_tipo(`Id_Factura_Tipo`, `Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`) VALUES ('" + Id_Factura_Tipo.ToString() + "', '" + Descripcion_Factura_Tipo.ToString() + "', '" + Abreviacion_Factura_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla factura_tipo.
        /// </summary>
        /// <param name="Id_Factura_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Factura_Tipo">Descripcion del tipo de factura</param>
        /// <param name="Abreviacion_Factura_Tipo">Abreviatura del tipo de factura</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Factura_Tipo, string Descripcion_Factura_Tipo, string Abreviacion_Factura_Tipo, string Filtro)
        {
            return "UPDATE factura_tipo SET `Id_Factura_Tipo` = '" + Id_Factura_Tipo.ToString() + "', `Descripcion_Factura_Tipo` = '" + Descripcion_Factura_Tipo.ToString() + "', `Abreviacion_Factura_Tipo` = '" + Abreviacion_Factura_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO factura_tipo(`Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Tipo + "', " + "'" + Obj.Abreviacion_Factura_Tipo + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE factura_tipo SET `Descripcion_Factura_Tipo` =  '" + Obj.Descripcion_Factura_Tipo + "', `Abreviacion_Factura_Tipo` =  '" + Obj.Abreviacion_Factura_Tipo + "' WHERE factura_tipo.Id_Factura_Tipo = " + Obj.Id_Factura_Tipo.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM factura_tipo WHERE factura_tipo.Id_Factura_Tipo = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO factura_tipo(`Descripcion_Factura_Tipo`, `Abreviacion_Factura_Tipo`)VALUES( " + "'" + Obj.Descripcion_Factura_Tipo + "', " + "'" + Obj.Abreviacion_Factura_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Factura_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Factura_tipo Obj)
        {
            if (Obj.Descripcion_Factura_Tipo == null)
            {
                throw new Exception("Descripcion_Factura_Tipo no puede ser null");
            }
            if (Obj.Abreviacion_Factura_Tipo == null)
            {
                throw new Exception("Abreviacion_Factura_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE factura_tipo SET `Descripcion_Factura_Tipo` =  '" + Obj.Descripcion_Factura_Tipo + "', `Abreviacion_Factura_Tipo` =  '" + Obj.Abreviacion_Factura_Tipo + "' WHERE factura_tipo.Id_Factura_Tipo = " + Obj.Id_Factura_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Factura_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM factura_tipo WHERE factura_tipo.Id_Factura_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Contiene todas las modificaciones que se hace en la base de 
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Historial_sql
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Historial_sql()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Historial_sql</param>
        public Historial_sql(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Historial_SQL"))
            {
                if (DataRowConstructor["Id_Historial_SQL"] != DBNull.Value)
                {
                    this.Id_Historial_SQL = Convert.ToInt32(DataRowConstructor["Id_Historial_SQL"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("SQL_Historial_SQL"))
            {
                if (DataRowConstructor["SQL_Historial_SQL"] != DBNull.Value)
                {
                    this.SQL_Historial_SQL = DataRowConstructor["SQL_Historial_SQL"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Historial_SQL"))
            {
                if (DataRowConstructor["Fecha_Historial_SQL"] != DBNull.Value)
                {
                    this.Fecha_Historial_SQL = Convert.ToDateTime(DataRowConstructor["Fecha_Historial_SQL"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("IP_Historial_SQL"))
            {
                if (DataRowConstructor["IP_Historial_SQL"] != DBNull.Value)
                {
                    this.IP_Historial_SQL = DataRowConstructor["IP_Historial_SQL"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Host_Historial_SQL"))
            {
                if (DataRowConstructor["Nombre_Host_Historial_SQL"] != DBNull.Value)
                {
                    this.Nombre_Host_Historial_SQL = DataRowConstructor["Nombre_Host_Historial_SQL"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Historial_sql</param>
        public Historial_sql(DataSet DataSetConstructor)
        {
            this.ListaHistorial_sql = new List<Historial_sql>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Historial_sql TEMP = new Historial_sql(Fila);
                this.ListaHistorial_sql.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Historial_sql> ListaHistorial_sql { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Historial_SQL { get; set; }
        /// <summary>
        /// SQL que modifica la base de datos
        /// </summary>
        public string SQL_Historial_SQL { get; set; }
        /// <summary>
        /// Fecha y hora en que se ejecula la SQL
        /// </summary>
        public DateTime Fecha_Historial_SQL { get; set; }
        /// <summary>
        /// IP de donde biene el SQL
        /// </summary>
        public string IP_Historial_SQL { get; set; }
        /// <summary>
        /// Nombre del equipo
        /// </summary>
        public string Nombre_Host_Historial_SQL { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla historial_sql.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Historial_SQL`, `SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`, `Nombre_Host_Historial_SQL` FROM historial_sql " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla historial_sql.
        /// </summary>
        /// <param name="Id_Historial_SQL">ID de la tabla</param>
        /// <param name="SQL_Historial_SQL">SQL que modifica la base de datos</param>
        /// <param name="Fecha_Historial_SQL">Fecha y hora en que se ejecula la SQL</param>
        /// <param name="IP_Historial_SQL">IP de donde biene el SQL</param>
        /// <param name="Nombre_Host_Historial_SQL">Nombre del equipo</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Historial_SQL, string SQL_Historial_SQL, DateTime Fecha_Historial_SQL, string IP_Historial_SQL, string Nombre_Host_Historial_SQL)
        {
            return "INSERT INTO historial_sql(`Id_Historial_SQL`, `SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`, `Nombre_Host_Historial_SQL`) VALUES ('" + Id_Historial_SQL.ToString() + "', '" + SQL_Historial_SQL.ToString() + "', '" + Fecha_Historial_SQL.ToString() + "', '" + IP_Historial_SQL.ToString() + "', '" + Nombre_Host_Historial_SQL.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla historial_sql.
        /// </summary>
        /// <param name="Id_Historial_SQL">ID de la tabla</param>
        /// <param name="SQL_Historial_SQL">SQL que modifica la base de datos</param>
        /// <param name="Fecha_Historial_SQL">Fecha y hora en que se ejecula la SQL</param>
        /// <param name="IP_Historial_SQL">IP de donde biene el SQL</param>
        /// <param name="Nombre_Host_Historial_SQL">Nombre del equipo</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Historial_SQL, string SQL_Historial_SQL, DateTime Fecha_Historial_SQL, string IP_Historial_SQL, string Nombre_Host_Historial_SQL, string Filtro)
        {
            return "UPDATE historial_sql SET `Id_Historial_SQL` = '" + Id_Historial_SQL.ToString() + "', `SQL_Historial_SQL` = '" + SQL_Historial_SQL.ToString() + "', `Fecha_Historial_SQL` = '" + Fecha_Historial_SQL.ToString() + "', `IP_Historial_SQL` = '" + IP_Historial_SQL.ToString() + "', `Nombre_Host_Historial_SQL` = '" + Nombre_Host_Historial_SQL.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Historial_sql.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Obj.Nombre_Host_Historial_SQL == null)
            {
                throw new Exception("Nombre_Host_Historial_SQL no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO historial_sql(`SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`, `Nombre_Host_Historial_SQL`)VALUES( " + "'" + Obj.SQL_Historial_SQL + "', " + "'" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.IP_Historial_SQL + "', " + "'" + Obj.Nombre_Host_Historial_SQL + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Historial_sql.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Obj.Nombre_Host_Historial_SQL == null)
            {
                throw new Exception("Nombre_Host_Historial_SQL no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE historial_sql SET `SQL_Historial_SQL` =  '" + Obj.SQL_Historial_SQL + "', `Fecha_Historial_SQL` =  '" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', `IP_Historial_SQL` =  '" + Obj.IP_Historial_SQL + "', `Nombre_Host_Historial_SQL` =  '" + Obj.Nombre_Host_Historial_SQL + "' WHERE historial_sql.Id_Historial_SQL = " + Obj.Id_Historial_SQL.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Historial_sql.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM historial_sql WHERE historial_sql.Id_Historial_SQL = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Obj.Nombre_Host_Historial_SQL == null)
            {
                throw new Exception("Nombre_Host_Historial_SQL no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO historial_sql(`SQL_Historial_SQL`, `Fecha_Historial_SQL`, `IP_Historial_SQL`, `Nombre_Host_Historial_SQL`)VALUES( " + "'" + Obj.SQL_Historial_SQL + "', " + "'" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.IP_Historial_SQL + "', " + "'" + Obj.Nombre_Host_Historial_SQL + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Historial_sql</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Historial_sql Obj)
        {
            if (Obj.SQL_Historial_SQL == null)
            {
                throw new Exception("SQL_Historial_SQL no puede ser null");
            }
            if (Obj.Fecha_Historial_SQL == null)
            {
                throw new Exception("Fecha_Historial_SQL no puede ser null");
            }
            if (Obj.IP_Historial_SQL == null)
            {
                throw new Exception("IP_Historial_SQL no puede ser null");
            }
            if (Obj.Nombre_Host_Historial_SQL == null)
            {
                throw new Exception("Nombre_Host_Historial_SQL no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE historial_sql SET `SQL_Historial_SQL` =  '" + Obj.SQL_Historial_SQL + "', `Fecha_Historial_SQL` =  '" + Obj.Fecha_Historial_SQL.ToString("yyyy-MM-dd HH:mm:ss") + "', `IP_Historial_SQL` =  '" + Obj.IP_Historial_SQL + "', `Nombre_Host_Historial_SQL` =  '" + Obj.Nombre_Host_Historial_SQL + "' WHERE historial_sql.Id_Historial_SQL = " + Obj.Id_Historial_SQL.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Historial_sql. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM historial_sql WHERE historial_sql.Id_Historial_SQL = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Ciudades del sistema
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Localidad
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Localidad()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Localidad</param>
        public Localidad(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Provincia"))
            {
                if (DataRowConstructor["Id_Provincia"] != DBNull.Value)
                {
                    this.Id_Provincia = Convert.ToInt32(DataRowConstructor["Id_Provincia"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Localidad"))
            {
                if (DataRowConstructor["Nombre_Localidad"] != DBNull.Value)
                {
                    this.Nombre_Localidad = DataRowConstructor["Nombre_Localidad"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Codigo_Postal_Localidad"))
            {
                if (DataRowConstructor["Codigo_Postal_Localidad"] != DBNull.Value)
                {
                    this.Codigo_Postal_Localidad = Convert.ToInt32(DataRowConstructor["Codigo_Postal_Localidad"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Localidad</param>
        public Localidad(DataSet DataSetConstructor)
        {
            this.ListaLocalidad = new List<Localidad>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Localidad TEMP = new Localidad(Fila);
                TEMP.Provincia = new Provincia(Fila);
                this.ListaLocalidad.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Localidad> ListaLocalidad { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// ID de la provincia
        /// </summary>
        public int Id_Provincia { get; set; }
        /// <summary>
        /// Nombre de la localidad
        /// </summary>
        public string Nombre_Localidad { get; set; }
        /// <summary>
        /// Codigo postal de la localidad
        /// </summary>
        public int Codigo_Postal_Localidad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Provincia, Provincias del sistema
        /// </summary>
        public Provincia Provincia { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla localidad.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Localidad`, `Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad` FROM localidad " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla localidad.
        /// </summary>
        /// <param name="Id_Localidad">ID de la tabla</param>
        /// <param name="Id_Provincia">ID de la provincia</param>
        /// <param name="Nombre_Localidad">Nombre de la localidad</param>
        /// <param name="Codigo_Postal_Localidad">Codigo postal de la localidad</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Localidad, int Id_Provincia, string Nombre_Localidad, int Codigo_Postal_Localidad)
        {
            return "INSERT INTO localidad(`Id_Localidad`, `Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`) VALUES ('" + Id_Localidad.ToString() + "', '" + Id_Provincia.ToString() + "', '" + Nombre_Localidad.ToString() + "', '" + Codigo_Postal_Localidad.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla localidad.
        /// </summary>
        /// <param name="Id_Localidad">ID de la tabla</param>
        /// <param name="Id_Provincia">ID de la provincia</param>
        /// <param name="Nombre_Localidad">Nombre de la localidad</param>
        /// <param name="Codigo_Postal_Localidad">Codigo postal de la localidad</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Localidad, int Id_Provincia, string Nombre_Localidad, int Codigo_Postal_Localidad, string Filtro)
        {
            return "UPDATE localidad SET `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Id_Provincia` = '" + Id_Provincia.ToString() + "', `Nombre_Localidad` = '" + Nombre_Localidad.ToString() + "', `Codigo_Postal_Localidad` = '" + Codigo_Postal_Localidad.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Localidad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO localidad(`Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`)VALUES( " + "'" + Obj.Id_Provincia.ToString() + "', " + "'" + Obj.Nombre_Localidad + "', " + "'" + Obj.Codigo_Postal_Localidad.ToString() + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Localidad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE localidad SET `Id_Provincia` =  '" + Obj.Id_Provincia.ToString() + "', `Nombre_Localidad` =  '" + Obj.Nombre_Localidad + "', `Codigo_Postal_Localidad` =  '" + Obj.Codigo_Postal_Localidad.ToString() + "' WHERE localidad.Id_Localidad = " + Obj.Id_Localidad.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Localidad.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM localidad WHERE localidad.Id_Localidad = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO localidad(`Id_Provincia`, `Nombre_Localidad`, `Codigo_Postal_Localidad`)VALUES( " + "'" + Obj.Id_Provincia.ToString() + "', " + "'" + Obj.Nombre_Localidad + "', " + "'" + Obj.Codigo_Postal_Localidad.ToString() + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Localidad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Localidad Obj)
        {
            if (Obj.Nombre_Localidad == null)
            {
                throw new Exception("Nombre_Localidad no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE localidad SET `Id_Provincia` =  '" + Obj.Id_Provincia.ToString() + "', `Nombre_Localidad` =  '" + Obj.Nombre_Localidad + "', `Codigo_Postal_Localidad` =  '" + Obj.Codigo_Postal_Localidad.ToString() + "' WHERE localidad.Id_Localidad = " + Obj.Id_Localidad.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Localidad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM localidad WHERE localidad.Id_Localidad = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se guardan los medicamentos
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Medicacion
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Medicacion()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Medicacion</param>
        public Medicacion(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion"))
            {
                if (DataRowConstructor["Id_Medicacion"] != DBNull.Value)
                {
                    this.Id_Medicacion = Convert.ToInt32(DataRowConstructor["Id_Medicacion"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Laboratorio"))
            {
                if (DataRowConstructor["Id_Medicacion_Laboratorio"] != DBNull.Value)
                {
                    this.Id_Medicacion_Laboratorio = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Laboratorio"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Accion_Farmacologica"))
            {
                if (DataRowConstructor["Id_Medicacion_Accion_Farmacologica"] != DBNull.Value)
                {
                    this.Id_Medicacion_Accion_Farmacologica = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Accion_Farmacologica"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Autorizacion"))
            {
                if (DataRowConstructor["Id_Medicacion_Autorizacion"] != DBNull.Value)
                {
                    this.Id_Medicacion_Autorizacion = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Autorizacion"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Principio_Activo_Medicacion"))
            {
                if (DataRowConstructor["Principio_Activo_Medicacion"] != DBNull.Value)
                {
                    this.Principio_Activo_Medicacion = DataRowConstructor["Principio_Activo_Medicacion"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Comercial_Medicacion"))
            {
                if (DataRowConstructor["Nombre_Comercial_Medicacion"] != DBNull.Value)
                {
                    this.Nombre_Comercial_Medicacion = DataRowConstructor["Nombre_Comercial_Medicacion"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Presentacion_Medicacion"))
            {
                if (DataRowConstructor["Presentacion_Medicacion"] != DBNull.Value)
                {
                    this.Presentacion_Medicacion = DataRowConstructor["Presentacion_Medicacion"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Regis_Medicacion"))
            {
                if (DataRowConstructor["Regis_Medicacion"] != DBNull.Value)
                {
                    this.Regis_Medicacion = DataRowConstructor["Regis_Medicacion"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Troquel_Medicacion"))
            {
                if (DataRowConstructor["Troquel_Medicacion"] != DBNull.Value)
                {
                    this.Troquel_Medicacion = DataRowConstructor["Troquel_Medicacion"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Medicacion"))
            {
                if (DataRowConstructor["Observaciones_Medicacion"] != DBNull.Value)
                {
                    this.Observaciones_Medicacion = DataRowConstructor["Observaciones_Medicacion"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Medicacion</param>
        public Medicacion(DataSet DataSetConstructor)
        {
            this.ListaMedicacion = new List<Medicacion>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Medicacion TEMP = new Medicacion(Fila);
                TEMP.Medicacion_laboratorio = new Medicacion_laboratorio(Fila);
                TEMP.Medicacion_accion_farmacologica = new Medicacion_accion_farmacologica(Fila);
                TEMP.Medicacion_autorizacion = new Medicacion_autorizacion(Fila);
                this.ListaMedicacion.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Medicacion> ListaMedicacion { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Medicacion { get; set; }
        /// <summary>
        /// Id del laboratorio
        /// </summary>
        public int Id_Medicacion_Laboratorio { get; set; }
        /// <summary>
        /// id de la accion facmacologica
        /// </summary>
        public int Id_Medicacion_Accion_Farmacologica { get; set; }
        /// <summary>
        /// id de la autorizacion
        /// </summary>
        public int Id_Medicacion_Autorizacion { get; set; }
        /// <summary>
        /// Principio activo
        /// </summary>
        public string Principio_Activo_Medicacion { get; set; }
        /// <summary>
        /// Nombre comercial
        /// </summary>
        public string Nombre_Comercial_Medicacion { get; set; }
        /// <summary>
        /// Presentacion
        /// </summary>
        public string Presentacion_Medicacion { get; set; }
        /// <summary>
        /// Regis
        /// </summary>
        public string Regis_Medicacion { get; set; }
        /// <summary>
        /// Troquel
        /// </summary>
        public string Troquel_Medicacion { get; set; }
        /// <summary>
        /// Obsercaciones de la medicacion
        /// </summary>
        public string Observaciones_Medicacion { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Medicacion_laboratorio, Se guardan los laboratorios para los medicamentos.
        /// </summary>
        public Medicacion_laboratorio Medicacion_laboratorio { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Medicacion_accion_farmacologica, Se guardan las acciones farmacologicas para la medicacion
        /// </summary>
        public Medicacion_accion_farmacologica Medicacion_accion_farmacologica { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Medicacion_autorizacion, Son las autorizaciones para los medicamentos.
        /// </summary>
        public Medicacion_autorizacion Medicacion_autorizacion { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla medicacion.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Medicacion`, `Id_Medicacion_Laboratorio`, `Id_Medicacion_Accion_Farmacologica`, `Id_Medicacion_Autorizacion`, `Principio_Activo_Medicacion`, `Nombre_Comercial_Medicacion`, `Presentacion_Medicacion`, `Regis_Medicacion`, `Troquel_Medicacion`, `Observaciones_Medicacion` FROM medicacion " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla medicacion.
        /// </summary>
        /// <param name="Id_Medicacion">Id de la tabla</param>
        /// <param name="Id_Medicacion_Laboratorio">Id del laboratorio</param>
        /// <param name="Id_Medicacion_Accion_Farmacologica">id de la accion facmacologica</param>
        /// <param name="Id_Medicacion_Autorizacion">id de la autorizacion</param>
        /// <param name="Principio_Activo_Medicacion">Principio activo</param>
        /// <param name="Nombre_Comercial_Medicacion">Nombre comercial</param>
        /// <param name="Presentacion_Medicacion">Presentacion</param>
        /// <param name="Regis_Medicacion">Regis</param>
        /// <param name="Troquel_Medicacion">Troquel</param>
        /// <param name="Observaciones_Medicacion">Obsercaciones de la medicacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Medicacion, int Id_Medicacion_Laboratorio, int Id_Medicacion_Accion_Farmacologica, int Id_Medicacion_Autorizacion, string Principio_Activo_Medicacion, string Nombre_Comercial_Medicacion, string Presentacion_Medicacion, string Regis_Medicacion, string Troquel_Medicacion, string Observaciones_Medicacion)
        {
            return "INSERT INTO medicacion(`Id_Medicacion`, `Id_Medicacion_Laboratorio`, `Id_Medicacion_Accion_Farmacologica`, `Id_Medicacion_Autorizacion`, `Principio_Activo_Medicacion`, `Nombre_Comercial_Medicacion`, `Presentacion_Medicacion`, `Regis_Medicacion`, `Troquel_Medicacion`, `Observaciones_Medicacion`) VALUES ('" + Id_Medicacion.ToString() + "', '" + Id_Medicacion_Laboratorio.ToString() + "', '" + Id_Medicacion_Accion_Farmacologica.ToString() + "', '" + Id_Medicacion_Autorizacion.ToString() + "', '" + Principio_Activo_Medicacion.ToString() + "', '" + Nombre_Comercial_Medicacion.ToString() + "', '" + Presentacion_Medicacion.ToString() + "', '" + Regis_Medicacion.ToString() + "', '" + Troquel_Medicacion.ToString() + "', '" + Observaciones_Medicacion.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla medicacion.
        /// </summary>
        /// <param name="Id_Medicacion">Id de la tabla</param>
        /// <param name="Id_Medicacion_Laboratorio">Id del laboratorio</param>
        /// <param name="Id_Medicacion_Accion_Farmacologica">id de la accion facmacologica</param>
        /// <param name="Id_Medicacion_Autorizacion">id de la autorizacion</param>
        /// <param name="Principio_Activo_Medicacion">Principio activo</param>
        /// <param name="Nombre_Comercial_Medicacion">Nombre comercial</param>
        /// <param name="Presentacion_Medicacion">Presentacion</param>
        /// <param name="Regis_Medicacion">Regis</param>
        /// <param name="Troquel_Medicacion">Troquel</param>
        /// <param name="Observaciones_Medicacion">Obsercaciones de la medicacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Medicacion, int Id_Medicacion_Laboratorio, int Id_Medicacion_Accion_Farmacologica, int Id_Medicacion_Autorizacion, string Principio_Activo_Medicacion, string Nombre_Comercial_Medicacion, string Presentacion_Medicacion, string Regis_Medicacion, string Troquel_Medicacion, string Observaciones_Medicacion, string Filtro)
        {
            return "UPDATE medicacion SET `Id_Medicacion` = '" + Id_Medicacion.ToString() + "', `Id_Medicacion_Laboratorio` = '" + Id_Medicacion_Laboratorio.ToString() + "', `Id_Medicacion_Accion_Farmacologica` = '" + Id_Medicacion_Accion_Farmacologica.ToString() + "', `Id_Medicacion_Autorizacion` = '" + Id_Medicacion_Autorizacion.ToString() + "', `Principio_Activo_Medicacion` = '" + Principio_Activo_Medicacion.ToString() + "', `Nombre_Comercial_Medicacion` = '" + Nombre_Comercial_Medicacion.ToString() + "', `Presentacion_Medicacion` = '" + Presentacion_Medicacion.ToString() + "', `Regis_Medicacion` = '" + Regis_Medicacion.ToString() + "', `Troquel_Medicacion` = '" + Troquel_Medicacion.ToString() + "', `Observaciones_Medicacion` = '" + Observaciones_Medicacion.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Medicacion Obj)
        {
            if (Obj.Principio_Activo_Medicacion == null)
            {
                throw new Exception("Principio_Activo_Medicacion no puede ser null");
            }
            if (Obj.Nombre_Comercial_Medicacion == null)
            {
                throw new Exception("Nombre_Comercial_Medicacion no puede ser null");
            }
            if (Obj.Presentacion_Medicacion == null)
            {
                throw new Exception("Presentacion_Medicacion no puede ser null");
            }
            if (Obj.Regis_Medicacion == null)
            {
                throw new Exception("Regis_Medicacion no puede ser null");
            }
            if (Obj.Troquel_Medicacion == null)
            {
                throw new Exception("Troquel_Medicacion no puede ser null");
            }
            if (Obj.Observaciones_Medicacion == null)
            {
                throw new Exception("Observaciones_Medicacion no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO medicacion(`Id_Medicacion_Laboratorio`, `Id_Medicacion_Accion_Farmacologica`, `Id_Medicacion_Autorizacion`, `Principio_Activo_Medicacion`, `Nombre_Comercial_Medicacion`, `Presentacion_Medicacion`, `Regis_Medicacion`, `Troquel_Medicacion`, `Observaciones_Medicacion`)VALUES( " + "'" + Obj.Id_Medicacion_Laboratorio.ToString() + "', " + "'" + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + "', " + "'" + Obj.Id_Medicacion_Autorizacion.ToString() + "', " + "'" + Obj.Principio_Activo_Medicacion + "', " + "'" + Obj.Nombre_Comercial_Medicacion + "', " + "'" + Obj.Presentacion_Medicacion + "', " + "'" + Obj.Regis_Medicacion + "', " + "'" + Obj.Troquel_Medicacion + "', " + "'" + Obj.Observaciones_Medicacion + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Medicacion Obj)
        {
            if (Obj.Principio_Activo_Medicacion == null)
            {
                throw new Exception("Principio_Activo_Medicacion no puede ser null");
            }
            if (Obj.Nombre_Comercial_Medicacion == null)
            {
                throw new Exception("Nombre_Comercial_Medicacion no puede ser null");
            }
            if (Obj.Presentacion_Medicacion == null)
            {
                throw new Exception("Presentacion_Medicacion no puede ser null");
            }
            if (Obj.Regis_Medicacion == null)
            {
                throw new Exception("Regis_Medicacion no puede ser null");
            }
            if (Obj.Troquel_Medicacion == null)
            {
                throw new Exception("Troquel_Medicacion no puede ser null");
            }
            if (Obj.Observaciones_Medicacion == null)
            {
                throw new Exception("Observaciones_Medicacion no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE medicacion SET `Id_Medicacion_Laboratorio` =  '" + Obj.Id_Medicacion_Laboratorio.ToString() + "', `Id_Medicacion_Accion_Farmacologica` =  '" + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + "', `Id_Medicacion_Autorizacion` =  '" + Obj.Id_Medicacion_Autorizacion.ToString() + "', `Principio_Activo_Medicacion` =  '" + Obj.Principio_Activo_Medicacion + "', `Nombre_Comercial_Medicacion` =  '" + Obj.Nombre_Comercial_Medicacion + "', `Presentacion_Medicacion` =  '" + Obj.Presentacion_Medicacion + "', `Regis_Medicacion` =  '" + Obj.Regis_Medicacion + "', `Troquel_Medicacion` =  '" + Obj.Troquel_Medicacion + "', `Observaciones_Medicacion` =  '" + Obj.Observaciones_Medicacion + "' WHERE medicacion.Id_Medicacion = " + Obj.Id_Medicacion.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM medicacion WHERE medicacion.Id_Medicacion = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Medicacion Obj)
        {
            if (Obj.Principio_Activo_Medicacion == null)
            {
                throw new Exception("Principio_Activo_Medicacion no puede ser null");
            }
            if (Obj.Nombre_Comercial_Medicacion == null)
            {
                throw new Exception("Nombre_Comercial_Medicacion no puede ser null");
            }
            if (Obj.Presentacion_Medicacion == null)
            {
                throw new Exception("Presentacion_Medicacion no puede ser null");
            }
            if (Obj.Regis_Medicacion == null)
            {
                throw new Exception("Regis_Medicacion no puede ser null");
            }
            if (Obj.Troquel_Medicacion == null)
            {
                throw new Exception("Troquel_Medicacion no puede ser null");
            }
            if (Obj.Observaciones_Medicacion == null)
            {
                throw new Exception("Observaciones_Medicacion no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO medicacion(`Id_Medicacion_Laboratorio`, `Id_Medicacion_Accion_Farmacologica`, `Id_Medicacion_Autorizacion`, `Principio_Activo_Medicacion`, `Nombre_Comercial_Medicacion`, `Presentacion_Medicacion`, `Regis_Medicacion`, `Troquel_Medicacion`, `Observaciones_Medicacion`)VALUES( " + "'" + Obj.Id_Medicacion_Laboratorio.ToString() + "', " + "'" + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + "', " + "'" + Obj.Id_Medicacion_Autorizacion.ToString() + "', " + "'" + Obj.Principio_Activo_Medicacion + "', " + "'" + Obj.Nombre_Comercial_Medicacion + "', " + "'" + Obj.Presentacion_Medicacion + "', " + "'" + Obj.Regis_Medicacion + "', " + "'" + Obj.Troquel_Medicacion + "', " + "'" + Obj.Observaciones_Medicacion + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Medicacion Obj)
        {
            if (Obj.Principio_Activo_Medicacion == null)
            {
                throw new Exception("Principio_Activo_Medicacion no puede ser null");
            }
            if (Obj.Nombre_Comercial_Medicacion == null)
            {
                throw new Exception("Nombre_Comercial_Medicacion no puede ser null");
            }
            if (Obj.Presentacion_Medicacion == null)
            {
                throw new Exception("Presentacion_Medicacion no puede ser null");
            }
            if (Obj.Regis_Medicacion == null)
            {
                throw new Exception("Regis_Medicacion no puede ser null");
            }
            if (Obj.Troquel_Medicacion == null)
            {
                throw new Exception("Troquel_Medicacion no puede ser null");
            }
            if (Obj.Observaciones_Medicacion == null)
            {
                throw new Exception("Observaciones_Medicacion no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE medicacion SET `Id_Medicacion_Laboratorio` =  '" + Obj.Id_Medicacion_Laboratorio.ToString() + "', `Id_Medicacion_Accion_Farmacologica` =  '" + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + "', `Id_Medicacion_Autorizacion` =  '" + Obj.Id_Medicacion_Autorizacion.ToString() + "', `Principio_Activo_Medicacion` =  '" + Obj.Principio_Activo_Medicacion + "', `Nombre_Comercial_Medicacion` =  '" + Obj.Nombre_Comercial_Medicacion + "', `Presentacion_Medicacion` =  '" + Obj.Presentacion_Medicacion + "', `Regis_Medicacion` =  '" + Obj.Regis_Medicacion + "', `Troquel_Medicacion` =  '" + Obj.Troquel_Medicacion + "', `Observaciones_Medicacion` =  '" + Obj.Observaciones_Medicacion + "' WHERE medicacion.Id_Medicacion = " + Obj.Id_Medicacion.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM medicacion WHERE medicacion.Id_Medicacion = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se guardan las acciones farmacologicas para la medicacion
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Medicacion_accion_farmacologica
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Medicacion_accion_farmacologica()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Medicacion_accion_farmacologica</param>
        public Medicacion_accion_farmacologica(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Accion_Farmacologica"))
            {
                if (DataRowConstructor["Id_Medicacion_Accion_Farmacologica"] != DBNull.Value)
                {
                    this.Id_Medicacion_Accion_Farmacologica = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Accion_Farmacologica"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Medicacion_Accion_Farmacologica"))
            {
                if (DataRowConstructor["Descripcion_Medicacion_Accion_Farmacologica"] != DBNull.Value)
                {
                    this.Descripcion_Medicacion_Accion_Farmacologica = DataRowConstructor["Descripcion_Medicacion_Accion_Farmacologica"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Medicacion_accion_farmacologica</param>
        public Medicacion_accion_farmacologica(DataSet DataSetConstructor)
        {
            this.ListaMedicacion_accion_farmacologica = new List<Medicacion_accion_farmacologica>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Medicacion_accion_farmacologica TEMP = new Medicacion_accion_farmacologica(Fila);
                this.ListaMedicacion_accion_farmacologica.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Medicacion_accion_farmacologica> ListaMedicacion_accion_farmacologica { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Medicacion_Accion_Farmacologica { get; set; }
        /// <summary>
        /// Descripcion de la accion farmacologica
        /// </summary>
        public string Descripcion_Medicacion_Accion_Farmacologica { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Medicacion_Accion_Farmacologica`, `Descripcion_Medicacion_Accion_Farmacologica` FROM medicacion_accion_farmacologica " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Id_Medicacion_Accion_Farmacologica">Id de la tabla</param>
        /// <param name="Descripcion_Medicacion_Accion_Farmacologica">Descripcion de la accion farmacologica</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Medicacion_Accion_Farmacologica, string Descripcion_Medicacion_Accion_Farmacologica)
        {
            return "INSERT INTO medicacion_accion_farmacologica(`Id_Medicacion_Accion_Farmacologica`, `Descripcion_Medicacion_Accion_Farmacologica`) VALUES ('" + Id_Medicacion_Accion_Farmacologica.ToString() + "', '" + Descripcion_Medicacion_Accion_Farmacologica.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Id_Medicacion_Accion_Farmacologica">Id de la tabla</param>
        /// <param name="Descripcion_Medicacion_Accion_Farmacologica">Descripcion de la accion farmacologica</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Medicacion_Accion_Farmacologica, string Descripcion_Medicacion_Accion_Farmacologica, string Filtro)
        {
            return "UPDATE medicacion_accion_farmacologica SET `Id_Medicacion_Accion_Farmacologica` = '" + Id_Medicacion_Accion_Farmacologica.ToString() + "', `Descripcion_Medicacion_Accion_Farmacologica` = '" + Descripcion_Medicacion_Accion_Farmacologica.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_accion_farmacologica</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Medicacion_accion_farmacologica Obj)
        {
            if (Obj.Descripcion_Medicacion_Accion_Farmacologica == null)
            {
                throw new Exception("Descripcion_Medicacion_Accion_Farmacologica no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO medicacion_accion_farmacologica(`Descripcion_Medicacion_Accion_Farmacologica`)VALUES( " + "'" + Obj.Descripcion_Medicacion_Accion_Farmacologica + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_accion_farmacologica</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Medicacion_accion_farmacologica Obj)
        {
            if (Obj.Descripcion_Medicacion_Accion_Farmacologica == null)
            {
                throw new Exception("Descripcion_Medicacion_Accion_Farmacologica no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE medicacion_accion_farmacologica SET `Descripcion_Medicacion_Accion_Farmacologica` =  '" + Obj.Descripcion_Medicacion_Accion_Farmacologica + "' WHERE medicacion_accion_farmacologica.Id_Medicacion_Accion_Farmacologica = " + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_accion_farmacologica.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM medicacion_accion_farmacologica WHERE medicacion_accion_farmacologica.Id_Medicacion_Accion_Farmacologica = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_accion_farmacologica. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_accion_farmacologica</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Medicacion_accion_farmacologica Obj)
        {
            if (Obj.Descripcion_Medicacion_Accion_Farmacologica == null)
            {
                throw new Exception("Descripcion_Medicacion_Accion_Farmacologica no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO medicacion_accion_farmacologica(`Descripcion_Medicacion_Accion_Farmacologica`)VALUES( " + "'" + Obj.Descripcion_Medicacion_Accion_Farmacologica + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_accion_farmacologica. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_accion_farmacologica</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Medicacion_accion_farmacologica Obj)
        {
            if (Obj.Descripcion_Medicacion_Accion_Farmacologica == null)
            {
                throw new Exception("Descripcion_Medicacion_Accion_Farmacologica no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE medicacion_accion_farmacologica SET `Descripcion_Medicacion_Accion_Farmacologica` =  '" + Obj.Descripcion_Medicacion_Accion_Farmacologica + "' WHERE medicacion_accion_farmacologica.Id_Medicacion_Accion_Farmacologica = " + Obj.Id_Medicacion_Accion_Farmacologica.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_accion_farmacologica. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM medicacion_accion_farmacologica WHERE medicacion_accion_farmacologica.Id_Medicacion_Accion_Farmacologica = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Son las autorizaciones para los medicamentos.
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Medicacion_autorizacion
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Medicacion_autorizacion()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Medicacion_autorizacion</param>
        public Medicacion_autorizacion(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Autorizacion"))
            {
                if (DataRowConstructor["Id_Medicacion_Autorizacion"] != DBNull.Value)
                {
                    this.Id_Medicacion_Autorizacion = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Autorizacion"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Medicacion_Autorizacion"))
            {
                if (DataRowConstructor["Descripcion_Medicacion_Autorizacion"] != DBNull.Value)
                {
                    this.Descripcion_Medicacion_Autorizacion = DataRowConstructor["Descripcion_Medicacion_Autorizacion"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Medicacion_autorizacion</param>
        public Medicacion_autorizacion(DataSet DataSetConstructor)
        {
            this.ListaMedicacion_autorizacion = new List<Medicacion_autorizacion>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Medicacion_autorizacion TEMP = new Medicacion_autorizacion(Fila);
                this.ListaMedicacion_autorizacion.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Medicacion_autorizacion> ListaMedicacion_autorizacion { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Medicacion_Autorizacion { get; set; }
        /// <summary>
        /// Descripcion de la autorizacion
        /// </summary>
        public string Descripcion_Medicacion_Autorizacion { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla medicacion_autorizacion.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Medicacion_Autorizacion`, `Descripcion_Medicacion_Autorizacion` FROM medicacion_autorizacion " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla medicacion_autorizacion.
        /// </summary>
        /// <param name="Id_Medicacion_Autorizacion">Id de la tabla</param>
        /// <param name="Descripcion_Medicacion_Autorizacion">Descripcion de la autorizacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Medicacion_Autorizacion, string Descripcion_Medicacion_Autorizacion)
        {
            return "INSERT INTO medicacion_autorizacion(`Id_Medicacion_Autorizacion`, `Descripcion_Medicacion_Autorizacion`) VALUES ('" + Id_Medicacion_Autorizacion.ToString() + "', '" + Descripcion_Medicacion_Autorizacion.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla medicacion_autorizacion.
        /// </summary>
        /// <param name="Id_Medicacion_Autorizacion">Id de la tabla</param>
        /// <param name="Descripcion_Medicacion_Autorizacion">Descripcion de la autorizacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Medicacion_Autorizacion, string Descripcion_Medicacion_Autorizacion, string Filtro)
        {
            return "UPDATE medicacion_autorizacion SET `Id_Medicacion_Autorizacion` = '" + Id_Medicacion_Autorizacion.ToString() + "', `Descripcion_Medicacion_Autorizacion` = '" + Descripcion_Medicacion_Autorizacion.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_autorizacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_autorizacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Medicacion_autorizacion Obj)
        {
            if (Obj.Descripcion_Medicacion_Autorizacion == null)
            {
                throw new Exception("Descripcion_Medicacion_Autorizacion no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO medicacion_autorizacion(`Descripcion_Medicacion_Autorizacion`)VALUES( " + "'" + Obj.Descripcion_Medicacion_Autorizacion + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_autorizacion.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_autorizacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Medicacion_autorizacion Obj)
        {
            if (Obj.Descripcion_Medicacion_Autorizacion == null)
            {
                throw new Exception("Descripcion_Medicacion_Autorizacion no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE medicacion_autorizacion SET `Descripcion_Medicacion_Autorizacion` =  '" + Obj.Descripcion_Medicacion_Autorizacion + "' WHERE medicacion_autorizacion.Id_Medicacion_Autorizacion = " + Obj.Id_Medicacion_Autorizacion.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_autorizacion.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM medicacion_autorizacion WHERE medicacion_autorizacion.Id_Medicacion_Autorizacion = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_autorizacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_autorizacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Medicacion_autorizacion Obj)
        {
            if (Obj.Descripcion_Medicacion_Autorizacion == null)
            {
                throw new Exception("Descripcion_Medicacion_Autorizacion no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO medicacion_autorizacion(`Descripcion_Medicacion_Autorizacion`)VALUES( " + "'" + Obj.Descripcion_Medicacion_Autorizacion + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_autorizacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_autorizacion</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Medicacion_autorizacion Obj)
        {
            if (Obj.Descripcion_Medicacion_Autorizacion == null)
            {
                throw new Exception("Descripcion_Medicacion_Autorizacion no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE medicacion_autorizacion SET `Descripcion_Medicacion_Autorizacion` =  '" + Obj.Descripcion_Medicacion_Autorizacion + "' WHERE medicacion_autorizacion.Id_Medicacion_Autorizacion = " + Obj.Id_Medicacion_Autorizacion.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_autorizacion. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM medicacion_autorizacion WHERE medicacion_autorizacion.Id_Medicacion_Autorizacion = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Se guardan los laboratorios para los medicamentos.
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Medicacion_laboratorio
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Medicacion_laboratorio()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Medicacion_laboratorio</param>
        public Medicacion_laboratorio(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Medicacion_Laboratorio"))
            {
                if (DataRowConstructor["Id_Medicacion_Laboratorio"] != DBNull.Value)
                {
                    this.Id_Medicacion_Laboratorio = Convert.ToInt32(DataRowConstructor["Id_Medicacion_Laboratorio"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Laboratorio"))
            {
                if (DataRowConstructor["Descripcion_Laboratorio"] != DBNull.Value)
                {
                    this.Descripcion_Laboratorio = DataRowConstructor["Descripcion_Laboratorio"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Medicacion_laboratorio</param>
        public Medicacion_laboratorio(DataSet DataSetConstructor)
        {
            this.ListaMedicacion_laboratorio = new List<Medicacion_laboratorio>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Medicacion_laboratorio TEMP = new Medicacion_laboratorio(Fila);
                this.ListaMedicacion_laboratorio.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Medicacion_laboratorio> ListaMedicacion_laboratorio { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Medicacion_Laboratorio { get; set; }
        /// <summary>
        /// Descripcion del Laboratorio
        /// </summary>
        public string Descripcion_Laboratorio { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla medicacion_laboratorio.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Medicacion_Laboratorio`, `Descripcion_Laboratorio` FROM medicacion_laboratorio " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla medicacion_laboratorio.
        /// </summary>
        /// <param name="Id_Medicacion_Laboratorio">Id de la tabla</param>
        /// <param name="Descripcion_Laboratorio">Descripcion del Laboratorio</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Medicacion_Laboratorio, string Descripcion_Laboratorio)
        {
            return "INSERT INTO medicacion_laboratorio(`Id_Medicacion_Laboratorio`, `Descripcion_Laboratorio`) VALUES ('" + Id_Medicacion_Laboratorio.ToString() + "', '" + Descripcion_Laboratorio.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla medicacion_laboratorio.
        /// </summary>
        /// <param name="Id_Medicacion_Laboratorio">Id de la tabla</param>
        /// <param name="Descripcion_Laboratorio">Descripcion del Laboratorio</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Medicacion_Laboratorio, string Descripcion_Laboratorio, string Filtro)
        {
            return "UPDATE medicacion_laboratorio SET `Id_Medicacion_Laboratorio` = '" + Id_Medicacion_Laboratorio.ToString() + "', `Descripcion_Laboratorio` = '" + Descripcion_Laboratorio.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_laboratorio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_laboratorio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Medicacion_laboratorio Obj)
        {
            if (Obj.Descripcion_Laboratorio == null)
            {
                throw new Exception("Descripcion_Laboratorio no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO medicacion_laboratorio(`Descripcion_Laboratorio`)VALUES( " + "'" + Obj.Descripcion_Laboratorio + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_laboratorio.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_laboratorio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Medicacion_laboratorio Obj)
        {
            if (Obj.Descripcion_Laboratorio == null)
            {
                throw new Exception("Descripcion_Laboratorio no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE medicacion_laboratorio SET `Descripcion_Laboratorio` =  '" + Obj.Descripcion_Laboratorio + "' WHERE medicacion_laboratorio.Id_Medicacion_Laboratorio = " + Obj.Id_Medicacion_Laboratorio.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_laboratorio.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM medicacion_laboratorio WHERE medicacion_laboratorio.Id_Medicacion_Laboratorio = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Medicacion_laboratorio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_laboratorio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Medicacion_laboratorio Obj)
        {
            if (Obj.Descripcion_Laboratorio == null)
            {
                throw new Exception("Descripcion_Laboratorio no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO medicacion_laboratorio(`Descripcion_Laboratorio`)VALUES( " + "'" + Obj.Descripcion_Laboratorio + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Medicacion_laboratorio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Medicacion_laboratorio</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Medicacion_laboratorio Obj)
        {
            if (Obj.Descripcion_Laboratorio == null)
            {
                throw new Exception("Descripcion_Laboratorio no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE medicacion_laboratorio SET `Descripcion_Laboratorio` =  '" + Obj.Descripcion_Laboratorio + "' WHERE medicacion_laboratorio.Id_Medicacion_Laboratorio = " + Obj.Id_Medicacion_Laboratorio.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Medicacion_laboratorio. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM medicacion_laboratorio WHERE medicacion_laboratorio.Id_Medicacion_Laboratorio = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: 
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Obra_social
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Obra_social()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Obra_social</param>
        public Obra_social(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Obra_Social"))
            {
                if (DataRowConstructor["Id_Obra_Social"] != DBNull.Value)
                {
                    this.Id_Obra_Social = Convert.ToInt32(DataRowConstructor["Id_Obra_Social"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Obra_Social"))
            {
                if (DataRowConstructor["Descripcion_Obra_Social"] != DBNull.Value)
                {
                    this.Descripcion_Obra_Social = DataRowConstructor["Descripcion_Obra_Social"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Obra_Social"))
            {
                if (DataRowConstructor["Observaciones_Obra_Social"] != DBNull.Value)
                {
                    this.Observaciones_Obra_Social = DataRowConstructor["Observaciones_Obra_Social"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Obra_social</param>
        public Obra_social(DataSet DataSetConstructor)
        {
            this.ListaObra_social = new List<Obra_social>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Obra_social TEMP = new Obra_social(Fila);
                this.ListaObra_social.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Obra_social> ListaObra_social { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Obra_Social { get; set; }
        /// <summary>
        /// Descripcion de la obra social
        /// </summary>
        public string Descripcion_Obra_Social { get; set; }
        /// <summary>
        /// Observaciones de la obra social
        /// </summary>
        public string Observaciones_Obra_Social { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla obra_social.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Obra_Social`, `Descripcion_Obra_Social`, `Observaciones_Obra_Social` FROM obra_social " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla obra_social.
        /// </summary>
        /// <param name="Id_Obra_Social">Id de la tabla</param>
        /// <param name="Descripcion_Obra_Social">Descripcion de la obra social</param>
        /// <param name="Observaciones_Obra_Social">Observaciones de la obra social</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Obra_Social, string Descripcion_Obra_Social, string Observaciones_Obra_Social)
        {
            return "INSERT INTO obra_social(`Id_Obra_Social`, `Descripcion_Obra_Social`, `Observaciones_Obra_Social`) VALUES ('" + Id_Obra_Social.ToString() + "', '" + Descripcion_Obra_Social.ToString() + "', '" + Observaciones_Obra_Social.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla obra_social.
        /// </summary>
        /// <param name="Id_Obra_Social">Id de la tabla</param>
        /// <param name="Descripcion_Obra_Social">Descripcion de la obra social</param>
        /// <param name="Observaciones_Obra_Social">Observaciones de la obra social</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Obra_Social, string Descripcion_Obra_Social, string Observaciones_Obra_Social, string Filtro)
        {
            return "UPDATE obra_social SET `Id_Obra_Social` = '" + Id_Obra_Social.ToString() + "', `Descripcion_Obra_Social` = '" + Descripcion_Obra_Social.ToString() + "', `Observaciones_Obra_Social` = '" + Observaciones_Obra_Social.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Obra_social.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Obra_social</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Obra_social Obj)
        {
            if (Obj.Descripcion_Obra_Social == null)
            {
                throw new Exception("Descripcion_Obra_Social no puede ser null");
            }
            if (Obj.Observaciones_Obra_Social == null)
            {
                throw new Exception("Observaciones_Obra_Social no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO obra_social(`Descripcion_Obra_Social`, `Observaciones_Obra_Social`)VALUES( " + "'" + Obj.Descripcion_Obra_Social + "', " + "'" + Obj.Observaciones_Obra_Social + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Obra_social.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Obra_social</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Obra_social Obj)
        {
            if (Obj.Descripcion_Obra_Social == null)
            {
                throw new Exception("Descripcion_Obra_Social no puede ser null");
            }
            if (Obj.Observaciones_Obra_Social == null)
            {
                throw new Exception("Observaciones_Obra_Social no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE obra_social SET `Descripcion_Obra_Social` =  '" + Obj.Descripcion_Obra_Social + "', `Observaciones_Obra_Social` =  '" + Obj.Observaciones_Obra_Social + "' WHERE obra_social.Id_Obra_Social = " + Obj.Id_Obra_Social.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Obra_social.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM obra_social WHERE obra_social.Id_Obra_Social = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Obra_social. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Obra_social</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Obra_social Obj)
        {
            if (Obj.Descripcion_Obra_Social == null)
            {
                throw new Exception("Descripcion_Obra_Social no puede ser null");
            }
            if (Obj.Observaciones_Obra_Social == null)
            {
                throw new Exception("Observaciones_Obra_Social no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO obra_social(`Descripcion_Obra_Social`, `Observaciones_Obra_Social`)VALUES( " + "'" + Obj.Descripcion_Obra_Social + "', " + "'" + Obj.Observaciones_Obra_Social + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Obra_social. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Obra_social</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Obra_social Obj)
        {
            if (Obj.Descripcion_Obra_Social == null)
            {
                throw new Exception("Descripcion_Obra_Social no puede ser null");
            }
            if (Obj.Observaciones_Obra_Social == null)
            {
                throw new Exception("Observaciones_Obra_Social no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE obra_social SET `Descripcion_Obra_Social` =  '" + Obj.Descripcion_Obra_Social + "', `Observaciones_Obra_Social` =  '" + Obj.Observaciones_Obra_Social + "' WHERE obra_social.Id_Obra_Social = " + Obj.Id_Obra_Social.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Obra_social. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM obra_social WHERE obra_social.Id_Obra_Social = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Paises del sistema
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Pais
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Pais()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Pais</param>
        public Pais(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Pais"))
            {
                if (DataRowConstructor["Id_Pais"] != DBNull.Value)
                {
                    this.Id_Pais = Convert.ToInt32(DataRowConstructor["Id_Pais"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Pais"))
            {
                if (DataRowConstructor["Nombre_Pais"] != DBNull.Value)
                {
                    this.Nombre_Pais = DataRowConstructor["Nombre_Pais"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Pais</param>
        public Pais(DataSet DataSetConstructor)
        {
            this.ListaPais = new List<Pais>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Pais TEMP = new Pais(Fila);
                this.ListaPais.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Pais> ListaPais { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Pais { get; set; }
        /// <summary>
        /// Nombre del pais
        /// </summary>
        public string Nombre_Pais { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla pais.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Pais`, `Nombre_Pais` FROM pais " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla pais.
        /// </summary>
        /// <param name="Id_Pais">ID de la tabla</param>
        /// <param name="Nombre_Pais">Nombre del pais</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Pais, string Nombre_Pais)
        {
            return "INSERT INTO pais(`Id_Pais`, `Nombre_Pais`) VALUES ('" + Id_Pais.ToString() + "', '" + Nombre_Pais.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla pais.
        /// </summary>
        /// <param name="Id_Pais">ID de la tabla</param>
        /// <param name="Nombre_Pais">Nombre del pais</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Pais, string Nombre_Pais, string Filtro)
        {
            return "UPDATE pais SET `Id_Pais` = '" + Id_Pais.ToString() + "', `Nombre_Pais` = '" + Nombre_Pais.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Pais.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO pais(`Nombre_Pais`)VALUES( " + "'" + Obj.Nombre_Pais + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Pais.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE pais SET `Nombre_Pais` =  '" + Obj.Nombre_Pais + "' WHERE pais.Id_Pais = " + Obj.Id_Pais.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Pais.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM pais WHERE pais.Id_Pais = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO pais(`Nombre_Pais`)VALUES( " + "'" + Obj.Nombre_Pais + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Pais</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Pais Obj)
        {
            if (Obj.Nombre_Pais == null)
            {
                throw new Exception("Nombre_Pais no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE pais SET `Nombre_Pais` =  '" + Obj.Nombre_Pais + "' WHERE pais.Id_Pais = " + Obj.Id_Pais.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Pais. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM pais WHERE pais.Id_Pais = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Provincias del sistema
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Provincia
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Provincia()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Provincia</param>
        public Provincia(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Provincia"))
            {
                if (DataRowConstructor["Id_Provincia"] != DBNull.Value)
                {
                    this.Id_Provincia = Convert.ToInt32(DataRowConstructor["Id_Provincia"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Pais"))
            {
                if (DataRowConstructor["Id_Pais"] != DBNull.Value)
                {
                    this.Id_Pais = Convert.ToInt32(DataRowConstructor["Id_Pais"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Nombre_Provincia"))
            {
                if (DataRowConstructor["Nombre_Provincia"] != DBNull.Value)
                {
                    this.Nombre_Provincia = DataRowConstructor["Nombre_Provincia"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Provincia</param>
        public Provincia(DataSet DataSetConstructor)
        {
            this.ListaProvincia = new List<Provincia>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Provincia TEMP = new Provincia(Fila);
                TEMP.Pais = new Pais(Fila);
                this.ListaProvincia.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Provincia> ListaProvincia { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Provincia { get; set; }
        /// <summary>
        /// Id del pais
        /// </summary>
        public int Id_Pais { get; set; }
        /// <summary>
        /// Nombre de la provincia
        /// </summary>
        public string Nombre_Provincia { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Pais, Paises del sistema
        /// </summary>
        public Pais Pais { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla provincia.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Provincia`, `Id_Pais`, `Nombre_Provincia` FROM provincia " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla provincia.
        /// </summary>
        /// <param name="Id_Provincia">ID de la tabla</param>
        /// <param name="Id_Pais">Id del pais</param>
        /// <param name="Nombre_Provincia">Nombre de la provincia</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Provincia, int Id_Pais, string Nombre_Provincia)
        {
            return "INSERT INTO provincia(`Id_Provincia`, `Id_Pais`, `Nombre_Provincia`) VALUES ('" + Id_Provincia.ToString() + "', '" + Id_Pais.ToString() + "', '" + Nombre_Provincia.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla provincia.
        /// </summary>
        /// <param name="Id_Provincia">ID de la tabla</param>
        /// <param name="Id_Pais">Id del pais</param>
        /// <param name="Nombre_Provincia">Nombre de la provincia</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Provincia, int Id_Pais, string Nombre_Provincia, string Filtro)
        {
            return "UPDATE provincia SET `Id_Provincia` = '" + Id_Provincia.ToString() + "', `Id_Pais` = '" + Id_Pais.ToString() + "', `Nombre_Provincia` = '" + Nombre_Provincia.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Provincia.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO provincia(`Id_Pais`, `Nombre_Provincia`)VALUES( " + "'" + Obj.Id_Pais.ToString() + "', " + "'" + Obj.Nombre_Provincia + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Provincia.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE provincia SET `Id_Pais` =  '" + Obj.Id_Pais.ToString() + "', `Nombre_Provincia` =  '" + Obj.Nombre_Provincia + "' WHERE provincia.Id_Provincia = " + Obj.Id_Provincia.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Provincia.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM provincia WHERE provincia.Id_Provincia = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO provincia(`Id_Pais`, `Nombre_Provincia`)VALUES( " + "'" + Obj.Id_Pais.ToString() + "', " + "'" + Obj.Nombre_Provincia + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Provincia</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Provincia Obj)
        {
            if (Obj.Nombre_Provincia == null)
            {
                throw new Exception("Nombre_Provincia no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE provincia SET `Id_Pais` =  '" + Obj.Id_Pais.ToString() + "', `Nombre_Provincia` =  '" + Obj.Nombre_Provincia + "' WHERE provincia.Id_Provincia = " + Obj.Id_Provincia.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Provincia. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM provincia WHERE provincia.Id_Provincia = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Lleva el control del los auto incrementos de los comprobante
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Series
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Series()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Series</param>
        public Series(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Comprobante"))
            {
                if (DataRowConstructor["Comprobante"] != DBNull.Value)
                {
                    this.Comprobante = DataRowConstructor["Comprobante"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Numero"))
            {
                if (DataRowConstructor["Numero"] != DBNull.Value)
                {
                    this.Numero = Convert.ToInt32(DataRowConstructor["Numero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Bloqueado"))
            {
                if (DataRowConstructor["Bloqueado"] != DBNull.Value)
                {
                    this.Bloqueado = Convert.ToBoolean(DataRowConstructor["Bloqueado"]);
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Series</param>
        public Series(DataSet DataSetConstructor)
        {
            this.ListaSeries = new List<Series>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Series TEMP = new Series(Fila);
                this.ListaSeries.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Series> ListaSeries { get; set; }
        /// <summary>
        /// Tipo de comprobantes
        /// </summary>
        public string Comprobante { get; set; }
        /// <summary>
        /// Numero de comprobante siguiente
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Verdadero si esta bloqueado
        /// </summary>
        public bool Bloqueado { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla series.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Comprobante`, `Numero`, `Bloqueado` FROM series " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla series.
        /// </summary>
        /// <param name="Comprobante">Tipo de comprobantes</param>
        /// <param name="Numero">Numero de comprobante siguiente</param>
        /// <param name="Bloqueado">Verdadero si esta bloqueado</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(string Comprobante, int Numero, bool Bloqueado)
        {
            return "INSERT INTO series(`Comprobante`, `Numero`, `Bloqueado`) VALUES ('" + Comprobante.ToString() + "', '" + Numero.ToString() + "', '" + Bloqueado.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla series.
        /// </summary>
        /// <param name="Comprobante">Tipo de comprobantes</param>
        /// <param name="Numero">Numero de comprobante siguiente</param>
        /// <param name="Bloqueado">Verdadero si esta bloqueado</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(string Comprobante, int Numero, bool Bloqueado, string Filtro)
        {
            return "UPDATE series SET `Comprobante` = '" + Comprobante.ToString() + "', `Numero` = '" + Numero.ToString() + "', `Bloqueado` = '" + Bloqueado.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Series.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO series(`Numero`, `Bloqueado`)VALUES( " + "'" + Obj.Numero.ToString() + "', " + Common.BoolToString(Obj.Bloqueado) + "" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Series.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = " + Obj.Comprobante.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Series.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM series WHERE series.Comprobante = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO series(`Numero`, `Bloqueado`)VALUES( " + "'" + Obj.Numero.ToString() + "', " + Common.BoolToString(Obj.Bloqueado) + "" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = " + Obj.Comprobante.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Series. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM series WHERE series.Comprobante = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Guarda los cliente y los proveedores
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:17 p.m.
    /// </summary>
    public partial class Tercero
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero</param>
        public Tercero(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Tipo"))
            {
                if (DataRowConstructor["Id_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Id_Tercero_Tipo = Convert.ToInt32(DataRowConstructor["Id_Tercero_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Localidad"))
            {
                if (DataRowConstructor["Id_Localidad"] != DBNull.Value)
                {
                    this.Id_Localidad = Convert.ToInt32(DataRowConstructor["Id_Localidad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Obra_Social"))
            {
                if (DataRowConstructor["Id_Obra_Social"] != DBNull.Value)
                {
                    this.Id_Obra_Social = Convert.ToInt32(DataRowConstructor["Id_Obra_Social"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Razon_Social_Tercero"))
            {
                if (DataRowConstructor["Razon_Social_Tercero"] != DBNull.Value)
                {
                    this.Razon_Social_Tercero = DataRowConstructor["Razon_Social_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Direccion_Tercero"))
            {
                if (DataRowConstructor["Direccion_Tercero"] != DBNull.Value)
                {
                    this.Direccion_Tercero = DataRowConstructor["Direccion_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Nacimiento_Tercero"))
            {
                if (DataRowConstructor["Fecha_Nacimiento_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Nacimiento_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Nacimiento_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("CUIT_Tercero"))
            {
                if (DataRowConstructor["CUIT_Tercero"] != DBNull.Value)
                {
                    this.CUIT_Tercero = DataRowConstructor["CUIT_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Telefonos_Tercero"))
            {
                if (DataRowConstructor["Telefonos_Tercero"] != DBNull.Value)
                {
                    this.Telefonos_Tercero = DataRowConstructor["Telefonos_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("DNI_Tercero"))
            {
                if (DataRowConstructor["DNI_Tercero"] != DBNull.Value)
                {
                    this.DNI_Tercero = Convert.ToInt32(DataRowConstructor["DNI_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fax_Tercero"))
            {
                if (DataRowConstructor["Fax_Tercero"] != DBNull.Value)
                {
                    this.Fax_Tercero = DataRowConstructor["Fax_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Email_Tercero"))
            {
                if (DataRowConstructor["Email_Tercero"] != DBNull.Value)
                {
                    this.Email_Tercero = DataRowConstructor["Email_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Alta_Tercero"))
            {
                if (DataRowConstructor["Fecha_Alta_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Alta_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Alta_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Baja_Tercero"))
            {
                if (DataRowConstructor["Fecha_Baja_Tercero"] != DBNull.Value)
                {
                    this.Fecha_Baja_Tercero = Convert.ToDateTime(DataRowConstructor["Fecha_Baja_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Anulado_Tercero"))
            {
                if (DataRowConstructor["Anulado_Tercero"] != DBNull.Value)
                {
                    this.Anulado_Tercero = Convert.ToBoolean(DataRowConstructor["Anulado_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Sexo_Tercero"))
            {
                if (DataRowConstructor["Sexo_Tercero"] != DBNull.Value)
                {
                    this.Sexo_Tercero = Convert.ToBoolean(DataRowConstructor["Sexo_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Estado_Civil_Tercero"))
            {
                if (DataRowConstructor["Estado_Civil_Tercero"] != DBNull.Value)
                {
                    this.Estado_Civil_Tercero = DataRowConstructor["Estado_Civil_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Ocupacion_Tercero"))
            {
                if (DataRowConstructor["Ocupacion_Tercero"] != DBNull.Value)
                {
                    this.Ocupacion_Tercero = DataRowConstructor["Ocupacion_Tercero"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Ultima_Consulta_Tercero"))
            {
                if (DataRowConstructor["Ultima_Consulta_Tercero"] != DBNull.Value)
                {
                    this.Ultima_Consulta_Tercero = Convert.ToDateTime(DataRowConstructor["Ultima_Consulta_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Tercero"))
            {
                if (DataRowConstructor["Observaciones_Tercero"] != DBNull.Value)
                {
                    this.Observaciones_Tercero = DataRowConstructor["Observaciones_Tercero"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero</param>
        public Tercero(DataSet DataSetConstructor)
        {
            this.ListaTercero = new List<Tercero>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero TEMP = new Tercero(Fila);
                TEMP.Tercero_tipo = new Tercero_tipo(Fila);
                TEMP.Tercero_iva = new Tercero_iva(Fila);
                TEMP.Localidad = new Localidad(Fila);
                TEMP.Obra_social = new Obra_social(Fila);
                this.ListaTercero.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero> ListaTercero { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Para saber si proveedor o cliente
        /// </summary>
        public int Id_Tercero_Tipo { get; set; }
        /// <summary>
        /// La condicion de iva del tercero
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// ID de la localidad de la aplicacion
        /// </summary>
        public int Id_Localidad { get; set; }
        /// <summary>
        /// Id de la obra social
        /// </summary>
        public int Id_Obra_Social { get; set; }
        /// <summary>
        /// Razon social, nombre y apellido del tercero
        /// </summary>
        public string Razon_Social_Tercero { get; set; }
        /// <summary>
        /// Direccion del tercero
        /// </summary>
        public string Direccion_Tercero { get; set; }
        /// <summary>
        /// Fecha de nacimiento
        /// </summary>
        public DateTime Fecha_Nacimiento_Tercero { get; set; }
        /// <summary>
        /// CUIT del tercero (por lo general a proveedores
        /// </summary>
        public string CUIT_Tercero { get; set; }
        /// <summary>
        /// Telefonos del tercero
        /// </summary>
        public string Telefonos_Tercero { get; set; }
        /// <summary>
        /// DNI del tercero
        /// </summary>
        public int DNI_Tercero { get; set; }
        /// <summary>
        /// Fax del tercer
        /// </summary>
        public string Fax_Tercero { get; set; }
        /// <summary>
        /// "Email del tercero
        /// </summary>
        public string Email_Tercero { get; set; }
        /// <summary>
        /// Fecha de alta del tercero
        /// </summary>
        public DateTime Fecha_Alta_Tercero { get; set; }
        /// <summary>
        /// Fecha de baja del tercero
        /// </summary>
        public DateTime Fecha_Baja_Tercero { get; set; }
        /// <summary>
        /// Es verdadero si esta anulado este tercero
        /// </summary>
        public bool Anulado_Tercero { get; set; }
        /// <summary>
        /// Sexo (Masculino - Femenino) del tercero
        /// </summary>
        public bool Sexo_Tercero { get; set; }
        /// <summary>
        /// Estado civil (soltero,casado,divorciado,viudo,separado) del tercero
        /// </summary>
        public string Estado_Civil_Tercero { get; set; }
        /// <summary>
        /// Ocupacion, trabajo del tercero
        /// </summary>
        public string Ocupacion_Tercero { get; set; }
        /// <summary>
        /// Ultima consulta que realizo un paciente
        /// </summary>
        public DateTime Ultima_Consulta_Tercero { get; set; }
        /// <summary>
        /// Observaciones del tercero
        /// </summary>
        public string Observaciones_Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_tipo, Para saber si es proveedor o cliente
        /// </summary>
        public Tercero_tipo Tercero_tipo { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero_iva, Tipo de condicion de IVA
        /// </summary>
        public Tercero_iva Tercero_iva { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Localidad, Ciudades del sistema
        /// </summary>
        public Localidad Localidad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Obra_social, 
        /// </summary>
        public Obra_social Obra_social { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero`, `Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Id_Obra_Social`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Sexo_Tercero`, `Estado_Civil_Tercero`, `Ocupacion_Tercero`, `Ultima_Consulta_Tercero`, `Observaciones_Tercero` FROM tercero " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero.
        /// </summary>
        /// <param name="Id_Tercero">ID de la tabla</param>
        /// <param name="Id_Tercero_Tipo">Para saber si proveedor o cliente</param>
        /// <param name="Id_Tercero_IVA">La condicion de iva del tercero</param>
        /// <param name="Id_Localidad">ID de la localidad de la aplicacion</param>
        /// <param name="Id_Obra_Social">Id de la obra social</param>
        /// <param name="Razon_Social_Tercero">Razon social, nombre y apellido del tercero</param>
        /// <param name="Direccion_Tercero">Direccion del tercero</param>
        /// <param name="Fecha_Nacimiento_Tercero">Fecha de nacimiento</param>
        /// <param name="CUIT_Tercero">CUIT del tercero (por lo general a proveedores</param>
        /// <param name="Telefonos_Tercero">Telefonos del tercero</param>
        /// <param name="DNI_Tercero">DNI del tercero</param>
        /// <param name="Fax_Tercero">Fax del tercer</param>
        /// <param name="Email_Tercero">"Email del tercero</param>
        /// <param name="Fecha_Alta_Tercero">Fecha de alta del tercero</param>
        /// <param name="Fecha_Baja_Tercero">Fecha de baja del tercero</param>
        /// <param name="Anulado_Tercero">Es verdadero si esta anulado este tercero</param>
        /// <param name="Sexo_Tercero">Sexo (Masculino - Femenino) del tercero</param>
        /// <param name="Estado_Civil_Tercero">Estado civil (soltero,casado,divorciado,viudo,separado) del tercero</param>
        /// <param name="Ocupacion_Tercero">Ocupacion, trabajo del tercero</param>
        /// <param name="Ultima_Consulta_Tercero">Ultima consulta que realizo un paciente</param>
        /// <param name="Observaciones_Tercero">Observaciones del tercero</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero, int Id_Tercero_Tipo, int Id_Tercero_IVA, int Id_Localidad, int Id_Obra_Social, string Razon_Social_Tercero, string Direccion_Tercero, DateTime Fecha_Nacimiento_Tercero, string CUIT_Tercero, string Telefonos_Tercero, int DNI_Tercero, string Fax_Tercero, string Email_Tercero, DateTime Fecha_Alta_Tercero, DateTime Fecha_Baja_Tercero, bool Anulado_Tercero, bool Sexo_Tercero, string Estado_Civil_Tercero, string Ocupacion_Tercero, DateTime Ultima_Consulta_Tercero, string Observaciones_Tercero)
        {
            return "INSERT INTO tercero(`Id_Tercero`, `Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Id_Obra_Social`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Sexo_Tercero`, `Estado_Civil_Tercero`, `Ocupacion_Tercero`, `Ultima_Consulta_Tercero`, `Observaciones_Tercero`) VALUES ('" + Id_Tercero.ToString() + "', '" + Id_Tercero_Tipo.ToString() + "', '" + Id_Tercero_IVA.ToString() + "', '" + Id_Localidad.ToString() + "', '" + Id_Obra_Social.ToString() + "', '" + Razon_Social_Tercero.ToString() + "', '" + Direccion_Tercero.ToString() + "', '" + Fecha_Nacimiento_Tercero.ToString() + "', '" + CUIT_Tercero.ToString() + "', '" + Telefonos_Tercero.ToString() + "', '" + DNI_Tercero.ToString() + "', '" + Fax_Tercero.ToString() + "', '" + Email_Tercero.ToString() + "', '" + Fecha_Alta_Tercero.ToString() + "', '" + Fecha_Baja_Tercero.ToString() + "', '" + Anulado_Tercero.ToString() + "', '" + Sexo_Tercero.ToString() + "', '" + Estado_Civil_Tercero.ToString() + "', '" + Ocupacion_Tercero.ToString() + "', '" + Ultima_Consulta_Tercero.ToString() + "', '" + Observaciones_Tercero.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero.
        /// </summary>
        /// <param name="Id_Tercero">ID de la tabla</param>
        /// <param name="Id_Tercero_Tipo">Para saber si proveedor o cliente</param>
        /// <param name="Id_Tercero_IVA">La condicion de iva del tercero</param>
        /// <param name="Id_Localidad">ID de la localidad de la aplicacion</param>
        /// <param name="Id_Obra_Social">Id de la obra social</param>
        /// <param name="Razon_Social_Tercero">Razon social, nombre y apellido del tercero</param>
        /// <param name="Direccion_Tercero">Direccion del tercero</param>
        /// <param name="Fecha_Nacimiento_Tercero">Fecha de nacimiento</param>
        /// <param name="CUIT_Tercero">CUIT del tercero (por lo general a proveedores</param>
        /// <param name="Telefonos_Tercero">Telefonos del tercero</param>
        /// <param name="DNI_Tercero">DNI del tercero</param>
        /// <param name="Fax_Tercero">Fax del tercer</param>
        /// <param name="Email_Tercero">"Email del tercero</param>
        /// <param name="Fecha_Alta_Tercero">Fecha de alta del tercero</param>
        /// <param name="Fecha_Baja_Tercero">Fecha de baja del tercero</param>
        /// <param name="Anulado_Tercero">Es verdadero si esta anulado este tercero</param>
        /// <param name="Sexo_Tercero">Sexo (Masculino - Femenino) del tercero</param>
        /// <param name="Estado_Civil_Tercero">Estado civil (soltero,casado,divorciado,viudo,separado) del tercero</param>
        /// <param name="Ocupacion_Tercero">Ocupacion, trabajo del tercero</param>
        /// <param name="Ultima_Consulta_Tercero">Ultima consulta que realizo un paciente</param>
        /// <param name="Observaciones_Tercero">Observaciones del tercero</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero, int Id_Tercero_Tipo, int Id_Tercero_IVA, int Id_Localidad, int Id_Obra_Social, string Razon_Social_Tercero, string Direccion_Tercero, DateTime Fecha_Nacimiento_Tercero, string CUIT_Tercero, string Telefonos_Tercero, int DNI_Tercero, string Fax_Tercero, string Email_Tercero, DateTime Fecha_Alta_Tercero, DateTime Fecha_Baja_Tercero, bool Anulado_Tercero, bool Sexo_Tercero, string Estado_Civil_Tercero, string Ocupacion_Tercero, DateTime Ultima_Consulta_Tercero, string Observaciones_Tercero, string Filtro)
        {
            return "UPDATE tercero SET `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Tercero_Tipo` = '" + Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Id_Localidad` = '" + Id_Localidad.ToString() + "', `Id_Obra_Social` = '" + Id_Obra_Social.ToString() + "', `Razon_Social_Tercero` = '" + Razon_Social_Tercero.ToString() + "', `Direccion_Tercero` = '" + Direccion_Tercero.ToString() + "', `Fecha_Nacimiento_Tercero` = '" + Fecha_Nacimiento_Tercero.ToString() + "', `CUIT_Tercero` = '" + CUIT_Tercero.ToString() + "', `Telefonos_Tercero` = '" + Telefonos_Tercero.ToString() + "', `DNI_Tercero` = '" + DNI_Tercero.ToString() + "', `Fax_Tercero` = '" + Fax_Tercero.ToString() + "', `Email_Tercero` = '" + Email_Tercero.ToString() + "', `Fecha_Alta_Tercero` = '" + Fecha_Alta_Tercero.ToString() + "', `Fecha_Baja_Tercero` = '" + Fecha_Baja_Tercero.ToString() + "', `Anulado_Tercero` = '" + Anulado_Tercero.ToString() + "', `Sexo_Tercero` = '" + Sexo_Tercero.ToString() + "', `Estado_Civil_Tercero` = '" + Estado_Civil_Tercero.ToString() + "', `Ocupacion_Tercero` = '" + Ocupacion_Tercero.ToString() + "', `Ultima_Consulta_Tercero` = '" + Ultima_Consulta_Tercero.ToString() + "', `Observaciones_Tercero` = '" + Observaciones_Tercero.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Estado_Civil_Tercero == null)
            {
                throw new Exception("Estado_Civil_Tercero no puede ser null");
            }
            if (Obj.Ocupacion_Tercero == null)
            {
                throw new Exception("Ocupacion_Tercero no puede ser null");
            }
            if (Obj.Ultima_Consulta_Tercero == null)
            {
                throw new Exception("Ultima_Consulta_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero(`Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Id_Obra_Social`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Sexo_Tercero`, `Estado_Civil_Tercero`, `Ocupacion_Tercero`, `Ultima_Consulta_Tercero`, `Observaciones_Tercero`)VALUES( " + "'" + Obj.Id_Tercero_Tipo.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Obra_Social.ToString() + "', " + "'" + Obj.Razon_Social_Tercero + "', " + "'" + Obj.Direccion_Tercero + "', " + "'" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.CUIT_Tercero + "', " + "'" + Obj.Telefonos_Tercero + "', " + "'" + Obj.DNI_Tercero.ToString() + "', " + "'" + Obj.Fax_Tercero + "', " + "'" + Obj.Email_Tercero + "', " + "'" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Anulado_Tercero) + ", " + Common.BoolToString(Obj.Sexo_Tercero) + ", " + "'" + Obj.Estado_Civil_Tercero + "', " + "'" + Obj.Ocupacion_Tercero + "', " + "'" + Obj.Ultima_Consulta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Tercero + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Estado_Civil_Tercero == null)
            {
                throw new Exception("Estado_Civil_Tercero no puede ser null");
            }
            if (Obj.Ocupacion_Tercero == null)
            {
                throw new Exception("Ocupacion_Tercero no puede ser null");
            }
            if (Obj.Ultima_Consulta_Tercero == null)
            {
                throw new Exception("Ultima_Consulta_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero SET `Id_Tercero_Tipo` =  '" + Obj.Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Obra_Social` =  '" + Obj.Id_Obra_Social.ToString() + "', `Razon_Social_Tercero` =  '" + Obj.Razon_Social_Tercero + "', `Direccion_Tercero` =  '" + Obj.Direccion_Tercero + "', `Fecha_Nacimiento_Tercero` =  '" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `CUIT_Tercero` =  '" + Obj.CUIT_Tercero + "', `Telefonos_Tercero` =  '" + Obj.Telefonos_Tercero + "', `DNI_Tercero` =  '" + Obj.DNI_Tercero.ToString() + "', `Fax_Tercero` =  '" + Obj.Fax_Tercero + "', `Email_Tercero` =  '" + Obj.Email_Tercero + "', `Fecha_Alta_Tercero` =  '" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Baja_Tercero` =  '" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Anulado_Tercero` = " + Common.BoolToString(Obj.Anulado_Tercero) + ", `Sexo_Tercero` = " + Common.BoolToString(Obj.Sexo_Tercero) + ", `Estado_Civil_Tercero` =  '" + Obj.Estado_Civil_Tercero + "', `Ocupacion_Tercero` =  '" + Obj.Ocupacion_Tercero + "', `Ultima_Consulta_Tercero` =  '" + Obj.Ultima_Consulta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Tercero` =  '" + Obj.Observaciones_Tercero + "' WHERE tercero.Id_Tercero = " + Obj.Id_Tercero.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero WHERE tercero.Id_Tercero = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Estado_Civil_Tercero == null)
            {
                throw new Exception("Estado_Civil_Tercero no puede ser null");
            }
            if (Obj.Ocupacion_Tercero == null)
            {
                throw new Exception("Ocupacion_Tercero no puede ser null");
            }
            if (Obj.Ultima_Consulta_Tercero == null)
            {
                throw new Exception("Ultima_Consulta_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero(`Id_Tercero_Tipo`, `Id_Tercero_IVA`, `Id_Localidad`, `Id_Obra_Social`, `Razon_Social_Tercero`, `Direccion_Tercero`, `Fecha_Nacimiento_Tercero`, `CUIT_Tercero`, `Telefonos_Tercero`, `DNI_Tercero`, `Fax_Tercero`, `Email_Tercero`, `Fecha_Alta_Tercero`, `Fecha_Baja_Tercero`, `Anulado_Tercero`, `Sexo_Tercero`, `Estado_Civil_Tercero`, `Ocupacion_Tercero`, `Ultima_Consulta_Tercero`, `Observaciones_Tercero`)VALUES( " + "'" + Obj.Id_Tercero_Tipo.ToString() + "', " + "'" + Obj.Id_Tercero_IVA.ToString() + "', " + "'" + Obj.Id_Localidad.ToString() + "', " + "'" + Obj.Id_Obra_Social.ToString() + "', " + "'" + Obj.Razon_Social_Tercero + "', " + "'" + Obj.Direccion_Tercero + "', " + "'" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.CUIT_Tercero + "', " + "'" + Obj.Telefonos_Tercero + "', " + "'" + Obj.DNI_Tercero.ToString() + "', " + "'" + Obj.Fax_Tercero + "', " + "'" + Obj.Email_Tercero + "', " + "'" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + Common.BoolToString(Obj.Anulado_Tercero) + ", " + Common.BoolToString(Obj.Sexo_Tercero) + ", " + "'" + Obj.Estado_Civil_Tercero + "', " + "'" + Obj.Ocupacion_Tercero + "', " + "'" + Obj.Ultima_Consulta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Tercero + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero Obj)
        {
            if (Obj.Razon_Social_Tercero == null)
            {
                throw new Exception("Razon_Social_Tercero no puede ser null");
            }
            if (Obj.Direccion_Tercero == null)
            {
                throw new Exception("Direccion_Tercero no puede ser null");
            }
            if (Obj.Fecha_Nacimiento_Tercero == null)
            {
                throw new Exception("Fecha_Nacimiento_Tercero no puede ser null");
            }
            if (Obj.CUIT_Tercero == null)
            {
                throw new Exception("CUIT_Tercero no puede ser null");
            }
            if (Obj.Telefonos_Tercero == null)
            {
                throw new Exception("Telefonos_Tercero no puede ser null");
            }
            if (Obj.Fax_Tercero == null)
            {
                throw new Exception("Fax_Tercero no puede ser null");
            }
            if (Obj.Email_Tercero == null)
            {
                throw new Exception("Email_Tercero no puede ser null");
            }
            if (Obj.Fecha_Alta_Tercero == null)
            {
                throw new Exception("Fecha_Alta_Tercero no puede ser null");
            }
            if (Obj.Fecha_Baja_Tercero == null)
            {
                throw new Exception("Fecha_Baja_Tercero no puede ser null");
            }
            if (Obj.Estado_Civil_Tercero == null)
            {
                throw new Exception("Estado_Civil_Tercero no puede ser null");
            }
            if (Obj.Ocupacion_Tercero == null)
            {
                throw new Exception("Ocupacion_Tercero no puede ser null");
            }
            if (Obj.Ultima_Consulta_Tercero == null)
            {
                throw new Exception("Ultima_Consulta_Tercero no puede ser null");
            }
            if (Obj.Observaciones_Tercero == null)
            {
                throw new Exception("Observaciones_Tercero no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero SET `Id_Tercero_Tipo` =  '" + Obj.Id_Tercero_Tipo.ToString() + "', `Id_Tercero_IVA` =  '" + Obj.Id_Tercero_IVA.ToString() + "', `Id_Localidad` =  '" + Obj.Id_Localidad.ToString() + "', `Id_Obra_Social` =  '" + Obj.Id_Obra_Social.ToString() + "', `Razon_Social_Tercero` =  '" + Obj.Razon_Social_Tercero + "', `Direccion_Tercero` =  '" + Obj.Direccion_Tercero + "', `Fecha_Nacimiento_Tercero` =  '" + Obj.Fecha_Nacimiento_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `CUIT_Tercero` =  '" + Obj.CUIT_Tercero + "', `Telefonos_Tercero` =  '" + Obj.Telefonos_Tercero + "', `DNI_Tercero` =  '" + Obj.DNI_Tercero.ToString() + "', `Fax_Tercero` =  '" + Obj.Fax_Tercero + "', `Email_Tercero` =  '" + Obj.Email_Tercero + "', `Fecha_Alta_Tercero` =  '" + Obj.Fecha_Alta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Fecha_Baja_Tercero` =  '" + Obj.Fecha_Baja_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Anulado_Tercero` = " + Common.BoolToString(Obj.Anulado_Tercero) + ", `Sexo_Tercero` = " + Common.BoolToString(Obj.Sexo_Tercero) + ", `Estado_Civil_Tercero` =  '" + Obj.Estado_Civil_Tercero + "', `Ocupacion_Tercero` =  '" + Obj.Ocupacion_Tercero + "', `Ultima_Consulta_Tercero` =  '" + Obj.Ultima_Consulta_Tercero.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Tercero` =  '" + Obj.Observaciones_Tercero + "' WHERE tercero.Id_Tercero = " + Obj.Id_Tercero.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero WHERE tercero.Id_Tercero = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Enfermedades de un terecero
    /// La última modificación fué el martes, 06 de diciembre de 2011 a las 04:46:37 p.m.
    /// </summary>
    public partial class Tercero_enfermedad
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_enfermedad()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_enfermedad</param>
        public Tercero_enfermedad(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Enfermedad"))
            {
                if (DataRowConstructor["Id_Tercero_Enfermedad"] != DBNull.Value)
                {
                    this.Id_Tercero_Enfermedad = Convert.ToInt32(DataRowConstructor["Id_Tercero_Enfermedad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Enfermedad"))
            {
                if (DataRowConstructor["Id_Enfermedad"] != DBNull.Value)
                {
                    this.Id_Enfermedad = Convert.ToInt32(DataRowConstructor["Id_Enfermedad"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Tercero_Enfermedad"))
            {
                if (DataRowConstructor["Observaciones_Tercero_Enfermedad"] != DBNull.Value)
                {
                    this.Observaciones_Tercero_Enfermedad = DataRowConstructor["Observaciones_Tercero_Enfermedad"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_enfermedad</param>
        public Tercero_enfermedad(DataSet DataSetConstructor)
        {
            this.ListaTercero_enfermedad = new List<Tercero_enfermedad>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_enfermedad TEMP = new Tercero_enfermedad(Fila);
                TEMP.Tercero = new Tercero(Fila);
                TEMP.Enfermedad = new Enfermedad(Fila);
                this.ListaTercero_enfermedad.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_enfermedad> ListaTercero_enfermedad { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Tercero_Enfermedad { get; set; }
        /// <summary>
        /// Id del tercero en cuestion
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Enfermeadad relacionada
        /// </summary>
        public int Id_Enfermedad { get; set; }
        /// <summary>
        /// Observaciones del la enfermedad del tercero
        /// </summary>
        public string Observaciones_Tercero_Enfermedad { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Enfermedad, Se guardan las enfermedades, los datos iniciales se sacaron de: CLASIFICACION ESTADISTICA INTERNACIONAL DE ENFERMEDADES Y PROBLEMAS RELACIONADOS CON LA SALUD. DECIMA REVISION. - CIE 10- CODIGOS Y DESCRIPCION A TRES Y CUATRO DIGITOS.
        /// </summary>
        public Enfermedad Enfermedad { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_enfermedad.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_Enfermedad`, `Id_Tercero`, `Id_Enfermedad`, `Observaciones_Tercero_Enfermedad` FROM tercero_enfermedad " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_enfermedad.
        /// </summary>
        /// <param name="Id_Tercero_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero en cuestion</param>
        /// <param name="Id_Enfermedad">Enfermeadad relacionada</param>
        /// <param name="Observaciones_Tercero_Enfermedad">Observaciones del la enfermedad del tercero</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_Enfermedad, int Id_Tercero, int Id_Enfermedad, string Observaciones_Tercero_Enfermedad)
        {
            return "INSERT INTO tercero_enfermedad(`Id_Tercero_Enfermedad`, `Id_Tercero`, `Id_Enfermedad`, `Observaciones_Tercero_Enfermedad`) VALUES ('" + Id_Tercero_Enfermedad.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Id_Enfermedad.ToString() + "', '" + Observaciones_Tercero_Enfermedad.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_enfermedad.
        /// </summary>
        /// <param name="Id_Tercero_Enfermedad">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero en cuestion</param>
        /// <param name="Id_Enfermedad">Enfermeadad relacionada</param>
        /// <param name="Observaciones_Tercero_Enfermedad">Observaciones del la enfermedad del tercero</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_Enfermedad, int Id_Tercero, int Id_Enfermedad, string Observaciones_Tercero_Enfermedad, string Filtro)
        {
            return "UPDATE tercero_enfermedad SET `Id_Tercero_Enfermedad` = '" + Id_Tercero_Enfermedad.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Id_Enfermedad` = '" + Id_Enfermedad.ToString() + "', `Observaciones_Tercero_Enfermedad` = '" + Observaciones_Tercero_Enfermedad.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_enfermedad Obj)
        {
            if (Obj.Observaciones_Tercero_Enfermedad == null)
            {
                throw new Exception("Observaciones_Tercero_Enfermedad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_enfermedad(`Id_Tercero`, `Id_Enfermedad`, `Observaciones_Tercero_Enfermedad`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Enfermedad.ToString() + "', " + "'" + Obj.Observaciones_Tercero_Enfermedad + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_enfermedad.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_enfermedad Obj)
        {
            if (Obj.Observaciones_Tercero_Enfermedad == null)
            {
                throw new Exception("Observaciones_Tercero_Enfermedad no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_enfermedad SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Enfermedad` =  '" + Obj.Id_Enfermedad.ToString() + "', `Observaciones_Tercero_Enfermedad` =  '" + Obj.Observaciones_Tercero_Enfermedad + "' WHERE tercero_enfermedad.Id_Tercero_Enfermedad = " + Obj.Id_Tercero_Enfermedad.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_enfermedad.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_enfermedad WHERE tercero_enfermedad.Id_Tercero_Enfermedad = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_enfermedad Obj)
        {
            if (Obj.Observaciones_Tercero_Enfermedad == null)
            {
                throw new Exception("Observaciones_Tercero_Enfermedad no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_enfermedad(`Id_Tercero`, `Id_Enfermedad`, `Observaciones_Tercero_Enfermedad`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Id_Enfermedad.ToString() + "', " + "'" + Obj.Observaciones_Tercero_Enfermedad + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_enfermedad</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_enfermedad Obj)
        {
            if (Obj.Observaciones_Tercero_Enfermedad == null)
            {
                throw new Exception("Observaciones_Tercero_Enfermedad no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_enfermedad SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Id_Enfermedad` =  '" + Obj.Id_Enfermedad.ToString() + "', `Observaciones_Tercero_Enfermedad` =  '" + Obj.Observaciones_Tercero_Enfermedad + "' WHERE tercero_enfermedad.Id_Tercero_Enfermedad = " + Obj.Id_Tercero_Enfermedad.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_enfermedad. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_enfermedad WHERE tercero_enfermedad.Id_Tercero_Enfermedad = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Tipo de condicion de IVA
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:18 p.m.
    /// </summary>
    public partial class Tercero_iva
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_iva()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_iva</param>
        public Tercero_iva(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_IVA"))
            {
                if (DataRowConstructor["Id_Tercero_IVA"] != DBNull.Value)
                {
                    this.Id_Tercero_IVA = Convert.ToInt32(DataRowConstructor["Id_Tercero_IVA"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Tercero_IVA"))
            {
                if (DataRowConstructor["Descripcion_Tercero_IVA"] != DBNull.Value)
                {
                    this.Descripcion_Tercero_IVA = DataRowConstructor["Descripcion_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Abreviacion_Tercero_IVA"))
            {
                if (DataRowConstructor["Abreviacion_Tercero_IVA"] != DBNull.Value)
                {
                    this.Abreviacion_Tercero_IVA = DataRowConstructor["Abreviacion_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Comprobante_Compra_Tercero_IVA"))
            {
                if (DataRowConstructor["Clase_Comprobante_Compra_Tercero_IVA"] != DBNull.Value)
                {
                    this.Clase_Comprobante_Compra_Tercero_IVA = DataRowConstructor["Clase_Comprobante_Compra_Tercero_IVA"].ToString();
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Clase_Comprobante_Venta_Tercero_IVA"))
            {
                if (DataRowConstructor["Clase_Comprobante_Venta_Tercero_IVA"] != DBNull.Value)
                {
                    this.Clase_Comprobante_Venta_Tercero_IVA = DataRowConstructor["Clase_Comprobante_Venta_Tercero_IVA"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_iva</param>
        public Tercero_iva(DataSet DataSetConstructor)
        {
            this.ListaTercero_iva = new List<Tercero_iva>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_iva TEMP = new Tercero_iva(Fila);
                this.ListaTercero_iva.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_iva> ListaTercero_iva { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero_IVA { get; set; }
        /// <summary>
        /// Descripcion del tipo de iva/ condicion del tercero
        /// </summary>
        public string Descripcion_Tercero_IVA { get; set; }
        /// <summary>
        /// Abreviatura del la descripcion
        /// </summary>
        public string Abreviacion_Tercero_IVA { get; set; }
        /// <summary>
        /// Clase que se usa para este tipo de iva en la compra
        /// </summary>
        public string Clase_Comprobante_Compra_Tercero_IVA { get; set; }
        /// <summary>
        /// Clase que se usa para este tipo de iva en la venta
        /// </summary>
        public string Clase_Comprobante_Venta_Tercero_IVA { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_iva.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_IVA`, `Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA` FROM tercero_iva " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_iva.
        /// </summary>
        /// <param name="Id_Tercero_IVA">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_IVA">Descripcion del tipo de iva/ condicion del tercero</param>
        /// <param name="Abreviacion_Tercero_IVA">Abreviatura del la descripcion</param>
        /// <param name="Clase_Comprobante_Compra_Tercero_IVA">Clase que se usa para este tipo de iva en la compra</param>
        /// <param name="Clase_Comprobante_Venta_Tercero_IVA">Clase que se usa para este tipo de iva en la venta</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_IVA, string Descripcion_Tercero_IVA, string Abreviacion_Tercero_IVA, string Clase_Comprobante_Compra_Tercero_IVA, string Clase_Comprobante_Venta_Tercero_IVA)
        {
            return "INSERT INTO tercero_iva(`Id_Tercero_IVA`, `Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`) VALUES ('" + Id_Tercero_IVA.ToString() + "', '" + Descripcion_Tercero_IVA.ToString() + "', '" + Abreviacion_Tercero_IVA.ToString() + "', '" + Clase_Comprobante_Compra_Tercero_IVA.ToString() + "', '" + Clase_Comprobante_Venta_Tercero_IVA.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_iva.
        /// </summary>
        /// <param name="Id_Tercero_IVA">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_IVA">Descripcion del tipo de iva/ condicion del tercero</param>
        /// <param name="Abreviacion_Tercero_IVA">Abreviatura del la descripcion</param>
        /// <param name="Clase_Comprobante_Compra_Tercero_IVA">Clase que se usa para este tipo de iva en la compra</param>
        /// <param name="Clase_Comprobante_Venta_Tercero_IVA">Clase que se usa para este tipo de iva en la venta</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_IVA, string Descripcion_Tercero_IVA, string Abreviacion_Tercero_IVA, string Clase_Comprobante_Compra_Tercero_IVA, string Clase_Comprobante_Venta_Tercero_IVA, string Filtro)
        {
            return "UPDATE tercero_iva SET `Id_Tercero_IVA` = '" + Id_Tercero_IVA.ToString() + "', `Descripcion_Tercero_IVA` = '" + Descripcion_Tercero_IVA.ToString() + "', `Abreviacion_Tercero_IVA` = '" + Abreviacion_Tercero_IVA.ToString() + "', `Clase_Comprobante_Compra_Tercero_IVA` = '" + Clase_Comprobante_Compra_Tercero_IVA.ToString() + "', `Clase_Comprobante_Venta_Tercero_IVA` = '" + Clase_Comprobante_Venta_Tercero_IVA.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_iva.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_iva(`Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`)VALUES( " + "'" + Obj.Descripcion_Tercero_IVA + "', " + "'" + Obj.Abreviacion_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_iva.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_iva SET `Descripcion_Tercero_IVA` =  '" + Obj.Descripcion_Tercero_IVA + "', `Abreviacion_Tercero_IVA` =  '" + Obj.Abreviacion_Tercero_IVA + "', `Clase_Comprobante_Compra_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', `Clase_Comprobante_Venta_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "' WHERE tercero_iva.Id_Tercero_IVA = " + Obj.Id_Tercero_IVA.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_iva.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_iva WHERE tercero_iva.Id_Tercero_IVA = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_iva(`Descripcion_Tercero_IVA`, `Abreviacion_Tercero_IVA`, `Clase_Comprobante_Compra_Tercero_IVA`, `Clase_Comprobante_Venta_Tercero_IVA`)VALUES( " + "'" + Obj.Descripcion_Tercero_IVA + "', " + "'" + Obj.Abreviacion_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', " + "'" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_iva</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_iva Obj)
        {
            if (Obj.Descripcion_Tercero_IVA == null)
            {
                throw new Exception("Descripcion_Tercero_IVA no puede ser null");
            }
            if (Obj.Abreviacion_Tercero_IVA == null)
            {
                throw new Exception("Abreviacion_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Compra_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Compra_Tercero_IVA no puede ser null");
            }
            if (Obj.Clase_Comprobante_Venta_Tercero_IVA == null)
            {
                throw new Exception("Clase_Comprobante_Venta_Tercero_IVA no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_iva SET `Descripcion_Tercero_IVA` =  '" + Obj.Descripcion_Tercero_IVA + "', `Abreviacion_Tercero_IVA` =  '" + Obj.Abreviacion_Tercero_IVA + "', `Clase_Comprobante_Compra_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Compra_Tercero_IVA + "', `Clase_Comprobante_Venta_Tercero_IVA` =  '" + Obj.Clase_Comprobante_Venta_Tercero_IVA + "' WHERE tercero_iva.Id_Tercero_IVA = " + Obj.Id_Tercero_IVA.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_iva. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_iva WHERE tercero_iva.Id_Tercero_IVA = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: 
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:18 p.m.
    /// </summary>
    public partial class Tercero_relaciones
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_relaciones()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_relaciones</param>
        public Tercero_relaciones(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Relaciones"))
            {
                if (DataRowConstructor["Id_Tercero_Relaciones"] != DBNull.Value)
                {
                    this.Id_Tercero_Relaciones = Convert.ToInt32(DataRowConstructor["Id_Tercero_Relaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Relacion_Tercero_Relaciones"))
            {
                if (DataRowConstructor["Relacion_Tercero_Relaciones"] != DBNull.Value)
                {
                    this.Relacion_Tercero_Relaciones = Convert.ToInt32(DataRowConstructor["Relacion_Tercero_Relaciones"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Tercero_Relaciones"))
            {
                if (DataRowConstructor["Observaciones_Tercero_Relaciones"] != DBNull.Value)
                {
                    this.Observaciones_Tercero_Relaciones = DataRowConstructor["Observaciones_Tercero_Relaciones"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_relaciones</param>
        public Tercero_relaciones(DataSet DataSetConstructor)
        {
            this.ListaTercero_relaciones = new List<Tercero_relaciones>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_relaciones TEMP = new Tercero_relaciones(Fila);
                TEMP.Tercero = new Tercero(Fila);
                this.ListaTercero_relaciones.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_relaciones> ListaTercero_relaciones { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Tercero_Relaciones { get; set; }
        /// <summary>
        /// Id del tercero en cuestion
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Id del tercero al que se relaciona con el tercero en cuestion
        /// </summary>
        public int Relacion_Tercero_Relaciones { get; set; }
        /// <summary>
        /// Observaciones de la relacion
        /// </summary>
        public string Observaciones_Tercero_Relaciones { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_relaciones.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_Relaciones`, `Id_Tercero`, `Relacion_Tercero_Relaciones`, `Observaciones_Tercero_Relaciones` FROM tercero_relaciones " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_relaciones.
        /// </summary>
        /// <param name="Id_Tercero_Relaciones">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero en cuestion</param>
        /// <param name="Relacion_Tercero_Relaciones">Id del tercero al que se relaciona con el tercero en cuestion</param>
        /// <param name="Observaciones_Tercero_Relaciones">Observaciones de la relacion</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_Relaciones, int Id_Tercero, int Relacion_Tercero_Relaciones, string Observaciones_Tercero_Relaciones)
        {
            return "INSERT INTO tercero_relaciones(`Id_Tercero_Relaciones`, `Id_Tercero`, `Relacion_Tercero_Relaciones`, `Observaciones_Tercero_Relaciones`) VALUES ('" + Id_Tercero_Relaciones.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Relacion_Tercero_Relaciones.ToString() + "', '" + Observaciones_Tercero_Relaciones.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_relaciones.
        /// </summary>
        /// <param name="Id_Tercero_Relaciones">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero en cuestion</param>
        /// <param name="Relacion_Tercero_Relaciones">Id del tercero al que se relaciona con el tercero en cuestion</param>
        /// <param name="Observaciones_Tercero_Relaciones">Observaciones de la relacion</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_Relaciones, int Id_Tercero, int Relacion_Tercero_Relaciones, string Observaciones_Tercero_Relaciones, string Filtro)
        {
            return "UPDATE tercero_relaciones SET `Id_Tercero_Relaciones` = '" + Id_Tercero_Relaciones.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Relacion_Tercero_Relaciones` = '" + Relacion_Tercero_Relaciones.ToString() + "', `Observaciones_Tercero_Relaciones` = '" + Observaciones_Tercero_Relaciones.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_relaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_relaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_relaciones Obj)
        {
            if (Obj.Observaciones_Tercero_Relaciones == null)
            {
                throw new Exception("Observaciones_Tercero_Relaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_relaciones(`Id_Tercero`, `Relacion_Tercero_Relaciones`, `Observaciones_Tercero_Relaciones`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Relacion_Tercero_Relaciones.ToString() + "', " + "'" + Obj.Observaciones_Tercero_Relaciones + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_relaciones.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_relaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_relaciones Obj)
        {
            if (Obj.Observaciones_Tercero_Relaciones == null)
            {
                throw new Exception("Observaciones_Tercero_Relaciones no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_relaciones SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Relacion_Tercero_Relaciones` =  '" + Obj.Relacion_Tercero_Relaciones.ToString() + "', `Observaciones_Tercero_Relaciones` =  '" + Obj.Observaciones_Tercero_Relaciones + "' WHERE tercero_relaciones.Id_Tercero_Relaciones = " + Obj.Id_Tercero_Relaciones.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_relaciones.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_relaciones WHERE tercero_relaciones.Id_Tercero_Relaciones = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_relaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_relaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_relaciones Obj)
        {
            if (Obj.Observaciones_Tercero_Relaciones == null)
            {
                throw new Exception("Observaciones_Tercero_Relaciones no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_relaciones(`Id_Tercero`, `Relacion_Tercero_Relaciones`, `Observaciones_Tercero_Relaciones`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Relacion_Tercero_Relaciones.ToString() + "', " + "'" + Obj.Observaciones_Tercero_Relaciones + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_relaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_relaciones</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_relaciones Obj)
        {
            if (Obj.Observaciones_Tercero_Relaciones == null)
            {
                throw new Exception("Observaciones_Tercero_Relaciones no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_relaciones SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Relacion_Tercero_Relaciones` =  '" + Obj.Relacion_Tercero_Relaciones.ToString() + "', `Observaciones_Tercero_Relaciones` =  '" + Obj.Observaciones_Tercero_Relaciones + "' WHERE tercero_relaciones.Id_Tercero_Relaciones = " + Obj.Id_Tercero_Relaciones.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_relaciones. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_relaciones WHERE tercero_relaciones.Id_Tercero_Relaciones = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Para saber si es proveedor o cliente
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:18 p.m.
    /// </summary>
    public partial class Tercero_tipo
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tercero_tipo()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tercero_tipo</param>
        public Tercero_tipo(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero_Tipo"))
            {
                if (DataRowConstructor["Id_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Id_Tercero_Tipo = Convert.ToInt32(DataRowConstructor["Id_Tercero_Tipo"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Tercero_Tipo"))
            {
                if (DataRowConstructor["Descripcion_Tercero_Tipo"] != DBNull.Value)
                {
                    this.Descripcion_Tercero_Tipo = DataRowConstructor["Descripcion_Tercero_Tipo"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tercero_tipo</param>
        public Tercero_tipo(DataSet DataSetConstructor)
        {
            this.ListaTercero_tipo = new List<Tercero_tipo>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tercero_tipo TEMP = new Tercero_tipo(Fila);
                this.ListaTercero_tipo.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tercero_tipo> ListaTercero_tipo { get; set; }
        /// <summary>
        /// ID de la tabla
        /// </summary>
        public int Id_Tercero_Tipo { get; set; }
        /// <summary>
        /// Descripcion del tipo de tipo de tercero
        /// </summary>
        public string Descripcion_Tercero_Tipo { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tercero_Tipo`, `Descripcion_Tercero_Tipo` FROM tercero_tipo " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Id_Tercero_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_Tipo">Descripcion del tipo de tipo de tercero</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tercero_Tipo, string Descripcion_Tercero_Tipo)
        {
            return "INSERT INTO tercero_tipo(`Id_Tercero_Tipo`, `Descripcion_Tercero_Tipo`) VALUES ('" + Id_Tercero_Tipo.ToString() + "', '" + Descripcion_Tercero_Tipo.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tercero_tipo.
        /// </summary>
        /// <param name="Id_Tercero_Tipo">ID de la tabla</param>
        /// <param name="Descripcion_Tercero_Tipo">Descripcion del tipo de tipo de tercero</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tercero_Tipo, string Descripcion_Tercero_Tipo, string Filtro)
        {
            return "UPDATE tercero_tipo SET `Id_Tercero_Tipo` = '" + Id_Tercero_Tipo.ToString() + "', `Descripcion_Tercero_Tipo` = '" + Descripcion_Tercero_Tipo.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tercero_tipo(`Descripcion_Tercero_Tipo`)VALUES( " + "'" + Obj.Descripcion_Tercero_Tipo + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tercero_tipo SET `Descripcion_Tercero_Tipo` =  '" + Obj.Descripcion_Tercero_Tipo + "' WHERE tercero_tipo.Id_Tercero_Tipo = " + Obj.Id_Tercero_Tipo.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_tipo.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tercero_tipo WHERE tercero_tipo.Id_Tercero_Tipo = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tercero_tipo(`Descripcion_Tercero_Tipo`)VALUES( " + "'" + Obj.Descripcion_Tercero_Tipo + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tercero_tipo</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tercero_tipo Obj)
        {
            if (Obj.Descripcion_Tercero_Tipo == null)
            {
                throw new Exception("Descripcion_Tercero_Tipo no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tercero_tipo SET `Descripcion_Tercero_Tipo` =  '" + Obj.Descripcion_Tercero_Tipo + "' WHERE tercero_tipo.Id_Tercero_Tipo = " + Obj.Id_Tercero_Tipo.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tercero_tipo. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tercero_tipo WHERE tercero_tipo.Id_Tercero_Tipo = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: En esta tabla se encuentran los tratamientos
    /// La última modificación fué el sábado, 03 de diciembre de 2011 a las 03:00:18 p.m.
    /// </summary>
    public partial class Tratamiento
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Tratamiento()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Tratamiento</param>
        public Tratamiento(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Tratamiento"))
            {
                if (DataRowConstructor["Id_Tratamiento"] != DBNull.Value)
                {
                    this.Id_Tratamiento = Convert.ToInt32(DataRowConstructor["Id_Tratamiento"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Descripcion_Tratamiento"))
            {
                if (DataRowConstructor["Descripcion_Tratamiento"] != DBNull.Value)
                {
                    this.Descripcion_Tratamiento = DataRowConstructor["Descripcion_Tratamiento"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Tratamiento</param>
        public Tratamiento(DataSet DataSetConstructor)
        {
            this.ListaTratamiento = new List<Tratamiento>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Tratamiento TEMP = new Tratamiento(Fila);
                this.ListaTratamiento.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Tratamiento> ListaTratamiento { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Tratamiento { get; set; }
        /// <summary>
        /// Descripcion del Tratamiento
        /// </summary>
        public string Descripcion_Tratamiento { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla tratamiento.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Tratamiento`, `Descripcion_Tratamiento` FROM tratamiento " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla tratamiento.
        /// </summary>
        /// <param name="Id_Tratamiento">Id de la tabla</param>
        /// <param name="Descripcion_Tratamiento">Descripcion del Tratamiento</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Tratamiento, string Descripcion_Tratamiento)
        {
            return "INSERT INTO tratamiento(`Id_Tratamiento`, `Descripcion_Tratamiento`) VALUES ('" + Id_Tratamiento.ToString() + "', '" + Descripcion_Tratamiento.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla tratamiento.
        /// </summary>
        /// <param name="Id_Tratamiento">Id de la tabla</param>
        /// <param name="Descripcion_Tratamiento">Descripcion del Tratamiento</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Tratamiento, string Descripcion_Tratamiento, string Filtro)
        {
            return "UPDATE tratamiento SET `Id_Tratamiento` = '" + Id_Tratamiento.ToString() + "', `Descripcion_Tratamiento` = '" + Descripcion_Tratamiento.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Tratamiento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Tratamiento Obj)
        {
            if (Obj.Descripcion_Tratamiento == null)
            {
                throw new Exception("Descripcion_Tratamiento no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO tratamiento(`Descripcion_Tratamiento`)VALUES( " + "'" + Obj.Descripcion_Tratamiento + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tratamiento.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Tratamiento Obj)
        {
            if (Obj.Descripcion_Tratamiento == null)
            {
                throw new Exception("Descripcion_Tratamiento no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE tratamiento SET `Descripcion_Tratamiento` =  '" + Obj.Descripcion_Tratamiento + "' WHERE tratamiento.Id_Tratamiento = " + Obj.Id_Tratamiento.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tratamiento.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM tratamiento WHERE tratamiento.Id_Tratamiento = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Tratamiento Obj)
        {
            if (Obj.Descripcion_Tratamiento == null)
            {
                throw new Exception("Descripcion_Tratamiento no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO tratamiento(`Descripcion_Tratamiento`)VALUES( " + "'" + Obj.Descripcion_Tratamiento + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Tratamiento</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Tratamiento Obj)
        {
            if (Obj.Descripcion_Tratamiento == null)
            {
                throw new Exception("Descripcion_Tratamiento no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE tratamiento SET `Descripcion_Tratamiento` =  '" + Obj.Descripcion_Tratamiento + "' WHERE tratamiento.Id_Tratamiento = " + Obj.Id_Tratamiento.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Tratamiento. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM tratamiento WHERE tratamiento.Id_Tratamiento = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
    /// <summary>
    /// Comentarios de la tabla: Turnos medicos
    /// La última modificación fué el lunes, 05 de diciembre de 2011 a las 05:55:20 p.m.
    /// </summary>
    public partial class Turno
    {
        /// <summary>
        /// Constructor de la clase, para crear la clases vacias
        /// </summary>
        public Turno()
        { }
        /// <summary>
        /// Contructor de la clase, este llena los campos directamente, sin ninguna lista.
        /// </summary>
        /// <param name="DataRowConstructor">Fila de la tabla Turno</param>
        public Turno(DataRow DataRowConstructor)
        {
            if (DataRowConstructor.Table.Columns.Contains("Id_Turno"))
            {
                if (DataRowConstructor["Id_Turno"] != DBNull.Value)
                {
                    this.Id_Turno = Convert.ToInt32(DataRowConstructor["Id_Turno"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Id_Tercero"))
            {
                if (DataRowConstructor["Id_Tercero"] != DBNull.Value)
                {
                    this.Id_Tercero = Convert.ToInt32(DataRowConstructor["Id_Tercero"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Fecha_Turno"))
            {
                if (DataRowConstructor["Fecha_Turno"] != DBNull.Value)
                {
                    this.Fecha_Turno = Convert.ToDateTime(DataRowConstructor["Fecha_Turno"]);
                }
            }
            if (DataRowConstructor.Table.Columns.Contains("Observaciones_Turno"))
            {
                if (DataRowConstructor["Observaciones_Turno"] != DBNull.Value)
                {
                    this.Observaciones_Turno = DataRowConstructor["Observaciones_Turno"].ToString();
                }
            }
        }
        /// <summary>
        /// Constructor de la clase, este llena la lista y no los campos
        /// </summary>
        /// <param name="DataSetConstructor">Tabla de tipo Turno</param>
        public Turno(DataSet DataSetConstructor)
        {
            this.ListaTurno = new List<Turno>();
            foreach (DataRow Fila in DataSetConstructor.Tables[0].Rows)
            {
                Turno TEMP = new Turno(Fila);
                TEMP.Tercero = new Tercero(Fila);
                this.ListaTurno.Add(TEMP);
            }
        }
        /// <summary>
        /// Lista de la clase, contiene muchas clases recursivas.
        /// </summary>
        public List<Turno> ListaTurno { get; set; }
        /// <summary>
        /// Id de la tabla
        /// </summary>
        public int Id_Turno { get; set; }
        /// <summary>
        /// Id del tercero que pidio el turno
        /// </summary>
        public int Id_Tercero { get; set; }
        /// <summary>
        /// Fecha y hora del turno
        /// </summary>
        public DateTime Fecha_Turno { get; set; }
        /// <summary>
        /// Observaciones del turno
        /// </summary>
        public string Observaciones_Turno { get; set; }
        /// <summary>
        /// Contiene datos de la tabla Tercero, Guarda los cliente y los proveedores
        /// </summary>
        public Tercero Tercero { get; set; }
        /// <summary>
        /// Obtiene una sentencia mysql select para la tabla turno.
        /// </summary>
        /// <param name="Filtro">Filtro que se le aplicará a dicha sentencia mysql</param>
        /// <returns>Devuelve una sentencia mysql</returns>
        public static string GetSelect(string Filtro)
        {
            return "SELECT `Id_Turno`, `Id_Tercero`, `Fecha_Turno`, `Observaciones_Turno` FROM turno " + Filtro + ";";
        }
        /// <summary>
        /// Obtiene una sentencia mysql insert into para la tabla turno.
        /// </summary>
        /// <param name="Id_Turno">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero que pidio el turno</param>
        /// <param name="Fecha_Turno">Fecha y hora del turno</param>
        /// <param name="Observaciones_Turno">Observaciones del turno</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetInsert(int Id_Turno, int Id_Tercero, DateTime Fecha_Turno, string Observaciones_Turno)
        {
            return "INSERT INTO turno(`Id_Turno`, `Id_Tercero`, `Fecha_Turno`, `Observaciones_Turno`) VALUES ('" + Id_Turno.ToString() + "', '" + Id_Tercero.ToString() + "', '" + Fecha_Turno.ToString() + "', '" + Observaciones_Turno.ToString() + "');";
        }
        /// <summary>
        /// Obtiene una sentencia mysql update into para la tabla turno.
        /// </summary>
        /// <param name="Id_Turno">Id de la tabla</param>
        /// <param name="Id_Tercero">Id del tercero que pidio el turno</param>
        /// <param name="Fecha_Turno">Fecha y hora del turno</param>
        /// <param name="Observaciones_Turno">Observaciones del turno</param>
        /// <param name="Filtro">Filtro para actualizar.</param>
        /// <returns>Devuelve una sentecia mysql</returns>
        public static string GetUpdate(int Id_Turno, int Id_Tercero, DateTime Fecha_Turno, string Observaciones_Turno, string Filtro)
        {
            return "UPDATE turno SET `Id_Turno` = '" + Id_Turno.ToString() + "', `Id_Tercero` = '" + Id_Tercero.ToString() + "', `Fecha_Turno` = '" + Fecha_Turno.ToString() + "', `Observaciones_Turno` = '" + Observaciones_Turno.ToString() + "' " + Filtro + ";";
        }
        /// <summary>
        /// Agrega un fila a la tabla Turno.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Turno</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Add(Turno Obj)
        {
            if (Obj.Fecha_Turno == null)
            {
                throw new Exception("Fecha_Turno no puede ser null");
            }
            if (Obj.Observaciones_Turno == null)
            {
                throw new Exception("Observaciones_Turno no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("INSERT INTO turno(`Id_Tercero`, `Fecha_Turno`, `Observaciones_Turno`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Fecha_Turno.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Turno + "'" + ");"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Turno.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Turno</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Set(Turno Obj)
        {
            if (Obj.Fecha_Turno == null)
            {
                throw new Exception("Fecha_Turno no puede ser null");
            }
            if (Obj.Observaciones_Turno == null)
            {
                throw new Exception("Observaciones_Turno no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE turno SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Fecha_Turno` =  '" + Obj.Fecha_Turno.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Turno` =  '" + Obj.Observaciones_Turno + "' WHERE turno.Id_Turno = " + Obj.Id_Turno.ToString() + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Turno.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool Delete(string Id)
        {
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("DELETE FROM turno WHERE turno.Id_Turno = " + Id + ";"))
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Agrega un fila a la tabla Turno. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Turno</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool AddSinTransaccion(Turno Obj)
        {
            if (Obj.Fecha_Turno == null)
            {
                throw new Exception("Fecha_Turno no puede ser null");
            }
            if (Obj.Observaciones_Turno == null)
            {
                throw new Exception("Observaciones_Turno no puede ser null");
            }
            if (Common.InsertUpdate("INSERT INTO turno(`Id_Tercero`, `Fecha_Turno`, `Observaciones_Turno`)VALUES( " + "'" + Obj.Id_Tercero.ToString() + "', " + "'" + Obj.Fecha_Turno.ToString("yyyy-MM-dd HH:mm:ss") + "', " + "'" + Obj.Observaciones_Turno + "'" + ");"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Actualiza un fila a la tabla Turno. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Turno</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetSinTransaccion(Turno Obj)
        {
            if (Obj.Fecha_Turno == null)
            {
                throw new Exception("Fecha_Turno no puede ser null");
            }
            if (Obj.Observaciones_Turno == null)
            {
                throw new Exception("Observaciones_Turno no puede ser null");
            }
            if (Common.InsertUpdate("UPDATE turno SET `Id_Tercero` =  '" + Obj.Id_Tercero.ToString() + "', `Fecha_Turno` =  '" + Obj.Fecha_Turno.ToString("yyyy-MM-dd HH:mm:ss") + "', `Observaciones_Turno` =  '" + Obj.Observaciones_Turno + "' WHERE turno.Id_Turno = " + Obj.Id_Turno.ToString() + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
        /// <summary>
        /// Borra una fila de la tabla Turno. Esto se hace sin transaccion, osea que la tansaccion tiene que estar gestionada desde afuera.
        /// </summary>
        /// <param name="Id">Es el id de la fila que se quiere borrar.</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool DeleteSinTransaccion(string Id)
        {
            if (Common.InsertUpdate("DELETE FROM turno WHERE turno.Id_Turno = " + Id + ";"))
            {
                return true;
            }
            else
            {
                Common.Cnn.Close();
                return false;
            }
        }
    }
}
