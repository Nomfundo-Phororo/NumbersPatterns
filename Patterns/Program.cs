using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a max number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a min number: ");
            int b= int.Parse(Console.ReadLine());
            //triangle of 5s
            for (int i = a; i >=b ; i--)
            {
                for (int k = i; k >= 1; k--)
                {
                    Console.Write(" " + k+",");

                }
                Console.WriteLine(" ");
            }
       
            for (int i = b; i <= a; i++)
            {
                for (int k = i; k >=1; k--)
                {
                    Console.Write(" " + k+",");

                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
