
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class PantallaDelBotonClientes : Form
    {
        public PantallaDelBotonClientes()
        {
            InitializeComponent();
        }
        SqlConnection Conexion = new SqlConnection("server=LAPTOP-A96HL7MU\\SQLEXPRESS;database= SistemaDeUsuario; integrated security = true");

        private void PantallaDelBotonClientes_Load(object sender, EventArgs e)
        {
            
            string consulta = "select * from Users";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,Conexion);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dgvClientes.DataSource = dt;
        }
    }
}
