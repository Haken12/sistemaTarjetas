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
    public partial class FClientes : Form
    {

        public Cliente cliente;
        public Modo modo;
        public string direccion { get; set; }

        public FClientes()
        {
            InitializeComponent();
        }

        private void crear() {
            queriesTableAdapter1.crear_cliente(
                txtNombre.Text, 
                mtxtCedula.Text,
                txtDireccion.Text,
                mtxtTelefono.Text);
        }

        private void actualizar() {
            queriesTableAdapter1.actualizar_cliente(
                cliente.codigo,
                txtNombre.Text,
                mtxtCedula.Text,
                txtDireccion.Text,
                mtxtTelefono.Text);
        }

        private void FClientes_Load(object sender, EventArgs e)
        {
            if (modo == Modo.Editar) {
                queriesTableAdapter1.unico_cliente(cliente.codigo, ref cliente.nombre, ref cliente.cedula, ref cliente.direccion, ref cliente.telefono);
                txtNombre.Text = cliente.nombre;
                txtDireccion.Text = cliente.direccion;
               
                mtxtCedula.Text = cliente.cedula;
                mtxtTelefono.Text = cliente.telefono;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
        }
    }
}
