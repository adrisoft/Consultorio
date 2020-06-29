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
    public partial class FrmEnfermedadesCategoriasABM : Form
    {
        public FrmEnfermedadesCategoriasABM()
        {
            InitializeComponent();
        }

        public FrmEnfermedadesCategoriasABM(string IdEnfermedadCategoria)
        {
            InitializeComponent();
            try
            {
                //Busco el una unica fila por su id
                Datos.Enfermedad_categoria EC = Datos.Enfermedad_categoria.GetEnfermedad_categoria(IdEnfermedadCategoria, "", "").ListaEnfermedad_categoria[0];

                id_Enfermedad_CategoriaNumericUpDown.Value = EC.Id_Enfermedad_Categoria;
                codigo_Enfermedad_CategoriaTextBox.Text = EC.Codigo_Enfermedad_Categoria;
                descripcion_Enfermedad_CategoriaTextBox.Text = EC.Descripcion_Enfermedad_Categoria;
                observaciones_Enfermedad_CategoriaTextBox.Text = EC.Observaciones_Enfermedad_Categoria;
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
                Datos.Enfermedad_categoria EC = new Datos.Enfermedad_categoria();

                EC.Id_Enfermedad_Categoria = (int)id_Enfermedad_CategoriaNumericUpDown.Value;
                EC.Codigo_Enfermedad_Categoria = codigo_Enfermedad_CategoriaTextBox.Text;
                EC.Descripcion_Enfermedad_Categoria = descripcion_Enfermedad_CategoriaTextBox.Text;
                EC.Observaciones_Enfermedad_Categoria = observaciones_Enfermedad_CategoriaTextBox.Text;

                if (id_Enfermedad_CategoriaNumericUpDown.Value == 0)
                {
                    Datos.Enfermedad_categoria.Add(EC);
                    MessageBox.Show("Se ha agregado un nuevo registro.");
                }
                else
                {
                    Datos.Enfermedad_categoria.Set(EC);
                    MessageBox.Show("Se ha modificado correctamente el registro.");
                }
                Close();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
