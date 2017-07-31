using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Cuadrado : Poligono
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibujando un cuadrado");
            base.Dibujar();
        }

        public override void Borrar()
        {
            Console.WriteLine("Borrando un cuadrado");
            base.Borrar();
        }
    }
}
