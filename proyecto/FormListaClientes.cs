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
using DAL_Datos_;

namespace proyecto
{
    public partial class FormListaClientes : Form
    {
        private readonly IcrudUsuario _usuarioBLL;
        DataSet dsTabla;
        Paginacion dq = new Paginacion();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;
        public FormListaClientes()
        {
            InitializeComponent();
            _usuarioBLL = new IcrudUsuario();
            LoadUsuarios();
            PagFinal = NumFilas;
            CargarDG();
        }

        private void LoadUsuarios()
        {
            var dataTable = _usuarioBLL.GetAllUsuarios();
            dataGridView1.DataSource = dataTable;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var idUser = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                var confirmResult = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    _usuarioBLL.DeleteUsuario(idUser);
                    LoadUsuarios(); // Recargar cuando se elimina un usuario
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e) // sender es el parámetro estándar para métodos de evento
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                var UserID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);
                var form = new FormMantCliente(UserID);

                
                form.OnSaved += (src, args) => LoadUsuarios(); 
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.");
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e) 
        {
            var form = new FormMantCliente();

            
            form.OnSaved += (src, args) => LoadUsuarios(); 
            form.ShowDialog();
        }






        
    }
}
