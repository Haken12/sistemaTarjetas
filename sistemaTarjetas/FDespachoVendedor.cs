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
    public partial class FDespachoVendedor : Form
    {
        public FDespachoVendedor()
        {
            InitializeComponent();
        }
        private Modo modo = Modo.Ver;
        private bool vendedorSi = false;
        private bool devolucionSi = false;
        private bool articuloSi = false;
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
            vendedorSi = false;
            txtNombre.Clear();
            dsSistemaTarjetas.v_inventario_vendedor.Clear();
            if (txtCodigoVendedor.TextLength > 0)
            {
                int id = Convert.ToInt32(txtCodigoVendedor.Text);
                if (querys.vendedor_existe(id) != 0)
                {
                    vendedorSi = true;
                    txtNombre.Text = (string)querys.nombreVendedor(id);
                    txtCodigo.Enabled = true;
                    txtCantidad.Enabled = true;
                    v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor, id);
                    
                }
            }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtCodigoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (vendedorSi == true & e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi == true & e.KeyCode == Keys.Enter)
            {
                txtCantidad.Focus();
            }
        }

        private void agregar()

        {
            DataRow dr = dsSistemaTarjetas.detalles_devoluciones.Newdetalles_devolucionesRow();
            dr[1] = Convert.ToInt32(txtCodigo.Text);
            dr[2] = txtDescripcion.Text;
            dr[3] = Convert.ToInt32(txtCantidad.Value);
            dr[4] = Convert.ToInt32(txtPrecio.Text);
            dr[5] = Convert.ToInt32(txtImporte.Text);
            dsSistemaTarjetas.detalles_devoluciones.Rows.Add(dr);
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi == true & txtCantidad.Value > 0 & e.KeyCode == Keys.Enter)
            {
                agregar();
            }
        }
        private bool verificar()
        {
            if (dgvArticulos.Rows.Count == 0)
            {
                return false;
            }
            if (modo == Modo.Editar)
            {
                return false;
            }
            return true;
        }
        private void guardar()
        {
            if (verificar())
            
            {
                int? n = null;
                querys.nueva_devolucion(dtpFecha.Value, Convert.ToInt32(txtCodigoVendedor.Text), ref n);
                foreach (DataRow dr in dsSistemaTarjetas.detalles_devoluciones)
                {
                    querys.nuevo_detalle_devolucion(n, (int)dr[1], (int)dr[3], (int)dr[4], (int)dr[5]);
                    
                }
                dgvArticulos.Rows.Clear();
                this.modo = Modo.Editar;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtNumero.Text = n.ToString();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtCodigoVendedor.Clear();
            txtCodigo.Clear();
            if (txtNumero.TextLength > 0)
            {
                int num = Convert.ToInt32(txtNumero.Text);
                DateTime? fecha = DateTime.Today;
                int? idV = null;
                int? total = null;
                string nombre = "";
                querys.conseguir_devolucion(num,ref fecha,ref idV, nombre,ref total);
                if  (idV != null)
                {
                    txtCodigoVendedor.Text = idV.ToString();
                    txtTotal.Text = total.ToString();
                    dtpFecha.Value = fecha.Value;
                    modo = Modo.Editar;
                }
                
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.TextLength > 0)
            {
                int cod = Convert.ToInt32(txtCodigo.Text);
                DataRow dr = dsSistemaTarjetas.v_inventario_vendedor.FindByCodigo(cod);
                if (dr != null)
                {
                    articuloSi = true;
                    txtDescripcion.Text = (string)dr[1];
                    txtPrecio.Text = ((int)dr[2]).ToString();
                }
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.TextLength > 0)
            {
                txtImporte.Text = (Convert.ToInt32(txtPrecio.Text) * txtCantidad.Value).ToString();
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtPrecio.TextLength > 0)
            {
                txtImporte.Text = (Convert.ToInt32(txtPrecio.Text) * txtCantidad.Value).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
            dtpFecha.Enabled = true;
            txtCodigoVendedor.Enabled = true;
            txtNumero.Clear();
            modo = Modo.Insertar;
            txtCodigoVendedor.Clear();
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtCodigoVendedor.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
