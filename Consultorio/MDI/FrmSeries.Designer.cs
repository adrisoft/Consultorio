namespace Consultorio.MDI
{
    partial class FrmSeries
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUD_FACA = new System.Windows.Forms.NumericUpDown();
            this.NUD_FACB = new System.Windows.Forms.NumericUpDown();
            this.NUD_Presupuesto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_FACC = new System.Windows.Forms.NumericUpDown();
            this.NUD_Recibos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Presupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(31, 170);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 63;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(123, 170);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 62;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUD_FACC);
            this.groupBox1.Controls.Add(this.NUD_Recibos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.NUD_FACA);
            this.groupBox1.Controls.Add(this.NUD_FACB);
            this.groupBox1.Controls.Add(this.NUD_Presupuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 152);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // NUD_FACA
            // 
            this.NUD_FACA.Location = new System.Drawing.Point(83, 40);
            this.NUD_FACA.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_FACA.Name = "NUD_FACA";
            this.NUD_FACA.Size = new System.Drawing.Size(111, 20);
            this.NUD_FACA.TabIndex = 68;
            this.NUD_FACA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_FACB
            // 
            this.NUD_FACB.Location = new System.Drawing.Point(83, 69);
            this.NUD_FACB.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_FACB.Name = "NUD_FACB";
            this.NUD_FACB.Size = new System.Drawing.Size(111, 20);
            this.NUD_FACB.TabIndex = 67;
            this.NUD_FACB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_Presupuesto
            // 
            this.NUD_Presupuesto.Location = new System.Drawing.Point(83, 14);
            this.NUD_Presupuesto.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_Presupuesto.Name = "NUD_Presupuesto";
            this.NUD_Presupuesto.Size = new System.Drawing.Size(111, 20);
            this.NUD_Presupuesto.TabIndex = 66;
            this.NUD_Presupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "Facturas A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 64;
            this.label2.Text = "Facturas B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presupuesto:";
            // 
            // NUD_FACC
            // 
            this.NUD_FACC.Location = new System.Drawing.Point(83, 95);
            this.NUD_FACC.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_FACC.Name = "NUD_FACC";
            this.NUD_FACC.Size = new System.Drawing.Size(111, 20);
            this.NUD_FACC.TabIndex = 72;
            this.NUD_FACC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NUD_Recibos
            // 
            this.NUD_Recibos.Location = new System.Drawing.Point(83, 124);
            this.NUD_Recibos.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NUD_Recibos.Name = "NUD_Recibos";
            this.NUD_Recibos.Size = new System.Drawing.Size(111, 20);
            this.NUD_Recibos.TabIndex = 71;
            this.NUD_Recibos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Facturas C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Recibos";
            // 
            // FrmSeries
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(223, 216);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(229, 244);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 244);
            this.Name = "FrmSeries";
            this.ShowIcon = false;
            this.Text = "Series";
            this.Load += new System.EventHandler(this.FrmSeries_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Presupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FACC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Recibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUD_Presupuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_FACA;
        private System.Windows.Forms.NumericUpDown NUD_FACB;
        private System.Windows.Forms.NumericUpDown NUD_FACC;
        private System.Windows.Forms.NumericUpDown NUD_Recibos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}