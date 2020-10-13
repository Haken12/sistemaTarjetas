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
    public partial class FListaTarjetas : Form
    {
        public FListaTarjetas()
        {
            InitializeComponent();
        }

        private void FListaTarjetas_Load(object sender, EventArgs e)
        {
            this.vTarjetasTableAdapter.Fill(this.dsSistemaTarjetas.vTarjetas);
            if (dgvTarjetas.Rows.Count > 0) {
                btnDetalles.Enabled = true;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            using (FTarjetas fTarjetas = new FTarjetas()) {
                fTarjetas.modo = Modo.Insertar;
                if (fTarjetas.ShowDialog() == DialogResult.OK) {
                    vTarjetasTableAdapter.Fill(dsSistemaTarjetas.vTarjetas);
                    if (dgvTarjetas.Rows.Count > 0)
                    {
                        btnDetalles.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true)
            {
                queriesTableAdapter1.eliminar_tarjeta(Convert.ToInt32(dgvTarjetas.SelectedCells[0].Value));
                this.vTarjetasTableAdapter.Fill(this.dsSistemaTarjetas.vTarjetas);
                if (dgvTarjetas.Rows.Count == 0)
                {
                    btnDetalles.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnModificar.Enabled = false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FTarjetas fTarjetas = new FTarjetas()) {
                fTarjetas.modo = Modo.Editar;
                fTarjetas.tarjeta.codigo = Convert.ToInt32(dgvTarjetas.SelectedRows[0].Cells[0].Value);
                if (fTarjetas.ShowDialog() == DialogResult.OK) {
                    this.vTarjetasTableAdapter.Fill(this.dsSistemaTarjetas.vTarjetas);
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (!(txtCodigo.Text.Length == 0))
            {
                bsTarjetas.Filter = "Codigo =" + txtCodigo.Text;
            }
            else
            {
                bsTarjetas.Filter = "";
            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            bsTarjetas.Filter = "Cliente LIKE '" + txtCliente.Text + "%'";
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtCodigo.Enabled = true;
                txtCliente.Enabled = false;
                bsTarjetas.Filter = "";
                txtCodigo.Clear();
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) 
            {
                txtCliente.Enabled = true;
                txtCodigo.Enabled = false;
                txtCodigo.Clear();
                bsTarjetas.Filter = ""; 
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FDetallesTarjeta fDetalles = new FDetallesTarjeta();
            fDetalles.tarjeta.codigo = Convert.ToInt32(dgvTarjetas.SelectedRows[0].Cells[0].Value);
            fDetalles.Show();
        }
    }
}
