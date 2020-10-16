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
    public partial class FRegVendedores : Form
    {
       

        public FRegVendedores()
        {
            InitializeComponent();
        }

        Modo modo;
        Vendedor vendedor;

        private bool verificar() 
        {
            if (txtNombre.Text.Length == 0) return false;
            if (txtComision.Text.Length == 0) return false;
            if (txtDireccion.Text.Length == 0) return false;
            if (txtTelefono.Text.Length == 0) return false;
            if (txtCelular.Text.Length == 0) return false;
            if (txtDeduccion.Text.Length == 0) return false;
            if (txtIdAyudante.Text.Length == 0) return false;
            if (querys.ayudante_existe(Convert.ToInt32(txtIdAyudante.Text)) == 0) 
            {
                txtIdAyudante.ForeColor = Color.Red;
                return false; }
            txtIdAyudante.ForeColor = Color.Green;
            return true;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            btnBuscar.Enabled = false;
            txtId.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDeduccion.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtComision.Value = txtComision.Minimum;
            btnNuevo.Enabled = false;
            
          
            dtpFecha.Value = DateTime.Today;
            modo = Modo.Insertar;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
        }

        private void crear()
        {
            querys.crear_vendedor(
                txtNombre.Text,
                txtCedula.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtTelefono.Text, 
                Convert.ToInt32(txtComision.Value),
                Convert.ToInt32(txtDeduccion.Text), 
                dtpFecha.Value,
                Convert.ToInt32(txtIdAyudante.Text));
           
         
        }

        private void actualizar()        
        { 
            querys.actualizar_vendedor(
                Convert.ToInt32(txtId.Text),
                txtNombre.Text,
                txtCedula.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtTelefono.Text,
                Convert.ToInt32(txtComision.Value),
                Convert.ToInt32(txtDeduccion.Text),
                dtpFecha.Value,
                Convert.ToInt32(txtIdAyudante));
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        txtNombre.Focus();
                        break;
                    case Modo.Editar:
                        actualizar();
                        txtId.Focus();
                        break;
                    default:
                        break;
                }
                
            }

        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            txtId.Focus();
            btnModificar.Enabled = false;
            btnNuevo.Enabled = true;
            modo = Modo.Editar;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            dtpFecha.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                /*  querys.unico_ayudante(
                     Convert.ToInt32(txtId.Text),
                     ref ayudante.nombre,
                     ref ayudante.cedula,
                     ref ayudante.direccion,
                     ref ayudante.telefono,
                     ref ayudante.celular,
                     ref ayudante.comision,
                     ref ayudante.deduccion,
                     ref ayudante.fechaIngreso
                     );
                     */
                querys.unico_vendedor(Convert.ToInt32(txtId.Text),
                    ref vendedor.nombre,
                    ref vendedor.cedula,
                    ref vendedor.direccion,
                    ref vendedor.telefono,
                    ref vendedor.celular,
                    ref vendedor.comision,
                    ref vendedor.deduccion,
                    ref vendedor.fechaIngreso,
                    ref vendedor.idAyudante);

                if (vendedor.nombre == null) return;
                
                    txtNombre.Text = vendedor.nombre;
                    txtCedula.Text = vendedor.cedula;
                    txtDireccion.Text = vendedor.direccion;
                    txtTelefono.Text = vendedor.telefono;
                    txtCelular.Text = vendedor.celular;
                    txtComision.Value = Convert.ToDecimal(vendedor.comision);
                    txtDeduccion.Text = vendedor.deduccion.ToString();
                    dtpFecha.Value = vendedor.fechaIngreso.Value;
                
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)8) return;
            e.Handled = true;
        }
    }
}
