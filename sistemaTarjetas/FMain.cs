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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }

        private void ayudantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaAyudantes fListaAyudantes = new FListaAyudantes();
            fListaAyudantes.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaVendedores fListaVendedores = new FListaVendedores();
            fListaVendedores.Show();
        }

        private void zonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaZona fListaZona = new FListaZona();
            fListaZona.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaClientes fListaClientes = new FListaClientes();
            fListaClientes.Show();
        }

        private void controlDeTarjetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListaTarjetas fListaTarjetas = new FListaTarjetas();
            fListaTarjetas.Show();
        }
    }
}
