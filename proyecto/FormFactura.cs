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

        public FormFactura()
        {
            InitializeComponent();
            loadproductos();
        }

        private void loadproductos()
        {
            dgvReporte.DataSource = FacturaDAL.GetAllFactura();
        }



    }
}
