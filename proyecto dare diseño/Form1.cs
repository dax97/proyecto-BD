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
    public partial class Form1 : Form
    {
        private MySqlConnection conexion = new MySqlConnection();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           conexion.ConnectionString= "server = 192.168.1.77; database = inventarioadmn; uid = " + txt_user.Text + "; pwd = " + txt_pwd.Text + "; SslMode = none";
            try
            {
                conexion.Open();
                MessageBox.Show("conexion exitosa");
                mainmenu ad = new mainmenu();
                ad.Show();
                this.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
} 
