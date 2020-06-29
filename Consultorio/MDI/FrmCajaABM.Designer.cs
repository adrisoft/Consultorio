namespace Consultorio.MDI
{
    partial class FrmCajaABM
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
            System.Windows.Forms.Label fecha_CajaLabel;
            System.Windows.Forms.Label importe_CajaLabel;
            System.Windows.Forms.Label tag_CajaLabel;
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Engreso_radioButton = new System.Windows.Forms.RadioButton();
            this.Ingreso_radioButton = new System.Windows.Forms.RadioButton();
            this.fecha_CajaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.importe_CajaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tag_CajaTextBox = new System.Windows.Forms.TextBox();
            fecha_CajaLabel = new System.Windows.Forms.Label();
            importe_CajaLabel = new System.Windows.Forms.Label();
            tag_CajaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importe_CajaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_CajaLabel
            // 
            fecha_CajaLabel.AutoSize = true;
            fecha_CajaLabel.Location = new System.Drawing.Point(9, 23);
            fecha_CajaLabel.Name = "fecha_CajaLabel";
            fecha_CajaLabel.Size = new System.Drawing.Size(40, 13);
            fecha_CajaLabel.TabIndex = 15;
            fecha_CajaLabel.Text = "Fecha:";
            // 
            // importe_CajaLabel
            // 
            importe_CajaLabel.AutoSize = true;
            importe_CajaLabel.Location = new System.Drawing.Point(9, 45);
            importe_CajaLabel.Name = "importe_CajaLabel";
            importe_CajaLabel.Size = new System.Drawing.Size(60, 13);
            importe_CajaLabel.TabIndex = 19;
            importe_CajaLabel.Text = "Importe ($):";
            // 
            // tag_CajaLabel
            // 
            tag_CajaLabel.AutoSize = true;
            tag_CajaLabel.Location = new System.Drawing.Point(9, 74);
            tag_CajaLabel.Name = "tag_CajaLabel";
            tag_CajaLabel.Size = new System.Drawing.Size(48, 13);
            tag_CajaLabel.TabIndex = 25;
            tag_CajaLabel.Text = "Detalles:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(167, 197);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 48;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(259, 197);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 47;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(fecha_CajaLabel);
            this.groupBox1.Controls.Add(this.fecha_CajaDateTimePicker);
            this.groupBox1.Controls.Add(importe_CajaLabel);
            this.groupBox1.Controls.Add(this.importe_CajaNumericUpDown);
            this.groupBox1.Controls.Add(tag_CajaLabel);
            this.groupBox1.Controls.Add(this.tag_CajaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 179);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Engreso_radioButton);
            this.groupBox2.Controls.Add(this.Ingreso_radioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 71);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // Engreso_radioButton
            // 
            this.Engreso_radioButton.AutoSize = true;
            this.Engreso_radioButton.Location = new System.Drawing.Point(6, 42);
            this.Engreso_radioButton.Name = "Engreso_radioButton";
            this.Engreso_radioButton.Size = new System.Drawing.Size(64, 17);
            this.Engreso_radioButton.TabIndex = 1;
            this.Engreso_radioButton.TabStop = true;
            this.Engreso_radioButton.Text = "Engreso";
            this.Engreso_radioButton.UseVisualStyleBackColor = true;
            // 
            // Ingreso_radioButton
            // 
            this.Ingreso_radioButton.AutoSize = true;
            this.Ingreso_radioButton.Checked = true;
            this.Ingreso_radioButton.Location = new System.Drawing.Point(6, 19);
            this.Ingreso_radioButton.Name = "Ingreso_radioButton";
            this.Ingreso_radioButton.Size = new System.Drawing.Size(60, 17);
            this.Ingreso_radioButton.TabIndex = 0;
            this.Ingreso_radioButton.TabStop = true;
            this.Ingreso_radioButton.Text = "Ingreso";
            this.Ingreso_radioButton.UseVisualStyleBackColor = true;
            // 
            // fecha_CajaDateTimePicker
            // 
            this.fecha_CajaDateTimePicker.Location = new System.Drawing.Point(122, 19);
            this.fecha_CajaDateTimePicker.Name = "fecha_CajaDateTimePicker";
            this.fecha_CajaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_CajaDateTimePicker.TabIndex = 16;
            // 
            // importe_CajaNumericUpDown
            // 
            this.importe_CajaNumericUpDown.DecimalPlaces = 4;
            this.importe_CajaNumericUpDown.Location = new System.Drawing.Point(122, 45);
            this.importe_CajaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.importe_CajaNumericUpDown.Name = "importe_CajaNumericUpDown";
            this.importe_CajaNumericUpDown.Size = new System.Drawing.Size(200, 20);
            this.importe_CajaNumericUpDown.TabIndex = 20;
            this.importe_CajaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tag_CajaTextBox
            // 
            this.tag_CajaTextBox.Location = new System.Drawing.Point(122, 71);
            this.tag_CajaTextBox.Name = "tag_CajaTextBox";
            this.tag_CajaTextBox.Size = new System.Drawing.Size(200, 20);
            this.tag_CajaTextBox.TabIndex = 26;
            // 
            // FrmCajaABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(359, 243);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 281);
            this.Name = "FrmCajaABM";
            this.ShowIcon = false;
            this.Text = "Ingreso/Engreso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.importe_CajaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker fecha_CajaDateTimePicker;
        private System.Windows.Forms.NumericUpDown importe_CajaNumericUpDown;
        private System.Windows.Forms.TextBox tag_CajaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Engreso_radioButton;
        private System.Windows.Forms.RadioButton Ingreso_radioButton;
    }
}