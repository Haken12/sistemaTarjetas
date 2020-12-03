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
    public partial class FDevolucionTarjetaB : Form
    {
        public FDevolucionTarjetaB()
        {
            InitializeComponent();
        }

        private bool venderSi;
        public int vendedor =0;
        public int venta = 0;
        public int tarjeta = 0;
        public string nombre = "";

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;
            if (Char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        public string NombreV;
        public string NombreT;
        public int Vendedor =0;
        public int Tarjeta =0;
        public int Venta = 0;
        public int Max;
        public int detalle = 0;
        private void FDevolucionTarjetaB_Load(object sender, EventArgs e)
        {
            txtTarjeta.Text = tarjeta.ToString();
            txtVendedor.Text = Vendedor.ToString();
            txtNombreT.Text = NombreT;
            txtNombreV.Text = NombreV;
            txtVenta.Text = Venta.ToString();
            datosVentaTableAdapter.Llenar(dsDevoluciones.datosVenta, Venta, Tarjeta);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FArticulosVentaT fArticulos = new FArticulosVentaT())
            {
                if (fArticulos.ShowDialog() == DialogResult.OK)
                {
                    int art = fArticulos.articulo;
                    txtArticulo.Text = art.ToString();
                    txtCantidad.Focus();
                }
            }
        }

        private void txtArticulo_TextChanged(object sender, EventArgs e)
        {
            venderSi = false;
            txtNombreA.Clear();
            txtActual.Text = "0";
            txtPrecio.Text = "0";
            Max = 0;
            txtCantidad.Text = "0";
            if(txtArticulo.TextLength != 0)
            {
                int a = Convert.ToInt32(txtArticulo.Text);
                var row = dsDevoluciones.datosVenta.FindByProducto(a);
                txtActual.Text = row.Cantidad.ToString();
                Max = row.Cantidad;
                txtNombreA.Text = row.Descripcion;
                txtPrecio.Text = row.Precio.ToString();
                detalle = row.Numero;
           
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length > 0)
            {
                int c = Convert.ToInt32(txtCantidad.Text);
                if (c > Max)
                {
                    txtCantidad.Text = Max.ToString();
                }
                if (c!=0) venderSi = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (venderSi) 
            {
                
            }
        }
    }
}
