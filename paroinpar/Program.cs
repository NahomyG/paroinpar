using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paroinpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numero es par o impar
            int numero;

            double cociente, residuo;

            //cociente = 10 / 5;
            //residuo = 10 % 5;

            Console.WriteLine("Ingrese el valor del numero:  ");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 ==0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }
        }
    }
}
