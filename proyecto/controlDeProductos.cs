using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class controlDeProductos : UserControl
    {
        private int indice = 0;
        public controlDeProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
            Limpiar();
        }

        private void Agregar()
        {
            indice = tablaDatos.Rows.Add();

            tablaDatos.Rows[indice].Cells[0].Value = textID.Text;
            tablaDatos.Rows[indice].Cells[1].Value = textCodigoBarras.Text;
            tablaDatos.Rows[indice].Cells[2].Value = textProducto.Text;
            tablaDatos.Rows[indice].Cells[3].Value = textDescripcion.Text;
            tablaDatos.Rows[indice].Cells[4].Value = textCategoria.Text;
            tablaDatos.Rows[indice].Cells[5].Value = textCantidad.Text;
            tablaDatos.Rows[indice].Cells[6].Value = textPrecioCompra.Text;
            tablaDatos.Rows[indice].Cells[7].Value = textPrecioVenta.Text;
            tablaDatos.Rows[indice].Cells[8].Value = checkBoxProducto.Checked;
            tablaDatos.Rows[indice].Cells[9].Value = textFechaRegistro.Text;
        }
        private void Limpiar()
        {
            textID.Text = "";
            textCodigoBarras.Text = "";
            textProducto.Text = "";
            textDescripcion.Text = "";
            textCategoria.Text = "";
            textCantidad.Text = "";
            textPrecioCompra.Text = "";
            textPrecioVenta.Text = "";
            checkBoxProducto.Checked = false;
            textFechaRegistro.Text = "";
        }

        private void tablaDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indice!=-1)
            {
                tablaDatos.Rows.RemoveAt(indice);
            }
        }
    }
}
