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
    public partial class FBuscarTarjeta : Form
    {
        public FBuscarTarjeta()
        {
            InitializeComponent();
        }

        public int seleccion = -1;
        private void FBuscarTarjeta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_tarjetas' Puede moverla o quitarla según sea necesario.
            this.v_tarjetasTableAdapter.Fill(this.dsSistemaTarjetas.v_tarjetas);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvTarjetas.Rows.Count == 0)
            {
                MessageBox.Show("No hay ninguna tarjeta", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.None;
            }
            else
            {
                if (dgvTarjetas.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe elegir una tarjeta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.DialogResult = DialogResult.None;
                }
                else
                {
                    seleccion = (int)dgvTarjetas.SelectedCells[0].Value;
                }
            }
        }
    }
}
