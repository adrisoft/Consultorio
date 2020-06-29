namespace Consultorio.MDI
{
    partial class FrmProvinciaABM
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
            System.Windows.Forms.Label id_PaisLabel;
            System.Windows.Forms.Label nombreLabel;
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_NombrePais = new System.Windows.Forms.TextBox();
            this.Btn_BuscarPais = new System.Windows.Forms.Button();
            this.id_PaisTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.ProvError = new System.Windows.Forms.ErrorProvider(this.components);
            id_PaisLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).BeginInit();
            this.SuspendLayout();
            // 
            // id_PaisLabel
            // 
            id_PaisLabel.AutoSize = true;
            id_PaisLabel.Location = new System.Drawing.Point(6, 42);
            id_PaisLabel.Name = "id_PaisLabel";
            id_PaisLabel.Size = new System.Drawing.Size(42, 13);
            id_PaisLabel.TabIndex = 11;
            id_PaisLabel.Text = "Id Pais:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(6, 68);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(180, 111);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 60;
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(272, 111);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 59;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_NombrePais);
            this.groupBox1.Controls.Add(this.Btn_BuscarPais);
            this.groupBox1.Controls.Add(id_PaisLabel);
            this.groupBox1.Controls.Add(this.id_PaisTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 93);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Txt_NombrePais
            // 
            this.Txt_NombrePais.Enabled = false;
            this.Txt_NombrePais.Location = new System.Drawing.Point(170, 40);
            this.Txt_NombrePais.Name = "Txt_NombrePais";
            this.Txt_NombrePais.Size = new System.Drawing.Size(156, 20);
            this.Txt_NombrePais.TabIndex = 16;
            // 
            // Btn_BuscarPais
            // 
            this.Btn_BuscarPais.AutoSize = true;
            this.Btn_BuscarPais.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarPais.Location = new System.Drawing.Point(138, 39);
            this.Btn_BuscarPais.Name = "Btn_BuscarPais";
            this.Btn_BuscarPais.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarPais.TabIndex = 15;
            this.Btn_BuscarPais.UseVisualStyleBackColor = true;
            this.Btn_BuscarPais.Click += new System.EventHandler(this.Btn_BuscarPais_Click);
            // 
            // id_PaisTextBox
            // 
            this.id_PaisTextBox.Enabled = false;
            this.id_PaisTextBox.Location = new System.Drawing.Point(59, 39);
            this.id_PaisTextBox.Name = "id_PaisTextBox";
            this.id_PaisTextBox.Size = new System.Drawing.Size(73, 20);
            this.id_PaisTextBox.TabIndex = 12;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(59, 65);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(267, 20);
            this.nombreTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(59, 13);
            this.Txt_Id.MaxLength = 6;
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(73, 20);
            this.Txt_Id.TabIndex = 9;
            this.Txt_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ProvError
            // 
            this.ProvError.ContainerControl = this;
            // 
            // FrmProvinciaABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(377, 158);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 196);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 196);
            this.Name = "FrmProvinciaABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Modificar Provincia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProvinciaABM_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_NombrePais;
        private System.Windows.Forms.Button Btn_BuscarPais;
        private System.Windows.Forms.TextBox id_PaisTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.ErrorProvider ProvError;
    }
}