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
    public partial class FBuscarDespachos : Form
    {
        public int seleccion = -1;
        public FBuscarDespachos()
        {
            InitializeComponent();
        }

        private void dgvBuscar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                seleccion = (int)dgvBuscar.SelectedCells[0].Value;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void FBuscarDespachos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDespachos.verDespachos' Puede moverla o quitarla según sea necesario.
            this.verDespachosTableAdapter.Fill(this.dsDespachos.verDespachos);

        }

        private void rbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVendedor.Checked)
            {
                bsBuscar.Filter = "";
                txtVendedor.Enabled = true;
                dtpFecha1.Enabled = false;
                dtpFecha2.Enabled = false;
            }
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFecha.Checked)
            {
                bsBuscar.Filter = "";
                dtpFecha1.Enabled = true;
                dtpFecha2.Enabled = true;
                txtVendedor.Enabled = false;
            }
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = $"Vendedor LIKE '{txtVendedor.Text}%'";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha2.MinDate = dtpFecha1.Value;
            bsBuscar.Filter = $"Fecha BETWEEN {dtpFecha1.Value.ToShortDateString()} AND {dtpFecha2.Value.ToShortDateString()}";
        }

        private void dtpFecha2_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha1.MaxDate = dtpFecha2.Value;
            bsBuscar.Filter = $"Fecha BETWEEN {dtpFecha1.Value.ToShortDateString()} AND {dtpFecha2.Value.ToShortDateString()}";
        }
    }
}
