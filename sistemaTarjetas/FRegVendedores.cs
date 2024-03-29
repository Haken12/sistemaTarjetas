﻿using System;
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
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe un nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus(); 
                return false;
            }
            if(txtAyudante.SelectedIndex < 0)
            {
                MessageBox.Show("Debe elegir un ayudante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAyudante.Focus();
                return false;
            }
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
            btnEliminar.Enabled = false;
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
                        btnEliminar.Enabled = true;
                        txtId.Focus();

                        break;
                    case Modo.Editar:
                        actualizar();
                        desactivar();
                        btnGuardar.Enabled = false;
                        btnCancelar.Enabled = false;
                        txtId.Focus();
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
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

        private void asignar()
        {

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
                if (querys.vendedor_existe(Convert.ToInt32(txtId.Text)) == 1 & txtId.Text !="1")
                {
                    cargar();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;                    
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
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;               
                return;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            btnEliminar.Enabled = true;
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
            buscar();
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
                    int cd = Convert.ToInt32(txtId.Text);
                    despejar();
                    txtId.Text = cd.ToString();
                    cargar();
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            int? resultado = querys.vendedor_asignado(id);
            if (resultado == 0)
            {
                querys.eliminar_vendedor(id);
                desactivar();
                txtId.Clear();
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                btnModificar.Enabled = false;
                btnNuevo.Enabled = true;
                txtId.Enabled = true;
                btnBuscar.Enabled = true;
                txtId.Focus();
            }
            else
            {
                if (MessageBox.Show("El vendedor seleccionado esta asignado en una o varias tarjetas, desea proceder?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    querys.eliminar_vendedor(id);
                    desactivar();
                    txtId.Clear();
                    btnGuardar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnNuevo.Enabled = true;
                    txtId.Enabled = true;
                    btnBuscar.Enabled = true;
                    txtId.Focus();
                }
            }
        }

        private void txtAyudante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void buscar()
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
                    btnEliminar.Enabled = true;
                }

            }
        }
        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtId.Text == String.Empty)
            {
                buscar();
            }
        }
    }   
}
