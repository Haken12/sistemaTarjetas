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
    public partial class FDevolucionVendedorB : Form
    {
        public FDevolucionVendedorB()
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
            dtpFecha.Enabled = true;
            dgvArticulos.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            int? c = 0;
            queriesNuevo.siguienteDevolucion(ref c, dtpFecha.Value);
            txtNumero.Text = c.ToString();
            txtCodigoVendedor.Focus();
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
            switch (modo)
            {
                case Modo.Insertar:
                    txtCodigo.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    vendedorSi = false;
                    if (txtCodigoVendedor.TextLength > 0)
                    {
                        int vendedor = Convert.ToInt32(txtCodigoVendedor.Text);
                        if (querys.vendedor_existe(vendedor) != 0)
                        {
                            MessageBox.Show("a");
                            txtNombre.Text = (string)querys.nombreVendedor(vendedor);
                            vendedorSi = true;
                            txtCodigo.Enabled = true;
                            btnBuscarProducto.Enabled = true;
                            idVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
                            v_inventario_vendedorTableAdapter.Fill(dsDespachos.v_inventario_vendedor, idVendedor);
                        }
                    }
                    break;
                case Modo.Editar:
                    break;
                case Modo.Ver:
                    break;
                default:
                    break;
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
            if (modo == Modo.Insertar && dgvArticulos.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar por lo menos un producto");
                txtCodigo.Focus();
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
            queries.nueva_devolucion(fecha, idVendedor, ref numeroDevolucion);
        }
        private void guardar()
        {
            if (verficar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        txtCodigoVendedor.Enabled = false;
                        btnBuscarVendedor.Enabled = false;
                        break;
                    case Modo.Editar:
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                int dev = Convert.ToInt32(txtNumero.Text);
                int ven = Convert.ToInt32(txtCodigoVendedor.Text);
                queriesNuevo.guardarDevolucion(dev, ven, calcularTotal(), dtpFecha.Value);
                foreach (dsDespachos.detalles_devolucionesRow  fila in dsDespachos.detalles_devoluciones)
                {
                    {
                        queries.eliminarDetalleDevolucion(dev, (int)fila["Codigo"]);
                        queries.nuevo_detalle_devolucion(dev,
                        fila.Codigo,
                        fila.Cantidad,
                        fila.Precio,
                        fila.Valor);
                    }
                }
                foreach(dsDespachos.detalles_devolucionesERow fila in dsDespachos.detalles_devolucionesE)
                {
                    queries.eliminarDetalleDevolucion(dev, fila.Codigo);
                }
                if (dsDespachos.detalles_devolucionesE.Rows.Count > 0) dsDespachos.detalles_devolucionesE.Rows.Clear();
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = true;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtNumero.Enabled = true;
                btnBuscarDevolucion.Enabled = true;
                dtpFecha.Enabled = false;
                txtCodigo.Clear();
                txtCodigo.Enabled = false;
                btnBuscarProducto.Enabled = false;
                dgvArticulos.Enabled = false;
                txtNumero.Focus();
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
           
                txtDescripcion.Clear();
            txtExistencias.Text = "0";
                txtPrecio.Text = "0";
                txtCantidad.Value = 0;
                txtImporte.Text = "0";
                articuloSi = false;
                txtCantidad.Enabled = false;
                if (txtCodigo.Text.Length > 0)
                {
                    int cod = Convert.ToInt32(txtCodigo.Text);
                    DataRow rw = dsDespachos.v_inventario_vendedor.FindByCodigo(cod);
                    if (rw == null)
                    {
                    txtDescripcion.Text = "No en inventario del vendedor";
                    }
                    else
                    {
                        txtDescripcion.Text = (string)rw[1];
                        txtPrecio.Text = ((int)rw[2]).ToString();
                        txtExistencias.Text = ((int)rw[3]).ToString();
                        txtCantidad.Maximum = (int)rw[3];
                        articuloSi = true;
                        txtCantidad.Enabled = true;
                    }
                }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = Modo.Editar;
            idVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
            v_inventario_vendedorTableAdapter.Fill(dsDespachos.v_inventario_vendedor, idVendedor);
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
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
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            int precio = Convert.ToInt32(txtPrecio.Text);
            int valor = cantidad * precio;
            int codigo = Convert.ToInt32(txtCodigo.Text);
            DataRow fila = null;
             fila = dsDespachos.detalles_devoluciones.Rows.Find(codigo);
            if (fila != null)
            {
                fila["Cantidad"] =  (int)fila["Cantidad"] + cantidad;
                fila["Valor"] = (int)fila["Valor"] + valor;
            }
            else
            {
                fila = dsDespachos.detalles_devoluciones.Newdetalles_devolucionesRow();
                fila["Codigo"] = codigo;
                fila["Descripcion"] = txtDescripcion.Text;
                fila["Precio"] = precio;
                fila["Cantidad"] = cantidad;
                fila["Valor"] = valor;
                dsDespachos.detalles_devoluciones.Rows.Add(fila);
            }
            txtTotal.Text = calcularTotal().ToString();
            dsDespachos.v_inventario_vendedor.FindByCodigo(codigo).Existencias -= cantidad;
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (comprobar() && e.KeyCode == Keys.Enter)
            {
                agregar();
            }
        }

        private void dgvArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode == Keys.Delete & dgvArticulos.SelectedRows.Count > 0)
            {
               if (Metodos.Confirmar())
                {
                    int codigo = (int)dgvArticulos.SelectedCells[0].Value;
                    var fila = dsDespachos.detalles_despacho.FindByCodigo(codigo);
                    int cantidad = fila.Cantidad;
                    dsDespachos.v_inventario_vendedor.FindByCodigo(codigo).Existencias += cantidad;
                    dsDespachos.detalles_despachoE.ImportRow(fila);    
                    dsDespachos.detalles_despacho.Rows.Remove(fila);
                    txtTotal.Text = calcularTotal().ToString();
                }
            }
        }

        private void cancelar()
        {
            if (Metodos.Confirmar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        queriesNuevo.cancelarDevolucion(Convert.ToInt32(txtNumero.Text));
                        despejar();
                        modo = Modo.Ver;
                        inicializar();
                        txtNumero.Clear();
                        if (dsDespachos.detalles_devoluciones.Rows.Count > 0) dsDespachos.detalles_devoluciones.Rows.Clear();
                        txtCodigoVendedor.Enabled = false;
                        btnBuscarVendedor.Enabled = false;
                        break;
                    case Modo.Editar:
                        btnEliminar.Enabled = true;
                        btnModificar.Enabled = true;
                        txtCodigo.Clear();
                        txtCodigo.Enabled = false;
                        btnBuscarProducto.Enabled = false;
                        idVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
                        v_inventario_vendedorTableAdapter.Fill(dsDespachos.v_inventario_vendedor, idVendedor);
                        dgvArticulos.Enabled = false;
                        detalles_devolucionesTableAdapter.Fill(dsDespachos.detalles_devoluciones, Convert.ToInt32(txtNumero.Text));
                        if (dsDespachos.detalles_devolucionesE.Rows.Count > 0) dsDespachos.detalles_devolucionesE.Rows.Clear();
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                txtCodigoVendedor.Enabled = false;
                btnBuscarVendedor.Enabled = false;
                txtCodigoVendedor.Clear();
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
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

        private void txtCodigoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (vendedorSi && e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi && e.KeyCode == Keys.Enter)
            {
                txtCantidad.Focus();
            }
        }

        private void FDevolucionVendedorB_Load(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (txtCodigoVendedor.Enabled) txtCodigoVendedor.Enabled = false;
        }

        private void dgvArticulos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dgvArticulos.Rows.Count == 0 && !txtCodigoVendedor.Enabled) txtCodigoVendedor.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{dsDespachos.detalles_devoluciones.Rows.Count},E:{dsDespachos.detalles_devolucionesE.Rows.Count}");

        }
    }
}
