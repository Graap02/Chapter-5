﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            displayDoWhileLoops();
        }
        public static void displayDoWhileLoops()
        {
            int count = 0;
            string response = null;

            do
            {
                do
                {
                    Console.WriteLine(count);
                    count++;
                } while (count < 10);

                do
                {
                    Console.WriteLine(count);
                    count--;
                } while (count > 0);

                Console.WriteLine("Would you like to count again? Y or N");
                    response = Console.ReadLine();
            } while ("Y" != response);
        }
        public static void displayWhileLoops()
        {
            int num = 100;
            int num2 = 0;
            bool again = true;
            while (num >= 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }

                num = num - 5;

            }
            while (num2 <= 10)
            {
                Console.WriteLine("Jayden");
                num2++;
            }
            num = 0;
            while (again == true)
            {
                num++;
                Console.WriteLine(num);
                if (num == 10)
                {
                    again = false;
                }
            }
        }
    }
}
