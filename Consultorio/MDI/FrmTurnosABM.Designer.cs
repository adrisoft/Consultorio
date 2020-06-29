namespace Consultorio.MDI
{
    partial class FrmTurnosABM
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
            System.Windows.Forms.Label fecha_TurnoLabel;
            System.Windows.Forms.Label id_TerceroLabel;
            System.Windows.Forms.Label id_TurnoLabel;
            System.Windows.Forms.Label observaciones_TurnoLabel;
            System.Windows.Forms.Label label1;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fecha_TurnoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Txt_NombrePaciente = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.Hora_TurnoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_TerceroNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.id_TurnoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.observaciones_TurnoTextBox = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            fecha_TurnoLabel = new System.Windows.Forms.Label();
            id_TerceroLabel = new System.Windows.Forms.Label();
            id_TurnoLabel = new System.Windows.Forms.Label();
            observaciones_TurnoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_TerceroNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_TurnoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha_TurnoLabel
            // 
            fecha_TurnoLabel.AutoSize = true;
            fecha_TurnoLabel.Location = new System.Drawing.Point(6, 72);
            fecha_TurnoLabel.Name = "fecha_TurnoLabel";
            fecha_TurnoLabel.Size = new System.Drawing.Size(33, 13);
            fecha_TurnoLabel.TabIndex = 9;
            fecha_TurnoLabel.Text = "Hora:";
            // 
            // id_TerceroLabel
            // 
            id_TerceroLabel.AutoSize = true;
            id_TerceroLabel.Location = new System.Drawing.Point(6, 42);
            id_TerceroLabel.Name = "id_TerceroLabel";
            id_TerceroLabel.Size = new System.Drawing.Size(52, 13);
            id_TerceroLabel.TabIndex = 11;
            id_TerceroLabel.Text = "Paciente:";
            // 
            // id_TurnoLabel
            // 
            id_TurnoLabel.AutoSize = true;
            id_TurnoLabel.Location = new System.Drawing.Point(6, 16);
            id_TurnoLabel.Name = "id_TurnoLabel";
            id_TurnoLabel.Size = new System.Drawing.Size(21, 13);
            id_TurnoLabel.TabIndex = 13;
            id_TurnoLabel.Text = "ID:";
            // 
            // observaciones_TurnoLabel
            // 
            observaciones_TurnoLabel.AutoSize = true;
            observaciones_TurnoLabel.Location = new System.Drawing.Point(6, 123);
            observaciones_TurnoLabel.Name = "observaciones_TurnoLabel";
            observaciones_TurnoLabel.Size = new System.Drawing.Size(81, 13);
            observaciones_TurnoLabel.TabIndex = 15;
            observaciones_TurnoLabel.Text = "Observaciones:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 98);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 13);
            label1.TabIndex = 151;
            label1.Text = "Fecha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.fecha_TurnoDateTimePicker);
            this.groupBox1.Controls.Add(this.Txt_NombrePaciente);
            this.groupBox1.Controls.Add(this.Btn_BuscarPaciente);
            this.groupBox1.Controls.Add(fecha_TurnoLabel);
            this.groupBox1.Controls.Add(this.Hora_TurnoDateTimePicker);
            this.groupBox1.Controls.Add(id_TerceroLabel);
            this.groupBox1.Controls.Add(this.id_TerceroNumericUpDown);
            this.groupBox1.Controls.Add(id_TurnoLabel);
            this.groupBox1.Controls.Add(this.id_TurnoNumericUpDown);
            this.groupBox1.Controls.Add(observaciones_TurnoLabel);
            this.groupBox1.Controls.Add(this.observaciones_TurnoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 289);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // fecha_TurnoDateTimePicker
            // 
            this.fecha_TurnoDateTimePicker.Location = new System.Drawing.Point(93, 94);
            this.fecha_TurnoDateTimePicker.Name = "fecha_TurnoDateTimePicker";
            this.fecha_TurnoDateTimePicker.Size = new System.Drawing.Size(328, 20);
            this.fecha_TurnoDateTimePicker.TabIndex = 152;
            // 
            // Txt_NombrePaciente
            // 
            this.Txt_NombrePaciente.Enabled = false;
            this.Txt_NombrePaciente.Location = new System.Drawing.Point(222, 42);
            this.Txt_NombrePaciente.Name = "Txt_NombrePaciente";
            this.Txt_NombrePaciente.Size = new System.Drawing.Size(199, 20);
            this.Txt_NombrePaciente.TabIndex = 150;
            // 
            // Btn_BuscarPaciente
            // 
            this.Btn_BuscarPaciente.AutoSize = true;
            this.Btn_BuscarPaciente.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarPaciente.Location = new System.Drawing.Point(190, 41);
            this.Btn_BuscarPaciente.Name = "Btn_BuscarPaciente";
            this.Btn_BuscarPaciente.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarPaciente.TabIndex = 149;
            this.Btn_BuscarPaciente.UseVisualStyleBackColor = true;
            this.Btn_BuscarPaciente.Click += new System.EventHandler(this.Btn_BuscarPaciente_Click);
            // 
            // Hora_TurnoDateTimePicker
            // 
            this.Hora_TurnoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Hora_TurnoDateTimePicker.Location = new System.Drawing.Point(93, 68);
            this.Hora_TurnoDateTimePicker.Name = "Hora_TurnoDateTimePicker";
            this.Hora_TurnoDateTimePicker.Size = new System.Drawing.Size(328, 20);
            this.Hora_TurnoDateTimePicker.TabIndex = 10;
            // 
            // id_TerceroNumericUpDown
            // 
            this.id_TerceroNumericUpDown.Enabled = false;
            this.id_TerceroNumericUpDown.Location = new System.Drawing.Point(93, 42);
            this.id_TerceroNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_TerceroNumericUpDown.Name = "id_TerceroNumericUpDown";
            this.id_TerceroNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.id_TerceroNumericUpDown.TabIndex = 12;
            this.id_TerceroNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // id_TurnoNumericUpDown
            // 
            this.id_TurnoNumericUpDown.Enabled = false;
            this.id_TurnoNumericUpDown.Location = new System.Drawing.Point(93, 16);
            this.id_TurnoNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_TurnoNumericUpDown.Name = "id_TurnoNumericUpDown";
            this.id_TurnoNumericUpDown.Size = new System.Drawing.Size(91, 20);
            this.id_TurnoNumericUpDown.TabIndex = 14;
            this.id_TurnoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // observaciones_TurnoTextBox
            // 
            this.observaciones_TurnoTextBox.Location = new System.Drawing.Point(93, 120);
            this.observaciones_TurnoTextBox.Multiline = true;
            this.observaciones_TurnoTextBox.Name = "observaciones_TurnoTextBox";
            this.observaciones_TurnoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observaciones_TurnoTextBox.Size = new System.Drawing.Size(328, 163);
            this.observaciones_TurnoTextBox.TabIndex = 16;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(257, 307);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 54;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(349, 307);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 53;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // FrmTurnosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(445, 353);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(461, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(461, 391);
            this.Name = "FrmTurnosABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Editar Turno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTurnosABM_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_TerceroNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_TurnoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker Hora_TurnoDateTimePicker;
        private System.Windows.Forms.NumericUpDown id_TerceroNumericUpDown;
        private System.Windows.Forms.NumericUpDown id_TurnoNumericUpDown;
        private System.Windows.Forms.TextBox observaciones_TurnoTextBox;
        private System.Windows.Forms.TextBox Txt_NombrePaciente;
        private System.Windows.Forms.Button Btn_BuscarPaciente;
        private System.Windows.Forms.DateTimePicker fecha_TurnoDateTimePicker;
    }
}