using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            int sum = 0;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Please enter a value >> ");
                value = Convert.ToInt32(Console.ReadLine());
                sum = sum + value;
            }
            Console.WriteLine("Your total is " + sum + ".");
        }
    }
}
