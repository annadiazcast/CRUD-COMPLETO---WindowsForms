using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_COMPLETO___WindowsForms
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();

        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = acc.MostrarAutos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarAuto(Convert.ToInt32(txtMatricula.Text)))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.InsertarAuto(Convert.ToInt32(txtMatricula.Text),txtMarca.Text, txtModelo.Text, Convert.ToInt32(txtAnio.Text),txtColor.Text))
                MessageBox.Show("Agregado con exito");

            else
                MessageBox.Show("Fallo al agregado");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarAuto(Convert.ToInt32(txtMatricula.Text),txtMarca.Text,txtModelo.Text,Convert.ToInt32(txtAnio.Text),txtColor.Text))
            {
                MessageBox.Show("Actualizado con éxito");
                dgDatos.DataSource = null;
                dgDatos.DataSource = acc.MostrarAutos();
            }
            else
            {
                MessageBox.Show("Fallo al actualizar");
            }
        }
    }
}
