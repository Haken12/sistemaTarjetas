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
        private Modo modo = Modo.Ver;
        private bool vendedorSi = false;
        private bool articuloSi = false;
        private int? numeroDevolucion = -1;
        private int? idVendedor = -1;
        private string nombreVendedor = "";
        private int? cantidadArticulos = 0;
        private int? total = 0;
        private DateTime? fecha = DateTime.Today;

        private void despejar()
        {
            txtCodigoVendedor.Clear();
            dtpFecha.Value = DateTime.Today;
            txtTotal.Text = "0";
        }

        private void inicializar()
        {
         numeroDevolucion = -1;
         idVendedor = -1;
         nombreVendedor = "";
         cantidadArticulos = 0;
         total = 0;
    }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Insertar;
            despejar();
            inicializar();
            txtNumero.Enabled = false;
            btnBuscarDevolucion.Enabled = false;
            txtCodigoVendedor.Enabled = true;
            btnBuscarVendedor.Enabled = true;
            dgvArticulos.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            using (FBuscarVendedor fBuscar = new FBuscarVendedor())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.Id;
                    txtCodigoVendedor.Text = res.ToString();
                }
            }
        }

        private void txtCodigoVendedor_TextChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Insertar)
            {
                txtNombre.Text = "";
                vendedorSi = false;
                
                if (txtCodigoVendedor.TextLength > 0)
                {
                    int id = Convert.ToInt32(txtCodigoVendedor.Text);
                    if (querys.vendedor_existe(id) != 0)
                    {
                        vendedorSi = true;
                        txtNombre.Text = (string)querys.nombreVendedor(id);
                    }
                }
            }
        }

        private bool verficar()
        {
            if (modo == Modo.Insertar & !vendedorSi)
            {
                MessageBox.Show("Elija un vendedor");
                txtCodigoVendedor.Focus();
                return false;
            }
            return true;
        }

        private void asignar()
        {
            idVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
            nombreVendedor = txtNombre.Text;
            cantidadArticulos = dgvArticulos.Rows.Count;
            fecha = dtpFecha.Value;
           
        }
        private void crear()
        {
            
        }
        private void guardar()
        {
            if (verficar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        asignar();
                        crear();
                        txtNumero.Text = numeroDevolucion.ToString();
                        txtCodigoVendedor.Enabled = false;
                        btnBuscarVendedor.Enabled = false;
                        break;
                    case Modo.Editar:
                        txtCodigo.Enabled = false;
                        btnBuscarProducto.Enabled = false;
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtNumero.Enabled = true;
                btnBuscarDevolucion.Enabled = true;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (FSeleccionarArticulo fBuscar = new FSeleccionarArticulo())
            {
                fBuscar.vendedor = Convert.ToInt32(txtCodigoVendedor.Text);
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.articulo;
                    txtCodigo.Text = res.ToString();
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Editar)
            {
               
             
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = Modo.Editar;
            
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            dgvArticulos.Enabled = true;
            txtCodigo.Enabled = true;
            btnBuscarProducto.Enabled = true;
            txtCodigo.Focus();
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (articuloSi & txtPrecio.Text.Length > 0)
            {
                txtImporte.Text = (Convert.ToInt32(txtCantidad.Value) * Convert.ToInt32(txtPrecio.Text)).ToString();
            }
        }

        private bool comprobar()
        {
            return true;
        }

        private int calcularTotal()
        {
            int sigma = 0;
            foreach (DataGridViewRow r in dgvArticulos.Rows)
            {
                sigma += (int)r.Cells[5].Value;
            }
            return sigma;
        }
        private void agregar()
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            int precio = Convert.ToInt32(txtPrecio.Text);
            int valor = cantidad * precio;
            txtTotal.Text = calcularTotal().ToString();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (comprobar())
            {
                agregar();
            }
        }

        private void dgvArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if(modo == Modo.Editar & e.KeyCode == Keys.Delete & dgvArticulos.SelectedRows.Count > 0)
            {
               
            }
        }

        private void cancelar()
        {
            if (Metodos.Confirmar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        
                        despejar();
                        modo = Modo.Ver;
                        inicializar();
                      
                        txtCodigoVendedor.Enabled = false;
                        btnBuscarVendedor.Enabled = false ;

                        break;
                    case Modo.Editar:
                        btnEliminar.Enabled = true;
                        txtCodigo.Clear();
                        txtCodigo.Enabled = false;
                        btnBuscarProducto.Enabled = false;
                        dgvArticulos.Enabled = false;
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                txtNumero.Enabled = true;
                btnBuscarDevolucion.Enabled = true;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarDevolucion_Click(object sender, EventArgs e)
        {
            using (FBuscarDevolucion fBuscar = new FBuscarDevolucion()) { 
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.seleccion;
                    txtNumero.Text = res.ToString();
                }
            }
        }
    }
}
