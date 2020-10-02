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
    public partial class FDespachoVendedor : Form
    {
        public FDespachoVendedor()
        {
            InitializeComponent();
        }

        public int idVendedor;

        private void FDespachoVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vProductos' Puede moverla o quitarla según sea necesario.
            this.vProductosTableAdapter.Fill(this.dsSistemaTarjetas.vProductos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                DataGridViewRow row = (DataGridViewRow)dgvInventario.SelectedRows[0].Clone();
                row.Cells[0].Value = dgvInventario.SelectedRows[0].Cells[0].Value;
                row.Cells[1].Value = dgvInventario.SelectedRows[0].Cells[1].Value;
                row.Cells[2].Value = nudCantidad.Value;
                int val = ((Int32)dgvInventario.SelectedRows[0].Cells[2].Value);
                val -= (Int32)nudCantidad.Value;
                dgvInventario.SelectedRows[0].Cells[2].Value = val;
                dgvVendedor.Rows.Add(row);
                nudCantidad.Maximum = Convert.ToInt32(dgvInventario.SelectedCells[2].Value);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {if (dgvVendedor.Rows.Count > 0)
            {
                int index = -1;
                string val = dgvVendedor.SelectedRows[0].Cells[0].Value.ToString();
                DataGridViewRow rw = dgvInventario.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["codig"].Value.ToString().Equals(val))
                    .First();
                index = rw.Index;
                int cantidad = Convert.ToInt32(dgvVendedor.SelectedCells[2].Value);
                cantidad += (Int32)dgvInventario.SelectedCells[2].Value;
                dgvInventario.Rows[index].Cells[2].Value = cantidad;
                dgvVendedor.Rows.Remove(dgvVendedor.SelectedRows[0]);
                nudCantidad.Maximum = Convert.ToInt32(dgvInventario.Rows[index].Cells[2].Value);
            }
        }

    

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            nudCantidad.Maximum = Convert.ToInt32(((DataGridView)sender).SelectedCells[2].Value);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvVendedor.Rows.Count > 0) 
            {
                foreach (DataGridViewRow row in dgvVendedor.Rows)
                {
                    queriesTableAdapter1.despachar_vendedor(
                        Convert.ToInt32(row.Cells[0].Value),
                        this.idVendedor, 
                        Convert.ToInt32(row.Cells[2].Value));
                }
            }
        }
    }
}
