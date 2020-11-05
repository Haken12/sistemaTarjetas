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
            txtAyudante.SelectedIndex = 0;
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
            querys.crear_vendedor(
                txtNombre.Text,
                txtCedula.Text,
                txtDireccion.Text,
                txtCelular.Text,
                txtTelefono.Text,
                Convert.ToInt32(txtComision.Value),
                Convert.ToInt32(txtDeduccion.Text),
                dtpFecha.Value,
                Convert.ToInt32(txtAyudante.SelectedValue)
                ,ref vendedor.id);
            txtId.Text = vendedor.id.ToString();

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
                Convert.ToInt32(txtAyudante.SelectedValue));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            activar();
            despejar();

            txtId.Enabled = false;
           
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
                if (String.IsNullOrEmpty(txtDeduccion.Text.Trim())) txtDeduccion.Text = "0";

                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        desactivar();
                        btnModificar.Enabled = true;
                        txtId.Enabled = true;
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        txtId.Focus();

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
        private void cargar() 
        {
            querys.unico_vendedor(
                         Convert.ToInt32(txtId.Text),
                         ref vendedor.nombre,
                         ref vendedor.cedula,
                         ref vendedor.direccion,
                         ref vendedor.telefono,
                         ref vendedor.celular,
                         ref vendedor.comision,
                         ref vendedor.deduccion,
                         ref vendedor.fechaIngreso,
                         ref vendedor.idAyudante
                         );
            txtNombre.Text = vendedor.nombre;
            txtCedula.Text = vendedor.cedula;
            txtDireccion.Text = vendedor.direccion;
            txtTelefono.Text = vendedor.telefono;
            txtCelular.Text = vendedor.celular;
            txtComision.Value = Convert.ToDecimal(vendedor.comision);
            txtDeduccion.Text = vendedor.deduccion.ToString();
            dtpFecha.Value = vendedor.fechaIngreso.Value;
            txtAyudante.SelectedValue = vendedor.idAyudante;
        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {
            despejar();
            if (txtId.Text.Length > 0)
            {
                if (querys.vendedor_existe(Convert.ToInt32(txtId.Text)) == 1)
                {
                    cargar();   
                    btnModificar.Enabled = true;                    
                }
                else
                {
                    btnModificar.Enabled = false;                   
                    return;
                }
            }
            else
            {
                btnModificar.Enabled = false;               
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
            using (FBuscarVendedor fBuscar = new FBuscarVendedor())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK) 
                {
                    int id = fBuscar.Id;
                    txtId.Text = id.ToString();
                    vendedor.id = id;
                    despejar();
                    cargar();
                    btnModificar.Enabled = true;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (this.modo)
            {
                case Modo.Insertar:
                    despejar();                 
                    desactivar();
                    break;
                case Modo.Editar:
                    despejar();
                    cargar();
                    desactivar();
                    break;
                default:
                    break;
            }
            btnGuardar.Enabled = false;            
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            txtId.Enabled = true;
            btnBuscar.Enabled = true;
            txtId.Clear();
            txtId.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) this.Close();
        }

        private void FRegAyudantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_ayudante' Puede moverla o quitarla según sea necesario.
            this.v_ayudanteTableAdapter.Fill(this.dsSistemaTarjetas.v_ayudante);
            txtId.Focus();
            if (txtAyudante.Items.Count > 0) txtAyudante.SelectedIndex = 0;
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
