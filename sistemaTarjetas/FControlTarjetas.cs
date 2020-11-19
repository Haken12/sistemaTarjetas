using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using regrexTest;

namespace sistemaTarjetas
{
    public partial class FControlTarjetas : Form
    {
        public FControlTarjetas()
        {
            InitializeComponent();
        }

        Modo modo = Modo.Ver;
        Tarjeta tarjeta;

        private void iniciar() {
            txtCodigo.Focus();
            this.v_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_vendedor);
            cbxFormaPago.SelectedIndex = 0;
            if (cbxVendedor.Items.Count != 0)
            {
                cbxVendedor.SelectedIndex = 0;

            }
            txtCodigo.Focus();
            this.v_zonaTableAdapter.Fill(this.dsSistemaTarjetas.v_zona);
            
            
        }

        private void activar()
        {
            txtNombre.Enabled = true;
            txtCedula.Enabled = true;
            txtReferencia.Enabled = true;
            txtTelefono.Enabled = true;
            dtpFecha.Enabled = true;
            cbxFormaPago.Enabled = true;
            cbxVendedor.Enabled = true;
            cbxZona.Enabled = true;
        }

        private void desactivar() 
        {
            txtNombre.Enabled = false;
            txtCedula.Enabled = false;
            txtReferencia.Enabled = false;
            txtTelefono.Enabled = false;
            dtpFecha.Enabled = false;
            cbxFormaPago.Enabled = false;
            cbxVendedor.Enabled = false;
            cbxZona.Enabled = false;
        }

        private void mToggle() 
        {
            foreach  (Control ctr in groupBox1.Controls)
            {
                if (ctr.Name != "txtCodigo" & !(ctr is Button) & !(ctr is Label)) 
                {
                    ctr.Enabled = ctr.Enabled ? false : true;
                }
            }
        }
        private void opToggle() 
        {
            txtValor.Enabled = txtValor.Enabled ? false : true;
            cbxTipo.Enabled = cbxTipo.Enabled ? false : true;
            dtpFecha.Enabled = dtpFecha.Enabled ? false : true;
            btnAsentar.Enabled = btnAsentar.Enabled ? false : true;
        }
        private void despejar() 
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtReferencia.Clear();
            txtTelefono.Clear();
            dtpFecha.Value = DateTime.Today;     
        }

        private void FControlTarjetas_Load(object sender, EventArgs e)
        {
            iniciar();
        }

        private void entrar(object sender, EventArgs e) 
        {
            ((Control)sender).BackColor = Color.LightBlue;
        }

        private void salir(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private bool verificar() 
        {
            if (!regrexTest.Comprobar.esCedula(txtCedula.Text)) return false;
            return true;
        }

        private void crear() {
            int? codigo = -1;
            querys.crear_tarjeta(
                txtNombre.Text,
                txtReferencia.Text,
                txtCedula.Text,
                txtTelefono.Text,
                dtpFecha.Value,
                (int)cbxVendedor.SelectedValue,
                (int)cbxZona.SelectedValue,
                cbxFormaPago.Text,ref codigo);
            txtCodigo.Text = codigo.ToString();
        }

        private void actualizar() {

            querys.actualizar_tarjeta(
                Convert.ToInt32(txtCodigo.Text),
                txtNombre.Text,
                txtReferencia.Text,
                txtCedula.Text,
                txtTelefono.Text,
                dtpFecha.Value,
                (int)cbxVendedor.SelectedValue,
                (int)cbxZona.SelectedValue,
                cbxFormaPago.Text,
                Convert.ToInt32(txtDebito.Text),
                Convert.ToInt32(txtCredito.Text),
                Convert.ToInt32(txtBalance.Text));
        }

        //Asentar
        private void venta() 
        {
            FNuevaVenta fNuevaVenta = new FNuevaVenta();
            fNuevaVenta.codTarjeta = Convert.ToInt32(txtCodigo.Text);
            fNuevaVenta.idVendedor = (int)cbxVendedor.SelectedValue;
            fNuevaVenta.fecha = dtpFecha.Value;
            fNuevaVenta.valTarjeta = Convert.ToInt32(txtValor.Text);
            if (fNuevaVenta.ShowDialog() == DialogResult.OK)
            { 
                v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, Convert.ToInt32(txtCodigo.Text));
                calcularBalance();
                txtValor.Clear();
                txtValor.Focus();
            }

        }

        private void cobro() {
            int balance = Convert.ToInt32(txtBalance.Text);
            int monto = Convert.ToInt32(txtValor.Text);
            if (monto <= balance) 
            {
                querys.nuevo_cobro_tarjeta(Convert.ToInt32(txtCodigo.Text), dtpFecha.Value, monto, 0);
                v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, Convert.ToInt32(txtCodigo.Text));
                calcularBalance();
                txtValor.Clear();
                
                txtCodigo.Focus();
                txtCodigo.SelectAll();
                

            }
            else
            {
                MessageBox.Show("Valor excede la deuda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void descuento() {
            int balance = Convert.ToInt32(txtBalance.Text);
            int monto = Convert.ToInt32(txtValor.Text);
            if (monto <= balance)
            {
                querys.nuevo_descuento_tarjeta(Convert.ToInt32(txtCodigo.Text), dtpFecha.Value, monto, 0);
                v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, Convert.ToInt32(txtCodigo.Text));
                calcularBalance();
                txtValor.Clear();
                txtValor.Focus();

            }
            else
            {
                MessageBox.Show("Valor excede la deuda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void devolucion() 
        {
            if (dgvDetalles.SelectedCells[2].Value.ToString() != "Venta")
            {
                MessageBox.Show("Debe seleccionar una venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                FDevolucionTarjeta fDevolucion = new FDevolucionTarjeta();
                fDevolucion.numeroVenta = (int)dgvDetalles.SelectedCells[0].Value;                
                fDevolucion.fecha = dtpFecha.Value;
                fDevolucion.valorMaximo = Convert.ToInt32(txtBalance.Text);
                fDevolucion.numeroTarjeta = Convert.ToInt32(txtCodigo.Text);
                
                if (fDevolucion.ShowDialog() == DialogResult.OK) v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, Convert.ToInt32(txtCodigo.Text));
                calcularBalance();
                txtValor.Clear();
                txtValor.Focus();

            }
        }



        //
        private void asentar()
        {
            if (txtValor.Text != "")
            {
                switch (cbxTipo.SelectedIndex)
                {
                    case 0:
                        venta();
                        break;
                    case 1:
                        cobro();
                        break;
                    case 2:
                        descuento();
                        break;
                    case 3:
                        devolucion();
                        break;

                }
            }
        }

        private void calcularBalance()
        {
            int creditos = 0;
            int debitos = 0;
            int balance = 0;
            foreach (DataRow row in dsSistemaTarjetas.v_detalles_tarjeta)
            {
                creditos += (int)row[4];
                debitos += (int)row[3];
                balance = creditos - debitos;
                txtCredito.Text = creditos.ToString();
                txtDebito.Text = debitos.ToString();
                txtBalance.Text = balance.ToString();
            }
        }
        private void btnNueva_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Enabled) mToggle();
            despejar();
            txtCodigo.Enabled = false;
            btnBuscar.Enabled = false;
            btnNueva.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            // foreach (Control ctr in pnlOp.Controls) ctr.Enabled = false;
            if (txtValor.Enabled) opToggle();
            this.modo = Modo.Insertar;
            dsSistemaTarjetas.v_detalles_tarjeta.Clear();
            txtNombre.Focus();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificar()) 
            {
                switch (this.modo) 
                {
                    case Modo.Insertar:
                        crear();
                        txtNombre.Enabled = false;
                        txtReferencia.Enabled = false;
                        txtCodigo.Enabled = true;
                        txtTelefono.Enabled = false;
                        cbxVendedor.Enabled = false;
                        cbxZona.Enabled = false;
                        cbxFormaPago.Enabled = false;
                        dtpFecha.Enabled = false;
                        
                        txtValor.Enabled = true;
                        btnAsentar.Enabled = true;
                        cbxTipo.Focus();
                        break;

                    case Modo.Editar:
                        actualizar();
                        mToggle();
                        opToggle();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnNueva.Enabled = true;

                        txtCodigo.Enabled = true;
                        btnBuscar.Enabled = true;
                        break;
                }
                    
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtReferencia.Clear();
            txtTelefono.Clear();
            dsSistemaTarjetas.v_detalles_tarjeta.Rows.Clear();
            if (txtValor.Enabled) opToggle();
            
            if (txtCodigo.Text.Length > 0 /*& querys.tarjeta_existe(Convert.ToInt32(txtCodigo.Text)) != 0*/) 
            {
                int? c = querys.tarjeta_existe(Convert.ToInt32(txtCodigo.Text));
                querys.unica_tarjeta(Convert.ToInt32(txtCodigo.Text),
                    ref tarjeta.nombre,
                    ref tarjeta.referencia,
                    ref tarjeta.cedula,
                    ref tarjeta.telefono,
                    ref tarjeta.fehcaCreacion,
                    ref tarjeta.idVendedor,
                    ref tarjeta.idZona,
                    ref tarjeta.tipoPago);
                if (c != 0) 
                {
                    txtNombre.Text = tarjeta.nombre;
                    txtReferencia.Text = tarjeta.referencia;
                    txtTelefono.Text = tarjeta.telefono;
                    txtCedula.Text = tarjeta.cedula;
                    dtpFecha.Value = tarjeta.fehcaCreacion.Value;
                    cbxVendedor.SelectedValue = tarjeta.idVendedor;
                    cbxZona.SelectedValue = tarjeta.idZona;
                    btnModificar.Enabled = true;
                    if (!txtValor.Enabled) opToggle();
                    cbxTipo.SelectedIndex = 0;
                    
                    v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, Convert.ToInt32(txtCodigo.Text));
                    txtCredito.Text = "0";
                    txtDebito.Text = "0";
                    txtBalance.Text = "0";
                    if (dgvDetalles.Rows.Count > 0) 
                    {
                        calcularBalance();
                    }
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.modo = Modo.Editar;
            txtCodigo.Enabled = false;
            btnBuscar.Enabled = false;
            btnNueva.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            mToggle();
            opToggle();
        }

        private void cbxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVendedor.SelectedIndex != -1) 
            {
                bsZonas.Filter = "id_vendedor =" + cbxVendedor.SelectedValue;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (this.modo)
            {
                case Modo.Insertar:
                    despejar();
                    txtCodigo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnNueva.Enabled = true;
                    mToggle();

                    txtCodigo.Focus();
                    break;
                case Modo.Editar:
                    txtNombre.Text = tarjeta.nombre;
                    txtReferencia.Text = tarjeta.referencia;
                    txtTelefono.Text = tarjeta.telefono;
                    txtCedula.Text = tarjeta.cedula;
                    dtpFecha.Value = tarjeta.fehcaCreacion.Value;
                    cbxVendedor.SelectedValue = tarjeta.idVendedor;
                    cbxZona.SelectedValue = tarjeta.idZona;
                    txtCodigo.Enabled = true;
                    btnBuscar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnNueva.Enabled = true;
                    txtCodigo.Focus();
                    break;
            }
        }

        private void btnAsentar_Click(object sender, EventArgs e)
        {
            asentar();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) asentar();
        }

        private void dgvDetalles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvDetalles.SelectedRows.Count > 0)
                {
                    if (Metodos.Confirmar())
                    {
                        int codigo = Convert.ToInt32(txtCodigo.Text);
                        int numero = (int)dgvDetalles.SelectedCells[0].Value;
                        switch ((string)dgvDetalles.SelectedCells[2].Value)
                        {                            
                            case "Venta":
                                querys.eliminar_venta_tarjeta(codigo,numero);                                
                                break;
                            case "Cobro":
                                querys.eliminar_cobro(codigo, numero);
                                break;
                            case "Devolucion":
                                querys.eliminar_devolucion_tarjeta(codigo, numero);
                                break;
                            case "Descuento":
                                querys.eliminar_descuento(codigo, numero);
                                break;
                            default:
                                break;
                        }
                        v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta,codigo);
                        calcularBalance();

                    }
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter &(txtNombre.Text != ""))
            {
                txtValor.Focus();
            }
        }

        private void cbxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Metodos.Confirmar())
            {
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
