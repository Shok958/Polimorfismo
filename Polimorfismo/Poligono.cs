using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Poligono
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public virtual void Dibujar()
        {
            Console.WriteLine("Dibujando");
        }
    }
}
