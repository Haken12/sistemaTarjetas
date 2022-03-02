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
    public partial class FGastosB : Form
    {
        Modo modo = Modo.Ver;
        private bool gastoSi = false;
        private bool vendedorSi = false;
        public FGastosB()
        {
            InitializeComponent();
        }

        private void despejar()
        {
            txtVendedor.Clear();
            
            txtDescripcion.Clear();
            txtValor.Text = "0";
            txtTotal.Text = "0";
            if (dsSistemaTarjetas.verDetallesGasto.Rows.Count > 0) dsSistemaTarjetas.verDetallesGasto.Rows.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Insertar;
            despejar();
            txtNumero.Enabled = false;
            btnBuscar.Enabled = false;
            txtVendedor.Enabled = true;
            btnBuscarVendedor.Enabled = true;
            dtpFecha.Enabled = true;
            cbxTipo.Enabled = true;
            txtValor.Enabled = true;
            txtDescripcion.Enabled = true;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;            
            btnCancelar.Enabled = true;
            int? n = 0;
            queriesNuevo.iniciarGasto(dtpFecha.Value, ref n);
            txtNumero.Text = n.ToString();
            dgvDetalles.Enabled = true;
            txtVendedor.Focus();
        }

        private void txtVendedor_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            vendedorSi = false;
            if (txtVendedor.Text.Length > 0)
            {
                int id = Convert.ToInt32(txtVendedor.Text);
                int? c = querys.vendedor_existe(id);
                if (c != 0)
                {
                    txtNombre.Text = (string)querys.nombreVendedor(id);
                    vendedorSi = true;                   
                }
            }
        }

        private void crear()
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            int vendedor = Convert.ToInt32(txtVendedor.Text);
            int total = Convert.ToInt32(txtTotal.Text);
            queriesNuevo.actualizarGasto(numero, vendedor, dtpFecha.Value, total);
        }
        private bool verificar()
        {
            if (txtVendedor.Text.Length == 0)
            {
                MessageBox.Show("Debe elegir un vendedor");
                txtVendedor.Focus();
                return false;
            }
            if (dgvDetalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe haber por lo menos un gasto");
                cbxTipo.Focus();
                return false;
            }
            return true;
        }
        private void guardar()
        {
            if (verificar())
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                crear();
                foreach (DataRow fila in dsSistemaTarjetas.verDetallesGasto)
                {
                    int detalle = (int)fila["No."];
                    queriesNuevo.eliminarDetalleGasto(numero, detalle);
                }
                foreach (DataRow fila in dsSistemaTarjetas.verDetallesGastoE)
                {
                    int detalle = (int)fila["No."];
                    queriesNuevo.eliminarDetalleGasto(numero, detalle);
                }
                foreach (DataRow fila in dsSistemaTarjetas.verDetallesGasto)
                {
                    int detalle = dsSistemaTarjetas.verDetallesGasto.Rows.IndexOf(fila);
                    queriesNuevo.nuevoDetalleGasto(numero, detalle, (string)fila["Tipo"], (string) fila["Descripcion"],(int) fila["Valor"]);
                    if (dsSistemaTarjetas.verDetallesGastoE.Rows.Count > 0) dsSistemaTarjetas.verDetallesGastoE.Rows.Clear();
                }
                switch (modo)
                {
                    case Modo.Insertar:
                        despejar();                                               
                        break;
                    case Modo.Editar:
                       
                        break;
                    case Modo.Ver:
                        break;
                    default:
                        break;
                }
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnModificar.Enabled = true;
                cbxTipo.Enabled = false;
                cbxTipo.SelectedIndex = 0;
                txtDescripcion.Enabled = false;
                txtValor.Enabled = false;
                dtpFecha.Enabled = false;
                txtNumero.Enabled = true;
                btnBuscar.Enabled = true;
                txtVendedor.Enabled = false;
                btnBuscarVendedor.Enabled = false;
                modo = Modo.Ver;
                txtNumero.Focus();

            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxTipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                txtValor.Focus();
                txtValor.SelectAll();
            } 
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                DataRow nuevo = dsSistemaTarjetas.verDetallesGasto.NewverDetallesGastoRow();
                int numero = dsSistemaTarjetas.verDetallesGasto.Rows.Count + 1;
                string tipo = cbxTipo.Text;               
                string descripcion = txtDescripcion.Text;
                int valor = Convert.ToInt32(txtValor.Text);
                nuevo["No."] = numero;
                nuevo["Tipo"] = tipo;
                nuevo["Descripcion"] = descripcion;
                nuevo["Valor"] = valor;
                dsSistemaTarjetas.verDetallesGasto.Rows.Add(nuevo);
                txtTotal.Text = calcularBalance().ToString();
                txtDescripcion.Clear();
                txtValor.Text = "0";
                cbxTipo.Focus();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void cbxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedIndex != -1)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Ver)
            {
                txtVendedor.Clear();
                txtNombre.Clear();
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;
                gastoSi = false;
                txtTotal.Text = "0";
                if (dgvDetalles.Rows.Count > 0)
                {
                    dsSistemaTarjetas.verDetallesGasto.Clear();
                }
                txtDescripcion.Clear();
                txtValor.Clear();
                dgvDetalles.Enabled = false;
                if (txtNumero.Text.Length > 0)
                {
                    int num = Convert.ToInt32(txtNumero.Text);
                    if (querys.gastoExiste(num) != 0)
                    {
                        gastoSi = true;
                        int? id = 0;
                        string nombre = "";
                        DateTime? fecha = DateTime.Now;
                        int? total = 0;
                        querys.datosGasto(num, ref id, ref nombre, ref fecha, ref total);
                        txtVendedor.Text = id.ToString();
                        verDetallesGastoTableAdapter.Fill(dsSistemaTarjetas.verDetallesGasto, Convert.ToInt32(txtNumero.Text));
                        txtTotal.Text = calcularBalance().ToString();

                        dtpFecha.Value = fecha.Value;
                        btnModificar.Enabled = true;


                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Enabled = true;
            cbxTipo.Enabled = true;
            btnModificar.Enabled = false;
            txtValor.Enabled = true;
            cbxTipo.SelectedIndex = 0;
            
            modo = Modo.Editar;
            txtNumero.Enabled = false;
            btnBuscar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            dgvDetalles.Enabled = true;
            cbxTipo.Focus();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private int calcularBalance()
        {
            int total = 0;
            foreach (DataGridViewRow fila in dgvDetalles.Rows)
            {
                total += (int)fila.Cells[3].Value;
            }
            return total;
        }
        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvDetalles.Rows.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (Metodos.Confirmar())
                    {
                        int numero = (int) dgvDetalles.SelectedCells[0].Value;
                        DataRow row = dsSistemaTarjetas.verDetallesGasto.Rows.Find(numero);
                        dsSistemaTarjetas.verDetallesGastoE.ImportRow(row);
                        
                        dsSistemaTarjetas.verDetallesGasto.Rows.Remove(row);
                        txtTotal.Text = calcularBalance().ToString();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    despejar();
                    dgvDetalles.Enabled = false;
                    queriesNuevo.cancelarGasto(Convert.ToInt32(txtNumero.Text));
                    txtNumero.Text = "";                    
                    break;
                case Modo.Editar:                   
                    btnModificar.Enabled = true;
                    verDetallesGastoTableAdapter.Fill(dsSistemaTarjetas.verDetallesGasto, Convert.ToInt32(txtNumero.Text));

                    break;
                case Modo.Ver:
                    break;
                default:
                    break;
            }
            if (dsSistemaTarjetas.verDetallesGastoE.Rows.Count > 0) dsSistemaTarjetas.verDetallesGastoE.Rows.Clear();
            cbxTipo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtValor.Enabled = false;
            txtNumero.Enabled = true;
            btnBuscar.Enabled = true;
            txtVendedor.Enabled = false;
            btnBuscarVendedor.Enabled = false;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            dtpFecha.Enabled = false;
            modo = Modo.Ver;
            txtNumero.Focus();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FBuscarGasto fBuscar = new FBuscarGasto())
            {
               if (  fBuscar.ShowDialog() == DialogResult.OK)
                {
                    int m = fBuscar.seleccion;
                    txtNumero.Text = m.ToString();
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
                    txtVendedor.Text = res.ToString();
                }
            }
        }

        private void txtVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & txtNombre.TextLength != 0)
            {
                cbxTipo.Focus();
            }
        }

        private void cbxTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
