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
    

    public partial class FMonto : Form
    {
        public int monto;

        public FMonto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar() == true)
            {
                this.monto = Convert.ToInt32(txtMonto.Text);

            }
            else { this.DialogResult = DialogResult.None; }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            { e.Handled = false; }
        }

        private void txtMonto_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
