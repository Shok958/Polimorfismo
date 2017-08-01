using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Circulo : Poligono
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un circulo");
            base.Dibujar();
        }
    }
}
