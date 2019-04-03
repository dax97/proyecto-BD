using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace proyecto_dare_diseño
{
    class ProductoFUN
    {
        /*private MySqlConnection conexion = new MySqlConnection();*/
        public static List<Producto> consulta(string Modelo, string Marca)
        {
            MySqlConnection w = new MySqlConnection();
            w = w.ObtenerConexion();
            List<Producto> Tabla = new List<Producto>();
            MySqlCommand buscar = new MySqlCommand(string.Format("select * from producto where modelo like '" + Modelo + "' or marca like '" + Marca + "' "), BDGeneral.ObtenerConexion(w));
            MySqlDataReader Lector = buscar.ExecuteReader();
            while (Lector.Read())
            {
                Producto producto = new Producto();
                producto.idproducto = Lector.GetInt32(0);
                producto.modelo = Lector.GetString(1);
                producto.marca = Lector.GetString(2);
                producto.existenciainicial = Lector.GetInt32(3);
                producto.existenciaactual = Lector.GetInt32(4);
                producto.preciounitario = Lector.GetDouble(5);
                Tabla.Add(producto);
            }            
                 
         

            return Tabla;
        }

        public static int Entrada (int existencia, string modelo,int unidades)
        {
            MySqlConnection y = new MySqlConnection();
            y = y.ObtenerConexion();
            int retorno = 0;
            
            existencia = existencia+unidades;
            MySqlCommand registrarEntrada = new MySqlCommand(string.Format("Update almacen1 set EXISTENCIA = '"+existencia+"' where MODELO = '"+modelo+"'" ), BDGeneral.ObtenerConexion(y));

            retorno = registrarEntrada.ExecuteNonQuery();
            return retorno;
        }

        public static int salida(int existencia, string modelo, int unidades)
        {
            MySqlConnection y = new MySqlConnection();
            y = y.ObtenerConexion();
            int retorno = 0;

            existencia = existencia - unidades;
            MySqlCommand registrarEntrada = new MySqlCommand(string.Format("Update almacen1 set EXISTENCIA = '" + existencia + "' where MODELO = '" + modelo + "'"), BDGeneral.ObtenerConexion(y));

            retorno = registrarEntrada.ExecuteNonQuery();
            return retorno;
        }

        /*public static int Alta(Producto producto)
        {
            MySqlConnection x = new MySqlConnection();
            x = x.ObtenerConexion();
            int retorno = 0;
            MySqlCommand insertar = new MySqlCommand(string.Format("insert into almacen1 (MODELO, MARCA, DESCRIPCION, EXISTENCIA, PRECIOIVA, PRECIOUNI ) values ('{0}','{1}','{2}', '{3}', '{4}', '{5}')",
            producto.modelo, producto.marca, producto.descripcion, producto.existencia, producto.precioIVA, producto.precioUnitario), BDGeneral.ObtenerConexion(x));
            retorno = insertar.ExecuteNonQuery();
            return retorno;
        }*/

        public static int baja (string modelo, string marca)
        {
            MySqlConnection j = new MySqlConnection();
            j = j.ObtenerConexion();
            int retorno = 0;
            MySqlCommand borrar = new MySqlCommand(string.Format("delete from almacen1 where MODELO = '" + modelo + "' and MARCA = '" + marca + "' "), BDGeneral.ObtenerConexion(j));
            retorno = borrar.ExecuteNonQuery();
            return retorno;
        }

        public static void solonumeros(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo numeros");
            }
        }
        public static void solodecimales(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo decimales");
            }
        }

        public static void sololetras(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("solo letras");
            }
        }
    }
}