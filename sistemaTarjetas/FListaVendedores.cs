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
    public partial class FListaVendedores : Form
    {
        public FListaVendedores()
        {
            InitializeComponent();
        }

        private void FListaVendedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vVendedores' Puede moverla o quitarla según sea necesario.
            this.vVendedoresTableAdapter.Fill(this.dsSistemaTarjetas.vVendedores);
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vendedor' Puede moverla o quitarla según sea necesario.
            if (dgvListaVendedores.Rows.Count > 0) {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (FVendedores fVendedores = new FVendedores()) {
                fVendedores.modo = Modo.Insertar;
                if (fVendedores.ShowDialog() == DialogResult.OK)
                {
                    vVendedoresTableAdapter.Fill(dsSistemaTarjetas.vVendedores);
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FVendedores fVendedores = new FVendedores())
            {
                fVendedores.modo = Modo.Editar;
                fVendedores.vendedor.id = Convert.ToInt32(dgvListaVendedores.SelectedRows[0].Cells[0].Value);
                if (fVendedores.ShowDialog() == DialogResult.OK)
                {
                    vVendedoresTableAdapter.Fill(dsSistemaTarjetas.vVendedores);                 
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true) {
                queriesTableAdapter1.eliminar_vendedor(Convert.ToInt32(dgvListaVendedores.SelectedCells[0].Value));
                vVendedoresTableAdapter.Fill(dsSistemaTarjetas.vVendedores);
                if (dgvListaVendedores.Rows.Count == 0) {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true) {
                txtBuscarId.Enabled = true;
                txtBuscarNombre.Enabled = false;
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true) {
                txtBuscarId.Enabled = false;
                txtBuscarNombre.Enabled = true;
            }
        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarId.Text.Length > 0)
            {
                bsVendedores.Filter = "id_vendedor =" + txtBuscarId.Text;
            }
            else
            {
                bsVendedores.Filter = "";
            }
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            bsVendedores.Filter = "nombre LIKE '" + txtBuscarNombre.Text + "'%";
        }
    }
}
