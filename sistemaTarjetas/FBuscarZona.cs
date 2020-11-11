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
    public partial class FBuscarZona : Form
    {
        public FBuscarZona()
        {
            InitializeComponent();
        }
        public int Id = -1;

        private void FBuscarZona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_zona' Puede moverla o quitarla según sea necesario.
            this.v_zonaTableAdapter.Fill(this.dsSistemaTarjetas.v_zona);

        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) 
            {
                txtId.Enabled = true;
                txtVendedor.Enabled = false;
                txtDescripcion.Enabled = false;
                bsBuscar.Filter = "";
                txtId.Focus();
            }
        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtId.Enabled = false;
                txtVendedor.Enabled = true;
                txtDescripcion.Enabled = false;
                bsBuscar.Filter = "";
                txtVendedor.Focus();
            }
        }

        private void rbDescripcion_TextChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtId.Enabled = false;
                txtVendedor.Enabled = false;
                txtDescripcion.Enabled = true;
                bsBuscar.Filter = "";
                txtDescripcion.Focus();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtId.TextLength != 0) 
            {
                int id = Convert.ToInt32(txtId.Text);
                bsBuscar.Filter = $"Id ={id}";
            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtVendedor.TextLength != 0) 
            {
                string vendedor = txtVendedor.Text;
                bsBuscar.Filter = $"Vendedor LIKE '{vendedor}%'";
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtDescripcion.TextLength != 0)
            {
                string descripcion = txtDescripcion.Text;
                bsBuscar.Filter = $"Vendedor LIKE '{descripcion}%'";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count != 0)
            {
                this.Id = (int)dgvBuscar.SelectedCells[0].Value;
            }
            else this.DialogResult = DialogResult.None;

        }
    }
}
