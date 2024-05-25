using DAL_Datos_;
using Entity_Entidad_;
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
    public partial class FormFactura : Form
    {
        private FacturaDAL FacturaDAL = new FacturaDAL();
        private FacturaDAL facturaDAL;
        public FormFactura()
        {
            InitializeComponent();
            facturaDAL = new FacturaDAL();
            loadproductos();

        }
        private void loadproductos()
        {
            DataTable dt = FacturaDAL.GetAllFactura();
            dgvReporte.DataSource = dt;

            // Asegúrate de que el DataGridView muestre las columnas PrecioCompra y Precio
            if (!dgvReporte.Columns.Contains("PrecioCompra"))
            {
                dgvReporte.Columns.Add("PrecioCompra", "Precio de Compra");
            }
            dgvReporte.Columns["PrecioCompra"].DataPropertyName = "PrecioCompra";

            if (!dgvReporte.Columns.Contains("Precio"))
            {
                dgvReporte.Columns.Add("Precio", "Precio de Venta");
            }
            dgvReporte.Columns["Precio"].DataPropertyName = "Precio";

            if (!dgvReporte.Columns.Contains("Total"))
            {
                dgvReporte.Columns.Add("Total", "Total de Venta");
            }
            dgvReporte.Columns["Total"].DataPropertyName = "Total";

            CalcularGanancias(dt);
        }

        private void CalcularGanancias(DataTable dt)
        {
            decimal cantidadInvertida = 0;
            decimal totalVentas = 0;
            decimal gananciaTotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                decimal precioCompra = Convert.ToDecimal(row["PrecioCompra"]);
                decimal precioVenta = Convert.ToDecimal(row["Precio"]);
                int cantidad = Convert.ToInt32(row["Cantidad"]);

                cantidadInvertida += precioCompra * cantidad;
                totalVentas += precioVenta * cantidad;
                gananciaTotal += (precioVenta - precioCompra) * cantidad;
            }

            lblCantidadInvertida.Text = $"${cantidadInvertida}";
            lblGananciaTotal.Text = $"${gananciaTotal}";
        }

        private void BtnCerrarVenta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFinal = dtpFechaFinal.Value;

            DataTable ventasTable = facturaDAL.GetVentasPorFecha(fechaInicio, fechaFinal);
            dgvReporte.DataSource = ventasTable;
            CalcularGanancias(ventasTable);
        }
    }
}