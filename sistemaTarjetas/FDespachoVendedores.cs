using System;
using System.Windows.Forms;
using System.Data;

namespace sistemaTarjetas
{
    public partial class FDespachoVendedores : Form
    {
        public FDespachoVendedores()
        {
            InitializeComponent();
        }

        private void crear() 
        {
            int vendedor = Convert.ToInt32(txtVendedor.Text);
            int? numero =null;
            int articulos = Convert.ToInt32(lblArticulos.Text);
            int importeTotal = Convert.ToInt32(txtTotal.Text);
            
            querys.nuevo_despacho(vendedor, txtObservacion.Text, articulos, importeTotal,dtpFecha.Value ,ref numero);
            foreach (DataRow row in dsSistemaTarjetas.despacho.Rows)
            {
                int codigo = Convert.ToInt32(row[0]);
                int precioP = Convert.ToInt32(row[2]);
                int cantidadP = Convert.ToInt32(row[3]);
                int importeP = Convert.ToInt32(row[4]);
                int idVendedor = Convert.ToInt32(txtVendedor.Text);
                querys.nuevo_detalle_despacho(numero, codigo, precioP, cantidadP, importeP);
                querys.despachar_vendedor(codigo, idVendedor, cantidadP);
            }

            
        }
        private void soloNumero(object sender, KeyPressEventArgs e) 
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;           
            e.Handled = true;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtPrecio.Enabled = false;
            txtCantidad.Enabled = false;
            txtInventario.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtCantidad.Text = "0";
            txtImporte.Text = "0";
            if (txtCodigo.Text.Length > 0) 
            {
                int codigo = Convert.ToInt32(txtCodigo.Text);
                string descripcion = "";
                int? precio = -1;
                int? costo = -1;
                int? inventario = -1;

                querys.unico_producto(codigo, ref descripcion, ref costo, ref precio, ref inventario);
                if (inventario != -1) 
                {
                    txtDescripcion.Text = descripcion;
                    txtPrecio.Text = precio.ToString();
                    txtInventario.Text = inventario.ToString();
                    inventario = -1;
                    txtCantidad.Enabled = true;
                    txtPrecio.Enabled = true;
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void agregar() 
        {
            DataRow fila = dsSistemaTarjetas.despacho.NewRow();
            fila[0] = Convert.ToInt32(txtCodigo.Text);
            fila[1] = txtDescripcion.Text;
            fila[2] = Convert.ToInt32(txtPrecio.Text);
            fila[3] = Convert.ToInt32(txtCantidad.Text);
            fila[4] = Convert.ToInt32(txtImporte.Text);

            DataRow fila2 = dsSistemaTarjetas.despacho.Rows.Find(Convert.ToInt32(txtCodigo.Text));
            if (fila2 == null) { 
                dsSistemaTarjetas.despacho.Rows.Add(fila);
                lblArticulos.Text = (Convert.ToInt32(lblArticulos.Text) + 1).ToString();
                }
            else 
            {
                int actuales = (int)fila2[3];
                int nuevos = Convert.ToInt32(txtCantidad.Text);
                int inventario = Convert.ToInt32(txtInventario.Text);
                if (actuales + nuevos > inventario) 
                {
                    MessageBox.Show("Excede la cantidad en inventario","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }
                else 
                {
                    fila2[3] = actuales + nuevos;
                    int importeActual = (int)fila2[4];
                    int nuevoImporte = Convert.ToInt32(txtImporte.Text);
                    fila2[4] = importeActual + nuevoImporte;
                    
                   
                }
               // int c = dsSistemaTarjetas.despacho.Rows.IndexOf(fila2);
            }
            int total = 0;
            foreach (DataRow fl in dsSistemaTarjetas.despacho.Rows)
            {
                total += (int)fl[4];
            }
            txtTotal.Text = total.ToString();
            int numArticulos = Convert.ToInt32(lblArticulos.Text);
            lblArticulos.Text = (++numArticulos).ToString();
            if (!btnGuardar.Enabled) 
            {
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            txtCodigo.Clear();
            txtCodigo.Focus();

        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) agregar();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.TextLength != 0 & txtPrecio.TextLength != 0) 
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int precio = Convert.ToInt32(txtPrecio.Text);
                int importe = cantidad * precio;
               
                txtImporte.Text = importe.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            txtNumero.Clear();
            txtNumero.Enabled = false;
            txtVendedor.Clear();
            txtNombre.Clear();
            txtVendedor.Enabled = true;
            dtpFecha.Enabled = true;
            dtpFecha.Value = DateTime.Today;
            dsSistemaTarjetas.despacho.Rows.Clear();
            
            btnGuardar.Enabled = true;
            btnBuscarVendedor.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            txtVendedor.Focus();
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            dsSistemaTarjetas.despacho.Rows.Clear();
            txtCodigo.Enabled = false;
            txtCodigo.Clear();
            if (txtVendedor.TextLength > 0)
            {
                int numero = Convert.ToInt32(txtVendedor.Text);
                if (querys.vendedor_existe(numero) != 0) 
                {
                    btnBuscarDespacho.Enabled = false;   
                    txtNombre.Text = querys.nombreVendedor(numero).ToString();
                    txtCodigo.Enabled = true;
                    txtCantidad.Enabled = true;
                    dtpFecha.Enabled = true;
                    txtObservacion.Enabled = true;
                    
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            crear();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            dtpFecha.Enabled = false;
            txtCantidad.Enabled = false;
            dsSistemaTarjetas.despacho.Rows.Clear();
            txtVendedor.Clear();
            txtVendedor.Focus();
            txtObservacion.Clear();
            txtTotal.Clear();
            lblArticulos.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) 
            {
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                dtpFecha.Enabled = false;
              
                dsSistemaTarjetas.despacho.Rows.Clear();
                txtVendedor.Clear();
               
                txtObservacion.Clear();
                txtTotal.Clear();
                lblArticulos.Text = "0";
                txtNumero.Enabled = true;
                btnNuevo.Enabled = true;
                txtVendedor.Enabled = false;
                txtCodigo.Enabled = false;
                txtCantidad.Enabled = false;
                txtCodigo.Focus();
                
            }
        }

        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            using (FBuscarArticulo fBuscar = new FBuscarArticulo())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.articulo;
                    txtCodigo.Text = res.ToString();
                }
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            using (FBuscarVendedor fBuscar = new FBuscarVendedor())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int vendedor = fBuscar.Id;
                    txtVendedor.Text = vendedor.ToString();
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & (txtDescripcion.Text !="")) 
            {
                txtCantidad.Focus();
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & (txtNombre.Text != ""))
            {
                txtCodigo.Focus();
            } 
        }
    }
}
