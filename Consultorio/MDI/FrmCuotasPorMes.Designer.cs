namespace Consultorio.MDI
{
    partial class FrmCuotasPorMes
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
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTercero = new System.Windows.Forms.Button();
            this.id_TerceroTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DT_Hasta = new System.Windows.Forms.DateTimePicker();
            this.DT_Desde = new System.Windows.Forms.DateTimePicker();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_CreditoTotal = new System.Windows.Forms.TextBox();
            this.Txt_CantidadRegistros = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Datos
            // 
            this.DG_Datos.AllowUserToAddRows = false;
            this.DG_Datos.AllowUserToDeleteRows = false;
            this.DG_Datos.AllowUserToOrderColumns = true;
            this.DG_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Location = new System.Drawing.Point(12, 85);
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.Size = new System.Drawing.Size(759, 226);
            this.DG_Datos.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_NombreTercero);
            this.groupBox1.Controls.Add(this.Btn_BuscarTercero);
            this.groupBox1.Controls.Add(this.id_TerceroTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DT_Hasta);
            this.groupBox1.Controls.Add(this.DT_Desde);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 67);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 14);
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
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 165;
            this.label3.Text = "Tercero:";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Enabled = false;
            this.Txt_NombreTercero.Location = new System.Drawing.Point(153, 14);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(189, 20);
            this.Txt_NombreTercero.TabIndex = 164;
            // 
            // Btn_BuscarTercero
            // 
            this.Btn_BuscarTercero.AutoSize = true;
            this.Btn_BuscarTercero.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarTercero.Location = new System.Drawing.Point(121, 13);
            this.Btn_BuscarTercero.Name = "Btn_BuscarTercero";
            this.Btn_BuscarTercero.Size = new System.Drawing.Size(26, 23);
            this.Btn_BuscarTercero.TabIndex = 163;
            this.Btn_BuscarTercero.UseVisualStyleBackColor = true;
            this.Btn_BuscarTercero.Click += new System.EventHandler(this.Btn_BuscarTercero_Click);
            // 
            // id_TerceroTextBox
            // 
            this.id_TerceroTextBox.Enabled = false;
            this.id_TerceroTextBox.Location = new System.Drawing.Point(72, 13);
            this.id_TerceroTextBox.Name = "id_TerceroTextBox";
            this.id_TerceroTextBox.Size = new System.Drawing.Size(43, 20);
            this.id_TerceroTextBox.TabIndex = 162;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 161;
            this.label6.Text = "Hasta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 160;
            this.label7.Text = "Desde:";
            // 
            // DT_Hasta
            // 
            this.DT_Hasta.Location = new System.Drawing.Point(338, 38);
            this.DT_Hasta.Name = "DT_Hasta";
            this.DT_Hasta.Size = new System.Drawing.Size(200, 20);
            this.DT_Hasta.TabIndex = 159;
            // 
            // DT_Desde
            // 
            this.DT_Desde.Location = new System.Drawing.Point(72, 39);
            this.DT_Desde.Name = "DT_Desde";
            this.DT_Desde.Size = new System.Drawing.Size(200, 20);
            this.DT_Desde.TabIndex = 158;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Consultorio.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(673, 26);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Txt_CreditoTotal);
            this.groupBox2.Controls.Add(this.Txt_CantidadRegistros);
            this.groupBox2.Location = new System.Drawing.Point(12, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(759, 43);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Totales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Importe Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Deudores:";
            // 
            // Txt_CreditoTotal
            // 
            this.Txt_CreditoTotal.Enabled = false;
            this.Txt_CreditoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreditoTotal.Location = new System.Drawing.Point(354, 15);
            this.Txt_CreditoTotal.Name = "Txt_CreditoTotal";
            this.Txt_CreditoTotal.Size = new System.Drawing.Size(87, 22);
            this.Txt_CreditoTotal.TabIndex = 1;
            // 
            // Txt_CantidadRegistros
            // 
            this.Txt_CantidadRegistros.Enabled = false;
            this.Txt_CantidadRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CantidadRegistros.Location = new System.Drawing.Point(68, 15);
            this.Txt_CantidadRegistros.Name = "Txt_CantidadRegistros";
            this.Txt_CantidadRegistros.Size = new System.Drawing.Size(87, 22);
            this.Txt_CantidadRegistros.TabIndex = 0;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(588, 366);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 39;
            this.Btn_Aceptar.Text = "Imprimir";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(501, 366);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 180;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Consultorio.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(314, 366);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 178;
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
            this.Btn_Opciones.Location = new System.Drawing.Point(400, 366);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 179;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(680, 366);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 181;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.MyPrintDocument;
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.DocumentName = "Entrega de documentación";
            this.MyPrintDocument.OriginAtMargins = true;
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.MyPrintDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmCuotasPorMes
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Aceptar;
            this.ClientSize = new System.Drawing.Size(783, 413);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_Datos);
            this.Name = "FrmCuotasPorMes";
            this.ShowIcon = false;
            this.Text = "Deudores de este mes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCuotasPorMes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DT_Hasta;
        private System.Windows.Forms.DateTimePicker DT_Desde;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_CreditoTotal;
        private System.Windows.Forms.TextBox Txt_CantidadRegistros;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarTercero;
        private System.Windows.Forms.TextBox id_TerceroTextBox;
        private System.Windows.Forms.Button button1;

    }
}