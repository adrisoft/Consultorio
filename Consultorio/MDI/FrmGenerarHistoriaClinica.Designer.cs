namespace Consultorio.MDI
{
    partial class FrmGenerarHistoriaClinica
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
            this.motivo_ConsultaTextBox = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.ImprimirDocumento = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Btn_Ajustar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_VistaPrevia = new System.Windows.Forms.Button();
            this.Btn_Papel = new System.Windows.Forms.Button();
            this.Btn_Opciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // motivo_ConsultaTextBox
            // 
            this.motivo_ConsultaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.motivo_ConsultaTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motivo_ConsultaTextBox.Location = new System.Drawing.Point(12, 12);
            this.motivo_ConsultaTextBox.Multiline = true;
            this.motivo_ConsultaTextBox.Name = "motivo_ConsultaTextBox";
            this.motivo_ConsultaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.motivo_ConsultaTextBox.Size = new System.Drawing.Size(585, 280);
            this.motivo_ConsultaTextBox.TabIndex = 0;
            this.motivo_ConsultaTextBox.WordWrap = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.ImprimirDocumento;
            // 
            // ImprimirDocumento
            // 
            this.ImprimirDocumento.DocumentName = "Entrega de documentación";
            this.ImprimirDocumento.OriginAtMargins = true;
            this.ImprimirDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirDocumento_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.ImprimirDocumento;
            this.printDialog1.UseEXDialog = true;
            // 
            // Btn_Ajustar
            // 
            this.Btn_Ajustar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Ajustar.Location = new System.Drawing.Point(320, 298);
            this.Btn_Ajustar.Name = "Btn_Ajustar";
            this.Btn_Ajustar.Size = new System.Drawing.Size(84, 38);
            this.Btn_Ajustar.TabIndex = 199;
            this.Btn_Ajustar.Text = "Ajustar a A4";
            this.Btn_Ajustar.UseVisualStyleBackColor = true;
            this.Btn_Ajustar.Click += new System.EventHandler(this.Btn_Ajustar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.button1.Location = new System.Drawing.Point(511, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 38);
            this.button1.TabIndex = 198;
            this.button1.Text = "Imprimir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_VistaPrevia
            // 
            this.Btn_VistaPrevia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_VistaPrevia.Location = new System.Drawing.Point(147, 298);
            this.Btn_VistaPrevia.Name = "Btn_VistaPrevia";
            this.Btn_VistaPrevia.Size = new System.Drawing.Size(81, 38);
            this.Btn_VistaPrevia.TabIndex = 197;
            this.Btn_VistaPrevia.Text = "Vista previa";
            this.Btn_VistaPrevia.UseVisualStyleBackColor = true;
            this.Btn_VistaPrevia.Visible = false;
            this.Btn_VistaPrevia.Click += new System.EventHandler(this.Btn_VistaPrevia_Click);
            // 
            // Btn_Papel
            // 
            this.Btn_Papel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Papel.AutoSize = true;
            this.Btn_Papel.Image = global::Consultorio.Properties.Resources._1318516983_document_32;
            this.Btn_Papel.Location = new System.Drawing.Point(234, 298);
            this.Btn_Papel.Name = "Btn_Papel";
            this.Btn_Papel.Size = new System.Drawing.Size(80, 38);
            this.Btn_Papel.TabIndex = 195;
            this.Btn_Papel.Text = "Papel";
            this.Btn_Papel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Papel.UseVisualStyleBackColor = true;
            this.Btn_Papel.Visible = false;
            this.Btn_Papel.Click += new System.EventHandler(this.Btn_Papel_Click);
            // 
            // Btn_Opciones
            // 
            this.Btn_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Opciones.AutoSize = true;
            this.Btn_Opciones.Image = global::Consultorio.Properties.Resources._1318516999_document_print;
            this.Btn_Opciones.Location = new System.Drawing.Point(410, 298);
            this.Btn_Opciones.Name = "Btn_Opciones";
            this.Btn_Opciones.Size = new System.Drawing.Size(95, 38);
            this.Btn_Opciones.TabIndex = 196;
            this.Btn_Opciones.Text = "Impresora";
            this.Btn_Opciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Opciones.UseVisualStyleBackColor = true;
            this.Btn_Opciones.Click += new System.EventHandler(this.Btn_Opciones_Click);
            // 
            // FrmGenerarHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 348);
            this.Controls.Add(this.Btn_Ajustar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_VistaPrevia);
            this.Controls.Add(this.Btn_Papel);
            this.Controls.Add(this.Btn_Opciones);
            this.Controls.Add(this.motivo_ConsultaTextBox);
            this.Name = "FrmGenerarHistoriaClinica";
            this.ShowIcon = false;
            this.Text = "Historia clícnica";
            this.Load += new System.EventHandler(this.FrmGenerarHistoriaClinica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox motivo_ConsultaTextBox;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument ImprimirDocumento;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button Btn_Ajustar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_VistaPrevia;
        private System.Windows.Forms.Button Btn_Papel;
        private System.Windows.Forms.Button Btn_Opciones;
    }
}