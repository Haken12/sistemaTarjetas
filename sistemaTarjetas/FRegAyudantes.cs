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

        Modo modo = Modo.Ver;
        Ayudante ayudante;

        private void entrar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.LightBlue;
        }
        private void salir(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }
        private void despejar()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDeduccion.Text = "0";
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
                dtpFecha.Value,
                ref ayudante.id);

            txtId.Text = ayudante.id.ToString();

        }
        private void cargar() 
        {
            ayudante.id = Convert.ToInt32(txtId.Text);
            querys.unico_ayudante(
                         ayudante.id,
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
        private void asignar() 
        {
            ayudante.id = Convert.ToInt32(txtId.Text);
            ayudante.nombre = txtNombre.Text;
            ayudante.cedula = txtCedula.Text;
            ayudante.direccion = txtDireccion.Text;
            ayudante.celular = txtCelular.Text;
            ayudante.telefono = txtTelefono.Text;
            ayudante.fechaIngreso = dtpFecha.Value;
            ayudante.comision = Convert.ToInt32(txtComision.Value);
            ayudante.deduccion = Convert.ToInt32(txtDeduccion.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            modo = Modo.Insertar;
            txtId.Clear();
            activar();
            despejar();
            btnEliminar.Enabled = false;
            txtId.Enabled = false;
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            txtNombre.Focus();
        }

        private void guardar() {
            if (verificar())
            {
                if (String.IsNullOrEmpty(txtDeduccion.Text.Trim())) txtDeduccion.Text = "0";
                
                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        btnNuevo.Enabled = true;                    
                        btnEliminar.Enabled = true;            
                        break;
                    case Modo.Editar:
                        actualizar();               
                        break;
                    default:
                        break;
                }               
                asignar();
                modo = Modo.Ver;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnModificar.Enabled = true;
                btnBuscar.Enabled = true;
                btnEliminar.Enabled = true;
                desactivar();
               
                txtId.Focus();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            guardar();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Ver)
            {
                despejar();
                if (txtId.Text.Length > 0)
                {
                    if (querys.ayudante_existe(Convert.ToInt32(txtId.Text)) == 1 & txtId.Text != "1")
                    {
                        cargar();
                        btnEliminar.Enabled = true;
                    }
                    else
                    {
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                       
                        return;
                    }
                }
                else
                {
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                    despejar();
                    return;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = Modo.Editar;
            txtId.Enabled = false;
            btnBuscar.Enabled = false;            
            btnModificar.Enabled = false;
            
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            asignar();
            activar();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
            using (FBuscarAyudante fBuscar = new FBuscarAyudante()) 
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    ayudante.id = fBuscar.Id;
                    txtId.Text = ayudante.id.ToString();
                    cargar();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (modo == Modo.Editar)
            {
                cargar();
                btnEliminar.Enabled = true;
            }
            else if (this.modo == Modo.Insertar)
            {                
                despejar();            
            }
            desactivar();
            btnNuevo.Enabled = true;
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            modo = Modo.Ver;
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

        private void txtDeduccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int? resultado = querys.ayudante_asignado(id);
            if (resultado == 0) {
                querys.eliminar_ayudante(id, 1);
                despejar();
                desactivar();
                btnModificar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnEliminar.Enabled = false;
                txtId.Enabled = true;
                txtId.Focus();
            }
            else
            {
                using (FReasignarAyudante fReasignar = new FReasignarAyudante())
                {
                    if (fReasignar.ShowDialog() == DialogResult.OK)
                    {
                        int nuevoId = fReasignar.seleccion;
                        querys.eliminar_ayudante(id, nuevoId);
                        despejar();
                        desactivar();
                        btnModificar.Enabled = false;
                        btnNuevo.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnEliminar.Enabled = false;
                        txtId.Enabled = true;
                        txtId.Focus();
                    }
                }
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNombre.Text.Length > 0 & e.KeyCode == Keys.Enter)
            {
                txtCedula.Focus();
            }
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCedula.MaskCompleted & e.KeyCode == Keys.Enter)
            {
                txtDireccion.Focus();
            }

        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDireccion.Text.Length > 0 & e.KeyCode == Keys.Enter)
            {
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTelefono.MaskCompleted & e.KeyCode == Keys.Enter)
            {
                txtComision.Focus();
            }
        }

        private void txtComision_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtComision.Value > 0 & e.KeyCode == Keys.Enter)
            {
                txtDeduccion.Focus();
            }
        }

        private void txtDeduccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDeduccion.Text.Length > 0 & e.KeyCode == Keys.Enter)
            {
                txtCelular.Focus();
            }
        }

        private void txtCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCelular.MaskCompleted & e.KeyCode == Keys.Enter)
            {
                guardar();
            }
        }
    }   
}
