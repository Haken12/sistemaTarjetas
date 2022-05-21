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
    public partial class FReasignarZona : Form
    {
        public int zona = -1;
        public int vendedor = -1;
        public int seleccion = -1;
        public FReasignarZona()
        {
            InitializeComponent();
        }

       
        private void FReasignarZona_Load(object sender, EventArgs e)
        {
            v_zonaSTableAdapter.Fill(dsSistemaTarjetas.v_zonaS, vendedor, zona);
            cbxZona.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.seleccion = (int)cbxZona.SelectedValue;
        }

        private void cbxZona_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
