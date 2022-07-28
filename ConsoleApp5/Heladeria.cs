using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public  class Heladeria
    {
        public string Helados { get; set; }
        public string topping { get; set; }
        public int Precio { get; set; }
        public string getHelados()
        {
            return Helados;
        }
        public void setHelados(string nombre)
        {
            this.Helados = nombre;
        }
        public string gettopping()
        {
            return topping;
        }
        public void settopiing(string topping)
        {
            this.topping = topping;
        }
        public string getprecio()
        {
            return Helados;
        }
        public void setprecio(string nombre)
        {
            this.Helados = nombre;
        }
    }

}
 