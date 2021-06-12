using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISION");

            int numero1, numero2, Resultado ;
            Console.WriteLine("DIVISOR");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIVIDENDO");
            numero2 = int.Parse(Console.ReadLine());
            Resultado = numero1 / numero2;
            Console.WriteLine("Resultado es " + Resultado);
            Console.ReadKey();



        }
    }
}
