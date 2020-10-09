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
    public partial class FDetallesTarjeta : Form
    {
        public FDetallesTarjeta()
        {
            InitializeComponent();
        }

        public Tarjeta tarjeta;
        
        private void FDetallesTarjeta_Load(object sender, EventArgs e)
        {
            unica_tarjeta_completaTableAdapter.Fill(dsSistemaTarjetas.unica_tarjeta_completa, tarjeta.codigo);
            detallesTarjetaTableAdapter.Fill(dsSistemaTarjetas.detallesTarjeta, tarjeta.codigo);
            cbxOperacion.SelectedIndex = 0;
            if (dgvDetalles.Rows.Count > 0) 
            {
                txtBalance.Text =  queriesTableAdapter1.balance_tarjeta(tarjeta.codigo).ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbxOperacion.SelectedIndex)
            {
                case 0:
                    using (FVenta fVenta = new FVenta())
                    {
                        fVenta.idVendedor = Convert.ToInt32(lblId.Text);
                        if (fVenta.ShowDialog() == DialogResult.OK)
                        {
                            int monto = fVenta.total;
                            MessageBox.Show(monto.ToString());
                            queriesTableAdapter1.nuevaVenta(tarjeta.codigo, DateTime.Today, monto);
                            detallesTarjetaTableAdapter.Fill(dsSistemaTarjetas.detallesTarjeta, tarjeta.codigo);
                            txtBalance.Text = queriesTableAdapter1.balance_tarjeta(tarjeta.codigo).ToString();
                        }
                    }
                    break;
                case 1:
                    using (FMonto fMonto = new FMonto())
                    {
                        if (fMonto.ShowDialog() == DialogResult.OK)
                        {
                            int monto = fMonto.monto;
                            queriesTableAdapter1.nuevoCobro(tarjeta.codigo, DateTime.Today, monto);
                            detallesTarjetaTableAdapter.Fill(dsSistemaTarjetas.detallesTarjeta, tarjeta.codigo);
                            txtBalance.Text = queriesTableAdapter1.balance_tarjeta(tarjeta.codigo).ToString();
                        }
                    }
                    break;
                case 2:
                    using (FMonto fMonto = new FMonto())
                    {
                        if (fMonto.ShowDialog() == DialogResult.OK)
                        {
                            int monto = fMonto.monto;
                            queriesTableAdapter1.nuevoDescuento(tarjeta.codigo, DateTime.Today, monto);
                            detallesTarjetaTableAdapter.Fill(dsSistemaTarjetas.detallesTarjeta, tarjeta.codigo);
                            txtBalance.Text = queriesTableAdapter1.balance_tarjeta(tarjeta.codigo).ToString();
                        }
                    }
                    break;
                case 3:
                    using (FMonto fMonto = new FMonto())
                    {
                        if (fMonto.ShowDialog() == DialogResult.OK)
                        {
                            int monto = fMonto.monto;
                            queriesTableAdapter1.nuevaDevolucion(tarjeta.codigo, DateTime.Today, monto);
                            detallesTarjetaTableAdapter.Fill(dsSistemaTarjetas.detallesTarjeta, tarjeta.codigo);
                            txtBalance.Text = queriesTableAdapter1.balance_tarjeta(tarjeta.codigo).ToString();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
