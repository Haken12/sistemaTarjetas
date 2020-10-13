using System;
using System.Windows.Forms;

namespace sistemaTarjetas
{


    public partial class FAyudantes : Form
    {

        

        void crearAyudante() {

            decimal com = Convert.ToDecimal(cbxComision.Text );
            decimal ded = Convert.ToDecimal(txtDeduccion.Text);
            queriesTableAdapter1.crear_ayudante(
                  txtNombre.Text,
                  mtxtCedula.Text,
                  txtDireccion.Text,
                  mtxtCelular.Text,
                  mtxtTelefono.Text,
                  com,
                  ded,
                  dtpFechaIngreso.Value
                   );
        }

        void actualizarAyudante() {
            decimal com = Convert.ToDecimal(cbxComision.Text);
            decimal ded = Convert.ToDecimal(txtDeduccion.Text);
            queriesTableAdapter1.actualizar_ayudante(
                ayudante.id,
                 txtNombre.Text,
                  mtxtCedula.Text,
                  txtDireccion.Text,
                  mtxtCelular.Text,
                  mtxtTelefono.Text,
                  com,
                  ded,
                  dtpFechaIngreso.Value
                );
        }
        public Modo modo;

        public Ayudante ayudante;

        public FAyudantes()
        {
            InitializeComponent();
        }

        private void FAyudantes_Load(object sender, EventArgs e)
        {
            if (modo == Modo.Editar)
            {
                queriesTableAdapter1.unico_ayudante(ayudante.id,
                    ref ayudante.nombre,
                    ref ayudante.cedula,
                    ref ayudante.direccion,
                    ref ayudante.telefono,
                    ref ayudante.celular,
                    ref ayudante.comision,
                    ref ayudante.deduccion,
                    ref ayudante.fechaIngreso);

                txtNombre.Text = ayudante.nombre;
                mtxtCedula.Text = ayudante.cedula;
                txtDireccion.Text = ayudante.direccion;
                mtxtTelefono.Text = ayudante.telefono;
                mtxtCelular.Text = ayudante.celular;
                cbxComision.SelectedText = ayudante.comision.ToString();
                txtDeduccion.Text = ayudante.deduccion.ToString();
                dtpFechaIngreso.Value = ayudante.fechaIngreso.Value;

               
            }
            else if (modo == Modo.Insertar) {
           
              
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (modo == Modo.Insertar)
            {
                crearAyudante();
            }
            else if (modo == Modo.Editar) {
                actualizarAyudante();
            }
        }
    }
}
