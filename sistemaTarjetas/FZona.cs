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
    public partial class FZona : Form
    {
        public Modo modo;
        public Zona zona;

        public FZona()
        {
            InitializeComponent();
        }

        private void FZona_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.vendedor' Puede moverla o quitarla según sea necesario.
            this.vendedorTableAdapter.Fill(this.dsSistemaTarjetas.vendedor);

            switch (this.modo)
            {
                case Modo.Insertar:
                    cbxVendedor.SelectedIndex = 0;
                    break;
                case Modo.Editar:
                    queriesTableAdapter1.unica_zona(zona.id, ref zona.descripcion, ref zona.idVendedor, ref zona.nombreVendedor);
                    txtDescripcion.Text = zona.descripcion;
                    cbxVendedor.SelectedValue = zona.idVendedor;
                    this.Text = "Editar Zona con ID:" + zona.id.ToString();
                    break;
                default:
                    break;
            }

        }

        private void crear() {
            queriesTableAdapter1.crear_zona(Convert.ToInt32(cbxVendedor.SelectedValue), txtDescripcion.Text);
        }

        private void actualizar() {
            queriesTableAdapter1.actualizar_zona(zona.id,Convert.ToInt32( cbxVendedor.SelectedValue), txtDescripcion.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
