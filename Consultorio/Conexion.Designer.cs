namespace Consultorio
{
    partial class Conexion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_BuscarCarpeta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CarpetaImagenes = new System.Windows.Forms.TextBox();
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
            this.Btn_ProbarConexion = new System.Windows.Forms.Button();
            this.BuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.ToolTipsText = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_BuscarCarpeta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_CarpetaImagenes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Txt_Contraseña);
            this.groupBox1.Controls.Add(this.Txt_Usuario);
            this.groupBox1.Controls.Add(this.Txt_DB);
            this.groupBox1.Controls.Add(this.Txt_Servidor);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del servidor";
            // 
            // Btn_BuscarCarpeta
            // 
            this.Btn_BuscarCarpeta.Location = new System.Drawing.Point(233, 123);
            this.Btn_BuscarCarpeta.Name = "Btn_BuscarCarpeta";
            this.Btn_BuscarCarpeta.Size = new System.Drawing.Size(23, 20);
            this.Btn_BuscarCarpeta.TabIndex = 10;
            this.Btn_BuscarCarpeta.Text = "...";
            this.ToolTipsText.SetToolTip(this.Btn_BuscarCarpeta, "Buscar la carpeta para el servidor de imagenes.");
            this.Btn_BuscarCarpeta.UseVisualStyleBackColor = true;
            this.Btn_BuscarCarpeta.Click += new System.EventHandler(this.Btn_BuscarCarpeta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Car. imagenes:";
            // 
            // Txt_CarpetaImagenes
            // 
            this.Txt_CarpetaImagenes.Location = new System.Drawing.Point(95, 123);
            this.Txt_CarpetaImagenes.Name = "Txt_CarpetaImagenes";
            this.Txt_CarpetaImagenes.Size = new System.Drawing.Size(132, 20);
            this.Txt_CarpetaImagenes.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base de datos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Servidor:";
            // 
            // Txt_Contraseña
            // 
            this.Txt_Contraseña.Location = new System.Drawing.Point(94, 97);
            this.Txt_Contraseña.Name = "Txt_Contraseña";
            this.Txt_Contraseña.PasswordChar = '*';
            this.Txt_Contraseña.Size = new System.Drawing.Size(162, 20);
            this.Txt_Contraseña.TabIndex = 3;
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(94, 71);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(162, 20);
            this.Txt_Usuario.TabIndex = 2;
            // 
            // Txt_DB
            // 
            this.Txt_DB.Location = new System.Drawing.Point(94, 45);
            this.Txt_DB.Name = "Txt_DB";
            this.Txt_DB.Size = new System.Drawing.Size(162, 20);
            this.Txt_DB.TabIndex = 1;
            // 
            // Txt_Servidor
            // 
            this.Txt_Servidor.Location = new System.Drawing.Point(94, 19);
            this.Txt_Servidor.Name = "Txt_Servidor";
            this.Txt_Servidor.Size = new System.Drawing.Size(162, 20);
            this.Txt_Servidor.TabIndex = 0;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Location = new System.Drawing.Point(131, 159);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(68, 35);
            this.Btn_Aceptar.TabIndex = 1;
            this.Btn_Aceptar.Text = "Aceptar";
            this.ToolTipsText.SetToolTip(this.Btn_Aceptar, "Establecer estos valores de conección para el sistema, para cambiarlos se tiene q" +
                    "ue borrar el archivo de conección (Conección.cnn)");
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Location = new System.Drawing.Point(205, 159);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(68, 35);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.ToolTipsText.SetToolTip(this.Btn_Cancelar, "Cerrar esta ventana.");
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_ProbarConexion
            // 
            this.Btn_ProbarConexion.Location = new System.Drawing.Point(7, 159);
            this.Btn_ProbarConexion.Name = "Btn_ProbarConexion";
            this.Btn_ProbarConexion.Size = new System.Drawing.Size(118, 35);
            this.Btn_ProbarConexion.TabIndex = 3;
            this.Btn_ProbarConexion.Text = "Probar conexión";
            this.ToolTipsText.SetToolTip(this.Btn_ProbarConexion, "Probar la conección con el servidor.");
            this.Btn_ProbarConexion.UseVisualStyleBackColor = true;
            this.Btn_ProbarConexion.Click += new System.EventHandler(this.Btn_ProbarConexion_Click);
            // 
            // Conexion
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(282, 200);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_ProbarConexion);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(298, 238);
            this.MinimumSize = new System.Drawing.Size(298, 238);
            this.Name = "Conexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión";
            this.Load += new System.EventHandler(this.Conexion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Contraseña;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.TextBox Txt_DB;
        private System.Windows.Forms.TextBox Txt_Servidor;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_ProbarConexion;
        private System.Windows.Forms.Button Btn_BuscarCarpeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_CarpetaImagenes;
        private System.Windows.Forms.FolderBrowserDialog BuscarCarpeta;
        private System.Windows.Forms.ToolTip ToolTipsText;
    }
}