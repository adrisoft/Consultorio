-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: db
-- Generation Time: Jun 29, 2020 at 10:03 PM
-- Server version: 5.5.62
-- PHP Version: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `medico`
--

-- --------------------------------------------------------

--
-- Table structure for table `caja`
--

CREATE TABLE `caja` (
  `Id_Caja` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Caja_Tipo` int(6) NOT NULL COMMENT 'Tipo de caja, define si es entrada o salida',
  `Importe_Caja` decimal(10,4) NOT NULL COMMENT 'De cuanto es el movimiento, siempre en pesos',
  `Fecha_Caja` datetime NOT NULL COMMENT 'Fecha del movimiento',
  `Numero_Remito_Caja` int(6) DEFAULT NULL COMMENT 'Numero del remito, si lo tiene',
  `Numero_Cuota_Caja` int(6) DEFAULT NULL COMMENT 'Numero de cuota de pago del remito',
  `Tag_Caja` varchar(255) DEFAULT NULL COMMENT 'Para almacenar datos de la aplicacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guarda todos las salidas y entradas de la caja en efectiv';

-- --------------------------------------------------------

--
-- Table structure for table `caja_tipo`
--

CREATE TABLE `caja_tipo` (
  `Id_Caja_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Caja_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de caja, con esto se define si es entrada o salida'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Para saber que tipo de modificacion se le puede hacer a la c';

-- --------------------------------------------------------

--
-- Table structure for table `cheque_cartera`
--

CREATE TABLE `cheque_cartera` (
  `Id_Cheque_Cartera` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Localidad` int(6) NOT NULL COMMENT 'Localidad del cheque',
  `Codigo_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Numero, codigo del cheque',
  `Numero_Recibo_Cheque_Cartera` int(6) NOT NULL COMMENT 'Numero de recibo con el que entregaron el cheque',
  `Nombre_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Nombre del banco de donde sale el cheque',
  `Fecha_Emicion_Cheque_Cartera` datetime NOT NULL COMMENT 'Fecha de cuando se emite el cheque',
  `Fecha_Vencimiento_Cheque_Cartera` datetime NOT NULL COMMENT 'Cuando se vence',
  `Nombre_Librador_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Nombre del que libera el cheque',
  `Marca_Cheque_Cartera` bit(1) NOT NULL,
  `Importe_Cheque_Cartera` decimal(10,4) NOT NULL COMMENT 'Importe del cheque',
  `Detalle_Cheque_Cartera` varchar(255) NOT NULL COMMENT 'Algunos detalles sobre este cheque'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Cheques que entregan como forma de pago los clientes';

-- --------------------------------------------------------

--
-- Table structure for table `consulta`
--

CREATE TABLE `consulta` (
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'id del tercero al que estara relacionada esta consulta',
  `Motivo_Consulta` text NOT NULL COMMENT 'Motivo de la consulta',
  `Analisis_Visual_Consulta` text NOT NULL COMMENT 'Analisis visual de la consulta',
  `Evolucion_Consulta` text NOT NULL COMMENT 'Evolucion de la consulta',
  `Alta_Medica_Consulta` text NOT NULL COMMENT 'Detalles del alta medica',
  `Fecha_Consulta` datetime NOT NULL COMMENT 'Fecha en la cual se inicio la consulta',
  `Fecha_Alta_Consulta` datetime NOT NULL COMMENT 'Fecha en la que se da de alta un cliente',
  `Alta_Consulta` bit(1) NOT NULL COMMENT 'Es verdadero cuando el paciente tiene un alta medica',
  `Observaciones_Consulta` text NOT NULL COMMENT 'Observaciones de la consulta'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se guardan las consultas medicas';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_enfermedad`
--

CREATE TABLE `consulta_enfermedad` (
  `Id_Consulta_Enfermedad` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la consulta conrrespondiente',
  `Id_Enfermedad` int(6) NOT NULL COMMENT 'Id de la enfermedad, diagnostico de la consulta'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guarda el diagnostico de la consulta';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_estudio`
--

CREATE TABLE `consulta_estudio` (
  `Id_Consulta_Estudio` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Consulta a la que se le va a asisganar un estudio',
  `Id_Estudio` int(6) NOT NULL COMMENT 'Estudio asignado a la consulta anterior'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='asignaciones de estudios a las consultas';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_imagenes`
--

CREATE TABLE `consulta_imagenes` (
  `Id_Consulta_Imagenes` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la consulta conrrespondiente',
  `Imagen_Consulta_Imagenes` varchar(41) NOT NULL COMMENT 'Nombre de una imagen y su extencion',
  `Observaciones_Consulta_Imagenes` varchar(255) NOT NULL COMMENT 'Observaciones de la imagen'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se guardan las imagenes de las consulta';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_medicacion`
--

CREATE TABLE `consulta_medicacion` (
  `Id_Consulta_Medicacion` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la consulta conrrespondiente',
  `Id_Medicacion` int(6) NOT NULL COMMENT 'Medicacamentos asignados a una consulta'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Medicamentos que tiene una consulta';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_tratamiento`
--

CREATE TABLE `consulta_tratamiento` (
  `Id_Consulta_Tratamiento` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la consulta conrrespondiente',
  `Id_Tratamiento` int(6) NOT NULL COMMENT 'id del tratamiento que se le va a asignar'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='asignaciones de tratamientos a las consultas';

-- --------------------------------------------------------

--
-- Table structure for table `consulta_visita`
--

CREATE TABLE `consulta_visita` (
  `Id_Consulta_Visita` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Consulta` int(6) NOT NULL COMMENT 'Id de la consulta conrrespondiente',
  `Fecha_Consulta_Visita` datetime NOT NULL COMMENT 'Fecha en que se realiza la visita',
  `Observaciones_Consulta_Visita` text NOT NULL COMMENT 'Observaciones de la visita'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se guardan las visitas que tubo una consulta';

-- --------------------------------------------------------

--
-- Table structure for table `couta`
--

CREATE TABLE `couta` (
  `Id_Couta` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'ID de la factura',
  `Numero_Couta_Couta` int(6) NOT NULL COMMENT 'Numero de la cuota',
  `Fecha_Vencimineto_Couta` datetime NOT NULL COMMENT 'Fecha vencimiento',
  `Fecha_Pago_Couta` datetime NOT NULL COMMENT 'Fecha del pago de la cuota',
  `Importe_Couta` decimal(10,4) NOT NULL COMMENT 'Importe de la cuota',
  `Importe_Interes_Couta` decimal(10,4) NOT NULL COMMENT 'Este interes se agrecuando se pago fuera de termino',
  `Asignacion_Cuota` decimal(10,4) NOT NULL COMMENT 'Aca se guarda el valor que se le va a asignar a la cuota, esto sirve para pargar una cuota parcialmente (fecha modif.: 23-11-2011)',
  `Pagado_Couta` bit(1) NOT NULL COMMENT 'Este campo es vendadero cuando esta cuota ya esta pagada',
  `Observaciones_Couta` varchar(255) NOT NULL COMMENT 'Algunas observaciones en el pago de la cuota'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se lleva el control de las coutas';

-- --------------------------------------------------------

--
-- Table structure for table `empresa`
--

CREATE TABLE `empresa` (
  `Id_Empresa` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Localidad` int(6) NOT NULL COMMENT 'Localidad de la empresa',
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'IVA de la empresa',
  `Razon_Social_Empresa` varchar(255) NOT NULL COMMENT 'Razon Social o nombre de la empresa',
  `Titular_Empresa` varchar(255) NOT NULL COMMENT 'Titular de dueño de la empresa',
  `CUIT_Empresa` varchar(13) NOT NULL COMMENT 'CUIT de la empresa',
  `Direccion_Empresa` varchar(255) NOT NULL COMMENT 'Direccion de la empresa',
  `Telefonos_Empresa` varchar(255) NOT NULL COMMENT 'Telefonos de la empresa',
  `Fax_Empresa` varchar(255) NOT NULL COMMENT 'Fax de la empresa',
  `Email_Empresa` varchar(255) NOT NULL COMMENT 'Email de la empresa',
  `Web_Empresa` varchar(255) NOT NULL COMMENT 'Web de la empresa',
  `Inicio_Actividades_Empresa` datetime NOT NULL COMMENT 'Cuando se inicio la actividad de la empresa',
  `Ingresos_Brutos_Empresa` varchar(255) NOT NULL COMMENT 'Ingresos brutos de la empresa'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Datos de la empresa';

-- --------------------------------------------------------

--
-- Table structure for table `enfermedad`
--

CREATE TABLE `enfermedad` (
  `Id_Enfermedad` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Enfermedad_Categoria` int(6) NOT NULL COMMENT 'Id de la categoria de la enfermedad',
  `Codigo_Enfermedad` varchar(5) NOT NULL COMMENT 'codigo de la enfermedad',
  `Descripcion_Enfermedad` varchar(255) NOT NULL COMMENT 'descripcion o nombre de la enfermedad',
  `Observaciones_Enfermedad` text NOT NULL COMMENT 'Obsercaciones de la enfermedad'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guardan las enfermedades, los datos iniciales se sacaron de: CLASIFICACION ESTADISTICA INTERNACIONAL DE ENFERMEDADES Y PROBLEMAS RELACIONADOS CON LA SALUD. DECIMA REVISION. - CIE 10- CODIGOS Y DESCRIPCION A TRES Y CUATRO DIGITOS.';

-- --------------------------------------------------------

--
-- Table structure for table `enfermedad_categoria`
--

CREATE TABLE `enfermedad_categoria` (
  `Id_Enfermedad_Categoria` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Codigo_Enfermedad_Categoria` varchar(10) NOT NULL COMMENT 'Codigo de la categoria',
  `Descripcion_Enfermedad_Categoria` varchar(255) NOT NULL COMMENT 'descripcion de la categoria',
  `Observaciones_Enfermedad_Categoria` text NOT NULL COMMENT 'Observaciones de la categoria'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Estas son las categorias que hay en las enfermedades.';

-- --------------------------------------------------------

--
-- Table structure for table `estudio`
--

CREATE TABLE `estudio` (
  `Id_Estudio` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Estudio` varchar(255) NOT NULL COMMENT 'Decripcion del Estudio'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se encuentran los estudios';

-- --------------------------------------------------------

--
-- Table structure for table `factura`
--

CREATE TABLE `factura` (
  `Id_Factura` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'ID del tercero responsable del comprobante',
  `Id_Factura_Tipo` int(6) NOT NULL COMMENT 'Tipo de factura',
  `Fecha_Factura` datetime NOT NULL COMMENT 'Facha en que se realiaza la factura',
  `Fecha_Vencimiento_Factura` datetime NOT NULL COMMENT 'Fecha de vencimiento de la factura',
  `Clase_Factura` varchar(1) NOT NULL COMMENT 'Clase de la factura',
  `Puesto_Factura` int(4) NOT NULL COMMENT 'Puesto de la factura',
  `Numero_Factura` int(8) NOT NULL COMMENT 'Numero de la factura',
  `Neto_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total del Neto de la factura',
  `IVA_105_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 10,5%',
  `IVA_21_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 21%',
  `IVA_27_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos con IVA 27%',
  `Percepcion_Factura` decimal(10,4) NOT NULL COMMENT 'Valor de la percepcion',
  `Exentos_Factura` decimal(10,4) NOT NULL COMMENT 'Valor total de los articulos sin IVA',
  `Otros_Factura` decimal(10,4) NOT NULL COMMENT 'Otros valores, recargos, importes internos, etc.',
  `Total_Factura` decimal(10,4) NOT NULL COMMENT 'Total de la factura',
  `Retencion_Factura` decimal(10,4) NOT NULL COMMENT 'Retencion de la factura',
  `Interes_Factura` decimal(10,4) NOT NULL COMMENT 'Interes que se le agrega a las cuotas',
  `Anulado_Factura` bit(1) NOT NULL COMMENT 'Si es verdadero la factura esta anulada',
  `Facturado_Factura` bit(1) NOT NULL COMMENT 'Si es verdadero la factura esta facturada',
  `Pagado_Factura` bit(1) NOT NULL COMMENT 'Se usa para los proveedores, para saber cuando esta pagada la factura de compra',
  `Observaciones_Factura` varchar(255) NOT NULL COMMENT 'Observaciones de la factura'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Aca van todas las facturas';

-- --------------------------------------------------------

--
-- Table structure for table `factura_detalle`
--

CREATE TABLE `factura_detalle` (
  `Id_Factura_Detalle` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Id de la factura',
  `Articulo_Factura_Detalle` varchar(255) NOT NULL COMMENT 'Id del articulo',
  `Cantidad_Factura_Detalle` int(6) NOT NULL COMMENT 'Cantidad de articulos',
  `Precio_Unitario_Factura_Detalle` decimal(10,4) NOT NULL COMMENT 'Precio unitario del articulo',
  `Bonifica_Factura_Detalle` decimal(10,4) NOT NULL COMMENT 'Bonificacion del articulo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Detalle de la factura, los articulos.';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_asignaciones`
--

CREATE TABLE `factura_recibo_asignaciones` (
  `Id_Factura_Recibo_Asignaciones` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Factura, que seria el recibo u orden de pago a que se le van a asignar facturas',
  `Factura_Asignada_Factura_Recibo_Asignaciones` int(6) NOT NULL COMMENT 'factura que se le asigna a esta orden o recibo',
  `Impresa_Factura_Recibo_Asignaciones` bit(1) NOT NULL,
  `Det1_Factura_Recibo_Asignaciones` varchar(2) NOT NULL,
  `Importe_Factura_Recibo_Asignaciones` decimal(10,4) NOT NULL COMMENT 'Importe de lo que se le va a asignar a esta factura',
  `Importe_Descuento_Factura_Recibo_Asignaciones` decimal(10,4) NOT NULL COMMENT 'Descuento que tiene esta facturas'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Asignaciones que se le hacen a las facturas';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_detalle`
--

CREATE TABLE `factura_recibo_detalle` (
  `Id_Factura_Recibo_Detalle` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Factura` int(6) NOT NULL COMMENT 'Id de la orden de pago o recibo',
  `Id_Factura_Recibo_Tipo` int(6) NOT NULL COMMENT 'Tipo asignacion a este recibo u orden',
  `Importe_Factura_Recibo_Detalle` decimal(10,4) NOT NULL COMMENT 'Importe de la asignacion',
  `Importe_Descuento_Factura_Recibo_Detalle` decimal(10,4) NOT NULL COMMENT 'Algun descuento a la asignacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Detalle de los recibo y ordenes';

-- --------------------------------------------------------

--
-- Table structure for table `factura_recibo_tipo`
--

CREATE TABLE `factura_recibo_tipo` (
  `Id_Factura_Recibo_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Factura_Recibo_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de recibo, es la forma de pago'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de pagos en recibos';

-- --------------------------------------------------------

--
-- Table structure for table `factura_tipo`
--

CREATE TABLE `factura_tipo` (
  `Id_Factura_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Factura_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de factura',
  `Abreviacion_Factura_Tipo` varchar(4) NOT NULL COMMENT 'Abreviatura del tipo de factura'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de comprobantes';

-- --------------------------------------------------------

--
-- Table structure for table `historial_sql`
--

CREATE TABLE `historial_sql` (
  `Id_Historial_SQL` int(6) NOT NULL COMMENT 'ID de la tabla',
  `SQL_Historial_SQL` text NOT NULL COMMENT 'SQL que modifica la base de datos',
  `Fecha_Historial_SQL` datetime NOT NULL COMMENT 'Fecha y hora en que se ejecula la SQL',
  `IP_Historial_SQL` varchar(15) NOT NULL COMMENT 'IP de donde biene el SQL',
  `Nombre_Host_Historial_SQL` varchar(255) NOT NULL COMMENT 'Nombre del equipo'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Contiene todas las modificaciones que se hace en la base de ';

-- --------------------------------------------------------

--
-- Table structure for table `localidad`
--

CREATE TABLE `localidad` (
  `Id_Localidad` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Provincia` int(6) NOT NULL COMMENT 'ID de la provincia',
  `Nombre_Localidad` varchar(255) NOT NULL COMMENT 'Nombre de la localidad',
  `Codigo_Postal_Localidad` int(6) NOT NULL COMMENT 'Codigo postal de la localidad'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Ciudades del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `medicacion`
--

CREATE TABLE `medicacion` (
  `Id_Medicacion` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Medicacion_Laboratorio` int(6) NOT NULL COMMENT 'Id del laboratorio',
  `Id_Medicacion_Accion_Farmacologica` int(6) NOT NULL COMMENT 'id de la accion facmacologica',
  `Id_Medicacion_Autorizacion` int(6) NOT NULL COMMENT 'id de la autorizacion',
  `Principio_Activo_Medicacion` varchar(255) NOT NULL COMMENT 'Principio activo',
  `Nombre_Comercial_Medicacion` varchar(255) NOT NULL COMMENT 'Nombre comercial',
  `Presentacion_Medicacion` varchar(255) NOT NULL COMMENT 'Presentacion',
  `Regis_Medicacion` varchar(10) NOT NULL COMMENT 'Regis',
  `Troquel_Medicacion` varchar(10) NOT NULL COMMENT 'Troquel',
  `Observaciones_Medicacion` text NOT NULL COMMENT 'Obsercaciones de la medicacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se guardan los medicamentos';

-- --------------------------------------------------------

--
-- Table structure for table `medicacion_accion_farmacologica`
--

CREATE TABLE `medicacion_accion_farmacologica` (
  `Id_Medicacion_Accion_Farmacologica` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Medicacion_Accion_Farmacologica` varchar(255) NOT NULL COMMENT 'Descripcion de la accion farmacologica'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guardan las acciones farmacologicas para la medicacion';

-- --------------------------------------------------------

--
-- Table structure for table `medicacion_autorizacion`
--

CREATE TABLE `medicacion_autorizacion` (
  `Id_Medicacion_Autorizacion` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Medicacion_Autorizacion` varchar(255) NOT NULL COMMENT 'Descripcion de la autorizacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Son las autorizaciones para los medicamentos.';

-- --------------------------------------------------------

--
-- Table structure for table `medicacion_laboratorio`
--

CREATE TABLE `medicacion_laboratorio` (
  `Id_Medicacion_Laboratorio` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Laboratorio` varchar(255) NOT NULL COMMENT 'Descripcion del Laboratorio'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Se guardan los laboratorios para los medicamentos.';

-- --------------------------------------------------------

--
-- Table structure for table `obra_social`
--

CREATE TABLE `obra_social` (
  `Id_Obra_Social` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Obra_Social` varchar(255) NOT NULL COMMENT 'Descripcion de la obra social',
  `Observaciones_Obra_Social` varchar(255) NOT NULL COMMENT 'Observaciones de la obra social'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `pais`
--

CREATE TABLE `pais` (
  `Id_Pais` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Nombre_Pais` varchar(255) NOT NULL COMMENT 'Nombre del pais'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Paises del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `provincia`
--

CREATE TABLE `provincia` (
  `Id_Provincia` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Pais` int(6) NOT NULL COMMENT 'Id del pais',
  `Nombre_Provincia` varchar(255) NOT NULL COMMENT 'Nombre de la provincia'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Provincias del sistema';

-- --------------------------------------------------------

--
-- Table structure for table `series`
--

CREATE TABLE `series` (
  `Comprobante` varchar(10) NOT NULL COMMENT 'Tipo de comprobantes',
  `Numero` int(8) NOT NULL COMMENT 'Numero de comprobante siguiente',
  `Bloqueado` bit(1) NOT NULL COMMENT 'Verdadero si esta bloqueado'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Lleva el control del los auto incrementos de los comprobante';

-- --------------------------------------------------------

--
-- Table structure for table `tercero`
--

CREATE TABLE `tercero` (
  `Id_Tercero` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Id_Tercero_Tipo` int(6) NOT NULL COMMENT 'Para saber si proveedor o cliente',
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'La condicion de iva del tercero',
  `Id_Localidad` int(6) NOT NULL COMMENT 'ID de la localidad de la aplicacion',
  `Id_Obra_Social` int(6) NOT NULL COMMENT 'Id de la obra social',
  `Razon_Social_Tercero` varchar(255) NOT NULL COMMENT 'Razon social, nombre y apellido del tercero',
  `Direccion_Tercero` varchar(255) NOT NULL COMMENT 'Direccion del tercero',
  `Fecha_Nacimiento_Tercero` datetime NOT NULL COMMENT 'Fecha de nacimiento',
  `CUIT_Tercero` varchar(13) NOT NULL COMMENT 'CUIT del tercero (por lo general a proveedores',
  `Telefonos_Tercero` varchar(255) NOT NULL COMMENT 'Telefonos del tercero',
  `DNI_Tercero` int(8) NOT NULL COMMENT 'DNI del tercero',
  `Fax_Tercero` varchar(255) NOT NULL COMMENT 'Fax del tercer',
  `Email_Tercero` varchar(255) NOT NULL COMMENT '"Email del tercero',
  `Fecha_Alta_Tercero` datetime NOT NULL COMMENT 'Fecha de alta del tercero',
  `Fecha_Baja_Tercero` datetime NOT NULL COMMENT 'Fecha de baja del tercero',
  `Anulado_Tercero` bit(1) NOT NULL COMMENT 'Es verdadero si esta anulado este tercero',
  `Sexo_Tercero` bit(1) NOT NULL COMMENT 'Sexo (Masculino - Femenino) del tercero',
  `Estado_Civil_Tercero` varchar(15) NOT NULL COMMENT 'Estado civil (soltero,casado,divorciado,viudo,separado) del tercero',
  `Ocupacion_Tercero` varchar(255) NOT NULL COMMENT 'Ocupacion, trabajo del tercero',
  `Ultima_Consulta_Tercero` datetime NOT NULL COMMENT 'Ultima consulta que realizo un paciente',
  `Observaciones_Tercero` varchar(255) NOT NULL COMMENT 'Observaciones del tercero'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Guarda los cliente y los proveedores';

-- --------------------------------------------------------

--
-- Table structure for table `tercero_enfermedad`
--

CREATE TABLE `tercero_enfermedad` (
  `Id_Tercero_Enfermedad` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'Id del tercero en cuestion',
  `Id_Enfermedad` int(6) NOT NULL COMMENT 'Enfermeadad relacionada',
  `Observaciones_Tercero_Enfermedad` varchar(255) NOT NULL COMMENT 'Observaciones del la enfermedad del tercero'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Enfermedades de un terecero';

-- --------------------------------------------------------

--
-- Table structure for table `tercero_iva`
--

CREATE TABLE `tercero_iva` (
  `Id_Tercero_IVA` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Tercero_IVA` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de iva/ condicion del tercero',
  `Abreviacion_Tercero_IVA` varchar(3) NOT NULL COMMENT 'Abreviatura del la descripcion',
  `Clase_Comprobante_Compra_Tercero_IVA` varchar(1) NOT NULL COMMENT 'Clase que se usa para este tipo de iva en la compra',
  `Clase_Comprobante_Venta_Tercero_IVA` varchar(1) NOT NULL COMMENT 'Clase que se usa para este tipo de iva en la venta'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Tipo de condicion de IVA';

-- --------------------------------------------------------

--
-- Table structure for table `tercero_relaciones`
--

CREATE TABLE `tercero_relaciones` (
  `Id_Tercero_Relaciones` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'Id del tercero en cuestion',
  `Relacion_Tercero_Relaciones` int(6) NOT NULL COMMENT 'Id del tercero al que se relaciona con el tercero en cuestion',
  `Observaciones_Tercero_Relaciones` varchar(255) NOT NULL COMMENT 'Observaciones de la relacion'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tercero_tipo`
--

CREATE TABLE `tercero_tipo` (
  `Id_Tercero_Tipo` int(6) NOT NULL COMMENT 'ID de la tabla',
  `Descripcion_Tercero_Tipo` varchar(255) NOT NULL COMMENT 'Descripcion del tipo de tipo de tercero'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Para saber si es proveedor o cliente';

-- --------------------------------------------------------

--
-- Table structure for table `tratamiento`
--

CREATE TABLE `tratamiento` (
  `Id_Tratamiento` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Descripcion_Tratamiento` varchar(255) NOT NULL COMMENT 'Descripcion del Tratamiento'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='En esta tabla se encuentran los tratamientos';

-- --------------------------------------------------------

--
-- Table structure for table `turno`
--

CREATE TABLE `turno` (
  `Id_Turno` int(6) NOT NULL COMMENT 'Id de la tabla',
  `Id_Tercero` int(6) NOT NULL COMMENT 'Id del tercero que pidio el turno',
  `Fecha_Turno` datetime NOT NULL COMMENT 'Fecha y hora del turno',
  `Observaciones_Turno` varchar(255) NOT NULL COMMENT 'Observaciones del turno'
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Turnos medicos';

--
-- Indexes for dumped tables
--

--
-- Indexes for table `caja`
--
ALTER TABLE `caja`
  ADD PRIMARY KEY (`Id_Caja`),
  ADD KEY `caja_caja_tipo` (`Id_Caja_Tipo`);

--
-- Indexes for table `caja_tipo`
--
ALTER TABLE `caja_tipo`
  ADD PRIMARY KEY (`Id_Caja_Tipo`);

--
-- Indexes for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  ADD PRIMARY KEY (`Id_Cheque_Cartera`),
  ADD KEY `cheque_cartera_localidad` (`Id_Localidad`);

--
-- Indexes for table `consulta`
--
ALTER TABLE `consulta`
  ADD PRIMARY KEY (`Id_Consulta`),
  ADD KEY `consulta_tercero` (`Id_Tercero`);

--
-- Indexes for table `consulta_enfermedad`
--
ALTER TABLE `consulta_enfermedad`
  ADD PRIMARY KEY (`Id_Consulta_Enfermedad`),
  ADD KEY `consulta_enfermedad_consulta` (`Id_Consulta`),
  ADD KEY `consulta_enfermedad_enfermedad` (`Id_Enfermedad`);

--
-- Indexes for table `consulta_estudio`
--
ALTER TABLE `consulta_estudio`
  ADD PRIMARY KEY (`Id_Consulta_Estudio`),
  ADD KEY `consulta_estudio_consulta` (`Id_Consulta`),
  ADD KEY `consulta_estudio_estudio` (`Id_Estudio`);

--
-- Indexes for table `consulta_imagenes`
--
ALTER TABLE `consulta_imagenes`
  ADD PRIMARY KEY (`Id_Consulta_Imagenes`),
  ADD KEY `consulta_imagenes_consulta` (`Id_Consulta`);

--
-- Indexes for table `consulta_medicacion`
--
ALTER TABLE `consulta_medicacion`
  ADD PRIMARY KEY (`Id_Consulta_Medicacion`),
  ADD KEY `consulta_medicacion_consulta` (`Id_Consulta`),
  ADD KEY `consulta_medicacion_medicacion` (`Id_Medicacion`);

--
-- Indexes for table `consulta_tratamiento`
--
ALTER TABLE `consulta_tratamiento`
  ADD PRIMARY KEY (`Id_Consulta_Tratamiento`),
  ADD KEY `consulta_tratamiento_consulta` (`Id_Consulta`),
  ADD KEY `consulta_tratamiento_tratamiento` (`Id_Tratamiento`);

--
-- Indexes for table `consulta_visita`
--
ALTER TABLE `consulta_visita`
  ADD PRIMARY KEY (`Id_Consulta_Visita`),
  ADD KEY `consulta_visita_consulta` (`Id_Consulta`);

--
-- Indexes for table `couta`
--
ALTER TABLE `couta`
  ADD PRIMARY KEY (`Id_Couta`),
  ADD KEY `cuota_factura` (`Id_Factura`);

--
-- Indexes for table `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`Id_Empresa`),
  ADD KEY `empresa_localidad` (`Id_Localidad`),
  ADD KEY `empresa_tercero_iva` (`Id_Tercero_IVA`);

--
-- Indexes for table `enfermedad`
--
ALTER TABLE `enfermedad`
  ADD PRIMARY KEY (`Id_Enfermedad`),
  ADD KEY `enfermedad_enfermedad_categoria` (`Id_Enfermedad_Categoria`);

--
-- Indexes for table `enfermedad_categoria`
--
ALTER TABLE `enfermedad_categoria`
  ADD PRIMARY KEY (`Id_Enfermedad_Categoria`);

--
-- Indexes for table `estudio`
--
ALTER TABLE `estudio`
  ADD PRIMARY KEY (`Id_Estudio`);

--
-- Indexes for table `factura`
--
ALTER TABLE `factura`
  ADD PRIMARY KEY (`Id_Factura`),
  ADD KEY `factura_tercero` (`Id_Tercero`),
  ADD KEY `factura_factura_tipo` (`Id_Factura_Tipo`);

--
-- Indexes for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD PRIMARY KEY (`Id_Factura_Detalle`),
  ADD KEY `factura_detalle_factura` (`Id_Factura`);

--
-- Indexes for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Asignaciones`),
  ADD KEY `factura_recibo_asignaciones_factura` (`Id_Factura`);

--
-- Indexes for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Detalle`),
  ADD KEY `factura_recibo_detalle_factura` (`Id_Factura`),
  ADD KEY `factura_recibo_detalle_factura_recibo_tipo` (`Id_Factura_Recibo_Tipo`);

--
-- Indexes for table `factura_recibo_tipo`
--
ALTER TABLE `factura_recibo_tipo`
  ADD PRIMARY KEY (`Id_Factura_Recibo_Tipo`);

--
-- Indexes for table `factura_tipo`
--
ALTER TABLE `factura_tipo`
  ADD PRIMARY KEY (`Id_Factura_Tipo`);

--
-- Indexes for table `historial_sql`
--
ALTER TABLE `historial_sql`
  ADD PRIMARY KEY (`Id_Historial_SQL`);

--
-- Indexes for table `localidad`
--
ALTER TABLE `localidad`
  ADD PRIMARY KEY (`Id_Localidad`),
  ADD KEY `localidad_provincia` (`Id_Provincia`);

--
-- Indexes for table `medicacion`
--
ALTER TABLE `medicacion`
  ADD PRIMARY KEY (`Id_Medicacion`),
  ADD KEY `medicacion_medicacion_accion_farmacologica` (`Id_Medicacion_Accion_Farmacologica`),
  ADD KEY `medicacion_medicacion_autorizacion` (`Id_Medicacion_Autorizacion`),
  ADD KEY `medicacion_medicacion_laboratorio` (`Id_Medicacion_Laboratorio`);

--
-- Indexes for table `medicacion_accion_farmacologica`
--
ALTER TABLE `medicacion_accion_farmacologica`
  ADD PRIMARY KEY (`Id_Medicacion_Accion_Farmacologica`);

--
-- Indexes for table `medicacion_autorizacion`
--
ALTER TABLE `medicacion_autorizacion`
  ADD PRIMARY KEY (`Id_Medicacion_Autorizacion`);

--
-- Indexes for table `medicacion_laboratorio`
--
ALTER TABLE `medicacion_laboratorio`
  ADD PRIMARY KEY (`Id_Medicacion_Laboratorio`);

--
-- Indexes for table `obra_social`
--
ALTER TABLE `obra_social`
  ADD PRIMARY KEY (`Id_Obra_Social`);

--
-- Indexes for table `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`Id_Pais`);

--
-- Indexes for table `provincia`
--
ALTER TABLE `provincia`
  ADD PRIMARY KEY (`Id_Provincia`),
  ADD KEY `provincia_pais` (`Id_Pais`);

--
-- Indexes for table `tercero`
--
ALTER TABLE `tercero`
  ADD PRIMARY KEY (`Id_Tercero`),
  ADD KEY `tercero_tercero_tipo` (`Id_Tercero_Tipo`),
  ADD KEY `tercero_tercero_iva` (`Id_Tercero_IVA`),
  ADD KEY `tercero_localidad` (`Id_Localidad`),
  ADD KEY `tercero_obra_social` (`Id_Obra_Social`);

--
-- Indexes for table `tercero_enfermedad`
--
ALTER TABLE `tercero_enfermedad`
  ADD PRIMARY KEY (`Id_Tercero_Enfermedad`),
  ADD KEY `tercero_enfermedad_enfermedad` (`Id_Enfermedad`),
  ADD KEY `tercero_enfermedad_tercero` (`Id_Tercero`);

--
-- Indexes for table `tercero_iva`
--
ALTER TABLE `tercero_iva`
  ADD PRIMARY KEY (`Id_Tercero_IVA`);

--
-- Indexes for table `tercero_relaciones`
--
ALTER TABLE `tercero_relaciones`
  ADD PRIMARY KEY (`Id_Tercero_Relaciones`),
  ADD KEY `tercero_relaciones_tercero` (`Id_Tercero`);

--
-- Indexes for table `tercero_tipo`
--
ALTER TABLE `tercero_tipo`
  ADD PRIMARY KEY (`Id_Tercero_Tipo`);

--
-- Indexes for table `tratamiento`
--
ALTER TABLE `tratamiento`
  ADD PRIMARY KEY (`Id_Tratamiento`);

--
-- Indexes for table `turno`
--
ALTER TABLE `turno`
  ADD PRIMARY KEY (`Id_Turno`),
  ADD KEY `turno_tercero` (`Id_Tercero`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `caja`
--
ALTER TABLE `caja`
  MODIFY `Id_Caja` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `caja_tipo`
--
ALTER TABLE `caja_tipo`
  MODIFY `Id_Caja_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  MODIFY `Id_Cheque_Cartera` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `consulta`
--
ALTER TABLE `consulta`
  MODIFY `Id_Consulta` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_enfermedad`
--
ALTER TABLE `consulta_enfermedad`
  MODIFY `Id_Consulta_Enfermedad` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_estudio`
--
ALTER TABLE `consulta_estudio`
  MODIFY `Id_Consulta_Estudio` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_imagenes`
--
ALTER TABLE `consulta_imagenes`
  MODIFY `Id_Consulta_Imagenes` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_medicacion`
--
ALTER TABLE `consulta_medicacion`
  MODIFY `Id_Consulta_Medicacion` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_tratamiento`
--
ALTER TABLE `consulta_tratamiento`
  MODIFY `Id_Consulta_Tratamiento` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `consulta_visita`
--
ALTER TABLE `consulta_visita`
  MODIFY `Id_Consulta_Visita` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `couta`
--
ALTER TABLE `couta`
  MODIFY `Id_Couta` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `empresa`
--
ALTER TABLE `empresa`
  MODIFY `Id_Empresa` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `enfermedad`
--
ALTER TABLE `enfermedad`
  MODIFY `Id_Enfermedad` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `enfermedad_categoria`
--
ALTER TABLE `enfermedad_categoria`
  MODIFY `Id_Enfermedad_Categoria` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `estudio`
--
ALTER TABLE `estudio`
  MODIFY `Id_Estudio` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `factura`
--
ALTER TABLE `factura`
  MODIFY `Id_Factura` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  MODIFY `Id_Factura_Detalle` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  MODIFY `Id_Factura_Recibo_Asignaciones` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  MODIFY `Id_Factura_Recibo_Detalle` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_recibo_tipo`
--
ALTER TABLE `factura_recibo_tipo`
  MODIFY `Id_Factura_Recibo_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `factura_tipo`
--
ALTER TABLE `factura_tipo`
  MODIFY `Id_Factura_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `historial_sql`
--
ALTER TABLE `historial_sql`
  MODIFY `Id_Historial_SQL` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `localidad`
--
ALTER TABLE `localidad`
  MODIFY `Id_Localidad` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `medicacion`
--
ALTER TABLE `medicacion`
  MODIFY `Id_Medicacion` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `medicacion_accion_farmacologica`
--
ALTER TABLE `medicacion_accion_farmacologica`
  MODIFY `Id_Medicacion_Accion_Farmacologica` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `medicacion_autorizacion`
--
ALTER TABLE `medicacion_autorizacion`
  MODIFY `Id_Medicacion_Autorizacion` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `medicacion_laboratorio`
--
ALTER TABLE `medicacion_laboratorio`
  MODIFY `Id_Medicacion_Laboratorio` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `obra_social`
--
ALTER TABLE `obra_social`
  MODIFY `Id_Obra_Social` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `pais`
--
ALTER TABLE `pais`
  MODIFY `Id_Pais` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `provincia`
--
ALTER TABLE `provincia`
  MODIFY `Id_Provincia` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero`
--
ALTER TABLE `tercero`
  MODIFY `Id_Tercero` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero_enfermedad`
--
ALTER TABLE `tercero_enfermedad`
  MODIFY `Id_Tercero_Enfermedad` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `tercero_iva`
--
ALTER TABLE `tercero_iva`
  MODIFY `Id_Tercero_IVA` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tercero_relaciones`
--
ALTER TABLE `tercero_relaciones`
  MODIFY `Id_Tercero_Relaciones` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `tercero_tipo`
--
ALTER TABLE `tercero_tipo`
  MODIFY `Id_Tercero_Tipo` int(6) NOT NULL AUTO_INCREMENT COMMENT 'ID de la tabla';

--
-- AUTO_INCREMENT for table `tratamiento`
--
ALTER TABLE `tratamiento`
  MODIFY `Id_Tratamiento` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- AUTO_INCREMENT for table `turno`
--
ALTER TABLE `turno`
  MODIFY `Id_Turno` int(6) NOT NULL AUTO_INCREMENT COMMENT 'Id de la tabla';

--
-- Constraints for dumped tables
--

--
-- Constraints for table `caja`
--
ALTER TABLE `caja`
  ADD CONSTRAINT `caja_caja_tipo` FOREIGN KEY (`Id_Caja_Tipo`) REFERENCES `caja_tipo` (`Id_Caja_Tipo`);

--
-- Constraints for table `cheque_cartera`
--
ALTER TABLE `cheque_cartera`
  ADD CONSTRAINT `cheque_cartera_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`);

--
-- Constraints for table `consulta`
--
ALTER TABLE `consulta`
  ADD CONSTRAINT `consulta_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `consulta_enfermedad`
--
ALTER TABLE `consulta_enfermedad`
  ADD CONSTRAINT `consulta_enfermedad_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`),
  ADD CONSTRAINT `consulta_enfermedad_enfermedad` FOREIGN KEY (`Id_Enfermedad`) REFERENCES `enfermedad` (`Id_Enfermedad`);

--
-- Constraints for table `consulta_estudio`
--
ALTER TABLE `consulta_estudio`
  ADD CONSTRAINT `consulta_estudio_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`),
  ADD CONSTRAINT `consulta_estudio_estudio` FOREIGN KEY (`Id_Estudio`) REFERENCES `estudio` (`Id_Estudio`);

--
-- Constraints for table `consulta_imagenes`
--
ALTER TABLE `consulta_imagenes`
  ADD CONSTRAINT `consulta_imagenes_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`);

--
-- Constraints for table `consulta_medicacion`
--
ALTER TABLE `consulta_medicacion`
  ADD CONSTRAINT `consulta_medicacion_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`),
  ADD CONSTRAINT `consulta_medicacion_medicacion` FOREIGN KEY (`Id_Medicacion`) REFERENCES `medicacion` (`Id_Medicacion`);

--
-- Constraints for table `consulta_tratamiento`
--
ALTER TABLE `consulta_tratamiento`
  ADD CONSTRAINT `consulta_tratamiento_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`),
  ADD CONSTRAINT `consulta_tratamiento_tratamiento` FOREIGN KEY (`Id_Tratamiento`) REFERENCES `tratamiento` (`Id_Tratamiento`);

--
-- Constraints for table `consulta_visita`
--
ALTER TABLE `consulta_visita`
  ADD CONSTRAINT `consulta_visita_consulta` FOREIGN KEY (`Id_Consulta`) REFERENCES `consulta` (`Id_Consulta`);

--
-- Constraints for table `couta`
--
ALTER TABLE `couta`
  ADD CONSTRAINT `cuota_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `empresa`
--
ALTER TABLE `empresa`
  ADD CONSTRAINT `empresa_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`),
  ADD CONSTRAINT `empresa_tercero_iva` FOREIGN KEY (`Id_Tercero_IVA`) REFERENCES `tercero_iva` (`Id_Tercero_IVA`);

--
-- Constraints for table `enfermedad`
--
ALTER TABLE `enfermedad`
  ADD CONSTRAINT `enfermedad_enfermedad_categoria` FOREIGN KEY (`Id_Enfermedad_Categoria`) REFERENCES `enfermedad_categoria` (`Id_Enfermedad_Categoria`);

--
-- Constraints for table `factura`
--
ALTER TABLE `factura`
  ADD CONSTRAINT `factura_factura_tipo` FOREIGN KEY (`Id_Factura_Tipo`) REFERENCES `factura_tipo` (`Id_Factura_Tipo`),
  ADD CONSTRAINT `factura_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `factura_detalle`
--
ALTER TABLE `factura_detalle`
  ADD CONSTRAINT `factura_detalle_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `factura_recibo_asignaciones`
--
ALTER TABLE `factura_recibo_asignaciones`
  ADD CONSTRAINT `factura_recibo_asignaciones_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`);

--
-- Constraints for table `factura_recibo_detalle`
--
ALTER TABLE `factura_recibo_detalle`
  ADD CONSTRAINT `factura_recibo_detalle_factura` FOREIGN KEY (`Id_Factura`) REFERENCES `factura` (`Id_Factura`),
  ADD CONSTRAINT `factura_recibo_detalle_factura_recibo_tipo` FOREIGN KEY (`Id_Factura_Recibo_Tipo`) REFERENCES `factura_recibo_tipo` (`Id_Factura_Recibo_Tipo`);

--
-- Constraints for table `localidad`
--
ALTER TABLE `localidad`
  ADD CONSTRAINT `localidad_provincia` FOREIGN KEY (`Id_Provincia`) REFERENCES `provincia` (`Id_Provincia`);

--
-- Constraints for table `medicacion`
--
ALTER TABLE `medicacion`
  ADD CONSTRAINT `medicacion_medicacion_accion_farmacologica` FOREIGN KEY (`Id_Medicacion_Accion_Farmacologica`) REFERENCES `medicacion_accion_farmacologica` (`Id_Medicacion_Accion_Farmacologica`),
  ADD CONSTRAINT `medicacion_medicacion_autorizacion` FOREIGN KEY (`Id_Medicacion_Autorizacion`) REFERENCES `medicacion_autorizacion` (`Id_Medicacion_Autorizacion`),
  ADD CONSTRAINT `medicacion_medicacion_laboratorio` FOREIGN KEY (`Id_Medicacion_Laboratorio`) REFERENCES `medicacion_laboratorio` (`Id_Medicacion_Laboratorio`);

--
-- Constraints for table `provincia`
--
ALTER TABLE `provincia`
  ADD CONSTRAINT `provincia_pais` FOREIGN KEY (`Id_Pais`) REFERENCES `pais` (`Id_Pais`);

--
-- Constraints for table `tercero`
--
ALTER TABLE `tercero`
  ADD CONSTRAINT `tercero_localidad` FOREIGN KEY (`Id_Localidad`) REFERENCES `localidad` (`Id_Localidad`),
  ADD CONSTRAINT `tercero_obra_social` FOREIGN KEY (`Id_Obra_Social`) REFERENCES `obra_social` (`Id_Obra_Social`),
  ADD CONSTRAINT `tercero_tercero_iva` FOREIGN KEY (`Id_Tercero_IVA`) REFERENCES `tercero_iva` (`Id_Tercero_IVA`),
  ADD CONSTRAINT `tercero_tercero_tipo` FOREIGN KEY (`Id_Tercero_Tipo`) REFERENCES `tercero_tipo` (`Id_Tercero_Tipo`);

--
-- Constraints for table `tercero_enfermedad`
--
ALTER TABLE `tercero_enfermedad`
  ADD CONSTRAINT `tercero_enfermedad_enfermedad` FOREIGN KEY (`Id_Enfermedad`) REFERENCES `enfermedad` (`Id_Enfermedad`),
  ADD CONSTRAINT `tercero_enfermedad_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `tercero_relaciones`
--
ALTER TABLE `tercero_relaciones`
  ADD CONSTRAINT `tercero_relaciones_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);

--
-- Constraints for table `turno`
--
ALTER TABLE `turno`
  ADD CONSTRAINT `turno_tercero` FOREIGN KEY (`Id_Tercero`) REFERENCES `tercero` (`Id_Tercero`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
