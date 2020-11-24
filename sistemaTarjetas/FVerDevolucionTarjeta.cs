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
    public partial class FVerDevolucionTarjeta : Form
    {
        public FVerDevolucionTarjeta()
        {
            InitializeComponent();
        }

        public int numeroDevolucion = 0;
        public int codigoTarjeta = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FVerDevolucionTarjeta_Load(object sender, EventArgs e)
        {
            verDetallesDevolucionTarjetaTableAdapter.Fill(dsSistemaTarjetas.verDetallesDevolucionTarjeta, this.numeroDevolucion, this.codigoTarjeta);
        }
    }
}
