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
    public partial class FNuevaVenta : Form
    {
        public FNuevaVenta()
        {
            InitializeComponent();
        }
        public int valTarjeta = 0;
        public int totalImporte = 0;
        public int idVendedor = 0;
        public int? numVenta = 0;
        private int existencias = 0;
        public DateTime fecha;
        private int? numeroVenta;
        public int codTarjeta = 0;

        private void FNuevaVenta_Load(object sender, EventArgs e)
        {
            v_inventario_vendedorTableAdapter.Fill(dsSistemaTarjetas.v_inventario_vendedor, idVendedor);
            lblVendedor.Text = idVendedor.ToString();
            lblValorT.Text = valTarjeta.ToString();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtImporte.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            existencias = 0;
            if (txtCodigo.TextLength > 0) 
            {
                int codigoA = Convert.ToInt32(txtCodigo.Text);
                DataRow fila = dsSistemaTarjetas.v_inventario_vendedor.NewRow();
                fila = dsSistemaTarjetas.v_inventario_vendedor.FindByCodigo(codigoA);

                if (fila != null) 
                {
                    txtDescripcion.Text = fila[1].ToString();
                    txtPrecio.Text = fila[2].ToString();
                    existencias = (int)fila[3];
                    txtPrecio.Enabled = true;
                    txtCantidad.Enabled = true;
                }
            }
        }

        private void agregar() 
        {
            int extT = 0;
            foreach (DataRow dr in dsSistemaTarjetas.venta.Rows)
            {
                if ((int)dr[0] == Convert.ToInt32(txtCodigo.Text))
                {
                    extT += (int)dr[3];
                }
            }
            extT += Convert.ToInt32(txtCantidad.Text);
            MessageBox.Show(existencias.ToString() + " " + extT.ToString());
            if (extT > existencias) 
            {
                MessageBox.Show("Excede el numero de existencias", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRow fila = dsSistemaTarjetas.venta.NewRow();
            fila[0] = Convert.ToInt32(txtCodigo.Text);
            fila[1] = txtDescripcion.Text;
            fila[2] = Convert.ToInt32(txtPrecio.Text);
            fila[3] = Convert.ToInt32(txtCantidad.Text);
            fila[4] = Convert.ToInt32(txtImporte.Text);
            dsSistemaTarjetas.venta.Rows.Add(fila);
            totalImporte = 0;
            foreach (DataRow rw in dsSistemaTarjetas.venta.Rows)
            {
                totalImporte += (int)rw[4];
            }
            txtTotal.Text = totalImporte.ToString();
            int valTarjeta = Convert.ToInt32(lblValorT.Text);
            txtDiferencia.Text = (valTarjeta - totalImporte).ToString();
            if (!btnAceptar.Enabled) 
            {
                btnAceptar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            txtCodigo.Focus();
           
        }
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPrecio.Text !="" & txtCantidad.Text !="") agregar();

            }
                
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio.Text != "" & txtCantidad.Text != "") 
            {
                int precio = Convert.ToInt32(txtPrecio.Text);
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                txtImporte.Text = (precio * cantidad).ToString();
            }
        }

        private void guardar() 
        {
            querys.nueva_venta_tarjeta(codTarjeta, fecha, totalImporte, 0, ref numeroVenta);
            int c = 0;
            foreach (DataRow fila in dsSistemaTarjetas.venta.Rows)
            {
                int codigo = (int)fila[0];
                int precio = (int)fila[2];
                int cantidad = (int)fila[3];
                int importe = (int)fila[4];
                querys.nuevo_detalle_venta_tarjeta(numeroVenta, codTarjeta, codigo, precio, cantidad, importe);
                c++;
                
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FSeleccionarArticulo fSeleccionar = new FSeleccionarArticulo())
            {
                fSeleccionar.vendedor = idVendedor;
                if (fSeleccionar.ShowDialog() == DialogResult.OK)
                {
                    int articulo = fSeleccionar.articulo;
                    txtCodigo.Text = articulo.ToString();
                }
            }
        }
    }
}
