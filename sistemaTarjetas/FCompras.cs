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
    public partial class FCompras : Form
    {
        public FCompras()
        {
            InitializeComponent();
        }

        private bool encontrado = false;
        private Modo modo;
        private void FCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_articulos' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_articulos' Puede moverla o quitarla según sea necesario.
            this.v_articulosTableAdapter.Fill(this.dsSistemaTarjetas.v_articulos);
         
            bsArticulos.Position = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.ReadOnly = true;
            txtSuplidor.Enabled = true;
          
            txtCodigo.Enabled = true;
            txtCantidad.Enabled = true;
            txtCosto.Enabled = true;
            txtCodigo.Clear();
            if (dgvCompra.Rows.Count > 0 )dgvCompra.Rows.Clear();
            btnBuscarArticulo.Enabled = true;
            btnBuscarCompra.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnModificar.Enabled = false;
            btnNueva.Enabled = false;
            btnImprimir.Enabled = false;
            modo = Modo.Insertar;
            txtSuplidor.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.modo = Modo.Editar;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNueva.Enabled = false;
            btnModificar.Enabled = false;
            txtCodigo.Enabled = true;
            txtSuplidor.Enabled = true;
            txtCantidad.Enabled = true;
            txtCosto.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            encontrado = false;
            if (txtCodigo.Text.Length > 0)
            {
              
                int codigo = Convert.ToInt32(txtCodigo.Text);
                int indice = bsArticulos.Find("Codigo",codigo);
                if (indice != -1)
                {
                    encontrado = true;
                    DataRow fila = dsSistemaTarjetas.v_articulos[indice];
                    txtDescripcion.Text = (string)fila[1];
                    txtCantidad.Text = "0";
                    txtCosto.Text = ((int)fila[2]).ToString();
                    
                }
                
            }
        }

        private void soloNumeros (object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.G & e.Control)
            {
                guardar();
            }
            else if( e.KeyCode == Keys.Enter & encontrado == true)
            {
                txtCantidad.Focus();
            }
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCantidad.TextLength > 0 & txtCantidad.Text != "0")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtCosto.Focus();
                }
            }
        }

        private bool verificar()
        {
            return true;
        }

        private int total() {
            int res = 0;
            foreach (DataGridViewRow rw in dgvCompra.Rows)
            {
                res = res + (int)rw.Cells[4].Value;
            }
            return res;
        }
        private void agregar()
        {
            if (verificar())
            {
                DataRow fila = dsSistemaTarjetas.v_detalles_compra.Newv_detalles_compraRow();
                fila[0] = Convert.ToInt32(txtCodigo.Text);
                fila[1] = txtDescripcion.Text;
                fila[2] = Convert.ToInt32(txtCantidad.Text);
                fila[3] = Convert.ToInt32(txtCosto.Text);
                fila[4] = Convert.ToInt32(txtImporte.Text);
                dsSistemaTarjetas.v_detalles_compra.Rows.Add(fila);
                txtTotal.Text = total().ToString();
                if (dgvCompra.Rows.Count ==1)
                {
                    btnGuardar.Enabled = true;
                    btnCancelar.Enabled = true;
                }
                txtCodigo.Focus();
                txtCodigo.Clear();
               
            }
        }
        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCosto.TextLength > 0 & txtCosto.Text != "0")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    agregar();
                    txtCodigo.Clear();
                    
                    txtCodigo.Focus();
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.TextLength > 0 & txtCosto.TextLength > 0)
            {
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                int cost = Convert.ToInt32(txtCosto.Text);
                txtImporte.Text = (cantidad * cost).ToString();
            }
        }

        private void guardar()
        {
            if (dgvCompra.Rows.Count > 0)
            {
                int? numero = -1;

                querys.nueva_compra(dtpFecha.Value, txtSuplidor.Text, 0,ref numero);

                foreach (DataGridViewRow rw in dgvCompra.Rows)
                {
                    int codigo = (int)rw.Cells[0].Value;
                    int cantidad = (int)rw.Cells[2].Value;
                    int costo = (int)rw.Cells[3].Value;
                    int importe = (int)rw.Cells[4].Value;
                    querys.nuevo_detalle_compra(numero, codigo, cantidad, costo, importe);
                }

                txtNumero.Text = numero.ToString();
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtNumero.Enabled = true;
                txtCodigo.Enabled = false;
                txtSuplidor.Enabled = false;
                txtCosto.Enabled = false;
                txtCantidad.Enabled = false;
                btnNueva.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                txtNumero.Focus();
                txtNumero.SelectAll();
            }
        }
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            using (FBuscarArticulo fBuscar = new FBuscarArticulo())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int codigo = fBuscar.articulo;
                    encontrado = true;
                    txtCodigo.Text = codigo.ToString();
                }
            }
        }

        private void txtSuplidor_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSuplidor.Text.Length > 0 & e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (this.modo)
            {
                case Modo.Insertar:
                    guardar();
                    encontrado = false;
                    break;
                case Modo.Editar:
                    break;
                default:
                    break;
            }
         
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtSuplidor.Clear();
            txtTotal.Text = "";
            dtpFecha.Value = DateTime.Today;
            if (dsSistemaTarjetas.v_detalles_compra.Rows.Count > 0) dsSistemaTarjetas.v_detalles_compra.Rows.Clear();
            if (txtNumero.Text.Length > 0)
            {
                int num = Convert.ToInt32(txtNumero.Text);
                int? res = querys.compra_existe(num);
             
                if (res > 0)
                {
                    DateTime? fecha = DateTime.Today;
                    string suplidor = "";
                    int? total = 0;
                    querys.conseguir_compra(num, ref suplidor, ref fecha, ref total);
                    txtSuplidor.Text = suplidor;
                    txtTotal.Text = total.ToString();
                    dtpFecha.Value = fecha.Value;
                    v_detalles_compraTableAdapter.Fill(dsSistemaTarjetas.v_detalles_compra, num);
                    btnNueva.Enabled = true;
                    btnModificar.Enabled = true;


                }
            }
        }
    }
}
