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
    public partial class FInventarioVendedores : Form
    {
        public FInventarioVendedores()
        {
            InitializeComponent();
        }

        private void FInventarioVendedores_Load(object sender, EventArgs e)
        {
            this.vVendedoresTableAdapter.Fill(this.dsSistemaTarjetas.vVendedores);
            this.v_inventario_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_inventario_vendedor);


            if (cbxNombre.Items.Count > 0) {
                cbxNombre.SelectedIndex = 0;
                bsInventarioVendedor.Filter = "id_vendedor =" + cbxNombre.SelectedValue;
                btnDevolucion.Enabled = true;
                btnIrDespacho.Enabled = true;
                
            }

        }

        private void cbxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNombre.SelectedIndex != -1) { 
            bsInventarioVendedor.Filter = "id_vendedor =" + cbxNombre.SelectedValue;
            }
        }

        private void irDespacho_Click(object sender, EventArgs e)
        {
            using (FDespachoVendedor fDespacho = new FDespachoVendedor())
            {
                fDespacho.idVendedor = Convert.ToInt32(cbxNombre.SelectedValue);
                if (fDespacho.ShowDialog() == DialogResult.OK) 
                {
                    v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor);
                }
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            using (FDevolverInventario fDevolver = new FDevolverInventario())
            {
                fDevolver.idVendedor = Convert.ToInt32(cbxNombre.SelectedValue);
                if (fDevolver.ShowDialog() == DialogResult.OK)
                {
                    v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor);
                }
            }
        }
    }
}
