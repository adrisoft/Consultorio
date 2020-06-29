namespace Consultorio.MDI
{
    partial class FrmContarCaja
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
            this.TotalInicial = new System.Windows.Forms.NumericUpDown();
            this.B100 = new System.Windows.Forms.NumericUpDown();
            this.B50 = new System.Windows.Forms.NumericUpDown();
            this.B20 = new System.Windows.Forms.NumericUpDown();
            this.B10 = new System.Windows.Forms.NumericUpDown();
            this.B5 = new System.Windows.Forms.NumericUpDown();
            this.B2 = new System.Windows.Forms.NumericUpDown();
            this.M2 = new System.Windows.Forms.NumericUpDown();
            this.M1 = new System.Windows.Forms.NumericUpDown();
            this.M050 = new System.Windows.Forms.NumericUpDown();
            this.M025 = new System.Windows.Forms.NumericUpDown();
            this.M010 = new System.Windows.Forms.NumericUpDown();
            this.M005 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DineroCaja = new System.Windows.Forms.NumericUpDown();
            this.Resultado = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_VueltoIdeal = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.Vuelto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TotalInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M050)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M025)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M010)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M005)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DineroCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vuelto)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalInicial
            // 
            this.TotalInicial.DecimalPlaces = 4;
            this.TotalInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInicial.Location = new System.Drawing.Point(176, 29);
            this.TotalInicial.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.TotalInicial.Name = "TotalInicial";
            this.TotalInicial.Size = new System.Drawing.Size(198, 31);
            this.TotalInicial.TabIndex = 0;
            this.TotalInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalInicial.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B100
            // 
            this.B100.Location = new System.Drawing.Point(100, 14);
            this.B100.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B100.Name = "B100";
            this.B100.Size = new System.Drawing.Size(113, 20);
            this.B100.TabIndex = 1;
            this.B100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B100.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B50
            // 
            this.B50.Location = new System.Drawing.Point(100, 40);
            this.B50.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B50.Name = "B50";
            this.B50.Size = new System.Drawing.Size(113, 20);
            this.B50.TabIndex = 2;
            this.B50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B50.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B20
            // 
            this.B20.Location = new System.Drawing.Point(100, 66);
            this.B20.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B20.Name = "B20";
            this.B20.Size = new System.Drawing.Size(113, 20);
            this.B20.TabIndex = 3;
            this.B20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B20.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B10
            // 
            this.B10.Location = new System.Drawing.Point(100, 92);
            this.B10.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B10.Name = "B10";
            this.B10.Size = new System.Drawing.Size(113, 20);
            this.B10.TabIndex = 4;
            this.B10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B10.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(100, 118);
            this.B5.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(113, 20);
            this.B5.TabIndex = 5;
            this.B5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B5.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(100, 144);
            this.B2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(113, 20);
            this.B2.TabIndex = 6;
            this.B2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.B2.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M2
            // 
            this.M2.Location = new System.Drawing.Point(100, 170);
            this.M2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(113, 20);
            this.M2.TabIndex = 7;
            this.M2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M2.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M1
            // 
            this.M1.Location = new System.Drawing.Point(100, 196);
            this.M1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(113, 20);
            this.M1.TabIndex = 8;
            this.M1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M1.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M050
            // 
            this.M050.Location = new System.Drawing.Point(100, 222);
            this.M050.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M050.Name = "M050";
            this.M050.Size = new System.Drawing.Size(113, 20);
            this.M050.TabIndex = 9;
            this.M050.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M050.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M025
            // 
            this.M025.Location = new System.Drawing.Point(100, 248);
            this.M025.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M025.Name = "M025";
            this.M025.Size = new System.Drawing.Size(113, 20);
            this.M025.TabIndex = 10;
            this.M025.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M025.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M010
            // 
            this.M010.Location = new System.Drawing.Point(100, 274);
            this.M010.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M010.Name = "M010";
            this.M010.Size = new System.Drawing.Size(113, 20);
            this.M010.TabIndex = 11;
            this.M010.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M010.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // M005
            // 
            this.M005.Location = new System.Drawing.Point(100, 300);
            this.M005.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.M005.Name = "M005";
            this.M005.Size = new System.Drawing.Size(113, 20);
            this.M005.TabIndex = 12;
            this.M005.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.M005.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.B100);
            this.groupBox1.Controls.Add(this.M005);
            this.groupBox1.Controls.Add(this.B50);
            this.groupBox1.Controls.Add(this.M010);
            this.groupBox1.Controls.Add(this.B20);
            this.groupBox1.Controls.Add(this.M025);
            this.groupBox1.Controls.Add(this.B10);
            this.groupBox1.Controls.Add(this.M050);
            this.groupBox1.Controls.Add(this.B5);
            this.groupBox1.Controls.Add(this.M1);
            this.groupBox1.Controls.Add(this.B2);
            this.groupBox1.Controls.Add(this.M2);
            this.groupBox1.Location = new System.Drawing.Point(10, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 330);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dinero en caja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Moneda $0,05:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Moneda $0,10:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Moneda $0,25:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Moneda $0,50:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Moneda $1:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Moneda $2:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Billete $2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Billete $5:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Billete $10:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Billete $20:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Billete $50:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Billete $100:";
            // 
            // DineroCaja
            // 
            this.DineroCaja.DecimalPlaces = 4;
            this.DineroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineroCaja.Location = new System.Drawing.Point(176, 96);
            this.DineroCaja.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.DineroCaja.Name = "DineroCaja";
            this.DineroCaja.Size = new System.Drawing.Size(198, 31);
            this.DineroCaja.TabIndex = 14;
            this.DineroCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DineroCaja.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // Resultado
            // 
            this.Resultado.DecimalPlaces = 4;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(176, 163);
            this.Resultado.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Resultado.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(198, 31);
            this.Resultado.TabIndex = 15;
            this.Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Resultado.ValueChanged += new System.EventHandler(this.Resultado_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Total inicial:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "Dinero en caja:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "Resultado:";
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 146;
            this.lineShape1.X2 = 406;
            this.lineShape1.Y1 = 130;
            this.lineShape1.Y2 = 130;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalInicial);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.DineroCaja);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.Resultado);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.shapeContainer2);
            this.groupBox2.Location = new System.Drawing.Point(242, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 207);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cuenta";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(425, 188);
            this.shapeContainer2.TabIndex = 19;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 156;
            this.lineShape2.X2 = 176;
            this.lineShape2.Y1 = 64;
            this.lineShape2.Y2 = 64;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(582, 300);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 47;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_VueltoIdeal);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Vuelto);
            this.groupBox3.Location = new System.Drawing.Point(242, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 75);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vuelto ideal";
            // 
            // Btn_VueltoIdeal
            // 
            this.Btn_VueltoIdeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VueltoIdeal.AutoSize = true;
            this.Btn_VueltoIdeal.Image = global::Consultorio.Properties.Resources.calculator_icon;
            this.Btn_VueltoIdeal.Location = new System.Drawing.Point(281, 12);
            this.Btn_VueltoIdeal.Name = "Btn_VueltoIdeal";
            this.Btn_VueltoIdeal.Size = new System.Drawing.Size(144, 50);
            this.Btn_VueltoIdeal.TabIndex = 48;
            this.Btn_VueltoIdeal.Text = "Calcular vuelto ideal";
            this.Btn_VueltoIdeal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_VueltoIdeal.UseVisualStyleBackColor = true;
            this.Btn_VueltoIdeal.Click += new System.EventHandler(this.Btn_VueltoIdeal_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 20);
            this.label16.TabIndex = 20;
            this.label16.Text = "Resultado:";
            // 
            // Vuelto
            // 
            this.Vuelto.DecimalPlaces = 4;
            this.Vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vuelto.Location = new System.Drawing.Point(107, 25);
            this.Vuelto.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.Vuelto.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.Vuelto.Name = "Vuelto";
            this.Vuelto.Size = new System.Drawing.Size(159, 26);
            this.Vuelto.TabIndex = 19;
            this.Vuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmContarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(682, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(698, 382);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(698, 382);
            this.Name = "FrmContarCaja";
            this.ShowIcon = false;
            this.Text = "Contar la caja";
            this.Load += new System.EventHandler(this.FrmContarCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M050)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M025)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M010)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M005)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DineroCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resultado)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Vuelto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TotalInicial;
        private System.Windows.Forms.NumericUpDown B100;
        private System.Windows.Forms.NumericUpDown B50;
        private System.Windows.Forms.NumericUpDown B20;
        private System.Windows.Forms.NumericUpDown B10;
        private System.Windows.Forms.NumericUpDown B5;
        private System.Windows.Forms.NumericUpDown B2;
        private System.Windows.Forms.NumericUpDown M2;
        private System.Windows.Forms.NumericUpDown M1;
        private System.Windows.Forms.NumericUpDown M050;
        private System.Windows.Forms.NumericUpDown M025;
        private System.Windows.Forms.NumericUpDown M010;
        private System.Windows.Forms.NumericUpDown M005;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DineroCaja;
        private System.Windows.Forms.NumericUpDown Resultado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown Vuelto;
        private System.Windows.Forms.Button Btn_VueltoIdeal;
    }
}