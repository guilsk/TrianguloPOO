using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloPOO
{
    internal class Triangulo
    {
        public int lado1;
        public int lado2;
        public int lado3;

        public bool IsTriangle()
        {
            if(lado1 + lado2 <= lado3)
                return false;
            else if(lado1 + lado3 <= lado2)
                return false;
            else if(lado2 + lado3 <= lado1)
                return false;
            else return true;
        }

        public void ConfereTipo(bool x)
        {
            if (x)
                if (lado1 == lado2 && lado2 == lado3)
                    Console.WriteLine("Triângulo Equilátero");
                else if ((lado1 == lado2 && lado3 != lado2) || (lado1 == lado3 && lado2 != lado3) || (lado2 == lado3 && lado1 != lado2))
                    Console.WriteLine("Triângulo Isóceles");
                else
                    Console.WriteLine("Triângulo Escaleno");
            else
                Console.WriteLine("Não é Triângulo");
        }
    }
}
