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
    public partial class NueUsuario : Form
    {
        public NueUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usuarioBox.Text == "" || contraBox.Text == "" || confirmBox.Text == "")
                MessageBox.Show("favor de ingresar usuario o contraseña");
            else
            {
                MySqlConnection x = new MySqlConnection();
                x = x.ObtenerConexion();
                MySqlCommand codigobaja = new MySqlCommand();
                codigobaja.Connection = x;

                if (contraBox.Text != confirmBox.Text)
                {
                    MessageBox.Show("contraseñas no coinciden");
                }
                else
                {
                      if (MessageBox.Show("¿Está seguro de eliminar este usuario?", "seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                      {
                          codigobaja.CommandText = ("delete from usuarios where nombre = '" + usuarioBox.Text + "' and password= '" + contraBox.Text + "' ");
                          codigobaja.ExecuteNonQuery();
                          MessageBox.Show("se elimino usuario correctamente");
                    }
                      else
                      {
                          MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                      }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usuarioBox.Text == "" || contraBox.Text == "" || confirmBox.Text == "")
                MessageBox.Show("favor de ingresar usuario o contraseña");
            else
            {
                MySqlConnection x = new MySqlConnection();
                x = x.ObtenerConexion();
                MySqlCommand codigoalta = new MySqlCommand();
                codigoalta.Connection = x;

                if (contraBox.Text == confirmBox.Text)
                {
                        if (MessageBox.Show("¿Está seguro de agregar este nuevo usuario?", "seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            codigoalta.CommandText = ("insert into usuarios (nombre,password) values ('"+usuarioBox.Text+"', '"+contraBox.Text+"')");
                            codigoalta.ExecuteNonQuery();
                            MessageBox.Show("se agrego nuevo usuario correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Se cancelo el alta de nuevo usuario", "alta Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                }
                else
                {
                    MessageBox.Show("contraseñas no coinciden");
                }
            }
        }

        private void contraBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se permiten espacios en una contraseña");

            }
        }

        private void confirmBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("no se permiten espacios en una contraseña");

            }
        }
    }
}