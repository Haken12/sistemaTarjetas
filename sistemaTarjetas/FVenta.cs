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
    public partial class FVenta : Form
    {
        public int idVendedor;
        public int total;

        public FVenta()
        {
            InitializeComponent();
        }

        private void FVenta_Load(object sender, EventArgs e)
        {
            this.Text = idVendedor.ToString();
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_inventario_vendedor' Puede moverla o quitarla según sea necesario.
            this.v_inventario_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_inventario_vendedor);
            bsProductos.Filter = "id_vendedor =" + idVendedor.ToString();
            if (dgvProductos.SelectedRows.Count > 0) 
            {
                nudCantidad.Maximum = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[3].Value);
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((dgvProductos.SelectedRows.Count > 0) & (nudCantidad.Value > 0))
            {
                int valor = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[2].Value);
                this.total = Convert.ToInt32(valor * nudCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
            else { this.DialogResult = DialogResult.None; }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedCells.Count > 0)
            {
                nudCantidad.Maximum = Convert.ToInt32(dgvProductos.SelectedCells[3].Value);
            }
        }
    }
}
