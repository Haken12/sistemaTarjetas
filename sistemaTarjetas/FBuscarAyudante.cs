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
    public partial class FBuscarAyudante : Form
    {
        public int Id = -1;
        public FBuscarAyudante()
        {
            InitializeComponent();
        }

        private void FBuscarAyudante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_ayudante' Puede moverla o quitarla según sea necesario.
            this.v_ayudanteTableAdapter.Fill(this.dsSistemaTarjetas.v_ayudante);
           
        }

        private void rbId_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) 
            {
                txtId.Enabled = true;
                txtNombre.Enabled = false;
                bsBuscar.Filter = "";
                txtId.Focus();
            }
        }

        private void rbNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                txtId.Enabled = false;
                txtNombre.Enabled = true;
                bsBuscar.Filter = "";
                txtNombre.Focus();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtId.TextLength != 0) 
            {
                int id = Convert.ToInt32(txtId.Text);
                bsBuscar.Filter = $@"Id ={ id.ToString()}";
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            bsBuscar.Filter = "";
            if (txtNombre.Text.Length != 0) 
            {
                string nombre = txtNombre.Text;
                bsBuscar.Filter = $"Nombre LIKE '{nombre}%'";               
            }

           
        }

        private void dgvBuscar_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count != 0)
            {
                this.Id = (int)dgvBuscar.SelectedCells[0].Value;
            }
            else this.DialogResult = DialogResult.None;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if (Char.IsWhiteSpace(e.KeyChar)) return;
            e.Handled = true;
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}
