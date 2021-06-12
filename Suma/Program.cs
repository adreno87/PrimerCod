using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MULTIPLICACION");
            int numero1, numero2, numero3, numero4,resultado ;
            Console.WriteLine("Primer Numero");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercer Numero");
            numero3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto Numero");
            numero4 = int.Parse(Console.ReadLine());

            resultado = numero1 * numero2 * numero3 * numero4;
            Console.WriteLine("Resultado es " + resultado);
            Console.ReadKey();
        }
    }
}
