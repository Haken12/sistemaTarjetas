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
    public partial class FTarjetas : Form
    {

        public Modo modo;
        public Tarjeta tarjeta;

        public FTarjetas()
        {
            InitializeComponent();
        }

        private void FTarjetas_Load(object sender, EventArgs e)
        {
            this.vVendedoresTableAdapter.Fill(this.dsSistemaTarjetas.vVendedores);
            this.vZonaTableAdapter.Fill(this.dsSistemaTarjetas.vZona);
            this.vClientesTableAdapter.Fill(this.dsSistemaTarjetas.vClientes);
            switch (modo)
            {
                case Modo.Insertar:
                    cbxFormaPago.SelectedIndex = 0;
                    break;
                case Modo.Editar:
                    queriesTableAdapter1.unica_tarjeta(
                        tarjeta.codigo,
                        ref tarjeta.codigoCliente,
                        ref tarjeta.fehcaCreacion,
                        ref tarjeta.idVendedor,
                        ref tarjeta.idZona,
                        ref tarjeta.tipoPago);

                    cbxCliente.SelectedValue = tarjeta.codigoCliente;
                    cbxVendedor.SelectedValue = tarjeta.idVendedor;
                    cbxZona.SelectedValue = tarjeta.idZona;
                    cbxFormaPago.SelectedText = tarjeta.tipoPago;
                    dtpFecha.Value = tarjeta.fehcaCreacion.Value;

                    break;
                default:
                    break;
            }
        }

        private void crear() {
            queriesTableAdapter1.crear_tarjeta(
                Convert.ToInt32(cbxCliente.SelectedValue),
                dtpFecha.Value,
                Convert.ToInt32(cbxVendedor.SelectedValue),
                Convert.ToInt32(cbxZona.SelectedValue),
                cbxFormaPago.Text
                );
        }

        private void actualizar() { 
            queriesTableAdapter1.actualizar_tarjeta(
                tarjeta.codigo,
                Convert.ToInt32(cbxCliente.SelectedValue),
                dtpFecha.Value,
                Convert.ToInt32(cbxVendedor.SelectedValue),
                Convert.ToInt32(cbxZona.SelectedValue),
                cbxFormaPago.Text
                );
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

        private void cbxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsZona.Filter = "id_vendedor =" + cbxVendedor.Text;
        }
    }
}
