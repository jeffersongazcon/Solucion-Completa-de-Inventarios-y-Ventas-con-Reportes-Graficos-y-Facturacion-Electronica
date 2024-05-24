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
using System.Data.SqlClient;

namespace proyecto
{
    public partial class FormVenta : Form
    {
        DataSet dsTabla;
        private ProductoDAL productoDAL = new ProductoDAL();
        private FacturaDAL factura = new FacturaDAL();
        private List<Producto> productosVendidos = new List<Producto>();
        Paginacion dq = new Paginacion();
        int PagInicio = 1, indice = 0, NumFilas = 10, PagFinal;
        public FormVenta()
        {
            InitializeComponent();
            txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
            txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
            PagFinal = NumFilas;
            AñadirProductos();
            CargarCategorias();
            CargarNombres();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            DisminuirProductoVendido();
        }

        public void DisminuirProductoVendido()
        {
            foreach (DataGridViewRow row in dgvVenta.SelectedRows)
            {
                Producto producto = new Producto
                {
                    ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                    DescripcionProducto = row.Cells["DescripcionProducto"].Value.ToString()
                };
                int cantidadAVender = Convert.ToInt32(txtCantidad.Text);
                int productoID = Convert.ToInt32(row.Cells["ProductoID"].Value);
                int Actual = productoDAL.GetCantidadActual(productoID);
                if (cantidadAVender > Actual)
                {
                    DialogResult resultado = MessageBox.Show($"La cantidad a vender: {cantidadAVender} supera  a la cantidad actual {Actual}","Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (resultado == DialogResult.OK)
                    {
                        break;
                    }
                }
                productosVendidos.Add(producto);
                productoDAL.Venta(productoID, cantidadAVender);
                cantidadVendida = cantidadAVender;
                int nuevaCantidad = Convert.ToInt32(row.Cells["Cantidad"].Value) - cantidadAVender;
                row.Cells["Cantidad"].Value = nuevaCantidad > 0 ? nuevaCantidad : 0;
                Factura facturaDetalle = CrearFacturaDetalle(producto, cantidadAVender);
                factura.AddFactura(facturaDetalle);

                EnvioFacturaCorreo();
            }
        }
        int cantidadVendida;
        public void EnvioFacturaCorreo()
        {
            string factura = GenerarFactura(productosVendidos);
            // Obtener la dirección de correo electrónico del usuario logueado
            string email = Usuario.Email;
            EnviarFacturaPorCorreo(email, factura);
            MessageBox.Show("Venta realizada y factura enviada por correo electrónico.");
        }
        private string GenerarFactura(List<Producto> productos)
        {
            StringBuilder facturaBuilder = new StringBuilder();
            facturaBuilder.AppendLine("<html><body style='font-family: Arial, sans-serif; background-color: #f0f0f0; margin: 0; padding: 0;'>");
            facturaBuilder.AppendLine("<div style='max-width: 800px; margin: 20px auto; padding: 20px; background-color: #fff; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);'>");
            facturaBuilder.AppendLine("<h1 style='color: yellowgreen; text-align: center;'>Factura de Venta</h1>");
            facturaBuilder.AppendLine("<table style='width: 100%; border-collapse: collapse;'>");
            facturaBuilder.AppendLine("<thead style='background-color: yellowgreen; color: #fff;'>");
            facturaBuilder.AppendLine("<tr><th style='padding: 10px; border: 1px solid #ddd;'>Producto</th><th style='padding: 10px; border: 1px solid #ddd;'>Descripción</th><th style='padding: 10px; border: 1px solid #ddd;'>Precio</th><th style='padding: 10px; border: 1px solid #ddd;'>Cantidad</th></tr>");
            facturaBuilder.AppendLine("</thead>");
            facturaBuilder.AppendLine("<tbody>");

            foreach (var producto in productos)
            {
                facturaBuilder.AppendLine("<tr>");
                facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'>{producto.Nombre}</td>");
                facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'>{producto.DescripcionProducto}</td>");
                facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'>{producto.PrecioVenta:C}</td>");
                facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'>{cantidadVendida}</td>");
                facturaBuilder.AppendLine("</tr>");
            }

            decimal total = productos.Sum(p => p.PrecioVenta * cantidadVendida);
            facturaBuilder.AppendLine("<tr style='background-color: #f9f9f9;'>");
            facturaBuilder.AppendLine($"<td colspan='3' style='text-align: right; padding: 10px; border: 1px solid #ddd;'><strong>Total:</strong></td>");
            facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'><strong>{total:C}</strong></td>");
            facturaBuilder.AppendLine("</tr>");
            facturaBuilder.AppendLine("</tbody>");
            facturaBuilder.AppendLine("</table>");
            facturaBuilder.AppendLine("</div>");
            facturaBuilder.AppendLine("</body></html>");

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
                mail.IsBodyHtml = true; 
                mail.Body = factura;

                smtpClient.Send(mail);
                MessageBox.Show("Factura enviada.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar la factura: {ex.Message}");
            }
        }
       
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
           Validacion();
        }

        private void Validacion()
        {
            if (!int.TryParse(txtCantidad.Text, out int cantidadAVender) || cantidadAVender <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida mayor que 0.");
                return;
            }
        }

        private void CargarCategorias()
        {
            try
            {
                DataTable categorias = productoDAL.GetAllCategorias();
                cbCategoria.DataSource = categorias;
                cbCategoria.DisplayMember = "Categoria";
                cbCategoria.ValueMember = "Categoria";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        public void CargarNombres()
        {
            try
            {
                DataTable nombres = productoDAL.GetAllNombres();
                cbNombre.DataSource = nombres;
                cbNombre.DisplayMember = "Nombre";
                cbNombre.ValueMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AñadirProductos()
        {
            dgvVenta.DataSource = productoDAL.GetAllProductos();
        }

        private Factura CrearFacturaDetalle(Producto producto, int cantidadVendida)
        {
            Factura facturaDetalle = new Factura
            {
                Producto = producto.Nombre,
                Descripcion = producto.DescripcionProducto,
                Precio = Convert.ToInt32(producto.PrecioVenta), // Convertir de decimal a int
                Cantidad = cantidadVendida,
                Total = Convert.ToInt32(cantidadVendida * producto.PrecioVenta) // Convertir de decimal a int
            };

            return facturaDetalle;
        }


    }
}
