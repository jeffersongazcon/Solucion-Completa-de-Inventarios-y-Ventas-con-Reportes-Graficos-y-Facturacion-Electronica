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

namespace proyecto
{
    public partial class PantallaDeInicio : Form
    {
        public PantallaDeInicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparaw, int lparam);

        private void PantallaDeInicio_Load(object sender, EventArgs e)
        {
            CargarInfomacionDeUsuario();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnElementos_Click(object sender, EventArgs e)
        {
            
            if (BarraDeOpciones.Width == 232)
            {
                BarraDeOpciones.Width = 53;
            }
            else
                BarraDeOpciones.Width = 232;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Confirmacion confirmacion = new Confirmacion();
            confirmacion.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SubReportes.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubReportes.Visible = true;
        }

        private void btnReportesCompras_Click(object sender, EventArgs e)
        {
            SubReportes.Visible = false;
        }

        private void CargarInfomacionDeUsuario()
        {
            lblNombre.Text = Usuario.FirsName+"  "+Usuario.LastName;
            lblCargo.Text = Usuario.Cargo;
            lblEmail.Text = Usuario.Email;
        }

        private void AbrirFormHija(object formhija)
        {
            if(this.panelInfo.Controls.Count > 0)
            {
                this.panelInfo.Controls.RemoveAt(0);
            }
            
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelInfo.Controls.Add(fh);
            this.panelInfo.Tag = fh;
            fh.Show();
            
        }

        private void BarraDeOpciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Producto());
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new PantallaDelBotonClientes());
        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
