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
    public partial class FDevolucionVendedor : Form
    {
        public FDevolucionVendedor()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FDevolucionVendedor_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigoVendedor_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            dsSistemaTarjetas.v_inventario_vendedor.Clear();
            if (txtCodigoVendedor.TextLength > 0) 
            {              
                int id = Convert.ToInt32(txtCodigoVendedor.Text);
                if (querys.vendedor_existe(id) != 0 )
                {
                    txtNombre.Text = (string)querys.nombreVendedor(id);
                    txtCodigo.Enabled = true;
                    txtCantidad.Enabled = true;
                    v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor, id);
                    txtCodigo.Focus();
                }
            }
            
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtImporte.Clear();
            txtCantidad.Value = 0;
            if (txtCodigo.TextLength > 0)
            {
                int id = Convert.ToInt32(txtCodigo.Text);
                DataRow fila = dsSistemaTarjetas.v_inventario_vendedor.FindByCodigo(id);
                if (fila != null) 
                {
                    txtDescripcion.Text = (string)fila[1];
                    txtPrecio.Text = ((int)fila[2]).ToString();
                    txtCantidad.Maximum = (int)fila[3];
                    txtCantidad.Focus();
                }
            }
        }
    }
}
