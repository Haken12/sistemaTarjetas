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

       
    }
}
