using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace sistemaTarjetas
{
    public enum Modo
    { 
        Insertar,
        Editar
    }

    public struct Cliente {
        public int codigo;
        public string nombre;
        public string cedula;
        public string telefono;
        public string direccion;
    }
    public struct Ayudante {
        public int id;
        public string nombre;
        public string cedula;
        public string direccion;
        public string telefono;
        public string celular;
        public decimal? comision;
        public decimal? deduccion;
        public DateTime? fechaIngreso;
    }

    public struct Vendedor
    {
        public int id;
        public string nombre;
        public string cedula;
        public string direccion;
        public string telefono;
        public string celular;
        public decimal? comision;
        public decimal? deduccion;
        public DateTime? fechaIngreso;
        public int? idAyudante;
    }

    public struct Zona {
        public int id;
        public string descripcion;
        public int? idVendedor;
        public string nombreVendedor;
    }

    public static class Metodos
    {
        public static bool Confirmar()
        {
            DialogResult dr;
            dr = MessageBox.Show("Esta seguro?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK) {
                return true;
            }
            else 
            { return false; }
        }
    }
}
