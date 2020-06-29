namespace Consultorio.MDI
{
    partial class FrmVistaPrevia
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
            this.VistaPrevia = new System.Windows.Forms.PrintPreviewControl();
            this.SuspendLayout();
            // 
            // VistaPrevia
            // 
            this.VistaPrevia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VistaPrevia.Location = new System.Drawing.Point(0, 0);
            this.VistaPrevia.Name = "VistaPrevia";
            this.VistaPrevia.Size = new System.Drawing.Size(284, 262);
            this.VistaPrevia.TabIndex = 0;
            this.VistaPrevia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.VistaPrevia_MouseClick);
            // 
            // FrmVistaPrevia
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.VistaPrevia);
            this.Name = "FrmVistaPrevia";
            this.ShowIcon = false;
            this.Text = "Vista previa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PrintPreviewControl VistaPrevia;

    }
}