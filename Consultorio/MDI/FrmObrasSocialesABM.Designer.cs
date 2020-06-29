namespace Consultorio.MDI
{
    partial class FrmObrasSocialesABM
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
            System.Windows.Forms.Label descripcion_Obra_SocialLabel;
            System.Windows.Forms.Label id_Obra_SocialLabel;
            System.Windows.Forms.Label observaciones_Obra_SocialLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.descripcion_Obra_SocialTextBox = new System.Windows.Forms.TextBox();
            this.id_Obra_SocialNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.observaciones_Obra_SocialTextBox = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            descripcion_Obra_SocialLabel = new System.Windows.Forms.Label();
            id_Obra_SocialLabel = new System.Windows.Forms.Label();
            observaciones_Obra_SocialLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_Obra_SocialNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion_Obra_SocialLabel
            // 
            descripcion_Obra_SocialLabel.AutoSize = true;
            descripcion_Obra_SocialLabel.Location = new System.Drawing.Point(6, 45);
            descripcion_Obra_SocialLabel.Name = "descripcion_Obra_SocialLabel";
            descripcion_Obra_SocialLabel.Size = new System.Drawing.Size(66, 13);
            descripcion_Obra_SocialLabel.TabIndex = 7;
            descripcion_Obra_SocialLabel.Text = "Descripción:";
            // 
            // id_Obra_SocialLabel
            // 
            id_Obra_SocialLabel.AutoSize = true;
            id_Obra_SocialLabel.Location = new System.Drawing.Point(6, 16);
            id_Obra_SocialLabel.Name = "id_Obra_SocialLabel";
            id_Obra_SocialLabel.Size = new System.Drawing.Size(21, 13);
            id_Obra_SocialLabel.TabIndex = 9;
            id_Obra_SocialLabel.Text = "ID:";
            // 
            // observaciones_Obra_SocialLabel
            // 
            observaciones_Obra_SocialLabel.AutoSize = true;
            observaciones_Obra_SocialLabel.Location = new System.Drawing.Point(6, 71);
            observaciones_Obra_SocialLabel.Name = "observaciones_Obra_SocialLabel";
            observaciones_Obra_SocialLabel.Size = new System.Drawing.Size(81, 13);
            observaciones_Obra_SocialLabel.TabIndex = 11;
            observaciones_Obra_SocialLabel.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(descripcion_Obra_SocialLabel);
            this.groupBox1.Controls.Add(this.descripcion_Obra_SocialTextBox);
            this.groupBox1.Controls.Add(id_Obra_SocialLabel);
            this.groupBox1.Controls.Add(this.id_Obra_SocialNumericUpDown);
            this.groupBox1.Controls.Add(observaciones_Obra_SocialLabel);
            this.groupBox1.Controls.Add(this.observaciones_Obra_SocialTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 289);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // descripcion_Obra_SocialTextBox
            // 
            this.descripcion_Obra_SocialTextBox.Location = new System.Drawing.Point(89, 40);
            this.descripcion_Obra_SocialTextBox.Name = "descripcion_Obra_SocialTextBox";
            this.descripcion_Obra_SocialTextBox.Size = new System.Drawing.Size(326, 20);
            this.descripcion_Obra_SocialTextBox.TabIndex = 8;
            // 
            // id_Obra_SocialNumericUpDown
            // 
            this.id_Obra_SocialNumericUpDown.Enabled = false;
            this.id_Obra_SocialNumericUpDown.Location = new System.Drawing.Point(89, 14);
            this.id_Obra_SocialNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_Obra_SocialNumericUpDown.Name = "id_Obra_SocialNumericUpDown";
            this.id_Obra_SocialNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.id_Obra_SocialNumericUpDown.TabIndex = 10;
            this.id_Obra_SocialNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // observaciones_Obra_SocialTextBox
            // 
            this.observaciones_Obra_SocialTextBox.Location = new System.Drawing.Point(89, 66);
            this.observaciones_Obra_SocialTextBox.Multiline = true;
            this.observaciones_Obra_SocialTextBox.Name = "observaciones_Obra_SocialTextBox";
            this.observaciones_Obra_SocialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observaciones_Obra_SocialTextBox.Size = new System.Drawing.Size(326, 217);
            this.observaciones_Obra_SocialTextBox.TabIndex = 12;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(250, 307);
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(342, 307);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 62;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // FrmObrasSocialesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(439, 353);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(455, 391);
            this.Name = "FrmObrasSocialesABM";
            this.ShowIcon = false;
            this.Text = "Nueva/Modificación Obra social";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_Obra_SocialNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox descripcion_Obra_SocialTextBox;
        private System.Windows.Forms.NumericUpDown id_Obra_SocialNumericUpDown;
        private System.Windows.Forms.TextBox observaciones_Obra_SocialTextBox;
    }
}