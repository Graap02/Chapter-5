using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            while (letter != '!')
            {
                Console.WriteLine("Please enter a lowercase letter >> ");
                letter = Convert.ToChar(Console.ReadLine());
                if (Char.IsLower(letter))
                {
                    Console.WriteLine("OK");
                }
                else if (Char.IsUpper(letter))
                {
                    Console.WriteLine("Error: that is not a lowercase letter.");
                }
                else if (letter == '!')
                {
                    Console.WriteLine("Goodbye :)");
                }
                else
                    Console.WriteLine("That literally isn't even a letter, specialty.");
            }
        }
    }
}
