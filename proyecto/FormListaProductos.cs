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

namespace proyecto
{
    public partial class FormListaProductos : Form
    {
        DataSet dsTabla;
        BLL_Listar dq = new BLL_Listar();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;

        public FormListaProductos()
        {
            InitializeComponent();
            PagFinal = NumFilas;
            CargarListaProductos();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
                throw new Exception();
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

        private void cbxPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Pagina = Convert.ToInt32(cbxPagina.Text);
            indice = Pagina - 1;
            PagInicio = (Pagina - 1) * NumFilas + 1;
            PagFinal = Pagina * NumFilas;
            CargarListaProductos();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMembresia frm = Owner as FormMembresia;

            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

    }
}
