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
    public partial class FBuscarDevolucion : Form
    {
        public FBuscarDevolucion()
        {
            InitializeComponent();
        }

        public int seleccion = 0;
        private void FBuscarDevolucion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDespachos.verDevoluciones' Puede moverla o quitarla según sea necesario.
            

        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            string filtro = $"Vendedor ={txtVendedor.Text}";
            if (ckbFecha.Checked)
            {
                filtro = filtro + string.Format(" And Fecha >= #{0:yyyy-MM-dd}#", dtpFecha.Value);
            }
            bsBuscar.Filter = filtro;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.Rows.Count > 0)
            {
                seleccion = (int)dgvBuscar.SelectedCells[0].Value;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una devolucion");
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
