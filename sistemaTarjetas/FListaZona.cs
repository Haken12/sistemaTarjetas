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
    public partial class FListaZona : Form
    {
        public FListaZona()
        {
            InitializeComponent();
        }

        private void FListaZona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vZona' Puede moverla o quitarla según sea necesario.
            this.vZonaTableAdapter.Fill(this.dsSistemaTarjetas.vZona);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            using (FZona fZona = new FZona())
            {
                fZona.modo = Modo.Insertar;
                if (fZona.ShowDialog() == DialogResult.OK)
                {
                    vZonaTableAdapter.Fill(dsSistemaTarjetas.vZona);
                    if (btnModificar.Enabled == false)
                    {
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FZona fZona = new FZona())
            {
                fZona.modo = Modo.Editar;
                fZona.zona.id = Convert.ToInt32(dgvListaZona.SelectedCells[0].Value);
                if (fZona.ShowDialog() == DialogResult.OK)
                {
                    vZonaTableAdapter.Fill(dsSistemaTarjetas.vZona);                   
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true) {
                queriesTableAdapter1.eliminar_zona(Convert.ToInt32(dgvListaZona.SelectedCells[0].Value));
                vZonaTableAdapter.Fill(dsSistemaTarjetas.vZona);
                if (dgvListaZona.Rows.Count == 0)
                {
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true) {
                txtId.Enabled = true;
                txtNombre.Enabled = false;
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                txtNombre.Enabled = true;
                txtId.Enabled = false;
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            bsZonas.Filter = "id_zona LIKE '" + txtId.Text + "%'";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bsZonas.Filter = "descripcion LIKE '" + txtNombre.Text + "%'";
        }
    }
}
