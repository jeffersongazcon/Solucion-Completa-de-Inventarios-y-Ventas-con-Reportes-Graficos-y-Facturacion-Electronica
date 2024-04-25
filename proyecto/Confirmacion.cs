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
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaDeInicio inicio = new PantallaDeInicio();
            inicio.Show();
            this.Hide();

        }

        private void panelMessage_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
