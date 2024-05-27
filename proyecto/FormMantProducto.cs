using DAL_Datos_;
using Entity_Entidad_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class FormMantProducto : Form
    {
        public event EventHandler OnSaved;
        private readonly ProductoDAL dt;
        private ProductoDAL productoDAL = new ProductoDAL();
        private int? productoID;
        public FormMantProducto(int? productoID = null)
        {
            InitializeComponent();
            this.productoID = productoID;
            dt = new ProductoDAL();
            if (productoID.HasValue)
            {
                CargarProducto(productoID.Value);
            }
            else
            {
                txtFechaRegistro.Text = DateTime.Now.ToString();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CargarProducto(int ProductoID)
        {
            var producto = dt.GetAllProductos().AsEnumerable().FirstOrDefault(r => Convert.ToInt32(r["ProductoID"]) == ProductoID);

            if (producto != null)
            {
                txtCodigoDeBarra.Text = producto["CodigoDeBarras"].ToString();
                txtNombre.Text = producto["Nombre"].ToString();
                txtDescripcionDeProducto.Text = producto["DescripcionProducto"].ToString();
                txtCategoria.Text = producto["Categoria"].ToString();
                txtCantidad.Text = producto["Cantidad"].ToString();
                txtPrecioCompra.Text = producto["PrecioCompra"].ToString();
                txtPrecioVenta.Text = producto["PrecioVenta"].ToString();
                txtEstado.Text = producto["Estado"].ToString();
                txtFechaRegistro.Text = producto["FechaRegistro"].ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            var producto = new Producto
            {
                CodigoDeBarras = txtCodigoDeBarra.Text,
                Nombre = txtNombre.Text,
                DescripcionProducto = txtDescripcionDeProducto.Text,
                Categoria = txtCategoria.Text,
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text),
                PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text),
                Estado = txtEstado.Text,
                FechaRegistro = txtFechaRegistro.Text
            };

            if (productoID.HasValue)
            {
                producto.ProductoID = productoID.Value;
                productoDAL.UpdateProducto(producto);
            }
            else
            {
                productoDAL.AddProducto(producto);
            }

            OnSaved?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoDeBarra.Text))
            {
                MessageBox.Show("Por favor, ingrese el Código de Barras.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Por favor, ingrese el Nombre.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDescripcionDeProducto.Text))
            {
                MessageBox.Show("Por favor, ingrese la Descripción del Producto.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Por favor, ingrese la Categoría.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingrese la Cantidad.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioCompra.Text))
            {
                MessageBox.Show("Por favor, ingrese el Precio de Compra.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioVenta.Text))
            {
                MessageBox.Show("Por favor, ingrese el Precio de Venta.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Por favor, ingrese el Estado.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFechaRegistro.Text))
            {
                MessageBox.Show("Por favor, ingrese la Fecha de Registro.");
                return false;
            }

            return true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
