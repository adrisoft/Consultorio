using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consultorio
{
    public static class Config
    {
        /// <summary>
        /// Carpeta en donde estan las imagenes
        /// </summary>
        public static string RutaImagenes = "";

        /// <summary>
        /// Formato decimal con dos ceros
        /// </summary>
        public static string NumeroDecimales = "#,##0.00";

        /// <summary>
        /// Formato de fecha AÑO-MES-DIA
        /// </summary>
        public static string FechaMySQL = "yyyy-MM-dd";

        /// <summary>
        /// Formato de fecha DIA/MES/AÑO
        /// </summary>
        public static string FechaMySQL2 = "dd/MM/yyyy";

        /// <summary>
        /// Formato fecha y hora AÑO-MES-DIA HORA:MINUTOS:SEGUNDOS
        /// </summary>
        public static string FachaHoraMySQL = "yyyy-MM-dd HH:mm:ss";

        /// <summary>
        /// Esta variable se usa al principio para saber si se carga o no la ventana principal
        /// </summary>
        public static bool CargarFormPrincipal = false;

        /// <summary>
        /// Nombre del tipo de fuente que usa para las grillas.
        /// </summary>
        public static string NombreFont = "Arial";

        /// <summary>
        /// Tamaño de las fuentes que se usa para las grillas.
        /// </summary>
        public static float TamañoFont = 10;
    }
}
