using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }



        public Coordenada Coordenada1 { get; set; }
        public Coordenada Coordenada2 { get; set; }
        public Coordenada Coordenada3 { get; set; }
        public Coordenada Coordenada4 { get; set; }



        //public double CalcularDistancia(int a1, int b1, int a2, int b2)
        //{
        //    return Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        //}
        //void CalcularBase()
        //{
        //    Base = CalcularDistancia(x1, y1, x2, y2);
        //}
        //void CalcularAltura()
        //{
        //    Altura = CalcularDistancia(x2, y2, x3, y3);
        //}



        public double CalcularArea()
        {
            return Base * Altura;
        }
        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }


    }
}
