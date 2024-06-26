﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Logica_;
using Entity_Entidad_;
using DAL_Datos_;

namespace proyecto
{
    public partial class FormMantCliente : Form
    {
        public event EventHandler OnSaved; // Para notificar cuando se guarde

        private readonly IcrudUsuario _usuarioBLL;
        private int? _UserID;
        public FormMantCliente(int? UserID = null) // Si se pasa un ID, es para editar
        {
            InitializeComponent();
            _usuarioBLL = new IcrudUsuario();
            _UserID = UserID;

            if (_UserID.HasValue)
            {
                LoadUsuario(_UserID.Value);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void LoadUsuario(int UserID)
        {
            var usuario = _usuarioBLL.GetAllUsuarios().AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["UserID"]) == UserID);
            if (usuario != null)
            {
                txtLoginName.Text = usuario["LoginName"].ToString();
                txtPassword.Text = usuario["Password"].ToString();
                txtFirsName.Text = usuario["FirsName"].ToString();
                txtLastName.Text = usuario["LastName"].ToString();
                txtCargo.Text = usuario["Cargo"].ToString();
                txtEmail.Text = usuario["Email"].ToString();
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMantCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            var loginName = txtLoginName.Text;
            var password = txtPassword.Text;
            var firstName = txtFirsName.Text;
            var lastName = txtLastName.Text;
            var cargo = txtCargo.Text;
            var email = txtEmail.Text;

            if (_UserID.HasValue) // Editar
            {
                _usuarioBLL.UpdateUsuario(_UserID.Value, loginName, password, firstName, lastName, cargo, email);
            }
            else // Nuevo
            {
                _usuarioBLL.AddUsuario(loginName, password, firstName, lastName, cargo, email);
            }

            OnSaved?.Invoke(this, EventArgs.Empty); //ahh esto es para notificar a FormListaClientes
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtLoginName.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre de usuario.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFirsName.Text))
            {
                MessageBox.Show("Por favor, ingrese el primer nombre.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Por favor, ingrese el apellido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCargo.Text))
            {
                MessageBox.Show("Por favor, ingrese el cargo.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, ingrese el email.");
                return false;
            }

            return true;
        }
    }
}
