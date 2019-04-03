using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_dare_diseño
{
    public partial class alta : Form
    {
       public alta()
        {
            InitializeComponent();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            /*if (Modelo2.Text == "" || Marca2.Text == "" || Descripcion2.Text == "" || Existencia2.Text == "" || PrecioIVA2.Text == "" || PrecioUni2.Text == "")
                    MessageBox.Show("favor de llenar todos los campos");
            else { 
                try
                {

                    Producto productoa = new Producto();
                    productoa.modelo = Modelo2.Text.Trim();
                    productoa.marca = Marca2.Text.Trim();
                    productoa.descripcion = Descripcion2.Text.Trim();
                    productoa.existencia = int.Parse(Existencia2.Text);
                    productoa.precioIVA = float.Parse(PrecioIVA2.Text);
                    productoa.precioUnitario = float.Parse(PrecioUni2.Text);
                    int resultado = ProductoFUN.Alta(productoa);
                    if (resultado > 0)
                    {
                        MessageBox.Show("Producto nuevo agregado con éxito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al guardar nuevo producto", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception m)
                {
                    MessageBox.Show("producto existente");
                }
            }*/
        }

        private void Existencia2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductoFUN.solonumeros(e);
        }

        private void PrecioIVA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductoFUN.solodecimales(e);
        }

        private void PrecioUni2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductoFUN.solodecimales(e);
        }

        private void alta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if(PrecioUni2.Text == "")
            {
                MessageBox.Show("favor de introducir una cantidad a calcular en precio unitario");
            }
            else
            {
                float x = 0;
                x = float.Parse(PrecioUni2.Text);
                x = x * 1.16f;
                PrecioIVA2.Text = x.ToString();
            }*/
        }

        private void Marca2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProductoFUN.sololetras(e);
        }
    }
}
