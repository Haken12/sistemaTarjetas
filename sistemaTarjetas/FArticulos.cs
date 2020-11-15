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
    public partial class FArticulos : Form
    {
        public FArticulos()
        {
            InitializeComponent();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.TextLength == 0) bsBuscar.Filter = "";
            else
            {
                switch (cbxBuscar.SelectedIndex)
                {
                    case 0:
                        bsBuscar.Filter = $"Codigo >={Convert.ToInt32(txtBuscar.Text)}";
                        break;
                    case 1:
                        bsBuscar.Filter = $"Descripcion LIKE '{txtBuscar.Text}%'";
                        break;
                    default:
                        break;
                }
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxBuscar.SelectedIndex == 0)
            {
                if (Char.IsDigit(e.KeyChar)) return;
                if (Char.IsControl(e.KeyChar)) return;
                e.Handled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FArticulos_Load(object sender, EventArgs e)
        {
            cbxBuscar.SelectedIndex = 0;
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_articulos' Puede moverla o quitarla según sea necesario.
            this.v_articulosTableAdapter.Fill(this.dsSistemaTarjetas.v_articulos);

        }

        private void cbxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
