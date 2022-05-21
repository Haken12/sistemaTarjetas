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
    public partial class FCuadreVendedor : Form
    {
        public FCuadreVendedor()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            int vendedor = Convert.ToInt32(txtVendedor.Text);
            int? vendido = 0;
            int? vendidoT = 0;
            int vendidoD = 0;
            int? cobrado = 0;
            int? cobradoT = 0;
            int  cobradoD = 0;
            int? descontado = 0;
            int? descontadoT = 0;
            int  descontadoD = 0;
            int? nuevas = 0;
            int? trabajadas = 0;
            int? noTrabajadas = 0;
            qryCuadres.datosCuadre(
                vendedor, 
                dtpDia.Value,
                ref vendidoT,
                ref cobradoT,
                ref descontadoT,
                ref nuevas,
                ref trabajadas,
                ref noTrabajadas);
            txtVendidoT.Text = vendidoT.ToString();
            txtCobradoT.Text = cobradoT.ToString();
            txtDescontadoT.Text = descontadoT.ToString();
            txtNuevas.Text = nuevas.ToString();
            txtNoTrabajadas.Text = noTrabajadas.ToString();
            txtTrabajadas.Text = trabajadas.ToString();

            int? gastos = qryCuadres.gastosDia(vendedor, dtpDia.Value);
            txtGastos.Text = gastos.ToString();
        }

        private void txtVendido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCobrado.Focus();
            }
        }

        private void txtCobrado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescontado.Focus();
            }
        }

        private void txtDescontado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRecibido.Focus();
            }
        }
    }
}
