using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 101);
            }
            int total = 0;
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
                total += number;
            }

            //for (int rand = 1; rand < numbers.Length; rand++)
            //{
            //    total += rand;
            //}
            Console.WriteLine("合計： " + total);
        }
    }
}