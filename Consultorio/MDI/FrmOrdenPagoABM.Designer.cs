namespace Consultorio.MDI
{
    partial class FrmOrdenPagoABM
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label total_FacturaLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label numero_Comprobante_FacturaLabel;
            System.Windows.Forms.Label clase_FacturaLabel;
            System.Windows.Forms.Label id_TerceroLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenPagoABM));
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Total = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NUD_TotalAsignado = new System.Windows.Forms.NumericUpDown();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.numero_Comprobante_FacturaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.puesto_FacturaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NombreTercero = new System.Windows.Forms.TextBox();
            this.Btn_BuscarTercero = new System.Windows.Forms.Button();
            this.id_TerceroTextBox = new System.Windows.Forms.TextBox();
            this.DG_Facturas = new System.Windows.Forms.DataGridView();
            this.Clm_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_FechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Importe1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_QuitarFactura = new System.Windows.Forms.Button();
            this.Btn_AgregarFactura = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DG_Efectivo = new System.Windows.Forms.DataGridView();
            this.Clm_Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DG_ChequeTercero = new System.Windows.Forms.DataGridView();
            this.Clm_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_FechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Importe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clm_Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_QuitarChequeTercero = new System.Windows.Forms.Button();
            this.Btn_AgregarChequeTercero = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.VistaPrevia = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ProvError = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Chk_ImprimirComprobante = new System.Windows.Forms.CheckBox();
            label2 = new System.Windows.Forms.Label();
            total_FacturaLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            numero_Comprobante_FacturaLabel = new System.Windows.Forms.Label();
            clase_FacturaLabel = new System.Windows.Forms.Label();
            id_TerceroLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TotalAsignado)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Facturas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Efectivo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ChequeTercero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 358);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 171;
            label2.Text = "Total:";
            // 
            // total_FacturaLabel
            // 
            total_FacturaLabel.AutoSize = true;
            total_FacturaLabel.Location = new System.Drawing.Point(9, 323);
            total_FacturaLabel.Name = "total_FacturaLabel";
            total_FacturaLabel.Size = new System.Drawing.Size(69, 13);
            total_FacturaLabel.TabIndex = 168;
            total_FacturaLabel.Text = "Total cuotas:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(457, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(14, 13);
            label3.TabIndex = 159;
            label3.Text = "X";
            // 
            // numero_Comprobante_FacturaLabel
            // 
            numero_Comprobante_FacturaLabel.AutoSize = true;
            numero_Comprobante_FacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numero_Comprobante_FacturaLabel.Location = new System.Drawing.Point(371, 11);
            numero_Comprobante_FacturaLabel.Name = "numero_Comprobante_FacturaLabel";
            numero_Comprobante_FacturaLabel.Size = new System.Drawing.Size(80, 13);
            numero_Comprobante_FacturaLabel.TabIndex = 156;
            numero_Comprobante_FacturaLabel.Text = "Número Comp.:";
            // 
            // clase_FacturaLabel
            // 
            clase_FacturaLabel.AutoSize = true;
            clase_FacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            clase_FacturaLabel.Location = new System.Drawing.Point(508, 12);
            clase_FacturaLabel.Name = "clase_FacturaLabel";
            clase_FacturaLabel.Size = new System.Drawing.Size(10, 13);
            clase_FacturaLabel.TabIndex = 155;
            clase_FacturaLabel.Text = "-";
            // 
            // id_TerceroLabel
            // 
            id_TerceroLabel.AutoSize = true;
            id_TerceroLabel.Location = new System.Drawing.Point(6, 9);
            id_TerceroLabel.Name = "id_TerceroLabel";
            id_TerceroLabel.Size = new System.Drawing.Size(47, 13);
            id_TerceroLabel.TabIndex = 151;
            id_TerceroLabel.Text = "Tercero:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 173;
            this.label1.Text = "$";
            // 
            // NUD_Total
            // 
            this.NUD_Total.DecimalPlaces = 4;
            this.NUD_Total.Enabled = false;
            this.NUD_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Total.Location = new System.Drawing.Point(100, 345);
            this.NUD_Total.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NUD_Total.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.NUD_Total.Name = "NUD_Total";
            this.NUD_Total.Size = new System.Drawing.Size(132, 29);
            this.NUD_Total.TabIndex = 172;
            this.NUD_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 170;
            this.label5.Text = "$";
            // 
            // NUD_TotalAsignado
            // 
            this.NUD_TotalAsignado.DecimalPlaces = 4;
            this.NUD_TotalAsignado.Enabled = false;
            this.NUD_TotalAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_TotalAsignado.Location = new System.Drawing.Point(100, 310);
            this.NUD_TotalAsignado.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.NUD_TotalAsignado.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.NUD_TotalAsignado.Name = "NUD_TotalAsignado";
            this.NUD_TotalAsignado.Size = new System.Drawing.Size(132, 29);
            this.NUD_TotalAsignado.TabIndex = 169;
            this.NUD_TotalAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUD_TotalAsignado.ValueChanged += new System.EventHandler(this.NUD_TotalAsignado_ValueChanged);
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(521, 336);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(126, 38);
            this.Btn_Aceptar.TabIndex = 167;
            this.Btn_Aceptar.Text = "Aceptar/Imprimir";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(653, 336);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 166;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(732, 292);
            this.tabControl1.TabIndex = 165;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.Txt_Id);
            this.tabPage7.Controls.Add(label3);
            this.tabPage7.Controls.Add(this.numero_Comprobante_FacturaTextBox);
            this.tabPage7.Controls.Add(this.puesto_FacturaTextBox);
            this.tabPage7.Controls.Add(numero_Comprobante_FacturaLabel);
            this.tabPage7.Controls.Add(clase_FacturaLabel);
            this.tabPage7.Controls.Add(this.Txt_NombreTercero);
            this.tabPage7.Controls.Add(this.Btn_BuscarTercero);
            this.tabPage7.Controls.Add(this.id_TerceroTextBox);
            this.tabPage7.Controls.Add(id_TerceroLabel);
            this.tabPage7.Controls.Add(this.DG_Facturas);
            this.tabPage7.Controls.Add(this.Btn_QuitarFactura);
            this.tabPage7.Controls.Add(this.Btn_AgregarFactura);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(724, 266);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Tercero/Facturas";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(620, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 166;
            this.label7.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(645, 9);
            this.Txt_Id.MaxLength = 6;
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(73, 20);
            this.Txt_Id.TabIndex = 165;
            this.Txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numero_Comprobante_FacturaTextBox
            // 
            this.numero_Comprobante_FacturaTextBox.Enabled = false;
            this.numero_Comprobante_FacturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_Comprobante_FacturaTextBox.Location = new System.Drawing.Point(519, 8);
            this.numero_Comprobante_FacturaTextBox.Mask = "00000000";
            this.numero_Comprobante_FacturaTextBox.Name = "numero_Comprobante_FacturaTextBox";
            this.numero_Comprobante_FacturaTextBox.Size = new System.Drawing.Size(56, 20);
            this.numero_Comprobante_FacturaTextBox.TabIndex = 158;
            // 
            // puesto_FacturaTextBox
            // 
            this.puesto_FacturaTextBox.Enabled = false;
            this.puesto_FacturaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puesto_FacturaTextBox.Location = new System.Drawing.Point(473, 8);
            this.puesto_FacturaTextBox.Mask = "0000";
            this.puesto_FacturaTextBox.Name = "puesto_FacturaTextBox";
            this.puesto_FacturaTextBox.Size = new System.Drawing.Size(32, 20);
            this.puesto_FacturaTextBox.TabIndex = 157;
            this.puesto_FacturaTextBox.Text = "0001";
            // 
            // Txt_NombreTercero
            // 
            this.Txt_NombreTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreTercero.Location = new System.Drawing.Point(137, 7);
            this.Txt_NombreTercero.Name = "Txt_NombreTercero";
            this.Txt_NombreTercero.Size = new System.Drawing.Size(189, 22);
            this.Txt_NombreTercero.TabIndex = 154;
            this.Txt_NombreTercero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreTercero_KeyPress);
            // 
            // Btn_BuscarTercero
            // 
            this.Btn_BuscarTercero.AutoSize = true;
            this.Btn_BuscarTercero.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarTercero.Location = new System.Drawing.Point(105, 6);
            this.Btn_BuscarTercero.Name = "Btn_BuscarTercero";
            this.Btn_BuscarTercero.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarTercero.TabIndex = 153;
            this.Btn_BuscarTercero.UseVisualStyleBackColor = true;
            this.Btn_BuscarTercero.Click += new System.EventHandler(this.Btn_BuscarTercero_Click);
            // 
            // id_TerceroTextBox
            // 
            this.id_TerceroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_TerceroTextBox.Location = new System.Drawing.Point(56, 6);
            this.id_TerceroTextBox.Name = "id_TerceroTextBox";
            this.id_TerceroTextBox.Size = new System.Drawing.Size(43, 22);
            this.id_TerceroTextBox.TabIndex = 152;
            this.id_TerceroTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NombreTercero_KeyPress);
            // 
            // DG_Facturas
            // 
            this.DG_Facturas.AllowUserToAddRows = false;
            this.DG_Facturas.AllowUserToOrderColumns = true;
            this.DG_Facturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Facturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Detalle,
            this.Clm_Remito,
            this.Clm_Numero,
            this.Clm_FechaDeVencimiento,
            this.Clm_Importe1,
            this.Clm_Interes,
            this.Clm_Observaciones});
            this.DG_Facturas.Location = new System.Drawing.Point(4, 33);
            this.DG_Facturas.MultiSelect = false;
            this.DG_Facturas.Name = "DG_Facturas";
            this.DG_Facturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Facturas.Size = new System.Drawing.Size(714, 187);
            this.DG_Facturas.TabIndex = 90;
            this.DG_Facturas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Facturas_CellEndEdit);
            // 
            // Clm_Detalle
            // 
            this.Clm_Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Detalle.HeaderText = "Det";
            this.Clm_Detalle.Name = "Clm_Detalle";
            this.Clm_Detalle.Width = 49;
            // 
            // Clm_Remito
            // 
            this.Clm_Remito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Remito.HeaderText = "Remito";
            this.Clm_Remito.Name = "Clm_Remito";
            this.Clm_Remito.Width = 65;
            // 
            // Clm_Numero
            // 
            this.Clm_Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Numero.HeaderText = "Número de Cuota";
            this.Clm_Numero.Name = "Clm_Numero";
            this.Clm_Numero.Width = 80;
            // 
            // Clm_FechaDeVencimiento
            // 
            this.Clm_FechaDeVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_FechaDeVencimiento.HeaderText = "Fecha de vencimiento";
            this.Clm_FechaDeVencimiento.Name = "Clm_FechaDeVencimiento";
            this.Clm_FechaDeVencimiento.Width = 125;
            // 
            // Clm_Importe1
            // 
            this.Clm_Importe1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Importe1.HeaderText = "Importe";
            this.Clm_Importe1.Name = "Clm_Importe1";
            this.Clm_Importe1.Width = 67;
            // 
            // Clm_Interes
            // 
            this.Clm_Interes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Interes.HeaderText = "Interes/Recargos";
            this.Clm_Interes.Name = "Clm_Interes";
            this.Clm_Interes.Width = 115;
            // 
            // Clm_Observaciones
            // 
            this.Clm_Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Clm_Observaciones.HeaderText = "Observaciones";
            this.Clm_Observaciones.Name = "Clm_Observaciones";
            this.Clm_Observaciones.Width = 103;
            // 
            // Btn_QuitarFactura
            // 
            this.Btn_QuitarFactura.AutoSize = true;
            this.Btn_QuitarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_QuitarFactura.Image = global::Consultorio.Properties.Resources._1318513481_Delete;
            this.Btn_QuitarFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_QuitarFactura.Location = new System.Drawing.Point(636, 225);
            this.Btn_QuitarFactura.Name = "Btn_QuitarFactura";
            this.Btn_QuitarFactura.Size = new System.Drawing.Size(38, 38);
            this.Btn_QuitarFactura.TabIndex = 89;
            this.Btn_QuitarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_QuitarFactura.UseVisualStyleBackColor = true;
            this.Btn_QuitarFactura.Click += new System.EventHandler(this.Btn_QuitarFactura_Click);
            // 
            // Btn_AgregarFactura
            // 
            this.Btn_AgregarFactura.AutoSize = true;
            this.Btn_AgregarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarFactura.Image = global::Consultorio.Properties.Resources._1318513498_Add;
            this.Btn_AgregarFactura.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_AgregarFactura.Location = new System.Drawing.Point(680, 225);
            this.Btn_AgregarFactura.Name = "Btn_AgregarFactura";
            this.Btn_AgregarFactura.Size = new System.Drawing.Size(38, 38);
            this.Btn_AgregarFactura.TabIndex = 88;
            this.Btn_AgregarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AgregarFactura.UseVisualStyleBackColor = true;
            this.Btn_AgregarFactura.Click += new System.EventHandler(this.Btn_AgregarFactura_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DG_Efectivo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(724, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Efectivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DG_Efectivo
            // 
            this.DG_Efectivo.AllowUserToOrderColumns = true;
            this.DG_Efectivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Efectivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Importe});
            this.DG_Efectivo.Location = new System.Drawing.Point(3, 6);
            this.DG_Efectivo.MultiSelect = false;
            this.DG_Efectivo.Name = "DG_Efectivo";
            this.DG_Efectivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Efectivo.Size = new System.Drawing.Size(715, 254);
            this.DG_Efectivo.TabIndex = 87;
            this.DG_Efectivo.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Facturas_CellEndEdit);
            // 
            // Clm_Importe
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Clm_Importe.DefaultCellStyle = dataGridViewCellStyle1;
            this.Clm_Importe.HeaderText = "Importe";
            this.Clm_Importe.Name = "Clm_Importe";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DG_ChequeTercero);
            this.tabPage2.Controls.Add(this.Btn_QuitarChequeTercero);
            this.tabPage2.Controls.Add(this.Btn_AgregarChequeTercero);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(724, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cheque tercero";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DG_ChequeTercero
            // 
            this.DG_ChequeTercero.AllowUserToAddRows = false;
            this.DG_ChequeTercero.AllowUserToOrderColumns = true;
            this.DG_ChequeTercero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ChequeTercero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clm_Codigo,
            this.Clm_Ciudad,
            this.Clm_Nombre,
            this.Clm_FechaVencimiento,
            this.Clm_Importe2,
            this.Clm_Nombre2});
            this.DG_ChequeTercero.Location = new System.Drawing.Point(4, 6);
            this.DG_ChequeTercero.MultiSelect = false;
            this.DG_ChequeTercero.Name = "DG_ChequeTercero";
            this.DG_ChequeTercero.ReadOnly = true;
            this.DG_ChequeTercero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_ChequeTercero.Size = new System.Drawing.Size(714, 214);
            this.DG_ChequeTercero.TabIndex = 90;
            this.DG_ChequeTercero.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Facturas_CellEndEdit);
            // 
            // Clm_Codigo
            // 
            this.Clm_Codigo.HeaderText = "Código";
            this.Clm_Codigo.Name = "Clm_Codigo";
            this.Clm_Codigo.ReadOnly = true;
            // 
            // Clm_Ciudad
            // 
            this.Clm_Ciudad.HeaderText = "Ciudad";
            this.Clm_Ciudad.Name = "Clm_Ciudad";
            this.Clm_Ciudad.ReadOnly = true;
            // 
            // Clm_Nombre
            // 
            this.Clm_Nombre.HeaderText = "Banco";
            this.Clm_Nombre.Name = "Clm_Nombre";
            this.Clm_Nombre.ReadOnly = true;
            // 
            // Clm_FechaVencimiento
            // 
            this.Clm_FechaVencimiento.HeaderText = "Fecha vencimiento";
            this.Clm_FechaVencimiento.Name = "Clm_FechaVencimiento";
            this.Clm_FechaVencimiento.ReadOnly = true;
            // 
            // Clm_Importe2
            // 
            this.Clm_Importe2.HeaderText = "Importe";
            this.Clm_Importe2.Name = "Clm_Importe2";
            this.Clm_Importe2.ReadOnly = true;
            // 
            // Clm_Nombre2
            // 
            this.Clm_Nombre2.HeaderText = "Nombre";
            this.Clm_Nombre2.Name = "Clm_Nombre2";
            this.Clm_Nombre2.ReadOnly = true;
            // 
            // Btn_QuitarChequeTercero
            // 
            this.Btn_QuitarChequeTercero.AutoSize = true;
            this.Btn_QuitarChequeTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_QuitarChequeTercero.Image = global::Consultorio.Properties.Resources._1318513481_Delete;
            this.Btn_QuitarChequeTercero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_QuitarChequeTercero.Location = new System.Drawing.Point(636, 222);
            this.Btn_QuitarChequeTercero.Name = "Btn_QuitarChequeTercero";
            this.Btn_QuitarChequeTercero.Size = new System.Drawing.Size(38, 38);
            this.Btn_QuitarChequeTercero.TabIndex = 89;
            this.Btn_QuitarChequeTercero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_QuitarChequeTercero.UseVisualStyleBackColor = true;
            this.Btn_QuitarChequeTercero.Click += new System.EventHandler(this.Btn_QuitarChequeTercero_Click);
            // 
            // Btn_AgregarChequeTercero
            // 
            this.Btn_AgregarChequeTercero.AutoSize = true;
            this.Btn_AgregarChequeTercero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarChequeTercero.Image = global::Consultorio.Properties.Resources._1318513498_Add;
            this.Btn_AgregarChequeTercero.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Btn_AgregarChequeTercero.Location = new System.Drawing.Point(680, 222);
            this.Btn_AgregarChequeTercero.Name = "Btn_AgregarChequeTercero";
            this.Btn_AgregarChequeTercero.Size = new System.Drawing.Size(38, 38);
            this.Btn_AgregarChequeTercero.TabIndex = 88;
            this.Btn_AgregarChequeTercero.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AgregarChequeTercero.UseVisualStyleBackColor = true;
            this.Btn_AgregarChequeTercero.Click += new System.EventHandler(this.Btn_AgregarChequeTercero_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Consultorio.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(247, 336);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 174;
            this.Btn_Papel.Text = "Papel";
            this.Btn_Papel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Papel.UseVisualStyleBackColor = true;
            this.Btn_Papel.Visible = false;
            this.Btn_Papel.Click += new System.EventHandler(this.Btn_Papel_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.AutoSize = true;
            this.Btn_Opciones.Image = global::Consultorio.Properties.Resources._1318516999_document_print;
            this.Btn_Opciones.Location = new System.Drawing.Point(420, 336);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 175;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.ImprimirDocumento;
            this.printDialog1.UseEXDialog = true;
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.DocumentName = "Recibo a Cliente";
            this.ImprimirDocumento.OriginAtMargins = true;
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.VistaPrevia.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.VistaPrevia.ClientSize = new System.Drawing.Size(400, 300);
            this.VistaPrevia.Document = this.ImprimirDocumento;
            this.VistaPrevia.Enabled = true;
            this.VistaPrevia.Icon = ((System.Drawing.Icon)(resources.GetObject("VistaPrevia.Icon")));
            this.VistaPrevia.Name = "VistaPrevia";
            this.VistaPrevia.UseAntiAlias = true;
            this.VistaPrevia.Visible = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.ImprimirDocumento;
            // 
            // ProvError
            // 
            this.ProvError.ContainerControl = this;
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(333, 336);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 176;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Chk_ImprimirComprobante
            // 
            this.Chk_ImprimirComprobante.AutoSize = true;
            this.Chk_ImprimirComprobante.Checked = true;
            this.Chk_ImprimirComprobante.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk_ImprimirComprobante.Location = new System.Drawing.Point(247, 310);
            this.Chk_ImprimirComprobante.Name = "Chk_ImprimirComprobante";
            this.Chk_ImprimirComprobante.Size = new System.Drawing.Size(126, 17);
            this.Chk_ImprimirComprobante.TabIndex = 177;
            this.Chk_ImprimirComprobante.Text = "Imprimir comprobante";
            this.Chk_ImprimirComprobante.UseVisualStyleBackColor = true;
            // 
            // FrmOrdenPagoABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(747, 380);
            this.Controls.Add(this.Chk_ImprimirComprobante);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NUD_Total);
            this.Controls.Add(label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NUD_TotalAsignado);
            this.Controls.Add(total_FacturaLabel);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(763, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(763, 418);
            this.Name = "FrmOrdenPagoABM";
            this.ShowIcon = false;
            this.Text = "Recibo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrdenPago_FormClosing);
            this.Load += new System.EventHandler(this.FrmOrdenPagoABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_TotalAsignado)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Facturas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Efectivo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ChequeTercero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NUD_TotalAsignado;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.MaskedTextBox numero_Comprobante_FacturaTextBox;
        private System.Windows.Forms.MaskedTextBox puesto_FacturaTextBox;
        private System.Windows.Forms.TextBox Txt_NombreTercero;
        private System.Windows.Forms.Button Btn_BuscarTercero;
        private System.Windows.Forms.TextBox id_TerceroTextBox;
        private System.Windows.Forms.DataGridView DG_Facturas;
        private System.Windows.Forms.Button Btn_QuitarFactura;
        private System.Windows.Forms.Button Btn_AgregarFactura;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DG_Efectivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Importe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DG_ChequeTercero;
        private System.Windows.Forms.Button Btn_QuitarChequeTercero;
        private System.Windows.Forms.Button Btn_AgregarChequeTercero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_FechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Importe2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Nombre2;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog VistaPrevia;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ErrorProvider ProvError;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.CheckBox Chk_ImprimirComprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Remito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_FechaDeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Importe1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clm_Observaciones;
    }
}