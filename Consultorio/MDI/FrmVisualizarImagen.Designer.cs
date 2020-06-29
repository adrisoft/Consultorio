namespace Consultorio.MDI
{
    partial class FrmVisualizarImagen
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
            this.CuadroImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // CuadroImagen
            // 
            this.CuadroImagen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CuadroImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CuadroImagen.Location = new System.Drawing.Point(0, 0);
            this.CuadroImagen.Name = "CuadroImagen";
            this.CuadroImagen.Size = new System.Drawing.Size(284, 262);
            this.CuadroImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CuadroImagen.TabIndex = 0;
            this.CuadroImagen.TabStop = false;
            this.CuadroImagen.Click += new System.EventHandler(this.CuadroImagen_Click);
            // 
            // FrmVisualizarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CuadroImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizarImagen";
            this.ShowIcon = false;
            this.Text = "Visualizador de imagenes - Consultorio Software";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CuadroImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CuadroImagen;
    }
}