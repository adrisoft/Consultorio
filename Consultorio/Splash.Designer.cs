namespace Consultorio
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Progreso = new System.Windows.Forms.ProgressBar();
            this.Lbl_Cargando = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Progreso
            // 
            this.Progreso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progreso.Location = new System.Drawing.Point(0, 356);
            this.Progreso.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Progreso.Maximum = 200;
            this.Progreso.Name = "Progreso";
            this.Progreso.Size = new System.Drawing.Size(996, 19);
            this.Progreso.TabIndex = 0;
            // 
            // Lbl_Cargando
            // 
            this.Lbl_Cargando.AutoSize = true;
            this.Lbl_Cargando.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cargando.Location = new System.Drawing.Point(6, 329);
            this.Lbl_Cargando.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Lbl_Cargando.Name = "Lbl_Cargando";
            this.Lbl_Cargando.Size = new System.Drawing.Size(70, 25);
            this.Lbl_Cargando.TabIndex = 1;
            this.Lbl_Cargando.Text = "label1";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Consultorio.Properties.Resources.fondo_consultorio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 375);
            this.Controls.Add(this.Lbl_Cargando);
            this.Controls.Add(this.Progreso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Software";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar Progreso;
        private System.Windows.Forms.Label Lbl_Cargando;
    }
}