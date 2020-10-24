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
    public partial class FControlTarjetas : Form
    {
        public FControlTarjetas()
        {
            InitializeComponent();
        }

        Modo modo;
        Tarjeta tarjeta;

        private void iniciar() {
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
            foreach (Control ctr in pnlOp.Controls) 
            {
                ctr.Enabled = ctr.Enabled ? false : true;            
            }
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
            ((Control)sender).BackColor = Color.Yellow;
        }

        private void salir(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private bool verificar() 
        {
            return true;
        }

        private void crear() {
            querys.crear_tarjeta(
                txtNombre.Text,
                txtReferencia.Text,
                txtCedula.Text,
                txtTelefono.Text,
                dtpFecha.Value,
                (int)cbxVendedor.SelectedValue,
                (int)cbxZona.SelectedValue,
                cbxFormaPago.Text);
        }

        private void actualizar() {

            querys.actualizar_tarjeta(
                Convert.ToInt32(txtCredito.Text),
                txtNombre.Text,
                txtReferencia.Text,
                txtCredito.Text,
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
            }

        }

        private void cobro() {
            int balance = Convert.ToInt32(txtBalance.Text);
            int monto = Convert.ToInt32(txtValor.Text);
            if (monto <= balance) 
            {
                querys.nuevo_cobro_tarjeta(tarjeta.codigo, dtpFecha.Value, monto, 0);
                v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, tarjeta.codigo);
                calcularBalance();
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
                querys.nuevo_descuento_tarjeta(tarjeta.codigo, dtpFecha.Value, monto, 0);
                v_detalles_tarjetaTableAdapter.Fill(dsSistemaTarjetas.v_detalles_tarjeta, tarjeta.codigo);
                calcularBalance();
            }
            else
            {
                MessageBox.Show("Valor excede la deuda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void devolucion() { }



        //
        private void asentar()
        {
            switch (cbxTipo.SelectedIndex)
            {
                case 0:
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
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            // foreach (Control ctr in pnlOp.Controls) ctr.Enabled = false;
            if (txtValor.Enabled) opToggle();
            this.modo = Modo.Insertar;
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
                        despejar();
                        txtNombre.Focus();

                        break;

                    case Modo.Editar:
                        actualizar();
                        mToggle();
                        opToggle();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
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
                querys.unica_tarjeta(Convert.ToInt32(txtCodigo.Text),
                    ref tarjeta.nombre,
                    ref tarjeta.referencia,
                    ref tarjeta.cedula,
                    ref tarjeta.telefono,
                    ref tarjeta.fehcaCreacion,
                    ref tarjeta.idVendedor,
                    ref tarjeta.idZona,
                    ref tarjeta.tipoPago);
                if (tarjeta.nombre != null) 
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
                    tarjeta.nombre = null;
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
                    txtCodigo.Focus();
                    break;
            }
        }

        private void btnAsentar_Click(object sender, EventArgs e)
        {
            asentar();
        }
    }
}
