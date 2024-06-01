using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAL_Datos_;

namespace proyecto
{
    public partial class FormReporteGrafico : Form
    {
        
        FacturaDAL factura1 = new FacturaDAL();
        private FacturaDAL FacturaDAL = new FacturaDAL();
        private FacturaDAL facturaDAL;


        ArrayList Producto = new ArrayList();
        ArrayList CantidadDeVecesVendidos = new ArrayList();
        ArrayList MasVendido = new ArrayList();
        ArrayList producto = new ArrayList();
        ArrayList ProductoMenos = new ArrayList();
        ArrayList MenosQuerido = new ArrayList();

        public FormReporteGrafico()
        {
            InitializeComponent();
            facturaDAL = new FacturaDAL();
            loadproductos();
            GraficoReportesProductos();
            Top5Productos();
            Top5ProductosMenos();
            MostrarEstadisticasGenerales();
        }

        private void FormReporteGrafico_Load(object sender, EventArgs e)
        {
            GraficoReportesProductos();
            Top5Productos();
            Top5ProductosMenos();
            MostrarEstadisticasGenerales();
        }

        public void GraficoReportesProductos()
        {
            DataTable dt = factura1.GetProductosVendidos();
            foreach (DataRow row in dt.Rows)
            {
                Producto.Add(row["Producto"].ToString());
                CantidadDeVecesVendidos.Add(Convert.ToInt32(row["CantidadDeVecesVendidos"]));
            }
            chartProducto.Series[0].Points.DataBindXY(Producto, CantidadDeVecesVendidos);
        }

        public void Top5Productos()
        {
            DataTable dt = factura1.GetTop5Productos();
            foreach (DataRow row in dt.Rows)
            {
                producto.Add(row["Producto"].ToString());
                MasVendido.Add(Convert.ToInt32(row["MasVendido"]));
            }
            chartTopMasVendidos.Series[0].Points.DataBindXY(producto, MasVendido);
        }

        public void Top5ProductosMenos()
        {
            DataTable dt = factura1.GetTop5ProductosMenos();
            foreach (DataRow row in dt.Rows)
            {
                ProductoMenos.Add(row["Producto"].ToString());
                MenosQuerido.Add(Convert.ToInt32(row["MenosVendido"]));
            }
            chartTopMenosVendidos.Series[0].Points.DataBindXY(ProductoMenos, MenosQuerido);
        }

        public void MostrarEstadisticasGenerales()
        {
            decimal cantidadInvertida;
            decimal ganancia;
            int cantidadDeClientes;
            int numeroDeCategorias;
            int cantidadDeProductos;

            factura1.GetGrafico(out cantidadInvertida, out ganancia, out cantidadDeClientes, out numeroDeCategorias, out cantidadDeProductos);

            
            lblCantidadInvertida.Text = $"{cantidadInvertida:C}";
            labelGanancia.Text = $"{ganancia:C}";
            labelCantidadDeClientes.Text = $"{cantidadDeClientes}";
            labelNumeroDeCategorias.Text = $"{numeroDeCategorias}";
            labelCantidadDeProductos.Text = $"{cantidadDeProductos}";
        }

        private void loadproductos()
        {
            DataTable dt = FacturaDAL.GetAllFactura();
            dgvReporte.DataSource = dt;

            
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

            lblCantidadInvertida.Text = $"${cantidadInvertida:N0}";
            labelGanancia.Text = $"${gananciaTotal:N0}";
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

        private void BtnCerrarProductos_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}


