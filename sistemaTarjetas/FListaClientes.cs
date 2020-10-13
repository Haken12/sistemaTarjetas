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
    public partial class FListaClientes : Form
    {
        public FListaClientes()
        {
            InitializeComponent();
        }

        private void FListaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vClientes' Puede moverla o quitarla según sea necesario.
            this.vClientesTableAdapter.Fill(this.dsSistemaTarjetas.vClientes);
            if (dgvClientes.Rows.Count > 0)
            {
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;

            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (FClientes fClientes = new FClientes()) {
                fClientes.modo = Modo.Insertar;
                if (fClientes.ShowDialog() == DialogResult.OK) {
                    vClientesTableAdapter.Fill(dsSistemaTarjetas.vClientes);
                    if (dgvClientes.Rows.Count == 1)
                    {
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FClientes fClientes = new FClientes())
            {
                fClientes.modo = Modo.Editar;
                fClientes.cliente.codigo = Convert.ToInt32(dgvClientes.SelectedCells[0].Value);
                if (fClientes.ShowDialog() == DialogResult.OK)
                {
                    vClientesTableAdapter.Fill(dsSistemaTarjetas.vClientes);                  
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true) {
                queriesTableAdapter1.eliminar_cliente(Convert.ToInt32(dgvClientes.SelectedCells[0].Value));
                vClientesTableAdapter.Fill(dsSistemaTarjetas.vClientes);
                if (dgvClientes.Rows.Count == 0)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                bsClientes.Filter = "codigo =" + txtCodigo.Text;
            }
            else 
            {
                bsClientes.Filter = "";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bsClientes.Filter = "Nombre LIKE '" + txtNombre.Text + "%'";
            
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) 
            {
                txtNombre.Clear();
                txtNombre.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Clear();
                bsClientes.Filter = "";
               
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtCodigo.Clear();
                txtCodigo.Enabled = false;
                txtNombre.Enabled = true;
                txtNombre.Clear();
                bsClientes.Filter = "";
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)8) return;
            e.Handled = true;
        }
    }
}
