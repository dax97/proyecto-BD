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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void validar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text == "" || txtpassword.Text == "")
                MessageBox.Show("favor de ingresar usuario o contraseña");
            else
            {
                MySqlConnection x = new MySqlConnection();
                x = x.ObtenerConexion();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = x;
                codigo.CommandText = ("select *from usuarios where nombre = '" + txtnombre.Text + "' and password= '" + txtpassword.Text + "' ");

                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.Read())
                {
                    this.Hide();
                    MessageBox.Show("bienvenido");
                    almacen_Dare sistema = new almacen_Dare();
                    sistema.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("usuario o contraseña incorrectos");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            
        }

        private void Nusuario_Click(object sender, EventArgs e)
        {
            NueUsuario altausu = new NueUsuario();
            altausu.ShowDialog();
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se permiten espacios en una contraseña");

            }
        }
    }
}
