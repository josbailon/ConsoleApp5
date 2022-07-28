using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class Topping : orden

    {
        public string nombre { get; set; }
        public int precio { get; set; }
        public Topping(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string getnombre()
        {
            return nombre;
        }
        public void setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public override double CaculoTotal()
        {
            return 0;
        }
    }
}
