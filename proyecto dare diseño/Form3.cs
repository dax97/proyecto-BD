using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace proyecto_dare_diseño
{
    public partial class mainmenu : Form
    {
        private MySqlConnection conexion = new MySqlConnection();
        public mainmenu()
        {
            InitializeComponent();
        }

        private void desconectarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("desconectado");
                    Form1 RetornoLogin = new Form1();
                    RetornoLogin.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void inventario_Click(object sender, EventArgs e)
        {
            almacen_Dare AbrirAlmacen = new almacen_Dare();
            AbrirAlmacen.Show();
            this.Close();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}
