﻿namespace Consultorio.MDI
{
    partial class FrmCarteraCheques
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_CantidadRegistros = new System.Windows.Forms.TextBox();
            this.Txt_CreditoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DT_Hasta = new System.Windows.Forms.DateTimePicker();
            this.DT_Desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.ImgIcono = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Txt_CantidadRegistros);
            this.groupBox3.Controls.Add(this.Txt_CreditoTotal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(8, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 50);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Credito total:";
            // 
            // Txt_CantidadRegistros
            // 
            this.Txt_CantidadRegistros.Enabled = false;
            this.Txt_CantidadRegistros.Location = new System.Drawing.Point(123, 17);
            this.Txt_CantidadRegistros.Name = "Txt_CantidadRegistros";
            this.Txt_CantidadRegistros.Size = new System.Drawing.Size(61, 20);
            this.Txt_CantidadRegistros.TabIndex = 2;
            this.Txt_CantidadRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Txt_CreditoTotal
            // 
            this.Txt_CreditoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_CreditoTotal.Enabled = false;
            this.Txt_CreditoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CreditoTotal.Location = new System.Drawing.Point(601, 12);
            this.Txt_CreditoTotal.Name = "Txt_CreditoTotal";
            this.Txt_CreditoTotal.Size = new System.Drawing.Size(129, 26);
            this.Txt_CreditoTotal.TabIndex = 1;
            this.Txt_CreditoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad de registros:";
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Aceptar.AutoSize = true;
            this.Btn_Aceptar.Image = global::Consultorio.Properties.Resources._1318513485_Check;
            this.Btn_Aceptar.Location = new System.Drawing.Point(558, 371);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 46;
            this.Btn_Aceptar.Text = "Aceptar";
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
            this.Btn_Cancelar.Location = new System.Drawing.Point(650, 371);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 45;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DG_Datos);
            this.groupBox2.Location = new System.Drawing.Point(5, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 176);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // DG_Datos
            // 
            this.DG_Datos.AllowUserToAddRows = false;
            this.DG_Datos.AllowUserToDeleteRows = false;
            this.DG_Datos.AllowUserToOrderColumns = true;
            this.DG_Datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG_Datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_Datos.Location = new System.Drawing.Point(3, 16);
            this.DG_Datos.MultiSelect = false;
            this.DG_Datos.Name = "DG_Datos";
            this.DG_Datos.ReadOnly = true;
            this.DG_Datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG_Datos.Size = new System.Drawing.Size(730, 157);
            this.DG_Datos.TabIndex = 0;
            this.DG_Datos.Click += new System.EventHandler(this.DG_Datos_Click);
            this.DG_Datos.DoubleClick += new System.EventHandler(this.DG_Datos_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DT_Hasta);
            this.groupBox1.Controls.Add(this.DT_Desde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(139, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 128);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desde:";
            // 
            // DT_Hasta
            // 
            this.DT_Hasta.Location = new System.Drawing.Point(315, 40);
            this.DT_Hasta.Name = "DT_Hasta";
            this.DT_Hasta.Size = new System.Drawing.Size(200, 20);
            this.DT_Hasta.TabIndex = 6;
            // 
            // DT_Desde
            // 
            this.DT_Desde.Location = new System.Drawing.Point(59, 40);
            this.DT_Desde.Name = "DT_Desde";
            this.DT_Desde.Size = new System.Drawing.Size(200, 20);
            this.DT_Desde.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Location = new System.Drawing.Point(59, 13);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(73, 20);
            this.Txt_Id.TabIndex = 3;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.AutoSize = true;
            this.Btn_Buscar.Image = global::Consultorio.Properties.Resources._1318513582_Search;
            this.Btn_Buscar.Location = new System.Drawing.Point(514, 84);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(82, 38);
            this.Btn_Buscar.TabIndex = 2;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // ImgIcono
            // 
            this.ImgIcono.BackColor = System.Drawing.Color.Transparent;
            this.ImgIcono.BackgroundImage = global::Consultorio.Properties.Resources._1318514988_folder_with_file;
            this.ImgIcono.Location = new System.Drawing.Point(5, 5);
            this.ImgIcono.Name = "ImgIcono";
            this.ImgIcono.Size = new System.Drawing.Size(128, 128);
            this.ImgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgIcono.TabIndex = 42;
            this.ImgIcono.TabStop = false;
            // 
            // FrmCarteraCheques
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(746, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImgIcono);
            this.Name = "FrmCarteraCheques";
            this.ShowIcon = false;
            this.Text = "Cartera de cheques";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCarteraCheque_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_CantidadRegistros;
        private System.Windows.Forms.TextBox Txt_CreditoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DT_Hasta;
        private System.Windows.Forms.DateTimePicker DT_Desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.PictureBox ImgIcono;
    }
}