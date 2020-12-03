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
    public partial class FBuscarGasto : Form
    {
        public FBuscarGasto()
        {
            InitializeComponent();
        }

        public enum MBuscar
        {
            Unico,Total
        }

        public MBuscar md = MBuscar.Unico;
        public int seleccion = 0;
        public int vendedor = 0;
        public DateTime fechaI = DateTime.Today;
        public DateTime fechaF = DateTime.Today.AddDays(1);
        public int total = 0;
        private int calcularTotal()
        {
            int t = 0;
            foreach (DataGridViewRow fila in dgvBuscar.Rows)
            {
                t += (int)fila.Cells[3].Value;
            }          
            return t;
        }
        private void FBuscarGasto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.verGastos' Puede moverla o quitarla según sea necesario.
            this.verGastosTableAdapter.Fill(this.dsSistemaTarjetas.verGastos);
            // TODO: esta línea de código carga datos en la tabla 'dsSistemaTarjetas.v_vendedor' Puede moverla o quitarla según sea necesario.
            this.v_vendedorTableAdapter.Fill(this.dsSistemaTarjetas.v_vendedor);
            
            switch (md)
            {
                case MBuscar.Unico:
                    bsVendedor.Filter = "Not Id =1";
                    break;
                case MBuscar.Total:
                    bsVendedor.Filter = $"Id ={this.vendedor}";
                    break;
                default:
                    break;
            }

        }

        private void dgvBuscar_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtTotal.Text = calcularTotal().ToString();
        }

        private void dgvBuscar_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtTotal.Text = calcularTotal().ToString();
        }

        private void ckbVendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbVendedor.Checked)
            {
                cbxVendedor.Enabled = true;
                cbxVendedor.SelectedIndex = 0;
                bsBuscar.Filter = string.Format("Fecha >= #{0:yyyy-MM-dd}# And Fecha <= #{1:yyyy-MM-dd}# And IdVendedor ={2}", dtpInicial.Value, dtpFinal.Value, cbxVendedor.SelectedValue);
            }
            else
            {
                cbxVendedor.Enabled = false;
                bsBuscar.Filter = string.Format("Fecha >= #{0:yyyy-MM-dd}# And Fecha <= #{1:yyyy-MM-dd}#", dtpInicial.Value, dtpFinal.Value);
            }
        }

        private void cbxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckbVendedor.Checked)
            {
                if (cbxVendedor.SelectedIndex != -1)
                bsBuscar.Filter = string.Format("Fecha >= #{0:yyyy-MM-dd}# And Fecha <= #{1:yyyy-MM-dd}# And IdVendedor ={2}", dtpInicial.Value, dtpFinal.Value, cbxVendedor.SelectedValue);
            }
        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {
            dtpFinal.MinDate = dtpInicial.Value.AddDays(1);
            string filter = string.Format("Fecha >= #{0:yyyy-MM-dd}# And Fecha <= #{1:yyyy-MM-dd}#", dtpInicial.Value, dtpFinal.Value);
            if (ckbVendedor.Checked)
            {
                filter = filter + $" And IdVendedor ={cbxVendedor.SelectedValue}";
            }
            bsBuscar.Filter = filter;
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            dtpInicial.MaxDate = dtpFinal.Value.AddDays(-1);
            string filter = string.Format("Fecha >= #{0:yyyy-MM-dd}# And Fecha <= #{1:yyyy-MM-dd}#", dtpInicial.Value, dtpFinal.Value);
            if (ckbVendedor.Checked)
            {
                filter = filter + $" And IdVendedor ={cbxVendedor.SelectedValue}";
            }
            bsBuscar.Filter = filter;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            switch (md)
            {
                case MBuscar.Unico:
                    if (dgvBuscar.Rows.Count > 0)
                    {
                        seleccion = (int)dgvBuscar.SelectedCells[0].Value;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                    }
                    break;
                case MBuscar.Total:
                    if (dgvBuscar.Rows.Count > 0)
                    {
                       this.total = Convert.ToInt32(txtTotal.Text);
                    }
                    else
                    {
                        this.DialogResult = DialogResult.None;
                    }
                    break;
                default:
                    break;
            }
           
        }
    }
}
