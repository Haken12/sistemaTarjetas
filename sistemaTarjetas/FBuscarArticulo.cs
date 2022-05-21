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
    public partial class FBuscarArticulo : Form
    {
        public FBuscarArticulo()
        {
            InitializeComponent();
        }

        public int articulo = -1;

        private void FBuscarArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_articulos' Puede moverla o quitarla según sea necesario.
            this.v_articulosTableAdapter.Fill(this.dsSistemaTarjetas.v_articulos);

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0) articulo = (int)dgvBuscar.SelectedCells[0].Value;
            else this.DialogResult = DialogResult.None;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtDescripcion.TextLength > 0)
            {
                bsBuscar.Filter = $@"Descripcion LIKE '{txtDescripcion.Text}%'";
            }
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                articulo = (int)dgvBuscar.SelectedCells[0].Value;
                this.DialogResult = DialogResult.OK;
            }
            else this.DialogResult = DialogResult.None;
        }
    }
}
