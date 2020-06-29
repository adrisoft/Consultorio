using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consultorio.MDI
{
    public partial class FrmEnfermedadesABM : Form
    {
        bool CerrarVentana = false;

        public FrmEnfermedadesABM()
        {
            InitializeComponent();
        }

        public FrmEnfermedadesABM(string IdEnfermedad)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Enfermedad E = Datos.Enfermedad.GetEnfermedadRelacional(IdEnfermedad,"","").ListaEnfermedad[0];

                id_EnfermedadNumericUpDown.Value = E.Id_Enfermedad;
                id_Enfermedad_CategoriaNumericUpDown.Value = E.Id_Enfermedad_Categoria;
                Txt_NombreCategoria.Text = E.Enfermedad_categoria.Descripcion_Enfermedad_Categoria;
                codigo_EnfermedadTextBox.Text = E.Codigo_Enfermedad;
                descripcion_EnfermedadTextBox.Text = E.Descripcion_Enfermedad;
                observaciones_EnfermedadTextBox.Text = E.Observaciones_Enfermedad;
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos.Enfermedad E = new Datos.Enfermedad();

                E.Id_Enfermedad = (int)id_EnfermedadNumericUpDown.Value;
                E.Id_Enfermedad_Categoria = (int)id_Enfermedad_CategoriaNumericUpDown.Value;
                E.Codigo_Enfermedad = codigo_EnfermedadTextBox.Text;
                E.Descripcion_Enfermedad = descripcion_EnfermedadTextBox.Text;
                E.Observaciones_Enfermedad = observaciones_EnfermedadTextBox.Text;

                if (id_EnfermedadNumericUpDown.Value == 0)
                {
                    Datos.Enfermedad.Add(E);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Enfermedad.Set(E);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                CerrarVentana = true;
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            CerrarVentana = true;
            Close();
        }

        private void Btn_BuscarCategoria_Click(object sender, EventArgs e)
        {
            MDI.FrmEnfermedadesCategorias FrmP = new MDI.FrmEnfermedadesCategorias();
            FrmP.ShowDialog();
            if (MDI.FrmEnfermedadesCategorias.ValorReturn != "")
            {
                id_Enfermedad_CategoriaNumericUpDown.Value = Convert.ToInt32(MDI.FrmEnfermedadesCategorias.ValorReturn);
                Txt_NombreCategoria.Text = Datos.Enfermedad_categoria.GetEnfermedad_categoria(id_Enfermedad_CategoriaNumericUpDown.Value.ToString(),"","").ListaEnfermedad_categoria[0].Descripcion_Enfermedad_Categoria;
            }
        }

        private void FrmEnfermedadesABM_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CerrarVentana;
        }
    }
}
