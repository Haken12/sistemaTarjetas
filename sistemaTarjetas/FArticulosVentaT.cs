using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaTarjetas
{
    public partial class FArticulosVentaT : Form
    {
        public FArticulosVentaT()
        {
            InitializeComponent();
        }

        public int articulo = 0;
        public int venta = 0;
       
        private void btnSel_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                articulo = (int)dgvBuscar.SelectedCells[0].Value;
                venta = dsDevoluciones.datosVenta[bsVenta.Position].Numero;
            }
        }

        private void FArticulosVentaT_Load(object sender, EventArgs e)
        {

        }
    }
}
