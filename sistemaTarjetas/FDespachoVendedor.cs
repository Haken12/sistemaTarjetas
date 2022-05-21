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
        
        private  class Despacho
        {
            public  int? Numero = -1;
            public  int? IdVendedor =-1;
            public  string Nombre = "";
            public  DateTime? Fecha = DateTime.Today;
            public  int? Total = 0;
            public  int? CantidadArticulos = 0;
            public  string Observacion;
            public  BindingList<DetalleMovimiento> Detalles = new BindingList<DetalleMovimiento>();
        }

        public class DetalleMovimiento
        {
            public int? Numero { get; set; } = 0;
            public string Producto { get; set; } = "";
            public int Valor { get; set;} = 0;
            public int Cantidad { get; set; } = 0;
            public int Importe { get; set; } = 0;

        }

        private bool vendedorExiste(int id)
        {
            var a = dsDespachos1.vendedoresNombre.Rows.Find(id);
            if (a != null) return true;
            else return false;

        }
        private Modo modo = Modo.Ver;
        private bool vendedorSi = false;
        private bool contenidoSi = false;
        private Despacho despacho = new Despacho();
        private bool articuloSi = false;
        
        public FDespachoVendedor()
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
            txtCodigoVendedor.Text = despacho.IdVendedor.ToString();
            txtNombre.Text = despacho.Nombre;
            txtTotal.Text = despacho.Total.ToString();
            dtpFecha.Value = despacho.Fecha.Value;
            
        }

        public void asignar()
        {
            despacho.IdVendedor = Convert.ToInt32(txtCodigoVendedor.Text);
            despacho.Nombre = txtNombre.Text;
            despacho.Fecha = dtpFecha.Value;
            despacho.Total = Convert.ToInt32(txtTotal.Text);
            despacho.CantidadArticulos = dgvDetalles.Rows.Count;
        }

        public bool existe()
        {

            return true;
        }

        public void conseguir()
        {
          
        }

        private void despejar()
        {
            txtNumero.Clear();
            txtCodigoVendedor.Clear();
            txtCodigo.Clear();
            if (dgvDetalles.Rows.Count > 0) dgvDetalles.Rows.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            modo = Modo.Insertar;
            contenidoSi = false;
            btnBuscarVendedor.Enabled = true;
            btnBuscarDevolucion.Enabled = false;
            btnSalir.Enabled = false;
            txtCodigoVendedor.Enabled = true;
            txtCodigoVendedor.Focus();
            
        }

        private void soloNumeros(object sender , KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
        private void crear()
        {
           
        }
        private bool verificar()
        {
            if (modo == Modo.Insertar & !vendedorSi)
            {
                MessageBox.Show("Elija un vendedor");
                return false;
            }
            return true;
        }
        private void guardar()
        {
            switch (modo)
            {
                case Modo.Insertar:
                    if (!contenidoSi)
                    { MessageBox.Show("No hay registros que guardar");
                        break;
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
        private void txtCodigoVendedor_TextChanged(object sender, EventArgs e)
        {
            
            if(txtCodigoVendedor.Text.Length > 0)
            {
                int codigo = Convert.ToInt32(txtCodigoVendedor.Text);
                if (vendedorExiste(codigo))
                {
                    string x = "";
                    txtNombre.Text = dsDespachos1.vendedoresNombre.FindByid_vendedor(codigo)[1].ToString();
                    btnBuscarProducto.Enabled = true;
                    btnGuardar.Enabled = true;
                    txtCodigo.Enabled = true;
                    
                    txtPrecio.Enabled = true;
                    vendedorSi = true;
                    dgvDetalles.Enabled = true;
                    
                }
                else { 
                    txtNombre.Clear(); 
                    vendedorSi=false;
                    btnGuardar.Enabled =false;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          
        }

        private bool articuloExiste(int codigo)
        {
            
            return false;
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCodigo.Text))
            {
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCantidad.Value = 0;
                txtImporte.Clear();
                articuloSi = false;
                txtPrecio.Enabled = false;
                txtCantidad.Enabled = false;
                return;
            }
              
            int codigo = Convert.ToInt32(txtCodigo.Text);
            var a = dsDespachos1.vProductos.FindByCodigo(codigo);
            if (a != null)
            {
                txtPrecio.Enabled=true;
                txtCantidad.Enabled = true;
                articuloSi = true;
                txtDescripcion.Text = a.Descripcion;
                txtPrecio.Text = a.Precio.ToString();
            }
            else
            {
                txtDescripcion.Clear();
                txtPrecio.Clear();
                txtCantidad.Value = 0;
                txtImporte.Clear();
                articuloSi=false;
                txtPrecio.Enabled = false;
                txtCantidad.Enabled = false;
            }
           
            
        }

        private void FDespachoVendedor_Load(object sender, EventArgs e)
        {
            vendedoresNombreTableAdapter1.Fill(dsDespachos1.vendedoresNombre);
            vProductosTableAdapter1.Fill(dsDespachos1.vProductos);
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi & e.KeyCode == Keys.Enter)
            {
                txtPrecio.Focus();
            }
        }

        private bool comprobar()
        {
            return true;
        }

        private void actualizar()
        {
          
        }
        
        private void agregar()
        {

            //dsDespachos.DespachosRow nuevo = (dsDespachos.DespachosRow)dsDespachos1.Despachos.Rows.Find(txtCodigo.Text.ToInt());
            dsDespachos.DespachosRow nuevo = dsDespachos1.Despachos.FindByCodigo(txtCodigo.Text.ToInt());
            if (nuevo != null)
            {
                nuevo.Cantidad =+Convert.ToInt32(txtCantidad.Value);
                
            }
            else { 
            nuevo = dsDespachos1.Despachos.NewDespachosRow();
            nuevo.Codigo = txtCodigo.Text.ToInt();
            nuevo.Descripcion = txtDescripcion.Text;
            nuevo.Precio = txtPrecio.Text.ToInt();
            nuevo.Cantidad = Convert.ToInt32(txtCantidad.Value);
            nuevo.Importe = txtImporte.Text.ToInt();
            despacho.Total = +nuevo.Importe;
            dsDespachos1.Despachos.AddDespachosRow(nuevo);
            }
        }
        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (articuloSi & txtCantidad.Value > 0 & e.KeyCode == Keys.Enter)
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
          
        }

        private void txtCodigoVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (vendedorSi && e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            int precio = txtPrecio.Text.ToInt();
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            txtImporte.Text = (precio * cantidad).ToString();
        }

        private void btnBuscarDevolucion_Click(object sender, EventArgs e)
        {
            using (FBuscarDespachos fBuscar = new FBuscarDespachos())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int res = fBuscar.seleccion;
                   
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
                   
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar())
            {
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                   
                    break;
                case Modo.Editar:
                    break;
                case Modo.Ver:
                    break;
                default:
                    break;
            }
            modo = Modo.Ver;
           

        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)txtCantidad.Focus();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            int precio = txtPrecio.Text.ToInt();
            int cantidad = Convert.ToInt32(txtCantidad.Value);
            txtImporte.Text = (precio * cantidad).ToString();
        }
    }
}
