using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultorio.Datos
{
    public partial class Caja
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCaja">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja GetCaja(string IdCaja, string IdRecibo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCaja != "")
            {
                Filtro += "AND Id_Caja = " + IdCaja + " ";
            }
            if (IdRecibo != "")
            {
                Filtro += "AND Numero_Remito_Caja = " + IdRecibo + " ";
            }
            return new Caja(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCaja">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja GetCajaRelacional(string IdCaja)
        {
            string SqlString = "SELECT caja.Id_Caja, caja.Id_Caja_Tipo, caja.Importe_Caja, caja.Fecha_Caja, caja.Numero_Remito_Caja, caja.Numero_Cuota_Caja, caja.Tag_Caja, caja_tipo.Id_Caja_Tipo, caja_tipo.Descripcion_Caja_Tipo FROM caja INNER JOIN caja_tipo ON (caja.Id_Caja_Tipo = caja_tipo.Id_Caja_Tipo)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCaja != "")
            {
                Filtro += "AND caja.Id_Caja = " + IdCaja + " ";
            }
            return new Caja(Common.Peticion(SqlString + Filtro + " ORDER BY caja.Fecha_Caja;"));
        }
    }
    public partial class Caja_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCaja_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Caja_tipo GetCaja_tipo(string IdCaja_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCaja_tipo != "")
            {
                Filtro += "AND Id_Caja_tipo = " + IdCaja_tipo + " ";
            }
            return new Caja_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Cheque_cartera
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCheque_cartera">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Cheque_cartera GetCheque_cartera(string IdCheque_cartera, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCheque_cartera != "")
            {
                Filtro += "AND Id_Cheque_cartera = " + IdCheque_cartera + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Numero_Recibo_Cheque_Cartera = " + IdFactura + " ";
            }
            return new Cheque_cartera(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCheque_cartera">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Cheque_cartera GetCheque_carteraRelacional(string IdCheque_cartera, string NumeroRecibo)
        {
            string SqlString = "SELECT cheque_cartera.Id_Cheque_Cartera, cheque_cartera.Id_Localidad, cheque_cartera.Codigo_Cheque_Cartera, cheque_cartera.Numero_Recibo_Cheque_Cartera, cheque_cartera.Nombre_Cheque_Cartera, cheque_cartera.Fecha_Emicion_Cheque_Cartera, cheque_cartera.Fecha_Vencimiento_Cheque_Cartera, cheque_cartera.Nombre_Librador_Cheque_Cartera, cheque_cartera.Marca_Cheque_Cartera, cheque_cartera.Importe_Cheque_Cartera, cheque_cartera.Detalle_Cheque_Cartera, localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad FROM cheque_cartera INNER JOIN localidad ON (cheque_cartera.Id_Localidad = localidad.Id_Localidad)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCheque_cartera != "")
            {
                Filtro += "AND cheque_cartera.Id_Cheque_cartera = " + IdCheque_cartera + " ";
            }
            if (NumeroRecibo != "")
            {
                Filtro += "AND cheque_cartera.Numero_Recibo_Cheque_Cartera = " + NumeroRecibo + " ";
            }
            return new Cheque_cartera(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta GetConsulta(string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta GetConsultaRelacional(string IdConsulta,string IdTercero)
        {
            string SqlString = "SELECT consulta.id_consulta, consulta.id_tercero, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.fecha_consulta, consulta.fecha_alta_consulta, consulta.alta_consulta, consulta.observaciones_consulta, tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.id_obra_social, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero, tercero.observaciones_tercero FROM consulta INNER JOIN tercero ON (consulta.id_tercero = tercero.id_tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta != "")
            {
                Filtro += "AND consulta.Id_Consulta = " + IdConsulta + " ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND consulta.id_tercero = " + IdTercero + " ";
            }
            return new Consulta(Common.Peticion(SqlString + Filtro + ";"));
        }
        /// <summary>
        /// Guarda una consulta con todas sus objetos
        /// </summary>
        /// <param name="ObjConsulta">La consulta en si</param>
        /// <param name="CE">Objetos de los estudios</param>
        /// <param name="C_EFERMEDAD">Objetos de la enfermedades</param>
        /// <param name="CT">Objetos de los tratamientos</param>
        /// <param name="CI">Imagenes de la consultas</param>
        /// <param name="CM">Medicamentos de la consulta</param>
        /// <param name="CV">Visitas de la consultas</param>
        /// <returns>Devuelve true si todo salio bien...</returns>
        public static bool Add_ConsultaCompleta(Consulta ObjConsulta,Consulta_estudio CE,Consulta_enfermedad C_EFERMEDAD,Consulta_tratamiento CT,Consulta_imagenes CI,Consulta_medicacion CM,Consulta_visita CV)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(ObjConsulta))
            {
                HuboError = true;
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(consulta.Id_Consulta) FROM consulta;").Tables[0].Rows[0][0]);

            foreach (Consulta_estudio ItemConsulta_estudio in CE.ListaConsulta_estudio)
            {
                ItemConsulta_estudio.Id_Consulta = UltimoId;
                if (!Consulta_estudio.AddSinTransaccion(ItemConsulta_estudio))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_enfermedad ItemConsulta_enfermedad in C_EFERMEDAD.ListaConsulta_enfermedad)
            {
                ItemConsulta_enfermedad.Id_Consulta = UltimoId;
                if (!Consulta_enfermedad.AddSinTransaccion(ItemConsulta_enfermedad))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_tratamiento ItemConsulta_tratamiento in CT.ListaConsulta_tratamiento)
            {
                ItemConsulta_tratamiento.Id_Consulta = UltimoId;
                if (!Consulta_tratamiento.AddSinTransaccion(ItemConsulta_tratamiento))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_imagenes ItemConsulta_imagenes in CI.ListaConsulta_imagenes)
            {
                ItemConsulta_imagenes.Id_Consulta = UltimoId;
                if (!Consulta_imagenes.AddSinTransaccion(ItemConsulta_imagenes))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_medicacion ItemConsulta_medicacion in CM.ListaConsulta_medicacion)
            {
                ItemConsulta_medicacion.Id_Consulta = UltimoId;
                if (!Consulta_medicacion.AddSinTransaccion(ItemConsulta_medicacion))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_visita ItemConsulta_visita in CV.ListaConsulta_visita)
            {
                ItemConsulta_visita.Id_Consulta = UltimoId;
                if (!Consulta_visita.AddSinTransaccion(ItemConsulta_visita))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Altualiza una consulta con todas sus objetos
        /// </summary>
        /// <param name="ObjConsulta">La consulta en si</param>
        /// <param name="CE">Objetos de los estudios</param>
        /// <param name="C_EFERMEDAD">Objetos de la enfermedades</param>
        /// <param name="CT">Objetos de los tratamientos</param>
        /// <param name="CI">Imagenes de la consultas</param>
        /// <param name="CM">Medicamentos de la consulta</param>
        /// <param name="CV">Visitas de la consultas</param>
        /// <returns>Devuelve true si todo salio bien...</returns>
        public static bool Set_ConsultaCompleta(Consulta ObjConsulta, Consulta_estudio CE, Consulta_enfermedad C_EFERMEDAD, Consulta_tratamiento CT, Consulta_imagenes CI, Consulta_medicacion CM, Consulta_visita CV)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!SetSinTransaccion(ObjConsulta))
            {
                HuboError = true;
            }

            //Borro y despues vuelve a guardar los estudios
            Consulta_estudio Consulta_estudioAnterior = Consulta_estudio.GetConsulta_estudio("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_estudio ItemConsulta_estudio in Consulta_estudioAnterior.ListaConsulta_estudio)
            {
                if (!Consulta_estudio.DeleteSinTransaccion(ItemConsulta_estudio.Id_Consulta_Estudio.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_estudio ItemConsulta_estudio in CE.ListaConsulta_estudio)
            {
                ItemConsulta_estudio.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_estudio.AddSinTransaccion(ItemConsulta_estudio))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las enfermedades
            Consulta_enfermedad Consulta_enfermedadAnterior = Consulta_enfermedad.GetConsulta_enfermedad("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_enfermedad ItemConsulta_enfermedad in Consulta_enfermedadAnterior.ListaConsulta_enfermedad)
            {
                if (!Consulta_enfermedad.DeleteSinTransaccion(ItemConsulta_enfermedad.Id_Consulta_Enfermedad.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_enfermedad ItemConsulta_enfermedad in C_EFERMEDAD.ListaConsulta_enfermedad)
            {
                ItemConsulta_enfermedad.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_enfermedad.AddSinTransaccion(ItemConsulta_enfermedad))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar los tratamientos
            Consulta_tratamiento Consulta_tratamientoAnterior = Consulta_tratamiento.GetConsulta_tratamiento("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_tratamiento ItemConsulta_tratamiento in Consulta_tratamientoAnterior.ListaConsulta_tratamiento)
            {
                if (!Consulta_tratamiento.DeleteSinTransaccion(ItemConsulta_tratamiento.Id_Consulta_Tratamiento.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_tratamiento ItemConsulta_tratamiento in CT.ListaConsulta_tratamiento)
            {
                ItemConsulta_tratamiento.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_tratamiento.AddSinTransaccion(ItemConsulta_tratamiento))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las imagenes
            Consulta_imagenes Consulta_imagenesAnterior = Consulta_imagenes.GetConsulta_imagenes("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_imagenes ItemConsulta_imagenes in Consulta_imagenesAnterior.ListaConsulta_imagenes)
            {
                if (!Consulta_imagenes.DeleteSinTransaccion(ItemConsulta_imagenes.Id_Consulta_Imagenes.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_imagenes ItemConsulta_imagenes in CI.ListaConsulta_imagenes)
            {
                ItemConsulta_imagenes.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_imagenes.AddSinTransaccion(ItemConsulta_imagenes))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las medicaciones
            Consulta_medicacion Consulta_medicacionAnterior = Consulta_medicacion.GetConsulta_medicacion("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_medicacion ItemConsulta_medicacion in Consulta_medicacionAnterior.ListaConsulta_medicacion)
            {
                if (!Consulta_medicacion.DeleteSinTransaccion(ItemConsulta_medicacion.Id_Consulta_Medicacion.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_medicacion ItemConsulta_medicacion in CM.ListaConsulta_medicacion)
            {
                ItemConsulta_medicacion.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_medicacion.AddSinTransaccion(ItemConsulta_medicacion))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las visitas
            Consulta_visita Consulta_visitaAnterior = Consulta_visita.GetConsulta_visita("", ObjConsulta.Id_Consulta.ToString());
            foreach (Consulta_visita ItemConsulta_visita in Consulta_visitaAnterior.ListaConsulta_visita)
            {
                if (!Consulta_visita.DeleteSinTransaccion(ItemConsulta_visita.Id_Consulta_Visita.ToString()))
                {
                    HuboError = true;
                }
            }

            foreach (Consulta_visita ItemConsulta_visita in CV.ListaConsulta_visita)
            {
                ItemConsulta_visita.Id_Consulta = ObjConsulta.Id_Consulta;
                if (!Consulta_visita.AddSinTransaccion(ItemConsulta_visita))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Delete_ConsultaCompleta(string IdConsulta)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();

            //Borro y despues vuelve a guardar los estudios
            Consulta_estudio Consulta_estudioAnterior = Consulta_estudio.GetConsulta_estudio("", IdConsulta);
            foreach (Consulta_estudio ItemConsulta_estudio in Consulta_estudioAnterior.ListaConsulta_estudio)
            {
                if (!Consulta_estudio.DeleteSinTransaccion(ItemConsulta_estudio.Id_Consulta_Estudio.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las enfermedades
            Consulta_enfermedad Consulta_enfermedadAnterior = Consulta_enfermedad.GetConsulta_enfermedad("",IdConsulta);
            foreach (Consulta_enfermedad ItemConsulta_enfermedad in Consulta_enfermedadAnterior.ListaConsulta_enfermedad)
            {
                if (!Consulta_enfermedad.DeleteSinTransaccion(ItemConsulta_enfermedad.Id_Consulta_Enfermedad.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar los tratamientos
            Consulta_tratamiento Consulta_tratamientoAnterior = Consulta_tratamiento.GetConsulta_tratamiento("", IdConsulta);
            foreach (Consulta_tratamiento ItemConsulta_tratamiento in Consulta_tratamientoAnterior.ListaConsulta_tratamiento)
            {
                if (!Consulta_tratamiento.DeleteSinTransaccion(ItemConsulta_tratamiento.Id_Consulta_Tratamiento.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las imagenes
            Consulta_imagenes Consulta_imagenesAnterior = Consulta_imagenes.GetConsulta_imagenes("", IdConsulta);
            foreach (Consulta_imagenes ItemConsulta_imagenes in Consulta_imagenesAnterior.ListaConsulta_imagenes)
            {
                if (!Consulta_imagenes.DeleteSinTransaccion(ItemConsulta_imagenes.Id_Consulta_Imagenes.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las medicaciones
            Consulta_medicacion Consulta_medicacionAnterior = Consulta_medicacion.GetConsulta_medicacion("", IdConsulta);
            foreach (Consulta_medicacion ItemConsulta_medicacion in Consulta_medicacionAnterior.ListaConsulta_medicacion)
            {
                if (!Consulta_medicacion.DeleteSinTransaccion(ItemConsulta_medicacion.Id_Consulta_Medicacion.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro y despues vuelve a guardar las visitas
            Consulta_visita Consulta_visitaAnterior = Consulta_visita.GetConsulta_visita("", IdConsulta);
            foreach (Consulta_visita ItemConsulta_visita in Consulta_visitaAnterior.ListaConsulta_visita)
            {
                if (!Consulta_visita.DeleteSinTransaccion(ItemConsulta_visita.Id_Consulta_Visita.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro la consulta en si..
            if (!Consulta.DeleteSinTransaccion(IdConsulta))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Consulta_enfermedad
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_enfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_enfermedad GetConsulta_enfermedad(string IdConsulta_enfermedad,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_enfermedad != "")
            {
                Filtro += "AND Id_Consulta_enfermedad = " + IdConsulta_enfermedad + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_enfermedad(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_enfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_enfermedad GetConsulta_enfermedadRelacional(string IdConsulta_enfermedad,string IdConsulta)
        {
            string SqlString = "SELECT consulta_enfermedad.id_consulta_enfermedad, consulta_enfermedad.id_consulta, consulta_enfermedad.id_enfermedad, consulta.id_consulta, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.observaciones_consulta, enfermedad.id_enfermedad, enfermedad.id_enfermedad_categoria, enfermedad.codigo_enfermedad, enfermedad.descripcion_enfermedad, enfermedad.observaciones_enfermedad FROM consulta_enfermedad INNER JOIN consulta ON (consulta_enfermedad.id_consulta = consulta.id_consulta) INNER JOIN enfermedad ON (consulta_enfermedad.id_enfermedad = enfermedad.id_enfermedad)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_enfermedad != "")
            {
                Filtro += "AND consulta_enfermedad.Id_Consulta_enfermedad = " + IdConsulta_enfermedad + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND consulta_enfermedad.id_consulta = " + IdConsulta + " ";
            }
            return new Consulta_enfermedad(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta_estudio
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_estudio">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_estudio GetConsulta_estudio(string IdConsulta_estudio,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_estudio != "")
            {
                Filtro += "AND Id_Consulta_estudio = " + IdConsulta_estudio + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_estudio(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_estudio">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_estudio GetConsulta_estudioRelacional(string IdConsulta_estudio, string IdConsulta)
        {
            string SqlString = "SELECT consulta_estudio.id_consulta_estudio, consulta_estudio.id_consulta, consulta_estudio.id_estudio, consulta.id_consulta, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.observaciones_consulta, estudio.id_estudio, estudio.descripcion_estudio FROM consulta_estudio INNER JOIN consulta ON (consulta_estudio.id_consulta = consulta.id_consulta) INNER JOIN estudio ON (consulta_estudio.id_estudio = estudio.id_estudio)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_estudio != "")
            {
                Filtro += "AND consulta_estudio.Id_Consulta_estudio = " + IdConsulta_estudio + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND consulta_estudio.id_consulta = " + IdConsulta + " ";
            }
            return new Consulta_estudio(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta_imagenes
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_imagenes">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_imagenes GetConsulta_imagenes(string IdConsulta_imagenes,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_imagenes != "")
            {
                Filtro += "AND Id_Consulta_imagenes = " + IdConsulta_imagenes + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_imagenes(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_imagenes">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_imagenes GetConsulta_imagenesRelacional(string IdConsulta_imagenes)
        {
            string SqlString = "SELECT consulta_imagenes.id_consulta_imagenes, consulta_imagenes.id_consulta, consulta_imagenes.imagen_consulta_imagenes, consulta_imagenes.observaciones_consulta_imagenes, consulta.id_consulta, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.observaciones_consulta FROM consulta_imagenes INNER JOIN consulta ON (consulta_imagenes.id_consulta = consulta.id_consulta)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_imagenes != "")
            {
                Filtro += "AND consulta_imagenes.Id_Consulta_imagenes = " + IdConsulta_imagenes + " ";
            }
            return new Consulta_imagenes(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta_medicacion
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_medicacion">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_medicacion GetConsulta_medicacion(string IdConsulta_medicacion,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_medicacion != "")
            {
                Filtro += "AND Id_Consulta_medicacion = " + IdConsulta_medicacion + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_medicacion(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_medicacion">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_medicacion GetConsulta_medicacionRelacional(string IdConsulta_medicacion, string IdConsulta)
        {
            string SqlString = "SELECT consulta_medicacion.id_consulta_medicacion, consulta_medicacion.id_consulta, consulta_medicacion.id_medicacion, consulta.id_consulta, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.observaciones_consulta, medicacion.id_medicacion, medicacion.id_medicacion_laboratorio, medicacion.id_medicacion_accion_farmacologica, medicacion.id_medicacion_autorizacion, medicacion.principio_activo_medicacion, medicacion.nombre_comercial_medicacion, medicacion.presentacion_medicacion, medicacion.regis_medicacion, medicacion.troquel_medicacion, medicacion.observaciones_medicacion FROM consulta_medicacion INNER JOIN consulta ON (consulta_medicacion.id_consulta = consulta.id_consulta) INNER JOIN medicacion ON (consulta_medicacion.id_medicacion = medicacion.id_medicacion)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_medicacion != "")
            {
                Filtro += "AND consulta_medicacion.Id_Consulta_medicacion = " + IdConsulta_medicacion + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND consulta_medicacion.id_consulta = " + IdConsulta + " ";
            }
            return new Consulta_medicacion(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta_tratamiento
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_tratamiento">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_tratamiento GetConsulta_tratamiento(string IdConsulta_tratamiento,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_tratamiento != "")
            {
                Filtro += "AND Id_Consulta_tratamiento = " + IdConsulta_tratamiento + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_tratamiento(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_tratamiento">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_tratamiento GetConsulta_tratamientoRelacional(string IdConsulta_tratamiento, string IdConsulta)
        {
            string SqlString = "SELECT consulta_tratamiento.id_consulta_tratamiento, consulta_tratamiento.id_consulta, consulta_tratamiento.id_tratamiento, consulta.id_consulta, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.observaciones_consulta, tratamiento.id_tratamiento, tratamiento.descripcion_tratamiento FROM consulta_tratamiento INNER JOIN consulta ON (consulta_tratamiento.id_consulta = consulta.id_consulta) INNER JOIN tratamiento ON (consulta_tratamiento.id_tratamiento = tratamiento.id_tratamiento)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_tratamiento != "")
            {
                Filtro += "AND consulta_tratamiento.Id_Consulta_tratamiento = " + IdConsulta_tratamiento + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND consulta_tratamiento.id_consulta = " + IdConsulta + " ";
            }
            return new Consulta_tratamiento(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Consulta_visita
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdConsulta_visita">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_visita GetConsulta_visita(string IdConsulta_visita,string IdConsulta)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdConsulta_visita != "")
            {
                Filtro += "AND Id_Consulta_visita = " + IdConsulta_visita + " ";
            }
            if (IdConsulta != "")
            {
                Filtro += "AND Id_Consulta = " + IdConsulta + " ";
            }
            return new Consulta_visita(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdConsulta_visita">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Consulta_visita GetConsulta_visitaRelacional(string IdConsulta_visita)
        {
            string SqlString = "SELECT consulta_visita.id_consulta_visita, consulta_visita.id_consulta, consulta_visita.fecha_consulta_visita, consulta_visita.observaciones_consulta_visita, consulta.id_consulta, consulta.id_tercero, consulta.motivo_consulta, consulta.analisis_visual_consulta, consulta.evolucion_consulta, consulta.alta_medica_consulta, consulta.fecha_consulta, consulta.fecha_alta_consulta, consulta.alta_consulta, consulta.observaciones_consulta FROM consulta_visita INNER JOIN consulta ON (consulta_visita.id_consulta = consulta.id_consulta)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdConsulta_visita != "")
            {
                Filtro += "AND consulta_visita.Id_Consulta_visita = " + IdConsulta_visita + " ";
            }
            return new Consulta_visita(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Couta
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdCouta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Couta GetCouta(string IdCouta, string IdFactura, string Pagado)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdCouta != "")
            {
                Filtro += "AND Id_Couta = " + IdCouta + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            if (Pagado != "")
            {
                Filtro += "AND Pagado_Couta = " + Pagado + " ";
            }
            return new Couta(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdCouta">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Couta GetCoutaRelacional(string IdCouta, string VenciminetoDesde, string VenciminetoHasta, string Pagado, string InFactura, string IdTercero)
        {
            string SqlString = "SELECT couta.id_couta, couta.id_factura, couta.numero_couta_couta, couta.fecha_vencimineto_couta, couta.fecha_pago_couta, couta.importe_couta, couta.importe_interes_couta, couta.asignacion_cuota, couta.pagado_couta, couta.observaciones_couta, factura.id_factura, factura.id_tercero, factura.id_factura_tipo, factura.fecha_factura, factura.fecha_vencimiento_factura, factura.clase_factura, factura.puesto_factura, factura.numero_factura, factura.neto_factura, factura.iva_105_factura, factura.iva_21_factura, factura.iva_27_factura, factura.percepcion_factura, factura.exentos_factura, factura.otros_factura, factura.total_factura, factura.retencion_factura, factura.anulado_factura, factura.facturado_factura, factura.pagado_factura, factura.observaciones_factura, factura.interes_factura FROM couta INNER JOIN factura ON (couta.id_factura = factura.id_factura) INNER JOIN tercero ON (factura.id_tercero = tercero.id_tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdCouta != "")
            {
                Filtro += "AND couta.Id_Couta = " + IdCouta + " ";
            }
            if (VenciminetoDesde != "" && VenciminetoHasta != "")
            {
                Filtro += "AND couta.Fecha_Vencimineto_Couta BETWEEN '" + VenciminetoDesde + "' AND '" + VenciminetoHasta + "' ";
            }
            if (Pagado != "")
            {
                Filtro += "AND couta.Pagado_Couta = '" + Pagado + "' ";
            }
            if (InFactura != "")
            {
                Filtro += "AND couta.Id_Factura IN (" + InFactura + ") ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero = " + IdTercero + " ";
            }
            return new Couta(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Empresa
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdEmpresa">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Empresa GetEmpresa(string IdEmpresa)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdEmpresa != "")
            {
                Filtro += "AND Id_Empresa = " + IdEmpresa + " ";
            }
            return new Empresa(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdEmpresa">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Empresa GetEmpresaRelacional(string IdEmpresa)
        {
            string SqlString = "SELECT empresa.Id_Empresa, empresa.Id_Localidad, empresa.Id_Tercero_IVA, empresa.Razon_Social_Empresa, empresa.Titular_Empresa, empresa.CUIT_Empresa, empresa.Direccion_Empresa, empresa.Telefonos_Empresa, empresa.Fax_Empresa, empresa.Email_Empresa, empresa.Web_Empresa, empresa.Inicio_Actividades_Empresa, empresa.Ingresos_Brutos_Empresa, localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad, tercero_iva.Id_Tercero_IVA, tercero_iva.Descripcion_Tercero_IVA, tercero_iva.Abreviacion_Tercero_IVA, tercero_iva.Clase_Comprobante_Compra_Tercero_IVA, tercero_iva.Clase_Comprobante_Venta_Tercero_IVA FROM empresa INNER JOIN localidad ON (empresa.Id_Localidad = localidad.Id_Localidad) INNER JOIN tercero_iva ON (empresa.Id_Tercero_IVA = tercero_iva.Id_Tercero_IVA)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdEmpresa != "")
            {
                Filtro += "AND empresa.Id_Empresa = " + IdEmpresa + " ";
            }
            return new Empresa(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Enfermedad
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdEnfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Enfermedad GetEnfermedad(string IdEnfermedad)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdEnfermedad != "")
            {
                Filtro += "AND Id_Enfermedad = " + IdEnfermedad + " ";
            }
            return new Enfermedad(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdEnfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Enfermedad GetEnfermedadRelacional(string IdEnfermedad,string Enfermedad,string IdCategoria)
        {
            string SqlString = "SELECT enfermedad.id_enfermedad, enfermedad.id_enfermedad_categoria, enfermedad.codigo_enfermedad, enfermedad.descripcion_enfermedad, enfermedad.observaciones_enfermedad, enfermedad_categoria.id_enfermedad_categoria, enfermedad_categoria.codigo_enfermedad_categoria, enfermedad_categoria.descripcion_enfermedad_categoria, enfermedad_categoria.observaciones_enfermedad_categoria FROM enfermedad INNER JOIN enfermedad_categoria ON (enfermedad.id_enfermedad_categoria = enfermedad_categoria.id_enfermedad_categoria)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdEnfermedad != "")
            {
                Filtro += "AND enfermedad.Id_Enfermedad = " + IdEnfermedad + " ";
            }
            if (Enfermedad != "")
            {
                Filtro += "AND enfermedad.descripcion_enfermedad LIKE '%" + Enfermedad.Replace(" ","%") + "%' ";
            }
            if (IdCategoria != "")
            {
                Filtro += "AND enfermedad.id_enfermedad_categoria = " + IdCategoria + " ";
            }
            return new Enfermedad(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Enfermedad_categoria
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdEnfermedad_categoria">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Enfermedad_categoria GetEnfermedad_categoria(string IdEnfermedad_categoria,string Codigo,string EnfermedadCategoria)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdEnfermedad_categoria != "")
            {
                Filtro += "AND Id_Enfermedad_categoria = " + IdEnfermedad_categoria + " ";
            }
            if (Codigo != "")
            {
                Filtro += "AND Codigo_Enfermedad_Categoria = '" + Codigo + "' ";
            }
            if (EnfermedadCategoria != "")
            {
                Filtro += "AND Descripcion_Enfermedad_Categoria LIKE '%" + EnfermedadCategoria.Replace(" ", "%") + "%' ";
            }
            return new Enfermedad_categoria(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Estudio
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdEstudio">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Estudio GetEstudio(string IdEstudio,string Estudio)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdEstudio != "")
            {
                Filtro += "AND Id_Estudio = " + IdEstudio + " ";
            }
            if (Estudio != "")
            {
                Filtro += "AND Descripcion_Estudio LIKE '%" + Estudio.Replace(" ", "%") + "%' ";
            }
            return new Estudio(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Factura
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura GetFactura(string IdFactura, string TipoFactura, string Clase, string Puesto, string Numero, string IdTercero, string FechaString)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }

            if (TipoFactura != "")
            {
                Filtro += "AND Id_Factura_Tipo = " + TipoFactura + " ";
            }

            if (Clase != "")
            {
                Filtro += "AND Clase_Factura = '" + Clase + "' ";
            }

            if (Puesto != "")
            {
                Filtro += "AND Puesto_Factura = " + Puesto + " ";
            }

            if (Numero != "")
            {
                Filtro += "AND Numero_Factura = " + Numero + " ";
            }

            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }

            if (FechaString != "")
            {
                DateTime Periodo = Convert.ToDateTime(FechaString);
                Filtro += "AND Fecha_Factura BETWEEN '" + Periodo.Year.ToString() + "-" + Periodo.Month.ToString() + "-1 00:00:00' AND '" + Periodo.Year.ToString() + "-" + (Periodo.Month + 1).ToString() + "-1 00:00:00'";
            }

            return new Factura(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura GetFacturaRelacional(string IdFactura, string IdFacturaTipo, string IdTercero, string TipoFacturaIn, string FechaString, string RazonSocial)
        {
            string SqlString = "SELECT factura.id_factura, factura.id_tercero, factura.id_factura_tipo, factura.fecha_factura, factura.fecha_vencimiento_factura, factura.clase_factura, factura.puesto_factura, factura.numero_factura, factura.neto_factura, factura.iva_105_factura, factura.iva_21_factura, factura.iva_27_factura, factura.percepcion_factura, factura.exentos_factura, factura.otros_factura, factura.total_factura, factura.retencion_factura, factura.interes_factura, factura.anulado_factura, factura.facturado_factura, factura.pagado_factura, factura.observaciones_factura, tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.observaciones_tercero, factura_tipo.id_factura_tipo, factura_tipo.descripcion_factura_tipo, factura_tipo.abreviacion_factura_tipo, tercero.id_obra_social, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero FROM factura INNER JOIN tercero ON (factura.id_tercero = tercero.id_tercero) INNER JOIN factura_tipo ON (factura.id_factura_tipo = factura_tipo.id_factura_tipo)";

            string Filtro = " WHERE 0 < 1 ";

            if (IdFactura != "")
            {
                Filtro += "AND factura.Id_Factura = " + IdFactura + " ";
            }

            if (IdFacturaTipo != "")
            {
                Filtro += "AND factura.Id_Factura_Tipo = " + IdFacturaTipo + " ";
            }

            if (TipoFacturaIn != "")
            {
                Filtro += "AND factura.Id_Factura_Tipo IN (" + TipoFacturaIn + ") ";
            }

            if (IdTercero != "")
            {
                Filtro += "AND factura.Id_Tercero = " + IdTercero + " ";
            }

            if (FechaString != "")
            {
                DateTime Periodo = Convert.ToDateTime(FechaString);
                DateTime Periodo2 = Convert.ToDateTime(FechaString).AddMonths(1);
                Filtro += "AND factura.Fecha_Factura BETWEEN '" + Periodo.Year.ToString() + "-" + Periodo.Month.ToString() + "-1 00:00:00' AND '" + Periodo2.Year.ToString() + "-" + Periodo2.Month.ToString() + "-1 00:00:00'";
            }

            if (RazonSocial != "")
            {
                Filtro += "AND tercero.Razon_Social_Tercero LIKE '%" + RazonSocial.Replace(" ", "%") + "%' ";
            }
            return new Factura(Common.Peticion(SqlString + Filtro + ";"));
        }

        public static bool AddFactura_detalle(Factura ObjFactura, Factura_detalle ObjFactura_detalle, Couta ObjCoutas)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(factura.Id_Factura) FROM factura;").Tables[0].Rows[0][0]);

            foreach (Factura_detalle ItemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
            {
                ItemFactura_detalle.Id_Factura = UltimoId;
                if (!Factura_detalle.AddSinTransaccion(ItemFactura_detalle))
                {
                    HuboError = true;
                }
            }

            foreach (Datos.Couta itemCouta in ObjCoutas.ListaCouta)
            {
                itemCouta.Id_Factura = UltimoId;

                if (!Couta.AddSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SetFactura_detalle(Factura ObjFactura, Factura_detalle ObjFactura_detalle, Couta ObjCoutas)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();
            //seteo el nuevo encabesado del remito
            if (!SetSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            //primero borro todos los detalles que existen
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", ObjFactura.Id_Factura.ToString());
            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca cargo los nuevos detalles
            foreach (Factura_detalle ItemFactura_detalle in ObjFactura_detalle.ListaFactura_detalle)
            {
                ItemFactura_detalle.Id_Factura = ObjFactura.Id_Factura;
                if (!Factura_detalle.AddSinTransaccion(ItemFactura_detalle))
                {
                    HuboError = true;
                }
            }

            //borro las cuotas viejas
            Couta CoutaAnterior = Couta.GetCouta("", ObjFactura.Id_Factura.ToString(), "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //agrego la nuevas cuotas
            foreach (Datos.Couta itemCouta in ObjCoutas.ListaCouta)
            {
                itemCouta.Id_Factura = ObjFactura.Id_Factura;

                if (!Couta.AddSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteFactura_detalle(string IdFactura)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "");

            //primero acomodo los valores del stock para esa factura
            //depues borro todos los detalles de la factura si tiene
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", IdFactura);

            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro las cuotas
            Couta CoutaAnterior = Couta.GetCouta("", IdFactura, "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                //BUSCAS LAS CUOTAS QUE TIENEN RECIBOS Y BORRA LOS RECIBO
                Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", "", ItemCouta.Id_Couta.ToString());
                foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
                {
                    DeleteRecibo_OrdenPagoSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura.ToString(), ref HuboError);
                }

                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro la factura en si..
            if (!Factura.DeleteSinTransaccion(IdFactura))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AnularFactura_detalle(string IdFactura)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "");

            //primero acomodo los valores del stock para esa factura
            //depues borro todos los detalles de la factura si tiene
            Factura_detalle DetalleAnterior = Factura_detalle.GetFactura_detalle("", IdFactura);

            foreach (Factura_detalle ItemFactura_detalle in DetalleAnterior.ListaFactura_detalle)
            {
                if (!Factura_detalle.DeleteSinTransaccion(ItemFactura_detalle.Id_Factura_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            //Aca borro las cuotas
            Couta CoutaAnterior = Couta.GetCouta("", IdFactura, "");
            foreach (Couta ItemCouta in CoutaAnterior.ListaCouta)
            {
                //BUSCAS LAS CUOTAS QUE TIENEN RECIBOS Y BORRA LOS RECIBO
                Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", "", ItemCouta.Id_Couta.ToString());
                foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
                {
                    DeleteRecibo_OrdenPagoSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura.ToString(), ref HuboError);
                }

                if (!Couta.DeleteSinTransaccion(ItemCouta.Id_Couta.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca MARCO LA FACTURA COMO NULA la factura en si..
            FacturaOriginal.ListaFactura[0].Anulado_Factura = true;
            if (!Factura.SetSinTransaccion(FacturaOriginal.ListaFactura[0]))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void DeleteRecibo_OrdenPagoSinTransaccion(string IdFactura, ref bool HuboError)
        {
            Factura FacturaOriginal = Factura.GetFactura(IdFactura, "", "", "", "", "", "").ListaFactura[0];

            //buscar las facturas asisnadas y sumar el importe en pendiente a todas las facturas
            Factura_recibo_asignaciones FRA = Factura_recibo_asignaciones.GetFactura_recibo_asignaciones("", IdFactura, "");

            foreach (Factura_recibo_asignaciones itemFactura_recibo_asignaciones in FRA.ListaFactura_recibo_asignaciones)
            {
                Couta C = Couta.GetCouta(itemFactura_recibo_asignaciones.Factura_Asignada_Factura_Recibo_Asignaciones.ToString(), "", "").ListaCouta[0];
                C.Pagado_Couta = false;
                C.Asignacion_Cuota -= FacturaOriginal.Total_Factura;
                if (C.Asignacion_Cuota < 0)
                {
                    C.Asignacion_Cuota = 0;
                }
                C.Importe_Interes_Couta = 0;
                C.Observaciones_Couta += " [CUOTA CANCELADA POR EL BORRADO DEL DEL RECIBO " + FacturaOriginal.Clase_Factura + " " + FacturaOriginal.Puesto_Factura.ToString("0000") + "-" + FacturaOriginal.Numero_Factura.ToString("00000000") + "]";
                if (!Couta.SetSinTransaccion(C))
                {
                    HuboError = true;
                }
                if (!Factura_recibo_asignaciones.DeleteSinTransaccion(itemFactura_recibo_asignaciones.Id_Factura_Recibo_Asignaciones.ToString()))
                {
                    HuboError = true;
                }
            }

            //busco en los detalles, y segun el tipo de recibo, devolver todo como estaba
            //eliminar lo de caja, tarjeta, banco, y en checarte ponerlo como no entregado

            Factura_recibo_detalle FRD = Factura_recibo_detalle.GetFactura_recibo_detalle("", IdFactura);

            foreach (Factura_recibo_detalle itemFactura_recibo_detalle in FRD.ListaFactura_recibo_detalle)
            {
                if (!Factura_recibo_detalle.DeleteSinTransaccion(itemFactura_recibo_detalle.Id_Factura_Recibo_Detalle.ToString()))
                {
                    HuboError = true;
                }
            }

            Caja Efectivo = Caja.GetCaja("", IdFactura);

            foreach (Caja itemCaja in Efectivo.ListaCaja)
            {
                if (!Caja.DeleteSinTransaccion(itemCaja.Id_Caja.ToString()))
                {
                    HuboError = true;
                }
            }

            Cheque_cartera CC = Cheque_cartera.GetCheque_cartera("", IdFactura);
            foreach (Cheque_cartera itemCheque_cartera in CC.ListaCheque_cartera)
            {
                if (!Cheque_cartera.DeleteSinTransaccion(itemCheque_cartera.Id_Cheque_Cartera.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro la orden de pago
            if (!DeleteSinTransaccion(IdFactura))
            {
                HuboError = true;
            }
        }

        public static bool DeleteRecibo_OrdenPago(string IdFactura)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();

            DeleteRecibo_OrdenPagoSinTransaccion(IdFactura, ref HuboError);

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AddRecibo_OrdenPago(Factura ObjFactura, Couta ObjCuotas, Cheque_cartera ObjCheque_Cartera, Caja ObjCaja)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(ObjFactura))
            {
                HuboError = true;
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(factura.Id_Factura) FROM factura;").Tables[0].Rows[0][0]);

            foreach (Couta itemCouta in ObjCuotas.ListaCouta)
            {
                Factura_recibo_asignaciones FRA = new Factura_recibo_asignaciones();
                FRA.Det1_Factura_Recibo_Asignaciones = "";
                FRA.Factura_Asignada_Factura_Recibo_Asignaciones = itemCouta.Id_Couta;
                FRA.Id_Factura = UltimoId;
                FRA.Importe_Descuento_Factura_Recibo_Asignaciones = 0;
                FRA.Importe_Factura_Recibo_Asignaciones = itemCouta.Importe_Couta + itemCouta.Importe_Interes_Couta;
                FRA.Impresa_Factura_Recibo_Asignaciones = false;

                if (!Couta.SetSinTransaccion(itemCouta))
                {
                    HuboError = true;
                }

                if (!Factura_recibo_asignaciones.AddSinTransaccion(FRA))
                {
                    HuboError = true;
                }
            }

            Factura_recibo_detalle FRD = new Factura_recibo_detalle();
            FRD.ListaFactura_recibo_detalle = new List<Factura_recibo_detalle>();

            foreach (Caja itemCaja in ObjCaja.ListaCaja)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle();
                TEMP.Id_Factura = UltimoId;
                TEMP.Id_Factura_Recibo_Tipo = 1;
                TEMP.Importe_Descuento_Factura_Recibo_Detalle = 0;
                TEMP.Importe_Factura_Recibo_Detalle = itemCaja.Importe_Caja;

                FRD.ListaFactura_recibo_detalle.Add(TEMP);

                itemCaja.Numero_Remito_Caja = UltimoId;
                if (!Caja.AddSinTransaccion(itemCaja))
                {
                    HuboError = true;
                }
            }

            foreach (Cheque_cartera itemCheque_cartera in ObjCheque_Cartera.ListaCheque_cartera)
            {
                Factura_recibo_detalle TEMP = new Factura_recibo_detalle();
                TEMP.Id_Factura = UltimoId;
                TEMP.Id_Factura_Recibo_Tipo = 2;
                TEMP.Importe_Descuento_Factura_Recibo_Detalle = 0;
                TEMP.Importe_Factura_Recibo_Detalle = itemCheque_cartera.Importe_Cheque_Cartera;

                FRD.ListaFactura_recibo_detalle.Add(TEMP);

                itemCheque_cartera.Numero_Recibo_Cheque_Cartera = UltimoId;
                if (!Cheque_cartera.AddSinTransaccion(itemCheque_cartera))
                {
                    HuboError = true;
                }
            }

            foreach (Factura_recibo_detalle itemFactura_recibo_detalle in FRD.ListaFactura_recibo_detalle)
            {
                if (!Factura_recibo_detalle.AddSinTransaccion(itemFactura_recibo_detalle))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Factura_detalle
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_detalle GetFactura_detalle(string IdFactura_detalle, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_detalle != "")
            {
                Filtro += "AND Id_Factura_detalle = " + IdFactura_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Factura_detalle(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_detalle GetFactura_detalleRelacional(string IdFactura_detalle, string IdFactura)
        {
            string SqlString = "SELECT factura_detalle.id_factura_detalle, factura_detalle.id_factura, factura_detalle.articulo_factura_detalle, factura_detalle.cantidad_factura_detalle, factura_detalle.precio_unitario_factura_detalle, factura_detalle.bonifica_factura_detalle, factura.id_factura, factura.id_tercero, factura.id_factura_tipo, factura.fecha_factura, factura.fecha_vencimiento_factura, factura.clase_factura, factura.puesto_factura, factura.numero_factura, factura.neto_factura, factura.iva_105_factura, factura.iva_21_factura, factura.iva_27_factura, factura.percepcion_factura, factura.exentos_factura, factura.otros_factura, factura.total_factura, factura.retencion_factura, factura.interes_factura, factura.anulado_factura, factura.facturado_factura, factura.pagado_factura, factura.observaciones_factura FROM factura_detalle INNER JOIN factura ON (factura_detalle.id_factura = factura.id_factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_detalle != "")
            {
                Filtro += "AND factura_detalle.Id_Factura_detalle = " + IdFactura_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND factura_detalle.Id_Factura = " + IdFactura + " ";
            }
            return new Factura_detalle(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_asignaciones
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_asignaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_asignaciones GetFactura_recibo_asignaciones(string IdFactura_recibo_asignaciones, string IdFactura, string FacturaAsignada)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_asignaciones != "")
            {
                Filtro += "AND Id_Factura_recibo_asignaciones = " + IdFactura_recibo_asignaciones + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            if (FacturaAsignada != "")
            {
                Filtro += "AND Factura_Asignada_Factura_Recibo_Asignaciones = " + FacturaAsignada + " ";
            }
            return new Factura_recibo_asignaciones(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_recibo_asignaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_asignaciones GetFactura_recibo_asignacionesRelacional(string IdFactura_recibo_asignaciones, string IdFactura)
        {
            string SqlString = "SELECT factura_recibo_asignaciones.id_factura_recibo_asignaciones, factura_recibo_asignaciones.id_factura, factura_recibo_asignaciones.factura_asignada_factura_recibo_asignaciones, factura_recibo_asignaciones.impresa_factura_recibo_asignaciones, factura_recibo_asignaciones.det1_factura_recibo_asignaciones, factura_recibo_asignaciones.importe_factura_recibo_asignaciones, factura_recibo_asignaciones.importe_descuento_factura_recibo_asignaciones, factura.id_factura, factura.id_tercero, factura.id_factura_tipo, factura.fecha_factura, factura.fecha_vencimiento_factura, factura.clase_factura, factura.puesto_factura, factura.numero_factura, factura.neto_factura, factura.iva_105_factura, factura.iva_21_factura, factura.iva_27_factura, factura.percepcion_factura, factura.exentos_factura, factura.otros_factura, factura.total_factura, factura.retencion_factura, factura.anulado_factura, factura.facturado_factura, factura.pagado_factura, factura.observaciones_factura, factura.interes_factura FROM factura_recibo_asignaciones INNER JOIN factura ON (factura_recibo_asignaciones.id_factura = factura.id_factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_recibo_asignaciones != "")
            {
                Filtro += "AND factura_recibo_asignaciones.Id_Factura_recibo_asignaciones = " + IdFactura_recibo_asignaciones + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND factura_recibo_asignaciones.Id_Factura = " + IdFactura + " ";
            }
            return new Factura_recibo_asignaciones(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_detalle
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_detalle GetFactura_recibo_detalle(string IdFactura_recibo_detalle, string IdFactura)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_detalle != "")
            {
                Filtro += "AND Id_Factura_recibo_detalle = " + IdFactura_recibo_detalle + " ";
            }
            if (IdFactura != "")
            {
                Filtro += "AND Id_Factura = " + IdFactura + " ";
            }
            return new Factura_recibo_detalle(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdFactura_recibo_detalle">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_detalle GetFactura_recibo_detalleRelacional(string IdFactura_recibo_detalle)
        {
            string SqlString = "SELECT factura_recibo_detalle.Id_Factura_Recibo_Detalle, factura_recibo_detalle.Id_Factura, factura_recibo_detalle.Id_Factura_Recibo_Tipo, factura_recibo_detalle.Importe_Factura_Recibo_Detalle, factura_recibo_detalle.Importe_Descuento_Factura_Recibo_Detalle, factura.Id_Factura, factura.Id_Tercero, factura.Id_Factura_Tipo, factura.Fecha_Factura, factura.Fecha_Vencimiento_Factura, factura.Clase_Factura, factura.Puesto_Factura, factura.Numero_Factura, factura.Neto_Factura, factura.IVA_105_Factura, factura.IVA_21_Factura, factura.IVA_27_Factura, factura.Percepcion_Factura, factura.Exentos_Factura, factura.Otros_Factura, factura.Total_Factura, factura.Retencion_Factura, factura.Anulado_Factura, factura.Facturado_Factura, factura.Pagado_Factura, factura.Observaciones_Factura, factura_recibo_tipo.Id_Factura_Recibo_Tipo, factura_recibo_tipo.Descripcion_Factura_Recibo_Tipo FROM factura_recibo_detalle INNER JOIN factura_recibo_tipo ON (factura_recibo_detalle.Id_Factura_Recibo_Tipo = factura_recibo_tipo.Id_Factura_Recibo_Tipo) INNER JOIN factura ON (factura_recibo_detalle.Id_Factura = factura.Id_Factura)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdFactura_recibo_detalle != "")
            {
                Filtro += "AND factura_recibo_detalle.Id_Factura_recibo_detalle = " + IdFactura_recibo_detalle + " ";
            }
            return new Factura_recibo_detalle(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Factura_recibo_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_recibo_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_recibo_tipo GetFactura_recibo_tipo(string IdFactura_recibo_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_recibo_tipo != "")
            {
                Filtro += "AND Id_Factura_recibo_tipo = " + IdFactura_recibo_tipo + " ";
            }
            return new Factura_recibo_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Factura_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdFactura_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Factura_tipo GetFactura_tipo(string IdFactura_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdFactura_tipo != "")
            {
                Filtro += "AND Id_Factura_tipo = " + IdFactura_tipo + " ";
            }
            return new Factura_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Historial_sql
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdHistorial_sql">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Historial_sql GetHistorial_sql(string IdHistorial_sql)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdHistorial_sql != "")
            {
                Filtro += "AND Id_Historial_sql = " + IdHistorial_sql + " ";
            }
            return new Historial_sql(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Localidad
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdLocalidad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Localidad GetLocalidad(string IdLocalidad)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdLocalidad != "")
            {
                Filtro += "AND Id_Localidad = " + IdLocalidad + " ";
            }
            return new Localidad(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdLocalidad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Localidad GetLocalidadRelacional(string IdLocalidad)
        {
            string SqlString = "SELECT localidad.Id_Localidad, localidad.Id_Provincia, localidad.Nombre_Localidad, localidad.Codigo_Postal_Localidad, provincia.Id_Provincia, provincia.Id_Pais, provincia.Nombre_Provincia FROM localidad INNER JOIN provincia ON (localidad.Id_Provincia = provincia.Id_Provincia)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdLocalidad != "")
            {
                Filtro += "AND localidad.Id_Localidad = " + IdLocalidad + " ";
            }
            return new Localidad(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Medicacion
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdMedicacion">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Medicacion GetMedicacion(string IdMedicacion)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdMedicacion != "")
            {
                Filtro += "AND Id_Medicacion = " + IdMedicacion + " ";
            }
            return new Medicacion(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdMedicacion">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Medicacion GetMedicacionRelacional(string IdMedicacion,string PrincipioActivo,string NombreComercial,string IdAccionFarmacologica)
        {
            string SqlString = "SELECT medicacion.id_medicacion, medicacion.id_medicacion_laboratorio, medicacion.id_medicacion_accion_farmacologica, medicacion.id_medicacion_autorizacion, medicacion.principio_activo_medicacion, medicacion.nombre_comercial_medicacion, medicacion.presentacion_medicacion, medicacion.regis_medicacion, medicacion.troquel_medicacion, medicacion.observaciones_medicacion, medicacion_laboratorio.id_medicacion_laboratorio, medicacion_laboratorio.descripcion_laboratorio, medicacion_accion_farmacologica.id_medicacion_accion_farmacologica, medicacion_accion_farmacologica.descripcion_medicacion_accion_farmacologica, medicacion_autorizacion.id_medicacion_autorizacion, medicacion_autorizacion.descripcion_medicacion_autorizacion FROM medicacion INNER JOIN medicacion_laboratorio ON (medicacion.id_medicacion_laboratorio = medicacion_laboratorio.id_medicacion_laboratorio) INNER JOIN medicacion_accion_farmacologica ON (medicacion.id_medicacion_accion_farmacologica = medicacion_accion_farmacologica.id_medicacion_accion_farmacologica) INNER JOIN medicacion_autorizacion ON (medicacion.id_medicacion_autorizacion = medicacion_autorizacion.id_medicacion_autorizacion)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdMedicacion != "")
            {
                Filtro += "AND medicacion.Id_Medicacion = " + IdMedicacion + " ";
            }
            if (PrincipioActivo != "")
            {
                Filtro += "AND medicacion.principio_activo_medicacion LIKE '%" + PrincipioActivo.Replace(" ", "%") + "%' ";
            }
            if (NombreComercial != "")
            {
                Filtro += "AND medicacion.nombre_comercial_medicacion LIKE '%" + NombreComercial.Replace(" ", "%") + "%' ";
            }
            if (IdAccionFarmacologica != "")
            {
                Filtro += "AND medicacion.id_medicacion_accion_farmacologica = " + IdAccionFarmacologica + " ";
            }
            return new Medicacion(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Medicacion_accion_farmacologica
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdMedicacion_accion_farmacologica">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Medicacion_accion_farmacologica GetMedicacion_accion_farmacologica(string IdMedicacion_accion_farmacologica,string AccionFarmacologica)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdMedicacion_accion_farmacologica != "")
            {
                Filtro += "AND Id_Medicacion_accion_farmacologica = " + IdMedicacion_accion_farmacologica + " ";
            }
            if (AccionFarmacologica != "")
            {
                Filtro += "AND Descripcion_Medicacion_Accion_Farmacologica LIKE '%" + AccionFarmacologica.Replace(" ","%") + "%' ";
            }
            return new Medicacion_accion_farmacologica(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Medicacion_autorizacion
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdMedicacion_autorizacion">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Medicacion_autorizacion GetMedicacion_autorizacion(string IdMedicacion_autorizacion,string Autorizacion)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdMedicacion_autorizacion != "")
            {
                Filtro += "AND Id_Medicacion_autorizacion = " + IdMedicacion_autorizacion + " ";
            }
            if (Autorizacion != "")
            {
                Filtro += "AND Descripcion_Medicacion_Autorizacion LIKE '%" + Autorizacion.Replace(" ", "%") + "%' ";
            }
            return new Medicacion_autorizacion(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Medicacion_laboratorio
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdMedicacion_laboratorio">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Medicacion_laboratorio GetMedicacion_laboratorio(string IdMedicacion_laboratorio,string Laboratorio)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdMedicacion_laboratorio != "")
            {
                Filtro += "AND Id_Medicacion_laboratorio = " + IdMedicacion_laboratorio + " ";
            }
            if (Laboratorio != "")
            {
                Filtro += "AND Descripcion_Laboratorio LIKE '%" + Laboratorio.Replace(" ", "%") + "%' ";
            }
            return new Medicacion_laboratorio(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Obra_social
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdObra_social">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Obra_social GetObra_social(string IdObra_social, string ObraSocial)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdObra_social != "")
            {
                Filtro += "AND Id_Obra_social = " + IdObra_social + " ";
            }
            if (ObraSocial != "")
            {
                Filtro += "AND Descripcion_Obra_Social LIKE '%" + ObraSocial.Replace(" ", "%") + "%' ";
            }
            return new Obra_social(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Pais
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdPais">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Pais GetPais(string IdPais)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdPais != "")
            {
                Filtro += "AND Id_Pais = " + IdPais + " ";
            }
            return new Pais(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Provincia
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdProvincia">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Provincia GetProvincia(string IdProvincia)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdProvincia != "")
            {
                Filtro += "AND Id_Provincia = " + IdProvincia + " ";
            }
            return new Provincia(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdProvincia">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Provincia GetProvinciaRelacional(string IdProvincia)
        {
            string SqlString = "SELECT provincia.Id_Provincia, provincia.Id_Pais, provincia.Nombre_Provincia, pais.Id_Pais, pais.Nombre_Pais FROM provincia INNER JOIN pais ON (provincia.Id_Pais = pais.Id_Pais)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdProvincia != "")
            {
                Filtro += "AND provincia.Id_Provincia = " + IdProvincia + " ";
            }
            return new Provincia(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Series
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdSeries">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Series GetSeries(string IdSeries)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdSeries != "")
            {
                Filtro += "AND Id_Series = " + IdSeries + " ";
            }
            return new Series(Common.Peticion(GetSelect(Filtro)));
        }

        public static int UltimoNumeroComprobante(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            return S.ListaSeries[0].Numero;
        }

        public static int Bloquear(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            if (S.ListaSeries[0].Bloqueado)
            {
                throw new Exception("Este tipo de comprobante esta siendo usado.");
            }
            else
            {
                S.ListaSeries[0].Bloqueado = true;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.Set(S.ListaSeries[0]);
                return S.ListaSeries[0].Numero;
            }
        }

        public static void Desbloquear(string TipoFactura)
        {
            try
            {
                //buscar el valor y bloquear el registro
                Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
                S.ListaSeries[0].Bloqueado = false;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.Set(S.ListaSeries[0]);
            }
            catch
            {

            }
        }

        public static void DesbloquearSumar(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Numero++;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.Set(S.ListaSeries[0]);
        }

        public static int BloquearSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            if (S.ListaSeries[0].Bloqueado)
            {
                throw new Exception("Este tipo de comprobante esta siendo usado.");
            }
            else
            {
                S.ListaSeries[0].Bloqueado = true;
                S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
                Series.SetSinTransaccion(S.ListaSeries[0]);
                return S.ListaSeries[0].Numero;
            }
        }

        public static void DesbloquearSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.SetSinTransaccion(S.ListaSeries[0]);
        }

        public static void DesbloquearSumarSinTransaccion(string TipoFactura)
        {
            //buscar el valor y bloquear el registro
            Series S = new Series(Common.Peticion(Series.GetSelect("WHERE Comprobante = '" + TipoFactura + "'")));
            S.ListaSeries[0].Bloqueado = false;
            S.ListaSeries[0].Numero++;
            S.ListaSeries[0].Comprobante = "'" + S.ListaSeries[0].Comprobante + "'";
            Series.SetSinTransaccion(S.ListaSeries[0]);
        }

        /// <summary>
        /// Actualiza un fila a la tabla Series. es para actualizar, le pone las comillas para que no dee error en el "where"
        /// </summary>
        /// <param name="Obj">Objeto/Clase de tipo + Series</param>
        /// <returns>Devulve verdadero si la operación tuvo éxito</returns>
        public static bool SetComillas(Series Obj)
        {
            if (Obj.Comprobante == null)
            {
                throw new Exception("Comprobante no puede ser null");
            }
            Datos.Common.AbrirConexion();
            if (Common.InsertUpdate("UPDATE series SET `Numero` =  '" + Obj.Numero.ToString() + "', `Bloqueado` = " + Common.BoolToString(Obj.Bloqueado) + " WHERE series.Comprobante = '" + Obj.Comprobante.ToString() + "';"))
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
    }
    public partial class Tercero
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero GetTercero(string IdTercero, string TipoTercero)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }
            if (TipoTercero != "")
            {
                Filtro += "AND Id_Tercero_Tipo = " + TipoTercero + " ";
            }
            return new Tercero(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdTercero">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero GetTerceroRelacional(string IdTercero, string TipoTercero, string RazonSocial)
        {
            string SqlString = "SELECT tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.observaciones_tercero, tercero_tipo.id_tercero_tipo, tercero_tipo.descripcion_tercero_tipo, tercero_iva.id_tercero_iva, tercero_iva.descripcion_tercero_iva, tercero_iva.abreviacion_tercero_iva, tercero_iva.clase_comprobante_compra_tercero_iva, tercero_iva.clase_comprobante_venta_tercero_iva, localidad.id_localidad, localidad.id_provincia, localidad.nombre_localidad, localidad.codigo_postal_localidad, tercero.id_obra_social, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero, obra_social.id_obra_social, obra_social.descripcion_obra_social, obra_social.observaciones_obra_social FROM tercero INNER JOIN tercero_iva ON (tercero.id_tercero_iva = tercero_iva.id_tercero_iva) INNER JOIN localidad ON (tercero.id_localidad = localidad.id_localidad) INNER JOIN tercero_tipo ON (tercero.id_tercero_tipo = tercero_tipo.id_tercero_tipo) INNER JOIN obra_social ON (tercero.id_obra_social = obra_social.id_obra_social)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero = " + IdTercero + " ";
            }
            if (TipoTercero != "")
            {
                Filtro += "AND tercero.Id_Tercero_Tipo = " + TipoTercero + " ";
            }
            if (RazonSocial != "")
            {
                Filtro += "AND tercero.Razon_Social_Tercero LIKE '%" + RazonSocial.Replace(" ", "%") + "%' ";
            }
            return new Tercero(Common.Peticion(SqlString + Filtro + ";"));
        }
        /// <summary>
        /// Agregar un tercero con sus relaciones y enfermedades
        /// </summary>
        /// <param name="Tercero">Tercero que se va agregar</param>
        /// <param name="Relaciones">Relaciones del tercero</param>
        /// <param name="Enfermedades">Enfermedader correspondiente al tercero</param>
        /// <returns>Devuelte true si todo salio bien</returns>
        public static bool Add_TerceroRelacionEnfermedad(Tercero Tercero, Tercero_relaciones Relaciones, Tercero_enfermedad Enfermedades)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!AddSinTransaccion(Tercero))
            {
                HuboError = true;
            }

            int UltimoId = Convert.ToInt32(Common.Peticion("SELECT MAX(tercero.Id_Tercero) FROM tercero;").Tables[0].Rows[0][0]);

            foreach (Tercero_relaciones ItemTercero_relaciones in Relaciones.ListaTercero_relaciones)
            {
                ItemTercero_relaciones.Id_Tercero = UltimoId;
                if (!Tercero_relaciones.AddSinTransaccion(ItemTercero_relaciones))
                {
                    HuboError = true;
                }
            }

            foreach (Datos.Tercero_enfermedad itemTercero_enfermedad in Enfermedades.ListaTercero_enfermedad)
            {
                itemTercero_enfermedad.Id_Tercero = UltimoId;
                if (!Tercero_enfermedad.AddSinTransaccion(itemTercero_enfermedad))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Modifica los datos de un tercero con sus relaciones y enfermedades
        /// </summary>
        /// <param name="Tercero">Tercero que se va agregar</param>
        /// <param name="Relaciones">Relaciones del tercero</param>
        /// <param name="Enfermedades">Enfermedader correspondiente al tercero</param>
        /// <returns>Devuelte true si todo salio bien</returns>
        public static bool Set_TerceroRelacionEnfermedad(Tercero Tercero, Tercero_relaciones Relaciones, Tercero_enfermedad Enfermedades)
        {
            bool HuboError = false;
            Consultorio.Datos.Common.AbrirConexion();

            if (!SetSinTransaccion(Tercero))
            {
                HuboError = true;
            }

            //Borro las relaciones anteriores
            Tercero_relaciones TR = Datos.Tercero_relaciones.GetTercero_relaciones("", Tercero.Id_Tercero.ToString());
            foreach (Tercero_relaciones ItemTercero_relaciones in TR.ListaTercero_relaciones)
            {
                if (!Tercero_relaciones.DeleteSinTransaccion(ItemTercero_relaciones.Id_Tercero_Relaciones.ToString()))
                {
                    HuboError = true;
                }
            }
            //Agrego las nuevas relaciones
            foreach (Tercero_relaciones ItemTercero_relaciones in Relaciones.ListaTercero_relaciones)
            {
                ItemTercero_relaciones.Id_Tercero = Tercero.Id_Tercero;
                if (!Tercero_relaciones.AddSinTransaccion(ItemTercero_relaciones))
                {
                    HuboError = true;
                }
            }

            //Borro las emfermedades anteriores
            Tercero_enfermedad TE = Datos.Tercero_enfermedad.GetTercero_enfermedad("", Tercero.Id_Tercero.ToString());
            foreach (Tercero_enfermedad ItemTercero_enfermedad in TE.ListaTercero_enfermedad)
            {
                if (!Tercero_enfermedad.DeleteSinTransaccion(ItemTercero_enfermedad.Id_Tercero_Enfermedad.ToString()))
                {
                    HuboError = true;
                }
            }
            //Agrego las nuevas enfermedades
            foreach (Datos.Tercero_enfermedad itemTercero_enfermedad in Enfermedades.ListaTercero_enfermedad)
            {
                itemTercero_enfermedad.Id_Tercero = Tercero.Id_Tercero;
                if (!Tercero_enfermedad.AddSinTransaccion(itemTercero_enfermedad))
                {
                    HuboError = true;
                }
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Borra un tercero con sus relaciones.
        /// </summary>
        /// <param name="IdTercero">Id del tercero que se va a eliminar</param>
        /// <returns>Devuelve true si todo salio bien</returns>
        public static bool Delete_TerceroRelacionesEnfermedades(string IdTercero)
        {
            bool HuboError = false;

            Consultorio.Datos.Common.AbrirConexion();

            Tercero_relaciones TR = Datos.Tercero_relaciones.GetTercero_relaciones("", IdTercero);
            foreach (Tercero_relaciones ItemTercero_relaciones in TR.ListaTercero_relaciones)
            {
                if (!Tercero_relaciones.DeleteSinTransaccion(ItemTercero_relaciones.Id_Tercero_Relaciones.ToString()))
                {
                    HuboError = true;
                }
            }

            //Borro las emfermedades anteriores
            Tercero_enfermedad TE = Datos.Tercero_enfermedad.GetTercero_enfermedad("", IdTercero);
            foreach (Tercero_enfermedad ItemTercero_enfermedad in TE.ListaTercero_enfermedad)
            {
                if (!Tercero_enfermedad.DeleteSinTransaccion(ItemTercero_enfermedad.Id_Tercero_Enfermedad.ToString()))
                {
                    HuboError = true;
                }
            }

            //aca borro el tercero en si..
            if (!Tercero.DeleteSinTransaccion(IdTercero))
            {
                HuboError = true;
            }

            if (!HuboError)
            {
                Common.Transaccion.Commit();
                Common.Cnn.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public partial class Tercero_enfermedad
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_enfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_enfermedad GetTercero_enfermedad(string IdTercero_enfermedad,string IdTercero)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_enfermedad != "")
            {
                Filtro += "AND Id_Tercero_enfermedad = " + IdTercero_enfermedad + " ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }
            return new Tercero_enfermedad(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdTercero_enfermedad">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_enfermedad GetTercero_enfermedadRelacional(string IdTercero_enfermedad,string IdTercero)
        {
            string SqlString = "SELECT tercero_enfermedad.id_tercero_enfermedad, tercero_enfermedad.id_tercero, tercero_enfermedad.id_enfermedad, tercero_enfermedad.observaciones_tercero_enfermedad, tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.id_obra_social, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero, tercero.observaciones_tercero, enfermedad.id_enfermedad, enfermedad.id_enfermedad_categoria, enfermedad.codigo_enfermedad, enfermedad.descripcion_enfermedad, enfermedad.observaciones_enfermedad FROM tercero_enfermedad INNER JOIN tercero ON (tercero_enfermedad.id_tercero = tercero.id_tercero) INNER JOIN enfermedad ON (tercero_enfermedad.id_enfermedad = enfermedad.id_enfermedad)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdTercero_enfermedad != "")
            {
                Filtro += "AND tercero_enfermedad.Id_Tercero_enfermedad = " + IdTercero_enfermedad + " ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND tercero_enfermedad.id_tercero = " + IdTercero + " ";
            }
            return new Tercero_enfermedad(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Tercero_iva
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_iva">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_iva GetTercero_iva(string IdTercero_iva)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_iva != "")
            {
                Filtro += "AND Id_Tercero_iva = " + IdTercero_iva + " ";
            }
            return new Tercero_iva(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Tercero_relaciones
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_relaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_relaciones GetTercero_relaciones(string IdTercero_relaciones,string IdTercero)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_relaciones != "")
            {
                Filtro += "AND Id_Tercero_relaciones = " + IdTercero_relaciones + " ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND Id_Tercero = " + IdTercero + " ";
            }
            return new Tercero_relaciones(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdTercero_relaciones">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_relaciones GetTercero_relacionesRelacional(string IdTercero_relaciones,string IdTercero)
        {
            string SqlString = "SELECT tercero_relaciones.id_tercero_relaciones, tercero_relaciones.id_tercero, tercero_relaciones.relacion_tercero_relaciones, tercero_relaciones.observaciones_tercero_relaciones, tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.id_obra_social, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero, tercero.observaciones_tercero FROM tercero_relaciones INNER JOIN tercero ON (tercero_relaciones.id_tercero = tercero.id_tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdTercero_relaciones != "")
            {
                Filtro += "AND tercero_relaciones.Id_Tercero_relaciones = " + IdTercero_relaciones + " ";
            }
            if (IdTercero != "")
            {
                Filtro += "AND tercero_relaciones.id_tercero = " + IdTercero + " ";
            }
            return new Tercero_relaciones(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
    public partial class Tercero_tipo
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTercero_tipo">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tercero_tipo GetTercero_tipo(string IdTercero_tipo)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTercero_tipo != "")
            {
                Filtro += "AND Id_Tercero_tipo = " + IdTercero_tipo + " ";
            }
            return new Tercero_tipo(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Tratamiento
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTratamiento">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Tratamiento GetTratamiento(string IdTratamiento,string Tratamiento)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTratamiento != "")
            {
                Filtro += "AND Id_Tratamiento = " + IdTratamiento + " ";
            }
            if (Tratamiento != "")
            {
                Filtro += "AND Descripcion_Tratamiento LIKE '%" + Tratamiento.Replace(" ", "%") + "%' ";
            }
            return new Tratamiento(Common.Peticion(GetSelect(Filtro)));
        }
    }
    public partial class Turno
    {
        /// <summary>
        /// Traer datos de esta clase.
        /// </summary>
        /// <param name="IdTurno">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Turno GetTurno(string IdTurno)
        {
            string Filtro = "WHERE 0 < 1 ";
            if (IdTurno != "")
            {
                Filtro += "AND Id_Turno = " + IdTurno + " ";
            }
            return new Turno(Common.Peticion(GetSelect(Filtro)));
        }
        /// <summary>
        /// Traer datos de esta clase y sus relaciones.
        /// </summary>
        /// <param name="IdTurno">Id de esta tabla.</param>
        /// <returns>Devuelve una lista de datos de este tipo en su variable de lista.</returns>
        public static Turno GetTurnoRelacional(string IdTurno,string Tercero)
        {
            string SqlString = "SELECT turno.id_turno, turno.id_tercero, turno.fecha_turno, turno.observaciones_turno, tercero.id_tercero, tercero.id_tercero_tipo, tercero.id_tercero_iva, tercero.id_localidad, tercero.id_obra_social, tercero.razon_social_tercero, tercero.direccion_tercero, tercero.fecha_nacimiento_tercero, tercero.cuit_tercero, tercero.telefonos_tercero, tercero.dni_tercero, tercero.fax_tercero, tercero.email_tercero, tercero.fecha_alta_tercero, tercero.fecha_baja_tercero, tercero.anulado_tercero, tercero.sexo_tercero, tercero.estado_civil_tercero, tercero.ocupacion_tercero, tercero.ultima_consulta_tercero, tercero.observaciones_tercero FROM turno INNER JOIN tercero ON (turno.id_tercero = tercero.id_tercero)";
            string Filtro = " WHERE 0 < 1 ";
            if (IdTurno != "")
            {
                Filtro += "AND turno.Id_Turno = " + IdTurno + " ";
            }
            if (Tercero != "")
            {
                Filtro += "AND tercero.razon_social_tercero LIKE '%" + Tercero.Replace(" ","%") + "%' ";
            }
            return new Turno(Common.Peticion(SqlString + Filtro + ";"));
        }
    }
}