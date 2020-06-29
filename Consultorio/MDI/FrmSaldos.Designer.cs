namespace Consultorio.MDI
{
    partial class FrmSaldos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Chk_SaldoEn0 = new System.Windows.Forms.CheckBox();
            this.Chk_Acreedores = new System.Windows.Forms.CheckBox();
            this.Chk_Deudores = new System.Windows.Forms.CheckBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.DG_Saldo = new System.Windows.Forms.DataGridView();
            this.ClmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmTelefonos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.MyPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Saldo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Chk_SaldoEn0);
            this.groupBox1.Controls.Add(this.Chk_Acreedores);
            this.groupBox1.Controls.Add(this.Chk_Deudores);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 74);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Chk_SaldoEn0
            // 
            this.Chk_SaldoEn0.AutoSize = true;
            this.Chk_SaldoEn0.Location = new System.Drawing.Point(106, 19);
            this.Chk_SaldoEn0.Name = "Chk_SaldoEn0";
            this.Chk_SaldoEn0.Size = new System.Drawing.Size(82, 17);
            this.Chk_SaldoEn0.TabIndex = 6;
            this.Chk_SaldoEn0.Text = "Saldos en 0";
            this.Chk_SaldoEn0.UseVisualStyleBackColor = true;
            // 
            // Chk_Acreedores
            // 
            this.Chk_Acreedores.AutoSize = true;
            this.Chk_Acreedores.Checked = true;
            this.Chk_Acreedores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Acreedores.Location = new System.Drawing.Point(6, 47);
            this.Chk_Acreedores.Name = "Chk_Acreedores";
            this.Chk_Acreedores.Size = new System.Drawing.Size(80, 17);
            this.Chk_Acreedores.TabIndex = 5;
            this.Chk_Acreedores.Text = "Acreedores";
            this.Chk_Acreedores.UseVisualStyleBackColor = true;
            // 
            // Chk_Deudores
            // 
            this.Chk_Deudores.AutoSize = true;
            this.Chk_Deudores.Checked = true;
            this.Chk_Deudores.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_Deudores.Location = new System.Drawing.Point(6, 19);
            this.Chk_Deudores.Name = "Chk_Deudores";
            this.Chk_Deudores.Size = new System.Drawing.Size(72, 17);
            this.Chk_Deudores.TabIndex = 4;
            this.Chk_Deudores.Text = "Deudores";
            this.Chk_Deudores.UseVisualStyleBackColor = true;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Consultorio.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(621, 26);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // DG_Saldo
            // 
            this.DG_Saldo.AllowUserToAddRows = false;
            this.DG_Saldo.AllowUserToDeleteRows = false;
            this.DG_Saldo.AllowUserToOrderColumns = true;
            this.DG_Saldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DG_Saldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Saldo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmNombre,
            this.ClmDireccion,
            this.ClmTelefonos,
            this.ClmSaldo});
            this.DG_Saldo.Location = new System.Drawing.Point(12, 92);
            this.DG_Saldo.MultiSelect = false;
            this.DG_Saldo.Name = "DG_Saldo";
            this.DG_Saldo.ReadOnly = true;
            this.DG_Saldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Saldo.Size = new System.Drawing.Size(709, 336);
            this.DG_Saldo.TabIndex = 4;
            // 
            // ClmNombre
            // 
            this.ClmNombre.HeaderText = "Nombre";
            this.ClmNombre.Name = "ClmNombre";
            this.ClmNombre.ReadOnly = true;
            // 
            // ClmDireccion
            // 
            this.ClmDireccion.HeaderText = "Dirección";
            this.ClmDireccion.Name = "ClmDireccion";
            this.ClmDireccion.ReadOnly = true;
            // 
            // ClmTelefonos
            // 
            this.ClmTelefonos.HeaderText = "Teléfonos";
            this.ClmTelefonos.Name = "ClmTelefonos";
            this.ClmTelefonos.ReadOnly = true;
            // 
            // ClmSaldo
            // 
            this.ClmSaldo.HeaderText = "Saldo";
            this.ClmSaldo.Name = "ClmSaldo";
            this.ClmSaldo.ReadOnly = true;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.AutoSize = true;
            this.Btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cerrar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cerrar.Location = new System.Drawing.Point(639, 434);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Cerrar.TabIndex = 6;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total: $ 0,00";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 37);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(460, 434);
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
            this.Btn_Papel.Location = new System.Drawing.Point(331, 444);
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
            this.Btn_Opciones.Location = new System.Drawing.Point(359, 434);
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(547, 434);
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
            // FrmSaldos
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DG_Saldo);
            this.Name = "FrmSaldos";
            this.ShowIcon = false;
            this.Text = "Saldos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSaldos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Saldo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Chk_SaldoEn0;
        private System.Windows.Forms.CheckBox Chk_Acreedores;
        private System.Windows.Forms.CheckBox Chk_Deudores;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.DataGridView DG_Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmSaldo;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument MyPrintDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}