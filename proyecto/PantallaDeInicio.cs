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

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnElementos_Click(object sender, EventArgs e)
        {

            if (BarraDeOpciones.Width == 232)
            {
                BarraDeOpciones.Width = 70;
            }
            else
                BarraDeOpciones.Width = 232;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login inicio = new Login();
            inicio.Show();
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
    }
}
