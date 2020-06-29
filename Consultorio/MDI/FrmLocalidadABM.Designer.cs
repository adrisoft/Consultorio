namespace Consultorio.MDI
{
    partial class FrmLocalidadABM
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
            System.Windows.Forms.Label codigo_PostalLabel;
            System.Windows.Forms.Label id_ProvinciaLabel;
            System.Windows.Forms.Label nombreLabel;
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_NombreProvincia = new System.Windows.Forms.TextBox();
            this.Btn_BuscarProvincia = new System.Windows.Forms.Button();
            this.codigo_PostalTextBox = new System.Windows.Forms.TextBox();
            this.id_ProvinciaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.ProvError = new System.Windows.Forms.ErrorProvider(this.components);
            codigo_PostalLabel = new System.Windows.Forms.Label();
            id_ProvinciaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvError)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo_PostalLabel
            // 
            codigo_PostalLabel.AutoSize = true;
            codigo_PostalLabel.Location = new System.Drawing.Point(7, 70);
            codigo_PostalLabel.Name = "codigo_PostalLabel";
            codigo_PostalLabel.Size = new System.Drawing.Size(74, 13);
            codigo_PostalLabel.TabIndex = 27;
            codigo_PostalLabel.Text = "Código postal:";
            // 
            // id_ProvinciaLabel
            // 
            id_ProvinciaLabel.AutoSize = true;
            id_ProvinciaLabel.Location = new System.Drawing.Point(7, 96);
            id_ProvinciaLabel.Name = "id_ProvinciaLabel";
            id_ProvinciaLabel.Size = new System.Drawing.Size(54, 13);
            id_ProvinciaLabel.TabIndex = 31;
            id_ProvinciaLabel.Text = "Provincia:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(7, 44);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 37;
            nombreLabel.Text = "Nombre:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(207, 142);
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(299, 142);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 53;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_NombreProvincia);
            this.groupBox1.Controls.Add(this.Btn_BuscarProvincia);
            this.groupBox1.Controls.Add(codigo_PostalLabel);
            this.groupBox1.Controls.Add(this.codigo_PostalTextBox);
            this.groupBox1.Controls.Add(id_ProvinciaLabel);
            this.groupBox1.Controls.Add(this.id_ProvinciaTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 124);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Txt_NombreProvincia
            // 
            this.Txt_NombreProvincia.Enabled = false;
            this.Txt_NombreProvincia.Location = new System.Drawing.Point(178, 93);
            this.Txt_NombreProvincia.Name = "Txt_NombreProvincia";
            this.Txt_NombreProvincia.Size = new System.Drawing.Size(170, 20);
            this.Txt_NombreProvincia.TabIndex = 42;
            // 
            // Btn_BuscarProvincia
            // 
            this.Btn_BuscarProvincia.AutoSize = true;
            this.Btn_BuscarProvincia.Image = global::Consultorio.Properties.Resources.mini_search;
            this.Btn_BuscarProvincia.Location = new System.Drawing.Point(146, 93);
            this.Btn_BuscarProvincia.Name = "Btn_BuscarProvincia";
            this.Btn_BuscarProvincia.Size = new System.Drawing.Size(26, 22);
            this.Btn_BuscarProvincia.TabIndex = 41;
            this.Btn_BuscarProvincia.UseVisualStyleBackColor = true;
            this.Btn_BuscarProvincia.Click += new System.EventHandler(this.Btn_BuscarProvincia_Click);
            // 
            // codigo_PostalTextBox
            // 
            this.codigo_PostalTextBox.Location = new System.Drawing.Point(101, 67);
            this.codigo_PostalTextBox.Name = "codigo_PostalTextBox";
            this.codigo_PostalTextBox.Size = new System.Drawing.Size(247, 20);
            this.codigo_PostalTextBox.TabIndex = 28;
            // 
            // id_ProvinciaTextBox
            // 
            this.id_ProvinciaTextBox.Enabled = false;
            this.id_ProvinciaTextBox.Location = new System.Drawing.Point(101, 93);
            this.id_ProvinciaTextBox.Name = "id_ProvinciaTextBox";
            this.id_ProvinciaTextBox.Size = new System.Drawing.Size(39, 20);
            this.id_ProvinciaTextBox.TabIndex = 32;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(101, 41);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(247, 20);
            this.nombreTextBox.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(101, 15);
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
            // FrmLocalidadABM
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(402, 187);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalidadABM";
            this.ShowIcon = false;
            this.Text = "Nuevo/Modificar Localidad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLocalidadABM_FormClosing);
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
        private System.Windows.Forms.TextBox Txt_NombreProvincia;
        private System.Windows.Forms.Button Btn_BuscarProvincia;
        private System.Windows.Forms.TextBox codigo_PostalTextBox;
        private System.Windows.Forms.TextBox id_ProvinciaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.ErrorProvider ProvError;
    }
}