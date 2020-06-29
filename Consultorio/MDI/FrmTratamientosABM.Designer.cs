namespace Consultorio.MDI
{
    partial class FrmTratamientosABM
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
            System.Windows.Forms.Label descripcion_TratamientoLabel;
            System.Windows.Forms.Label id_TratamientoLabel;
            this.descripcion_TratamientoTextBox = new System.Windows.Forms.TextBox();
            this.id_TratamientoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            descripcion_TratamientoLabel = new System.Windows.Forms.Label();
            id_TratamientoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.id_TratamientoNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcion_TratamientoLabel
            // 
            descripcion_TratamientoLabel.AutoSize = true;
            descripcion_TratamientoLabel.Location = new System.Drawing.Point(6, 45);
            descripcion_TratamientoLabel.Name = "descripcion_TratamientoLabel";
            descripcion_TratamientoLabel.Size = new System.Drawing.Size(66, 13);
            descripcion_TratamientoLabel.TabIndex = 5;
            descripcion_TratamientoLabel.Text = "Descripción:";
            // 
            // id_TratamientoLabel
            // 
            id_TratamientoLabel.AutoSize = true;
            id_TratamientoLabel.Location = new System.Drawing.Point(6, 16);
            id_TratamientoLabel.Name = "id_TratamientoLabel";
            id_TratamientoLabel.Size = new System.Drawing.Size(21, 13);
            id_TratamientoLabel.TabIndex = 7;
            id_TratamientoLabel.Text = "ID:";
            // 
            // descripcion_TratamientoTextBox
            // 
            this.descripcion_TratamientoTextBox.Location = new System.Drawing.Point(78, 42);
            this.descripcion_TratamientoTextBox.Name = "descripcion_TratamientoTextBox";
            this.descripcion_TratamientoTextBox.Size = new System.Drawing.Size(337, 20);
            this.descripcion_TratamientoTextBox.TabIndex = 6;
            // 
            // id_TratamientoNumericUpDown
            // 
            this.id_TratamientoNumericUpDown.Enabled = false;
            this.id_TratamientoNumericUpDown.Location = new System.Drawing.Point(78, 16);
            this.id_TratamientoNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_TratamientoNumericUpDown.Name = "id_TratamientoNumericUpDown";
            this.id_TratamientoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.id_TratamientoNumericUpDown.TabIndex = 8;
            this.id_TratamientoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_TratamientoNumericUpDown);
            this.groupBox1.Controls.Add(id_TratamientoLabel);
            this.groupBox1.Controls.Add(this.descripcion_TratamientoTextBox);
            this.groupBox1.Controls.Add(descripcion_TratamientoLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 73);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(250, 91);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 66;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(342, 91);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 65;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // FrmTratamientosABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(449, 138);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(465, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 176);
            this.Name = "FrmTratamientosABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Modificar tratameinto";
            ((System.ComponentModel.ISupportInitialize)(this.id_TratamientoNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descripcion_TratamientoTextBox;
        private System.Windows.Forms.NumericUpDown id_TratamientoNumericUpDown;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}