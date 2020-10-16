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
    public partial class FRegAyudantes : Form
    {


        public FRegAyudantes()
        {
            InitializeComponent();
        }

        Modo modo;
        Ayudante ayudante;

        private void entrar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
        }
        private void salir(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }
        private void despejar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDeduccion.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtCedula.Clear();
            txtComision.Value = txtComision.Minimum;
            dtpFecha.Value = DateTime.Today;          
        }
        private bool verificar()
        {
            
            return true;
        }
        private void activar()
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name.Contains("txt") | item.Name.Contains("dtp"))
                item.Enabled = true;
            }
        }
        private void desactivar()
        {
            foreach (Control item in this.Controls)
            {
                if (item!= txtId & (item.Name.Contains("txt") | item.Name.Contains("dtp")))
                    item.Enabled = false ;
            }
        }

        private void crear()
        {
            querys.crear_ayudante(
                txtNombre.Text,
                txtCedula.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtTelefono.Text,
                Convert.ToInt32(txtComision.Value),
                Convert.ToInt32(txtDeduccion.Text),
                dtpFecha.Value);


        }

        private void actualizar()
        {
            querys.actualizar_ayudante(
                Convert.ToInt32(txtId.Text),
                txtNombre.Text,
                txtCedula.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtTelefono.Text,
                Convert.ToInt32(txtComision.Value),
                Convert.ToInt32(txtDeduccion.Text),
                dtpFecha.Value);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            activar();
            despejar();

            txtId.Enabled = false;
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            modo = Modo.Insertar;
            txtNombre.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        despejar();
                        txtNombre.Focus();
                        break;
                    case Modo.Editar:
                        actualizar();
                        desactivar();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        txtId.Focus();
                        btnModificar.Enabled = true;
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
            if (txtId.Text.Length > 0)
            {
                if (querys.ayudante_existe(Convert.ToInt32(txtId.Text)) == 1)
                {
                    querys.unico_ayudante(
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
                    btnModificar.Enabled = true;
                    txtNombre.Text = ayudante.nombre;
                    txtCedula.Text = ayudante.cedula;
                    txtDireccion.Text = ayudante.direccion;
                    txtTelefono.Text = ayudante.telefono;
                    txtCelular.Text = ayudante.celular;
                    txtComision.Value = Convert.ToDecimal(ayudante.comision);
                    txtDeduccion.Text = ayudante.deduccion.ToString();
                    dtpFecha.Value = ayudante.fechaIngreso.Value;
                }
                else
                {
                    btnModificar.Enabled = false;
                    despejar();
                    return;
                }



            }
            else
            {
                btnModificar.Enabled = false;
                despejar();
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnBuscar.Enabled = false;            
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            modo = Modo.Editar;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            activar();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         /*   if (txtId.Text.Length > 0)
            {             
                querys.unico_ayudante(
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

                if (ayudante.nombre == null) return;

                txtNombre.Text = ayudante.nombre;
                txtCedula.Text = ayudante.cedula;
                txtDireccion.Text = ayudante.direccion;
                txtTelefono.Text = ayudante.telefono;
                txtCelular.Text = ayudante.celular;
                txtComision.Value = Convert.ToDecimal(ayudante.comision);
                txtDeduccion.Text = ayudante.deduccion.ToString();
                dtpFecha.Value = ayudante.fechaIngreso.Value;

            }*/
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;            
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            txtId.Clear();
            despejar();
            desactivar();
            txtId.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) this.Close();
        }

        private void FRegAyudantes_Load(object sender, EventArgs e)
        {
            txtId.Focus();
        }

        private void txtDeduccion_TextChanged(object sender, EventArgs e)
        {
            if (txtDeduccion.Text.Length == 0) 
            {
                txtDeduccion.Text = "0";
            }
        }
    }   
}
