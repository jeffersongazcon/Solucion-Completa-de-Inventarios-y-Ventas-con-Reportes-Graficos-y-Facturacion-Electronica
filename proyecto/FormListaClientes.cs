using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Entity_Entidad_;
using System.Data.SqlClient;
using BLL_Logica_;

namespace proyecto
{
    public partial class FormListaClientes : Form
    {
        DataSet dsTabla;
        BLL_Listar dq = new BLL_Listar();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;
        public FormListaClientes()
        {
            InitializeComponent();
            PagFinal = NumFilas;
            CargarDG();
        }
       
        private void CargarDG()
        {
            Usuario.inicio = PagInicio;
            Usuario.final = PagFinal;
            dsTabla = dq.ListasUsusarios();
            dataGridView1.DataSource = dsTabla.Tables[1];

            int catidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString())/ NumFilas;

            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString())% NumFilas > 0)catidad++;

            textCantidadPagina.Text = catidad.ToString();
            cbxPagina.Items.Clear();

            for (int x = 1; x <= catidad; x++)
            {
                cbxPagina.Items.Add(x.ToString());
            }
            cbxPagina.SelectedIndex = indice;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            //InsertarFilas();
        }
        

        private void BtnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPagina_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Pagina = Convert.ToInt32(cbxPagina.Text);
            indice = Pagina - 1;
            PagInicio = (Pagina - 1) * NumFilas + 1;
            PagFinal = Pagina * NumFilas;
            CargarDG();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            if (dataGridView1.SelectedRows.Count > 0)
            {               
                frm.txtid.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtLoginName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.txtFirsName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.txtLastName.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                frm.ShowDialog();
             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FormMantCliente frm = new FormMantCliente();
            frm.ShowDialog();
        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormMembresia frm = Owner as FormMembresia;
            //FormMembresia frm = new FormMembresia();

            frm.txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.txtnombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtapellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }


        
    }
}
