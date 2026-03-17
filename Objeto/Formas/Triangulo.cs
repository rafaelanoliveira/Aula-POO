using System;
using System.Collections.Generic;
using System.Text;

namespace Formas
{
    internal class Triangulo
    {
        public double rlado;
        public double raltura;

        public void escalar(double rlado, double raltura)
        {
            Console.WriteLine("A área do triângulo é: " + (rlado*raltura / 2));
        }
    }
}
