using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_dare_diseño
{
    public class Producto
    {
        public string modelo { get; set; }
        public string marca { get; set; }
        public string descripcion { get; set; }
        public int existencia { get; set; }
        public float precioIVA { get; set; }
        public float precioUnitario { get; set;}

        public Producto()
        {

        }


        public Producto(string Modelo, string Marca, string Descripcion, int Existencia, float PrecioIVA, float PrecioUnitario)
        {
            this.modelo = Modelo;
            this.marca = Marca;
            this.descripcion = Descripcion;
            this.existencia = Existencia;
            this.precioIVA = PrecioIVA;
            this.precioUnitario = PrecioUnitario;
        }
    }
}
