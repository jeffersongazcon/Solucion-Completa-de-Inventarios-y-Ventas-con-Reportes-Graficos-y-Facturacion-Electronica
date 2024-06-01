using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using DAL_Datos_;
using Entity_Entidad_;
using Font = iTextSharp.text.Font;

namespace proyecto
{
    public partial class FormVenta : Form
    {
        private bool facturaEnviada = false;
        private ProductoDAL productoDAL = new ProductoDAL();
        private FacturaDAL factura = new FacturaDAL();
        private List<Producto> productosVendidos = new List<Producto>();
        private List<Producto> carrito = new List<Producto>();

        public FormVenta()
        {
            InitializeComponent();
            txtCantidad.KeyPress += new KeyPressEventHandler(txtCantidad_KeyPress);
            txtCantidad.TextChanged += new EventHandler(txtCantidad_TextChanged);
            cbCategoria.SelectedIndexChanged += new EventHandler(cbCategoria_SelectedIndexChanged);
            cbNombre.SelectedIndexChanged += new EventHandler(cbNombre_SelectedIndexChanged);
            btnAgregar.Click += new EventHandler(btnAgregar_Click);
            btnQuitar.Click += new EventHandler(btnQuitar_Click);
            btnVender.Click -= new EventHandler(btnVender_Click);
            btnVender.Click += new EventHandler(btnVender_Click);
            btnGenerarFactura.Click += new EventHandler(btnGenerarFactura_Click);
            AñadirProductos();
            CargarCategorias();
            ActualizarImagen();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("No se ha seleccionado ningún producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DisminuirProductoVendido();
            ActualizarImagen();
        }

        private void DisminuirProductoVendido()
        {
            bool hayError = false;
            foreach (var producto in carrito)
            {
                int cantidadAVender = producto.Cantidad;
                int productoID = producto.ProductoID;
                int Actual = productoDAL.GetCantidadActual(productoID);

                if (cantidadAVender > Actual)
                {
                    MessageBox.Show($"La cantidad a vender: {cantidadAVender} supera a la cantidad actual {Actual}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                productosVendidos.Add(producto);
                productoDAL.Venta(productoID, cantidadAVender);
                Factura facturaDetalle = CrearFacturaDetalle(producto, cantidadAVender);
                factura.AddFactura(facturaDetalle);
            }

            if (!hayError)
            {
                EnvioFacturaCorreo();
                carrito.Clear();
                ActualizarCarrito();
            }
        }

        private void ActualizarCarrito()
        {
            dgvCarrito.DataSource = null;
            if (!dgvCarrito.Columns.Contains("NombreCliente"))
            {
                dgvCarrito.Columns.Add("NombreCliente", "Nombre Cliente");
            }
            foreach (DataGridViewRow row in dgvCarrito.Rows)
            {
                row.Cells["NombreCliente"].Value = Usuario.FirsName + "  " + Usuario.LastName;
            }

            dgvCarrito.DataSource = carrito;

            dgvCarrito.Columns["CodigoDeBarras"].Visible = false;
            dgvCarrito.Columns["ProductoID"].Visible = false;
            dgvCarrito.Columns["PrecioCompra"].Visible = false;
            dgvCarrito.Columns["Estado"].Visible = false;
            dgvCarrito.Columns["FechaRegistro"].Visible = false;
        }

        private void ActualizarImagen()
        {
            pbEsperando.Visible = carrito.Count == 0;
        }

        private void EnvioFacturaCorreo()
        {
            string factura = GenerarFactura(productosVendidos);
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
                facturaBuilder.AppendLine($"<td style='padding: 10px; border: 1px solid #ddd;'>{producto.Cantidad}</td>");
                facturaBuilder.AppendLine("</tr>");
            }

            decimal total = productos.Sum(p => p.PrecioVenta * p.Cantidad);
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
                smtpClient.Credentials = new NetworkCredential("inventariodelduende@gmail.com", "g r o v r o v g r a z h o v m t");
                smtpClient.EnableSsl = true;

                mail.From = new MailAddress("inventariodelduende@gmail.com");
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
            if (!int.TryParse(txtCantidad.Text, out int cantidadAComprar) || cantidadAComprar <= 0)
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

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedValue != null)
            {
                string categoria = cbCategoria.SelectedValue.ToString();
                DataTable productos = productoDAL.GetProductosByCategoria(categoria);
                dgvVenta.DataSource = productos;

                DataTable nombres = productoDAL.GetNombresByCategoria(categoria);
                cbNombre.DataSource = nombres;
                cbNombre.DisplayMember = "Nombre";
                cbNombre.ValueMember = "Nombre";
            }
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNombre.SelectedValue != null && cbCategoria.SelectedValue != null)
            {
                string nombre = cbNombre.SelectedValue.ToString();
                string categoria = cbCategoria.SelectedValue.ToString();
                DataTable productos = productoDAL.GetProductosByNombreYCategoria(nombre, categoria);
                dgvVenta.DataSource = productos;
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
            dgvVenta.Columns["CodigoDeBarras"].Visible = false;
            dgvVenta.Columns["ProductoID"].Visible = false;
            dgvVenta.Columns["PrecioCompra"].Visible = false;
            dgvVenta.Columns["Estado"].Visible = false;
            dgvVenta.Columns["FechaRegistro"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCantidad.Text))
            {
                ValidacionDeCantidad();
                return;
            }
            foreach (DataGridViewRow row in dgvVenta.SelectedRows)
            {
                Producto producto = new Producto
                {
                    ProductoID = Convert.ToInt32(row.Cells["ProductoID"].Value),
                    Nombre = row.Cells["Nombre"].Value.ToString(),
                    PrecioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                    DescripcionProducto = row.Cells["DescripcionProducto"].Value.ToString(),
                    PrecioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                    Categoria = row.Cells["Categoria"].Value.ToString(),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                };

                carrito.Add(producto);
            }
            ActualizarImagen();

            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
            dgvCarrito.Columns["CodigoDeBarras"].Visible = false;
            dgvCarrito.Columns["ProductoID"].Visible = false;
            dgvCarrito.Columns["PrecioCompra"].Visible = false;
            dgvCarrito.Columns["Estado"].Visible = false;
            dgvCarrito.Columns["FechaRegistro"].Visible = false;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCarrito.SelectedRows)
            {
                Producto producto = row.DataBoundItem as Producto;
                if (producto != null)
                {
                    carrito.Remove(producto);
                }
            }
            ActualizarImagen();
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = carrito;
        }

        private Factura CrearFacturaDetalle(Producto producto, int cantidadVendida)
        {
            Factura facturaDetalle = new Factura
            {
                Producto = producto.Nombre,
                Descripcion = producto.DescripcionProducto,
                Precio = Convert.ToInt32(producto.PrecioVenta), 
                Cantidad = cantidadVendida,
                Total = Convert.ToInt32(cantidadVendida * producto.PrecioVenta), 
                PrecioCompra = Convert.ToInt32(producto.PrecioCompra),
                NombreCliente = Usuario.FirsName + "  " + Usuario.LastName,
            };

            return facturaDetalle;
        }

        private void BtnCerrarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ValidacionDeCantidad()
        {
            MessageBox.Show("Por favor, ingrese una CANTIDAD del producto que quiero comprar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;

        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            GenerarFacturaPDF(productosVendidos, "Factura.pdf");
            return;
        }

        private void GenerarFacturaPDF(List<Producto> productos, string fileName)
        {
            // por aqui se pone la ruta de la carpeta Documentos
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(folderPath, fileName);

            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(fullPath, FileMode.Create));
            document.Open();

            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, iTextSharp.text.Font.BOLD, BaseColor.GREEN);
            Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
            Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 12, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);


            // Título 
            Paragraph title = new Paragraph("Factura de Venta", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 20
            };
            document.Add(title);

            // se crea la tabla aqi!
            PdfPTable table = new PdfPTable(4)
            {
                WidthPercentage = 100
            };
            table.SetWidths(new float[] { 2, 5, 2, 2 });

            
            PdfPCell[] headers = {
                new PdfPCell(new Phrase("Producto", headerFont)) { BackgroundColor = BaseColor.GREEN, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 },
                new PdfPCell(new Phrase("Descripción", headerFont)) { BackgroundColor = BaseColor.GREEN, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 },
                new PdfPCell(new Phrase("Precio", headerFont)) { BackgroundColor = BaseColor.GREEN, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 },
                new PdfPCell(new Phrase("Cantidad", headerFont)) { BackgroundColor = BaseColor.GREEN, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 5 }
            };

            foreach (var header in headers)
            {
                table.AddCell(header);
            }

           
            foreach (var producto in productos)
            {
                table.AddCell(new PdfPCell(new Phrase(producto.Nombre, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(producto.DescripcionProducto, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(producto.PrecioVenta.ToString("C"), cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(producto.Cantidad.ToString(), cellFont)) { Padding = 5 });
            }

            // Total
            decimal total = productos.Sum(p => p.PrecioVenta * p.Cantidad);
            PdfPCell totalCell = new PdfPCell(new Phrase("Total", cellFont)) { Colspan = 3, HorizontalAlignment = Element.ALIGN_RIGHT, Padding = 5 };
            table.AddCell(totalCell);
            table.AddCell(new PdfPCell(new Phrase(total.ToString("C"), cellFont)) { Padding = 5 });

            document.Add(table);
            document.Close();

            MessageBox.Show("Factura generada y guardada en la carpeta Documentos.");
            
        }
    }
}
