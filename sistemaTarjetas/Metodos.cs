using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;

namespace sistemaTarjetas
{
    public enum Modo
    { 
        Insertar,
        Editar,
        Ver
    }

    public struct Articulo
    {
      public  int? codigo;
        public string descripcion;
        public int? costo;
        public int? precio;
        public string unidad;
    }
    public struct Cliente {
        public int codigo;
        public string nombre;
        public string cedula;
        public string telefono;
        public string direccion;
    }
    public struct Ayudante {
        public int? id;
        public string nombre;
        public string cedula;
        public string direccion;
        public string telefono;
        public string celular;
        public int? comision;
        public int? deduccion;
        public DateTime? fechaIngreso;
    }
    public struct Tarjeta {
        public int? codigo;
        public string nombre;
        public string cedula;
        public string referencia;
        public string telefono;
        public string tipoPago;
        public DateTime? fehcaCreacion;
        public int? idVendedor;
        public int? idZona;       
    }
    public struct Vendedor
    {
        public int? id;
        public string nombre;
        public string cedula;
        public string direccion;
        public string telefono;
        public string celular;
        public int? comision;
        public int? deduccion;
        public DateTime? fechaIngreso;
        public int? idAyudante;
    }
    public struct Producto {
        public int codigo;
        public string descripcion;
        public decimal? precio;
        public decimal? costo;
        public int? existencias;

    }
    public struct Zona {
        public int? id;
        public string descripcion;
        public int? idVendedor;
        public string nombreVendedor;
    }
   /* public struct Despacho
    {
        public  int? numero;
        public int? idVendedor;
        public string observacion;
        public string nombreVendedor;
        public int? cantidadArticulos;
        public int? total;
        public DateTime? fecha;
    }*/
    public static class Metodos
    {
        public static int ToInt(this string str)
        {
            return Convert.ToInt32(str);
        }

        public static int? Numero(this TextBox box)
        {
            try
            {
                return box.Text.ToInt();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

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

        public static void SoloNumero(object sender, KeyPressEventArgs e) 
        
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == (char)8) return;
            e.Handled = true;
        }

        public static void t() {
           
        }
    }
}
