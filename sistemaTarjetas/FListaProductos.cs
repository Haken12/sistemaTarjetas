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
    public partial class FListaProductos : Form
    {
        public FListaProductos()
        {
            InitializeComponent();
        }

        private void FListaProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vProductos' Puede moverla o quitarla según sea necesario.
            this.vProductosTableAdapter.Fill(this.dsSistemaTarjetas.vProductos);
            if (dgvProductos.Rows.Count > 0) 
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(FProducto fProducto = new FProducto())
            {
                fProducto.modo = Modo.Insertar;
                if (fProducto.ShowDialog() == DialogResult.OK) {
                    vProductosTableAdapter.Fill(dsSistemaTarjetas.vProductos);
                    if (btnModificar.Enabled == false) { 
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            using (FProducto fProducto = new FProducto())
            {
                fProducto.modo = Modo.Editar;
                fProducto.producto.codigo = Convert.ToInt32(dgvProductos.SelectedRows[0].Cells[0].Value);
                if (fProducto.ShowDialog() == DialogResult.OK)
                {
                    vProductosTableAdapter.Fill(dsSistemaTarjetas.vProductos);                   
                }
            }
        }
    }
}
