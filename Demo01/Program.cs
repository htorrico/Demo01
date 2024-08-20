using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Persona persona = new Persona
            {
                Nombres = "Hugo",
                Apellidos = "Torrico"              
            };
            persona.AsignarNombresCompletos();
            Console.WriteLine(persona.NombresCompletos);


            Console.WriteLine("Hola Mundo");
            Console.Read();
            
        }

        static void Rectangulo()
        {
            int area = 0;
            int perimetro = 0;
            Rectangulo rectangulo = new Rectangulo();
            rectangulo.Base = 10;
            rectangulo.Altura = 20;

            area = rectangulo.CalcularArea();
            perimetro = rectangulo.CalcularPerimetro();

            Console.WriteLine("El area es:");
            Console.WriteLine(area);
            Console.WriteLine("El perímetro es:");
            Console.WriteLine(perimetro);

        }
    }
}
