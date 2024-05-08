using BLL_Logica_;
using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Datos_;

namespace proyecto
{
    public partial class FormListaProductos : Form
    {
        DataSet dsTabla;
        private ProductoDAL productoDAL = new ProductoDAL();
        Paginacion dq = new Paginacion();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;

        public FormListaProductos()
        {
            InitializeComponent();
            PagFinal = NumFilas;
            CargarListaProductos();
            loadproductos();

        }
        
        private void loadproductos()
        {
            dataGridView1.DataSource = productoDAL.GetAllProductos();
        } 


        private void CargarListaProductos()
        {
            
            Producto.inicioProducto = PagInicio;
            Producto.finalProducto = PagFinal;
            dsTabla = dq.ListasProductos();
            dataGridView1.DataSource = dsTabla.Tables[1];
            int catidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) catidad++;

            textCantidadPagina.Text = catidad.ToString();
            cbxPagina.Items.Clear();

            for (int x = 1; x <= catidad; x++)
            {
                cbxPagina.Items.Add(x.ToString());
            }
            cbxPagina.SelectedIndex = indice;
        }

        private void BtnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var productoID = Convert.ToInt32(selectedRow.Cells["ProductoID"].Value);

                var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    productoDAL.DeleteProducto(productoID); // Eliminar producto
                    loadproductos(); // Refrescar lista
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.");
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var productoID = Convert.ToInt32(selectedRow.Cells["ProductoID"].Value);

                var form = new FormMantProducto(productoID); // Formulario para editar producto

                form.OnSaved += (src, args) => loadproductos(); // Recargar lista
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.");
            }
        }

        private void cbxPagina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Pagina = Convert.ToInt32(cbxPagina.Text);
            indice = Pagina - 1;
            PagInicio = (Pagina - 1) * NumFilas + 1;
            PagFinal = Pagina * NumFilas;
            loadproductos();
        }





        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var form = new FormMantProducto(); // Formulario para nuevo producto

            form.OnSaved += (src, args) => loadproductos(); // Recargar lista cuando se guarde un producto
            form.ShowDialog();
        }




    }
}
