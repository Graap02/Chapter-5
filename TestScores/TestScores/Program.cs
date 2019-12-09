using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int score = 0;
            int count = 0;
            double average = 0.0;
            do
            {
                Console.WriteLine("Give me test scores that range from 0 to 100! (Enter 101 to stop giving scores)");
                score = Convert.ToInt32(Console.ReadLine());
                if (score < 0 && score < 100 && score != 101)
                {
                    Console.WriteLine("Not a valid score, do it again.");
                }
                else if (0 < score && score < 100 || score == 101)
                {
                    Console.WriteLine("Number entered, enter another.");
                    sum = sum + score;
                    count++;
                }



            } while (score != 101);
            sum = sum - 101;
            count--;
            average = sum / count;
            Console.WriteLine("Your sum is {0}, with an average of {1} and a count of {2} as the total test scores entered.", sum, average, count);
        }
    }
}
