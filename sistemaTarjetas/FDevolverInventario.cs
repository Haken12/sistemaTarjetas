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
    public partial class FDevolverInventario : Form
    {

        public int idVendedor;
       

        public FDevolverInventario()
        {
            InitializeComponent();
        }

        private void FDevolverInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas1.vVendedores' Puede moverla o quitarla según sea necesario.
            this.vVendedoresTableAdapter.Fill(this.dsSistemaTarjetas1.vVendedores);
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_inventario_vendedor' Puede moverla o quitarla según sea necesario.
            this.v_inventario_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_inventario_vendedor);
           
            bsInventarioVendedor.Filter = "id_vendedor =" + this.idVendedor.ToString();

            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if ((dgvVendedor.Rows.Count > 0) && (nudCantidad.Value > 0)) 
            { 
                DataGridViewRow rw = (DataGridViewRow)dgvVendedor.Rows[0].Clone();
                rw.Cells.Remove(rw.Cells[3]);
                rw.Cells[0].Value = dgvVendedor.SelectedCells[0].Value;
                rw.Cells[1].Value = dgvVendedor.SelectedCells[1].Value;
                rw.Cells[2].Value = nudCantidad.Value;
                dgvDevolucion.Rows.Add(rw);
                int val = Convert.ToInt32(dgvVendedor.SelectedCells[2].Value);
                dgvVendedor.SelectedCells[2].Value =   val - nudCantidad.Value;
                nudCantidad.Maximum = val - nudCantidad.Value;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDevolucion.Rows.Count > 0)
            {
                int index = -1;
                DataGridViewRow row;
                string valor = dgvDevolucion.SelectedCells[0].Value.ToString();
                row = dgvVendedor.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells["_codigo"].Value.ToString().Equals(valor))
                    .First();
                index = row.Index;

                int val = Convert.ToInt32(dgvVendedor.Rows[index].Cells[2].Value)
                    + Convert.ToInt32(dgvDevolucion.SelectedCells[2].Value);
                dgvVendedor.Rows[index].Cells[2].Value = val;
                nudCantidad.Maximum = Convert.ToInt32(dgvVendedor.SelectedCells[2].Value);
                dgvDevolucion.Rows.Remove(dgvDevolucion.SelectedRows[0]);

            }
        }

        private void dgvVendedor_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvDevolucion.Rows.Count > 0) 
            {
                foreach (DataGridViewRow row in dgvDevolucion.Rows)
                {
                    queriesTableAdapter1.devolver_a_inventario(
                        Convert.ToInt32(row.Cells[0].Value),
                        this.idVendedor,
                        Convert.ToInt32(row.Cells[2].Value));
                }
                v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor);
                dgvDevolucion.Rows.Clear();
            }
        }

        
       
    }
}
