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
        FacturaDAL facturaDAL = new FacturaDAL();

        ArrayList Producto = new ArrayList();
        ArrayList CantidadDeVecesVendidos = new ArrayList();
        ArrayList MasVendido = new ArrayList();
        ArrayList producto = new ArrayList();
        ArrayList ProductoMenos = new ArrayList();
        ArrayList MenosQuerido = new ArrayList();

        public FormReporteGrafico()
        {
            InitializeComponent();
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
            DataTable dt = facturaDAL.GetProductosVendidos();
            foreach (DataRow row in dt.Rows)
            {
                Producto.Add(row["Producto"].ToString());
                CantidadDeVecesVendidos.Add(Convert.ToInt32(row["CantidadDeVecesVendidos"]));
            }
            chartProducto.Series[0].Points.DataBindXY(Producto, CantidadDeVecesVendidos);
        }

        public void Top5Productos()
        {
            DataTable dt = facturaDAL.GetTop5Productos();
            foreach (DataRow row in dt.Rows)
            {
                producto.Add(row["Producto"].ToString());
                MasVendido.Add(Convert.ToInt32(row["MasVendido"]));
            }
            chartTopMasVendidos.Series[0].Points.DataBindXY(producto, MasVendido);
        }

        public void Top5ProductosMenos()
        {
            DataTable dt = facturaDAL.GetTop5ProductosMenos();
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

            facturaDAL.GetGrafico(out cantidadInvertida, out ganancia, out cantidadDeClientes, out numeroDeCategorias, out cantidadDeProductos);

            // Mostrar las estadísticas generales en la interfaz
            lblCantidadInvertid.Text = $"{cantidadInvertida:N0}";
            labelGanancia.Text = $"{ganancia:N0}";
            labelCantidadDeClientes.Text = $"{cantidadDeClientes}";
            labelNumeroDeCategorias.Text = $"{numeroDeCategorias}";
            labelCantidadDeProductos.Text = $"{cantidadDeProductos}";
        }
    }
}
