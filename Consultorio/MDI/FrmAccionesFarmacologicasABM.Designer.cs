namespace Consultorio.MDI
{
    partial class FrmAccionesFarmacologicasABM
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
            System.Windows.Forms.Label descripcion_Medicacion_Accion_FarmacologicaLabel;
            System.Windows.Forms.Label id_Medicacion_Accion_FarmacologicaLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox = new System.Windows.Forms.TextBox();
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            descripcion_Medicacion_Accion_FarmacologicaLabel = new System.Windows.Forms.Label();
            id_Medicacion_Accion_FarmacologicaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_Medicacion_Accion_FarmacologicaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion_Medicacion_Accion_FarmacologicaLabel
            // 
            descripcion_Medicacion_Accion_FarmacologicaLabel.AutoSize = true;
            descripcion_Medicacion_Accion_FarmacologicaLabel.Location = new System.Drawing.Point(6, 45);
            descripcion_Medicacion_Accion_FarmacologicaLabel.Name = "descripcion_Medicacion_Accion_FarmacologicaLabel";
            descripcion_Medicacion_Accion_FarmacologicaLabel.Size = new System.Drawing.Size(66, 13);
            descripcion_Medicacion_Accion_FarmacologicaLabel.TabIndex = 5;
            descripcion_Medicacion_Accion_FarmacologicaLabel.Text = "Descripción:";
            // 
            // id_Medicacion_Accion_FarmacologicaLabel
            // 
            id_Medicacion_Accion_FarmacologicaLabel.AutoSize = true;
            id_Medicacion_Accion_FarmacologicaLabel.Location = new System.Drawing.Point(6, 16);
            id_Medicacion_Accion_FarmacologicaLabel.Name = "id_Medicacion_Accion_FarmacologicaLabel";
            id_Medicacion_Accion_FarmacologicaLabel.Size = new System.Drawing.Size(21, 13);
            id_Medicacion_Accion_FarmacologicaLabel.TabIndex = 7;
            id_Medicacion_Accion_FarmacologicaLabel.Text = "ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(descripcion_Medicacion_Accion_FarmacologicaLabel);
            this.groupBox1.Controls.Add(this.descripcion_Medicacion_Accion_FarmacologicaTextBox);
            this.groupBox1.Controls.Add(id_Medicacion_Accion_FarmacologicaLabel);
            this.groupBox1.Controls.Add(this.id_Medicacion_Accion_FarmacologicaNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 69);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // descripcion_Medicacion_Accion_FarmacologicaTextBox
            // 
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox.Location = new System.Drawing.Point(78, 42);
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox.MaxLength = 255;
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox.Name = "descripcion_Medicacion_Accion_FarmacologicaTextBox";
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox.Size = new System.Drawing.Size(337, 20);
            this.descripcion_Medicacion_Accion_FarmacologicaTextBox.TabIndex = 6;
            // 
            // id_Medicacion_Accion_FarmacologicaNumericUpDown
            // 
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.Enabled = false;
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.Location = new System.Drawing.Point(78, 16);
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.Name = "id_Medicacion_Accion_FarmacologicaNumericUpDown";
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.Size = new System.Drawing.Size(95, 20);
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.TabIndex = 8;
            this.id_Medicacion_Accion_FarmacologicaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(250, 87);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 57;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(342, 87);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 56;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // FrmAccionesFarmacologicasABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(440, 135);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(456, 173);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(456, 173);
            this.Name = "FrmAccionesFarmacologicasABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Editar Acciones farmacológicas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_Medicacion_Accion_FarmacologicaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcion_Medicacion_Accion_FarmacologicaTextBox;
        private System.Windows.Forms.NumericUpDown id_Medicacion_Accion_FarmacologicaNumericUpDown;
    }
}