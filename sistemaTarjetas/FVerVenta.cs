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
    public partial class FVerVenta : Form
    {
        public FVerVenta()
        {
            InitializeComponent();
        }

        public int numeroVenta = 0;
        public int codigoTarjeta = 0;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FVerVenta_Load(object sender, EventArgs e)
        {
           
            verDetallesVentaTableAdapter.Fill(dsSistemaTarjetas.verDetallesVenta, this.numeroVenta,this.codigoTarjeta);
        }
    }
}
