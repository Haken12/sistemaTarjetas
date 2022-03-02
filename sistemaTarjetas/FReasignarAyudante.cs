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
    public partial class FReasignarAyudante : Form
    {
        public int seleccion = -1;
        public int actual =0;
        public FReasignarAyudante()
        {
            InitializeComponent();
        }

        private void FReasignarAyudante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_ayudante' Puede moverla o quitarla según sea necesario.
            this.v_ayudanteTableAdapter.Fill(this.dsSistemaTarjetas.v_ayudante);
            bindingSource1.Filter = $"Id <> {actual}";
            cbxAyudantes.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.seleccion = (int)cbxAyudantes.SelectedValue;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbxAyudantes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
