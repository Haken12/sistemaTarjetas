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
    public partial class FInventarioVendedor : Form
    {
        public FInventarioVendedor()
        {
            InitializeComponent();
        }

        private void ClickCerrar(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtId.Enabled = true;
                cbNombre.Enabled = false;
            }
            else
            {
                txtId.Enabled = false;
                cbNombre.Enabled = true;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (!(((TextBox)sender).Text == String.Empty))
            {
                int vendedor = Convert.ToInt32(txtId.Text);
                if (querys.vendedor_existe(vendedor) != 0)
                {
                    cbNombre.SelectedValue = vendedor;
                    this.v_inventario_vendedorTableAdapter.Fill(this.dsInventario.v_inventario_vendedor, vendedor);
                }
                else this.dsInventario.v_inventario_vendedor.Clear();
            }
            else this.dsInventario.v_inventario_vendedor.Clear();
        }

        private void FInventarioVendedor_Load(object sender, EventArgs e)
        {
            this.v_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_vendedor);
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != -1)
            {
                this.v_inventario_vendedorTableAdapter.Fill(this.dsInventario.v_inventario_vendedor, (int)cbNombre.SelectedValue);
                //txtId.Text = cbNombre.SelectedValue.ToString();
            }
        }
    }
}
