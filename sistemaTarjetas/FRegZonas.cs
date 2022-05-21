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

        Modo modo = Modo.Ver;
        Zona zona;
        private void FRegZonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_vendedor' Puede moverla o quitarla según sea necesario.
            this.v_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_vendedor);
            if (cbxVendedor.Items.Count > 0) cbxVendedor.SelectedIndex = 0;

        }

        private bool verificar() 
        
        {
            bool any = false;

            if (cbxVendedor.SelectedIndex == -1)
            {
                epVendedor.SetError(cbxVendedor, "Debe eligir un vendedor");
                any = true;
            }
            else epVendedor.SetError(cbxVendedor, "");

            if (txtDescripcion.Text.Length == 0)
            {
                epDescripcion.SetError(txtDescripcion, "No puede quedar en blanco");
                txtDescripcion.Focus();
                any = true;
            }
              else epDescripcion.SetError(txtDescripcion, "");
           
            if (!any) return true; 
            else return false;
        }

        private void entrar(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Yellow;
        }

        private void salir(object sender, EventArgs e) 
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void activar()
        {
            txtDescripcion.Enabled = true;
            cbxVendedor.Enabled = true;
        }

        private void desactivar()
        {
            txtDescripcion.Enabled = false;
            cbxVendedor.Enabled = false;
        }

        private void limpiar()
        {
            txtDescripcion.Clear();
        }

        private void cargar()
        {
            querys.unica_zona(zona.id, ref zona.descripcion, ref zona.idVendedor, ref zona.nombreVendedor);
            txtDescripcion.Text = zona.descripcion;
            cbxVendedor.SelectedValue = zona.idVendedor;           
        }

        private void asignar() 
        {
            zona.id = Convert.ToInt32(txtIdZona.Text);
            zona.descripcion = txtDescripcion.Text;
            zona.idVendedor = (int)cbxVendedor.SelectedValue;
            zona.nombreVendedor = cbxVendedor.Text;
        }

        private void crear() 
        {
            querys.crear_zona(Convert.ToInt32(cbxVendedor.SelectedValue), txtDescripcion.Text, ref zona.id);
            txtIdZona.Text = zona.id.ToString();
        }

        private void actualizar() 
        {
            querys.actualizar_zona(Convert.ToInt32(txtIdZona.Text),
                Convert.ToInt32(cbxVendedor.SelectedValue),
                txtDescripcion.Text);
        }

        private void guardar()
        {
            if (verificar())
            {
                switch (modo)
                {
                    case Modo.Insertar:
                        crear();
                        break;
                    case Modo.Editar:
                        actualizar();                      
                        break;
                    default:
                        break;
                }
                btnNueva.Enabled = true;
                btnModificar.Enabled = true;
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnBuscar.Enabled = true;
                txtIdZona.Enabled = true;
                btnEliminar.Enabled = true;
                asignar();
                desactivar();
                modo = Modo.Ver;
                txtIdZona.Focus();
                txtIdZona.SelectAll();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            modo = Modo.Insertar;
            txtIdZona.Clear();
            txtIdZona.Enabled = false;
            btnBuscar.Enabled = false;
            activar();
            limpiar();
            btnEliminar.Enabled = false;
            btnNueva.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;         
            cbxVendedor.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modo = Modo.Editar;
            activar();
            asignar();
            btnNueva.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnBuscar.Enabled = false;
            txtIdZona.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;         
            cbxVendedor.Focus();
        }

        private void txtIdZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtIdZona_TextChanged(object sender, EventArgs e)
        {
            if (modo == Modo.Ver)
            {
                limpiar();
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                if (txtIdZona.TextLength > 0 & txtIdZona.Text !="1")
                {
                    zona.id = Convert.ToInt32(txtIdZona.Text);
                    if (querys.zona_existe(zona.id) != 0)
                    {
                        cargar();
                        btnModificar.Enabled = true;
                        btnEliminar.Enabled = true;
                    }

                }
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            switch (modo)
            {
                case Modo.Insertar:
                    limpiar();
                    desactivar();
                    break;                    
                case Modo.Editar:
                    cargar();
                    desactivar();
                    btnEliminar.Enabled = true;
                    btnModificar.Enabled = true;
                    break;
                case Modo.Ver:
                    break;
                default:
                    break;
            }
            txtIdZona.Enabled = true;
            btnNueva.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnBuscar.Enabled = true;
            txtIdZona.Focus();
            txtIdZona.SelectAll();
            modo = Modo.Ver;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdZona.Text);
            int? asignado = querys.zona_asignada(id);
            if (asignado == 0)
            {
                querys.eliminar_zona(id, 1);
                txtDescripcion.Clear();
                txtIdZona.Clear();
                btnCancelar.Enabled = false;
                btnGuardar.Enabled = false;
                btnModificar.Enabled = false;
                btnNueva.Enabled = true;
                txtIdZona.Enabled = true;
                btnBuscar.Enabled = true;
                txtIdZona.Focus();
            }
            else
            {
                int vendedor = (int)cbxVendedor.SelectedValue;
                int? cantidad = querys.cantidad_zonas(vendedor);
                if (cantidad > 1)
                {
                    using (FReasignarZona fReasignar = new FReasignarZona())
                    {
                        fReasignar.zona = id;
                        fReasignar.vendedor = vendedor;
                       
                        if (fReasignar.ShowDialog() == DialogResult.OK)
                        {
                            int nuevo = fReasignar.seleccion;
                            querys.eliminar_zona(id, nuevo);
                            querys.eliminar_zona(id, 1);
                            txtDescripcion.Clear();
                            txtIdZona.Clear();
                            btnCancelar.Enabled = false;
                            btnGuardar.Enabled = false;
                            btnModificar.Enabled = false;
                            btnNueva.Enabled = true;
                            txtIdZona.Enabled = true;
                            btnBuscar.Enabled = true;
                            txtIdZona.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La zona seleccionada esta asignada a una tarjeta y no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbxVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FBuscarZona fBuscar = new FBuscarZona())
            {
                if (fBuscar.ShowDialog() == DialogResult.OK)
                {
                    zona.id = fBuscar.Id;
                    txtIdZona.Text = zona.id.ToString();
                }
            }
        }

        private void cbxVendedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbxVendedor.SelectedIndex != -1 & e.KeyCode == Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtDescripcion.TextLength >0  & e.KeyCode == Keys.Enter)
            {
                guardar();
            }
        }
    }
}
