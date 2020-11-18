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
    public partial class FAjustarInventario : Form
    {
        public FAjustarInventario()
        {
            InitializeComponent();
        }

        private void FAjustarInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_articulos' Puede moverla o quitarla según sea necesario.
            this.v_articulosTableAdapter.Fill(this.dsSistemaTarjetas.v_articulos);
            rbReemplazar.Checked = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                bsArticulos.Position = bsArticulos.Find("Codigo", codigo);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FBuscarArticulo fBuscar = new FBuscarArticulo())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int codigo = fBuscar.articulo;
                    txtCodigo.Text = codigo.ToString();
                }
            }
        }

        private void aplicar()
        {
            if (txtCantidad.TextLength > 0 & (txtArticulo.Text != ""))
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                if (rbReemplazar.Checked)
                {
                    querys.ajustar_producto_a(codigo, cantidad);
                }
                else if (rbSumar.Checked)
                {
                    querys.ajustar_producto_b(codigo, cantidad);
                }

                int posicion = bsArticulos.Position;
                v_articulosTableAdapter.Fill(dsSistemaTarjetas.v_articulos);
                bsArticulos.Position = posicion;

                txtCodigo.Clear();
                
                txtCantidad.Text = "0";
                
                txtCodigo.Focus();
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            aplicar();          
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) aplicar();
            else e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
