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
    public partial class FProducto : Form
    {

        public Modo modo;
        public Producto producto;
        public FProducto()
        {
            InitializeComponent();
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            if (this.modo == Modo.Editar)
            {
                queriesTableAdapter1.unico_producto(
                    producto.codigo,
                    ref producto.descripcion, 
                    ref producto.costo,
                    ref producto.precio,
                    ref producto.existencias
                    );
                txtDescripcion.Text = producto.descripcion;
                mtxtCosto.Text = producto.costo.ToString();
                mtxtPrecio.Text = producto.precio.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crear() 
        {
            queriesTableAdapter1.crear_producto(
                txtDescripcion.Text, 
                Convert.ToDecimal(mtxtCosto.Text), 
                Convert.ToDecimal(mtxtPrecio.Text),
                0);
        }

        private void actualizar() 
        {
            queriesTableAdapter1.actualizar_producto(
                producto.codigo,
                txtDescripcion.Text,
                Convert.ToDecimal(mtxtCosto.Text),
                Convert.ToDecimal(mtxtPrecio.Text)
                );
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    crear();
                    break;
                case Modo.Editar:
                    actualizar();
                    break;
                default:
                    break;
            }
        }
    }
}
