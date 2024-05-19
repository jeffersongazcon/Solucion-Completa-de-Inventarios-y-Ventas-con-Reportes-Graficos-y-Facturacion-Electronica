using DAL_Datos_;
using System;
using Entity_Entidad_;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail;
using System.Net;

namespace proyecto
{
    public partial class FormVenta : Form
    {
        DataSet dsTabla;
        private ProductoDAL productoDAL = new ProductoDAL();
        private List<Producto> productosVendidos = new List<Producto>();
        Paginacion dq = new Paginacion();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;
        public FormVenta()
        {
            InitializeComponent();
            txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
            txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
            PagFinal = NumFilas;
            CargarListaProductos();
            loadproductos();
            CargarProductos();
        }

        private void loadproductos()
        {
            dgvVenta.DataSource = productoDAL.GetAllProductos();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            // Capturar los productos seleccionados para la venta
            foreach (DataGridViewRow row in dgvVenta.SelectedRows)
            {
                Producto producto = new Producto
                {
                    ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                    DescripcionProducto = row.Cells["DescripcionProducto"].Value.ToString()
                };
                productosVendidos.Add(producto);
            }

            // Generar la factura con los detalles de los productos vendidos
            string factura = GenerarFactura(productosVendidos);

            // Obtener la dirección de correo electrónico del usuario logueado
            string email = Usuario.Email;

            // Enviar la factura por correo electrónico al usuario
            EnviarFacturaPorCorreo(email, factura);

            MessageBox.Show("Venta realizada y factura enviada por correo electrónico.");
        }

        private string GenerarFactura(List<Producto> productos)
        {
            StringBuilder facturaBuilder = new StringBuilder();
            facturaBuilder.AppendLine("Factura de Venta");
            facturaBuilder.AppendLine("-------------------------------");
            foreach (var producto in productos)
            {
                facturaBuilder.AppendLine($"Producto: {producto.Nombre}");
                facturaBuilder.AppendLine($"Descripción: {producto.DescripcionProducto}");
                facturaBuilder.AppendLine($"Precio: {producto.PrecioVenta:C}");
                facturaBuilder.AppendLine("-------------------------------");
            }
            decimal total = productos.Sum(p => p.PrecioVenta);
            facturaBuilder.AppendLine($"Total: {total:C}");
            return facturaBuilder.ToString();
        }

        private void EnviarFacturaPorCorreo(string email, string factura)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("gazconjefferson@gmail.com", "yrvo uehn ihrk nmve");
                smtpClient.EnableSsl = true;

                mail.From = new MailAddress("gazconjefferson@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Factura de su compra";
                mail.Body = factura;

                smtpClient.Send(mail);
                MessageBox.Show("Factura enviada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la factura: {ex.Message}");
            }
        }



        private void CargarListaProductos()
        {

            Producto.inicioProducto = PagInicio;
            Producto.finalProducto = PagFinal;
            dsTabla = dq.ListasProductos();
            dgvVenta.DataSource = dsTabla.Tables[1];
            int catidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) catidad++;

            textCantidadPagina.Text = catidad.ToString();
            cbxPagina.Items.Clear();

            for (int x = 1; x <= catidad; x++)
            {
                cbxPagina.Items.Add(x.ToString());
            }
            cbxPagina.SelectedIndex = indice;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0)
            {

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

        private void CargarProductos()
        {
            dsTabla = new DataSet(); // Suponiendo que dq.ListasProductos() retorna un DataSet
            dsTabla = dq.ListasProductos();
            dgvVenta.DataSource = dsTabla.Tables[1];
        }
    }
}
