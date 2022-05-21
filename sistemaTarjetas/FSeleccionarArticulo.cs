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
    public partial class FSeleccionarArticulo : Form
    {
        public int vendedor = -1;
        public int articulo = -1;

        public FSeleccionarArticulo()
        {
            InitializeComponent();
        }

        private void FSeleccionarArticulo_Load(object sender, EventArgs e)
        {
            v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor, vendedor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void seleccionar()
        {
            if (dgvBuscar.SelectedRows.Count > 0) articulo = (int)dgvBuscar.SelectedCells[0].Value;
            else this.DialogResult = DialogResult.None;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            bsBuscar.Filter = $"Descripcion LIKE '{txtDescripcion.Text}%'";
        }

        private void dgvBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvBuscar.Rows.Count > 0)
                {
                    seleccionar();
                }
            }
        }
    }
}
