namespace Consultorio.MDI
{
    partial class FrmResumenCuenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_SaldoTotal = new System.Windows.Forms.TextBox();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DT_Hasta = new System.Windows.Forms.DateTimePicker();
            this.DT_Desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTercero = new System.Windows.Forms.Button();
            this.id_TerceroTextBox = new System.Windows.Forms.TextBox();
            this.DG_Cuenta = new System.Windows.Forms.DataGridView();
            this.ClmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmNumeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDebito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Cuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Saldo:";
            // 
            // Txt_SaldoTotal
            // 
            this.Txt_SaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Txt_SaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoTotal.Location = new System.Drawing.Point(55, 414);
            this.Txt_SaldoTotal.Name = "Txt_SaldoTotal";
            this.Txt_SaldoTotal.Size = new System.Drawing.Size(172, 31);
            this.Txt_SaldoTotal.TabIndex = 43;
            this.Txt_SaldoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.AutoSize = true;
            this.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cerrar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cerrar.Location = new System.Drawing.Point(656, 409);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(80, 38);
            this.Btn_Cerrar.TabIndex = 42;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DT_Hasta);
            this.groupBox1.Controls.Add(this.DT_Desde);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_NombreTercero);
            this.groupBox1.Controls.Add(this.Btn_BuscarTercero);
            this.groupBox1.Controls.Add(this.id_TerceroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(724, 74);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Consultorio.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(636, 26);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "Desde:";
            // 
            // DT_Hasta
            // 
            this.DT_Hasta.Location = new System.Drawing.Point(382, 45);
            this.DT_Hasta.Name = "DT_Hasta";
            this.DT_Hasta.Size = new System.Drawing.Size(200, 20);
            this.DT_Hasta.TabIndex = 155;
            // 
            // DT_Desde
            // 
            this.DT_Desde.Location = new System.Drawing.Point(79, 45);
            this.DT_Desde.Name = "DT_Desde";
            this.DT_Desde.Size = new System.Drawing.Size(200, 20);
            this.DT_Desde.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 153;
            this.label1.Text = "Tercero:";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Enabled = false;
            this.Txt_NombreTercero.Location = new System.Drawing.Point(160, 20);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(189, 20);
            this.Txt_NombreTercero.TabIndex = 152;
            // 
            // Btn_BuscarTercero
            // 
            this.Btn_BuscarTercero.AutoSize = true;
            this.Btn_BuscarTercero.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarTercero.Location = new System.Drawing.Point(128, 19);
            this.Btn_BuscarTercero.Name = "Btn_BuscarTercero";
            this.Btn_BuscarTercero.Size = new System.Drawing.Size(26, 23);
            this.Btn_BuscarTercero.TabIndex = 151;
            this.Btn_BuscarTercero.UseVisualStyleBackColor = true;
            this.Btn_BuscarTercero.Click += new System.EventHandler(this.Btn_BuscarTercero_Click);
            // 
            // id_TerceroTextBox
            // 
            this.id_TerceroTextBox.Enabled = false;
            this.id_TerceroTextBox.Location = new System.Drawing.Point(79, 19);
            this.id_TerceroTextBox.Name = "id_TerceroTextBox";
            this.id_TerceroTextBox.Size = new System.Drawing.Size(43, 20);
            this.id_TerceroTextBox.TabIndex = 150;
            // 
            // DG_Cuenta
            // 
            this.DG_Cuenta.AllowUserToAddRows = false;
            this.DG_Cuenta.AllowUserToDeleteRows = false;
            this.DG_Cuenta.AllowUserToOrderColumns = true;
            this.DG_Cuenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Cuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmFecha,
            this.ClmReferencia,
            this.ClmNumeros,
            this.ClmDebito,
            this.ClmCredito,
            this.ClmSaldo});
            this.DG_Cuenta.Location = new System.Drawing.Point(12, 87);
            this.DG_Cuenta.MultiSelect = false;
            this.DG_Cuenta.Name = "DG_Cuenta";
            this.DG_Cuenta.ReadOnly = true;
            this.DG_Cuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Cuenta.Size = new System.Drawing.Size(724, 316);
            this.DG_Cuenta.TabIndex = 40;
            // 
            // ClmFecha
            // 
            this.ClmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmFecha.HeaderText = "Fecha";
            this.ClmFecha.Name = "ClmFecha";
            this.ClmFecha.ReadOnly = true;
            this.ClmFecha.Width = 62;
            // 
            // ClmReferencia
            // 
            this.ClmReferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmReferencia.HeaderText = "Referencia";
            this.ClmReferencia.Name = "ClmReferencia";
            this.ClmReferencia.ReadOnly = true;
            this.ClmReferencia.Width = 84;
            // 
            // ClmNumeros
            // 
            this.ClmNumeros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClmNumeros.HeaderText = "Números";
            this.ClmNumeros.Name = "ClmNumeros";
            this.ClmNumeros.ReadOnly = true;
            this.ClmNumeros.Width = 74;
            // 
            // ClmDebito
            // 
            this.ClmDebito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClmDebito.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClmDebito.HeaderText = "Débito";
            this.ClmDebito.Name = "ClmDebito";
            this.ClmDebito.ReadOnly = true;
            this.ClmDebito.Width = 63;
            // 
            // ClmCredito
            // 
            this.ClmCredito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClmCredito.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClmCredito.HeaderText = "Crédito";
            this.ClmCredito.Name = "ClmCredito";
            this.ClmCredito.ReadOnly = true;
            this.ClmCredito.Width = 65;
            // 
            // ClmSaldo
            // 
            this.ClmSaldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ClmSaldo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClmSaldo.HeaderText = "Saldo";
            this.ClmSaldo.Name = "ClmSaldo";
            this.ClmSaldo.ReadOnly = true;
            this.ClmSaldo.Width = 59;
            // 
            // ProvError
            // 
            this.ProvError.ContainerControl = this;
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(477, 409);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 184;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Consultorio.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(233, 410);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 182;
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
            this.Btn_Opciones.Location = new System.Drawing.Point(376, 409);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 183;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(564, 409);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 181;
            this.Btn_Aceptar.Text = "Imprimir";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.MyPrintDocument;
            this.printDialog1.UseEXDialog = true;
            // 
            // MyPrintDocument
            // 
            this.MyPrintDocument.DocumentName = "Entrega de documentación";
            this.MyPrintDocument.OriginAtMargins = true;
            this.MyPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.MyPrintDocument;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rectangleShape1.BackColor = System.Drawing.Color.SkyBlue;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.Location = new System.Drawing.Point(359, 424);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(10, 10);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(748, 450);
            this.shapeContainer1.TabIndex = 185;
            this.shapeContainer1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 186;
            this.label5.Text = "Sin Facturar";
            // 
            // FrmResumenCuenta
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_SaldoTotal);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_Cuenta);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmResumenCuenta";
            this.ShowIcon = false;
            this.Text = "Resumen de cuenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Cuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_SaldoTotal;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DT_Hasta;
        private System.Windows.Forms.DateTimePicker DT_Desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarTercero;
        private System.Windows.Forms.TextBox id_TerceroTextBox;
        private System.Windows.Forms.DataGridView DG_Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmReferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNumeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDebito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSaldo;
        private System.Windows.Forms.ErrorProvider ProvError;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label5;
    }
}