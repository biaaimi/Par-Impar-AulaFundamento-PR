using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {

            int NumeroDigitado;

            Console.Write("Insira um número: ");

            NumeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (NumeroDigitado % 2 == 0)
            {
                //Número Par
                Console.WriteLine("Par");
            }
            else
            {
                //Número Impar
                Console.WriteLine("Impar");
            }

            Console.ReadKey();
        }
    }
}
