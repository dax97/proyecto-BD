using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace proyecto_dare_diseño
{
    public static class BDGeneral
    {


        public static MySqlConnection ObtenerConexion(this MySqlConnection conector)
        {
            MySqlConnection Conectar = new MySqlConnection("server=127.0.0.1; database = darediseno;Uid=root; pwd=Hybridmatrix1;SslMode = none;");
            Conectar.Open();
            return Conectar;
        }
        /*public static MySqlConnection ObtenerConexion(this MySqlConnection conector)
        {
            MySqlConnection Conectar = new MySqlConnection("server=192.168.1.101;port = 3306; database = prueba;Uid=root; pwd=root;SslMode = none;");
            Conectar.Open();
            return Conectar;
        }*/

    }

}
