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
    public partial class FDevolucionTarjeta : Form
    {
        public FDevolucionTarjeta()
        {
            InitializeComponent();
        }
        public int? numeroRef;
        public int numeroVenta;
       
        public int numeroTarjeta;
        public int valorT =0;
        public DateTime fecha;
        private void FDevolucionTarjeta_Load(object sender, EventArgs e)
        {
            articulos_devolverTableAdapter.Fill(dsSistemaTarjetas.articulos_devolver,numeroVenta);
        }

        private void agregar() 
        {
            int numero = (int)dgvActuales.SelectedRows[0].Cells[0].Value;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int cantidadAct = (int)dgvActuales.SelectedRows[0].Cells[3].Value;
            int precio = (int)dgvActuales.SelectedRows[0].Cells[4].Value;
            if (cantidad > cantidadAct) 
            {
                MessageBox.Show("Cantidad supera existencias");
                return;
            }
            DataRow fila; 
            fila = dsSistemaTarjetas.devolver.FindByNumero(numero);
            if (fila == null) 
            {
            fila = dsSistemaTarjetas.devolver.NewRow();
                int indice = dgvActuales.SelectedRows[0].Index;
                int cantidadActual = (int)dsSistemaTarjetas.articulos_devolver.Rows[indice][3];
            fila[0] = dsSistemaTarjetas.articulos_devolver.Rows[indice][0];
            fila[1] = dsSistemaTarjetas.articulos_devolver.Rows[indice][1];
            fila[2] = dsSistemaTarjetas.articulos_devolver.Rows[indice][2];
            fila[3] = cantidad;
                fila[4] = cantidad * precio;
            dsSistemaTarjetas.devolver.Rows.Add(fila);
                dsSistemaTarjetas.articulos_devolver.Rows[indice][3] = cantidadActual - cantidad;
            }
            else 
            {
                
                int actual = (int)fila[3];
                int actualVenta = (int)dsSistemaTarjetas.articulos_devolver.Rows.Find(numero)[3];
                fila[3] = actual + cantidad;
                fila[4] = (actual + cantidad) * precio;
                dsSistemaTarjetas.articulos_devolver.Rows.Find(numero)[3] = actualVenta - cantidad;
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantidad.Text) > 0 & dgvActuales.SelectedRows[0] != null) agregar();
        }

        private void quitar() 
        {

            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int numero = (int)(dgvDevolver.SelectedCells[0].Value);
            DataRow filaA = dsSistemaTarjetas.articulos_devolver.Rows.Find(numero);
            DataRow filaB = dsSistemaTarjetas.devolver.FindByNumero(numero);
            int cantidadA = (int)filaA[3];
            int cantidadB = (int)filaB[3];
            int precio = (int)filaA[4];
            filaA[3] = cantidadA + cantidad;
            filaB[3] = cantidadB - cantidad;
            filaB[4] = (cantidadB - cantidad) * precio;
            if ((int)filaB[3] == 0) 
            {
                dsSistemaTarjetas.devolver.Rows.Remove(filaB);
            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtCantidad.Text) > 0) quitar();
        }

        private bool verificar() {
            if (dsSistemaTarjetas.devolver.Rows.Count == 0) return false;
            return true;
        }

        private void aceptar() {
            valorT = 0;
            foreach (DataRow rw in dsSistemaTarjetas.devolver.Rows)
            {
                valorT += (int)rw[4];
            }
            int? numDevolucion = 0;
            querys.nueva_devolucion_tarjeta(numeroTarjeta, fecha, valorT, numeroVenta, ref numDevolucion);
            int c = 1;
            foreach (DataRow row in dsSistemaTarjetas.devolver.Rows) 
            {
                int numero = (int)row[0];
                int codigo = (int)row[1];
                int cantidad = (int)row[3];
                int valor = (int)row[4];
                querys.nuevo_detalle_devolucion_tarjeta(
                    this.numeroTarjeta, numDevolucion, this.numeroVenta, numero, codigo, valor / cantidad, cantidad, valor);
                c++;
                
            }
            this.DialogResult = DialogResult.OK;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificar()) aceptar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Metodos.Confirmar()) 
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
