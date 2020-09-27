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
    public partial class FVendedores : Form
    {
        public Modo modo;
        public Vendedor vendedor;

        public FVendedores()
        {
            InitializeComponent();
        }

        private void FVendedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.seleccionAyudante' Puede moverla o quitarla según sea necesario.
            this.seleccionAyudanteTableAdapter.Fill(this.dsSistemaTarjetas.seleccionAyudante);
            if (this.modo == Modo.Editar)
            {
                queriesTableAdapter1.unico_vendedor(vendedor.id,
                    ref vendedor.nombre,
                    ref vendedor.cedula,
                    ref vendedor.direccion,
                    ref vendedor.telefono,
                    ref vendedor.celular,
                    ref vendedor.comision,
                    ref vendedor.deduccion,
                    ref vendedor.fechaIngreso,
                    ref vendedor.idAyudante);

                this.Text = "Vendedor con Id: " + vendedor.id.ToString();
                txtNombre.Text = vendedor.nombre;
                txtDireccion.Text = vendedor.direccion;
                mtxtCedula.Text = vendedor.cedula;
                mtxtTelefon.Text = vendedor.telefono;
                mtxtCelular.Text = vendedor.celular;
                mtxtComision.Text = vendedor.comision.ToString();
                mtxtDeduccion.Text = vendedor.deduccion.ToString();
                dtpFecha.Value = vendedor.fechaIngreso.Value;
                cbxAyudante.SelectedValue = vendedor.idAyudante;
            }
            else {
                cbxAyudante.SelectedValue = 1;
            }
        }

        private void crear() {
            decimal com = Convert.ToDecimal(mtxtComision.Text);
            decimal ded = Convert.ToDecimal(mtxtDeduccion.Text);

            queriesTableAdapter1.crear_vendedor_ca(
                txtNombre.Text,
                mtxtCedula.Text, 
                txtDireccion.Text,
                mtxtCelular.Text,
                mtxtTelefon.Text, 
                com, 
                ded,
                dtpFecha.Value,
                Convert.ToInt32(cbxAyudante.SelectedValue));
        }

        private void actualizar() {
            decimal com = Convert.ToDecimal(mtxtComision.Text);
            decimal ded = Convert.ToDecimal(mtxtDeduccion.Text);
            queriesTableAdapter1.actualizar_vendedor(
                vendedor.id,
                 txtNombre.Text,
                mtxtCedula.Text,
                txtDireccion.Text,
                mtxtCelular.Text,
                mtxtTelefon.Text,
                 com,
                ded,
                dtpFecha.Value,
                Convert.ToInt32(cbxAyudante.SelectedValue)
                );
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (this.modo)
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
        }
    }
}
