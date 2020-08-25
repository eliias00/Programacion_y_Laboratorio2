using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
       public static void Main(string[] args)
        {
            int numero;
            Console.WriteLine(" Ingrese un numero para pidamide");
            numero = Convert.ToInt32(Console.ReadLine());
            mostrar(numero);

        }
        public static void mostrar ( int parametro)
        {
            for (int i = 0; i <= (parametro * 2); i = i + 2)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadKey();

        }
    }
}
