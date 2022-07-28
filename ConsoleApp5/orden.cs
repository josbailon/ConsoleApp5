using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class orden
    {
        protected List<Heladeria> heladeria = new List<Heladeria>
            {
                new Heladeria { Helados = "Vainilla ", Precio = 1},
                new Heladeria { Helados = "mango", Precio = 1},
                new Heladeria { Helados = "fresa", Precio = 1}

            };
        public abstract double CaculoTotal();
    }

}