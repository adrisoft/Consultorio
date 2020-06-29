namespace Consultorio.MDI
{
    partial class FrmTercero
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
            this.Btn_Baja = new System.Windows.Forms.Button();
            this.Btn_Alta = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_SaldoTotal = new System.Windows.Forms.TextBox();
            this.Txt_CantidadRegistros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DG_Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.razon_social_textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.ImgIcono = new System.Windows.Forms.PictureBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Baja
            // 
            this.Btn_Baja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Baja.AutoSize = true;
            this.Btn_Baja.Image = global::Consultorio.Properties.Resources._1318513493_Stock_Index_Down;
            this.Btn_Baja.Location = new System.Drawing.Point(178, 368);
            this.Btn_Baja.Name = "Btn_Baja";
            this.Btn_Baja.Size = new System.Drawing.Size(105, 38);
            this.Btn_Baja.TabIndex = 56;
            this.Btn_Baja.Text = "Dar de Baja";
            this.Btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Baja.UseVisualStyleBackColor = true;
            this.Btn_Baja.Click += new System.EventHandler(this.Btn_Baja_Click);
            // 
            // Btn_Alta
            // 
            this.Btn_Alta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Alta.AutoSize = true;
            this.Btn_Alta.Image = global::Consultorio.Properties.Resources._1318513503_Stock_Index_Up;
            this.Btn_Alta.Location = new System.Drawing.Point(71, 368);
            this.Btn_Alta.Name = "Btn_Alta";
            this.Btn_Alta.Size = new System.Drawing.Size(101, 38);
            this.Btn_Alta.TabIndex = 55;
            this.Btn_Alta.Text = "Dar de alta";
            this.Btn_Alta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Alta.UseVisualStyleBackColor = true;
            this.Btn_Alta.Click += new System.EventHandler(this.Btn_Alta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Txt_SaldoTotal);
            this.groupBox3.Controls.Add(this.Txt_CantidadRegistros);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(5, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 50);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(528, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saldo total:";
            this.label5.Visible = false;
            // 
            // Txt_SaldoTotal
            // 
            this.Txt_SaldoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_SaldoTotal.Enabled = false;
            this.Txt_SaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SaldoTotal.Location = new System.Drawing.Point(600, 17);
            this.Txt_SaldoTotal.Name = "Txt_SaldoTotal";
            this.Txt_SaldoTotal.Size = new System.Drawing.Size(129, 26);
            this.Txt_SaldoTotal.TabIndex = 6;
            this.Txt_SaldoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Txt_SaldoTotal.Visible = false;
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
            this.Btn_Aceptar.Location = new System.Drawing.Point(380, 368);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Aceptar.TabIndex = 53;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Editar.AutoSize = true;
            this.Btn_Editar.Image = global::Consultorio.Properties.Resources._1318513465_Edit;
            this.Btn_Editar.Location = new System.Drawing.Point(564, 368);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(80, 38);
            this.Btn_Editar.TabIndex = 52;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Agregar.AutoSize = true;
            this.Btn_Agregar.Image = global::Consultorio.Properties.Resources._1318513498_Add;
            this.Btn_Agregar.Location = new System.Drawing.Point(472, 368);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(86, 38);
            this.Btn_Agregar.TabIndex = 51;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cancelar.AutoSize = true;
            this.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Cancelar.Image = global::Consultorio.Properties.Resources._1318513490_Log_Out;
            this.Btn_Cancelar.Location = new System.Drawing.Point(650, 368);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(91, 38);
            this.Btn_Cancelar.TabIndex = 50;
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
            this.groupBox2.Size = new System.Drawing.Size(736, 174);
            this.groupBox2.TabIndex = 49;
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
            this.DG_Datos.Size = new System.Drawing.Size(730, 155);
            this.DG_Datos.TabIndex = 0;
            this.DG_Datos.Click += new System.EventHandler(this.DG_Datos_Click);
            this.DG_Datos.DoubleClick += new System.EventHandler(this.DG_Datos_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.razon_social_textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Id);
            this.groupBox1.Controls.Add(this.Btn_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(139, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 128);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // razon_social_textBox1
            // 
            this.razon_social_textBox1.Location = new System.Drawing.Point(83, 39);
            this.razon_social_textBox1.Name = "razon_social_textBox1";
            this.razon_social_textBox1.Size = new System.Drawing.Size(207, 20);
            this.razon_social_textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Razon social:";
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
            this.Txt_Id.Location = new System.Drawing.Point(83, 13);
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
            this.ImgIcono.Image = global::Consultorio.Properties.Resources._1318511950_users;
            this.ImgIcono.Location = new System.Drawing.Point(33, 35);
            this.ImgIcono.Name = "ImgIcono";
            this.ImgIcono.Size = new System.Drawing.Size(64, 64);
            this.ImgIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImgIcono.TabIndex = 47;
            this.ImgIcono.TabStop = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.AutoSize = true;
            this.Btn_Eliminar.Image = global::Consultorio.Properties.Resources._1318513481_Delete;
            this.Btn_Eliminar.Location = new System.Drawing.Point(289, 368);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(85, 38);
            this.Btn_Eliminar.TabIndex = 58;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // FrmTercero
            // 
            this.AcceptButton = this.Btn_Buscar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.Btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(746, 418);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Baja);
            this.Controls.Add(this.Btn_Alta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ImgIcono);
            this.Name = "FrmTercero";
            this.ShowIcon = false;
            this.Text = "FrmTercero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTercero_Load_1);
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

        private System.Windows.Forms.Button Btn_Baja;
        private System.Windows.Forms.Button Btn_Alta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_SaldoTotal;
        private System.Windows.Forms.TextBox Txt_CantidadRegistros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DG_Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.PictureBox ImgIcono;
        private System.Windows.Forms.TextBox razon_social_textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Eliminar;
    }
}