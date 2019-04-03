using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_dare_diseño
{
    public class Producto
    {
        public int idproducto { get; set; }
        public string modelo { get; set; }
        public string marca { get; set; }
        public int existenciainicial { get; set; }
        public int existenciaactual { get; set; }
        public double preciounitario { get; set;}
        public int productoidproducto { get; set; }
        public string medicion1 { get; set; }
        public string medicion2 { get; set; }
        public string anotacion { get; set; }
        public string estante { get; set; }
        public int pedidoidpedido { get; set; }
        public int cantidad { get; set; }
        public double iva { get; set; }
        public double precioiva { get; set; }
        public double subtotal { get; set; }
        public DateTime fechaexpedicion { get; set; }
        public int idpedido { get; set; }
        public DateTime fechaentrega { get; set;}
        public string provedorrfc { get; set; }
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set;}
        public string email { get; set; }
        public int ventaidfactura { get; set; }
        public int idfactura { get; set; }
        public string clienterfc { get; set;}
        public string apellido { get; set; }
        public string empresa { get; set; }

        public Producto()
        {

        }


        public Producto(int Idproducto, string Modelo, string Marca, int Existenciainicial, int Existenciaactual,
        double Preciounitario)
        {

            this.idproducto = Idproducto;
            this.modelo = Modelo;
            this.marca = Marca;
            this.existenciainicial = Existenciainicial;
            this.existenciaactual = Existenciaactual;
            this.preciounitario = Preciounitario;
            /*this.productoidproducto = Productoidproducto;
            this.medicion1 = Medicion1;
            this.medicion2 = Medicion2;
            this.anotacion = Anotacion;
            this.estante = Estante;
            this.pedidoidpedido = Pedidoidpedido;
            this.cantidad = Cantidad;
            this.iva = Iva;
            this.precioiva = Precioiva;
            this.subtotal = Subtotal;
            this.fechaexpedicion = Fechaexpedicion;
            this.idpedido = Idpedido;
            this.fechaentrega = Fechaentrega;
            this.provedorrfc = provedorrfc;
            this.rfc = Rfc;
            this.nombre = nombre;
            this.telefono { get; set; }
            this.email = Email;
            this.ventaidfactura = Ventaidfactura;
            this.idfactura = Idfactura;
            this.clienterfc = Clienterfc;
            this.apellido = Apellido;
            this.empresa = Empresa;*/
    }
    }
}
