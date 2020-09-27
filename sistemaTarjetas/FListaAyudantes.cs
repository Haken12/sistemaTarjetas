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
    public partial class FListaAyudantes : Form
    {
        public FListaAyudantes()
        {
            InitializeComponent();
        }

        private void FListaAyudantes_Load(object sender, EventArgs e)
        {
            this.ayudanteTableAdapter.Fill(this.dsSistemaTarjetas.ayudante);
            if (dgvListaAyudantes.Rows.Count > 0)
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FAyudantes fAyudantes = new FAyudantes())
            {
                fAyudantes.modo = Modo.Editar;
                fAyudantes.ayudante.id = Int32.Parse(dgvListaAyudantes.SelectedRows[0].Cells[0].Value.ToString());
                if (fAyudantes.ShowDialog() == DialogResult.OK)
                {
                    ayudanteTableAdapter.Fill(dsSistemaTarjetas.ayudante);
                    if (dgvListaAyudantes.Rows.Count > 0)
                    {
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                    }
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using(FAyudantes fAyudantes = new FAyudantes())
            {
                if (fAyudantes.ShowDialog() == DialogResult.OK) {
                    ayudanteTableAdapter.Fill(dsSistemaTarjetas.ayudante);
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true) {
                queriesTableAdapter1.eliminar_ayudante(Int32.Parse(dgvListaAyudantes.SelectedRows[0].Cells[0].Value.ToString()));
                ayudanteTableAdapter.Fill(dsSistemaTarjetas.ayudante);
                if (dgvListaAyudantes.Rows.Count == 0) {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            { txtBuscarId.Enabled = true;
              txtBuscarNombre.Enabled = false;
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            { txtBuscarNombre.Enabled = true;
                txtBuscarId.Enabled = false;
            }
        }

        private void txtBuscarId_TextChanged(object sender, EventArgs e)
        {
            bsAyudantes.Filter = "id_ayudante LIKE '" + txtBuscarId.Text + "%'";
        }

        private void txtBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            bsAyudantes.Filter = "nombre LIKE '" + txtBuscarNombre.Text +"%'";

        }
    }
}
