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
using BLL_Logica_;
using Entity_Entidad_;

namespace proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //es para que se pueda mover la pestaña del login
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparaw, int lparam);
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "User")
            {
                if (txtpass.Text != "Password")
                {
                    BLL_Usuario bLL_Usuario = new BLL_Usuario();
                    var validLogin = bLL_Usuario.Login(txtUser.Text,txtpass.Text);
                    if (validLogin == true)
                    {
                        PantallaDeInicio mainMenu = new PantallaDeInicio();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        msgError("User o password incorrrectos");
                        txtpass.Clear();
                        txtUser.Clear();
                        txtUser.Focus();
                        
                    }
                }
                else msgError("Rellene el campo de Password");
            }
            else msgError("Rellene el campo User");

            //Usuario usario = new BLL_Usuario().Lista().Where(u => u.Documento == txtUser.Text && u.Clave == txtpass.Text).FirstOrDefault();

        }

        private void msgError(string msg)
        {
            MensajeDeError.Text = "   " + msg;
            MensajeDeError.Visible = true;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.Text = "User";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text= "Password";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Es para que cuando se cierre la pantalla de inicio se cierre este vuelva a el login
        private void cerrarPantallaDeInicio(object sender, EventArgs e)
        {
            this.Show();
        }

        private void MensajeDeError_Click(object sender, EventArgs e)
        {

        }
    }
}
