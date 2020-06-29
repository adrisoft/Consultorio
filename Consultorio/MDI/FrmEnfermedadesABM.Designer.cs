namespace Consultorio.MDI
{
    partial class FrmEnfermedadesABM
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
            System.Windows.Forms.Label codigo_EnfermedadLabel;
            System.Windows.Forms.Label descripcion_EnfermedadLabel;
            System.Windows.Forms.Label id_EnfermedadLabel;
            System.Windows.Forms.Label id_Enfermedad_CategoriaLabel;
            System.Windows.Forms.Label observaciones_EnfermedadLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_NombreCategoria = new System.Windows.Forms.TextBox();
            this.Btn_BuscarCategoria = new System.Windows.Forms.Button();
            this.codigo_EnfermedadTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_EnfermedadTextBox = new System.Windows.Forms.TextBox();
            this.id_EnfermedadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.id_Enfermedad_CategoriaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.observaciones_EnfermedadTextBox = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            codigo_EnfermedadLabel = new System.Windows.Forms.Label();
            descripcion_EnfermedadLabel = new System.Windows.Forms.Label();
            id_EnfermedadLabel = new System.Windows.Forms.Label();
            id_Enfermedad_CategoriaLabel = new System.Windows.Forms.Label();
            observaciones_EnfermedadLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_EnfermedadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_Enfermedad_CategoriaNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_EnfermedadLabel
            // 
            codigo_EnfermedadLabel.AutoSize = true;
            codigo_EnfermedadLabel.Location = new System.Drawing.Point(6, 71);
            codigo_EnfermedadLabel.Name = "codigo_EnfermedadLabel";
            codigo_EnfermedadLabel.Size = new System.Drawing.Size(43, 13);
            codigo_EnfermedadLabel.TabIndex = 11;
            codigo_EnfermedadLabel.Text = "Código:";
            // 
            // descripcion_EnfermedadLabel
            // 
            descripcion_EnfermedadLabel.AutoSize = true;
            descripcion_EnfermedadLabel.Location = new System.Drawing.Point(6, 97);
            descripcion_EnfermedadLabel.Name = "descripcion_EnfermedadLabel";
            descripcion_EnfermedadLabel.Size = new System.Drawing.Size(66, 13);
            descripcion_EnfermedadLabel.TabIndex = 13;
            descripcion_EnfermedadLabel.Text = "Descripción:";
            // 
            // id_EnfermedadLabel
            // 
            id_EnfermedadLabel.AutoSize = true;
            id_EnfermedadLabel.Location = new System.Drawing.Point(6, 16);
            id_EnfermedadLabel.Name = "id_EnfermedadLabel";
            id_EnfermedadLabel.Size = new System.Drawing.Size(21, 13);
            id_EnfermedadLabel.TabIndex = 15;
            id_EnfermedadLabel.Text = "ID:";
            // 
            // id_Enfermedad_CategoriaLabel
            // 
            id_Enfermedad_CategoriaLabel.AutoSize = true;
            id_Enfermedad_CategoriaLabel.Location = new System.Drawing.Point(6, 42);
            id_Enfermedad_CategoriaLabel.Name = "id_Enfermedad_CategoriaLabel";
            id_Enfermedad_CategoriaLabel.Size = new System.Drawing.Size(57, 13);
            id_Enfermedad_CategoriaLabel.TabIndex = 17;
            id_Enfermedad_CategoriaLabel.Text = "Categoría:";
            // 
            // observaciones_EnfermedadLabel
            // 
            observaciones_EnfermedadLabel.AutoSize = true;
            observaciones_EnfermedadLabel.Location = new System.Drawing.Point(6, 123);
            observaciones_EnfermedadLabel.Name = "observaciones_EnfermedadLabel";
            observaciones_EnfermedadLabel.Size = new System.Drawing.Size(81, 13);
            observaciones_EnfermedadLabel.TabIndex = 19;
            observaciones_EnfermedadLabel.Text = "Observaciones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_NombreCategoria);
            this.groupBox1.Controls.Add(this.Btn_BuscarCategoria);
            this.groupBox1.Controls.Add(codigo_EnfermedadLabel);
            this.groupBox1.Controls.Add(this.codigo_EnfermedadTextBox);
            this.groupBox1.Controls.Add(descripcion_EnfermedadLabel);
            this.groupBox1.Controls.Add(this.descripcion_EnfermedadTextBox);
            this.groupBox1.Controls.Add(id_EnfermedadLabel);
            this.groupBox1.Controls.Add(this.id_EnfermedadNumericUpDown);
            this.groupBox1.Controls.Add(id_Enfermedad_CategoriaLabel);
            this.groupBox1.Controls.Add(this.id_Enfermedad_CategoriaNumericUpDown);
            this.groupBox1.Controls.Add(observaciones_EnfermedadLabel);
            this.groupBox1.Controls.Add(this.observaciones_EnfermedadTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 289);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Txt_NombreCategoria
            // 
            this.Txt_NombreCategoria.Enabled = false;
            this.Txt_NombreCategoria.Location = new System.Drawing.Point(218, 40);
            this.Txt_NombreCategoria.Name = "Txt_NombreCategoria";
            this.Txt_NombreCategoria.Size = new System.Drawing.Size(197, 20);
            this.Txt_NombreCategoria.TabIndex = 145;
            // 
            // Btn_BuscarCategoria
            // 
            this.Btn_BuscarCategoria.AutoSize = true;
            this.Btn_BuscarCategoria.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarCategoria.Location = new System.Drawing.Point(186, 39);
            this.Btn_BuscarCategoria.Name = "Btn_BuscarCategoria";
            this.Btn_BuscarCategoria.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarCategoria.TabIndex = 144;
            this.Btn_BuscarCategoria.UseVisualStyleBackColor = true;
            this.Btn_BuscarCategoria.Click += new System.EventHandler(this.Btn_BuscarCategoria_Click);
            // 
            // codigo_EnfermedadTextBox
            // 
            this.codigo_EnfermedadTextBox.Location = new System.Drawing.Point(91, 66);
            this.codigo_EnfermedadTextBox.MaxLength = 5;
            this.codigo_EnfermedadTextBox.Name = "codigo_EnfermedadTextBox";
            this.codigo_EnfermedadTextBox.Size = new System.Drawing.Size(324, 20);
            this.codigo_EnfermedadTextBox.TabIndex = 12;
            // 
            // descripcion_EnfermedadTextBox
            // 
            this.descripcion_EnfermedadTextBox.Location = new System.Drawing.Point(91, 92);
            this.descripcion_EnfermedadTextBox.Name = "descripcion_EnfermedadTextBox";
            this.descripcion_EnfermedadTextBox.Size = new System.Drawing.Size(324, 20);
            this.descripcion_EnfermedadTextBox.TabIndex = 14;
            // 
            // id_EnfermedadNumericUpDown
            // 
            this.id_EnfermedadNumericUpDown.Enabled = false;
            this.id_EnfermedadNumericUpDown.Location = new System.Drawing.Point(91, 14);
            this.id_EnfermedadNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_EnfermedadNumericUpDown.Name = "id_EnfermedadNumericUpDown";
            this.id_EnfermedadNumericUpDown.Size = new System.Drawing.Size(89, 20);
            this.id_EnfermedadNumericUpDown.TabIndex = 16;
            this.id_EnfermedadNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // id_Enfermedad_CategoriaNumericUpDown
            // 
            this.id_Enfermedad_CategoriaNumericUpDown.Enabled = false;
            this.id_Enfermedad_CategoriaNumericUpDown.Location = new System.Drawing.Point(91, 40);
            this.id_Enfermedad_CategoriaNumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.id_Enfermedad_CategoriaNumericUpDown.Name = "id_Enfermedad_CategoriaNumericUpDown";
            this.id_Enfermedad_CategoriaNumericUpDown.Size = new System.Drawing.Size(89, 20);
            this.id_Enfermedad_CategoriaNumericUpDown.TabIndex = 18;
            this.id_Enfermedad_CategoriaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // observaciones_EnfermedadTextBox
            // 
            this.observaciones_EnfermedadTextBox.Location = new System.Drawing.Point(91, 118);
            this.observaciones_EnfermedadTextBox.Multiline = true;
            this.observaciones_EnfermedadTextBox.Name = "observaciones_EnfermedadTextBox";
            this.observaciones_EnfermedadTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.observaciones_EnfermedadTextBox.Size = new System.Drawing.Size(324, 165);
            this.observaciones_EnfermedadTextBox.TabIndex = 20;
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
            // FrmEnfermedadesABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(442, 352);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnfermedadesABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Editar Enfermedad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEnfermedadesABM_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_EnfermedadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_Enfermedad_CategoriaNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codigo_EnfermedadTextBox;
        private System.Windows.Forms.TextBox descripcion_EnfermedadTextBox;
        private System.Windows.Forms.NumericUpDown id_EnfermedadNumericUpDown;
        private System.Windows.Forms.NumericUpDown id_Enfermedad_CategoriaNumericUpDown;
        private System.Windows.Forms.TextBox observaciones_EnfermedadTextBox;
        private System.Windows.Forms.TextBox Txt_NombreCategoria;
        private System.Windows.Forms.Button Btn_BuscarCategoria;
    }
}