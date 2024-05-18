using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto
{
    public partial class FormVenta : Form
    {
        public FormVenta()
        {
            txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
            txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
            InitializeComponent();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0)
            {
                // Intenta convertir el texto a un entero
                if (int.TryParse(txtCantidad.Text, out int value))
                {
                    if (value <= 0)
                    {
                        MessageBox.Show("Por favor, ingrese un número mayor que 0.");
                        txtCantidad.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Entrada inválida. Por favor, ingrese solo números.");
                    txtCantidad.Clear();
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
