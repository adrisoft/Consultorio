namespace Consultorio.MDI
{
    partial class FrmBackup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Contraseña = new System.Windows.Forms.TextBox();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.Txt_DB = new System.Windows.Forms.TextBox();
            this.Txt_Servidor = new System.Windows.Forms.TextBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.SaveDialogo = new System.Windows.Forms.SaveFileDialog();
            this.Btn_ProbarConexion = new System.Windows.Forms.Button();
            this.Btn_Restablecer = new System.Windows.Forms.Button();
            this.OpenDialogo = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Contraseña);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Controls.Add(this.Txt_DB);
            this.groupBox1.Controls.Add(this.Txt_Servidor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del servidor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Base de datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servidor:";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(90, 95);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.Size = new System.Drawing.Size(321, 20);
            this.Txt_Contraseña.TabIndex = 11;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(90, 69);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(321, 20);
            this.Txt_Usuario.TabIndex = 10;
            // 
            // Txt_DB
            // 
            this.Txt_DB.Location = new System.Drawing.Point(90, 43);
            this.Txt_DB.Name = "Txt_DB";
            this.Txt_DB.Size = new System.Drawing.Size(321, 20);
            this.Txt_DB.TabIndex = 9;
            // 
            // Txt_Servidor
            // 
            this.Txt_Servidor.Location = new System.Drawing.Point(90, 17);
            this.Txt_Servidor.Name = "Txt_Servidor";
            this.Txt_Servidor.Size = new System.Drawing.Size(321, 20);
            this.Txt_Servidor.TabIndex = 8;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Location = new System.Drawing.Point(231, 150);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(94, 38);
            this.Btn_Aceptar.TabIndex = 61;
            this.Btn_Aceptar.Text = "Guardar DB";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(340, 150);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 38);
            this.Btn_Cancelar.TabIndex = 60;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_ProbarConexion
            // 
            this.Btn_ProbarConexion.Location = new System.Drawing.Point(13, 150);
            this.Btn_ProbarConexion.Name = "Btn_ProbarConexion";
            this.Btn_ProbarConexion.Size = new System.Drawing.Size(94, 38);
            this.Btn_ProbarConexion.TabIndex = 62;
            this.Btn_ProbarConexion.Text = "Probar conexión";
            this.Btn_ProbarConexion.UseVisualStyleBackColor = true;
            this.Btn_ProbarConexion.Click += new System.EventHandler(this.Btn_ProbarConexion_Click);
            // 
            // Btn_Restablecer
            // 
            this.Btn_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Restablecer.AutoSize = true;
            this.Btn_Restablecer.Location = new System.Drawing.Point(122, 150);
            this.Btn_Restablecer.Name = "Btn_Restablecer";
            this.Btn_Restablecer.Size = new System.Drawing.Size(94, 38);
            this.Btn_Restablecer.TabIndex = 63;
            this.Btn_Restablecer.Text = "Restaurar BD";
            this.Btn_Restablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Restablecer.UseVisualStyleBackColor = true;
            this.Btn_Restablecer.Click += new System.EventHandler(this.Btn_Restablecer_Click);
            // 
            // OpenDialogo
            // 
            this.OpenDialogo.FileName = "openFileDialog1";
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 200);
            this.Controls.Add(this.Btn_Restablecer);
            this.Controls.Add(this.Btn_ProbarConexion);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackup";
            this.ShowIcon = false;
            this.Text = "Backup de base de datos";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_DB;
        private System.Windows.Forms.TextBox Txt_Servidor;
        private System.Windows.Forms.SaveFileDialog SaveDialogo;
        private System.Windows.Forms.Button Btn_ProbarConexion;
        private System.Windows.Forms.Button Btn_Restablecer;
        private System.Windows.Forms.OpenFileDialog OpenDialogo;
    }
}