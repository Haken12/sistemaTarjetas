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
    public partial class FDespachoVendedorB : Form
    {
        private  class Despacho
        {
            public static int? Numero = -1;
            public static int? IdVendedor =-1;
            public static string Nombre = "";
            public static DateTime? Fecha = DateTime.Today;
            public static int? Total = 0;
            public static int? CantidadArticulos = 0;
            public static string Observacion;
        }


        private Modo modo = Modo.Ver;
        private bool vendedorSi = false;
        private bool productoSi = false;
        private Despacho despacho = new Despacho();
        private bool articuloSi = false;
        DataRow rw;
        public FDespachoVendedorB()
        {
            InitializeComponent();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int calcularTotal() 
        {
            int sigma = 0;
            foreach (DataGridViewRow data in dgvDetalles.Rows)
            {
                sigma = sigma + (int)data.Cells[5].Value;
            }
            return sigma;
        }
        public void cargar()
        {
            txtCodigoVendedor.Text = Despacho.IdVendedor.ToString();
            txtNombre.Text = Despacho.Nombre;
            txtTotal.Text = Despacho.Total.ToString();
            dtpFecha.Value = Despacho.Fecha.Value;
            
        }

        public void asignar()
        {
            Despacho.IdVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
            Despacho.Nombre = txtNombre.Text;
            Despacho.Fecha = dtpFecha.Value;
            Despacho.Total = Convert.ToInt32(txtTotal.Text);
            Despacho.CantidadArticulos = dgvDetalles.Rows.Count;
        }

        public bool existe()
        {

            return true;
        }

        public void conseguir()
        {
            queries.conseguir_despacho(Despacho.Numero,
                    ref Despacho.IdVendedor, 
                    ref Despacho.Nombre, 
                    ref Despacho.Observacion, 
                    ref Despacho.CantidadArticulos, 
                    ref Despacho.Total, 
                    ref Despacho.Fecha);
        }

        private void despejar()
        {
            txtCodigoVendedor.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Text = "0";
            txtCantidad.Value = 0;
            txtImporte.Text = "0";
            txtTotal.Text = "0";
            if (dsDespachos.detalles_despacho.Rows.Count > 0) dsDespachos.detalles_despacho.Rows.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    break;
                case Modo.Editar:
                    break;
                case Modo.Ver:
                    despejar();
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    if (txtNumero.TextLength > 0)
                    {
                        Despacho.Numero = Convert.ToInt32(txtNumero.Text);
                        if (queries.despacho_existe(Despacho.Numero) !=0)
                        {
                            conseguir();
                            cargar();
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                            detalles_despachoTableAdapter.Fill(dsDespachos.detalles_despacho, Despacho.Numero);
                        }
                    }

                    break;
                default:
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Insertar;
            despejar();
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            dtpFecha.Enabled = true;
            btnCancelar.Enabled = true;
            int? a = 0;
            txtNumero.Text = queriesNuevo.siguienteDespacho(ref a, dtpFecha.Value).ToString();
            Despacho.Numero = Convert.ToInt32(txtNumero.Text);
            txtNumero.Enabled = false;
            btnBuscarDevolucion.Enabled = false;
            txtCodigoVendedor.Enabled = true;
            btnBuscarVendedor.Enabled = true;
            txtCodigoVendedor.Focus();
            txtCodigoVendedor.SelectAll();
        }

        private void soloNumeros(object sender , KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        private void crear()
        {
            queries.nuevo_despacho(ref Despacho.Numero, Despacho.IdVendedor, "", Despacho.CantidadArticulos, Despacho.Total, Despacho.Fecha);
        }
        private bool verificar()
        {
            if (modo == Modo.Insertar & !vendedorSi)
            {
                MessageBox.Show("Elija un vendedor");
                return false;
            }
            if (modo == Modo.Insertar && dgvDetalles.Rows.Count == 0) 
            {
                MessageBox.Show("Debe agregar por lo menos un producto");
                return false;
            }
            return true;
        }
        private void guardar()
        {
            if ( verificar()){
                switch (modo)
                {
                    case Modo.Insertar:
                        queriesNuevo.guardarDespacho(Despacho.Numero, Convert.ToInt32(txtCodigoVendedor.Text), 0, dgvDetalles.Rows.Count, Convert.ToInt32(txtTotal.Text));                       
                        break;
                    case Modo.Editar:
                        queriesNuevo.guardarDespacho(Despacho.Numero, Convert.ToInt32(txtCodigoVendedor.Text), 0, dgvDetalles.Rows.Count, Convert.ToInt32(txtTotal.Text));
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                foreach (DataRow row in dsDespachos.detalles_despacho.Rows)
                {
                    queries.eliminarDetalleDespacho(Despacho.Numero, (int)row[0], (int)row[1], Convert.ToInt32(txtCodigoVendedor.Text), (int)row[3]);
                    queries.nuevo_detalle_despacho(Despacho.Numero, (int)row[1], (int)row[4], (int)row[3], (int)row[5]);
                }
                dgvDetalles.Enabled = true;
                modo = Modo.Ver;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                dtpFecha.Enabled = false;
                txtCodigo.Enabled = false;
                txtCodigoVendedor.Clear();
                txtCodigoVendedor.Enabled = false;
                btnBuscarProducto.Enabled = false;
                btnBuscarVendedor.Enabled = false;
                btnBuscarDevolucion.Enabled = true;
                txtNumero.Focus(); 
            }
        
        }
        private void txtCodigoVendedor_TextChanged(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    txtNombre.Clear();
                    txtCodigo.Enabled = false;
                    btnBuscarProducto.Enabled = false;
                    txtCodigo.Clear();
                    vendedorSi = false;                    
                    if(txtCodigoVendedor.TextLength > 0)
                    {
                        int vendedor = Convert.ToInt32(txtCodigoVendedor.Text);
                       if (querys.vendedor_existe(vendedor) != 0)
                        {
                            txtNombre.Text = (string)querys.nombreVendedor(vendedor);                            
                            vendedorSi = true;
                            txtCodigo.Enabled = true;
                            btnBuscarProducto.Enabled = true;
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = Modo.Editar;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;            
            dgvDetalles.Enabled = true;
            txtCodigo.Enabled = true;
            btnBuscarProducto.Enabled = true;
            txtCodigo.Focus();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            articuloSi = false;
                txtDescripcion.Clear();
                txtCantidad.Value = 0;
                txtCantidad.Enabled = false;
                txtPrecio.Text = "0";
                txtImporte.Text = "0";
                articuloSi = false;
                if(txtCodigo.Text.Length > 0)
                {
                    int cod = Convert.ToInt32(txtCodigo.Text);
                    rw = dsDespachos.vProductos.FindByCodigo(cod);
                    if (rw != null)
                    {
                        txtDescripcion.Text = (string)rw[1];
                        txtPrecio.Text = ((int)rw[3]).ToString();
                        txtInventario.Text = ((int)rw[4]).ToString();
                        txtCantidad.Maximum = (int)rw[4];
                        articuloSi = true;
                        txtCantidad.Enabled = true;
                    }
                }
            
        }

        private void FDespachoVendedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDespachos.vProductos' Puede moverla o quitarla según sea necesario.
            this.vProductosTableAdapter.Fill(this.dsDespachos.vProductos);

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi & e.KeyCode == Keys.Enter)
            {
                txtCantidad.Focus();
            }
        }

        private bool comprobar()
        {
            int tt = Convert.ToInt32(txtCantidad.Value);          
            if (tt > txtCantidad.Maximum)
            {
                MessageBox.Show("Excede el numero de existencias");
                return false;
            }
            return true;
        }

        private void actualizar()
        {
            queries.actualizar_despacho(Despacho.Numero,
                Despacho.IdVendedor, Despacho.Observacion, Despacho.CantidadArticulos, Despacho.Total, Despacho.Fecha);
        }
        
        private void agregar()
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            var fila = dsDespachos.detalles_despacho.Rows.Find(codigo);
            if (fila != null)
            {
                fila["Cantidad"] = (int)fila["Cantidad"] + Convert.ToInt32(txtCantidad.Value);
                fila["Importe"] = (int)fila["Cantidad"] * (int)fila["Precio"];
             }
            else
            {
                var nueva = dsDespachos.detalles_despacho.Newdetalles_despachoRow();
                nueva.Despacho = Convert.ToInt32(Despacho.Numero);
                nueva._No_ = dsDespachos.detalles_despacho.Rows.Count + 1;
                nueva.Codigo = Convert.ToInt32(txtCodigo.Text);
                nueva.Cantidad = Convert.ToInt32(txtCantidad.Value);
                nueva.Importe = Convert.ToInt32(txtImporte.Text);
                nueva.Descripcion = txtDescripcion.Text;
                dsDespachos.detalles_despacho.Adddetalles_despachoRow(nueva);
            }
            dgvDetalles.Enabled = true;
            dsDespachos.vProductos.FindByCodigo(codigo).Existencias -= Convert.ToInt32(txtCantidad.Value);
            txtTotal.Text = calcularTotal().ToString();
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi && txtCantidad.Value > 0 && e.KeyCode == Keys.Enter)
            {
                if (comprobar())
                {
                    agregar();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvDetalles.Rows.Count > 0)
                {
                  if (Metodos.Confirmar())
                    {
                        int c = (int)dgvDetalles.SelectedCells[0].Value;
                        var f = dsDespachos.detalles_despacho.FindByCodigo(c);
                        dsDespachos.vProductos.FindByCodigo(c).Existencias += f.Cantidad;
                        dsDespachos.detalles_despacho.Removedetalles_despachoRow(f);
                        txtTotal.Text = calcularTotal().ToString();                        
                    }
                }
            }
        }

        private void txtCodigoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (vendedorSi & e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text.Length > 0)
            {
                int importe = Convert.ToInt32(txtPrecio.Text) * Convert.ToInt32(txtCantidad.Value);
                txtImporte.Text = importe.ToString();
            }
        }

        private void btnBuscarDevolucion_Click(object sender, EventArgs e)
        {
            using (FBuscarDespachos fBuscar = new FBuscarDespachos())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.seleccion;
                    txtNumero.Text = res.ToString();
                }
            }
        }

        private void btnBuscarVendedor_Click(object sender, EventArgs e)
        {
            using (FBuscarVendedor fBuscar = new FBuscarVendedor())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.Id;
                    txtCodigoVendedor.Text = res.ToString();
                    txtCantidad.Focus();
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar())
            {
                foreach (DataGridViewRow rw in dgvDetalles.Rows)
                {
                    int dt = (int)rw.Cells[0].Value;
                    int cp = (int)rw.Cells[1].Value;
                    int ct = (int)rw.Cells[3].Value;
                    queries.eliminarDetalleDespacho(Despacho.Numero, dt, cp, Despacho.IdVendedor, ct);
                }
                queries.elimnarDespacho(Despacho.Numero);
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                txtNumero.Clear();
                despejar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    queriesNuevo.cancelarDespacho(Despacho.Numero);
                    if (dgvDetalles.Rows.Count > 0)  dsDespachos.detalles_despacho.Rows.Clear();                
                    txtNumero.Clear();
                    Despacho.Numero = 0;                   
                    dtpFecha.Enabled = false;
                    txtTotal.Text = "0";
                    break;
                case Modo.Editar:
                    detalles_despachoTableAdapter.Fill(dsDespachos.detalles_despacho, Despacho.Numero);
                    btnEliminar.Enabled = true;
                    txtTotal.Text = calcularTotal().ToString();
                    break;
                case Modo.Ver:
                    break;
                default:
                    break;
            }
            modo = Modo.Ver;
            txtNumero.Enabled = true;
            btnBuscarDevolucion.Enabled = true;
            this.vProductosTableAdapter.Fill(this.dsDespachos.vProductos);
            txtCodigoVendedor.Clear();
            txtNombre.Clear();
            txtCodigo.Clear();
            txtCodigo.Enabled = false;
            txtCodigoVendedor.Enabled = false;
            btnBuscarProducto.Enabled = false;
            btnBuscarVendedor.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;

        }
    }
}
