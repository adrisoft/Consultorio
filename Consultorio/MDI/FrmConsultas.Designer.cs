namespace Consultorio.MDI
{
    partial class FrmConsultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CantidadRegistros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Detener = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTercero = new System.Windows.Forms.Button();
            this.id_TerceroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.ImgIcono = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Progreso = new System.Windows.Forms.ToolStripProgressBar();
            this.LblPorcentaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Btn_Imprimir = new System.Windows.Forms.Button();
            this.Btn_ImpHC = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Txt_CantidadRegistros);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Location = new System.Drawing.Point(5, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(820, 50);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(712, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sin alta médica:";
            // 
            // Txt_CantidadRegistros
            // 
            this.Txt_CantidadRegistros.Enabled = false;
            this.Txt_CantidadRegistros.Location = new System.Drawing.Point(123, 17);
            this.Txt_CantidadRegistros.Name = "Txt_CantidadRegistros";
            this.Txt_CantidadRegistros.Size = new System.Drawing.Size(61, 20);
            this.Txt_CantidadRegistros.TabIndex = 2;
            this.Txt_CantidadRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de registros:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(814, 31);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(793, 4);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(15, 15);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DG_Datos);
            this.groupBox2.Location = new System.Drawing.Point(5, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 158);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // DG_Datos
            // 
            this.DG_Datos.AllowUserToAddRows = false;
            this.DG_Datos.AllowUserToDeleteRows = false;
            this.DG_Datos.AllowUserToOrderColumns = true;
            this.DG_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Datos.Location = new System.Drawing.Point(3, 16);
            this.DG_Datos.MultiSelect = false;
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Datos.Size = new System.Drawing.Size(814, 139);
            this.DG_Datos.TabIndex = 0;
            this.DG_Datos.Click += new System.EventHandler(this.DG_Datos_Click);
            this.DG_Datos.DoubleClick += new System.EventHandler(this.DG_Datos_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_Detener);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_NombreTercero);
            this.groupBox1.Controls.Add(this.Btn_BuscarTercero);
            this.groupBox1.Controls.Add(this.id_TerceroTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(139, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 128);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Btn_Detener
            // 
            this.Btn_Detener.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Detener.AutoSize = true;
            this.Btn_Detener.Location = new System.Drawing.Point(572, 40);
            this.Btn_Detener.Name = "Btn_Detener";
            this.Btn_Detener.Size = new System.Drawing.Size(106, 38);
            this.Btn_Detener.TabIndex = 64;
            this.Btn_Detener.Text = "Detener busqueda";
            this.Btn_Detener.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Detener.UseVisualStyleBackColor = true;
            this.Btn_Detener.Click += new System.EventHandler(this.Btn_Detener_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 166;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 165;
            this.label3.Text = "Paciente:";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Enabled = false;
            this.Txt_NombreTercero.Location = new System.Drawing.Point(151, 41);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(157, 20);
            this.Txt_NombreTercero.TabIndex = 164;
            // 
            // Btn_BuscarTercero
            // 
            this.Btn_BuscarTercero.AutoSize = true;
            this.Btn_BuscarTercero.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarTercero.Location = new System.Drawing.Point(119, 40);
            this.Btn_BuscarTercero.Name = "Btn_BuscarTercero";
            this.Btn_BuscarTercero.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarTercero.TabIndex = 163;
            this.Btn_BuscarTercero.UseVisualStyleBackColor = true;
            this.Btn_BuscarTercero.Click += new System.EventHandler(this.Btn_BuscarTercero_Click);
            // 
            // id_TerceroTextBox
            // 
            this.id_TerceroTextBox.Enabled = false;
            this.id_TerceroTextBox.Location = new System.Drawing.Point(70, 40);
            this.id_TerceroTextBox.Name = "id_TerceroTextBox";
            this.id_TerceroTextBox.Size = new System.Drawing.Size(43, 20);
            this.id_TerceroTextBox.TabIndex = 162;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(70, 14);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(73, 20);
            this.Txt_Id.TabIndex = 3;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Consultorio.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(598, 84);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(373, 355);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 59;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Editar.AutoSize = true;
            this.Btn_Editar.Image = global::Consultorio.Properties.Resources._1318513465_Edit;
            this.Btn_Editar.Location = new System.Drawing.Point(648, 355);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(80, 38);
            this.Btn_Editar.TabIndex = 58;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.AutoSize = true;
            this.Btn_Eliminar.Image = global::Consultorio.Properties.Resources._1318513481_Delete;
            this.Btn_Eliminar.Location = new System.Drawing.Point(557, 355);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 38);
            this.Btn_Eliminar.TabIndex = 57;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.AutoSize = true;
            this.Btn_Agregar.Image = global::Consultorio.Properties.Resources._1318513498_Add;
            this.Btn_Agregar.Location = new System.Drawing.Point(465, 355);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Agregar.TabIndex = 56;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(734, 355);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 55;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // ImgIcono
            // 
            this.ImgIcono.BackColor = System.Drawing.Color.Transparent;
            this.ImgIcono.Image = global::Consultorio.Properties.Resources.lista3;
            this.ImgIcono.Location = new System.Drawing.Point(5, 7);
            this.ImgIcono.Name = "ImgIcono";
            this.ImgIcono.Size = new System.Drawing.Size(128, 128);
            this.ImgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgIcono.TabIndex = 52;
            this.ImgIcono.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progreso,
            this.LblPorcentaje});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 62;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Progreso
            // 
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(200, 16);
            // 
            // LblPorcentaje
            // 
            this.LblPorcentaje.Name = "LblPorcentaje";
            this.LblPorcentaje.Size = new System.Drawing.Size(26, 17);
            this.LblPorcentaje.Text = "0 %";
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Consultorio.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(20, 355);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 180;
            this.Btn_Papel.Text = "Papel";
            this.Btn_Papel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Papel.UseVisualStyleBackColor = true;
            this.Btn_Papel.Visible = false;
            this.Btn_Papel.Click += new System.EventHandler(this.Btn_Papel_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Opciones.AutoSize = true;
            this.Btn_Opciones.Image = global::Consultorio.Properties.Resources._1318516999_document_print;
            this.Btn_Opciones.Location = new System.Drawing.Point(192, 355);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 181;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.ImprimirDocumento;
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.DocumentName = "Impresión de Remito";
            this.ImprimirDocumento.OriginAtMargins = true;
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.ImprimirDocumento;
            this.printDialog1.UseEXDialog = true;
            // 
            // Btn_Imprimir
            // 
            this.Btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Imprimir.AutoSize = true;
            this.Btn_Imprimir.Location = new System.Drawing.Point(293, 355);
            this.Btn_Imprimir.Name = "Btn_Imprimir";
            this.Btn_Imprimir.Size = new System.Drawing.Size(75, 38);
            this.Btn_Imprimir.TabIndex = 182;
            this.Btn_Imprimir.Text = "Imprimir";
            this.Btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Imprimir.UseVisualStyleBackColor = true;
            this.Btn_Imprimir.Click += new System.EventHandler(this.Btn_Imprimir_Click);
            // 
            // Btn_ImpHC
            // 
            this.Btn_ImpHC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ImpHC.AutoSize = true;
            this.Btn_ImpHC.Location = new System.Drawing.Point(106, 355);
            this.Btn_ImpHC.Name = "Btn_ImpHC";
            this.Btn_ImpHC.Size = new System.Drawing.Size(80, 38);
            this.Btn_ImpHC.TabIndex = 183;
            this.Btn_ImpHC.Text = "Imp HC";
            this.Btn_ImpHC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_ImpHC.UseVisualStyleBackColor = true;
            this.Btn_ImpHC.Click += new System.EventHandler(this.Btn_ImpHC_Click);
            // 
            // FrmConsultas
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(830, 418);
            this.Controls.Add(this.Btn_ImpHC);
            this.Controls.Add(this.Btn_Imprimir);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImgIcono);
            this.Name = "FrmConsultas";
            this.ShowIcon = false;
            this.Text = "Historial de consultas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConsultas_FormClosing);
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_CantidadRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.PictureBox ImgIcono;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarTercero;
        private System.Windows.Forms.TextBox id_TerceroTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar Progreso;
        private System.Windows.Forms.ToolStripStatusLabel LblPorcentaje;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Detener;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Btn_Imprimir;
        private System.Windows.Forms.Button Btn_ImpHC;
    }
}