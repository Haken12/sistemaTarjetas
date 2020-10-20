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
    public partial class FRegZonas : Form
    {
        public FRegZonas()
        {
            InitializeComponent();
        }

        Modo modo;
        Zona zona;
        private void FRegZonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_vendedor' Puede moverla o quitarla según sea necesario.
            this.v_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_vendedor);
            if (cbxVendedor.Items.Count > 0) cbxVendedor.SelectedIndex = 0;

        }

        private bool verificar() 
        
        {
            if (cbxVendedor.SelectedIndex == -1) return false;
            return true;
        }

        private void entrar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
        }

        private void salir(object sender, EventArgs e) 
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void crear() 
        {
            querys.crear_zona(Convert.ToInt32(cbxVendedor.SelectedValue), txtDescripcion.Text);
        }
        private void actualizar() 
        {
            querys.actualizar_zona(Convert.ToInt32(txtIdZona.Text),
                Convert.ToInt32(cbxVendedor.SelectedValue),
                txtDescripcion.Text);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            txtIdZona.Clear();
            txtIdZona.Enabled = false;
            txtDescripcion.Enabled = true;
            cbxVendedor.Enabled = true;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            modo = Modo.Insertar;
            cbxVendedor.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            cbxVendedor.Enabled = true;
            btnBuscar.Enabled = false;
            txtDescripcion.Enabled = true;
            txtIdZona.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            modo = Modo.Editar;
            cbxVendedor.Focus();
            btnModificar.Enabled = false;
        }

        private void txtIdZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtIdZona_TextChanged(object sender, EventArgs e)
        {
            if ((txtIdZona.Text.Length == 0))
            {
                txtDescripcion.Clear();
                btnModificar.Enabled = false;
            }
            else if (querys.zona_existe(Convert.ToInt32(txtIdZona.Text)) == 0)
            {
                txtDescripcion.Clear();
                btnModificar.Enabled = false;
            }
            else
            {
                btnBuscar.Enabled = false;
                querys.unica_zona(Convert.ToInt32(txtIdZona.Text),
                    ref zona.descripcion,
                    ref zona.idVendedor,
                    ref zona.nombreVendedor);

                cbxVendedor.SelectedValue = zona.idVendedor;
                txtDescripcion.Text = zona.descripcion;
                btnModificar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNueva.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            txtDescripcion.Clear();
            cbxVendedor.SelectedIndex = 0;
            txtDescripcion.Enabled = false;
            cbxVendedor.Enabled = false;
            txtIdZona.Clear();
            txtIdZona.Enabled = true;
            txtIdZona.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificar()) 
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        txtDescripcion.Clear();
                        txtIdZona.Clear();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnNueva.Enabled = true;
                        txtIdZona.Enabled = true;
                        txtIdZona.Focus();
                        txtDescripcion.Enabled = false;
                        cbxVendedor.Enabled = false;
                        break;
                    case Modo.Editar:
                        actualizar();
                        btnCancelar.Enabled = false;
                        btnGuardar.Enabled = false;
                        btnModificar.Enabled = true;
                        btnBuscar.Enabled = true;

                        txtIdZona.Enabled = true;
                        txtIdZona.Focus();
                        txtDescripcion.Enabled = false;
                        cbxVendedor.Enabled = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
