namespace Consultorio.MDI
{
    partial class FrmDialogoFactura
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Lbl_Msj = new System.Windows.Forms.Label();
            this.Temporisador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(97, 110);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 52;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.AutoSize = true;
            this.Btn_Eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Eliminar.Image = global::Consultorio.Properties.Resources._1318513481_Delete;
            this.Btn_Eliminar.Location = new System.Drawing.Point(200, 110);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Eliminar.TabIndex = 51;
            this.Btn_Eliminar.Text = "Cancelar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Lbl_Msj
            // 
            this.Lbl_Msj.AutoSize = true;
            this.Lbl_Msj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Msj.Location = new System.Drawing.Point(4, 48);
            this.Lbl_Msj.Name = "Lbl_Msj";
            this.Lbl_Msj.Size = new System.Drawing.Size(380, 15);
            this.Lbl_Msj.TabIndex = 53;
            this.Lbl_Msj.Text = "¿Esta seguro que el número de comprobante es X 0000-00000000?";
            // 
            // Temporisador
            // 
            this.Temporisador.Enabled = true;
            this.Temporisador.Interval = 1000;
            this.Temporisador.Tick += new System.EventHandler(this.Temporisador_Tick);
            // 
            // FrmDialogoFactura
            // 
            this.AcceptButton = this.Btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Eliminar;
            this.ClientSize = new System.Drawing.Size(388, 160);
            this.Controls.Add(this.Lbl_Msj);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Eliminar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 198);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 198);
            this.Name = "FrmDialogoFactura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Número de factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label Lbl_Msj;
        private System.Windows.Forms.Timer Temporisador;
    }
}