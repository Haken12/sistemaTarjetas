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
    public partial class FRegistroArticulos : Form
    {
        public FRegistroArticulos()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtUnidad.Clear();
        }

        private void activar()
        {
            foreach (Control ctr in this.Controls.OfType<TextBox>())
            {
                if (ctr.Name != "txtCodigo")
                {
                    ctr.Enabled = ctr.Enabled ? false : true;
                }
            }
        }
     
        private bool verficar()
        {
            if (this.modo == Modo.Insertar)
            { //SI LA DESCRIPCION SE REPITE 
                int? res = querys.descripcion_articulo_coincide(txtDescripcion.Text);
                if (res > 0)
                {
                    if (MessageBox.Show("Existe ya un producto con esa descripcion, desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return false;
                    }
                }
            }                
            return true;
        }
        private void cargar()
        {
            txtDescripcion.Text = articulo.descripcion;
            txtCosto.Text = articulo.costo.ToString();
            txtPrecio.Text = articulo.precio.ToString();
            txtUnidad.Text = articulo.unidad;         
        }
        private void asignar()
        {
            articulo.descripcion = txtDescripcion.Text;
            articulo.costo = Convert.ToInt32(txtCodigo.Text);
            articulo.precio = Convert.ToInt32(txtPrecio.Text);
            articulo.unidad = (txtUnidad.Text);
        }
        private Modo modo;
        private Articulo articulo;
        private void FRegistroArticulos_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

            limpiar();
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            if (txtCodigo.Text.Length > 0)
            {
                articulo.codigo = Convert.ToInt32(txtCodigo.Text);
                if (querys.articulo_existe(articulo.codigo) > 0)
                {
                    querys.articulo_por_id(articulo.codigo, ref articulo.descripcion, ref articulo.costo, ref articulo.precio, ref articulo.unidad);
                    cargar();
                    btnModificar.Enabled = true;
                    btnNuevo.Enabled = false;
                }
                
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            txtCodigo.Clear();
            txtCosto.Enabled = false;
            limpiar();
            activar();            
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            this.modo = Modo.Insertar;
            txtDescripcion.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            activar();
            txtCodigo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            this.modo = Modo.Editar;
            txtDescripcion.Focus();
        }

        private void crear()
        {
            int? codigo = -1;
            querys.crear_articulo(ref codigo, articulo.descripcion, articulo.precio, articulo.costo, articulo.unidad);
            txtCodigo.Text = codigo.ToString();
        }

        private void actualizar()
        {
            querys.actualizar_articulo(articulo.codigo, articulo.descripcion, articulo.precio, articulo.costo, articulo.unidad);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verficar())
            {
                switch (this.modo)
                {
                    case Modo.Insertar:
                        asignar();
                        crear();
                        activar();
                       
                        break;
                    case Modo.Editar:
                        asignar();
                        actualizar();
                        activar();
                        break;
                    default:
                        break;
                }
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                btnBuscar.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FBuscarArticulo fBuscar = new FBuscarArticulo())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int codigo = fBuscar.articulo;
                    articulo.codigo = codigo;
                    txtCodigo.Text = codigo.ToString();
      
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void solorNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
